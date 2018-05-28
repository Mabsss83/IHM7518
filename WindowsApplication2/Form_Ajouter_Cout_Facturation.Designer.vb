<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajouteruncoutdefac
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
        Me.Text_R1_Coutdefac = New System.Windows.Forms.Label()
        Me.Text_R2_Coutdefac = New System.Windows.Forms.Label()
        Me.Text_TVA_Coutdefac = New System.Windows.Forms.Label()
        Me.Text_Dateactu_coutdefac = New System.Windows.Forms.Label()
        Me.Text_Datefin_Coutdefac = New System.Windows.Forms.Label()
        Me.TextBox_R1_Coutdefac = New System.Windows.Forms.TextBox()
        Me.TextBox_R2_Coutdefac = New System.Windows.Forms.TextBox()
        Me.TextBox_TVA_Coutdefac = New System.Windows.Forms.TextBox()
        Me.Date_DateActualisation_Coutdefac = New System.Windows.Forms.DateTimePicker()
        Me.Date_Datefin_Coutdefac = New System.Windows.Forms.DateTimePicker()
        Me.Button_Ajout_Coutdefac = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ajouter un cout de facturation"
        '
        'Text_R1_Coutdefac
        '
        Me.Text_R1_Coutdefac.AutoSize = True
        Me.Text_R1_Coutdefac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_R1_Coutdefac.Location = New System.Drawing.Point(111, 133)
        Me.Text_R1_Coutdefac.Name = "Text_R1_Coutdefac"
        Me.Text_R1_Coutdefac.Size = New System.Drawing.Size(28, 16)
        Me.Text_R1_Coutdefac.TabIndex = 2
        Me.Text_R1_Coutdefac.Text = "R1 "
        '
        'Text_R2_Coutdefac
        '
        Me.Text_R2_Coutdefac.AutoSize = True
        Me.Text_R2_Coutdefac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_R2_Coutdefac.Location = New System.Drawing.Point(111, 181)
        Me.Text_R2_Coutdefac.Name = "Text_R2_Coutdefac"
        Me.Text_R2_Coutdefac.Size = New System.Drawing.Size(28, 16)
        Me.Text_R2_Coutdefac.TabIndex = 3
        Me.Text_R2_Coutdefac.Text = "R2 "
        '
        'Text_TVA_Coutdefac
        '
        Me.Text_TVA_Coutdefac.AutoSize = True
        Me.Text_TVA_Coutdefac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_TVA_Coutdefac.Location = New System.Drawing.Point(104, 225)
        Me.Text_TVA_Coutdefac.Name = "Text_TVA_Coutdefac"
        Me.Text_TVA_Coutdefac.Size = New System.Drawing.Size(35, 16)
        Me.Text_TVA_Coutdefac.TabIndex = 4
        Me.Text_TVA_Coutdefac.Text = "TVA"
        '
        'Text_Dateactu_coutdefac
        '
        Me.Text_Dateactu_coutdefac.AutoSize = True
        Me.Text_Dateactu_coutdefac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Dateactu_coutdefac.Location = New System.Drawing.Point(353, 133)
        Me.Text_Dateactu_coutdefac.Name = "Text_Dateactu_coutdefac"
        Me.Text_Dateactu_coutdefac.Size = New System.Drawing.Size(116, 16)
        Me.Text_Dateactu_coutdefac.TabIndex = 5
        Me.Text_Dateactu_coutdefac.Text = "Date Actualisation"
        '
        'Text_Datefin_Coutdefac
        '
        Me.Text_Datefin_Coutdefac.AutoSize = True
        Me.Text_Datefin_Coutdefac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Datefin_Coutdefac.Location = New System.Drawing.Point(416, 181)
        Me.Text_Datefin_Coutdefac.Name = "Text_Datefin_Coutdefac"
        Me.Text_Datefin_Coutdefac.Size = New System.Drawing.Size(53, 16)
        Me.Text_Datefin_Coutdefac.TabIndex = 6
        Me.Text_Datefin_Coutdefac.Text = "Date fin"
        '
        'TextBox_R1_Coutdefac
        '
        Me.TextBox_R1_Coutdefac.Location = New System.Drawing.Point(161, 129)
        Me.TextBox_R1_Coutdefac.Name = "TextBox_R1_Coutdefac"
        Me.TextBox_R1_Coutdefac.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_R1_Coutdefac.TabIndex = 8
        '
        'TextBox_R2_Coutdefac
        '
        Me.TextBox_R2_Coutdefac.Location = New System.Drawing.Point(161, 177)
        Me.TextBox_R2_Coutdefac.Name = "TextBox_R2_Coutdefac"
        Me.TextBox_R2_Coutdefac.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_R2_Coutdefac.TabIndex = 9
        '
        'TextBox_TVA_Coutdefac
        '
        Me.TextBox_TVA_Coutdefac.Location = New System.Drawing.Point(161, 221)
        Me.TextBox_TVA_Coutdefac.Name = "TextBox_TVA_Coutdefac"
        Me.TextBox_TVA_Coutdefac.Size = New System.Drawing.Size(133, 20)
        Me.TextBox_TVA_Coutdefac.TabIndex = 10
        '
        'Date_DateActualisation_Coutdefac
        '
        Me.Date_DateActualisation_Coutdefac.Location = New System.Drawing.Point(491, 129)
        Me.Date_DateActualisation_Coutdefac.Name = "Date_DateActualisation_Coutdefac"
        Me.Date_DateActualisation_Coutdefac.Size = New System.Drawing.Size(200, 20)
        Me.Date_DateActualisation_Coutdefac.TabIndex = 11
        '
        'Date_Datefin_Coutdefac
        '
        Me.Date_Datefin_Coutdefac.Location = New System.Drawing.Point(491, 177)
        Me.Date_Datefin_Coutdefac.Name = "Date_Datefin_Coutdefac"
        Me.Date_Datefin_Coutdefac.Size = New System.Drawing.Size(200, 20)
        Me.Date_Datefin_Coutdefac.TabIndex = 12
        '
        'Button_Ajout_Coutdefac
        '
        Me.Button_Ajout_Coutdefac.Location = New System.Drawing.Point(298, 349)
        Me.Button_Ajout_Coutdefac.Name = "Button_Ajout_Coutdefac"
        Me.Button_Ajout_Coutdefac.Size = New System.Drawing.Size(120, 41)
        Me.Button_Ajout_Coutdefac.TabIndex = 13
        Me.Button_Ajout_Coutdefac.Text = "Ajouter un coût de facturation"
        Me.Button_Ajout_Coutdefac.UseVisualStyleBackColor = True
        '
        'Ajouteruncoutdefac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 451)
        Me.Controls.Add(Me.Button_Ajout_Coutdefac)
        Me.Controls.Add(Me.Date_Datefin_Coutdefac)
        Me.Controls.Add(Me.Date_DateActualisation_Coutdefac)
        Me.Controls.Add(Me.TextBox_TVA_Coutdefac)
        Me.Controls.Add(Me.TextBox_R2_Coutdefac)
        Me.Controls.Add(Me.TextBox_R1_Coutdefac)
        Me.Controls.Add(Me.Text_Datefin_Coutdefac)
        Me.Controls.Add(Me.Text_Dateactu_coutdefac)
        Me.Controls.Add(Me.Text_TVA_Coutdefac)
        Me.Controls.Add(Me.Text_R2_Coutdefac)
        Me.Controls.Add(Me.Text_R1_Coutdefac)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ajouteruncoutdefac"
        Me.Text = "Ajouter un cout de facturation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Text_R1_Coutdefac As System.Windows.Forms.Label
    Friend WithEvents Text_R2_Coutdefac As System.Windows.Forms.Label
    Friend WithEvents Text_TVA_Coutdefac As System.Windows.Forms.Label
    Friend WithEvents Text_Dateactu_coutdefac As System.Windows.Forms.Label
    Friend WithEvents Text_Datefin_Coutdefac As System.Windows.Forms.Label
    Friend WithEvents TextBox_R1_Coutdefac As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_R2_Coutdefac As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_TVA_Coutdefac As System.Windows.Forms.TextBox
    Friend WithEvents Date_DateActualisation_Coutdefac As System.Windows.Forms.DateTimePicker
    Friend WithEvents Date_Datefin_Coutdefac As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button_Ajout_Coutdefac As System.Windows.Forms.Button
End Class
