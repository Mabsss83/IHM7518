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
    End Sub

    'Bouton Ajouter un abonnement
    Private Sub Button_Ajout_Abonnement_Click(sender As System.Object, e As System.EventArgs) Handles Button_Ajout_Abonnement.Click
        Me.Close()
        MsgBox("Nouvel abonnement ajouté")
    End Sub

End Class