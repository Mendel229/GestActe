Imports System.Data.OleDb
Imports System.Security.Cryptography
Public Class addMariage
    Private provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sephora DIDAVI\Documents\Visual Studio 2015\Projects\Gestion_naissance\Gest.accdb;Persist Security Info=False"
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub addMariage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim epx, epse, off, com, ref, tem1, tem2 As String

        epx = TextBox8.Text
        epse = TextBox9.Text
        tem1 = TextBox3.Text
        tem2 = TextBox1.Text
        off = TextBox6.Text
        com = TextBox7.Text

        Dim datema As DateTime
        datema = jour.Value
        Try
            Dim con As New OleDbConnection(Me.provider)
            con.Open()
            Dim req As String = "INSERT INTO mariage (epoux, epouse, datema, commune, officier, tem1, tem2) VALUES (?,?,?,?,?,?,?)"
            Dim command As New OleDbCommand(req, con)
            command.Parameters.AddWithValue("?", epx)
            command.Parameters.AddWithValue("?", epse)
            command.Parameters.AddWithValue("?", datema)
            command.Parameters.AddWithValue("?", com)
            command.Parameters.AddWithValue("?", off)
            command.Parameters.AddWithValue("?", tem1)
            command.Parameters.AddWithValue("?", tem2)

            If command.ExecuteNonQuery > 0 Then
                MessageBox.Show("Acte Enregistrer")
                Dim nav As New mariage()
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

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nav As New mariage()
        nav.Show()
        Me.Hide()
    End Sub

    Private Sub btnNaissance_Click(sender As Object, e As EventArgs) Handles btnNaissance.Click
        Dim nav As New naissance()
        nav.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nav As New terrain()
        nav.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim nav As New mariage()
        nav.Show()
        Me.Hide()
    End Sub
End Class