Public Class Ajouteruncoutdefac

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.MdiParent = Form_Main    'Pour imbriqué le Form
        Me.Show()

    End Sub

    'Form imbriqué dans le Main
    Private Sub Ajouteruncoutdefac_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    'Bouton Ajouter un tarif
    Private Sub Button_Ajout_Coutdefac_Click(sender As System.Object, e As System.EventArgs) Handles Button_Ajout_Coutdefac.Click
        Me.Close()
        MsgBox("Nouveau coût de facturation ajouté")
    End Sub
End Class