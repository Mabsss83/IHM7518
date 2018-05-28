Public Class Form_Modifier_Abonnement

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.MdiParent = Form_Main    'Pour imbriqué le Form
        Me.Show()

    End Sub

    'Form imbriqué dans le Main
    Private Sub AjouterUnAbonnement_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim B = bdd.Read("SELECT Nom FROM client")
        For i = 0 To B.Count - 1
            ComboBox_Abonement_Client.Items.Add(B(i)(0))
        Next
        B = bdd.Read("SELECT NumCompteur FROM compteur")
        For i = 0 To B.Count - 2
            ComboBox_Abonnement_Compteur.Items.Add(B(i)(0))
        Next

    End Sub

    'Bouton Ajouter un abonnement
    Private Sub Button_Ajout_Abonnement_Click(sender As System.Object, e As System.EventArgs) Handles Button_Ajout_Abonnement.Click

        Dim NomClient = ComboBox_Abonement_Client.SelectedItem.ToString
        Dim NumCompteur = ComboBox_Abonnement_Compteur.SelectedItem.ToString
        Dim IdClient = bdd.Read("SELECT Id FROM client WHERE (Nom = '" & NomClient & "')")(0)(0)
        Dim IdCompteur = bdd.Read("SELECT Id FROM compteur WHERE (NumCompteur = '" & NumCompteur & "')")(0)(0)
        Dim DateDebut As String = Date_Début_Abonnement.Value.Date.ToString("yyyy-MM-dd")
        bdd.Write("INSERT INTO abonnement VALUES (0,'" & IdClient & "','" & IdCompteur & "','" & DateDebut & "','" & DateDebut & "')")
        Me.Close()
    End Sub

End Class