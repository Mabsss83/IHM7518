Public Class Form_Hopital

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.Show()

    End Sub

    'Bouton Entrer conso hopital
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button_ConsoHopital.Click
        Me.Close()
        MsgBox("Consommation hôpital enregistrée")
    End Sub

End Class