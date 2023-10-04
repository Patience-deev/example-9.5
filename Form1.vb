Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myPhrase As String
        Dim LblPhrase
        Dim blExtract

        myPhrase = InputBox("enter your phrase")
        LblPhrase = myPhrase
        blExtract = MsgBox(Mid(myPhrase, 2, 6))
    End Sub
End Class
