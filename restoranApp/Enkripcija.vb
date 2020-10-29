Imports System.Data.SqlClient
Imports System.IO
Public Class Enkripcija
    Public Shared HashPrijava As String
    Public Shared HashNoviK As String

    Private Shared Function StringtoSha512(ByRef Content As String) As String
        Dim sha As New System.Security.Cryptography.SHA512CryptoServiceProvider
        Dim ByteString() As Byte = System.Text.Encoding.ASCII.GetBytes(Content)
        ByteString = sha.ComputeHash(ByteString)
        Dim FinalString As String = Nothing

        For Each bt As Byte In ByteString
            FinalString &= bt.ToString("x2")
        Next
        Return FinalString.ToUpper()
    End Function
    Public Shared Sub EncryptPass()
        If HashPrijava = String.Empty Then
            Try
                HashPrijava = Chr(128) & StringtoSha512(prijava.textBox2.Text + prijava.textBox1.Text)
            Catch ex As Exception
            End Try
        End If
        If HashNoviK = String.Empty Then
            Try
                HashNoviK = Chr(128) & StringtoSha512(admin.TextBox2.Text + admin.TextBox5.Text)
            Catch ex As Exception
            End Try
        End If

    End Sub
End Class