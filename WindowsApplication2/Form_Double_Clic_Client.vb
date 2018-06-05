Imports System
Imports System.IO
Imports System.Text
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class Form_Double_Clic_Client

    Private idClient As String
    Private Fuel As Boolean = False

    Public Sub New(ByVal id As String)

        ' This call is required by the designer.
        InitializeComponent()
        Me.MdiParent = Form_Main

        ' Add any initialization after the InitializeComponent() call.
        idClient = id
        If bdd.Read("SELECT DeuxSource FROM Client WHERE Id = " & idClient)(0)(0) = "1" Then
            Fuel = True
        End If

        Double_Clic_sur_Un_Client_Load()
    End Sub


    'Bouton Fermer
    Private Sub Button_fermer_Client_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    'Form imbriqué dans le Main
    Private Sub Double_Clic_sur_Un_Client_Load() Handles MyBase.Load
        '(sender As System.Object, e As System.EventArgs)
        Me.WindowState = FormWindowState.Maximized
        FillForm()

        Me.Show()
    End Sub

    Private Sub List_Factures_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles List_Factures.DoubleClick
        If Me.List_Factures.SelectedItems.Count = 1 Then
            Dim lvi As ListViewItem = Me.List_Factures.SelectedItems(0)
            Dim idFacture As String = lvi.Text

            Dim factureData As List(Of List(Of String)) = bdd.Read("SELECT * FROM FactureStokee WHERE Id = " & idFacture)

            Dim factPath As String
            Dim dialog As New FolderBrowserDialog()
            dialog.RootFolder = Environment.SpecialFolder.Desktop
            dialog.SelectedPath = "C:\"
            dialog.Description = "Choisir un dossier où enregistrer la facture"
            If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                factPath = dialog.SelectedPath
                CreateFacturePDF(factureData(0), factPath)
            End If

        End If
    End Sub

    Private Function MonthDifference(ByVal first As DateTime, ByVal second As DateTime) As Integer
        Return Math.Abs((first.Month - second.Month) + 12 * (first.Year - second.Year))
    End Function

    Private Sub DateTime_DateDebut_Consommation_ValueChanged(sender As Object, e As EventArgs) Handles DateTime_DateDebut_Consommation.ValueChanged
        UpdateChart()
    End Sub

    Private Sub DateTime_DateFin_Consommation_ValueChanged(sender As Object, e As EventArgs) Handles DateTime_DateFin_Consommation.ValueChanged
        UpdateChart()
    End Sub

    Private Sub ComboBoxNumCompteur_Conso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNumCompteur_Conso.SelectedIndexChanged
        UpdateChart()
    End Sub

    Private Sub DateTime_DateDebut_Factures_ValueChanged(sender As Object, e As EventArgs) Handles DateTime_DateDebut_Factures.ValueChanged
        UpdateFactList()
    End Sub

    Private Sub DateTime_DateFin_Factures_ValueChanged(sender As Object, e As EventArgs) Handles DateTime_DateFin_Factures.ValueChanged
        UpdateFactList()
    End Sub

    Private Sub ComboBoxNumCompteur_Fact_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNumCompteur_Fact.SelectedIndexChanged
        UpdateFactList()
    End Sub

    Private Sub ComboBoxAdresse_Fact_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAdresse_Fact.SelectedIndexChanged
        UpdateFactList()
    End Sub

    Private Sub Enregister_Click(sender As Object, e As EventArgs) Handles Enregister.Click
        UpdateInfo()
    End Sub

    Private Sub Button_Supprimer_Compteurs_Click(sender As Object, e As EventArgs)
        If Me.List_Compteur.SelectedItems.Count = 1 Then
            If MsgBox("Voulez-vous vraiment suprimer cet abonnement ?", MsgBoxStyle.YesNo, "Comfirmation") = DialogResult.Yes Then
                Dim lvi As ListViewItem = Me.List_Compteur.SelectedItems(0)
                Dim idCompteur As String = lvi.Text

                bdd.Modify("DELETE FROM Abonnement WHERE IdCompteur = " & idCompteur)

                Dim data As List(Of List(Of String))
                Dim item As ListViewItem

                List_Compteur.Items.Clear()

                data = bdd.Read("SELECT cp.NumCompteur, cp.AdresseLivraison, pu.puissance,  pu.DateDebut FROM Compteur cp INNER JOIN Puissance pu ON cp.Id = pu.IdCompteur INNER JOIN Abonnement ab ON cp.Id = ab.IdCompteur WHERE ab.IdClient = " & idClient)
                For Each line In data
                    item = New ListViewItem()
                    item.Text = line(0)
                    For i As Integer = 1 To 3
                        item.SubItems.Add(line(i))
                    Next
                    List_Compteur.Items.Add(item)
                Next
            End If
        End If
    End Sub

    Private Sub Button_Ajouter_Compteurs_Click(sender As Object, e As EventArgs) Handles Button_Ajouter_Compteurs.Click
        Dim formAddAbo As Form_Modifier_Abonnement = New Form_Modifier_Abonnement(idClient)
    End Sub

    Private Sub Button_Modifier_Compteurs_Click(sender As Object, e As EventArgs) Handles Button_Modifier_Compteurs.Click
        If Me.List_Compteur.SelectedItems.Count = 1 Then
            Dim lvi As ListViewItem = Me.List_Compteur.SelectedItems(0)
            Dim idCompteur As String = lvi.Text
            Dim formAddAbo As Form_Modifier_Abonnement = New Form_Modifier_Abonnement(idClient, idCompteur)
        End If
    End Sub





    Private Sub CreateFacturePDF(ByVal data As List(Of String), ByVal path As String)
        If Fuel Then
            Dim PdfTemplate As String = "facture_mise_en_situation_form.pdf"

            Dim newFile As String = path & "\" & data(1).ToString & "_" & data(5) & ".pdf"

            Dim PdfReader As New PdfReader(PdfTemplate)

            Dim PdfStamper As New PdfStamper(PdfReader, New FileStream(newFile, FileMode.Create))

            Dim pdfFormFields As AcroFields = PdfStamper.AcroFields
            pdfFormFields.SetField("libelle_client", data(3) & " " & data(5) & " " & data(4))
            pdfFormFields.SetField("adresse_fact", data(6))
            pdfFormFields.SetField("cp_fact", data(8))
            pdfFormFields.SetField("ville_fact", data(7))
            pdfFormFields.SetField("libelle", "FACTURE du " & Convert.ToDateTime(data(51)).ToString("d MMMM yyyy") & " au " & Convert.ToDateTime(data(52)).ToString("d MMMM yyyy"))
            pdfFormFields.SetField("date_fact", DateAndTime.Today.ToString("d MMMM yyyy"))
            pdfFormFields.SetField("num_fact", data(0))
            pdfFormFields.SetField("num_client", data(2))
            pdfFormFields.SetField("nom_client", data(5) & " " & data(4))
            pdfFormFields.SetField("adresse_livraison", data(17))
            pdfFormFields.SetField("puissance", data(22))
            pdfFormFields.SetField("date_releve_th_ancien", Convert.ToDateTime(data(51)).ToString("dd/mm/yyyy"))
            pdfFormFields.SetField("date_releve_th_nouveau", Convert.ToDateTime(data(52)).ToString("dd/mm/yyyy"))
            pdfFormFields.SetField("index_ancien", data(33))
            pdfFormFields.SetField("index_nouveau", data(36))
            pdfFormFields.SetField("conso", data(55))
            pdfFormFields.SetField("conso2", data(55))
            pdfFormFields.SetField("date_entree_abo", data(14))
            pdfFormFields.SetField("date_sortie_abo", data(15))
            Dim dureeMois As Integer = MonthDifference(Convert.ToDateTime(data(14)), Convert.ToDateTime(data(15)))
            pdfFormFields.SetField("duree_mois", dureeMois.ToString)
            pdfFormFields.SetField("tarif_r1", data(45))
            pdfFormFields.SetField("tarif_r2", data(46))
            pdfFormFields.SetField("r1_ht", data(58))
            pdfFormFields.SetField("r2_ht", data(60))
            pdfFormFields.SetField("total_ht", data(62))
            pdfFormFields.SetField("tva", data(47))
            pdfFormFields.SetField("tva2", data(47))
            pdfFormFields.SetField("r1_ttc", data(59))
            pdfFormFields.SetField("r2_ttc", data(61))
            pdfFormFields.SetField("total_ttc", data(63))

            PdfStamper.FormFlattening = True

            PdfStamper.Close()
        Else
            Dim PdfTemplate As String = "facture_mise_en_situation_form.pdf"

            Dim newFile As String = path & "\" & data(1).ToString & "_" & data(5) & ".pdf"

            Dim PdfReader As New PdfReader(PdfTemplate)

            Dim PdfStamper As New PdfStamper(PdfReader, New FileStream(newFile, FileMode.Create))

            Dim pdfFormFields As AcroFields = PdfStamper.AcroFields
            pdfFormFields.SetField("libelle_client", data(3) & " " & data(5) & " " & data(4))
            pdfFormFields.SetField("adresse_fact", data(6))
            pdfFormFields.SetField("cp_fact", data(8))
            pdfFormFields.SetField("ville_fact", data(7))
            pdfFormFields.SetField("libelle", "FACTURE du " & Convert.ToDateTime(data(51)).ToString("d MMMM yyyy") & " au " & Convert.ToDateTime(data(52)).ToString("d MMMM yyyy"))
            pdfFormFields.SetField("date_fact", DateAndTime.Today.ToString("d MMMM yyyy"))
            pdfFormFields.SetField("num_fact", data(0))
            pdfFormFields.SetField("num_client", data(2))
            pdfFormFields.SetField("nom_client", data(5) & " " & data(4))
            pdfFormFields.SetField("adresse_livraison", data(17))
            pdfFormFields.SetField("puissance", data(22))
            pdfFormFields.SetField("date_releve_th_ancien", Convert.ToDateTime(data(51)).ToString("dd/mm/yyyy"))
            pdfFormFields.SetField("date_releve_th_nouveau", Convert.ToDateTime(data(52)).ToString("dd/mm/yyyy"))
            pdfFormFields.SetField("index_ancien", data(33))
            pdfFormFields.SetField("index_nouveau", data(36))
            pdfFormFields.SetField("conso", data(55))
            pdfFormFields.SetField("conso2", data(55))
            pdfFormFields.SetField("date_entree_abo", data(14))
            pdfFormFields.SetField("date_sortie_abo", data(15))
            Dim dureeMois As Integer = MonthDifference(Convert.ToDateTime(data(14)), Convert.ToDateTime(data(15)))
            pdfFormFields.SetField("duree_mois", dureeMois.ToString)
            pdfFormFields.SetField("tarif_r1", data(45))
            pdfFormFields.SetField("tarif_r2", data(46))
            pdfFormFields.SetField("r1_ht", data(58))
            pdfFormFields.SetField("r2_ht", data(60))
            pdfFormFields.SetField("total_ht", data(62))
            pdfFormFields.SetField("tva", data(47))
            pdfFormFields.SetField("tva2", data(47))
            pdfFormFields.SetField("r1_ttc", data(59))
            pdfFormFields.SetField("r2_ttc", data(61))
            pdfFormFields.SetField("total_ttc", data(63))

            PdfStamper.FormFlattening = True

            PdfStamper.Close()
        End If
    End Sub

    Private Sub FillForm()
        Dim data As List(Of List(Of String))
        Dim item As ListViewItem

        'Tab Information
        data = bdd.Read("SELECT * FROM Client WHERE Id = " & idClient)
        TextBox_Id_Informations.Text = data(0)(0)
        Select Case data(0)(1)
            Case "M."
                ComboBox_civilite.SelectedIndex = 0
            Case "Mme."
                ComboBox_civilite.SelectedIndex = 1
        End Select
        Textbox_Nom_Information.Text = data(0)(3)
        TextBox_Prenom_Information.Text = data(0)(2)
        TextBox_Adresse1_Information.Text = data(0)(4)
        TextBox_CodePostal.Text = data(0)(6)
        TextBox_ville.Text = data(0)(5)
        TextBox_mail.Text = data(0)(7)
        If (data(0)(8) = "1") Then
            CheckBox_Courrier.Checked = True
        End If
        If (data(0)(9) = "1") Then
            CheckBox_mail.Checked = True
        End If

        'Tab Compteur
        data = bdd.Read("SELECT cp.NumCompteur, cp.AdresseLivraison, pu.puissance,  pu.DateDebut FROM Compteur cp INNER JOIN Puissance pu ON cp.Id = pu.IdCompteur INNER JOIN Abonnement ab ON cp.Id = ab.IdCompteur WHERE ab.IdClient = " & idClient)
        For Each line In data
            item = New ListViewItem()
            item.Text = line(0)
            For i As Integer = 1 To 3
                item.SubItems.Add(line(i))
            Next
            List_Compteur.Items.Add(item)
        Next

        'Tab Facture
        DateTime_DateDebut_Factures.Value = DateAndTime.Today.AddMonths(-6)
        DateTime_DateFin_Factures.Value = DateAndTime.Today
        data = bdd.Read("SELECT Id, DateFacture, NumCompteurBois, AdresseFacturation, CoutTotalTTC FROM FactureStockee WHERE IdClient = " & idClient & " AND DateFacture < '" & DateTime_DateFin_Factures.Text & "' AND DateFacture > '" & DateTime_DateDebut_Factures.Text & "'")
        For Each line In data
            item = New ListViewItem()
            item.Text = line(0)
            For i As Integer = 1 To 4
                item.SubItems.Add(line(i))
            Next
            List_Compteur.Items.Add(item)
        Next
        data = bdd.Read("SELECT NumCompteurBois, NumCompteurBois FROM FactureStockee WHERE IdClient = " & idClient & " AND DateFacture < '" & DateTime_DateFin_Factures.Text & "' AND DateFacture > '" & DateTime_DateDebut_Factures.Text & "' GROUP BY NumCompteurBois")
        ComboBoxNumCompteur_Fact.Items.Add("")
        ComboBoxNumCompteur_Conso.Items.Add("")
        For Each line In data
            ComboBoxNumCompteur_Fact.Items.Add(line(0))
            ComboBoxNumCompteur_Conso.Items.Add(line(0) & " - Bois")
            If Fuel Then
                ComboBoxNumCompteur_Fact.Items.Add(line(1))
                ComboBoxNumCompteur_Conso.Items.Add(line(1) & " - Fuel")
            End If
        Next
        data = bdd.Read("SELECT AdresseFacturation FROM FactureStockee WHERE IdClient = " & idClient & " AND DateFacture < '" & DateTime_DateFin_Factures.Text & "' AND DateFacture > '" & DateTime_DateDebut_Factures.Text & "' GROUP BY AdresseFacturation")
        For Each line In data
            ComboBoxAdresse_Fact.Items.Add(line(0))
        Next

        'Tab Conso
        DateTime_DateDebut_Consommation.Value = DateAndTime.Today.AddMonths(-6)
        DateTime_DateFin_Consommation.Value = DateAndTime.Today
        Chart_Consommation.Series("Conso").Points.Clear()
    End Sub

    Private Sub UpdateChart()
        Dim data As List(Of List(Of String))
        If (ComboBoxNumCompteur_Conso.Text <> "") Then
            If Fuel Then
                Dim query As String = "SELECT DateFacture, ConsoBois, ConsoFuel FROM FactureStockee WHERE IdClient = " & idClient & " AND DateFacture < '" & DateTime_DateFin_Factures.Text & "' AND DateFacture > '" & DateTime_DateDebut_Factures.Text & "'"
                query = query & " AND (NumCompteurBois = '" & ComboBoxNumCompteur_Conso.Text & "' OR NumCompteurFuel = '" & ComboBoxNumCompteur_Conso.Text & "')"

                data = bdd.Read(query)
                Chart_Consommation.Series("Conso").Points.Clear()
                For Each line In data
                    Chart_Consommation.Series("Conso").Points.AddXY(line(0), line(1))
                Next

            Else
                Dim query As String = "SELECT DateFacture, ConsoBois FROM FactureStockee WHERE IdClient = " & idClient & " AND DateFacture < '" & DateTime_DateFin_Factures.Text & "' AND DateFacture > '" & DateTime_DateDebut_Factures.Text & "'"
                If (ComboBoxNumCompteur_Conso.Text <> "") Then
                    query = query & " AND NumCompteurBois = '" & ComboBoxNumCompteur_Conso.Text & "'"
                End If

                data = bdd.Read(query)
                Chart_Consommation.Series("Conso").Points.Clear()
                For Each line In data
                    Chart_Consommation.Series("Conso").Points.AddXY(line(0), line(1))
                Next
            End If
        Else
            Chart_Consommation.Series("Conso").Points.Clear()
        End If

    End Sub

    Private Sub UpdateFactList()
        Dim data As List(Of List(Of String))
        Dim item As ListViewItem

        Dim query As String = "SELECT Id, DateFacture, NumCompteurBois, NumCompteurFuel, AdresseFacturation, CoutTotalTTC FROM FactureStockee WHERE IdClient = " & idClient & " AND DateFacture < '" & DateTime_DateFin_Factures.Text & "' AND DateFacture > '" & DateTime_DateDebut_Factures.Text & "'"
        If (ComboBoxNumCompteur_Fact.Text <> "") Then
            query = query & " AND (NumCompteurBois = '" & ComboBoxNumCompteur_Fact.Text & "' OR NumCompteurBois = '" & ComboBoxNumCompteur_Fact.Text & "')"
        End If
        If (ComboBoxAdresse_Fact.Text <> "") Then
            query = query & " AND AdresseFacturation = '" & ComboBoxAdresse_Fact.Text & "'"
        End If

        data = bdd.Read(query)
        List_Compteur.Items.Clear()
        For Each line In data
            item = New ListViewItem()
            item.Text = line(0)
            If Fuel Then
                item.SubItems.Add(line(1) & " & " & line(2))
            Else
                item.SubItems.Add(line(1))
            End If
            item.SubItems.Add(line(3))
            item.SubItems.Add(line(4))
            List_Compteur.Items.Add(item)
        Next

    End Sub

    Private Sub UpdateInfo()
        Dim query As String = "UPDATE Client SET Civ = '" & ComboBox_civilite.Text & "', Nom = '" & Textbox_Nom_Information.Text & "', Prenom = '" & TextBox_Prenom_Information.Text & "', AdresseFacturation = '" & TextBox_Adresse1_Information.Text & "', CodePostal = '" & TextBox_CodePostal.Text & "', Ville = '" & TextBox_ville.Text & "', AdresseMail = '" & TextBox_mail.Text & "'"
        If CheckBox_Courrier.Checked Then
            query = query & ", FacturePostal = 1"
        Else
            query = query & ", FacturePostal = 0"
        End If
        If CheckBox_mail.Checked Then
            query = query & ", FactureMail = 1"
        Else
            query = query & ", FactureMail = 0"
        End If
        query = query & " WHERE Id = " & idClient
        bdd.Modify(query)
    End Sub
End Class