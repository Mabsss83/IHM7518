<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Parametre
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Text_Parametre = New System.Windows.Forms.Label()
        Me.ListView_Parametre = New System.Windows.Forms.ListView()
        Me.Paramètre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Valeur = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Text_Parametre
        '
        Me.Text_Parametre.AutoSize = True
        Me.Text_Parametre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Parametre.Location = New System.Drawing.Point(39, 34)
        Me.Text_Parametre.Name = "Text_Parametre"
        Me.Text_Parametre.Size = New System.Drawing.Size(154, 31)
        Me.Text_Parametre.TabIndex = 2
        Me.Text_Parametre.Text = "Paramètres"
        '
        'ListView_Parametre
        '
        Me.ListView_Parametre.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Paramètre, Me.Valeur})
        Me.ListView_Parametre.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView_Parametre.Location = New System.Drawing.Point(45, 108)
        Me.ListView_Parametre.MultiSelect = False
        Me.ListView_Parametre.Name = "ListView_Parametre"
        Me.ListView_Parametre.Size = New System.Drawing.Size(689, 311)
        Me.ListView_Parametre.TabIndex = 3
        Me.ListView_Parametre.UseCompatibleStateImageBehavior = False
        Me.ListView_Parametre.View = System.Windows.Forms.View.Details
        '
        'Paramètre
        '
        Me.Paramètre.Text = "Paramètre"
        Me.Paramètre.Width = 150
        '
        'Valeur
        '
        Me.Valeur.Text = "Valeur"
        Me.Valeur.Width = 589
        '
        'Form_Parametre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 461)
        Me.Controls.Add(Me.ListView_Parametre)
        Me.Controls.Add(Me.Text_Parametre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Parametre"
        Me.Text = "Editer les paramètres"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Text_Parametre As Label
    Friend WithEvents ListView_Parametre As ListView
    Friend WithEvents Paramètre As ColumnHeader
    Friend WithEvents Valeur As ColumnHeader
End Class
