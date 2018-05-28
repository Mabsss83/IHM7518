<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Ajouter_Client
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
        Me.Text_Ajouterunclient = New System.Windows.Forms.Label()
        Me.Text_Civilite_ajoutclient = New System.Windows.Forms.Label()
        Me.Text_Nom_ajoutclient = New System.Windows.Forms.Label()
        Me.Text_Prenom_ajoutclient = New System.Windows.Forms.Label()
        Me.Text_adressefacturation_ajouterunclient = New System.Windows.Forms.Label()
        Me.Text_Ville_ajouterunclient = New System.Windows.Forms.Label()
        Me.Text_Codepostal_Ajoutclient = New System.Windows.Forms.Label()
        Me.Text_Adressemail_Ajouteruneclient = New System.Windows.Forms.Label()
        Me.TextBox_Nom_AjoutClient = New System.Windows.Forms.TextBox()
        Me.TextBox_Prenom_AjoutClient = New System.Windows.Forms.TextBox()
        Me.TextBox_Adressefac_Ajoutclient = New System.Windows.Forms.TextBox()
        Me.TextBox_Ville_AjoutClient = New System.Windows.Forms.TextBox()
        Me.ComboBox_CodePostal_AjoutClient = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Civilite_AjoutClient = New System.Windows.Forms.ComboBox()
        Me.TextBox_Adressemail_ajoutclient = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button_Ajouter_Client = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Text_Ajouterunclient
        '
        Me.Text_Ajouterunclient.AutoSize = True
        Me.Text_Ajouterunclient.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Ajouterunclient.Location = New System.Drawing.Point(75, 80)
        Me.Text_Ajouterunclient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Text_Ajouterunclient.Name = "Text_Ajouterunclient"
        Me.Text_Ajouterunclient.Size = New System.Drawing.Size(317, 47)
        Me.Text_Ajouterunclient.TabIndex = 1
        Me.Text_Ajouterunclient.Text = "Ajouter un client"
        '
        'Text_Civilite_ajoutclient
        '
        Me.Text_Civilite_ajoutclient.AutoSize = True
        Me.Text_Civilite_ajoutclient.Location = New System.Drawing.Point(152, 218)
        Me.Text_Civilite_ajoutclient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Text_Civilite_ajoutclient.Name = "Text_Civilite_ajoutclient"
        Me.Text_Civilite_ajoutclient.Size = New System.Drawing.Size(53, 20)
        Me.Text_Civilite_ajoutclient.TabIndex = 8
        Me.Text_Civilite_ajoutclient.Text = "Civilité"
        '
        'Text_Nom_ajoutclient
        '
        Me.Text_Nom_ajoutclient.AutoSize = True
        Me.Text_Nom_ajoutclient.Location = New System.Drawing.Point(399, 223)
        Me.Text_Nom_ajoutclient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Text_Nom_ajoutclient.Name = "Text_Nom_ajoutclient"
        Me.Text_Nom_ajoutclient.Size = New System.Drawing.Size(42, 20)
        Me.Text_Nom_ajoutclient.TabIndex = 9
        Me.Text_Nom_ajoutclient.Text = "Nom"
        '
        'Text_Prenom_ajoutclient
        '
        Me.Text_Prenom_ajoutclient.AutoSize = True
        Me.Text_Prenom_ajoutclient.Location = New System.Drawing.Point(738, 223)
        Me.Text_Prenom_ajoutclient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Text_Prenom_ajoutclient.Name = "Text_Prenom_ajoutclient"
        Me.Text_Prenom_ajoutclient.Size = New System.Drawing.Size(64, 20)
        Me.Text_Prenom_ajoutclient.TabIndex = 10
        Me.Text_Prenom_ajoutclient.Text = "Prénom"
        '
        'Text_adressefacturation_ajouterunclient
        '
        Me.Text_adressefacturation_ajouterunclient.AutoSize = True
        Me.Text_adressefacturation_ajouterunclient.Location = New System.Drawing.Point(38, 282)
        Me.Text_adressefacturation_ajouterunclient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Text_adressefacturation_ajouterunclient.Name = "Text_adressefacturation_ajouterunclient"
        Me.Text_adressefacturation_ajouterunclient.Size = New System.Drawing.Size(170, 20)
        Me.Text_adressefacturation_ajouterunclient.TabIndex = 11
        Me.Text_adressefacturation_ajouterunclient.Text = "Adresse de facturation"
        '
        'Text_Ville_ajouterunclient
        '
        Me.Text_Ville_ajouterunclient.AutoSize = True
        Me.Text_Ville_ajouterunclient.Location = New System.Drawing.Point(549, 282)
        Me.Text_Ville_ajouterunclient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Text_Ville_ajouterunclient.Name = "Text_Ville_ajouterunclient"
        Me.Text_Ville_ajouterunclient.Size = New System.Drawing.Size(38, 20)
        Me.Text_Ville_ajouterunclient.TabIndex = 12
        Me.Text_Ville_ajouterunclient.Text = "Ville"
        '
        'Text_Codepostal_Ajoutclient
        '
        Me.Text_Codepostal_Ajoutclient.AutoSize = True
        Me.Text_Codepostal_Ajoutclient.Location = New System.Drawing.Point(834, 282)
        Me.Text_Codepostal_Ajoutclient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Text_Codepostal_Ajoutclient.Name = "Text_Codepostal_Ajoutclient"
        Me.Text_Codepostal_Ajoutclient.Size = New System.Drawing.Size(95, 20)
        Me.Text_Codepostal_Ajoutclient.TabIndex = 13
        Me.Text_Codepostal_Ajoutclient.Text = "Code Postal"
        '
        'Text_Adressemail_Ajouteruneclient
        '
        Me.Text_Adressemail_Ajouteruneclient.AutoSize = True
        Me.Text_Adressemail_Ajouteruneclient.Location = New System.Drawing.Point(106, 340)
        Me.Text_Adressemail_Ajouteruneclient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Text_Adressemail_Ajouteruneclient.Name = "Text_Adressemail_Ajouteruneclient"
        Me.Text_Adressemail_Ajouteruneclient.Size = New System.Drawing.Size(100, 20)
        Me.Text_Adressemail_Ajouteruneclient.TabIndex = 14
        Me.Text_Adressemail_Ajouteruneclient.Text = "Adresse Mail"
        '
        'TextBox_Nom_AjoutClient
        '
        Me.TextBox_Nom_AjoutClient.Location = New System.Drawing.Point(452, 218)
        Me.TextBox_Nom_AjoutClient.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_Nom_AjoutClient.Name = "TextBox_Nom_AjoutClient"
        Me.TextBox_Nom_AjoutClient.Size = New System.Drawing.Size(236, 26)
        Me.TextBox_Nom_AjoutClient.TabIndex = 18
        '
        'TextBox_Prenom_AjoutClient
        '
        Me.TextBox_Prenom_AjoutClient.Location = New System.Drawing.Point(812, 218)
        Me.TextBox_Prenom_AjoutClient.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_Prenom_AjoutClient.Name = "TextBox_Prenom_AjoutClient"
        Me.TextBox_Prenom_AjoutClient.Size = New System.Drawing.Size(229, 26)
        Me.TextBox_Prenom_AjoutClient.TabIndex = 19
        '
        'TextBox_Adressefac_Ajoutclient
        '
        Me.TextBox_Adressefac_Ajoutclient.Location = New System.Drawing.Point(216, 277)
        Me.TextBox_Adressefac_Ajoutclient.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_Adressefac_Ajoutclient.Name = "TextBox_Adressefac_Ajoutclient"
        Me.TextBox_Adressefac_Ajoutclient.Size = New System.Drawing.Size(301, 26)
        Me.TextBox_Adressefac_Ajoutclient.TabIndex = 20
        '
        'TextBox_Ville_AjoutClient
        '
        Me.TextBox_Ville_AjoutClient.Location = New System.Drawing.Point(597, 277)
        Me.TextBox_Ville_AjoutClient.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_Ville_AjoutClient.Name = "TextBox_Ville_AjoutClient"
        Me.TextBox_Ville_AjoutClient.Size = New System.Drawing.Size(188, 26)
        Me.TextBox_Ville_AjoutClient.TabIndex = 21
        '
        'ComboBox_CodePostal_AjoutClient
        '
        Me.ComboBox_CodePostal_AjoutClient.FormattingEnabled = True
        Me.ComboBox_CodePostal_AjoutClient.Location = New System.Drawing.Point(939, 277)
        Me.ComboBox_CodePostal_AjoutClient.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox_CodePostal_AjoutClient.Name = "ComboBox_CodePostal_AjoutClient"
        Me.ComboBox_CodePostal_AjoutClient.Size = New System.Drawing.Size(180, 28)
        Me.ComboBox_CodePostal_AjoutClient.TabIndex = 22
        '
        'ComboBox_Civilite_AjoutClient
        '
        Me.ComboBox_Civilite_AjoutClient.FormattingEnabled = True
        Me.ComboBox_Civilite_AjoutClient.Items.AddRange(New Object() {"Mme", "M"})
        Me.ComboBox_Civilite_AjoutClient.Location = New System.Drawing.Point(216, 214)
        Me.ComboBox_Civilite_AjoutClient.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox_Civilite_AjoutClient.Name = "ComboBox_Civilite_AjoutClient"
        Me.ComboBox_Civilite_AjoutClient.Size = New System.Drawing.Size(80, 28)
        Me.ComboBox_Civilite_AjoutClient.TabIndex = 23
        '
        'TextBox_Adressemail_ajoutclient
        '
        Me.TextBox_Adressemail_ajoutclient.Location = New System.Drawing.Point(216, 335)
        Me.TextBox_Adressemail_ajoutclient.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_Adressemail_ajoutclient.Name = "TextBox_Adressemail_ajoutclient"
        Me.TextBox_Adressemail_ajoutclient.Size = New System.Drawing.Size(301, 26)
        Me.TextBox_Adressemail_ajoutclient.TabIndex = 24
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Oui", "Non"})
        Me.ComboBox3.Location = New System.Drawing.Point(537, 395)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(91, 28)
        Me.ComboBox3.TabIndex = 29
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Oui", "Non"})
        Me.ComboBox2.Location = New System.Drawing.Point(291, 395)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(91, 28)
        Me.ComboBox2.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(436, 400)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 20)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Par courrier"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(216, 400)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Par mail"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 400)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 20)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Envoi de la facture :"
        '
        'Button_Ajouter_Client
        '
        Me.Button_Ajouter_Client.Location = New System.Drawing.Point(452, 575)
        Me.Button_Ajouter_Client.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_Ajouter_Client.Name = "Button_Ajouter_Client"
        Me.Button_Ajouter_Client.Size = New System.Drawing.Size(206, 68)
        Me.Button_Ajouter_Client.TabIndex = 30
        Me.Button_Ajouter_Client.Text = "Ajouter un client"
        Me.Button_Ajouter_Client.UseVisualStyleBackColor = True
        '
        'Form_Ajouter_Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 709)
        Me.Controls.Add(Me.Button_Ajouter_Client)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_Adressemail_ajoutclient)
        Me.Controls.Add(Me.ComboBox_Civilite_AjoutClient)
        Me.Controls.Add(Me.ComboBox_CodePostal_AjoutClient)
        Me.Controls.Add(Me.TextBox_Ville_AjoutClient)
        Me.Controls.Add(Me.TextBox_Adressefac_Ajoutclient)
        Me.Controls.Add(Me.TextBox_Prenom_AjoutClient)
        Me.Controls.Add(Me.TextBox_Nom_AjoutClient)
        Me.Controls.Add(Me.Text_Adressemail_Ajouteruneclient)
        Me.Controls.Add(Me.Text_Codepostal_Ajoutclient)
        Me.Controls.Add(Me.Text_Ville_ajouterunclient)
        Me.Controls.Add(Me.Text_adressefacturation_ajouterunclient)
        Me.Controls.Add(Me.Text_Prenom_ajoutclient)
        Me.Controls.Add(Me.Text_Nom_ajoutclient)
        Me.Controls.Add(Me.Text_Civilite_ajoutclient)
        Me.Controls.Add(Me.Text_Ajouterunclient)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_Ajouter_Client"
        Me.Text = "Ajouter un client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Text_Ajouterunclient As System.Windows.Forms.Label
    Friend WithEvents Text_Civilite_ajoutclient As System.Windows.Forms.Label
    Friend WithEvents Text_Nom_ajoutclient As System.Windows.Forms.Label
    Friend WithEvents Text_Prenom_ajoutclient As System.Windows.Forms.Label
    Friend WithEvents Text_adressefacturation_ajouterunclient As System.Windows.Forms.Label
    Friend WithEvents Text_Ville_ajouterunclient As System.Windows.Forms.Label
    Friend WithEvents Text_Codepostal_Ajoutclient As System.Windows.Forms.Label
    Friend WithEvents Text_Adressemail_Ajouteruneclient As System.Windows.Forms.Label
    Friend WithEvents TextBox_Nom_AjoutClient As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Prenom_AjoutClient As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Adressefac_Ajoutclient As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Ville_AjoutClient As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox_CodePostal_AjoutClient As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_Civilite_AjoutClient As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox_Adressemail_ajoutclient As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button_Ajouter_Client As System.Windows.Forms.Button
End Class
