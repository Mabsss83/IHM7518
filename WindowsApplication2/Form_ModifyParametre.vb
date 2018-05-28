Public Class Form_ModifyParametre

    Private Parameter As String
    Event Para_Update()

    Public Sub New(ByVal Para As String, ByVal Val As String)
        InitializeComponent()
        Parameter = Para
        TextBox_Value.Text = Val
        Me.Show()
    End Sub

    Private Sub Button_Modify_Click(sender As Object, e As EventArgs) Handles Button_Modify.Click
        Write_XML_Value(Parameter, TextBox_Value.Text)
        RaiseEvent Para_Update()
        Me.Close()
    End Sub
End Class