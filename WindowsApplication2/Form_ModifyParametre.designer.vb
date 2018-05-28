<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ModifyParametre
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox_Value = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Modify = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox_Value
        '
        Me.TextBox_Value.Location = New System.Drawing.Point(55, 50)
        Me.TextBox_Value.Multiline = True
        Me.TextBox_Value.Name = "TextBox_Value"
        Me.TextBox_Value.Size = New System.Drawing.Size(243, 180)
        Me.TextBox_Value.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Modifier le paramètre :"
        '
        'Button_Modify
        '
        Me.Button_Modify.Location = New System.Drawing.Point(133, 260)
        Me.Button_Modify.Name = "Button_Modify"
        Me.Button_Modify.Size = New System.Drawing.Size(75, 23)
        Me.Button_Modify.TabIndex = 2
        Me.Button_Modify.Text = "Modifier"
        Me.Button_Modify.UseVisualStyleBackColor = True
        '
        'Form_ModifyParametre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 295)
        Me.Controls.Add(Me.Button_Modify)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_Value)
        Me.Name = "Form_ModifyParametre"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_Value As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_Modify As Button
End Class
