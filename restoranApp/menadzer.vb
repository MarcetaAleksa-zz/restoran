Public Class menadzer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        prijava.Show()
    End Sub

    Private Sub menadzer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KaficDataSet2.Skladiste' table. You can move, or remove it, as needed.
        Me.SkladisteTableAdapter1.Fill(Me.KaficDataSet2.Skladiste)
        'TODO: This line of code loads data into the 'KaficDataSet1.Skladiste' table. You can move, or remove it, as needed.
        ' Me.SkladisteTableAdapter.Fill(Me.KaficDataSet1.Skladiste)

    End Sub
End Class