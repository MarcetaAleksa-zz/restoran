Imports System.Data.SqlClient
Public Class prijava
    Public Shared tipNaloga As Integer = 404
    Public imePozicije As String
    Public imePrijavljenog As String


    Private connPrijava As New SqlConnection("")

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
        Enkripcija.EncryptPass()
        Dim command As New SqlCommand("select korisnickoIme, Lozinka, Pozicija  from zaposleni where 
korisnickoIme = @korisnicki_id and  lozinka = '" + Enkripcija.HashPrijava + "' COLLATE Latin1_General_CS_AS", Baza.connection)
        'TextBox3.Text = Enkripcija.HashStore
        command.Parameters.Add("@korisnicki_id", SqlDbType.VarChar).Value = textBox1.Text
        command.Parameters.Add("@lozinka", SqlDbType.VarChar).Value = textBox2.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim tabela As New DataTable()

        Dim tipPozicije As Integer

        adapter.Fill(tabela)
        Try
            Try
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
            Catch ex As Exception

            End Try
            If tabela.Rows.Count <> 0 Then
                imePrijavljenog = tabela.Rows(0)(0)
                KoJeOvajPokemon.Text = textBox1.Text
                If tipNaloga = 1 Then
                    admin.Show()
                    textBox1.Text = "Korisničko ime"
                    textBox2.Text = "Lozinka"
                    Enkripcija.HashPrijava = Nothing
                    Me.Hide()
                ElseIf tipNaloga = 2 Then
                    sanker.Show()
                    textBox1.Text = "Korisničko ime"
                    textBox2.Text = "Lozinka"
                    Enkripcija.HashPrijava = Nothing
                    Me.Hide()
                ElseIf tipNaloga = 3 Then
                    konobar.Show()
                    textBox1.Text = "Korisničko ime"
                    textBox2.Text = "Lozinka"
                    Enkripcija.HashPrijava = Nothing
                    Me.Hide()
                ElseIf tipNaloga = 4 Then
                    sanker.Show()
                    textBox1.Text = "Korisničko ime"
                    textBox2.Text = "Lozinka"
                    Enkripcija.HashPrijava = Nothing
                    Me.Hide()
                End If
            Else
                Enkripcija.HashPrijava = Nothing
                MessageBox.Show("Neuspješna prijava!")
                textBox1.Text = "Korisničko ime"
                textBox2.Text = "Lozinka"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        pregledNarudzbe.Show()
    End Sub
End Class
'