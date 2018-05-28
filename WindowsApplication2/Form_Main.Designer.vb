<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Main
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip_Main = New System.Windows.Forms.MenuStrip()
        Me.FicheriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FermerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutilsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImporterUnFichierDeRelevéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaisirUnRelevéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HôpitalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterUnCompteurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterAbonnementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterCoutDeFacturationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FenêtresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ParamètresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip_Main
        '
        Me.MenuStrip_Main.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FicheriToolStripMenuItem, Me.OutilsToolStripMenuItem, Me.FenêtresToolStripMenuItem, Me.ParamètresToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip_Main.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip_Main.MdiWindowListItem = Me.FenêtresToolStripMenuItem
        Me.MenuStrip_Main.Name = "MenuStrip_Main"
        Me.MenuStrip_Main.Size = New System.Drawing.Size(776, 33)
        Me.MenuStrip_Main.TabIndex = 0
        Me.MenuStrip_Main.Text = "Main"
        '
        'FicheriToolStripMenuItem
        '
        Me.FicheriToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FermerToolStripMenuItem})
        Me.FicheriToolStripMenuItem.Name = "FicheriToolStripMenuItem"
        Me.FicheriToolStripMenuItem.Size = New System.Drawing.Size(74, 29)
        Me.FicheriToolStripMenuItem.Text = "Fichier"
        '
        'FermerToolStripMenuItem
        '
        Me.FermerToolStripMenuItem.Name = "FermerToolStripMenuItem"
        Me.FermerToolStripMenuItem.Size = New System.Drawing.Size(152, 30)
        Me.FermerToolStripMenuItem.Text = "Fermer"
        '
        'OutilsToolStripMenuItem
        '
        Me.OutilsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImporterUnFichierDeRelevéToolStripMenuItem, Me.SaisirUnRelevéToolStripMenuItem, Me.AjouterClientToolStripMenuItem, Me.AjouterUnCompteurToolStripMenuItem, Me.AjouterAbonnementToolStripMenuItem, Me.AjouterCoutDeFacturationToolStripMenuItem})
        Me.OutilsToolStripMenuItem.Name = "OutilsToolStripMenuItem"
        Me.OutilsToolStripMenuItem.Size = New System.Drawing.Size(70, 29)
        Me.OutilsToolStripMenuItem.Text = "Outils"
        '
        'ImporterUnFichierDeRelevéToolStripMenuItem
        '
        Me.ImporterUnFichierDeRelevéToolStripMenuItem.Name = "ImporterUnFichierDeRelevéToolStripMenuItem"
        Me.ImporterUnFichierDeRelevéToolStripMenuItem.Size = New System.Drawing.Size(360, 30)
        Me.ImporterUnFichierDeRelevéToolStripMenuItem.Text = "Importer un fichier de relevé"
        '
        'SaisirUnRelevéToolStripMenuItem
        '
        Me.SaisirUnRelevéToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HôpitalToolStripMenuItem, Me.BoisToolStripMenuItem})
        Me.SaisirUnRelevéToolStripMenuItem.Name = "SaisirUnRelevéToolStripMenuItem"
        Me.SaisirUnRelevéToolStripMenuItem.Size = New System.Drawing.Size(360, 30)
        Me.SaisirUnRelevéToolStripMenuItem.Text = "Saisir un relevé"
        '
        'HôpitalToolStripMenuItem
        '
        Me.HôpitalToolStripMenuItem.Name = "HôpitalToolStripMenuItem"
        Me.HôpitalToolStripMenuItem.Size = New System.Drawing.Size(155, 30)
        Me.HôpitalToolStripMenuItem.Text = "Hôpital"
        '
        'BoisToolStripMenuItem
        '
        Me.BoisToolStripMenuItem.Name = "BoisToolStripMenuItem"
        Me.BoisToolStripMenuItem.Size = New System.Drawing.Size(155, 30)
        Me.BoisToolStripMenuItem.Text = "Bois"
        '
        'AjouterClientToolStripMenuItem
        '
        Me.AjouterClientToolStripMenuItem.Name = "AjouterClientToolStripMenuItem"
        Me.AjouterClientToolStripMenuItem.Size = New System.Drawing.Size(360, 30)
        Me.AjouterClientToolStripMenuItem.Text = "Ajouter un client"
        '
        'AjouterUnCompteurToolStripMenuItem
        '
        Me.AjouterUnCompteurToolStripMenuItem.Name = "AjouterUnCompteurToolStripMenuItem"
        Me.AjouterUnCompteurToolStripMenuItem.Size = New System.Drawing.Size(360, 30)
        Me.AjouterUnCompteurToolStripMenuItem.Text = "Ajouter un compteur"
        '
        'AjouterAbonnementToolStripMenuItem
        '
        Me.AjouterAbonnementToolStripMenuItem.Name = "AjouterAbonnementToolStripMenuItem"
        Me.AjouterAbonnementToolStripMenuItem.Size = New System.Drawing.Size(360, 30)
        Me.AjouterAbonnementToolStripMenuItem.Text = "Ajouter/Modifier un abonnement"
        '
        'AjouterCoutDeFacturationToolStripMenuItem
        '
        Me.AjouterCoutDeFacturationToolStripMenuItem.Name = "AjouterCoutDeFacturationToolStripMenuItem"
        Me.AjouterCoutDeFacturationToolStripMenuItem.Size = New System.Drawing.Size(360, 30)
        Me.AjouterCoutDeFacturationToolStripMenuItem.Text = "Ajouter un coût de facturation"
        '
        'FenêtresToolStripMenuItem
        '
        Me.FenêtresToolStripMenuItem.Name = "FenêtresToolStripMenuItem"
        Me.FenêtresToolStripMenuItem.Size = New System.Drawing.Size(90, 29)
        Me.FenêtresToolStripMenuItem.Text = "Fenêtres"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(32, 29)
        Me.ToolStripMenuItem1.Text = "?"
        '
        'ParamètresToolStripMenuItem
        '
        Me.ParamètresToolStripMenuItem.Name = "ParamètresToolStripMenuItem"
        Me.ParamètresToolStripMenuItem.Size = New System.Drawing.Size(111, 29)
        Me.ParamètresToolStripMenuItem.Text = "Paramètres"
        '
        'Form_Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(776, 516)
        Me.Controls.Add(Me.MenuStrip_Main)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip_Main
        Me.MaximizeBox = False
        Me.Name = "Form_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturation IHM"
        Me.MenuStrip_Main.ResumeLayout(False)
        Me.MenuStrip_Main.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip_Main As System.Windows.Forms.MenuStrip
    Friend WithEvents FicheriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutilsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FenêtresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FermerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterCoutDeFacturationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterAbonnementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImporterUnFichierDeRelevéToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaisirUnRelevéToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HôpitalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BoisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents AjouterUnCompteurToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParamètresToolStripMenuItem As ToolStripMenuItem
End Class
