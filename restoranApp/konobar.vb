Imports System.Data.SqlClient
Public Class konobar

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.Text = CDbl(Label3.Text) + 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label4.Text = CDbl(Label4.Text) + 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label5.Text = CDbl(Label5.Text) + 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        prijava.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Dim Command As New SqlCommand("SELECT * FROM NarudzbaK", Baza.connection)
        Dim Command1 As New SqlCommand("SELECT * FROM NarudzbaS", Baza.connection)

        Label2.Text = prijava.imePrijavljenog
        Label7.Text = TimeOfDay.ToString("h:mm tt")



        Try
            Baza.connection.Open()
            Dim Command As New SqlCommand("INSERT INTO NarudzbaK (redniBroj, konobar, CocaCola, Pepsi, Nektar) VALUES (" + TextBox1.Text + ", '" + prijava.KoJeOvajPokemon.Text + "' , " + Label3.Text + ", " + Label4.Text + ", " + Label5.Text + ") ", Baza.connection)


            'Command.Parameters.Add("@rBroj", SqlDbType.VarChar).Value = TextBox1.Text
            'Command.Parameters.Add("@imKonobara", SqlDbType.VarChar).Value = prijava.imePrijavljenog
            'Command.Parameters.Add("@kola", SqlDbType.VarChar).Value = Label3.Text
            'Command.Parameters.Add("@peps", SqlDbType.VarChar).Value = Label4.Text
            'Command.Parameters.Add("@nekt", SqlDbType.VarChar).Value = Label5.Text
            ' Command.Parameters.Add("@vrijeme", SqlDbType.VarChar).Value = Label6.Text
            Command1.CommandText = "INSERT INTO NarudzbaS (brojNarudzbe, konobar, vrijemeNarudzbe) VALUES (" + TextBox1.Text + ", '" + prijava.KoJeOvajPokemon.Text + "', '" + Label7.Text + "') "

            Command1.ExecuteNonQuery()
            Command.ExecuteNonQuery()

            Baza.connection.Close()
        Catch ex As Exception
            Baza.connection.Close()
            MessageBox.Show(ex.ToString)
        End Try

        ' label 1 - 2 - 3.text pretvoriti u int i ubaciti u tabelu narudzbe na pozocije redoslijedom navedene "kola" "pespi" "pivo" + ID NARUDZBE prvije svega
        ' ID NARUDZBE IME KONOBARA i VRIJEME dodati u tabelu koju ces tek napraviti, pregled narudzbi
        ' ID NADRUZBE iz pregleda narudzbi i ID NARUDZBE iz tabela narudzbe moraju biti iste i povezane, da se jedna odnosi na drugu
    End Sub

    Private Sub konobar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = prijava.imePrijavljenog
    End Sub
End Class