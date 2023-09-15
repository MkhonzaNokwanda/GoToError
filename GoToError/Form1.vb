Imports System.IO

Public Class Form1
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim strNumber As String
        strNumber = txtNumber.Text

        On Error GoTo ErrorHandler

        Dim dNumericNo As Double
        dNumericNo = CDbl(strNumber)

        MsgBox("Success! You entered a valid number: " & dNumericNo)
        Exit Sub

ErrorHandler:
        MsgBox("Error: " & strNumber & " is not a number")

    End Sub
End Class
