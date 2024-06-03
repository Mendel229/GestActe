Imports System.Data.OleDb

Public Class addTerrain
    Private provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sephora DIDAVI\Documents\Visual Studio 2015\Projects\Gestion_naissance\Gest.accdb;Persist Security Info=False"
    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim nomacheteur, nomvendeur, tem1, tem2, vente, superficie, com As String

        nomacheteur = TextBox1.Text
        nomvendeur = TextBox3.Text
        tem1 = TextBox2.Text
        tem2 = TextBox7.Text
        vente = TextBox4.Text
        superficie = TextBox8.Text
        com = TextBox6.Text


        Dim dat As DateTime
        dat = DateTimePicker1.Value
        Try
            Dim con As New OleDbConnection(Me.provider)
            con.Open()
            Dim req As String = "INSERT INTO terrain (vendeur, acheteur, datevend, site, superficie, prix, tem1, tem2) VALUES (?,?,?,?,?,?,?,?)"
            Dim command As New OleDbCommand(req, con)
            command.Parameters.AddWithValue("?", nomvendeur)
            command.Parameters.AddWithValue("?", nomacheteur)
            command.Parameters.AddWithValue("?", dat)
            command.Parameters.AddWithValue("?", com)
            command.Parameters.AddWithValue("?", superficie)
            command.Parameters.AddWithValue("?", vente)
            command.Parameters.AddWithValue("?", tem1)
            command.Parameters.AddWithValue("?", tem2)

            If command.ExecuteNonQuery > 0 Then
                MessageBox.Show("Acte Enregistrer")
                Dim nav As New terrain()
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
        Dim nav As New terrain()
        nav.Show()
        Me.Hide()
    End Sub
End Class