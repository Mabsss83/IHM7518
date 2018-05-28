<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Double_Clic_Compteur
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Text_Titre = New System.Windows.Forms.Label()
        Me.List_Releves_DoubleClic = New System.Windows.Forms.TabPage()
        Me.List_Compteur = New System.Windows.Forms.ListView()
        Me.Datereleve_th = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IndexAncien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IndexNouveau = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Informations = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_CodePostal = New System.Windows.Forms.TextBox()
        Me.TextBox_Adresse_Informations = New System.Windows.Forms.TextBox()
        Me.TextBox_Id_Informations = New System.Windows.Forms.TextBox()
        Me.Text_CodePostal_Information = New System.Windows.Forms.Label()
        Me.Button_Enregister = New System.Windows.Forms.Button()
        Me.Text_Adresse_Informations = New System.Windows.Forms.Label()
        Me.Text_Id_Informations = New System.Windows.Forms.Label()
        Me.Releves = New System.Windows.Forms.TabControl()
        Me.DoubleClic_Consommation = New System.Windows.Forms.TabPage()
        Me.Text_DateDebut_Consommation = New System.Windows.Forms.Label()
        Me.Text_DateFin_Consommation = New System.Windows.Forms.Label()
        Me.DateTime_DateDebut_Consommation = New System.Windows.Forms.DateTimePicker()
        Me.DateTime_DateFin_Consommation = New System.Windows.Forms.DateTimePicker()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Datereleve_re = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.List_Releves_DoubleClic.SuspendLayout()
        Me.Informations.SuspendLayout()
        Me.Releves.SuspendLayout()
        Me.DoubleClic_Consommation.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Text_Titre
        '
        Me.Text_Titre.AutoEllipsis = True
        Me.Text_Titre.AutoSize = True
        Me.Text_Titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Titre.Location = New System.Drawing.Point(256, 9)
        Me.Text_Titre.Name = "Text_Titre"
        Me.Text_Titre.Size = New System.Drawing.Size(191, 24)
        Me.Text_Titre.TabIndex = 3
        Me.Text_Titre.Text = "Numéro du compteur"
        '
        'List_Releves_DoubleClic
        '
        Me.List_Releves_DoubleClic.Controls.Add(Me.List_Compteur)
        Me.List_Releves_DoubleClic.Location = New System.Drawing.Point(4, 22)
        Me.List_Releves_DoubleClic.Name = "List_Releves_DoubleClic"
        Me.List_Releves_DoubleClic.Padding = New System.Windows.Forms.Padding(3)
        Me.List_Releves_DoubleClic.Size = New System.Drawing.Size(764, 386)
        Me.List_Releves_DoubleClic.TabIndex = 1
        Me.List_Releves_DoubleClic.Text = "Relevés"
        Me.List_Releves_DoubleClic.UseVisualStyleBackColor = True
        '
        'List_Compteur
        '
        Me.List_Compteur.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Datereleve_th, Me.IndexAncien, Me.IndexNouveau, Me.Datereleve_re})
        Me.List_Compteur.GridLines = True
        Me.List_Compteur.Location = New System.Drawing.Point(3, 3)
        Me.List_Compteur.Name = "List_Compteur"
        Me.List_Compteur.Size = New System.Drawing.Size(758, 380)
        Me.List_Compteur.TabIndex = 0
        Me.List_Compteur.UseCompatibleStateImageBehavior = False
        Me.List_Compteur.View = System.Windows.Forms.View.Details
        '
        'Datereleve_th
        '
        Me.Datereleve_th.Text = "Date relevé théorique"
        Me.Datereleve_th.Width = 216
        '
        'IndexAncien
        '
        Me.IndexAncien.DisplayIndex = 2
        Me.IndexAncien.Text = "Index ancien"
        Me.IndexAncien.Width = 100
        '
        'IndexNouveau
        '
        Me.IndexNouveau.DisplayIndex = 3
        Me.IndexNouveau.Text = "Index nouveau"
        Me.IndexNouveau.Width = 100
        '
        'Informations
        '
        Me.Informations.Controls.Add(Me.TextBox1)
        Me.Informations.Controls.Add(Me.Label1)
        Me.Informations.Controls.Add(Me.TextBox_CodePostal)
        Me.Informations.Controls.Add(Me.TextBox_Adresse_Informations)
        Me.Informations.Controls.Add(Me.TextBox_Id_Informations)
        Me.Informations.Controls.Add(Me.Text_CodePostal_Information)
        Me.Informations.Controls.Add(Me.Button_Enregister)
        Me.Informations.Controls.Add(Me.Text_Adresse_Informations)
        Me.Informations.Controls.Add(Me.Text_Id_Informations)
        Me.Informations.Location = New System.Drawing.Point(4, 22)
        Me.Informations.Name = "Informations"
        Me.Informations.Padding = New System.Windows.Forms.Padding(3)
        Me.Informations.Size = New System.Drawing.Size(764, 386)
        Me.Informations.TabIndex = 0
        Me.Informations.Text = "Informations"
        Me.Informations.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(162, 93)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(144, 20)
        Me.TextBox1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Numéro du compteur"
        '
        'TextBox_CodePostal
        '
        Me.TextBox_CodePostal.Location = New System.Drawing.Point(162, 177)
        Me.TextBox_CodePostal.Name = "TextBox_CodePostal"
        Me.TextBox_CodePostal.Size = New System.Drawing.Size(144, 20)
        Me.TextBox_CodePostal.TabIndex = 13
        '
        'TextBox_Adresse_Informations
        '
        Me.TextBox_Adresse_Informations.Location = New System.Drawing.Point(162, 136)
        Me.TextBox_Adresse_Informations.Name = "TextBox_Adresse_Informations"
        Me.TextBox_Adresse_Informations.Size = New System.Drawing.Size(223, 20)
        Me.TextBox_Adresse_Informations.TabIndex = 7
        '
        'TextBox_Id_Informations
        '
        Me.TextBox_Id_Informations.Location = New System.Drawing.Point(162, 53)
        Me.TextBox_Id_Informations.Name = "TextBox_Id_Informations"
        Me.TextBox_Id_Informations.ReadOnly = True
        Me.TextBox_Id_Informations.Size = New System.Drawing.Size(144, 20)
        Me.TextBox_Id_Informations.TabIndex = 6
        '
        'Text_CodePostal_Information
        '
        Me.Text_CodePostal_Information.AutoSize = True
        Me.Text_CodePostal_Information.Location = New System.Drawing.Point(100, 180)
        Me.Text_CodePostal_Information.Name = "Text_CodePostal_Information"
        Me.Text_CodePostal_Information.Size = New System.Drawing.Size(56, 13)
        Me.Text_CodePostal_Information.TabIndex = 12
        Me.Text_CodePostal_Information.Text = "Puissance"
        '
        'Button_Enregister
        '
        Me.Button_Enregister.Location = New System.Drawing.Point(574, 314)
        Me.Button_Enregister.Name = "Button_Enregister"
        Me.Button_Enregister.Size = New System.Drawing.Size(143, 43)
        Me.Button_Enregister.TabIndex = 5
        Me.Button_Enregister.Text = "Enregistrer"
        Me.Button_Enregister.UseVisualStyleBackColor = True
        '
        'Text_Adresse_Informations
        '
        Me.Text_Adresse_Informations.AutoSize = True
        Me.Text_Adresse_Informations.Location = New System.Drawing.Point(66, 139)
        Me.Text_Adresse_Informations.Name = "Text_Adresse_Informations"
        Me.Text_Adresse_Informations.Size = New System.Drawing.Size(90, 13)
        Me.Text_Adresse_Informations.TabIndex = 3
        Me.Text_Adresse_Informations.Text = "Adresse Livraison"
        '
        'Text_Id_Informations
        '
        Me.Text_Id_Informations.AutoSize = True
        Me.Text_Id_Informations.Location = New System.Drawing.Point(140, 56)
        Me.Text_Id_Informations.Name = "Text_Id_Informations"
        Me.Text_Id_Informations.Size = New System.Drawing.Size(16, 13)
        Me.Text_Id_Informations.TabIndex = 0
        Me.Text_Id_Informations.Text = "Id"
        '
        'Releves
        '
        Me.Releves.Controls.Add(Me.Informations)
        Me.Releves.Controls.Add(Me.List_Releves_DoubleClic)
        Me.Releves.Controls.Add(Me.DoubleClic_Consommation)
        Me.Releves.Location = New System.Drawing.Point(4, 36)
        Me.Releves.Name = "Releves"
        Me.Releves.SelectedIndex = 0
        Me.Releves.Size = New System.Drawing.Size(772, 412)
        Me.Releves.TabIndex = 2
        '
        'DoubleClic_Consommation
        '
        Me.DoubleClic_Consommation.Controls.Add(Me.Text_DateDebut_Consommation)
        Me.DoubleClic_Consommation.Controls.Add(Me.Text_DateFin_Consommation)
        Me.DoubleClic_Consommation.Controls.Add(Me.DateTime_DateDebut_Consommation)
        Me.DoubleClic_Consommation.Controls.Add(Me.DateTime_DateFin_Consommation)
        Me.DoubleClic_Consommation.Controls.Add(Me.Chart1)
        Me.DoubleClic_Consommation.Location = New System.Drawing.Point(4, 22)
        Me.DoubleClic_Consommation.Name = "DoubleClic_Consommation"
        Me.DoubleClic_Consommation.Padding = New System.Windows.Forms.Padding(3)
        Me.DoubleClic_Consommation.Size = New System.Drawing.Size(764, 386)
        Me.DoubleClic_Consommation.TabIndex = 2
        Me.DoubleClic_Consommation.Text = "Consommation"
        Me.DoubleClic_Consommation.UseVisualStyleBackColor = True
        '
        'Text_DateDebut_Consommation
        '
        Me.Text_DateDebut_Consommation.AutoSize = True
        Me.Text_DateDebut_Consommation.Location = New System.Drawing.Point(74, 24)
        Me.Text_DateDebut_Consommation.Name = "Text_DateDebut_Consommation"
        Me.Text_DateDebut_Consommation.Size = New System.Drawing.Size(62, 13)
        Me.Text_DateDebut_Consommation.TabIndex = 11
        Me.Text_DateDebut_Consommation.Text = "Date Début"
        '
        'Text_DateFin_Consommation
        '
        Me.Text_DateFin_Consommation.AutoSize = True
        Me.Text_DateFin_Consommation.Location = New System.Drawing.Point(89, 50)
        Me.Text_DateFin_Consommation.Name = "Text_DateFin_Consommation"
        Me.Text_DateFin_Consommation.Size = New System.Drawing.Size(47, 13)
        Me.Text_DateFin_Consommation.TabIndex = 10
        Me.Text_DateFin_Consommation.Text = "Date Fin"
        '
        'DateTime_DateDebut_Consommation
        '
        Me.DateTime_DateDebut_Consommation.Location = New System.Drawing.Point(174, 18)
        Me.DateTime_DateDebut_Consommation.Name = "DateTime_DateDebut_Consommation"
        Me.DateTime_DateDebut_Consommation.Size = New System.Drawing.Size(200, 20)
        Me.DateTime_DateDebut_Consommation.TabIndex = 9
        '
        'DateTime_DateFin_Consommation
        '
        Me.DateTime_DateFin_Consommation.Location = New System.Drawing.Point(174, 44)
        Me.DateTime_DateFin_Consommation.Name = "DateTime_DateFin_Consommation"
        Me.DateTime_DateFin_Consommation.Size = New System.Drawing.Size(200, 20)
        Me.DateTime_DateFin_Consommation.TabIndex = 8
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(21, 80)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(737, 300)
        Me.Chart1.TabIndex = 6
        Me.Chart1.Text = "Chart_Consommation"
        '
        'Datereleve_re
        '
        Me.Datereleve_re.DisplayIndex = 1
        Me.Datereleve_re.Text = "Date relevé réelle"
        Me.Datereleve_re.Width = 216
        '
        'Form_Double_Clic_Compteur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 451)
        Me.Controls.Add(Me.Text_Titre)
        Me.Controls.Add(Me.Releves)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Double_Clic_Compteur"
        Me.Text = "Informations compteurs"
        Me.List_Releves_DoubleClic.ResumeLayout(False)
        Me.Informations.ResumeLayout(False)
        Me.Informations.PerformLayout()
        Me.Releves.ResumeLayout(False)
        Me.DoubleClic_Consommation.ResumeLayout(False)
        Me.DoubleClic_Consommation.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Text_Titre As System.Windows.Forms.Label
    Friend WithEvents List_Releves_DoubleClic As System.Windows.Forms.TabPage
    Friend WithEvents List_Compteur As System.Windows.Forms.ListView
    Friend WithEvents IndexAncien As System.Windows.Forms.ColumnHeader
    Friend WithEvents Datereleve_th As System.Windows.Forms.ColumnHeader
    Friend WithEvents IndexNouveau As System.Windows.Forms.ColumnHeader
    Friend WithEvents Informations As System.Windows.Forms.TabPage
    Friend WithEvents TextBox_CodePostal As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Adresse_Informations As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Id_Informations As System.Windows.Forms.TextBox
    Friend WithEvents Text_CodePostal_Information As System.Windows.Forms.Label
    Friend WithEvents Button_Enregister As System.Windows.Forms.Button
    Friend WithEvents Text_Adresse_Informations As System.Windows.Forms.Label
    Friend WithEvents Text_Id_Informations As System.Windows.Forms.Label
    Friend WithEvents Releves As System.Windows.Forms.TabControl
    Friend WithEvents DoubleClic_Consommation As System.Windows.Forms.TabPage
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Text_DateDebut_Consommation As System.Windows.Forms.Label
    Friend WithEvents Text_DateFin_Consommation As System.Windows.Forms.Label
    Friend WithEvents DateTime_DateDebut_Consommation As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTime_DateFin_Consommation As System.Windows.Forms.DateTimePicker
    Friend WithEvents Datereleve_re As ColumnHeader
End Class
