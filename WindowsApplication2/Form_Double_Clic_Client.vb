Public Class Form_Double_Clic_Client

    'Bouton Fermer
    Private Sub Button_fermer_Client_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    'Form imbriqué dans le Main
    Private Sub Double_Clic_sur_Un_Client_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class