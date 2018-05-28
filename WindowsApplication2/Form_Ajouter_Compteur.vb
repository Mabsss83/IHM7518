Public Class Form_Ajouter_Compteur
    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.MdiParent = Form_Main    'Pour imbriqué le Form
        Me.Show()

    End Sub

    'Form imbriqué dans le Main
    Private Sub Ajouteruncompteur_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    'Bouton Ajouter un compteur
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button_AjouterCompteur.Click
        Dim NumCompteur = TextBox_Compteur_Num.Text
        Dim Adresse = TextBox_Compteur_AdresseLiv.Text
        Dim Puissance = TextBox_Compteur_Puissance.Text
        Dim DateDebut = DateTimePicker_Compteur_DateDebut.Value.Date.ToString("yyyy-MM-dd")


        bdd.Write("INSERT INTO compteur VALUES (0,'" & Adresse & "','" & NumCompteur & "')")
        Dim IdCompteur = bdd.Read("SELECT Id FROM compteur WHERE NumCompteur = '" & NumCompteur & "'")
        MsgBox(DateDebut)
        bdd.Write("INSERT INTO puissance VALUES (0," & IdCompteur(0)(0) & "," & Puissance & ",'" & DateDebut & "')")
        MsgBox("Compteur ajouté avec Succès")
        Me.Close()
    End Sub

End Class