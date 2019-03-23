<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formListOrder
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formListOrder))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Kol_Nota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_Pelanggan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_Terima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_Berat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_Jenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_Progress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_Ambil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.kol_Hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btncari = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.editCari = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDelTable = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuBar = New System.Windows.Forms.MenuStrip()
        Me.PelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LayananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiskonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kol_Nota, Me.kol_Pelanggan, Me.kol_Terima, Me.kol_Berat, Me.kol_Jenis, Me.kol_Harga, Me.kol_Progress, Me.kol_Status, Me.kol_Ambil, Me.kol_Edit, Me.kol_Hapus})
        Me.DataGridView1.Location = New System.Drawing.Point(25, 188)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1031, 329)
        Me.DataGridView1.TabIndex = 1
        '
        'Kol_Nota
        '
        Me.Kol_Nota.DataPropertyName = "nota"
        Me.Kol_Nota.HeaderText = "Nota"
        Me.Kol_Nota.Name = "Kol_Nota"
        Me.Kol_Nota.ReadOnly = True
        Me.Kol_Nota.Width = 50
        '
        'kol_Pelanggan
        '
        Me.kol_Pelanggan.DataPropertyName = "nama_customer"
        Me.kol_Pelanggan.HeaderText = "Nama Pelanggan"
        Me.kol_Pelanggan.Name = "kol_Pelanggan"
        Me.kol_Pelanggan.ReadOnly = True
        Me.kol_Pelanggan.Width = 200
        '
        'kol_Terima
        '
        Me.kol_Terima.DataPropertyName = "tgl_terima"
        Me.kol_Terima.HeaderText = "Tanggal Terima"
        Me.kol_Terima.Name = "kol_Terima"
        Me.kol_Terima.ReadOnly = True
        Me.kol_Terima.Width = 80
        '
        'kol_Berat
        '
        Me.kol_Berat.DataPropertyName = "berat"
        Me.kol_Berat.HeaderText = "Berat"
        Me.kol_Berat.Name = "kol_Berat"
        Me.kol_Berat.ReadOnly = True
        Me.kol_Berat.Width = 50
        '
        'kol_Jenis
        '
        Me.kol_Jenis.DataPropertyName = "jenis_layanan"
        Me.kol_Jenis.HeaderText = "Jenis Layanan"
        Me.kol_Jenis.Name = "kol_Jenis"
        Me.kol_Jenis.ReadOnly = True
        '
        'kol_Harga
        '
        Me.kol_Harga.DataPropertyName = "harga"
        Me.kol_Harga.HeaderText = "Harga"
        Me.kol_Harga.Name = "kol_Harga"
        Me.kol_Harga.ReadOnly = True
        '
        'kol_Progress
        '
        Me.kol_Progress.DataPropertyName = "progress"
        Me.kol_Progress.HeaderText = "Progress"
        Me.kol_Progress.Name = "kol_Progress"
        Me.kol_Progress.ReadOnly = True
        '
        'kol_Status
        '
        Me.kol_Status.DataPropertyName = "status"
        Me.kol_Status.HeaderText = "Status"
        Me.kol_Status.Name = "kol_Status"
        Me.kol_Status.ReadOnly = True
        Me.kol_Status.Width = 120
        '
        'kol_Ambil
        '
        Me.kol_Ambil.DataPropertyName = "tgl_diambil"
        Me.kol_Ambil.HeaderText = "Tgl Diambil"
        Me.kol_Ambil.Name = "kol_Ambil"
        Me.kol_Ambil.ReadOnly = True
        Me.kol_Ambil.Width = 80
        '
        'kol_Edit
        '
        Me.kol_Edit.DataPropertyName = "nota"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.NullValue = "Edit"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.kol_Edit.DefaultCellStyle = DataGridViewCellStyle1
        Me.kol_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.kol_Edit.HeaderText = ""
        Me.kol_Edit.Name = "kol_Edit"
        Me.kol_Edit.ReadOnly = True
        Me.kol_Edit.Text = "Edit"
        Me.kol_Edit.UseColumnTextForButtonValue = True
        Me.kol_Edit.Width = 40
        '
        'kol_Hapus
        '
        Me.kol_Hapus.DataPropertyName = "nota"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Firebrick
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.NullValue = "Delete"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.kol_Hapus.DefaultCellStyle = DataGridViewCellStyle2
        Me.kol_Hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.kol_Hapus.HeaderText = ""
        Me.kol_Hapus.Name = "kol_Hapus"
        Me.kol_Hapus.ReadOnly = True
        Me.kol_Hapus.Text = "Delete"
        Me.kol_Hapus.UseColumnTextForButtonValue = True
        Me.kol_Hapus.Width = 50
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
        Me.btntambah.Location = New System.Drawing.Point(25, 140)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(104, 42)
        Me.btntambah.TabIndex = 0
        Me.btntambah.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'btncari
        '
        Me.btncari.BackColor = System.Drawing.Color.Transparent
        Me.btncari.BackgroundImage = CType(resources.GetObject("btncari.BackgroundImage"), System.Drawing.Image)
        Me.btncari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btncari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncari.FlatAppearance.BorderSize = 0
        Me.btncari.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple
        Me.btncari.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid
        Me.btncari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncari.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncari.Location = New System.Drawing.Point(949, 141)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(107, 42)
        Me.btncari.TabIndex = 3
        Me.btncari.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btncari.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(697, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 24)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Nota :"
        '
        'editCari
        '
        Me.editCari.Location = New System.Drawing.Point(793, 154)
        Me.editCari.Name = "editCari"
        Me.editCari.Size = New System.Drawing.Size(150, 20)
        Me.editCari.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(25, 58)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1031, 78)
        Me.Panel3.TabIndex = 97
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Std Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(124, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 38)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "List Order"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'btnDelTable
        '
        Me.btnDelTable.BackColor = System.Drawing.Color.Transparent
        Me.btnDelTable.BackgroundImage = CType(resources.GetObject("btnDelTable.BackgroundImage"), System.Drawing.Image)
        Me.btnDelTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDelTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelTable.FlatAppearance.BorderSize = 0
        Me.btnDelTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnDelTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnDelTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelTable.Location = New System.Drawing.Point(230, 141)
        Me.btnDelTable.Name = "btnDelTable"
        Me.btnDelTable.Size = New System.Drawing.Size(98, 41)
        Me.btnDelTable.TabIndex = 98
        Me.btnDelTable.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(446, 149)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 99
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(578, 150)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 100
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MenuBar
        '
        Me.MenuBar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuBar.Font = New System.Drawing.Font("Comic Sans MS", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PelangganToolStripMenuItem, Me.LayananToolStripMenuItem, Me.DiskonToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuBar.Size = New System.Drawing.Size(1080, 33)
        Me.MenuBar.Stretch = False
        Me.MenuBar.TabIndex = 101
        Me.MenuBar.Text = "MenuStrip1"
        '
        'PelangganToolStripMenuItem
        '
        Me.PelangganToolStripMenuItem.Name = "PelangganToolStripMenuItem"
        Me.PelangganToolStripMenuItem.Size = New System.Drawing.Size(107, 29)
        Me.PelangganToolStripMenuItem.Text = "Pelanggan"
        '
        'LayananToolStripMenuItem
        '
        Me.LayananToolStripMenuItem.Name = "LayananToolStripMenuItem"
        Me.LayananToolStripMenuItem.Size = New System.Drawing.Size(145, 29)
        Me.LayananToolStripMenuItem.Text = "Jesin Layanan"
        '
        'DiskonToolStripMenuItem
        '
        Me.DiskonToolStripMenuItem.Name = "DiskonToolStripMenuItem"
        Me.DiskonToolStripMenuItem.Size = New System.Drawing.Size(79, 29)
        Me.DiskonToolStripMenuItem.Text = "Diskon"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(95, 29)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'formListOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaundyProject.My.Resources.Resources.th001X0WEA
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1080, 496)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDelTable)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.editCari)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuBar)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MainMenuStrip = Me.MenuBar
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1096, 535)
        Me.MinimumSize = New System.Drawing.Size(1096, 535)
        Me.Name = "formListOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List Order"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents editCari As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Kol_Nota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_Pelanggan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_Terima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_Berat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_Jenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_Harga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_Progress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_Ambil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_Edit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents kol_Hapus As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnDelTable As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MenuBar As System.Windows.Forms.MenuStrip
    Friend WithEvents PelangganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LayananToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiskonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
