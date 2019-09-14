Public Class Form1

    Dim password As String
    Dim rd As New Random

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox1.Text = "" Then
            Return
        End If
        RichTextBox1.Text = ""
        For i = 0 To CInt(TextBox2.Text) - 1
            password = ""
            For x = 0 To CInt(TextBox1.Text) - 1
                Dim capitalize = rd.Next(2)
                If capitalize = 0 Then
                    password = password & GetIt(rd.Next(10)).ToUpper
                Else
                    password = password & GetIt(rd.Next(10)).ToLower
                End If
            Next
            RichTextBox1.Text = RichTextBox1.Text & password & Environment.NewLine
        Next
    End Sub

    Public Function GetIt(ByRef intger As Integer) As String
        Select Case intger
            Case 0
                Return "a"
            Case 1
                Return "b"
            Case 2
                Return "c"
            Case 3
                Return "d"
            Case 4
                Return "e"
            Case 5
                Return "f"
            Case 6
                Return "g"
            Case 7
                Return "h"
            Case 8
                Return "i"
            Case 9
                Return "j"
        End Select
        Return ""
    End Function

End Class
