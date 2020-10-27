Imports System.Data.SqlClient

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Riki\Desktop\imenikTelefonski\imenikTelefonski\aperionBaza.mdf;Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = " select username, pass from korisnici where username = '" & textBox1.Text & "' and pass = '" & textBox2.Text & "'"

        rd = cmd.ExecuteReader

        If rd.HasRows Then

            prozor.Show()
            Me.Hide()
            textBox1.Text = "Korisničko ime"
            textBox2.Text = "Lozinka"
        Else
            MessageBox.Show("Neuspješna prijava!")
        End If
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


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        button2.Select()
    End Sub
End Class
