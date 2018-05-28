<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Modifier_Abonnement
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Text_Idclient = New System.Windows.Forms.Label()
        Me.Text_DateFin_Abonnement = New System.Windows.Forms.Label()
        Me.text_DateDebut_Abonnement = New System.Windows.Forms.Label()
        Me.Text_IdCompteur_Abonnement = New System.Windows.Forms.Label()
        Me.Date_Fin_Abonnement = New System.Windows.Forms.DateTimePicker()
        Me.Date_Début_Abonnement = New System.Windows.Forms.DateTimePicker()
        Me.Button_Ajout_Abonnement = New System.Windows.Forms.Button()
        Me.ComboBox_Abonement_Client = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Abonnement_Compteur = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(559, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ajouter/Modifier un abonnement"
        '
        'Text_Idclient
        '
        Me.Text_Idclient.AutoSize = True
        Me.Text_Idclient.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Idclient.Location = New System.Drawing.Point(252, 193)
        Me.Text_Idclient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Text_Idclient.Name = "Text_Idclient"
        Me.Text_Idclient.Size = New System.Drawing.Size(75, 29)
        Me.Text_Idclient.TabIndex = 1
        Me.Text_Idclient.Text = "Client"
        '
        'Text_DateFin_Abonnement
        '
        Me.Text_DateFin_Abonnement.AutoSize = True
        Me.Text_DateFin_Abonnement.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_DateFin_Abonnement.Location = New System.Drawing.Point(224, 414)
        Me.Text_DateFin_Abonnement.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Text_DateFin_Abonnement.Name = "Text_DateFin_Abonnement"
        Me.Text_DateFin_Abonnement.Size = New System.Drawing.Size(103, 29)
        Me.Text_DateFin_Abonnement.TabIndex = 2
        Me.Text_DateFin_Abonnement.Text = "Date Fin"
        '
        'text_DateDebut_Abonnement
        '
        Me.text_DateDebut_Abonnement.AutoSize = True
        Me.text_DateDebut_Abonnement.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_DateDebut_Abonnement.Location = New System.Drawing.Point(195, 338)
        Me.text_DateDebut_Abonnement.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.text_DateDebut_Abonnement.Name = "text_DateDebut_Abonnement"
        Me.text_DateDebut_Abonnement.Size = New System.Drawing.Size(133, 29)
        Me.text_DateDebut_Abonnement.TabIndex = 3
        Me.text_DateDebut_Abonnement.Text = "Date Début"
        '
        'Text_IdCompteur_Abonnement
        '
        Me.Text_IdCompteur_Abonnement.AutoSize = True
        Me.Text_IdCompteur_Abonnement.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_IdCompteur_Abonnement.Location = New System.Drawing.Point(208, 261)
        Me.Text_IdCompteur_Abonnement.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Text_IdCompteur_Abonnement.Name = "Text_IdCompteur_Abonnement"
        Me.Text_IdCompteur_Abonnement.Size = New System.Drawing.Size(119, 29)
        Me.Text_IdCompteur_Abonnement.TabIndex = 4
        Me.Text_IdCompteur_Abonnement.Text = "Compteur"
        '
        'Date_Fin_Abonnement
        '
        Me.Date_Fin_Abonnement.Location = New System.Drawing.Point(342, 411)
        Me.Date_Fin_Abonnement.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Date_Fin_Abonnement.Name = "Date_Fin_Abonnement"
        Me.Date_Fin_Abonnement.Size = New System.Drawing.Size(298, 26)
        Me.Date_Fin_Abonnement.TabIndex = 7
        '
        'Date_Début_Abonnement
        '
        Me.Date_Début_Abonnement.Location = New System.Drawing.Point(342, 335)
        Me.Date_Début_Abonnement.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Date_Début_Abonnement.Name = "Date_Début_Abonnement"
        Me.Date_Début_Abonnement.Size = New System.Drawing.Size(298, 26)
        Me.Date_Début_Abonnement.TabIndex = 8
        '
        'Button_Ajout_Abonnement
        '
        Me.Button_Ajout_Abonnement.Location = New System.Drawing.Point(405, 515)
        Me.Button_Ajout_Abonnement.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_Ajout_Abonnement.Name = "Button_Ajout_Abonnement"
        Me.Button_Ajout_Abonnement.Size = New System.Drawing.Size(189, 68)
        Me.Button_Ajout_Abonnement.TabIndex = 9
        Me.Button_Ajout_Abonnement.Text = "Ajouter l'abonnement"
        Me.Button_Ajout_Abonnement.UseVisualStyleBackColor = True
        '
        'ComboBox_Abonement_Client
        '
        Me.ComboBox_Abonement_Client.FormattingEnabled = True
        Me.ComboBox_Abonement_Client.Location = New System.Drawing.Point(342, 194)
        Me.ComboBox_Abonement_Client.Name = "ComboBox_Abonement_Client"
        Me.ComboBox_Abonement_Client.Size = New System.Drawing.Size(298, 28)
        Me.ComboBox_Abonement_Client.TabIndex = 10
        '
        'ComboBox_Abonnement_Compteur
        '
        Me.ComboBox_Abonnement_Compteur.FormattingEnabled = True
        Me.ComboBox_Abonnement_Compteur.Location = New System.Drawing.Point(342, 261)
        Me.ComboBox_Abonnement_Compteur.Name = "ComboBox_Abonnement_Compteur"
        Me.ComboBox_Abonnement_Compteur.Size = New System.Drawing.Size(298, 28)
        Me.ComboBox_Abonnement_Compteur.TabIndex = 11
        '
        'Form_Modifier_Abonnement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 691)
        Me.Controls.Add(Me.ComboBox_Abonnement_Compteur)
        Me.Controls.Add(Me.ComboBox_Abonement_Client)
        Me.Controls.Add(Me.Button_Ajout_Abonnement)
        Me.Controls.Add(Me.Date_Début_Abonnement)
        Me.Controls.Add(Me.Date_Fin_Abonnement)
        Me.Controls.Add(Me.Text_IdCompteur_Abonnement)
        Me.Controls.Add(Me.text_DateDebut_Abonnement)
        Me.Controls.Add(Me.Text_DateFin_Abonnement)
        Me.Controls.Add(Me.Text_Idclient)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_Modifier_Abonnement"
        Me.Text = "Ajouter un abonnement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Text_Idclient As System.Windows.Forms.Label
    Friend WithEvents Text_DateFin_Abonnement As System.Windows.Forms.Label
    Friend WithEvents text_DateDebut_Abonnement As System.Windows.Forms.Label
    Friend WithEvents Text_IdCompteur_Abonnement As System.Windows.Forms.Label
    Friend WithEvents Date_Fin_Abonnement As System.Windows.Forms.DateTimePicker
    Friend WithEvents Date_Début_Abonnement As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button_Ajout_Abonnement As System.Windows.Forms.Button
    Friend WithEvents ComboBox_Abonement_Client As ComboBox
    Friend WithEvents ComboBox_Abonnement_Compteur As ComboBox
End Class
