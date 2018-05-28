<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Recherche
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
        Me.Cout_de_Facturation = New System.Windows.Forms.TabPage()
        Me.GroupBox_Coutdefac_Actuel = New System.Windows.Forms.GroupBox()
        Me.TextBox_Coutdefac_Actuel_TVA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_Coutdefac_Actuel_R2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_Coutdefac_Actuel_R1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox_Recherche_Coutdefac = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTime_datefin_coutdefac = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox_PrixkWh_coutdefac = New System.Windows.Forms.ComboBox()
        Me.Text_TVA_Cotudefac = New System.Windows.Forms.Label()
        Me.Text_Dateactu_Coutdefac = New System.Windows.Forms.Label()
        Me.DateTime_datedeb_coutdefac = New System.Windows.Forms.DateTimePicker()
        Me.List_Coutdefac = New System.Windows.Forms.ListView()
        Me.Colonne_R1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_R2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_TVA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_DateNouvelleActualisation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox_Coutdefac_Recherche = New System.Windows.Forms.GroupBox()
        Me.Factures = New System.Windows.Forms.TabPage()
        Me.Tab_factures = New System.Windows.Forms.ListView()
        Me.Colonne_DateFacture = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_Nomclient = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_Consobois = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_ConsoFuel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_ConsoTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_R1HT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_R1TTC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_R2HT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_R2TTC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_CoutTotalHT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_CoûtTotalTTC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox_Recherche_Facture = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTime_DateFin_Factures = New System.Windows.Forms.DateTimePicker()
        Me.DateTime_DateDebut_Factures = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_Factures_Nom_Client = New System.Windows.Forms.TextBox()
        Me.Text_Idclient_Factures = New System.Windows.Forms.Label()
        Me.GroupBox_Factures_Resultats = New System.Windows.Forms.GroupBox()
        Me.Compteurs = New System.Windows.Forms.TabPage()
        Me.GroupBox_Recherche_Compteur = New System.Windows.Forms.GroupBox()
        Me.TextBox_Nomclient_Compteur = New System.Windows.Forms.TextBox()
        Me.TextBox_Nomcompteur_Compteur = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Text_nomcompteur_Compteur = New System.Windows.Forms.Label()
        Me.TextBox_Adresse_Compteur = New System.Windows.Forms.TextBox()
        Me.Text_Nomclient_Compteur = New System.Windows.Forms.Label()
        Me.GroupBox_Compteurs_Resultats = New System.Windows.Forms.GroupBox()
        Me.Tab_compteur = New System.Windows.Forms.ListView()
        Me.Colonne_Num_compteur = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_Nom_client = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_Adresseclient = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_Puissance = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clients = New System.Windows.Forms.TabPage()
        Me.GroupBox_Recherche_Client = New System.Windows.Forms.GroupBox()
        Me.Text_CodePostal_Clients = New System.Windows.Forms.Label()
        Me.Text_Nom_Client = New System.Windows.Forms.Label()
        Me.TextBox_Nom_Clients = New System.Windows.Forms.TextBox()
        Me.TextBox_CodePostal_Clients = New System.Windows.Forms.TextBox()
        Me.Text_Adresse_Clients = New System.Windows.Forms.Label()
        Me.TextBox_Adresse_Client = New System.Windows.Forms.TextBox()
        Me.GroupBox_Clients_Resultats = New System.Windows.Forms.GroupBox()
        Me.Tab_Clients = New System.Windows.Forms.ListView()
        Me.ColumnHeader_Clients_Civ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_Clients_Nom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_Prénom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_Adressedefac = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_Ville = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_CodePostal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_AdresseMail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Relevés = New System.Windows.Forms.TabPage()
        Me.TextBox_NumCompteur_Releves = New System.Windows.Forms.TextBox()
        Me.GroupBox_Recherche_Releve = New System.Windows.Forms.GroupBox()
        Me.Label_periode_2 = New System.Windows.Forms.Label()
        Me.Text_NomCompteur_Releves = New System.Windows.Forms.Label()
        Me.DateTimePicker_Fin = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_Debut = New System.Windows.Forms.DateTimePicker()
        Me.Text_Datedébut_Factures = New System.Windows.Forms.Label()
        Me.GroupBox_Releves_Resultats = New System.Windows.Forms.GroupBox()
        Me.Tab_releves = New System.Windows.Forms.ListView()
        Me.Colonne_Releves_Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_Releves_NumCompteur = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_Releves_Reelle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_Releves_Date_Theorique = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_Releves_IndexAncien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colonne_Releves_IndexNouveau = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tab_Relevé = New System.Windows.Forms.TabControl()
        Me.ColumnHeader_Clients_Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cout_de_Facturation.SuspendLayout()
        Me.GroupBox_Coutdefac_Actuel.SuspendLayout()
        Me.GroupBox_Recherche_Coutdefac.SuspendLayout()
        Me.Factures.SuspendLayout()
        Me.GroupBox_Recherche_Facture.SuspendLayout()
        Me.Compteurs.SuspendLayout()
        Me.GroupBox_Recherche_Compteur.SuspendLayout()
        Me.GroupBox_Compteurs_Resultats.SuspendLayout()
        Me.Clients.SuspendLayout()
        Me.GroupBox_Recherche_Client.SuspendLayout()
        Me.GroupBox_Clients_Resultats.SuspendLayout()
        Me.Relevés.SuspendLayout()
        Me.GroupBox_Recherche_Releve.SuspendLayout()
        Me.GroupBox_Releves_Resultats.SuspendLayout()
        Me.Tab_Relevé.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cout_de_Facturation
        '
        Me.Cout_de_Facturation.Controls.Add(Me.GroupBox_Coutdefac_Actuel)
        Me.Cout_de_Facturation.Controls.Add(Me.GroupBox_Recherche_Coutdefac)
        Me.Cout_de_Facturation.Controls.Add(Me.List_Coutdefac)
        Me.Cout_de_Facturation.Controls.Add(Me.GroupBox_Coutdefac_Recherche)
        Me.Cout_de_Facturation.Location = New System.Drawing.Point(4, 29)
        Me.Cout_de_Facturation.Name = "Cout_de_Facturation"
        Me.Cout_de_Facturation.Padding = New System.Windows.Forms.Padding(3)
        Me.Cout_de_Facturation.Size = New System.Drawing.Size(858, 418)
        Me.Cout_de_Facturation.TabIndex = 4
        Me.Cout_de_Facturation.Text = "Coût de Facturation"
        Me.Cout_de_Facturation.UseVisualStyleBackColor = True
        '
        'GroupBox_Coutdefac_Actuel
        '
        Me.GroupBox_Coutdefac_Actuel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Coutdefac_Actuel.Controls.Add(Me.TextBox_Coutdefac_Actuel_TVA)
        Me.GroupBox_Coutdefac_Actuel.Controls.Add(Me.Label3)
        Me.GroupBox_Coutdefac_Actuel.Controls.Add(Me.TextBox_Coutdefac_Actuel_R2)
        Me.GroupBox_Coutdefac_Actuel.Controls.Add(Me.Label2)
        Me.GroupBox_Coutdefac_Actuel.Controls.Add(Me.TextBox_Coutdefac_Actuel_R1)
        Me.GroupBox_Coutdefac_Actuel.Controls.Add(Me.Label1)
        Me.GroupBox_Coutdefac_Actuel.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox_Coutdefac_Actuel.Name = "GroupBox_Coutdefac_Actuel"
        Me.GroupBox_Coutdefac_Actuel.Size = New System.Drawing.Size(842, 66)
        Me.GroupBox_Coutdefac_Actuel.TabIndex = 16
        Me.GroupBox_Coutdefac_Actuel.TabStop = False
        Me.GroupBox_Coutdefac_Actuel.Text = "Coût de facturation actuel"
        '
        'TextBox_Coutdefac_Actuel_TVA
        '
        Me.TextBox_Coutdefac_Actuel_TVA.Location = New System.Drawing.Point(606, 30)
        Me.TextBox_Coutdefac_Actuel_TVA.Name = "TextBox_Coutdefac_Actuel_TVA"
        Me.TextBox_Coutdefac_Actuel_TVA.ReadOnly = True
        Me.TextBox_Coutdefac_Actuel_TVA.Size = New System.Drawing.Size(100, 26)
        Me.TextBox_Coutdefac_Actuel_TVA.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(572, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "TVA"
        '
        'TextBox_Coutdefac_Actuel_R2
        '
        Me.TextBox_Coutdefac_Actuel_R2.Location = New System.Drawing.Point(319, 30)
        Me.TextBox_Coutdefac_Actuel_R2.Name = "TextBox_Coutdefac_Actuel_R2"
        Me.TextBox_Coutdefac_Actuel_R2.ReadOnly = True
        Me.TextBox_Coutdefac_Actuel_R2.Size = New System.Drawing.Size(100, 26)
        Me.TextBox_Coutdefac_Actuel_R2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(292, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "R2"
        '
        'TextBox_Coutdefac_Actuel_R1
        '
        Me.TextBox_Coutdefac_Actuel_R1.Location = New System.Drawing.Point(33, 30)
        Me.TextBox_Coutdefac_Actuel_R1.Name = "TextBox_Coutdefac_Actuel_R1"
        Me.TextBox_Coutdefac_Actuel_R1.ReadOnly = True
        Me.TextBox_Coutdefac_Actuel_R1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox_Coutdefac_Actuel_R1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "R1"
        '
        'GroupBox_Recherche_Coutdefac
        '
        Me.GroupBox_Recherche_Coutdefac.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Recherche_Coutdefac.Controls.Add(Me.Label7)
        Me.GroupBox_Recherche_Coutdefac.Controls.Add(Me.DateTime_datefin_coutdefac)
        Me.GroupBox_Recherche_Coutdefac.Controls.Add(Me.ComboBox_PrixkWh_coutdefac)
        Me.GroupBox_Recherche_Coutdefac.Controls.Add(Me.Text_TVA_Cotudefac)
        Me.GroupBox_Recherche_Coutdefac.Controls.Add(Me.Text_Dateactu_Coutdefac)
        Me.GroupBox_Recherche_Coutdefac.Controls.Add(Me.DateTime_datedeb_coutdefac)
        Me.GroupBox_Recherche_Coutdefac.Location = New System.Drawing.Point(8, 78)
        Me.GroupBox_Recherche_Coutdefac.Name = "GroupBox_Recherche_Coutdefac"
        Me.GroupBox_Recherche_Coutdefac.Size = New System.Drawing.Size(844, 106)
        Me.GroupBox_Recherche_Coutdefac.TabIndex = 10
        Me.GroupBox_Recherche_Coutdefac.TabStop = False
        Me.GroupBox_Recherche_Coutdefac.Text = "Recherche d'un coût de facturation"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(384, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "à"
        '
        'DateTime_datefin_coutdefac
        '
        Me.DateTime_datefin_coutdefac.Location = New System.Drawing.Point(429, 31)
        Me.DateTime_datefin_coutdefac.Name = "DateTime_datefin_coutdefac"
        Me.DateTime_datefin_coutdefac.Size = New System.Drawing.Size(200, 26)
        Me.DateTime_datefin_coutdefac.TabIndex = 16
        '
        'ComboBox_PrixkWh_coutdefac
        '
        Me.ComboBox_PrixkWh_coutdefac.FormattingEnabled = True
        Me.ComboBox_PrixkWh_coutdefac.Location = New System.Drawing.Point(175, 63)
        Me.ComboBox_PrixkWh_coutdefac.Name = "ComboBox_PrixkWh_coutdefac"
        Me.ComboBox_PrixkWh_coutdefac.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox_PrixkWh_coutdefac.TabIndex = 15
        Me.ComboBox_PrixkWh_coutdefac.Text = "Prix kWh"
        '
        'Text_TVA_Cotudefac
        '
        Me.Text_TVA_Cotudefac.AutoSize = True
        Me.Text_TVA_Cotudefac.Location = New System.Drawing.Point(105, 66)
        Me.Text_TVA_Cotudefac.Name = "Text_TVA_Cotudefac"
        Me.Text_TVA_Cotudefac.Size = New System.Drawing.Size(40, 20)
        Me.Text_TVA_Cotudefac.TabIndex = 13
        Me.Text_TVA_Cotudefac.Text = "TVA"
        '
        'Text_Dateactu_Coutdefac
        '
        Me.Text_Dateactu_Coutdefac.AutoSize = True
        Me.Text_Dateactu_Coutdefac.Location = New System.Drawing.Point(6, 37)
        Me.Text_Dateactu_Coutdefac.Name = "Text_Dateactu_Coutdefac"
        Me.Text_Dateactu_Coutdefac.Size = New System.Drawing.Size(161, 20)
        Me.Text_Dateactu_Coutdefac.TabIndex = 11
        Me.Text_Dateactu_Coutdefac.Text = "Date Actualisation de"
        '
        'DateTime_datedeb_coutdefac
        '
        Me.DateTime_datedeb_coutdefac.Location = New System.Drawing.Point(175, 31)
        Me.DateTime_datedeb_coutdefac.Name = "DateTime_datedeb_coutdefac"
        Me.DateTime_datedeb_coutdefac.Size = New System.Drawing.Size(200, 26)
        Me.DateTime_datedeb_coutdefac.TabIndex = 10
        '
        'List_Coutdefac
        '
        Me.List_Coutdefac.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.List_Coutdefac.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Colonne_R1, Me.Colonne_R2, Me.Colonne_TVA, Me.Colonne_DateNouvelleActualisation})
        Me.List_Coutdefac.GridLines = True
        Me.List_Coutdefac.Location = New System.Drawing.Point(17, 209)
        Me.List_Coutdefac.Name = "List_Coutdefac"
        Me.List_Coutdefac.Size = New System.Drawing.Size(827, 197)
        Me.List_Coutdefac.TabIndex = 0
        Me.List_Coutdefac.UseCompatibleStateImageBehavior = False
        Me.List_Coutdefac.View = System.Windows.Forms.View.Details
        '
        'Colonne_R1
        '
        Me.Colonne_R1.Text = "R1"
        Me.Colonne_R1.Width = 90
        '
        'Colonne_R2
        '
        Me.Colonne_R2.Text = "R2"
        Me.Colonne_R2.Width = 94
        '
        'Colonne_TVA
        '
        Me.Colonne_TVA.Text = "TVA"
        Me.Colonne_TVA.Width = 100
        '
        'Colonne_DateNouvelleActualisation
        '
        Me.Colonne_DateNouvelleActualisation.Text = "Date Nouvelle Actualisation"
        Me.Colonne_DateNouvelleActualisation.Width = 179
        '
        'GroupBox_Coutdefac_Recherche
        '
        Me.GroupBox_Coutdefac_Recherche.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Coutdefac_Recherche.Location = New System.Drawing.Point(8, 190)
        Me.GroupBox_Coutdefac_Recherche.Name = "GroupBox_Coutdefac_Recherche"
        Me.GroupBox_Coutdefac_Recherche.Size = New System.Drawing.Size(842, 222)
        Me.GroupBox_Coutdefac_Recherche.TabIndex = 17
        Me.GroupBox_Coutdefac_Recherche.TabStop = False
        Me.GroupBox_Coutdefac_Recherche.Text = "Résultats obtenus :"
        '
        'Factures
        '
        Me.Factures.Controls.Add(Me.Tab_factures)
        Me.Factures.Controls.Add(Me.GroupBox_Recherche_Facture)
        Me.Factures.Controls.Add(Me.GroupBox_Factures_Resultats)
        Me.Factures.Location = New System.Drawing.Point(4, 29)
        Me.Factures.Name = "Factures"
        Me.Factures.Padding = New System.Windows.Forms.Padding(3)
        Me.Factures.Size = New System.Drawing.Size(858, 418)
        Me.Factures.TabIndex = 3
        Me.Factures.Text = "Factures"
        Me.Factures.UseVisualStyleBackColor = True
        '
        'Tab_factures
        '
        Me.Tab_factures.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_factures.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Colonne_DateFacture, Me.Colonne_Nomclient, Me.Colonne_Consobois, Me.Colonne_ConsoFuel, Me.Colonne_ConsoTotal, Me.Colonne_R1HT, Me.Colonne_R1TTC, Me.Colonne_R2HT, Me.Colonne_R2TTC, Me.Colonne_CoutTotalHT, Me.Colonne_CoûtTotalTTC})
        Me.Tab_factures.GridLines = True
        Me.Tab_factures.Location = New System.Drawing.Point(14, 142)
        Me.Tab_factures.Name = "Tab_factures"
        Me.Tab_factures.Size = New System.Drawing.Size(832, 264)
        Me.Tab_factures.TabIndex = 0
        Me.Tab_factures.UseCompatibleStateImageBehavior = False
        Me.Tab_factures.View = System.Windows.Forms.View.Details
        '
        'Colonne_DateFacture
        '
        Me.Colonne_DateFacture.Text = "Date Facture"
        Me.Colonne_DateFacture.Width = 89
        '
        'Colonne_Nomclient
        '
        Me.Colonne_Nomclient.Text = "Nom du client"
        Me.Colonne_Nomclient.Width = 88
        '
        'Colonne_Consobois
        '
        Me.Colonne_Consobois.Text = "Conso Bois"
        Me.Colonne_Consobois.Width = 87
        '
        'Colonne_ConsoFuel
        '
        Me.Colonne_ConsoFuel.Text = "Conso Fuel"
        Me.Colonne_ConsoFuel.Width = 70
        '
        'Colonne_ConsoTotal
        '
        Me.Colonne_ConsoTotal.Text = "Conso Total"
        Me.Colonne_ConsoTotal.Width = 81
        '
        'Colonne_R1HT
        '
        Me.Colonne_R1HT.Text = "R1 HT"
        Me.Colonne_R1HT.Width = 47
        '
        'Colonne_R1TTC
        '
        Me.Colonne_R1TTC.Text = "R1 TTC"
        Me.Colonne_R1TTC.Width = 54
        '
        'Colonne_R2HT
        '
        Me.Colonne_R2HT.Text = "R2 HT"
        Me.Colonne_R2HT.Width = 50
        '
        'Colonne_R2TTC
        '
        Me.Colonne_R2TTC.Text = "R2 TTC"
        Me.Colonne_R2TTC.Width = 57
        '
        'Colonne_CoutTotalHT
        '
        Me.Colonne_CoutTotalHT.Text = "Coût Total HT"
        Me.Colonne_CoutTotalHT.Width = 97
        '
        'Colonne_CoûtTotalTTC
        '
        Me.Colonne_CoûtTotalTTC.Text = "Coût Total TTC"
        Me.Colonne_CoûtTotalTTC.Width = 101
        '
        'GroupBox_Recherche_Facture
        '
        Me.GroupBox_Recherche_Facture.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Recherche_Facture.Controls.Add(Me.Label5)
        Me.GroupBox_Recherche_Facture.Controls.Add(Me.DateTime_DateFin_Factures)
        Me.GroupBox_Recherche_Facture.Controls.Add(Me.DateTime_DateDebut_Factures)
        Me.GroupBox_Recherche_Facture.Controls.Add(Me.Label6)
        Me.GroupBox_Recherche_Facture.Controls.Add(Me.TextBox_Factures_Nom_Client)
        Me.GroupBox_Recherche_Facture.Controls.Add(Me.Text_Idclient_Factures)
        Me.GroupBox_Recherche_Facture.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox_Recherche_Facture.Name = "GroupBox_Recherche_Facture"
        Me.GroupBox_Recherche_Facture.Size = New System.Drawing.Size(844, 111)
        Me.GroupBox_Recherche_Facture.TabIndex = 6
        Me.GroupBox_Recherche_Facture.TabStop = False
        Me.GroupBox_Recherche_Facture.Text = "Recherche d'une facture"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(353, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "au"
        '
        'DateTime_DateFin_Factures
        '
        Me.DateTime_DateFin_Factures.Location = New System.Drawing.Point(394, 47)
        Me.DateTime_DateFin_Factures.Name = "DateTime_DateFin_Factures"
        Me.DateTime_DateFin_Factures.Size = New System.Drawing.Size(200, 26)
        Me.DateTime_DateFin_Factures.TabIndex = 13
        '
        'DateTime_DateDebut_Factures
        '
        Me.DateTime_DateDebut_Factures.Location = New System.Drawing.Point(128, 47)
        Me.DateTime_DateDebut_Factures.Name = "DateTime_DateDebut_Factures"
        Me.DateTime_DateDebut_Factures.Size = New System.Drawing.Size(200, 26)
        Me.DateTime_DateDebut_Factures.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Location = New System.Drawing.Point(6, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Date de la facture :  du"
        '
        'TextBox_Factures_Nom_Client
        '
        Me.TextBox_Factures_Nom_Client.Location = New System.Drawing.Point(128, 73)
        Me.TextBox_Factures_Nom_Client.Name = "TextBox_Factures_Nom_Client"
        Me.TextBox_Factures_Nom_Client.Size = New System.Drawing.Size(100, 26)
        Me.TextBox_Factures_Nom_Client.TabIndex = 5
        '
        'Text_Idclient_Factures
        '
        Me.Text_Idclient_Factures.AutoSize = True
        Me.Text_Idclient_Factures.Location = New System.Drawing.Point(50, 76)
        Me.Text_Idclient_Factures.Name = "Text_Idclient_Factures"
        Me.Text_Idclient_Factures.Size = New System.Drawing.Size(105, 20)
        Me.Text_Idclient_Factures.TabIndex = 4
        Me.Text_Idclient_Factures.Text = "Nom du client"
        '
        'GroupBox_Factures_Resultats
        '
        Me.GroupBox_Factures_Resultats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Factures_Resultats.Location = New System.Drawing.Point(8, 123)
        Me.GroupBox_Factures_Resultats.Name = "GroupBox_Factures_Resultats"
        Me.GroupBox_Factures_Resultats.Size = New System.Drawing.Size(844, 289)
        Me.GroupBox_Factures_Resultats.TabIndex = 7
        Me.GroupBox_Factures_Resultats.TabStop = False
        Me.GroupBox_Factures_Resultats.Text = "Résultats obtenus :"
        '
        'Compteurs
        '
        Me.Compteurs.Controls.Add(Me.GroupBox_Recherche_Compteur)
        Me.Compteurs.Controls.Add(Me.GroupBox_Compteurs_Resultats)
        Me.Compteurs.Location = New System.Drawing.Point(4, 29)
        Me.Compteurs.Name = "Compteurs"
        Me.Compteurs.Padding = New System.Windows.Forms.Padding(3)
        Me.Compteurs.Size = New System.Drawing.Size(858, 418)
        Me.Compteurs.TabIndex = 2
        Me.Compteurs.Text = "Compteurs"
        Me.Compteurs.UseVisualStyleBackColor = True
        '
        'GroupBox_Recherche_Compteur
        '
        Me.GroupBox_Recherche_Compteur.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Recherche_Compteur.Controls.Add(Me.TextBox_Nomclient_Compteur)
        Me.GroupBox_Recherche_Compteur.Controls.Add(Me.TextBox_Nomcompteur_Compteur)
        Me.GroupBox_Recherche_Compteur.Controls.Add(Me.Label4)
        Me.GroupBox_Recherche_Compteur.Controls.Add(Me.Text_nomcompteur_Compteur)
        Me.GroupBox_Recherche_Compteur.Controls.Add(Me.TextBox_Adresse_Compteur)
        Me.GroupBox_Recherche_Compteur.Controls.Add(Me.Text_Nomclient_Compteur)
        Me.GroupBox_Recherche_Compteur.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox_Recherche_Compteur.Name = "GroupBox_Recherche_Compteur"
        Me.GroupBox_Recherche_Compteur.Size = New System.Drawing.Size(844, 106)
        Me.GroupBox_Recherche_Compteur.TabIndex = 9
        Me.GroupBox_Recherche_Compteur.TabStop = False
        Me.GroupBox_Recherche_Compteur.Text = "Recherche d'un compteur"
        '
        'TextBox_Nomclient_Compteur
        '
        Me.TextBox_Nomclient_Compteur.Location = New System.Drawing.Point(159, 49)
        Me.TextBox_Nomclient_Compteur.Name = "TextBox_Nomclient_Compteur"
        Me.TextBox_Nomclient_Compteur.Size = New System.Drawing.Size(146, 26)
        Me.TextBox_Nomclient_Compteur.TabIndex = 4
        '
        'TextBox_Nomcompteur_Compteur
        '
        Me.TextBox_Nomcompteur_Compteur.Location = New System.Drawing.Point(159, 24)
        Me.TextBox_Nomcompteur_Compteur.Name = "TextBox_Nomcompteur_Compteur"
        Me.TextBox_Nomcompteur_Compteur.Size = New System.Drawing.Size(146, 26)
        Me.TextBox_Nomcompteur_Compteur.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Adresse"
        '
        'Text_nomcompteur_Compteur
        '
        Me.Text_nomcompteur_Compteur.AutoSize = True
        Me.Text_nomcompteur_Compteur.Location = New System.Drawing.Point(17, 30)
        Me.Text_nomcompteur_Compteur.Name = "Text_nomcompteur_Compteur"
        Me.Text_nomcompteur_Compteur.Size = New System.Drawing.Size(116, 20)
        Me.Text_nomcompteur_Compteur.TabIndex = 2
        Me.Text_nomcompteur_Compteur.Text = "Num Compteur"
        '
        'TextBox_Adresse_Compteur
        '
        Me.TextBox_Adresse_Compteur.Location = New System.Drawing.Point(159, 75)
        Me.TextBox_Adresse_Compteur.Name = "TextBox_Adresse_Compteur"
        Me.TextBox_Adresse_Compteur.Size = New System.Drawing.Size(146, 26)
        Me.TextBox_Adresse_Compteur.TabIndex = 12
        '
        'Text_Nomclient_Compteur
        '
        Me.Text_Nomclient_Compteur.AutoSize = True
        Me.Text_Nomclient_Compteur.Location = New System.Drawing.Point(47, 55)
        Me.Text_Nomclient_Compteur.Name = "Text_Nomclient_Compteur"
        Me.Text_Nomclient_Compteur.Size = New System.Drawing.Size(86, 20)
        Me.Text_Nomclient_Compteur.TabIndex = 1
        Me.Text_Nomclient_Compteur.Text = "Nom Client"
        '
        'GroupBox_Compteurs_Resultats
        '
        Me.GroupBox_Compteurs_Resultats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Compteurs_Resultats.Controls.Add(Me.Tab_compteur)
        Me.GroupBox_Compteurs_Resultats.Location = New System.Drawing.Point(8, 118)
        Me.GroupBox_Compteurs_Resultats.Name = "GroupBox_Compteurs_Resultats"
        Me.GroupBox_Compteurs_Resultats.Size = New System.Drawing.Size(844, 294)
        Me.GroupBox_Compteurs_Resultats.TabIndex = 10
        Me.GroupBox_Compteurs_Resultats.TabStop = False
        Me.GroupBox_Compteurs_Resultats.Text = "Résultats obtenus :"
        '
        'Tab_compteur
        '
        Me.Tab_compteur.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.Tab_compteur.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_compteur.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Colonne_Num_compteur, Me.Colonne_Nom_client, Me.Colonne_Adresseclient, Me.Colonne_Puissance})
        Me.Tab_compteur.GridLines = True
        Me.Tab_compteur.Location = New System.Drawing.Point(6, 25)
        Me.Tab_compteur.Name = "Tab_compteur"
        Me.Tab_compteur.Size = New System.Drawing.Size(832, 263)
        Me.Tab_compteur.TabIndex = 0
        Me.Tab_compteur.UseCompatibleStateImageBehavior = False
        Me.Tab_compteur.View = System.Windows.Forms.View.Details
        '
        'Colonne_Num_compteur
        '
        Me.Colonne_Num_compteur.Text = "Num Compteur"
        Me.Colonne_Num_compteur.Width = 133
        '
        'Colonne_Nom_client
        '
        Me.Colonne_Nom_client.Text = "Nom Client"
        Me.Colonne_Nom_client.Width = 145
        '
        'Colonne_Adresseclient
        '
        Me.Colonne_Adresseclient.Text = "Adresse Livraison"
        Me.Colonne_Adresseclient.Width = 160
        '
        'Colonne_Puissance
        '
        Me.Colonne_Puissance.Text = "Puissance"
        Me.Colonne_Puissance.Width = 103
        '
        'Clients
        '
        Me.Clients.Controls.Add(Me.GroupBox_Recherche_Client)
        Me.Clients.Controls.Add(Me.GroupBox_Clients_Resultats)
        Me.Clients.Location = New System.Drawing.Point(4, 29)
        Me.Clients.Name = "Clients"
        Me.Clients.Padding = New System.Windows.Forms.Padding(3)
        Me.Clients.Size = New System.Drawing.Size(858, 418)
        Me.Clients.TabIndex = 1
        Me.Clients.Text = "Clients"
        Me.Clients.UseVisualStyleBackColor = True
        '
        'GroupBox_Recherche_Client
        '
        Me.GroupBox_Recherche_Client.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Recherche_Client.Controls.Add(Me.Text_CodePostal_Clients)
        Me.GroupBox_Recherche_Client.Controls.Add(Me.Text_Nom_Client)
        Me.GroupBox_Recherche_Client.Controls.Add(Me.TextBox_Nom_Clients)
        Me.GroupBox_Recherche_Client.Controls.Add(Me.TextBox_CodePostal_Clients)
        Me.GroupBox_Recherche_Client.Controls.Add(Me.Text_Adresse_Clients)
        Me.GroupBox_Recherche_Client.Controls.Add(Me.TextBox_Adresse_Client)
        Me.GroupBox_Recherche_Client.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox_Recherche_Client.Name = "GroupBox_Recherche_Client"
        Me.GroupBox_Recherche_Client.Size = New System.Drawing.Size(844, 111)
        Me.GroupBox_Recherche_Client.TabIndex = 11
        Me.GroupBox_Recherche_Client.TabStop = False
        Me.GroupBox_Recherche_Client.Text = "Recherche d'un client"
        '
        'Text_CodePostal_Clients
        '
        Me.Text_CodePostal_Clients.AutoSize = True
        Me.Text_CodePostal_Clients.Location = New System.Drawing.Point(6, 88)
        Me.Text_CodePostal_Clients.Name = "Text_CodePostal_Clients"
        Me.Text_CodePostal_Clients.Size = New System.Drawing.Size(95, 20)
        Me.Text_CodePostal_Clients.TabIndex = 4
        Me.Text_CodePostal_Clients.Text = "Code Postal"
        '
        'Text_Nom_Client
        '
        Me.Text_Nom_Client.AutoSize = True
        Me.Text_Nom_Client.Location = New System.Drawing.Point(59, 31)
        Me.Text_Nom_Client.Name = "Text_Nom_Client"
        Me.Text_Nom_Client.Size = New System.Drawing.Size(42, 20)
        Me.Text_Nom_Client.TabIndex = 2
        Me.Text_Nom_Client.Text = "Nom"
        '
        'TextBox_Nom_Clients
        '
        Me.TextBox_Nom_Clients.Location = New System.Drawing.Point(120, 29)
        Me.TextBox_Nom_Clients.Name = "TextBox_Nom_Clients"
        Me.TextBox_Nom_Clients.Size = New System.Drawing.Size(172, 26)
        Me.TextBox_Nom_Clients.TabIndex = 5
        '
        'TextBox_CodePostal_Clients
        '
        Me.TextBox_CodePostal_Clients.Location = New System.Drawing.Point(120, 84)
        Me.TextBox_CodePostal_Clients.Name = "TextBox_CodePostal_Clients"
        Me.TextBox_CodePostal_Clients.Size = New System.Drawing.Size(69, 26)
        Me.TextBox_CodePostal_Clients.TabIndex = 7
        '
        'Text_Adresse_Clients
        '
        Me.Text_Adresse_Clients.AutoSize = True
        Me.Text_Adresse_Clients.Location = New System.Drawing.Point(33, 60)
        Me.Text_Adresse_Clients.Name = "Text_Adresse_Clients"
        Me.Text_Adresse_Clients.Size = New System.Drawing.Size(68, 20)
        Me.Text_Adresse_Clients.TabIndex = 3
        Me.Text_Adresse_Clients.Text = "Adresse"
        '
        'TextBox_Adresse_Client
        '
        Me.TextBox_Adresse_Client.Location = New System.Drawing.Point(120, 56)
        Me.TextBox_Adresse_Client.Name = "TextBox_Adresse_Client"
        Me.TextBox_Adresse_Client.Size = New System.Drawing.Size(239, 26)
        Me.TextBox_Adresse_Client.TabIndex = 6
        '
        'GroupBox_Clients_Resultats
        '
        Me.GroupBox_Clients_Resultats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Clients_Resultats.Controls.Add(Me.Tab_Clients)
        Me.GroupBox_Clients_Resultats.Location = New System.Drawing.Point(8, 123)
        Me.GroupBox_Clients_Resultats.Name = "GroupBox_Clients_Resultats"
        Me.GroupBox_Clients_Resultats.Size = New System.Drawing.Size(844, 289)
        Me.GroupBox_Clients_Resultats.TabIndex = 12
        Me.GroupBox_Clients_Resultats.TabStop = False
        Me.GroupBox_Clients_Resultats.Text = "Résultats obtenus :"
        '
        'Tab_Clients
        '
        Me.Tab_Clients.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.Tab_Clients.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_Clients.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader_Clients_Id, Me.ColumnHeader_Clients_Civ, Me.ColumnHeader_Clients_Nom, Me.Colonne_Prénom, Me.Colonne_Adressedefac, Me.Colonne_Ville, Me.Colonne_CodePostal, Me.Colonne_AdresseMail})
        Me.Tab_Clients.FullRowSelect = True
        Me.Tab_Clients.GridLines = True
        Me.Tab_Clients.Location = New System.Drawing.Point(6, 19)
        Me.Tab_Clients.Name = "Tab_Clients"
        Me.Tab_Clients.Size = New System.Drawing.Size(832, 264)
        Me.Tab_Clients.TabIndex = 0
        Me.Tab_Clients.UseCompatibleStateImageBehavior = False
        Me.Tab_Clients.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader_Clients_Civ
        '
        Me.ColumnHeader_Clients_Civ.Text = "Civ"
        Me.ColumnHeader_Clients_Civ.Width = 37
        '
        'ColumnHeader_Clients_Nom
        '
        Me.ColumnHeader_Clients_Nom.Text = "Nom"
        '
        'Colonne_Prénom
        '
        Me.Colonne_Prénom.Text = "Prénom"
        Me.Colonne_Prénom.Width = 78
        '
        'Colonne_Adressedefac
        '
        Me.Colonne_Adressedefac.Text = "Adresse de facturation"
        Me.Colonne_Adressedefac.Width = 194
        '
        'Colonne_Ville
        '
        Me.Colonne_Ville.Text = "Ville"
        Me.Colonne_Ville.Width = 107
        '
        'Colonne_CodePostal
        '
        Me.Colonne_CodePostal.Text = "Code Postal"
        Me.Colonne_CodePostal.Width = 96
        '
        'Colonne_AdresseMail
        '
        Me.Colonne_AdresseMail.Text = "Adresse Mail"
        Me.Colonne_AdresseMail.Width = 109
        '
        'Relevés
        '
        Me.Relevés.Controls.Add(Me.TextBox_NumCompteur_Releves)
        Me.Relevés.Controls.Add(Me.GroupBox_Recherche_Releve)
        Me.Relevés.Controls.Add(Me.GroupBox_Releves_Resultats)
        Me.Relevés.Location = New System.Drawing.Point(4, 29)
        Me.Relevés.Name = "Relevés"
        Me.Relevés.Padding = New System.Windows.Forms.Padding(3)
        Me.Relevés.Size = New System.Drawing.Size(858, 418)
        Me.Relevés.TabIndex = 0
        Me.Relevés.Text = "Relevés"
        Me.Relevés.UseVisualStyleBackColor = True
        '
        'TextBox_NumCompteur_Releves
        '
        Me.TextBox_NumCompteur_Releves.Location = New System.Drawing.Point(157, 35)
        Me.TextBox_NumCompteur_Releves.Name = "TextBox_NumCompteur_Releves"
        Me.TextBox_NumCompteur_Releves.Size = New System.Drawing.Size(100, 26)
        Me.TextBox_NumCompteur_Releves.TabIndex = 6
        '
        'GroupBox_Recherche_Releve
        '
        Me.GroupBox_Recherche_Releve.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Recherche_Releve.Controls.Add(Me.Label_periode_2)
        Me.GroupBox_Recherche_Releve.Controls.Add(Me.Text_NomCompteur_Releves)
        Me.GroupBox_Recherche_Releve.Controls.Add(Me.DateTimePicker_Fin)
        Me.GroupBox_Recherche_Releve.Controls.Add(Me.DateTimePicker_Debut)
        Me.GroupBox_Recherche_Releve.Controls.Add(Me.Text_Datedébut_Factures)
        Me.GroupBox_Recherche_Releve.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox_Recherche_Releve.Name = "GroupBox_Recherche_Releve"
        Me.GroupBox_Recherche_Releve.Size = New System.Drawing.Size(844, 101)
        Me.GroupBox_Recherche_Releve.TabIndex = 10
        Me.GroupBox_Recherche_Releve.TabStop = False
        Me.GroupBox_Recherche_Releve.Text = "Recherche d'un relevé"
        '
        'Label_periode_2
        '
        Me.Label_periode_2.AutoSize = True
        Me.Label_periode_2.Location = New System.Drawing.Point(364, 67)
        Me.Label_periode_2.Name = "Label_periode_2"
        Me.Label_periode_2.Size = New System.Drawing.Size(27, 20)
        Me.Label_periode_2.TabIndex = 15
        Me.Label_periode_2.Text = "au"
        '
        'Text_NomCompteur_Releves
        '
        Me.Text_NomCompteur_Releves.AutoSize = True
        Me.Text_NomCompteur_Releves.Location = New System.Drawing.Point(29, 32)
        Me.Text_NomCompteur_Releves.Name = "Text_NomCompteur_Releves"
        Me.Text_NomCompteur_Releves.Size = New System.Drawing.Size(116, 20)
        Me.Text_NomCompteur_Releves.TabIndex = 3
        Me.Text_NomCompteur_Releves.Text = "Num Compteur"
        '
        'DateTimePicker_Fin
        '
        Me.DateTimePicker_Fin.Location = New System.Drawing.Point(397, 64)
        Me.DateTimePicker_Fin.Name = "DateTimePicker_Fin"
        Me.DateTimePicker_Fin.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker_Fin.TabIndex = 14
        '
        'DateTimePicker_Debut
        '
        Me.DateTimePicker_Debut.Location = New System.Drawing.Point(158, 62)
        Me.DateTimePicker_Debut.Name = "DateTimePicker_Debut"
        Me.DateTimePicker_Debut.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker_Debut.TabIndex = 13
        '
        'Text_Datedébut_Factures
        '
        Me.Text_Datedébut_Factures.AutoSize = True
        Me.Text_Datedébut_Factures.Location = New System.Drawing.Point(6, 64)
        Me.Text_Datedébut_Factures.Name = "Text_Datedébut_Factures"
        Me.Text_Datedébut_Factures.Size = New System.Drawing.Size(146, 20)
        Me.Text_Datedébut_Factures.TabIndex = 12
        Me.Text_Datedébut_Factures.Text = "Date du relevé :  du"
        '
        'GroupBox_Releves_Resultats
        '
        Me.GroupBox_Releves_Resultats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Releves_Resultats.Controls.Add(Me.Tab_releves)
        Me.GroupBox_Releves_Resultats.Location = New System.Drawing.Point(8, 113)
        Me.GroupBox_Releves_Resultats.Name = "GroupBox_Releves_Resultats"
        Me.GroupBox_Releves_Resultats.Size = New System.Drawing.Size(844, 299)
        Me.GroupBox_Releves_Resultats.TabIndex = 11
        Me.GroupBox_Releves_Resultats.TabStop = False
        Me.GroupBox_Releves_Resultats.Text = "Résultats obtenus :"
        '
        'Tab_releves
        '
        Me.Tab_releves.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.Tab_releves.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_releves.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Colonne_Releves_Id, Me.Colonne_Releves_NumCompteur, Me.Colonne_Releves_Reelle, Me.ColumnHeader_Releves_Date_Theorique, Me.Colonne_Releves_IndexAncien, Me.Colonne_Releves_IndexNouveau})
        Me.Tab_releves.FullRowSelect = True
        Me.Tab_releves.GridLines = True
        Me.Tab_releves.Location = New System.Drawing.Point(6, 19)
        Me.Tab_releves.Name = "Tab_releves"
        Me.Tab_releves.Size = New System.Drawing.Size(832, 274)
        Me.Tab_releves.TabIndex = 0
        Me.Tab_releves.UseCompatibleStateImageBehavior = False
        Me.Tab_releves.View = System.Windows.Forms.View.Details
        '
        'Colonne_Releves_Id
        '
        Me.Colonne_Releves_Id.Text = "Id"
        '
        'Colonne_Releves_NumCompteur
        '
        Me.Colonne_Releves_NumCompteur.Text = "Numéro compteur"
        Me.Colonne_Releves_NumCompteur.Width = 111
        '
        'Colonne_Releves_Reelle
        '
        Me.Colonne_Releves_Reelle.Text = "Date réelle"
        Me.Colonne_Releves_Reelle.Width = 103
        '
        'ColumnHeader_Releves_Date_Theorique
        '
        Me.ColumnHeader_Releves_Date_Theorique.Text = "Date théorique"
        Me.ColumnHeader_Releves_Date_Theorique.Width = 90
        '
        'Colonne_Releves_IndexAncien
        '
        Me.Colonne_Releves_IndexAncien.Text = "Index ancien"
        Me.Colonne_Releves_IndexAncien.Width = 105
        '
        'Colonne_Releves_IndexNouveau
        '
        Me.Colonne_Releves_IndexNouveau.Text = "Index nouveau"
        Me.Colonne_Releves_IndexNouveau.Width = 104
        '
        'Tab_Relevé
        '
        Me.Tab_Relevé.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_Relevé.Controls.Add(Me.Relevés)
        Me.Tab_Relevé.Controls.Add(Me.Clients)
        Me.Tab_Relevé.Controls.Add(Me.Compteurs)
        Me.Tab_Relevé.Controls.Add(Me.Factures)
        Me.Tab_Relevé.Controls.Add(Me.Cout_de_Facturation)
        Me.Tab_Relevé.Location = New System.Drawing.Point(3, 35)
        Me.Tab_Relevé.Name = "Tab_Relevé"
        Me.Tab_Relevé.SelectedIndex = 0
        Me.Tab_Relevé.Size = New System.Drawing.Size(866, 451)
        Me.Tab_Relevé.TabIndex = 0
        '
        'ColumnHeader_Clients_Id
        '
        Me.ColumnHeader_Clients_Id.Text = "Id"
        '
        'Form_Recherche
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(869, 476)
        Me.ControlBox = False
        Me.Controls.Add(Me.Tab_Relevé)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Recherche"
        Me.Text = "Accueil"
        Me.Cout_de_Facturation.ResumeLayout(False)
        Me.GroupBox_Coutdefac_Actuel.ResumeLayout(False)
        Me.GroupBox_Coutdefac_Actuel.PerformLayout()
        Me.GroupBox_Recherche_Coutdefac.ResumeLayout(False)
        Me.GroupBox_Recherche_Coutdefac.PerformLayout()
        Me.Factures.ResumeLayout(False)
        Me.GroupBox_Recherche_Facture.ResumeLayout(False)
        Me.GroupBox_Recherche_Facture.PerformLayout()
        Me.Compteurs.ResumeLayout(False)
        Me.GroupBox_Recherche_Compteur.ResumeLayout(False)
        Me.GroupBox_Recherche_Compteur.PerformLayout()
        Me.GroupBox_Compteurs_Resultats.ResumeLayout(False)
        Me.Clients.ResumeLayout(False)
        Me.GroupBox_Recherche_Client.ResumeLayout(False)
        Me.GroupBox_Recherche_Client.PerformLayout()
        Me.GroupBox_Clients_Resultats.ResumeLayout(False)
        Me.Relevés.ResumeLayout(False)
        Me.Relevés.PerformLayout()
        Me.GroupBox_Recherche_Releve.ResumeLayout(False)
        Me.GroupBox_Recherche_Releve.PerformLayout()
        Me.GroupBox_Releves_Resultats.ResumeLayout(False)
        Me.Tab_Relevé.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cout_de_Facturation As System.Windows.Forms.TabPage
    Friend WithEvents List_Coutdefac As System.Windows.Forms.ListView
    Friend WithEvents Factures As System.Windows.Forms.TabPage
    Friend WithEvents Tab_factures As System.Windows.Forms.ListView
    Friend WithEvents Compteurs As System.Windows.Forms.TabPage
    Friend WithEvents Tab_compteur As System.Windows.Forms.ListView
    Friend WithEvents Clients As System.Windows.Forms.TabPage
    Friend WithEvents Relevés As System.Windows.Forms.TabPage
    Friend WithEvents TextBox_NumCompteur_Releves As System.Windows.Forms.TextBox
    Friend WithEvents Text_NomCompteur_Releves As System.Windows.Forms.Label
    Friend WithEvents Tab_releves As System.Windows.Forms.ListView
    Friend WithEvents Colonne_Releves_NumCompteur As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_Releves_Reelle As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_Releves_IndexAncien As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_Releves_IndexNouveau As System.Windows.Forms.ColumnHeader
    Friend WithEvents Tab_Relevé As System.Windows.Forms.TabControl
    Friend WithEvents TextBox_CodePostal_Clients As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Adresse_Client As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Nom_Clients As System.Windows.Forms.TextBox
    Friend WithEvents Text_CodePostal_Clients As System.Windows.Forms.Label
    Friend WithEvents Text_Adresse_Clients As System.Windows.Forms.Label
    Friend WithEvents Text_Nom_Client As System.Windows.Forms.Label
    Friend WithEvents Tab_Clients As System.Windows.Forms.ListView
    Friend WithEvents Colonne_Adressedefac As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_Ville As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_CodePostal As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_AdresseMail As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_Num_compteur As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_Nom_client As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_Adresseclient As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_Puissance As System.Windows.Forms.ColumnHeader
    Friend WithEvents Text_Nomclient_Compteur As System.Windows.Forms.Label
    Friend WithEvents Text_nomcompteur_Compteur As System.Windows.Forms.Label
    Friend WithEvents TextBox_Nomclient_Compteur As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Nomcompteur_Compteur As System.Windows.Forms.TextBox
    Friend WithEvents Text_Idclient_Factures As System.Windows.Forms.Label
    Friend WithEvents GroupBox_Recherche_Coutdefac As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox_PrixkWh_coutdefac As System.Windows.Forms.ComboBox
    Friend WithEvents Text_TVA_Cotudefac As System.Windows.Forms.Label
    Friend WithEvents Text_Dateactu_Coutdefac As System.Windows.Forms.Label
    Friend WithEvents DateTime_datedeb_coutdefac As System.Windows.Forms.DateTimePicker
    Friend WithEvents Colonne_Prénom As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_Releves_Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_DateFacture As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_Nomclient As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_Consobois As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_ConsoFuel As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_ConsoTotal As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_R1HT As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_R1TTC As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_R2HT As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_R2TTC As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_CoutTotalHT As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_CoûtTotalTTC As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_R1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_R2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_TVA As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colonne_DateNouvelleActualisation As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader_Releves_Date_Theorique As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox_Recherche_Facture As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_Recherche_Compteur As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_Recherche_Client As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_Recherche_Releve As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_Coutdefac_Actuel As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_Coutdefac_Actuel_TVA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Coutdefac_Actuel_R2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Coutdefac_Actuel_R1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox_Releves_Resultats As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_Coutdefac_Recherche As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_Factures_Resultats As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_Compteurs_Resultats As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_Clients_Resultats As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_Factures_Nom_Client As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader_Clients_Nom As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader_Clients_Civ As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label_periode_2 As Label
    Friend WithEvents DateTimePicker_Fin As DateTimePicker
    Friend WithEvents DateTimePicker_Debut As DateTimePicker
    Friend WithEvents Text_Datedébut_Factures As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_Adresse_Compteur As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTime_DateFin_Factures As DateTimePicker
    Friend WithEvents DateTime_DateDebut_Factures As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTime_datefin_coutdefac As DateTimePicker
    Friend WithEvents ColumnHeader_Clients_Id As ColumnHeader
End Class
