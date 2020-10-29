Imports System.Data.SqlClient
Public Class konobar
    Public Sub Sumiranje(i As String, b As Integer)
        Dim nazivPica As Label = New Label
        With nazivPica
            .Text = i
            .TextAlign = ContentAlignment.MiddleCenter
            .Visible = True
            .BackColor = Color.Transparent
            .Font = New Font("Microsoft Sans Serif", 14)
            .Dock = DockStyle.Fill
            TABLA.Controls.Add(nazivPica, 0, 0)
        End With
        Dim kolicina As Label = New Label
        With kolicina
            .Text = b
            .TextAlign = ContentAlignment.MiddleCenter
            .Visible = True
            .BackColor = Color.Transparent
            .Font = New Font("Microsoft Sans Serif", 14)
            .Dock = DockStyle.Fill
            TABLA.Controls.Add(kolicina, 1, 0)
        End With
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.Text = CDbl(Label3.Text) + 1
        'Button1.Tag = CDbl(Button1.Tag) + 1
        Sumiranje(Button1.Text, Label3.Text)
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

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click, Label20.Click, Label1.Click, Label38.Click, Label37.Click, Label34.Click, Label32.Click, Label29.Click, Label28.Click, Label27.Click, Label24.Click, Label23.Click, Label22.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click, Label36.Click, Label31.Click, Label26.Click, Label21.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click, Label40.Click, Label35.Click, Label30.Click, Label25.Click

    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click

    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click

    End Sub
End Class