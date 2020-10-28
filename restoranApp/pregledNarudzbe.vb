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

        Dim sqlCommand1 As New SqlCommand("SELECT * FROM Skladiste ", Baza.connection)
        Dim adapter1 As New SqlDataAdapter(sqlCommand1)
        Dim oprema_table11 As New DataTable()
        adapter1.Fill(oprema_table11)
        Dim brojacOpreme As Integer = 0
        brojacOpreme = oprema_table11.Rows.Count
        Dim nesto As Integer = 0
        Dim noviRed As Integer = 0
        Label3.Text = oprema_table1.Rows(i)(0)
        Label4.Text = oprema_table1.Rows(i)(1)
        For k = 2 To brojacOpreme + 1
            Try
                nesto = k - 2

                If oprema_table1(i)(k) <> 0 And oprema_table1(i)(k) <> Nothing Then
                    Dim L As Label = New Label
                    With L
                        .Text = oprema_table11(nesto)(0)             'naziv artikla izvucen u label
                        .TextAlign = ContentAlignment.MiddleCenter
                        .Visible = True
                        .Font = New Font("Microsoft Sans Serif", 14)
                        .BackColor = Color.Transparent
                        .Dock = DockStyle.Fill
                        tab1.Controls.Add(L, 0, k - 2)
                    End With

                    Dim L1 As Label = New Label
                    With L1
                        .Text = oprema_table1(i)(k)
                        .Name = "L1" + i.ToString 'kolicina narucenog izvucena u label
                        .TextAlign = ContentAlignment.MiddleCenter
                        .Visible = True
                        .Font = New Font("Microsoft Sans Serif", 14)
                        .BackColor = Color.Transparent
                        .Dock = DockStyle.Fill
                        tab1.Controls.Add(L1, 1, k - 2)
                    End With

                    Dim L2 As Label = New Label
                    With L2
                        .Text = Math.Round(oprema_table11(nesto)(2), 2)
                        .TextAlign = ContentAlignment.MiddleCenter 'cijena izvucena u label
                        .Visible = True
                        .BackColor = Color.Transparent
                        .Font = New Font("Microsoft Sans Serif", 14)
                        .Dock = DockStyle.Fill
                        tab1.Controls.Add(L2, 2, k - 2)
                    End With
                    Try
                        Dim L3 As Label = New Label
                        With L3
                            .Text = Math.Round(L2.Text * CDec(Val(L1.Text)), 2)
                            'Math.Round((L2.Text * L1.Text), 2)
                            .TextAlign = ContentAlignment.MiddleCenter 'cijena izvucena u label
                            .Visible = True
                            .BackColor = Color.Transparent
                            .Font = New Font("Microsoft Sans Serif", 14)
                            .Dock = DockStyle.Fill
                            tab1.Controls.Add(L3, 3, k - 2)
                        End With
                        Label12.Text = Math.Round(CDec(Val(Label12.Text)) + CDec(Val(L3.Text)), 2) & "KM"
                    Catch ex As Exception
                        Dim L3 As Label = New Label
                        With L3
                            .Text = "error 404"
                            .TextAlign = ContentAlignment.MiddleCenter
                            .Visible = True
                            .BackColor = Color.Transparent
                            .Font = New Font("Microsoft Sans Serif", 14)
                            .Dock = DockStyle.Fill
                            tab1.Controls.Add(L3, 3, k - 2)
                        End With
                    End Try

                    tab1.HorizontalScroll.Enabled = False
                End If
            Catch ex As Exception
            End Try
        Next

    End Sub

    Private Sub pregledNarudzbe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        pregledNarudzbe_Load(e, e)
        Me.Hide()
        sanker.Enabled = True
        sanker.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'skidas sa stanje ucitanu tabelu
    End Sub
End Class