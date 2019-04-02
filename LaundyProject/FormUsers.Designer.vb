<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUsers))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DGVUsers = New System.Windows.Forms.DataGridView()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.kol_layanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_Terima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_Del = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(0, -3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(599, 78)
        Me.Panel3.TabIndex = 102
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cooper Std Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(136, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 38)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Users"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 77)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'DGVUsers
        '
        Me.DGVUsers.AllowUserToAddRows = False
        Me.DGVUsers.AllowUserToDeleteRows = False
        Me.DGVUsers.AllowUserToResizeColumns = False
        Me.DGVUsers.AllowUserToResizeRows = False
        Me.DGVUsers.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kol_layanan, Me.kol_Terima, Me.kol_Del})
        Me.DGVUsers.Location = New System.Drawing.Point(37, 156)
        Me.DGVUsers.Name = "DGVUsers"
        Me.DGVUsers.ReadOnly = True
        Me.DGVUsers.Size = New System.Drawing.Size(337, 273)
        Me.DGVUsers.TabIndex = 103
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.Color.Transparent
        Me.btntambah.BackgroundImage = CType(resources.GetObject("btntambah.BackgroundImage"), System.Drawing.Image)
        Me.btntambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btntambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntambah.FlatAppearance.BorderSize = 0
        Me.btntambah.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btntambah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btntambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.Location = New System.Drawing.Point(37, 96)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(104, 42)
        Me.btntambah.TabIndex = 104
        Me.btntambah.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'kol_layanan
        '
        Me.kol_layanan.DataPropertyName = "username"
        Me.kol_layanan.FillWeight = 150.0!
        Me.kol_layanan.HeaderText = "Username"
        Me.kol_layanan.Name = "kol_layanan"
        Me.kol_layanan.ReadOnly = True
        Me.kol_layanan.Width = 150
        '
        'kol_Terima
        '
        Me.kol_Terima.DataPropertyName = "rule"
        Me.kol_Terima.HeaderText = "Rule"
        Me.kol_Terima.Name = "kol_Terima"
        Me.kol_Terima.ReadOnly = True
        '
        'kol_Del
        '
        Me.kol_Del.DataPropertyName = "username"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Firebrick
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.NullValue = "Edit"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.kol_Del.DefaultCellStyle = DataGridViewCellStyle2
        Me.kol_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.kol_Del.HeaderText = ""
        Me.kol_Del.Name = "kol_Del"
        Me.kol_Del.ReadOnly = True
        Me.kol_Del.Text = "Delete"
        Me.kol_Del.UseColumnTextForButtonValue = True
        Me.kol_Del.Width = 40
        '
        'FormUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaundyProject.My.Resources.Resources.th001X0WEA
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(411, 461)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.DGVUsers)
        Me.MaximizeBox = False
        Me.Name = "FormUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUsers"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents DGVUsers As System.Windows.Forms.DataGridView
    Friend WithEvents kol_layanan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_Terima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_Del As System.Windows.Forms.DataGridViewButtonColumn
End Class
