Public Class admin
    Private Sub Nazad_Click(sender As Object, e As EventArgs) Handles Nazad.Click
        prijava.Show()
        Me.Close()
        Ponisti.PerformClick()
    End Sub

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KaficDataSet.Nalozi' table. You can move, or remove it, as needed.
        Me.NaloziTableAdapter.Fill(Me.KaficDataSet.Nalozi)

        Me.Focus()
        'TODO: This line of code loads data into the 'KaficDataSet1.Nalozi' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'KaficDataSet.Zaposleni' table. You can move, or remove it, as needed.

        PozicijaComboBox.SelectedIndex = -1
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class