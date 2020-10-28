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
        Dim brojacopreme As Integer
        adapter.Fill(oprema_table1)
        brojacopreme = oprema_table1.Rows.Count
        Try
            ' Label4.Text = oprema_table1.Rows(i)(2)
            ' Label5.Text = oprema_table1.Rows(i)(3)
            ' Label6.Text = oprema_table1.Rows(i)(4)
            Dim k As Integer = 2
            Do While k <> 6
                If oprema_table1(i)(k) <> 0 Then
                    Dim L As Label = New Label
                    With L
                        .Text = 'oprema_table1(i)(2)             'naziv artikla izvucen u label
                        .TextAlign = ContentAlignment.MiddleCenter
                        .Visible = True
                        .Font = New Font("Microsoft Sans Serif", 14)
                        .BackColor = Color.Transparent
                        .Dock = DockStyle.Fill
                        tab1.Controls.Add(L, 0, i)
                    End With
                    k = +1
                End If



                Dim L1 As Label = New Label
                With L1
                    .Text = oprema_table1(i)(1)
                    .Name = "L1" + i.ToString 'kolicina izvucena u label
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Visible = True
                    .Font = New Font("Microsoft Sans Serif", 14)
                    .BackColor = Color.Transparent
                    .Dock = DockStyle.Fill
                    tab1.Controls.Add(L1, 1, i)
                End With
                k = +1

                Dim L2 As Label = New Label
                With L2
                    .Text = oprema_table1(i)(2)
                    .TextAlign = ContentAlignment.MiddleCenter 'cijena izvucena u label
                    .Visible = True
                    .BackColor = Color.Transparent
                    .Font = New Font("Microsoft Sans Serif", 14)
                    .Dock = DockStyle.Fill
                    tab1.Controls.Add(L2, 2, i)
                End With
                k = +1

                Dim L3 As Label = New Label
                With L3

                    .Text = "OTVORI"
                    .Name = "b" + i.ToString
                    .Visible = True
                    .Size = New Size(100, 40)
                    tab1.Controls.Add(L3, 3, i)
                End With
                k = +1
            Loop
            tab1.HorizontalScroll.Enabled = False
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