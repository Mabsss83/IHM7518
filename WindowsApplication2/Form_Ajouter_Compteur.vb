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


        bdd.Write("INSERT INTO compteur VALUES (0,'" & Adresse & "'," & NumCompteur & ")")
        bdd.Write("INSERT INTO compteur VALUES (0,'" & Adresse & "'," & NumCompteur & ")")
        MsgBox("Compteur ajouté avec Succès")
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class