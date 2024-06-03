<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mariage
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnNaissance = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NomEpoux = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomEpouse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datema = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomCom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomTemEpoux = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomTemEpouse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomOfficier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columnn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox6 = New System.Windows.Forms.Label()
        Me.datman = New System.Windows.Forms.DateTimePicker()
        Me.comm = New System.Windows.Forms.TextBox()
        Me.off = New System.Windows.Forms.TextBox()
        Me.temEpoux = New System.Windows.Forms.TextBox()
        Me.npEpoux = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.npEpouse = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.temEpouse = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.Button3)
        Me.PanelMenu.Controls.Add(Me.Button2)
        Me.PanelMenu.Controls.Add(Me.Button1)
        Me.PanelMenu.Controls.Add(Me.btnNaissance)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(156, 585)
        Me.PanelMenu.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button3.Location = New System.Drawing.Point(0, 525)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(156, 60)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Paramètre"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button2.Location = New System.Drawing.Point(0, 200)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(156, 60)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Acte de vente de terrain"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button1.Location = New System.Drawing.Point(0, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(156, 60)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Acte de mariage"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnNaissance
        '
        Me.btnNaissance.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnNaissance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNaissance.FlatAppearance.BorderSize = 0
        Me.btnNaissance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNaissance.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnNaissance.Location = New System.Drawing.Point(0, 80)
        Me.btnNaissance.Name = "btnNaissance"
        Me.btnNaissance.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.btnNaissance.Size = New System.Drawing.Size(156, 60)
        Me.btnNaissance.TabIndex = 1
        Me.btnNaissance.Text = "Acte de naissance"
        Me.btnNaissance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNaissance.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PanelLogo.Controls.Add(Me.Label2)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(156, 80)
        Me.PanelLogo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "GestActe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(170, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Liste des  mariages enregistrer :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(337, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Actes de mariage"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(156, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(855, 80)
        Me.Panel1.TabIndex = 10
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(847, 98)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(115, 19)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Enregistrer un marige"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomEpoux, Me.NomEpouse, Me.datema, Me.nomCom, Me.NomTemEpoux, Me.NomTemEpouse, Me.NomOfficier, Me.Columnn})
        Me.DataGridView1.Location = New System.Drawing.Point(172, 140)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(790, 216)
        Me.DataGridView1.TabIndex = 12
        '
        'NomEpoux
        '
        Me.NomEpoux.HeaderText = "Nom et prénoms de l'epoux"
        Me.NomEpoux.MinimumWidth = 6
        Me.NomEpoux.Name = "NomEpoux"
        Me.NomEpoux.ReadOnly = True
        Me.NomEpoux.Width = 125
        '
        'NomEpouse
        '
        Me.NomEpouse.HeaderText = "Nom et prénoms de l'epouse"
        Me.NomEpouse.MinimumWidth = 6
        Me.NomEpouse.Name = "NomEpouse"
        Me.NomEpouse.ReadOnly = True
        Me.NomEpouse.Width = 125
        '
        'datema
        '
        Me.datema.HeaderText = "Date de mariage"
        Me.datema.MinimumWidth = 6
        Me.datema.Name = "datema"
        Me.datema.ReadOnly = True
        Me.datema.Width = 125
        '
        'nomCom
        '
        Me.nomCom.HeaderText = "Nom de la commune"
        Me.nomCom.MinimumWidth = 6
        Me.nomCom.Name = "nomCom"
        Me.nomCom.ReadOnly = True
        Me.nomCom.Width = 125
        '
        'NomTemEpoux
        '
        Me.NomTemEpoux.HeaderText = "Nom et prénoms du Témoin de l'époux"
        Me.NomTemEpoux.MinimumWidth = 6
        Me.NomTemEpoux.Name = "NomTemEpoux"
        Me.NomTemEpoux.ReadOnly = True
        Me.NomTemEpoux.Width = 125
        '
        'NomTemEpouse
        '
        Me.NomTemEpouse.HeaderText = "Nom et prénoms du Témoin de l'épouse"
        Me.NomTemEpouse.MinimumWidth = 6
        Me.NomTemEpouse.Name = "NomTemEpouse"
        Me.NomTemEpouse.ReadOnly = True
        Me.NomTemEpouse.Width = 125
        '
        'NomOfficier
        '
        Me.NomOfficier.HeaderText = "Nom et prénoms de l'officier"
        Me.NomOfficier.MinimumWidth = 6
        Me.NomOfficier.Name = "NomOfficier"
        Me.NomOfficier.ReadOnly = True
        Me.NomOfficier.Width = 125
        '
        'Columnn
        '
        Me.Columnn.HeaderText = "id"
        Me.Columnn.Name = "Columnn"
        Me.Columnn.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBox6)
        Me.Panel2.Controls.Add(Me.datman)
        Me.Panel2.Controls.Add(Me.comm)
        Me.Panel2.Controls.Add(Me.off)
        Me.Panel2.Controls.Add(Me.temEpoux)
        Me.Panel2.Controls.Add(Me.npEpoux)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.npEpouse)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.temEpouse)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(172, 404)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(790, 141)
        Me.Panel2.TabIndex = 13
        '
        'TextBox6
        '
        Me.TextBox6.AutoSize = True
        Me.TextBox6.Location = New System.Drawing.Point(606, 50)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(10, 13)
        Me.TextBox6.TabIndex = 31
        Me.TextBox6.Text = "-"
        '
        'datman
        '
        Me.datman.Location = New System.Drawing.Point(407, 50)
        Me.datman.Name = "datman"
        Me.datman.Size = New System.Drawing.Size(164, 20)
        Me.datman.TabIndex = 30
        '
        'comm
        '
        Me.comm.Location = New System.Drawing.Point(407, 106)
        Me.comm.Margin = New System.Windows.Forms.Padding(2)
        Me.comm.Name = "comm"
        Me.comm.Size = New System.Drawing.Size(164, 20)
        Me.comm.TabIndex = 28
        '
        'off
        '
        Me.off.Location = New System.Drawing.Point(606, 106)
        Me.off.Margin = New System.Windows.Forms.Padding(2)
        Me.off.Name = "off"
        Me.off.Size = New System.Drawing.Size(172, 20)
        Me.off.TabIndex = 27
        '
        'temEpoux
        '
        Me.temEpoux.Location = New System.Drawing.Point(180, 50)
        Me.temEpoux.Margin = New System.Windows.Forms.Padding(2)
        Me.temEpoux.Name = "temEpoux"
        Me.temEpoux.Size = New System.Drawing.Size(186, 20)
        Me.temEpoux.TabIndex = 18
        '
        'npEpoux
        '
        Me.npEpoux.Location = New System.Drawing.Point(14, 50)
        Me.npEpoux.Margin = New System.Windows.Forms.Padding(2)
        Me.npEpoux.Name = "npEpoux"
        Me.npEpoux.Size = New System.Drawing.Size(127, 20)
        Me.npEpoux.TabIndex = 16
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(177, 26)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(193, 13)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Nom et prénoms  du témoin de l'époux :"
        '
        'npEpouse
        '
        Me.npEpouse.Location = New System.Drawing.Point(14, 106)
        Me.npEpouse.Margin = New System.Windows.Forms.Padding(2)
        Me.npEpouse.Name = "npEpouse"
        Me.npEpouse.Size = New System.Drawing.Size(127, 20)
        Me.npEpouse.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(177, 81)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(199, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Nom et prénoms  du témoin de l'épouse :"
        '
        'temEpouse
        '
        Me.temEpouse.Location = New System.Drawing.Point(180, 106)
        Me.temEpouse.Margin = New System.Windows.Forms.Padding(2)
        Me.temEpouse.Name = "temEpouse"
        Me.temEpouse.Size = New System.Drawing.Size(186, 20)
        Me.temEpouse.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(404, 81)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Commune de mariage :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(604, 26)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Numéro de référence :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(604, 81)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Nom et prénom de l'officier célébrant :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(404, 26)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Date de mariage :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 81)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Nom et prénons de l'épouse :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 26)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nom et prénons de l'époux :"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(757, 372)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(115, 19)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Charger pour modifier"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(886, 372)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(76, 19)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "Supprimer"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(881, 557)
        Me.Button7.Margin = New System.Windows.Forms.Padding(2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(80, 19)
        Me.Button7.TabIndex = 16
        Me.Button7.Text = "Modifier"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'mariage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 585)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.Label3)
        Me.Name = "mariage"
        Me.Text = "mariage"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnNaissance As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents temEpoux As TextBox
    Friend WithEvents npEpoux As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents npEpouse As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents temEpouse As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents comm As TextBox
    Friend WithEvents off As TextBox
    Friend WithEvents datman As DateTimePicker
    Friend WithEvents NomEpoux As DataGridViewTextBoxColumn
    Friend WithEvents NomEpouse As DataGridViewTextBoxColumn
    Friend WithEvents datema As DataGridViewTextBoxColumn
    Friend WithEvents nomCom As DataGridViewTextBoxColumn
    Friend WithEvents NomTemEpoux As DataGridViewTextBoxColumn
    Friend WithEvents NomTemEpouse As DataGridViewTextBoxColumn
    Friend WithEvents NomOfficier As DataGridViewTextBoxColumn
    Friend WithEvents Columnn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox6 As Label
End Class
