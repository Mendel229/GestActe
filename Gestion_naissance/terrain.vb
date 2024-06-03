Imports System.Data.OleDb

Public Class terrain
    Private provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sephora DIDAVI\Documents\Visual Studio 2015\Projects\Gestion_naissance\Gest.accdb;Persist Security Info=False"

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PanelMenu_Paint(sender As Object, e As PaintEventArgs) Handles PanelMenu.Paint

    End Sub

    Private Sub terrain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call afficher()
    End Sub
    Private Sub afficher()
        Dim con As New OleDbConnection(Me.provider)
        con.Open()
        Dim sel As String = "Select * from terrain"
        Dim command As New OleDbCommand(sel, con)
        Dim ret As OleDbDataReader
        ret = command.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While ret.Read
            DataGridView1.Rows.Add(ret.Item("id"), ret.Item("vendeur"), ret.Item("acheteur"), ret.Item("site"), ret.Item("superficie"), ret.Item("prix"), ret.Item("datevend"), ret.Item("tem1"), ret.Item("tem2"))
        Loop

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim nav As New addTerrain()
        nav.Show()

        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        iddd.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
        TextBox1.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
        TextBox2.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value
        TextBox5.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value
        TextBox3.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value
        TextBox8.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(5).Value
        DateTimePicker1.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(6).Value
        TextBox4.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value
        TextBox7.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(8).Value
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim nomvend, nomach, com, superf, prix, tem1, tem2, id As String

        nomvend = TextBox1.Text
        nomach = TextBox2.Text
        com = TextBox5.Text
        superf = TextBox3.Text
        prix = TextBox8.Text
        tem1 = TextBox4.Text
        tem2 = TextBox7.Text
        id = iddd.Text

        Dim datoor As DateTime
        datoor = DateTimePicker1.Value

        Try
            Dim con As New OleDbConnection(Me.provider)
            con.Open()
            Dim req As String = "update terrain set vendeur = '" & nomvend & "', acheteur = '" & nomach & "', datevend = '" & datoor & "', site = '" & com & "', superficie = '" & superf & "', prix = '" & prix & "', tem1 = '" & tem1 & "', tem2 = '" & tem2 & "' where id =" & id
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
            Dim req As String = "Delete * from terrain where id = " & id
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
End Class