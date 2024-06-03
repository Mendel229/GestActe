Imports System.Data.OleDb
Public Class addNaissance
    Private provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sephora DIDAVI\Documents\Visual Studio 2015\Projects\Gestion_naissance\Gest.accdb;Persist Security Info=False"

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim nom, nomp, nomm, com, dat, hop, pre As String

        nom = TextBox1.Text
        nomp = TextBox2.Text
        nomm = TextBox7.Text
        com = TextBox6.Text
        hop = TextBox4.Text
        pre = TextBox3.Text


        Dim datema As DateTime
        dat = DateTimePicker1.Value
        Try
            Dim con As New OleDbConnection(Me.provider)
            con.Open()
            Dim req As String = "INSERT INTO birth (childname, childsurname, birthday, birthplace, hospital, mothername, dadname) VALUES (?,?,?,?,?,?,?)"
            Dim command As New OleDbCommand(req, con)
            command.Parameters.AddWithValue("?", nom)
            command.Parameters.AddWithValue("?", pre)
            command.Parameters.AddWithValue("?", dat)
            command.Parameters.AddWithValue("?", com)
            command.Parameters.AddWithValue("?", hop)
            command.Parameters.AddWithValue("?", nomp)
            command.Parameters.AddWithValue("?", nomm)

            If command.ExecuteNonQuery > 0 Then
                MessageBox.Show("Acte Enregistrer")
                Dim nav As New naissance()
                nav.Show()
                Me.Hide()

                
            Else
                MessageBox.Show("Erreur")
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnNaissance_Click(sender As Object, e As EventArgs) Handles btnNaissance.Click

        Dim nav As New naissance()
        nav.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nav As New mariage()
        nav.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nav As New terrain()
        nav.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim nav As New naissance()
        nav.Show()
        Me.Hide()
    End Sub
End Class