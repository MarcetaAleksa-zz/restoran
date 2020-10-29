﻿Imports System.Data.SqlClient

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

    Private Sub Dodaj_Click(sender As Object, e As EventArgs) Handles Dodaj.Click

        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter()
        Dim holdit As Integer
        Try
            Try
                Select Case PozicijaComboBox.Text
                    Case "Administrator"
                        holdit = 1
                    Case "Vlasnik"
                        holdit = 2
                    Case "Konobar"
                        holdit = 3
                    Case "Sanker"
                        holdit = 4
                    Case Else
                        Debug.WriteLine("Izaberite poziciju zaposlenog.")
                End Select
            Catch ex As Exception
            End Try
            If TextBox5.Text = "" Or TextBox2.Text = "" Or PozicijaComboBox.Text = "" Then
                MsgBox("Polja nisu ispunjena!")
            Else
                Try
                    Enkripcija.EncryptPass()
                    Baza.connection.Open()
                    Dim command As New SqlCommand("INSERT INTO dbo.Zaposleni (korisnickoIme, lozinka, pozicija, ime, prezime, sluzbeniEmail, mobitel, sluzbeniMobitel) 
VALUES ('" & TextBox5.Text & "','" & Enkripcija.HashNoviK & "', '" & holdit & "' , '" & imeTextBox.Text & "' , '" & TextBox1.Text & "' , '" & TextBox3.Text & "', '" & TextBox6.Text & "', '" & TextBox4.Text & "')", Baza.connection)
                    command.ExecuteNonQuery()
                    MsgBox("Uspjesno ste dodali korisnika!")

                    Me.Controls.Clear() 'removes all the controls on the form
                    InitializeComponent() 'load all the controls again
                    admin_Load(e, e)


                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    Baza.connection.Close()
                End Try
            End If

        Catch ex As Exception
                MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class