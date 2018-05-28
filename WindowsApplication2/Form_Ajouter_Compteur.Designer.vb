<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Ajouter_Compteur
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
        Me.Text_Id_AjoutCompteur = New System.Windows.Forms.Label()
        Me.Text_AdresseLivraison_AjoutCompteur = New System.Windows.Forms.Label()
        Me.Text_NumCompteur_AjoutCompteur = New System.Windows.Forms.Label()
        Me.TextBox_Compteur_Num = New System.Windows.Forms.TextBox()
        Me.TextBox_Compteur_AdresseLiv = New System.Windows.Forms.TextBox()
        Me.TextBox_Compteur_Puissance = New System.Windows.Forms.TextBox()
        Me.Button_AjouterCompteur = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker_Compteur_DateDebut = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(426, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ajouter Un Compteur"
        '
        'Text_Id_AjoutCompteur
        '
        Me.Text_Id_AjoutCompteur.AutoSize = True
        Me.Text_Id_AjoutCompteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Id_AjoutCompteur.Location = New System.Drawing.Point(63, 235)
        Me.Text_Id_AjoutCompteur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Text_Id_AjoutCompteur.Name = "Text_Id_AjoutCompteur"
        Me.Text_Id_AjoutCompteur.Size = New System.Drawing.Size(207, 29)
        Me.Text_Id_AjoutCompteur.TabIndex = 1
        Me.Text_Id_AjoutCompteur.Text = "Numéro compteur"
        '
        'Text_AdresseLivraison_AjoutCompteur
        '
        Me.Text_AdresseLivraison_AjoutCompteur.AutoSize = True
        Me.Text_AdresseLivraison_AjoutCompteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_AdresseLivraison_AjoutCompteur.Location = New System.Drawing.Point(75, 308)
        Me.Text_AdresseLivraison_AjoutCompteur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Text_AdresseLivraison_AjoutCompteur.Name = "Text_AdresseLivraison_AjoutCompteur"
        Me.Text_AdresseLivraison_AjoutCompteur.Size = New System.Drawing.Size(197, 29)
        Me.Text_AdresseLivraison_AjoutCompteur.TabIndex = 2
        Me.Text_AdresseLivraison_AjoutCompteur.Text = "Adresse livraison"
        '
        'Text_NumCompteur_AjoutCompteur
        '
        Me.Text_NumCompteur_AjoutCompteur.AutoSize = True
        Me.Text_NumCompteur_AjoutCompteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_NumCompteur_AjoutCompteur.Location = New System.Drawing.Point(144, 385)
        Me.Text_NumCompteur_AjoutCompteur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Text_NumCompteur_AjoutCompteur.Name = "Text_NumCompteur_AjoutCompteur"
        Me.Text_NumCompteur_AjoutCompteur.Size = New System.Drawing.Size(124, 29)
        Me.Text_NumCompteur_AjoutCompteur.TabIndex = 3
        Me.Text_NumCompteur_AjoutCompteur.Text = "Puissance"
        '
        'TextBox_Compteur_Num
        '
        Me.TextBox_Compteur_Num.Location = New System.Drawing.Point(302, 235)
        Me.TextBox_Compteur_Num.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_Compteur_Num.Name = "TextBox_Compteur_Num"
        Me.TextBox_Compteur_Num.Size = New System.Drawing.Size(286, 26)
        Me.TextBox_Compteur_Num.TabIndex = 4
        '
        'TextBox_Compteur_AdresseLiv
        '
        Me.TextBox_Compteur_AdresseLiv.Location = New System.Drawing.Point(302, 308)
        Me.TextBox_Compteur_AdresseLiv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_Compteur_AdresseLiv.Name = "TextBox_Compteur_AdresseLiv"
        Me.TextBox_Compteur_AdresseLiv.Size = New System.Drawing.Size(492, 26)
        Me.TextBox_Compteur_AdresseLiv.TabIndex = 5
        '
        'TextBox_Compteur_Puissance
        '
        Me.TextBox_Compteur_Puissance.Location = New System.Drawing.Point(302, 385)
        Me.TextBox_Compteur_Puissance.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_Compteur_Puissance.Name = "TextBox_Compteur_Puissance"
        Me.TextBox_Compteur_Puissance.Size = New System.Drawing.Size(286, 26)
        Me.TextBox_Compteur_Puissance.TabIndex = 6
        '
        'Button_AjouterCompteur
        '
        Me.Button_AjouterCompteur.Location = New System.Drawing.Point(465, 548)
        Me.Button_AjouterCompteur.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_AjouterCompteur.Name = "Button_AjouterCompteur"
        Me.Button_AjouterCompteur.Size = New System.Drawing.Size(192, 66)
        Me.Button_AjouterCompteur.TabIndex = 7
        Me.Button_AjouterCompteur.Text = "Ajouter un compteur"
        Me.Button_AjouterCompteur.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 445)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Date Début"
        '
        'DateTimePicker_Compteur_DateDebut
        '
        Me.DateTimePicker_Compteur_DateDebut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_Compteur_DateDebut.Location = New System.Drawing.Point(302, 447)
        Me.DateTimePicker_Compteur_DateDebut.Name = "DateTimePicker_Compteur_DateDebut"
        Me.DateTimePicker_Compteur_DateDebut.Size = New System.Drawing.Size(119, 26)
        Me.DateTimePicker_Compteur_DateDebut.TabIndex = 9
        '
        'Form_Ajouter_Compteur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 708)
        Me.Controls.Add(Me.DateTimePicker_Compteur_DateDebut)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_AjouterCompteur)
        Me.Controls.Add(Me.TextBox_Compteur_Puissance)
        Me.Controls.Add(Me.TextBox_Compteur_AdresseLiv)
        Me.Controls.Add(Me.TextBox_Compteur_Num)
        Me.Controls.Add(Me.Text_NumCompteur_AjoutCompteur)
        Me.Controls.Add(Me.Text_AdresseLivraison_AjoutCompteur)
        Me.Controls.Add(Me.Text_Id_AjoutCompteur)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_Ajouter_Compteur"
        Me.Text = "Ajouter un compteur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Text_Id_AjoutCompteur As System.Windows.Forms.Label
    Friend WithEvents Text_AdresseLivraison_AjoutCompteur As System.Windows.Forms.Label
    Friend WithEvents Text_NumCompteur_AjoutCompteur As System.Windows.Forms.Label
    Friend WithEvents TextBox_Compteur_Num As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Compteur_AdresseLiv As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Compteur_Puissance As System.Windows.Forms.TextBox
    Friend WithEvents Button_AjouterCompteur As System.Windows.Forms.Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker_Compteur_DateDebut As DateTimePicker
End Class
