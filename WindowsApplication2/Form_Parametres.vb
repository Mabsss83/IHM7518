Public Class Form_Parametre

    Dim WithEvents Modification As Form_ModifyParametre

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

        UpdateParameterList()
    End Sub

    Private Sub UpdateParameterList() Handles Modification.Para_Update
        ListView_Parametre.Items.Clear()
        Read_XML_ListView(ListView_Parametre)
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView_Parametre.DoubleClick
        If Me.ListView_Parametre.SelectedItems.Count = 1 Then
            Dim lvi As ListViewItem = Me.ListView_Parametre.SelectedItems(0)
            Dim parameter As String = lvi.SubItems(0).Text
            Dim value As String = lvi.SubItems(1).Text
            Modification = New Form_ModifyParametre(parameter, value)
        End If
    End Sub
End Class