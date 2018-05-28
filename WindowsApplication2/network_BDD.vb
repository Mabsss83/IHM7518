Imports System
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class BDD_Network
    Private BDD As New MySqlConnection

    Public Sub New(ByVal ConnStr As String)
        BDD.ConnectionString = ConnStr
        Do
            Try
                BDD.Open()
                Exit Do
            Catch ex As MySqlException
                If MsgBox(ex.ToString & ConnStr, MsgBoxStyle.RetryCancel, "Connexion Error") = 2 Then
                    Application.Exit()
                End If
            End Try
        Loop
    End Sub

    Public Function Read(ByVal aQuery As String) As List(Of List(Of String))
        Dim results As New List(Of List(Of String))
        Dim query As MySqlCommand = BDD.CreateCommand()
        Dim reader As MySqlDataReader
        query.CommandText = aQuery
        reader = query.ExecuteReader()
        While reader.Read()
            Dim ls As New List(Of String)
            For i As Integer = 0 To reader.FieldCount - 1
                ls.Add(reader.GetString(i).ToString)
            Next
            results.Add(ls)
        End While
        reader.Dispose()
        Return results
    End Function

    Public Sub Write(ByVal aQuery As String)
        Dim query As MySqlCommand = BDD.CreateCommand()
        query.CommandText = aQuery
        Try
            query.ExecuteNonQuery()
        Catch ex As MySqlException
            MsgBox(ex, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub

    Public Sub Modify(ByVal aQuery As String)
        Dim query As MySqlCommand = BDD.CreateCommand()
        query.CommandText = aQuery
        Try
            query.ExecuteNonQuery()
        Catch ex As MySqlException
            MsgBox(ex, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub

    Protected Overrides Sub Finalize()
        BDD.Close()
    End Sub
End Class