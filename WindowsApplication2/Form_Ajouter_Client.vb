Public Class Form_Ajouter_Client

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.MdiParent = Form_Main    'Pour imbriqué le Form
        Me.Show()

    End Sub

    'Form imbriqué dans le Main
    Private Sub Ajouterunclient_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    'Bouton Ajouter un client
    Private Sub Button_Ajouter_Client_Click(sender As System.Object, e As System.EventArgs) Handles Button_Ajouter_Client.Click

        Dim Civ = ComboBox_Civilite_AjoutClient.Text
        Dim Nom = TextBox_Nom_AjoutClient.Text
        Dim Prenom = TextBox_Prenom_AjoutClient.Text
        Dim Adresse = TextBox_Adressefac_Ajoutclient.Text
        Dim Ville = TextBox_Ville_AjoutClient.Text
        Dim CP = Val(ComboBox_CodePostal_AjoutClient.Text)
        Dim Mail = TextBox_Adressemail_ajoutclient.Text
        Dim AutMail = 0
        Dim AutPost = 0
        If ComboBox2.Text = "Oui" Then
            AutMail = 1
        Else
            AutMail = 0
        End If
        If ComboBox3.Text = "Oui" Then
            AutPost = 1
        Else
            AutPost = 0
        End If
        Dim AutDouble = 0
        If AutMail = 1 And AutPost = 1 Then
            AutDouble = 1
        End If
        bdd.Write("INSERT INTO client VALUES (0, '" & Civ & "','" & Nom & "','" & Prenom & "','" & Adresse & "','" & Ville & "'," & CP & ",'" & Mail & "'," & AutMail & "," & AutPost & "," & AutDouble & ")")
        MsgBox("Client ajouté avec Succès")
        Me.Close()
    End Sub
End Class