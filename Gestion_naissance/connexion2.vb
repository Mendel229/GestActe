Imports System.Data.OleDb

Public Class connexion2
    Private provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Manu\Documents\Visual Studio 2015\Projects\Gestion_naissance\Gest.accdb;Persist Security Info=False"
    Private Sub connexion2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nom, pass
        nom = nam.Text
        pass = mdp.Text

        Try
            Dim con As New OleDbConnection(Me.provider)
            con.Open()
            Dim req As String = "SELECT COUNT (*) FROM users WHERE identifiant= ? AND code= ?"
            Dim command As New OleDbCommand(req, con)
            command.Parameters.AddWithValue("?", nom)
            command.Parameters.AddWithValue("?", pass)

            If command.ExecuteScalar > 0 Then
                MessageBox.Show("Sucess")

            Else
                MessageBox.Show("Erreur")
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class