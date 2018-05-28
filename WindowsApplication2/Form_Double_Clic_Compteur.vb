Public Class Form_Double_Clic_Compteur

    'Bouton Fermer
    Private Sub Button_Fermer_clicsurcompteur_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    'Form imbriqué dans le Main
    Private Sub Double_Clic_Sur_Compteur_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

End Class