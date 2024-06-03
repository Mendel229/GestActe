Imports System.Data.OleDb
Public Class Connexion
    Private provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sephora DIDAVI\Documents\Visual Studio 2015\Projects\Gestion_naissance\Gest.accdb;Persist Security Info=False"
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PanelLogo_Paint(sender As Object, e As PaintEventArgs) Handles PanelLogo.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim nom, mdp
        nom = Pass.Text
        mdp = User.Text

        Try
            Dim con As New OleDbConnection(Me.provider)
            con.Open()
            Dim req As String = "SELECT COUNT (*) FROM users WHERE identifiant= ? AND code= ?"
            Dim command As New OleDbCommand(req, con)
            command.Parameters.AddWithValue("?", nom)
            command.Parameters.AddWithValue("?", mdp)

            If command.ExecuteScalar > 0 Then
                Dim nav As New naissance()
                nav.Show()
                Me.Hide()

            Else
                MessageBox.Show("Le mot de passe est incorrect (Vérifiez S'il-vous-plais le document de conception pour prendre les identifiants correctes! Merci )")
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
End Class