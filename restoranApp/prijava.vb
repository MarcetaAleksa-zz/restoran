Imports System.Data.SqlClient
Public Class prijava
    Public Shared tipNaloga As Integer = 404
    Public imePozicije As String

    Private Sub prijava_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Me.Close()

    End Sub

    Private Sub textBox1_Enter(sender As Object, e As EventArgs) Handles textBox1.Enter
        If textBox1.Text = "Korisničko ime" Then
            textBox1.Text = ""
        End If
    End Sub
    Private Sub textBox1_Leave(sender As Object, e As EventArgs) Handles textBox1.Leave
        If textBox1.Text = "" Then
            textBox1.Text = "Korisničko ime"
        End If
    End Sub


    Private Sub textBox2_Enter(sender As Object, e As EventArgs) Handles textBox2.Enter
        If textBox2.Text = "Lozinka" Then
            textBox2.Text = ""
            textBox2.PasswordChar = "*"
        End If
    End Sub
    Private Sub textBox2_Leave(sender As Object, e As EventArgs) Handles textBox2.Leave
        If textBox2.Text = "" Then
            textBox2.Text = "Lozinka"
            textBox2.PasswordChar = Nothing
        End If
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim command As New SqlCommand("select korisnickoIme, Lozinka, Pozicija  from zaposleni where 
korisnickoIme = @korisnicki_id and  lozinka = @lozinka COLLATE Latin1_General_CS_AS", Baza.connection)

        command.Parameters.Add("@korisnicki_id", SqlDbType.VarChar).Value = textBox1.Text
        command.Parameters.Add("@lozinka", SqlDbType.VarChar).Value = textBox2.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim tabela As New DataTable()
        Dim rd As SqlDataReader

        Dim tipPozicije As Integer

        adapter.Fill(tabela)
        tipPozicije = tabela.Rows(0)(2)

        Me.tipNaloga = tipPozicije

        Select Case tipNaloga
            Case 1
                imePozicije = "Administrator"
            Case 2
                imePozicije = "Vlasnik"
            Case 3
                imePozicije = "Konobar"
            Case 4
                imePozicije = "Sanker"
        End Select


        If tabela.Rows.Count <> 0 Then

            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Neuspješna prijava!")
        End If
    End Sub
End Class
