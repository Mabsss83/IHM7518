<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Double_Clic_Client
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim StripLine1 As System.Windows.Forms.DataVisualization.Charting.StripLine = New System.Windows.Forms.DataVisualization.Charting.StripLine()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Compteurs = New System.Windows.Forms.TabControl()
        Me.Informations = New System.Windows.Forms.TabPage()
        Me.CheckBox_mail = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Courrier = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_mail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_ville = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox_civilite = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_CodePostal = New System.Windows.Forms.TextBox()
        Me.Text_CodePostal_Information = New System.Windows.Forms.Label()
        Me.Textbox_Nom_Information = New System.Windows.Forms.TextBox()
        Me.TextBox_Prenom_Information = New System.Windows.Forms.TextBox()
        Me.TextBox_Adresse1_Information = New System.Windows.Forms.TextBox()
        Me.TextBox_Id_Informations = New System.Windows.Forms.TextBox()
        Me.Enregister = New System.Windows.Forms.Button()
        Me.Text_Adresse1_Informations = New System.Windows.Forms.Label()
        Me.Text_Prenom_Informations = New System.Windows.Forms.Label()
        Me.Text_Nom_Informations = New System.Windows.Forms.Label()
        Me.Text_Id_Informations = New System.Windows.Forms.Label()
        Me.List_Compteur_DoubleClic = New System.Windows.Forms.TabPage()
        Me.Button_Modifier_Compteurs = New System.Windows.Forms.Button()
        Me.Button_Supprimer_Compteurs = New System.Windows.Forms.Button()
        Me.Button_Ajouter_Compteurs = New System.Windows.Forms.Button()
        Me.List_Compteur = New System.Windows.Forms.ListView()
        Me.Compteur = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Client_Address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Puissance = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_Client_Compteurs_DebutAbonnement = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_Client_Compteurs_FinAbonnement = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DoubleClic_factures = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxNumCompteur_Fact = New System.Windows.Forms.ComboBox()
        Me.Label_periode_2 = New System.Windows.Forms.Label()
        Me.DateTime_DateFin_Factures = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxAdresse_Fact = New System.Windows.Forms.ComboBox()
        Me.Label_tri_adresse = New System.Windows.Forms.Label()
        Me.DateTime_DateDebut_Factures = New System.Windows.Forms.DateTimePicker()
        Me.Text_Datedébut_Factures = New System.Windows.Forms.Label()
        Me.List_Factures = New System.Windows.Forms.ListView()
        Me.Num = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Date_facture = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_Client_Factures_Num_Compteur = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Montant = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DoubleClic_Consommation = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxNumCompteur_Conso = New System.Windows.Forms.ComboBox()
        Me.Text_DateDebut_Consommation = New System.Windows.Forms.Label()
        Me.Text_DateFin_Consommation = New System.Windows.Forms.Label()
        Me.DateTime_DateDebut_Consommation = New System.Windows.Forms.DateTimePicker()
        Me.DateTime_DateFin_Consommation = New System.Windows.Forms.DateTimePicker()
        Me.Chart_Consommation = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Text_Titre = New System.Windows.Forms.Label()
        Me.Compteurs.SuspendLayout()
        Me.Informations.SuspendLayout()
        Me.List_Compteur_DoubleClic.SuspendLayout()
        Me.DoubleClic_factures.SuspendLayout()
        Me.DoubleClic_Consommation.SuspendLayout()
        CType(Me.Chart_Consommation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Compteurs
        '
        Me.Compteurs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Compteurs.Controls.Add(Me.Informations)
        Me.Compteurs.Controls.Add(Me.List_Compteur_DoubleClic)
        Me.Compteurs.Controls.Add(Me.DoubleClic_factures)
        Me.Compteurs.Controls.Add(Me.DoubleClic_Consommation)
        Me.Compteurs.Location = New System.Drawing.Point(0, 36)
        Me.Compteurs.Name = "Compteurs"
        Me.Compteurs.SelectedIndex = 0
        Me.Compteurs.Size = New System.Drawing.Size(779, 407)
        Me.Compteurs.TabIndex = 0
        '
        'Informations
        '
        Me.Informations.Controls.Add(Me.CheckBox_mail)
        Me.Informations.Controls.Add(Me.CheckBox_Courrier)
        Me.Informations.Controls.Add(Me.Label4)
        Me.Informations.Controls.Add(Me.TextBox_mail)
        Me.Informations.Controls.Add(Me.Label3)
        Me.Informations.Controls.Add(Me.TextBox_ville)
        Me.Informations.Controls.Add(Me.Label2)
        Me.Informations.Controls.Add(Me.ComboBox_civilite)
        Me.Informations.Controls.Add(Me.Label1)
        Me.Informations.Controls.Add(Me.TextBox_CodePostal)
        Me.Informations.Controls.Add(Me.Text_CodePostal_Information)
        Me.Informations.Controls.Add(Me.Textbox_Nom_Information)
        Me.Informations.Controls.Add(Me.TextBox_Prenom_Information)
        Me.Informations.Controls.Add(Me.TextBox_Adresse1_Information)
        Me.Informations.Controls.Add(Me.TextBox_Id_Informations)
        Me.Informations.Controls.Add(Me.Enregister)
        Me.Informations.Controls.Add(Me.Text_Adresse1_Informations)
        Me.Informations.Controls.Add(Me.Text_Prenom_Informations)
        Me.Informations.Controls.Add(Me.Text_Nom_Informations)
        Me.Informations.Controls.Add(Me.Text_Id_Informations)
        Me.Informations.Location = New System.Drawing.Point(4, 22)
        Me.Informations.Name = "Informations"
        Me.Informations.Padding = New System.Windows.Forms.Padding(3)
        Me.Informations.Size = New System.Drawing.Size(771, 381)
        Me.Informations.TabIndex = 0
        Me.Informations.Text = "Informations"
        Me.Informations.UseVisualStyleBackColor = True
        '
        'CheckBox_mail
        '
        Me.CheckBox_mail.AutoSize = True
        Me.CheckBox_mail.Location = New System.Drawing.Point(279, 211)
        Me.CheckBox_mail.Name = "CheckBox_mail"
        Me.CheckBox_mail.Size = New System.Drawing.Size(64, 17)
        Me.CheckBox_mail.TabIndex = 24
        Me.CheckBox_mail.Text = "Par Mail"
        Me.CheckBox_mail.UseVisualStyleBackColor = True
        '
        'CheckBox_Courrier
        '
        Me.CheckBox_Courrier.AutoSize = True
        Me.CheckBox_Courrier.Location = New System.Drawing.Point(144, 211)
        Me.CheckBox_Courrier.Name = "CheckBox_Courrier"
        Me.CheckBox_Courrier.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox_Courrier.TabIndex = 23
        Me.CheckBox_Courrier.Text = "Par Courrier"
        Me.CheckBox_Courrier.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Envoi de la facture :"
        '
        'TextBox_mail
        '
        Me.TextBox_mail.Location = New System.Drawing.Point(91, 171)
        Me.TextBox_mail.Name = "TextBox_mail"
        Me.TextBox_mail.Size = New System.Drawing.Size(220, 20)
        Me.TextBox_mail.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Adresse mail"
        '
        'TextBox_ville
        '
        Me.TextBox_ville.Location = New System.Drawing.Point(279, 132)
        Me.TextBox_ville.Name = "TextBox_ville"
        Me.TextBox_ville.Size = New System.Drawing.Size(101, 20)
        Me.TextBox_ville.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(247, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Ville"
        '
        'ComboBox_civilite
        '
        Me.ComboBox_civilite.FormattingEnabled = True
        Me.ComboBox_civilite.Items.AddRange(New Object() {"M.", "Mme."})
        Me.ComboBox_civilite.Location = New System.Drawing.Point(91, 61)
        Me.ComboBox_civilite.Name = "ComboBox_civilite"
        Me.ComboBox_civilite.Size = New System.Drawing.Size(67, 21)
        Me.ComboBox_civilite.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Civilité"
        '
        'TextBox_CodePostal
        '
        Me.TextBox_CodePostal.Location = New System.Drawing.Point(91, 132)
        Me.TextBox_CodePostal.Name = "TextBox_CodePostal"
        Me.TextBox_CodePostal.Size = New System.Drawing.Size(101, 20)
        Me.TextBox_CodePostal.TabIndex = 13
        '
        'Text_CodePostal_Information
        '
        Me.Text_CodePostal_Information.AutoSize = True
        Me.Text_CodePostal_Information.Location = New System.Drawing.Point(21, 135)
        Me.Text_CodePostal_Information.Name = "Text_CodePostal_Information"
        Me.Text_CodePostal_Information.Size = New System.Drawing.Size(64, 13)
        Me.Text_CodePostal_Information.TabIndex = 12
        Me.Text_CodePostal_Information.Text = "Code Postal"
        '
        'Textbox_Nom_Information
        '
        Me.Textbox_Nom_Information.Location = New System.Drawing.Point(278, 62)
        Me.Textbox_Nom_Information.Name = "Textbox_Nom_Information"
        Me.Textbox_Nom_Information.Size = New System.Drawing.Size(128, 20)
        Me.Textbox_Nom_Information.TabIndex = 9
        '
        'TextBox_Prenom_Information
        '
        Me.TextBox_Prenom_Information.Location = New System.Drawing.Point(528, 62)
        Me.TextBox_Prenom_Information.Name = "TextBox_Prenom_Information"
        Me.TextBox_Prenom_Information.Size = New System.Drawing.Size(128, 20)
        Me.TextBox_Prenom_Information.TabIndex = 8
        '
        'TextBox_Adresse1_Information
        '
        Me.TextBox_Adresse1_Information.Location = New System.Drawing.Point(91, 98)
        Me.TextBox_Adresse1_Information.Name = "TextBox_Adresse1_Information"
        Me.TextBox_Adresse1_Information.Size = New System.Drawing.Size(220, 20)
        Me.TextBox_Adresse1_Information.TabIndex = 7
        '
        'TextBox_Id_Informations
        '
        Me.TextBox_Id_Informations.Location = New System.Drawing.Point(91, 27)
        Me.TextBox_Id_Informations.Name = "TextBox_Id_Informations"
        Me.TextBox_Id_Informations.ReadOnly = True
        Me.TextBox_Id_Informations.Size = New System.Drawing.Size(101, 20)
        Me.TextBox_Id_Informations.TabIndex = 6
        '
        'Enregister
        '
        Me.Enregister.Location = New System.Drawing.Point(586, 322)
        Me.Enregister.Name = "Enregister"
        Me.Enregister.Size = New System.Drawing.Size(133, 38)
        Me.Enregister.TabIndex = 5
        Me.Enregister.Text = "Enregistrer"
        Me.Enregister.UseVisualStyleBackColor = True
        '
        'Text_Adresse1_Informations
        '
        Me.Text_Adresse1_Informations.AutoSize = True
        Me.Text_Adresse1_Informations.Location = New System.Drawing.Point(40, 101)
        Me.Text_Adresse1_Informations.Name = "Text_Adresse1_Informations"
        Me.Text_Adresse1_Informations.Size = New System.Drawing.Size(45, 13)
        Me.Text_Adresse1_Informations.TabIndex = 3
        Me.Text_Adresse1_Informations.Text = "Adresse"
        '
        'Text_Prenom_Informations
        '
        Me.Text_Prenom_Informations.AutoSize = True
        Me.Text_Prenom_Informations.Location = New System.Drawing.Point(479, 65)
        Me.Text_Prenom_Informations.Name = "Text_Prenom_Informations"
        Me.Text_Prenom_Informations.Size = New System.Drawing.Size(43, 13)
        Me.Text_Prenom_Informations.TabIndex = 2
        Me.Text_Prenom_Informations.Text = "Prénom"
        '
        'Text_Nom_Informations
        '
        Me.Text_Nom_Informations.AutoSize = True
        Me.Text_Nom_Informations.Location = New System.Drawing.Point(243, 65)
        Me.Text_Nom_Informations.Name = "Text_Nom_Informations"
        Me.Text_Nom_Informations.Size = New System.Drawing.Size(29, 13)
        Me.Text_Nom_Informations.TabIndex = 1
        Me.Text_Nom_Informations.Text = "Nom"
        Me.Text_Nom_Informations.UseMnemonic = False
        '
        'Text_Id_Informations
        '
        Me.Text_Id_Informations.AutoSize = True
        Me.Text_Id_Informations.Location = New System.Drawing.Point(69, 30)
        Me.Text_Id_Informations.Name = "Text_Id_Informations"
        Me.Text_Id_Informations.Size = New System.Drawing.Size(16, 13)
        Me.Text_Id_Informations.TabIndex = 0
        Me.Text_Id_Informations.Text = "Id"
        '
        'List_Compteur_DoubleClic
        '
        Me.List_Compteur_DoubleClic.Controls.Add(Me.Button_Modifier_Compteurs)
        Me.List_Compteur_DoubleClic.Controls.Add(Me.Button_Supprimer_Compteurs)
        Me.List_Compteur_DoubleClic.Controls.Add(Me.Button_Ajouter_Compteurs)
        Me.List_Compteur_DoubleClic.Controls.Add(Me.List_Compteur)
        Me.List_Compteur_DoubleClic.Location = New System.Drawing.Point(4, 22)
        Me.List_Compteur_DoubleClic.Name = "List_Compteur_DoubleClic"
        Me.List_Compteur_DoubleClic.Padding = New System.Windows.Forms.Padding(3)
        Me.List_Compteur_DoubleClic.Size = New System.Drawing.Size(771, 381)
        Me.List_Compteur_DoubleClic.TabIndex = 1
        Me.List_Compteur_DoubleClic.Text = "Compteurs"
        Me.List_Compteur_DoubleClic.UseVisualStyleBackColor = True
        '
        'Button_Modifier_Compteurs
        '
        Me.Button_Modifier_Compteurs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Modifier_Compteurs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Modifier_Compteurs.Location = New System.Drawing.Point(309, 318)
        Me.Button_Modifier_Compteurs.Name = "Button_Modifier_Compteurs"
        Me.Button_Modifier_Compteurs.Size = New System.Drawing.Size(112, 40)
        Me.Button_Modifier_Compteurs.TabIndex = 3
        Me.Button_Modifier_Compteurs.Text = "Modifier"
        Me.Button_Modifier_Compteurs.UseVisualStyleBackColor = True
        '
        'Button_Supprimer_Compteurs
        '
        Me.Button_Supprimer_Compteurs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Supprimer_Compteurs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Supprimer_Compteurs.Location = New System.Drawing.Point(488, 318)
        Me.Button_Supprimer_Compteurs.Name = "Button_Supprimer_Compteurs"
        Me.Button_Supprimer_Compteurs.Size = New System.Drawing.Size(127, 40)
        Me.Button_Supprimer_Compteurs.TabIndex = 2
        Me.Button_Supprimer_Compteurs.Text = "Supprimer"
        Me.Button_Supprimer_Compteurs.UseVisualStyleBackColor = True
        '
        'Button_Ajouter_Compteurs
        '
        Me.Button_Ajouter_Compteurs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button_Ajouter_Compteurs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Ajouter_Compteurs.Location = New System.Drawing.Point(120, 318)
        Me.Button_Ajouter_Compteurs.Name = "Button_Ajouter_Compteurs"
        Me.Button_Ajouter_Compteurs.Size = New System.Drawing.Size(109, 40)
        Me.Button_Ajouter_Compteurs.TabIndex = 1
        Me.Button_Ajouter_Compteurs.Text = "Ajouter"
        Me.Button_Ajouter_Compteurs.UseVisualStyleBackColor = True
        '
        'List_Compteur
        '
        Me.List_Compteur.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.List_Compteur.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Compteur, Me.Client_Address, Me.Puissance, Me.ColumnHeader_Client_Compteurs_DebutAbonnement, Me.ColumnHeader_Client_Compteurs_FinAbonnement})
        Me.List_Compteur.FullRowSelect = True
        Me.List_Compteur.GridLines = True
        Me.List_Compteur.HideSelection = False
        Me.List_Compteur.Location = New System.Drawing.Point(9, 6)
        Me.List_Compteur.Name = "List_Compteur"
        Me.List_Compteur.Size = New System.Drawing.Size(759, 292)
        Me.List_Compteur.TabIndex = 0
        Me.List_Compteur.UseCompatibleStateImageBehavior = False
        Me.List_Compteur.View = System.Windows.Forms.View.Details
        '
        'Compteur
        '
        Me.Compteur.Text = "Numéro Compteur"
        Me.Compteur.Width = 102
        '
        'Client_Address
        '
        Me.Client_Address.Text = "Adresse"
        Me.Client_Address.Width = 268
        '
        'Puissance
        '
        Me.Puissance.Text = "Puissance"
        Me.Puissance.Width = 68
        '
        'ColumnHeader_Client_Compteurs_DebutAbonnement
        '
        Me.ColumnHeader_Client_Compteurs_DebutAbonnement.Text = "Date de début d'abonnement"
        Me.ColumnHeader_Client_Compteurs_DebutAbonnement.Width = 156
        '
        'ColumnHeader_Client_Compteurs_FinAbonnement
        '
        Me.ColumnHeader_Client_Compteurs_FinAbonnement.Text = "Date de fin d'abonnement"
        Me.ColumnHeader_Client_Compteurs_FinAbonnement.Width = 160
        '
        'DoubleClic_factures
        '
        Me.DoubleClic_factures.Controls.Add(Me.Label5)
        Me.DoubleClic_factures.Controls.Add(Me.ComboBoxNumCompteur_Fact)
        Me.DoubleClic_factures.Controls.Add(Me.Label_periode_2)
        Me.DoubleClic_factures.Controls.Add(Me.DateTime_DateFin_Factures)
        Me.DoubleClic_factures.Controls.Add(Me.ComboBoxAdresse_Fact)
        Me.DoubleClic_factures.Controls.Add(Me.Label_tri_adresse)
        Me.DoubleClic_factures.Controls.Add(Me.DateTime_DateDebut_Factures)
        Me.DoubleClic_factures.Controls.Add(Me.Text_Datedébut_Factures)
        Me.DoubleClic_factures.Controls.Add(Me.List_Factures)
        Me.DoubleClic_factures.Location = New System.Drawing.Point(4, 22)
        Me.DoubleClic_factures.Name = "DoubleClic_factures"
        Me.DoubleClic_factures.Padding = New System.Windows.Forms.Padding(3)
        Me.DoubleClic_factures.Size = New System.Drawing.Size(771, 381)
        Me.DoubleClic_factures.TabIndex = 2
        Me.DoubleClic_factures.Text = "Factures"
        Me.DoubleClic_factures.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "N° Compteur"
        '
        'ComboBoxNumCompteur_Fact
        '
        Me.ComboBoxNumCompteur_Fact.FormattingEnabled = True
        Me.ComboBoxNumCompteur_Fact.Location = New System.Drawing.Point(115, 51)
        Me.ComboBoxNumCompteur_Fact.Name = "ComboBoxNumCompteur_Fact"
        Me.ComboBoxNumCompteur_Fact.Size = New System.Drawing.Size(194, 21)
        Me.ComboBoxNumCompteur_Fact.TabIndex = 11
        '
        'Label_periode_2
        '
        Me.Label_periode_2.AutoSize = True
        Me.Label_periode_2.Location = New System.Drawing.Point(432, 24)
        Me.Label_periode_2.Name = "Label_periode_2"
        Me.Label_periode_2.Size = New System.Drawing.Size(19, 13)
        Me.Label_periode_2.TabIndex = 10
        Me.Label_periode_2.Text = "au"
        '
        'DateTime_DateFin_Factures
        '
        Me.DateTime_DateFin_Factures.CustomFormat = "yyyy-mm-dd"
        Me.DateTime_DateFin_Factures.Location = New System.Drawing.Point(473, 18)
        Me.DateTime_DateFin_Factures.Name = "DateTime_DateFin_Factures"
        Me.DateTime_DateFin_Factures.Size = New System.Drawing.Size(200, 20)
        Me.DateTime_DateFin_Factures.TabIndex = 9
        '
        'ComboBoxAdresse_Fact
        '
        Me.ComboBoxAdresse_Fact.FormattingEnabled = True
        Me.ComboBoxAdresse_Fact.Location = New System.Drawing.Point(377, 51)
        Me.ComboBoxAdresse_Fact.Name = "ComboBoxAdresse_Fact"
        Me.ComboBoxAdresse_Fact.Size = New System.Drawing.Size(362, 21)
        Me.ComboBoxAdresse_Fact.TabIndex = 8
        '
        'Label_tri_adresse
        '
        Me.Label_tri_adresse.AutoSize = True
        Me.Label_tri_adresse.Location = New System.Drawing.Point(325, 56)
        Me.Label_tri_adresse.Name = "Label_tri_adresse"
        Me.Label_tri_adresse.Size = New System.Drawing.Size(45, 13)
        Me.Label_tri_adresse.TabIndex = 7
        Me.Label_tri_adresse.Text = "Adresse"
        '
        'DateTime_DateDebut_Factures
        '
        Me.DateTime_DateDebut_Factures.CustomFormat = "yyyy-mm-dd"
        Me.DateTime_DateDebut_Factures.Location = New System.Drawing.Point(207, 18)
        Me.DateTime_DateDebut_Factures.Name = "DateTime_DateDebut_Factures"
        Me.DateTime_DateDebut_Factures.Size = New System.Drawing.Size(200, 20)
        Me.DateTime_DateDebut_Factures.TabIndex = 3
        '
        'Text_Datedébut_Factures
        '
        Me.Text_Datedébut_Factures.AutoSize = True
        Me.Text_Datedébut_Factures.Location = New System.Drawing.Point(71, 24)
        Me.Text_Datedébut_Factures.Name = "Text_Datedébut_Factures"
        Me.Text_Datedébut_Factures.Size = New System.Drawing.Size(116, 13)
        Me.Text_Datedébut_Factures.TabIndex = 1
        Me.Text_Datedébut_Factures.Text = "Date de la facture :  du"
        '
        'List_Factures
        '
        Me.List_Factures.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.List_Factures.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Num, Me.Date_facture, Me.Colonne_Client_Factures_Num_Compteur, Me.Montant, Me.Address})
        Me.List_Factures.GridLines = True
        Me.List_Factures.Location = New System.Drawing.Point(8, 86)
        Me.List_Factures.Name = "List_Factures"
        Me.List_Factures.Size = New System.Drawing.Size(753, 289)
        Me.List_Factures.TabIndex = 0
        Me.List_Factures.UseCompatibleStateImageBehavior = False
        Me.List_Factures.View = System.Windows.Forms.View.Details
        '
        'Num
        '
        Me.Num.Text = "N°"
        Me.Num.Width = 30
        '
        'Date_facture
        '
        Me.Date_facture.Text = "Date de la facture"
        Me.Date_facture.Width = 113
        '
        'Colonne_Client_Factures_Num_Compteur
        '
        Me.Colonne_Client_Factures_Num_Compteur.Text = "Numéro compteur"
        Me.Colonne_Client_Factures_Num_Compteur.Width = 117
        '
        'Montant
        '
        Me.Montant.DisplayIndex = 4
        Me.Montant.Text = "Montant"
        Me.Montant.Width = 123
        '
        'Address
        '
        Me.Address.DisplayIndex = 3
        Me.Address.Text = "Adresse"
        Me.Address.Width = 366
        '
        'DoubleClic_Consommation
        '
        Me.DoubleClic_Consommation.Controls.Add(Me.Label7)
        Me.DoubleClic_Consommation.Controls.Add(Me.ComboBoxNumCompteur_Conso)
        Me.DoubleClic_Consommation.Controls.Add(Me.Text_DateDebut_Consommation)
        Me.DoubleClic_Consommation.Controls.Add(Me.Text_DateFin_Consommation)
        Me.DoubleClic_Consommation.Controls.Add(Me.DateTime_DateDebut_Consommation)
        Me.DoubleClic_Consommation.Controls.Add(Me.DateTime_DateFin_Consommation)
        Me.DoubleClic_Consommation.Controls.Add(Me.Chart_Consommation)
        Me.DoubleClic_Consommation.Location = New System.Drawing.Point(4, 22)
        Me.DoubleClic_Consommation.Name = "DoubleClic_Consommation"
        Me.DoubleClic_Consommation.Padding = New System.Windows.Forms.Padding(3)
        Me.DoubleClic_Consommation.Size = New System.Drawing.Size(771, 381)
        Me.DoubleClic_Consommation.TabIndex = 3
        Me.DoubleClic_Consommation.Text = "Consommation"
        Me.DoubleClic_Consommation.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(414, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "N° Compteur"
        '
        'ComboBoxNumCompteur_Conso
        '
        Me.ComboBoxNumCompteur_Conso.FormattingEnabled = True
        Me.ComboBoxNumCompteur_Conso.Location = New System.Drawing.Point(503, 51)
        Me.ComboBoxNumCompteur_Conso.Name = "ComboBoxNumCompteur_Conso"
        Me.ComboBoxNumCompteur_Conso.Size = New System.Drawing.Size(194, 21)
        Me.ComboBoxNumCompteur_Conso.TabIndex = 8
        '
        'Text_DateDebut_Consommation
        '
        Me.Text_DateDebut_Consommation.AutoSize = True
        Me.Text_DateDebut_Consommation.Location = New System.Drawing.Point(75, 31)
        Me.Text_DateDebut_Consommation.Name = "Text_DateDebut_Consommation"
        Me.Text_DateDebut_Consommation.Size = New System.Drawing.Size(62, 13)
        Me.Text_DateDebut_Consommation.TabIndex = 7
        Me.Text_DateDebut_Consommation.Text = "Date Début"
        '
        'Text_DateFin_Consommation
        '
        Me.Text_DateFin_Consommation.AutoSize = True
        Me.Text_DateFin_Consommation.Location = New System.Drawing.Point(90, 57)
        Me.Text_DateFin_Consommation.Name = "Text_DateFin_Consommation"
        Me.Text_DateFin_Consommation.Size = New System.Drawing.Size(47, 13)
        Me.Text_DateFin_Consommation.TabIndex = 6
        Me.Text_DateFin_Consommation.Text = "Date Fin"
        '
        'DateTime_DateDebut_Consommation
        '
        Me.DateTime_DateDebut_Consommation.CustomFormat = "yyyy-mm-dd"
        Me.DateTime_DateDebut_Consommation.Location = New System.Drawing.Point(175, 25)
        Me.DateTime_DateDebut_Consommation.Name = "DateTime_DateDebut_Consommation"
        Me.DateTime_DateDebut_Consommation.Size = New System.Drawing.Size(200, 20)
        Me.DateTime_DateDebut_Consommation.TabIndex = 5
        '
        'DateTime_DateFin_Consommation
        '
        Me.DateTime_DateFin_Consommation.CustomFormat = "yyyy-mm-dd"
        Me.DateTime_DateFin_Consommation.Location = New System.Drawing.Point(175, 51)
        Me.DateTime_DateFin_Consommation.Name = "DateTime_DateFin_Consommation"
        Me.DateTime_DateFin_Consommation.Size = New System.Drawing.Size(200, 20)
        Me.DateTime_DateFin_Consommation.TabIndex = 4
        '
        'Chart_Consommation
        '
        StripLine1.Text = "Date"
        StripLine1.TextAlignment = System.Drawing.StringAlignment.Center
        ChartArea1.AxisX.StripLines.Add(StripLine1)
        ChartArea1.Name = "ChartArea1"
        Me.Chart_Consommation.ChartAreas.Add(ChartArea1)
        Me.Chart_Consommation.Location = New System.Drawing.Point(22, 93)
        Me.Chart_Consommation.Name = "Chart_Consommation"
        Series1.ChartArea = "ChartArea1"
        Series1.IsValueShownAsLabel = True
        Series1.Name = "Conso"
        Me.Chart_Consommation.Series.Add(Series1)
        Me.Chart_Consommation.Size = New System.Drawing.Size(720, 287)
        Me.Chart_Consommation.TabIndex = 0
        Me.Chart_Consommation.Text = "Consommation de la periode"
        '
        'Text_Titre
        '
        Me.Text_Titre.AutoEllipsis = True
        Me.Text_Titre.AutoSize = True
        Me.Text_Titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Titre.Location = New System.Drawing.Point(298, 9)
        Me.Text_Titre.Name = "Text_Titre"
        Me.Text_Titre.Size = New System.Drawing.Size(127, 24)
        Me.Text_Titre.TabIndex = 1
        Me.Text_Titre.Text = "Nom du client"
        '
        'Form_Double_Clic_Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 448)
        Me.Controls.Add(Me.Text_Titre)
        Me.Controls.Add(Me.Compteurs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Double_Clic_Client"
        Me.Text = "Informations clients"
        Me.Compteurs.ResumeLayout(False)
        Me.Informations.ResumeLayout(False)
        Me.Informations.PerformLayout()
        Me.List_Compteur_DoubleClic.ResumeLayout(False)
        Me.DoubleClic_factures.ResumeLayout(False)
        Me.DoubleClic_factures.PerformLayout()
        Me.DoubleClic_Consommation.ResumeLayout(False)
        Me.DoubleClic_Consommation.PerformLayout()
        CType(Me.Chart_Consommation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Compteurs As System.Windows.Forms.TabControl
    Friend WithEvents Informations As System.Windows.Forms.TabPage
    Friend WithEvents List_Compteur_DoubleClic As System.Windows.Forms.TabPage
    Friend WithEvents DoubleClic_factures As System.Windows.Forms.TabPage
    Friend WithEvents DoubleClic_Consommation As System.Windows.Forms.TabPage
    Friend WithEvents Text_Adresse1_Informations As System.Windows.Forms.Label
    Friend WithEvents Text_Prenom_Informations As System.Windows.Forms.Label
    Friend WithEvents Text_Nom_Informations As System.Windows.Forms.Label
    Friend WithEvents Text_Id_Informations As System.Windows.Forms.Label
    Friend WithEvents Text_Titre As System.Windows.Forms.Label
    Friend WithEvents Enregister As System.Windows.Forms.Button
    Friend WithEvents List_Compteur As System.Windows.Forms.ListView
    Friend WithEvents Compteur As System.Windows.Forms.ColumnHeader
    Friend WithEvents Textbox_Nom_Information As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Prenom_Information As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Adresse1_Information As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Id_Informations As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_CodePostal As System.Windows.Forms.TextBox
    Friend WithEvents Text_CodePostal_Information As System.Windows.Forms.Label
    Friend WithEvents Puissance As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button_Modifier_Compteurs As System.Windows.Forms.Button
    Friend WithEvents Button_Supprimer_Compteurs As System.Windows.Forms.Button
    Friend WithEvents Button_Ajouter_Compteurs As System.Windows.Forms.Button
    Friend WithEvents Text_Datedébut_Factures As System.Windows.Forms.Label
    Friend WithEvents List_Factures As System.Windows.Forms.ListView
    Friend WithEvents Date_facture As System.Windows.Forms.ColumnHeader
    Private WithEvents Colonne_Client_Factures_Num_Compteur As System.Windows.Forms.ColumnHeader
    Friend WithEvents Montant As System.Windows.Forms.ColumnHeader
    Friend WithEvents Address As System.Windows.Forms.ColumnHeader
    Friend WithEvents DateTime_DateDebut_Factures As System.Windows.Forms.DateTimePicker
    Friend WithEvents Chart_Consommation As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Text_DateDebut_Consommation As System.Windows.Forms.Label
    Friend WithEvents Text_DateFin_Consommation As System.Windows.Forms.Label
    Friend WithEvents DateTime_DateDebut_Consommation As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTime_DateFin_Consommation As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox_civilite As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_mail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_ville As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Client_Address As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader_Client_Compteurs_DebutAbonnement As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader_Client_Compteurs_FinAbonnement As System.Windows.Forms.ColumnHeader
    Friend WithEvents DateTime_DateFin_Factures As DateTimePicker
    Friend WithEvents ComboBoxAdresse_Fact As ComboBox
    Friend WithEvents Label_tri_adresse As Label
    Friend WithEvents Label_periode_2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxNumCompteur_Conso As ComboBox
    Friend WithEvents Num As ColumnHeader
    Friend WithEvents CheckBox_mail As CheckBox
    Friend WithEvents CheckBox_Courrier As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxNumCompteur_Fact As ComboBox
End Class
