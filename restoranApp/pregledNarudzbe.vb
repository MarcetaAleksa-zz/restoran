Imports System.Data.SqlClient

Public Class pregledNarudzbe
    Dim connection As New SqlConnection("server=ROMMEL; database=Kafic;user id=konobar;password=1")
    Dim com As New SqlCommand("SELECT * from meni", connection)
    Dim table As New DataTable()
    Dim ad As New SqlDataAdapter(com)





    Public Sub ucitaj(i As Integer)

        Dim sqlCommand As New SqlCommand("SELECT * FROM narudzbak ", Baza.connection)
        Dim adapter As New SqlDataAdapter(sqlCommand)
        Dim oprema_table1 As New DataTable()

        adapter.Fill(oprema_table1)

        Try
            Label4.Text = oprema_table1.Rows(i)(2)
            Label5.Text = oprema_table1.Rows(i)(3)
            Label6.Text = oprema_table1.Rows(i)(4)

        Catch ex As Exception

        End Try




    End Sub

    Private Sub pregledNarudzbe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        sanker.Enabled = True
        sanker.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'skidas sa stanje ucitanu tabelu
    End Sub
End Class