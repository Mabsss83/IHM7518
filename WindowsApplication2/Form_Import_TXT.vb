Imports System.IO
Imports System.String


Public Class Form1


    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.MdiParent = Form_Main    'Pour imbriqué le Form
        Me.Show()

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'Anienne méthode (semestre 1) pour joindre le tramaye.txt
        'Dim currentRow As String()
        'Dim userProfilePath As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\"
        'Dim softPath As String = userProfilePath & ""
        'Dim filePath As String = softPath & "tramayes.txt"
        'Dim filePath As String()
        Dim myStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True
        'ouvre une boite de dialogue pour sélectionner le fichier à lire
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = openFileDialog1.OpenFile()
                If (myStream IsNot Nothing) Then
                    ' Insert code to read the stream here.
                    Dim TramayeImport As New List(Of String())
                    Using r As StreamReader = New StreamReader(myStream)
                        Dim currentLine As String = r.ReadLine
                        Do While (Not String.IsNullOrWhiteSpace(currentLine))
                            TramayeImport.Add(currentLine.Split(vbTab))
                            currentLine = r.ReadLine
                        Loop
                    End Using
                    'Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(openFileDialog1.FileName)

                    'Dim currentRow As String()

                    'MyReader.TextFieldType = FileIO.FieldType.Delimited
                    'MyReader.SetDelimiters(vbTab) 'definition delimitation (PAS DE TAB pour le 1er...)

                    'currentRow = MyReader.ReadFields() 'définition de la première ligne
                    'currentRow = MyReader.ReadFields() 'commencer à la ligne 2 (structure de ligne 1 connue)

                    'Const ForReading = 1
                    'Dim objFSO = CreateObject("Scripting.FileSystemObject")

                    'Dim objTextFile = objFSO.OpenTextFile _
                    '(openFileDialog1.FileName, ForReading)
                    'objTextFile.ReadAll()

                    'Dim x As Integer = 5 'nb colonnes
                    'Dim y As Integer = objTextFile.Line - 2 'nb lignes
                    'Dim Grid(y, x) As String 'Données de bases pour faire tourner le programme!

                    'For k = 0 To y
                    '    For i = 0 To x
                    '        Grid(k, i) = currentRow(i) 'affiliation fichier txt au tableau
                    '    Next i

                    '    currentRow = MyReader.ReadFields()
                    'Next k

                    Label1.Text = String.Join(", ", TramayeImport(0))
                    Label2.Text = String.Join(", ", TramayeImport(1))
                    Label3.Text = TramayeImport(1)(1)

                    'Label4.Text = TramayeImport(0, 3)
                    'Label5.Text = TramayeImport(0, 4)
                    'Label6.Text = TramayeImport(0, 5)

                    'End Using
                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk.\nOriginal error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If

            End Try

        End If

    End Sub

End Class
