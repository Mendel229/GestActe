Imports System.Data.OleDb

Public Class mariage
    Private provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sephora DIDAVI\Documents\Visual Studio 2015\Projects\Gestion_naissance\Gest.accdb;Persist Security Info=False"
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim id As String
        id = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value
        Try
            Dim con As New OleDbConnection(Me.provider)
            con.Open()
            Dim req As String = "Delete * from mariage where id = " & id
            Dim command As New OleDbCommand(req, con)
            If command.ExecuteNonQuery > 0 Then
                MessageBox.Show("Suppression effectué")
                Call afficher()
            Else
                MessageBox.Show("Suppression non effectué")
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles npEpoux.TextChanged

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles npEpouse.TextChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles temEpouse.TextChanged

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles temEpoux.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub mariage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call afficher()
    End Sub

    Private Sub afficher()
        Dim con As New OleDbConnection(Me.provider)
        con.Open()
        Dim sel As String = "Select * from mariage"
        Dim command As New OleDbCommand(sel, con)
        Dim ret As OleDbDataReader
        ret = command.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While ret.Read
            DataGridView1.Rows.Add(ret.Item("epoux"), ret.Item("epouse"), ret.Item("datema"), ret.Item("commune"), ret.Item("tem1"), ret.Item("tem2"), ret.Item("officier"), ret.Item("id"))
        Loop

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        npEpoux.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
        npEpouse.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
        datman.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value
        comm.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value
        temEpoux.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value
        temEpouse.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(5).Value
        off.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(6).Value
        TextBox6.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim addmariage As New addMariage()
        addmariage.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim ep, epse, ofc, com, t1, t2, id As String

        ep = npEpoux.Text
        epse = npEpouse.Text
        ofc = off.Text
        com = comm.Text
        t1 = temEpoux.Text
        t2 = temEpouse.Text
        id = TextBox6.Text


        Dim dat As DateTime
        dat = datman.Value

        Try
            Dim con As New OleDbConnection(Me.provider)
            con.Open()
            Dim req As String = "update mariage set epoux = '" & ep & "', epouse = '" & epse & "', datema = '" & dat & "', commune = '" & com & "', officier = '" & ofc & "', tem1 = '" & t1 & "', tem2 = '" & t2 & "' where id =" & id
            Dim command As New OleDbCommand(req, con)
            If command.ExecuteNonQuery > 0 Then
                MessageBox.Show("Modificaton effectué")
                Call afficher()
            Else
                MessageBox.Show("Modificaton non effectué")
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
End Class