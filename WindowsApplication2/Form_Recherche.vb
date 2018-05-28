Imports MySql.Data

Public Class Form_Recherche

    'A l'ouverture de la fenetre

    Private Sub Fenetre_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized  'Form imbriqué dans le Main

        'Appel de toutes les fonctions de chargement des tableaux

        Me.Releve_Charger()
        Me.Client_Charger()
        Me.Compteur_Charger()
        Me.Tarifs_Charger()

    End Sub

    'A l'initialisation

    Public Sub New()

        InitializeComponent()
        Me.MdiParent = Form_Main    'Form imbriqué dans le Main
        Me.Show()

    End Sub

    'Chargement des Relevés

    Private Sub Releve_Charger()

        'Chargement initial de tout les Relevés

        Dim Donnees = bdd.Read("SELECT Id, NumCompteur, DATE_FORMAT(DateReleveReel, ""%d/%c/%Y""), DATE_FORMAT(DateReleveTh, ""%d/%c/%Y""), IndexAncien, IndexNouveau FROM telereleve ")

        For i = 0 To Donnees.Count() - 1
            Dim Line As ListViewItem = New ListViewItem(Donnees(i).ToArray)
            Tab_releves.Items.Add(Line)
        Next i

    End Sub

    'Chargement des Clients

    Private Sub Client_Charger()

        'Chargement initial de tout les clients

        Dim Donnees = bdd.Read("SELECT Id, Civ, Nom, Prenom, AdresseFacturation, Ville, CodePostal, AdresseMail FROM client ")

        For i = 0 To Donnees.Count() - 1
            Dim Line As ListViewItem = New ListViewItem(Donnees(i).ToArray)
            Tab_Clients.Items.Add(Line)
        Next i


    End Sub

    'Chargement des Compteurs

    Private Sub Compteur_Charger()

        'Chargement initial de tout les compteurs

        Dim Donnees = bdd.Read("SELECT cp.NumCompteur, cl.Nom, cp.AdresseLivraison, pu.Puissance 
                                FROM dbchaufferie.compteur cp
                                INNER JOIN dbchaufferie.abonnement ab ON cp.Id=ab.IdCompteur
                                INNER JOIN dbchaufferie.client cl ON cl.Id=ab.IdClient
                                INNER JOIN dbchaufferie.puissance pu ON pu.IdCompteur=cp.Id ")

        For i = 0 To Donnees.Count() - 1
            Dim Line As ListViewItem = New ListViewItem(Donnees(i).ToArray)
            Tab_compteur.Items.Add(Line)
        Next i
    End Sub

    'Chargement des Tarifs

    Private Sub Tarifs_Charger()

        'Chargement initial de tout les compteurs

        Dim Donnees = bdd.Read("SELECT r1, r2, TVA, DATE_FORMAT(DateDebut, ""%d/%c/%Y"") FROM tarif")

        'Affichage dans le tableau
        For i = 0 To Donnees.Count() - 1
            Dim Line As ListViewItem = New ListViewItem(Donnees(i).ToArray)
            List_Coutdefac.Items.Add(Line)
        Next i

        'Affichage des tarifs en vigueur dans les TextBox
        TextBox_Coutdefac_Actuel_R1.Text = Donnees(Donnees.Count - 1)(0)
        TextBox_Coutdefac_Actuel_R2.Text = Donnees(Donnees.Count - 1)(1)
        TextBox_Coutdefac_Actuel_TVA.Text = Donnees(Donnees.Count - 1)(2)

    End Sub

    'Recherche de Compteurs

    Private Sub Compteur_Recherche() Handles TextBox_Nomcompteur_Compteur.TextChanged,
                                             TextBox_Nomclient_Compteur.TextChanged,
                                             TextBox_Adresse_Compteur.TextChanged

        'Suppression de toutes les lignes du Tableau
        Tab_compteur.Items.Clear()

        'Déclaration des Variables
        Dim Condition As New List(Of String)
        Dim ConsWhere As String = ""

        'Création de la Commande WHERE
        If TextBox_Nomcompteur_Compteur.Text <> "" Then
            Condition.Add("cp.NumCompteur = '" & TextBox_Nomcompteur_Compteur.Text & "'")
        End If
        If TextBox_Nomclient_Compteur.Text <> "" Then
            Condition.Add("cl.Nom LIKE '" & TextBox_Nomclient_Compteur.Text & "%'")
        End If
        If TextBox_Adresse_Compteur.Text <> "" Then
            Condition.Add("cp.AdresseLivraison LIKE '%" & TextBox_Adresse_Compteur.Text & "%'")
        End If
        If Condition.Count() <> 0 Then
            ConsWhere = " WHERE " & String.Join(" AND ", Condition.ToArray)
        End If

        'Requete SQL
        Dim Donnees = bdd.Read("SELECT cp.NumCompteur, cl.Nom, cp.AdresseLivraison, pu.Puissance 
                                FROM dbchaufferie.compteur cp
                                INNER JOIN dbchaufferie.abonnement ab ON cp.Id=ab.IdCompteur
                                INNER JOIN dbchaufferie.client cl ON cl.Id=ab.IdClient
                                INNER JOIN dbchaufferie.puissance pu ON pu.IdCompteur=cp.Id" & ConsWhere)

        'Affichage dans le Tableau
        If Donnees.Count() >= 1 Then
            For i = 0 To Donnees.Count() - 1
                Dim Line As ListViewItem = New ListViewItem(Donnees(i).ToArray)
                Tab_compteur.Items.Add(Line)
            Next i
        End If

    End Sub

    'Recherche de Relevés

    Private Sub Releve_Recherche() Handles TextBox_NumCompteur_Releves.TextChanged,
                                         DateTimePicker_Debut.ValueChanged,
                                        DateTimePicker_Fin.ValueChanged
        'Suppression de toutes les lignes du Tableau
        Tab_releves.Items.Clear()

        'Déclaration des Variables
        Dim Condition As New List(Of String)
        Dim ConsWhere As String = ""
        Dim FormatDateDebut As String = DateTimePicker_Debut.Value.Date.ToString("yyyy-MM-dd")
        Dim FormatDateFin As String = DateTimePicker_Fin.Value.Date.ToString("yyyy-MM-dd")

        'Création de la Commande WHERE
        If TextBox_NumCompteur_Releves.Text <> "" Then
            Condition.Add("NumCompteur = " & TextBox_NumCompteur_Releves.Text)
        End If
        If TextBox_NumCompteur_Releves.Text <> "" Then
            Condition.Add("NumCompteur = '" & TextBox_NumCompteur_Releves.Text & "'")
        End If
        If DateTimePicker_Debut.Value.ToShortDateString <> Date.Now.ToShortDateString Then
            Condition.Add("DateReleveTh> '" & FormatDateDebut & "'")
        End If
        If DateTimePicker_Fin.Value.ToShortDateString <> Date.Now.ToShortDateString Then
            Condition.Add("DateReleveTh< '" & FormatDateFin & "'")
        End If
        If Condition.Count() <> 0 Then
            ConsWhere = " WHERE " & String.Join(" AND ", Condition.ToArray)
        End If

        'Requete SQL
        Dim Donnees = bdd.Read("SELECT Id, NumCompteur, DATE_FORMAT(DateReleveReel, ""%d/%c/%Y""), DATE_FORMAT(DateReleveTh, ""%d/%c/%Y""), IndexAncien, IndexNouveau FROM telereleve" & ConsWhere)

        'Affichage dans le Tableau
        If Donnees.Count() >= 1 Then
            For i = 0 To Donnees.Count() - 1
                Dim Line As ListViewItem = New ListViewItem(Donnees(i).ToArray)
                Tab_releves.Items.Add(Line)
            Next i
        End If

    End Sub

    'Recherche de Clients

    Private Sub Cient_Recherche() Handles TextBox_Nom_Clients.TextChanged,
                                          TextBox_Adresse_Client.TextChanged,
                                          TextBox_CodePostal_Clients.TextChanged

        'Suppression de toutes les lignes du Tableau
        Tab_Clients.Items.Clear()

        'Déclaration des Variables
        Dim Condition As New List(Of String)
        Dim ConsWhere As String = ""

        'Création de la Commande WHERE
        If TextBox_Nom_Clients.Text <> "" Then
            Condition.Add("Nom LIKE '" & TextBox_Nom_Clients.Text & "%'")
        End If
        If TextBox_Adresse_Client.Text <> "" Then
            Condition.Add("AdresseFacturation LIKE '%" & TextBox_Adresse_Client.Text & "%'")
        End If
        If TextBox_CodePostal_Clients.Text <> "" Then
            Condition.Add("CodePostal LIKE '" & TextBox_CodePostal_Clients.Text & "%'")
        End If
        If Condition.Count() <> 0 Then
            ConsWhere = " WHERE " & String.Join(" AND ", Condition.ToArray)
        End If

        'Requete SQL

        Dim Donnees = bdd.Read("SELECT Id, Civ, Nom, Prenom, AdresseFacturation, Ville, CodePostal, AdresseMail FROM client " & ConsWhere)

        'Affichage dans le Tableau
        If Donnees.Count() >= 1 Then
            For i = 0 To Donnees.Count() - 1
                Dim Line As ListViewItem = New ListViewItem(Donnees(i).ToArray)
                Tab_Clients.Items.Add(Line)
            Next i
        End If

    End Sub

    'Recherche Coût de Facturation

    Private Sub DateTime_date_coutdefac_ValueChanged(sender As Object, e As EventArgs) Handles DateTime_datedeb_coutdefac.ValueChanged,
                                                                                               DateTime_datefin_coutdefac.ValueChanged

        'Suppression de toutes les lignes du Tableau
        List_Coutdefac.Items.Clear()

        'Déclaration des Variables
        Dim Condition As New List(Of String)
        Dim ConsWhere As String = ""

        Dim FormatDateDebut As String = DateTime_datedeb_coutdefac.Value.Date.ToString("yyyy-MM-dd")
        Dim FormatDateFin As String = DateTime_datefin_coutdefac.Value.Date.ToString("yyyy-MM-dd")

        'Création de la Commande WHERE
        If DateTime_datedeb_coutdefac.Value.ToShortDateString <> Date.Now.ToShortDateString Then
            Condition.Add("DateDebut > '" & FormatDateDebut & "'")
        End If
        If DateTime_datefin_coutdefac.Value.ToShortDateString <> Date.Now.ToShortDateString Then
            Condition.Add("DateDebut < '" & FormatDateFin & "'")
        End If
        If Condition.Count() <> 0 Then
            ConsWhere = " WHERE " & String.Join(" AND ", Condition.ToArray)
        End If

        'Requete SQL
        Dim Donnees = bdd.Read("SELECT r1, r2, TVA, DATE_FORMAT(DateDebut, ""%d/%c/%Y"") FROM tarif" & ConsWhere)

        'Affichage dans le tableau
        For i = 0 To Donnees.Count() - 1
            Dim Line As ListViewItem = New ListViewItem(Donnees(i).ToArray)
            List_Coutdefac.Items.Add(Line)
        Next i
    End Sub

    Private Sub Double_Click_Client() Handles Tab_Clients.MouseDoubleClick

        If Me.Tab_Clients.SelectedItems.Count = 1 Then

            Dim lvi As ListViewItem = Me.Tab_Clients.SelectedItems(0)
            Dim idClient As String = lvi.SubItems(0).Text
            Dim Client As New Form_Double_Clic_Client(idClient)

        End If
    End Sub
End Class