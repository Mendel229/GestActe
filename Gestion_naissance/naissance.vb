Imports System.Data.OleDb

Public Class naissance
    Private provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sephora DIDAVI\Documents\Visual Studio 2015\Projects\Gestion_naissance\Gest.accdb;Persist Security Info=False"

    Private Sub naissance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call afficher()
    End Sub

    Private Sub afficher()
        Dim con As New OleDbConnection(Me.provider)
        con.Open()
        Dim sel As String = "Select * from birth"
        Dim command As New OleDbCommand(sel, con)
        Dim ret As OleDbDataReader
        ret = command.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While ret.Read
            DataGridView1.Rows.Add(ret.Item("id"), ret.Item("childname"), ret.Item("childsurname"), ret.Item("birthday"), ret.Item("birthplace"), ret.Item("hospital"), ret.Item("dadname"), ret.Item("mothername"))
        Loop

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim nav As New addNaissance()
        nav.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox6.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
        TextBox1.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
        TextBox2.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value
        DateTimePicker1.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value
        TextBox7.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value
        TextBox8.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(5).Value
        TextBox5.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(6).Value
        TextBox3.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim nom, pre, hop, nomp, nomm, com, id As String

        nom = TextBox1.Text
        pre = TextBox2.Text
        com = TextBox7.Text
        hop = TextBox8.Text
        nomp = TextBox5.Text
        nomm = TextBox3.Text
        id = TextBox6.Text

        Dim datoor As DateTime
        datoor = DateTimePicker1.Value

        Try
            Dim con As New OleDbConnection(Me.provider)
            con.Open()
            Dim req As String = "update birth set childname = '" & nom & "', childsurname = '" & pre & "', birthday = '" & datoor & "', birthplace = '" & com & "', hospital = '" & hop & "', dadname = '" & nomp & "', mothername = '" & nomm & "' where id =" & id
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim id As String
        id = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
        Try
            Dim con As New OleDbConnection(Me.provider)
            con.Open()
            Dim req As String = "Delete * from birth where id = " & id
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