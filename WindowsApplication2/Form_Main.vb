Public Class Form_Main


    'S'exécute lors de l'ouverture du Main
    Private Sub Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Ouvre le Form Recherche

        Dim FormRech = New Form_Recherche()
    End Sub

    'Menu Fichier puis Fermer
    Private Sub FermerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FermerToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Menu Outils puis Ajouter un client
    Private Sub AjouterClientToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AjouterClientToolStripMenuItem.Click
        Dim FormAjouterClient As New Form_Ajouter_Client
    End Sub

    'Menu Outils puis Ajouter un cout de facturation
    Private Sub AjouterCoutDeFacturationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AjouterCoutDeFacturationToolStripMenuItem.Click
        Dim Ajoutcoutfac As New Ajouteruncoutdefac
    End Sub

    'Menu Outils puis Ajouter un abonnement
    Private Sub AjouterAbonnementToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AjouterAbonnementToolStripMenuItem.Click
        Dim Ajoutabo As New Form_Modifier_Abonnement
    End Sub

    'Menu Outils puis Saisir un relevé puis Hopital
    Private Sub HôpitalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HôpitalToolStripMenuItem.Click
        Dim Hopital As New Form_Hopital
    End Sub

    'Menu Outils puis Ajouter un compteur
    Private Sub AjouterUnCompteurToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AjouterUnCompteurToolStripMenuItem.Click
        Dim Nouveau_Compteur As New Form_Ajouter_Compteur
    End Sub

    'Menu Outils puis Saisir un relevé puis Bois
    Private Sub BoisToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BoisToolStripMenuItem.Click
        Dim Bois As New Form_Bois
    End Sub

    Private Sub ImporterUnFichierDeRelevéToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImporterUnFichierDeRelevéToolStripMenuItem.Click
        Dim Nouveau_Fichier_Import As New Form1
    End Sub

    Private Sub OutilsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutilsToolStripMenuItem.Click

    End Sub

    Private Sub ParamètresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParamètresToolStripMenuItem.Click
        Dim parametre As New Form_Parametre
    End Sub
End Class