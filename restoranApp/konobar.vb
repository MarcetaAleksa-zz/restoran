Imports System.Data.SqlClient
Public Class konobar
    Public Shared counter As Integer = 0
    Public Sub Sumiranje(i As String, b As Integer)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CocaColaL.Text = CDbl(CocaColaL.Text) + 1
        Button1.Tag = CDbl(Button1.Tag) + 1
        ' Sumiranje(Button1.Text, Label3.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PepsiL.Text = CDbl(PepsiL.Text) + 1
        Button2.Tag = CDbl(Button2.Tag) + 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FantaL.Text = CDbl(FantaL.Text) + 1
        Button3.Tag = CDbl(Button3.Tag) + 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        prijava.Button3_Click_1(e, e)
        Me.Hide()
        prijava.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim commandS As New SqlCommand("SELECT Max(brojNarudzbe) FROM NarudzbaS", Baza.connection)
        Dim adapterS As New SqlDataAdapter(commandS)
        Dim tableS As New DataTable
        adapterS.Fill(tableS)
        Dim vrijednostID As Integer
        Try
            vrijednostID = tableS.Rows(0)(0)
            vrijednostID += 1
        Catch ex As Exception
            vrijednostID = 1
        End Try
        Label2.Text = prijava.imePrijavljenog
        Try
            Baza.connection.Open()
            For Each button In Me.Controls
                If button.tag > 0 Then
                    Dim sirnica As Double
                    Dim mesnica As String
                    sirnica = button.Tag
                    mesnica = button.text
                    Dim Command As New SqlCommand("INSERT INTO NarudzbaK (redniBroj, konobar, id_pica, kolicina) VALUES (" + vrijednostID.ToString + ",'" + prijava.KoJeOvajPokemon.Text + "','" + mesnica.ToString + "', " + sirnica.ToString + " )", Baza.connection)
                    Command.ExecuteNonQuery()
                End If
            Next
            Dim brojac As Integer
            brojac = 0
            brojac += 1
            Dim Command1 As New SqlCommand("INSERT INTO NarudzbaS (brojNarudzbe, konobar, vrijemeNarudzbe) VALUES (" + vrijednostID.ToString + ", '" + prijava.KoJeOvajPokemon.Text + "', '" + Label1.Text + "') ", Baza.connection)
            brojac += 1

            If brojac = 2 And counter < 40 Then
                Command1.ExecuteNonQuery()
                Baza.connection.Close()
                MsgBox("Narudzba poslata sankeru!")
                Me.Controls.Clear()
                InitializeComponent()
                konobar_Load(e, e)
            ElseIf counter = 40 Then
                MsgBox("Ne mozete poslati praznu narudzbu!")
                Baza.connection.Close()
            End If
        Catch ex As Exception
            Baza.connection.Close()
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub konobar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = prijava.imePrijavljenog
    End Sub
    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        Me.Controls.Clear()
        InitializeComponent()
        konobar_Load(e, e)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter = 0
        Try
            For Each Label In Me.Controls
                If Label.text = "0" Then
                    Label.visible = False
                    counter += 1
                ElseIf Label.text = "-1" Or Label.text = "-2" Or Label.text = "-3" Then
                    Label.text = 0
                    Label.visible = False
                Else
                    Label.visible = True
                End If
            Next
        Catch ex As Exception
        End Try

        Try
            For Each button In Me.Controls
                If button.tag < 0 Then
                    button.tag = 0
                End If
            Next
        Catch ex As Exception

        End Try


        Label1.Text = TimeOfDay.ToString("hh:mm tt")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RedBullL.Text = CDbl(RedBullL.Text) + 1
        Button6.Tag = CDbl(Button6.Tag) + 1
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        SchweppesL.Text = CDbl(SchweppesL.Text) + 1
        Button28.Tag = CDbl(Button28.Tag) + 1
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        SpriteL.Text = CDbl(SpriteL.Text) + 1
        Button29.Tag = CDbl(Button29.Tag) + 1
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MineralnaL.Text = CDbl(MineralnaL.Text) + 1
        Button7.Tag = CDbl(Button7.Tag) + 1
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        JuiceL.Text = CDbl(JuiceL.Text) + 1
        Button11.Tag = CDbl(Button11.Tag) + 1
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        JabukaL.Text = CDbl(JabukaL.Text) + 1
        Button8.Tag = CDbl(Button8.Tag) + 1
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        VisnjaL.Text = CDbl(VisnjaL.Text) + 1
        Button12.Tag = CDbl(Button12.Tag) + 1
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        BorovnicaL.Text = CDbl(BorovnicaL.Text) + 1
        Button13.Tag = CDbl(Button13.Tag) + 1
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        MultivitaminL.Text = CDbl(MultivitaminL.Text) + 1
        Button15.Tag = CDbl(Button15.Tag) + 1
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        CijedjenisokL.Text = CDbl(CijedjenisokL.Text) + 1
        Button14.Tag = CDbl(Button14.Tag) + 1
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        LedeniCajL.Text = CDbl(LedeniCajL.Text) + 1
        Button40.Tag = CDbl(Button40.Tag) + 1
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        VodasokusomL.Text = CDbl(VodasokusomL.Text) + 1
        Button9.Tag = CDbl(Button9.Tag) + 1
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        IzvorskavodaL.Text = CDbl(IzvorskavodaL.Text) + 1
        Button10.Tag = CDbl(Button10.Tag) + 1
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        EsspressoL.Text = CDbl(EsspressoL.Text) + 1
        Button16.Tag = CDbl(Button16.Tag) + 1
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        EspressosmlijekomL.Text = CDbl(EspressosmlijekomL.Text) + 1
        Button20.Tag = CDbl(Button20.Tag) + 1
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        MacchiatoL.Text = CDbl(MacchiatoL.Text) + 1
        Button21.Tag = CDbl(Button21.Tag) + 1
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        CappuccinoL.Text = CDbl(CappuccinoL.Text) + 1
        Button17.Tag = CDbl(Button17.Tag) + 1
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        NesscafeL.Text = CDbl(NesscafeL.Text) + 1
        Button22.Tag = CDbl(Button22.Tag) + 1
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        ToplacokoladaL.Text = CDbl(ToplacokoladaL.Text) + 1
        Button19.Tag = CDbl(Button19.Tag) + 1
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        CajL.Text = CDbl(CajL.Text) + 1
        Button18.Tag = CDbl(Button18.Tag) + 1
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        HeinekenL.Text = CDbl(HeinekenL.Text) + 1
        Button25.Tag = CDbl(Button25.Tag) + 1
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        NektarL.Text = CDbl(NektarL.Text) + 1
        Button23.Tag = CDbl(Button23.Tag) + 1
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        JelenL.Text = CDbl(JelenL.Text) + 1
        Button31.Tag = CDbl(Button31.Tag) + 1
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        StaropramenL.Text = CDbl(StaropramenL.Text) + 1
        Button32.Tag = CDbl(Button32.Tag) + 1
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        BanjaluckoL.Text = CDbl(BanjaluckoL.Text) + 1
        Button33.Tag = CDbl(Button33.Tag) + 1
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        TuborgL.Text = CDbl(TuborgL.Text) + 1
        Button34.Tag = CDbl(Button34.Tag) + 1
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        BecksL.Text = CDbl(BecksL.Text) + 1
        Button35.Tag = CDbl(Button35.Tag) + 1
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        JackDanielsL.Text = CDbl(JackDanielsL.Text) + 1
        Button26.Tag = CDbl(Button26.Tag) + 1
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        BelvedereL.Text = CDbl(BelvedereL.Text) + 1
        Button24.Tag = CDbl(Button24.Tag) + 1
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        GreygooseL.Text = CDbl(GreygooseL.Text) + 1
        Button36.Tag = CDbl(Button36.Tag) + 1
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        VigorVodkaL.Text = CDbl(VigorVodkaL.Text) + 1
        Button37.Tag = CDbl(Button37.Tag) + 1
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        JagermeisterL.Text = CDbl(JagermeisterL.Text) + 1
        Button38.Tag = CDbl(Button38.Tag) + 1
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        AbsinthL.Text = CDbl(AbsinthL.Text) + 1
        Button39.Tag = CDbl(Button39.Tag) + 1
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        ViljamovkaL.Text = CDbl(ViljamovkaL.Text) + 1
        Button27.Tag = CDbl(Button27.Tag) + 1
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        GinL.Text = CDbl(GinL.Text) + 1
        Button30.Tag = CDbl(Button30.Tag) + 1
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        BadelKonjakL.Text = CDbl(BadelKonjakL.Text) + 1
        Button41.Tag = CDbl(Button41.Tag) + 1
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        RubinovVinjakL.Text = CDbl(RubinovVinjakL.Text) + 1
        Button42.Tag = CDbl(Button42.Tag) + 1
    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        If e.Button = MouseButtons.Right Then
            CocaColaL.Text = CDbl(CocaColaL.Text) - 1
            Button1.Tag = CDbl(Button1.Tag) - 1
        End If
    End Sub

    Private Sub Button2_MouseDown(sender As Object, e As MouseEventArgs) Handles Button2.MouseDown
        If e.Button = MouseButtons.Right Then
            PepsiL.Text = CDbl(PepsiL.Text) - 1
            Button2.Tag = CDbl(Button2.Tag) - 1
        End If
    End Sub

    Private Sub Button3_MouseDown(sender As Object, e As MouseEventArgs) Handles Button3.MouseDown
        If e.Button = MouseButtons.Right Then
            FantaL.Text = CDbl(FantaL.Text) - 1
            Button3.Tag = CDbl(Button3.Tag) - 1
        End If
    End Sub

    Private Sub Button6_MouseDown(sender As Object, e As MouseEventArgs) Handles Button6.MouseDown
        If e.Button = MouseButtons.Right Then
            RedBullL.Text = CDbl(RedBullL.Text) - 1
            Button6.Tag = CDbl(Button6.Tag) - 1
        End If
    End Sub

    Private Sub Button28_MouseDown(sender As Object, e As MouseEventArgs) Handles Button28.MouseDown
        If e.Button = MouseButtons.Right Then
            SchweppesL.Text = CDbl(SchweppesL.Text) - 1
            Button28.Tag = CDbl(Button28.Tag) - 1
        End If
    End Sub

    Private Sub Button29_MouseDown(sender As Object, e As MouseEventArgs) Handles Button29.MouseDown
        If e.Button = MouseButtons.Right Then
            SpriteL.Text = CDbl(SpriteL.Text) - 1
            Button29.Tag = CDbl(Button29.Tag) - 1
        End If
    End Sub

    Private Sub Button7_MouseDown(sender As Object, e As MouseEventArgs) Handles Button7.MouseDown
        If e.Button = MouseButtons.Right Then
            MineralnaL.Text = CDbl(MineralnaL.Text) - 1
            Button7.Tag = CDbl(Button7.Tag) - 1
        End If
    End Sub

    Private Sub Button11_MouseDown(sender As Object, e As MouseEventArgs) Handles Button11.MouseDown
        If e.Button = MouseButtons.Right Then
            JuiceL.Text = CDbl(JuiceL.Text) - 1
            Button11.Tag = CDbl(Button11.Tag) - 1
        End If
    End Sub

    Private Sub Button8_MouseDown(sender As Object, e As MouseEventArgs) Handles Button8.MouseDown
        If e.Button = MouseButtons.Right Then
            JabukaL.Text = CDbl(JabukaL.Text) - 1
            Button8.Tag = CDbl(Button8.Tag) - 1
        End If
    End Sub

    Private Sub Button12_MouseDown(sender As Object, e As MouseEventArgs) Handles Button12.MouseDown
        If e.Button = MouseButtons.Right Then
            VisnjaL.Text = CDbl(VisnjaL.Text) - 1
            Button12.Tag = CDbl(Button12.Tag) - 1
        End If
    End Sub

    Private Sub Button13_MouseDown(sender As Object, e As MouseEventArgs) Handles Button13.MouseDown
        If e.Button = MouseButtons.Right Then
            BorovnicaL.Text = CDbl(BorovnicaL.Text) - 1
            Button13.Tag = CDbl(Button13.Tag) - 1
        End If
    End Sub

    Private Sub Button15_MouseDown(sender As Object, e As MouseEventArgs) Handles Button15.MouseDown
        If e.Button = MouseButtons.Right Then
            MultivitaminL.Text = CDbl(MultivitaminL.Text) - 1
            Button15.Tag = CDbl(Button15.Tag) - 1
        End If
    End Sub

    Private Sub Button14_MouseDown(sender As Object, e As MouseEventArgs) Handles Button14.MouseDown
        If e.Button = MouseButtons.Right Then
            CijedjenisokL.Text = CDbl(CijedjenisokL.Text) - 1
            Button14.Tag = CDbl(Button14.Tag) - 1
        End If
    End Sub

    Private Sub Button40_MouseDown(sender As Object, e As MouseEventArgs) Handles Button40.MouseDown
        If e.Button = MouseButtons.Right Then
            LedeniCajL.Text = CDbl(LedeniCajL.Text) - 1
            Button40.Tag = CDbl(Button40.Tag) - 1
        End If
    End Sub

    Private Sub Button9_MouseDown(sender As Object, e As MouseEventArgs) Handles Button9.MouseDown
        If e.Button = MouseButtons.Right Then
            VodasokusomL.Text = CDbl(VodasokusomL.Text) - 1
            Button9.Tag = CDbl(Button9.Tag) - 1
        End If
    End Sub

    Private Sub Button10_MouseDown(sender As Object, e As MouseEventArgs) Handles Button10.MouseDown
        If e.Button = MouseButtons.Right Then
            IzvorskavodaL.Text = CDbl(IzvorskavodaL.Text) - 1
            Button10.Tag = CDbl(Button10.Tag) - 1
        End If
    End Sub

    Private Sub Button16_MouseDown(sender As Object, e As MouseEventArgs) Handles Button16.MouseDown
        If e.Button = MouseButtons.Right Then
            EsspressoL.Text = CDbl(EsspressoL.Text) - 1
            Button16.Tag = CDbl(Button16.Tag) - 1
        End If
    End Sub

    Private Sub Button20_MouseDown(sender As Object, e As MouseEventArgs) Handles Button20.MouseDown
        If e.Button = MouseButtons.Right Then
            EspressosmlijekomL.Text = CDbl(EspressosmlijekomL.Text) - 1
            Button20.Tag = CDbl(Button20.Tag) - 1
        End If
    End Sub

    Private Sub Button21_MouseDown(sender As Object, e As MouseEventArgs) Handles Button21.MouseDown
        If e.Button = MouseButtons.Right Then
            MacchiatoL.Text = CDbl(MacchiatoL.Text) - 1
            Button21.Tag = CDbl(Button21.Tag) - 1
        End If
    End Sub

    Private Sub Button17_MouseDown(sender As Object, e As MouseEventArgs) Handles Button17.MouseDown
        If e.Button = MouseButtons.Right Then
            CappuccinoL.Text = CDbl(CappuccinoL.Text) - 1
            Button17.Tag = CDbl(Button17.Tag) - 1
        End If
    End Sub

    Private Sub Button22_MouseDown(sender As Object, e As MouseEventArgs) Handles Button22.MouseDown
        If e.Button = MouseButtons.Right Then
            NesscafeL.Text = CDbl(NesscafeL.Text) - 1
            Button22.Tag = CDbl(Button22.Tag) - 1
        End If
    End Sub

    Private Sub Button19_MouseDown(sender As Object, e As MouseEventArgs) Handles Button19.MouseDown
        If e.Button = MouseButtons.Right Then
            ToplacokoladaL.Text = CDbl(ToplacokoladaL.Text) - 1
            Button19.Tag = CDbl(Button19.Tag) - 1
        End If
    End Sub

    Private Sub Button18_MouseDown(sender As Object, e As MouseEventArgs) Handles Button18.MouseDown
        If e.Button = MouseButtons.Right Then
            CajL.Text = CDbl(CajL.Text) - 1
            Button18.Tag = CDbl(Button18.Tag) - 1
        End If
    End Sub

    Private Sub Button25_MouseDown(sender As Object, e As MouseEventArgs) Handles Button25.MouseDown
        If e.Button = MouseButtons.Right Then
            HeinekenL.Text = CDbl(HeinekenL.Text) - 1
            Button25.Tag = CDbl(Button25.Tag) - 1
        End If
    End Sub

    Private Sub Button23_MouseDown(sender As Object, e As MouseEventArgs) Handles Button23.MouseDown
        If e.Button = MouseButtons.Right Then
            NektarL.Text = CDbl(NektarL.Text) - 1
            Button23.Tag = CDbl(Button23.Tag) - 1
        End If
    End Sub

    Private Sub Button31_MouseDown(sender As Object, e As MouseEventArgs) Handles Button31.MouseDown
        If e.Button = MouseButtons.Right Then
            JelenL.Text = CDbl(JelenL.Text) - 1
            Button31.Tag = CDbl(Button31.Tag) - 1
        End If
    End Sub

    Private Sub Button32_MouseDown(sender As Object, e As MouseEventArgs) Handles Button32.MouseDown
        If e.Button = MouseButtons.Right Then
            StaropramenL.Text = CDbl(StaropramenL.Text) - 1
            Button32.Tag = CDbl(Button32.Tag) - 1
        End If
    End Sub

    Private Sub Button33_MouseDown(sender As Object, e As MouseEventArgs) Handles Button33.MouseDown
        If e.Button = MouseButtons.Right Then
            BanjaluckoL.Text = CDbl(BanjaluckoL.Text) - 1
            Button33.Tag = CDbl(Button33.Tag) - 1
        End If
    End Sub

    Private Sub Button34_MouseDown(sender As Object, e As MouseEventArgs) Handles Button34.MouseDown
        If e.Button = MouseButtons.Right Then
            TuborgL.Text = CDbl(TuborgL.Text) - 1
            Button34.Tag = CDbl(Button34.Tag) - 1
        End If
    End Sub

    Private Sub Button35_MouseDown(sender As Object, e As MouseEventArgs) Handles Button35.MouseDown
        If e.Button = MouseButtons.Right Then
            BecksL.Text = CDbl(BecksL.Text) - 1
            Button35.Tag = CDbl(Button35.Tag) - 1
        End If
    End Sub

    Private Sub Button26_MouseDown(sender As Object, e As MouseEventArgs) Handles Button26.MouseDown
        If e.Button = MouseButtons.Right Then
            JackDanielsL.Text = CDbl(JackDanielsL.Text) - 1
            Button26.Tag = CDbl(Button26.Tag) - 1
        End If
    End Sub

    Private Sub Button24_MouseDown(sender As Object, e As MouseEventArgs) Handles Button24.MouseDown
        If e.Button = MouseButtons.Right Then
            BelvedereL.Text = CDbl(BelvedereL.Text) - 1
            Button24.Tag = CDbl(Button24.Tag) - 1
        End If
    End Sub

    Private Sub Button36_MouseDown(sender As Object, e As MouseEventArgs) Handles Button36.MouseDown
        If e.Button = MouseButtons.Right Then
            GreygooseL.Text = CDbl(GreygooseL.Text) - 1
            Button36.Tag = CDbl(Button36.Tag) - 1
        End If
    End Sub

    Private Sub Button37_MouseDown(sender As Object, e As MouseEventArgs) Handles Button37.MouseDown
        If e.Button = MouseButtons.Right Then
            VigorVodkaL.Text = CDbl(VigorVodkaL.Text) - 1
            Button37.Tag = CDbl(Button37.Tag) - 1
        End If
    End Sub

    Private Sub Button38_MouseDown(sender As Object, e As MouseEventArgs) Handles Button38.MouseDown
        If e.Button = MouseButtons.Right Then
            JagermeisterL.Text = CDbl(JagermeisterL.Text) - 1
            Button38.Tag = CDbl(Button38.Tag) - 1
        End If
    End Sub

    Private Sub Button39_MouseDown(sender As Object, e As MouseEventArgs) Handles Button39.MouseDown
        If e.Button = MouseButtons.Right Then
            AbsinthL.Text = CDbl(AbsinthL.Text) - 1
            Button39.Tag = CDbl(Button39.Tag) - 1
        End If
    End Sub

    Private Sub Button27_MouseDown(sender As Object, e As MouseEventArgs) Handles Button27.MouseDown
        If e.Button = MouseButtons.Right Then
            ViljamovkaL.Text = CDbl(ViljamovkaL.Text) - 1
            Button27.Tag = CDbl(Button27.Tag) - 1
        End If
    End Sub

    Private Sub Button30_MouseDown(sender As Object, e As MouseEventArgs) Handles Button30.MouseDown
        If e.Button = MouseButtons.Right Then
            GinL.Text = CDbl(GinL.Text) - 1
            Button30.Tag = CDbl(Button30.Tag) - 1
        End If
    End Sub

    Private Sub Button41_MouseDown(sender As Object, e As MouseEventArgs) Handles Button41.MouseDown
        If e.Button = MouseButtons.Right Then
            BadelKonjakL.Text = CDbl(BadelKonjakL.Text) - 1
            Button41.Tag = CDbl(Button41.Tag) - 1
        End If
    End Sub

    Private Sub Button42_MouseDown(sender As Object, e As MouseEventArgs) Handles Button42.MouseDown
        If e.Button = MouseButtons.Right Then
            RubinovVinjakL.Text = CDbl(RubinovVinjakL.Text) - 1
            Button42.Tag = CDbl(Button42.Tag) - 1
        End If
    End Sub
End Class