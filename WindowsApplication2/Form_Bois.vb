Public Class Form_Bois

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.Show()

    End Sub

    'Bouton Ajouter conso
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button_AjouterBois.Click
        Me.Close()
        MsgBox("Consommation bois enregistrée")
    End Sub

End Class