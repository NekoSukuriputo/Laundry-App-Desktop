<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPelanggan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPelanggan))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGVPelanggan = New System.Windows.Forms.DataGridView()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.colIDPlgn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_Pelanggan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_Terima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_nohp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.kol_Hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DGVPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVPelanggan
        '
        Me.DGVPelanggan.AllowUserToAddRows = False
        Me.DGVPelanggan.AllowUserToDeleteRows = False
        Me.DGVPelanggan.AllowUserToResizeColumns = False
        Me.DGVPelanggan.AllowUserToResizeRows = False
        Me.DGVPelanggan.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGVPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPelanggan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIDPlgn, Me.kol_Pelanggan, Me.kol_Terima, Me.kol_nohp, Me.kol_Edit, Me.kol_Hapus})
        Me.DGVPelanggan.Location = New System.Drawing.Point(31, 148)
        Me.DGVPelanggan.Name = "DGVPelanggan"
        Me.DGVPelanggan.ReadOnly = True
        Me.DGVPelanggan.Size = New System.Drawing.Size(954, 273)
        Me.DGVPelanggan.TabIndex = 2
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
        Me.btntambah.Location = New System.Drawing.Point(31, 78)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(104, 42)
        Me.btntambah.TabIndex = 3
        Me.btntambah.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'colIDPlgn
        '
        Me.colIDPlgn.DataPropertyName = "id"
        Me.colIDPlgn.HeaderText = "ID"
        Me.colIDPlgn.Name = "colIDPlgn"
        Me.colIDPlgn.ReadOnly = True
        Me.colIDPlgn.Width = 50
        '
        'kol_Pelanggan
        '
        Me.kol_Pelanggan.DataPropertyName = "nama_pelanggan"
        Me.kol_Pelanggan.HeaderText = "Nama Pelanggan"
        Me.kol_Pelanggan.Name = "kol_Pelanggan"
        Me.kol_Pelanggan.ReadOnly = True
        Me.kol_Pelanggan.Width = 200
        '
        'kol_Terima
        '
        Me.kol_Terima.DataPropertyName = "alamat"
        Me.kol_Terima.HeaderText = "Alamat"
        Me.kol_Terima.Name = "kol_Terima"
        Me.kol_Terima.ReadOnly = True
        Me.kol_Terima.Width = 400
        '
        'kol_nohp
        '
        Me.kol_nohp.DataPropertyName = "nohp"
        Me.kol_nohp.HeaderText = "No. HP"
        Me.kol_nohp.Name = "kol_nohp"
        Me.kol_nohp.ReadOnly = True
        Me.kol_nohp.Width = 170
        '
        'kol_Edit
        '
        Me.kol_Edit.DataPropertyName = "id"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.NullValue = "Edit"
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.kol_Edit.DefaultCellStyle = DataGridViewCellStyle5
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
        Me.kol_Hapus.DataPropertyName = "id"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Firebrick
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.NullValue = "Delete"
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Brown
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.kol_Hapus.DefaultCellStyle = DataGridViewCellStyle6
        Me.kol_Hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.kol_Hapus.HeaderText = ""
        Me.kol_Hapus.Name = "kol_Hapus"
        Me.kol_Hapus.ReadOnly = True
        Me.kol_Hapus.Text = "Delete"
        Me.kol_Hapus.UseColumnTextForButtonValue = True
        Me.kol_Hapus.Width = 50
        '
        'FormPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 489)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.DGVPelanggan)
        Me.Name = "FormPelanggan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form Pelanggan"
        CType(Me.DGVPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVPelanggan As System.Windows.Forms.DataGridView
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents colIDPlgn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_Pelanggan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_Terima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_nohp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_Edit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents kol_Hapus As System.Windows.Forms.DataGridViewButtonColumn
End Class
