<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formUpdateOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formUpdateOrder))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.groupStatus = New System.Windows.Forms.GroupBox()
        Me.rbSudahBayar = New System.Windows.Forms.RadioButton()
        Me.rbBelumBayar = New System.Windows.Forms.RadioButton()
        Me.groupProgress = New System.Windows.Forms.GroupBox()
        Me.rbJemur = New System.Windows.Forms.RadioButton()
        Me.rbTerima = New System.Windows.Forms.RadioButton()
        Me.rbCuci = New System.Windows.Forms.RadioButton()
        Me.rbSetrika = New System.Windows.Forms.RadioButton()
        Me.rbSelesai = New System.Windows.Forms.RadioButton()
        Me.rbAmbil = New System.Windows.Forms.RadioButton()
        Me.groupLayanan = New System.Windows.Forms.GroupBox()
        Me.rbStandart = New System.Windows.Forms.RadioButton()
        Me.rbExpress = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTerima = New System.Windows.Forms.Label()
        Me.txtCostumer = New System.Windows.Forms.Label()
        Me.tglTerima = New System.Windows.Forms.DateTimePicker()
        Me.editHarga = New System.Windows.Forms.TextBox()
        Me.editBerat = New System.Windows.Forms.TextBox()
        Me.editNama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tglAmbil = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.editItem = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.gridItem = New System.Windows.Forms.DataGridView()
        Me.nama_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kolEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.editJumlah = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNota = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupStatus.SuspendLayout()
        Me.groupProgress.SuspendLayout()
        Me.groupLayanan.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.BackgroundImage = CType(resources.GetObject("btnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Location = New System.Drawing.Point(124, 403)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(89, 31)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'groupStatus
        '
        Me.groupStatus.Controls.Add(Me.rbSudahBayar)
        Me.groupStatus.Controls.Add(Me.rbBelumBayar)
        Me.groupStatus.Location = New System.Drawing.Point(124, 312)
        Me.groupStatus.Name = "groupStatus"
        Me.groupStatus.Size = New System.Drawing.Size(522, 34)
        Me.groupStatus.TabIndex = 41
        Me.groupStatus.TabStop = False
        '
        'rbSudahBayar
        '
        Me.rbSudahBayar.AutoSize = True
        Me.rbSudahBayar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbSudahBayar.Location = New System.Drawing.Point(123, 11)
        Me.rbSudahBayar.Name = "rbSudahBayar"
        Me.rbSudahBayar.Size = New System.Drawing.Size(95, 17)
        Me.rbSudahBayar.TabIndex = 13
        Me.rbSudahBayar.Text = "Sudah Dibayar"
        Me.rbSudahBayar.UseVisualStyleBackColor = True
        '
        'rbBelumBayar
        '
        Me.rbBelumBayar.AutoSize = True
        Me.rbBelumBayar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbBelumBayar.Location = New System.Drawing.Point(21, 11)
        Me.rbBelumBayar.Name = "rbBelumBayar"
        Me.rbBelumBayar.Size = New System.Drawing.Size(93, 17)
        Me.rbBelumBayar.TabIndex = 12
        Me.rbBelumBayar.Text = "Belum Dibayar"
        Me.rbBelumBayar.UseVisualStyleBackColor = True
        '
        'groupProgress
        '
        Me.groupProgress.Controls.Add(Me.rbJemur)
        Me.groupProgress.Controls.Add(Me.rbTerima)
        Me.groupProgress.Controls.Add(Me.rbCuci)
        Me.groupProgress.Controls.Add(Me.rbSetrika)
        Me.groupProgress.Controls.Add(Me.rbSelesai)
        Me.groupProgress.Controls.Add(Me.rbAmbil)
        Me.groupProgress.Location = New System.Drawing.Point(124, 262)
        Me.groupProgress.Name = "groupProgress"
        Me.groupProgress.Size = New System.Drawing.Size(522, 37)
        Me.groupProgress.TabIndex = 40
        Me.groupProgress.TabStop = False
        '
        'rbJemur
        '
        Me.rbJemur.AutoSize = True
        Me.rbJemur.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbJemur.Location = New System.Drawing.Point(304, 12)
        Me.rbJemur.Name = "rbJemur"
        Me.rbJemur.Size = New System.Drawing.Size(60, 17)
        Me.rbJemur.TabIndex = 9
        Me.rbJemur.Text = "Dijemur"
        Me.rbJemur.UseVisualStyleBackColor = True
        '
        'rbTerima
        '
        Me.rbTerima.AutoSize = True
        Me.rbTerima.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbTerima.Location = New System.Drawing.Point(21, 11)
        Me.rbTerima.Name = "rbTerima"
        Me.rbTerima.Size = New System.Drawing.Size(63, 17)
        Me.rbTerima.TabIndex = 6
        Me.rbTerima.Text = "Diterima"
        Me.rbTerima.UseVisualStyleBackColor = True
        '
        'rbCuci
        '
        Me.rbCuci.AutoSize = True
        Me.rbCuci.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbCuci.Location = New System.Drawing.Point(123, 11)
        Me.rbCuci.Name = "rbCuci"
        Me.rbCuci.Size = New System.Drawing.Size(55, 17)
        Me.rbCuci.TabIndex = 7
        Me.rbCuci.Text = "Dicuci"
        Me.rbCuci.UseVisualStyleBackColor = True
        '
        'rbSetrika
        '
        Me.rbSetrika.AutoSize = True
        Me.rbSetrika.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbSetrika.Location = New System.Drawing.Point(224, 12)
        Me.rbSetrika.Name = "rbSetrika"
        Me.rbSetrika.Size = New System.Drawing.Size(66, 17)
        Me.rbSetrika.TabIndex = 8
        Me.rbSetrika.Text = "Disetrika"
        Me.rbSetrika.UseVisualStyleBackColor = True
        '
        'rbSelesai
        '
        Me.rbSelesai.AutoSize = True
        Me.rbSelesai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbSelesai.Location = New System.Drawing.Point(377, 12)
        Me.rbSelesai.Name = "rbSelesai"
        Me.rbSelesai.Size = New System.Drawing.Size(59, 17)
        Me.rbSelesai.TabIndex = 10
        Me.rbSelesai.Text = "Selesai"
        Me.rbSelesai.UseVisualStyleBackColor = True
        '
        'rbAmbil
        '
        Me.rbAmbil.AutoSize = True
        Me.rbAmbil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbAmbil.Location = New System.Drawing.Point(446, 12)
        Me.rbAmbil.Name = "rbAmbil"
        Me.rbAmbil.Size = New System.Drawing.Size(59, 17)
        Me.rbAmbil.TabIndex = 11
        Me.rbAmbil.Text = "Diambil"
        Me.rbAmbil.UseVisualStyleBackColor = True
        '
        'groupLayanan
        '
        Me.groupLayanan.Controls.Add(Me.rbStandart)
        Me.groupLayanan.Controls.Add(Me.rbExpress)
        Me.groupLayanan.Location = New System.Drawing.Point(124, 161)
        Me.groupLayanan.Name = "groupLayanan"
        Me.groupLayanan.Size = New System.Drawing.Size(522, 39)
        Me.groupLayanan.TabIndex = 39
        Me.groupLayanan.TabStop = False
        '
        'rbStandart
        '
        Me.rbStandart.AutoSize = True
        Me.rbStandart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbStandart.Location = New System.Drawing.Point(21, 12)
        Me.rbStandart.Name = "rbStandart"
        Me.rbStandart.Size = New System.Drawing.Size(68, 17)
        Me.rbStandart.TabIndex = 3
        Me.rbStandart.TabStop = True
        Me.rbStandart.Text = "Standard"
        Me.rbStandart.UseVisualStyleBackColor = True
        '
        'rbExpress
        '
        Me.rbExpress.AutoSize = True
        Me.rbExpress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbExpress.Location = New System.Drawing.Point(123, 12)
        Me.rbExpress.Name = "rbExpress"
        Me.rbExpress.Size = New System.Drawing.Size(62, 17)
        Me.rbExpress.TabIndex = 4
        Me.rbExpress.TabStop = True
        Me.rbExpress.Text = "Express"
        Me.rbExpress.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 327)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Progress"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Jenis Layanan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Berat (Kg)"
        '
        'txtTerima
        '
        Me.txtTerima.AutoSize = True
        Me.txtTerima.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerima.Location = New System.Drawing.Point(12, 80)
        Me.txtTerima.Name = "txtTerima"
        Me.txtTerima.Size = New System.Drawing.Size(95, 13)
        Me.txtTerima.TabIndex = 33
        Me.txtTerima.Text = "Tanggal Terima"
        '
        'txtCostumer
        '
        Me.txtCostumer.AutoSize = True
        Me.txtCostumer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostumer.Location = New System.Drawing.Point(12, 27)
        Me.txtCostumer.Name = "txtCostumer"
        Me.txtCostumer.Size = New System.Drawing.Size(95, 13)
        Me.txtCostumer.TabIndex = 32
        Me.txtCostumer.Text = "Nama Costumer"
        '
        'tglTerima
        '
        Me.tglTerima.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tglTerima.Location = New System.Drawing.Point(124, 77)
        Me.tglTerima.Name = "tglTerima"
        Me.tglTerima.Size = New System.Drawing.Size(178, 20)
        Me.tglTerima.TabIndex = 1
        '
        'editHarga
        '
        Me.editHarga.Location = New System.Drawing.Point(124, 223)
        Me.editHarga.Name = "editHarga"
        Me.editHarga.ReadOnly = True
        Me.editHarga.Size = New System.Drawing.Size(522, 20)
        Me.editHarga.TabIndex = 5
        '
        'editBerat
        '
        Me.editBerat.Location = New System.Drawing.Point(124, 129)
        Me.editBerat.Name = "editBerat"
        Me.editBerat.Size = New System.Drawing.Size(522, 20)
        Me.editBerat.TabIndex = 2
        '
        'editNama
        '
        Me.editNama.Location = New System.Drawing.Point(124, 24)
        Me.editNama.Name = "editNama"
        Me.editNama.Size = New System.Drawing.Size(522, 20)
        Me.editNama.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 367)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Tanggal Diambil"
        '
        'tglAmbil
        '
        Me.tglAmbil.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tglAmbil.Location = New System.Drawing.Point(124, 364)
        Me.tglAmbil.Name = "tglAmbil"
        Me.tglAmbil.Size = New System.Drawing.Size(178, 20)
        Me.tglAmbil.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Nama Item"
        '
        'editItem
        '
        Me.editItem.Location = New System.Drawing.Point(85, 22)
        Me.editItem.Name = "editItem"
        Me.editItem.Size = New System.Drawing.Size(204, 20)
        Me.editItem.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Linen
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnFinish)
        Me.Panel1.Controls.Add(Me.btnTambah)
        Me.Panel1.Controls.Add(Me.gridItem)
        Me.Panel1.Controls.Add(Me.editJumlah)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.editItem)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(702, 127)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(403, 457)
        Me.Panel1.TabIndex = 47
        '
        'btnFinish
        '
        Me.btnFinish.BackColor = System.Drawing.Color.Transparent
        Me.btnFinish.BackgroundImage = CType(resources.GetObject("btnFinish.BackgroundImage"), System.Drawing.Image)
        Me.btnFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinish.FlatAppearance.BorderSize = 0
        Me.btnFinish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnFinish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinish.Location = New System.Drawing.Point(269, 403)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(93, 31)
        Me.btnFinish.TabIndex = 19
        Me.btnFinish.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.Transparent
        Me.btnTambah.BackgroundImage = CType(resources.GetObject("btnTambah.BackgroundImage"), System.Drawing.Image)
        Me.btnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.btnTambah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Location = New System.Drawing.Point(309, 16)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(71, 63)
        Me.btnTambah.TabIndex = 18
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'gridItem
        '
        Me.gridItem.AllowUserToAddRows = False
        Me.gridItem.AllowUserToResizeRows = False
        Me.gridItem.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.gridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nama_item, Me.kol_Jumlah, Me.idItem, Me.kolEdit})
        Me.gridItem.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gridItem.Location = New System.Drawing.Point(17, 97)
        Me.gridItem.Name = "gridItem"
        Me.gridItem.ReadOnly = True
        Me.gridItem.Size = New System.Drawing.Size(365, 292)
        Me.gridItem.TabIndex = 49
        '
        'nama_item
        '
        Me.nama_item.DataPropertyName = "nama_item"
        Me.nama_item.HeaderText = "Nama Item"
        Me.nama_item.Name = "nama_item"
        Me.nama_item.ReadOnly = True
        Me.nama_item.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.nama_item.Width = 220
        '
        'kol_Jumlah
        '
        Me.kol_Jumlah.DataPropertyName = "jumlah"
        Me.kol_Jumlah.HeaderText = "Jumlah"
        Me.kol_Jumlah.Name = "kol_Jumlah"
        Me.kol_Jumlah.ReadOnly = True
        Me.kol_Jumlah.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.kol_Jumlah.Width = 50
        '
        'idItem
        '
        Me.idItem.DataPropertyName = "id"
        Me.idItem.HeaderText = "id"
        Me.idItem.Name = "idItem"
        Me.idItem.ReadOnly = True
        Me.idItem.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.idItem.Visible = False
        '
        'kolEdit
        '
        Me.kolEdit.DataPropertyName = "id"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.NullValue = "Delete"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.kolEdit.DefaultCellStyle = DataGridViewCellStyle1
        Me.kolEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.kolEdit.HeaderText = "Aksi"
        Me.kolEdit.Name = "kolEdit"
        Me.kolEdit.ReadOnly = True
        Me.kolEdit.Text = "Delete"
        Me.kolEdit.UseColumnTextForButtonValue = True
        Me.kolEdit.Width = 50
        '
        'editJumlah
        '
        Me.editJumlah.Location = New System.Drawing.Point(85, 57)
        Me.editJumlah.Name = "editJumlah"
        Me.editJumlah.Size = New System.Drawing.Size(204, 20)
        Me.editJumlah.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Jumlah"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(36, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 31)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Nota"
        '
        'txtNota
        '
        Me.txtNota.AutoSize = True
        Me.txtNota.BackColor = System.Drawing.Color.Transparent
        Me.txtNota.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNota.Location = New System.Drawing.Point(115, 94)
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(63, 30)
        Me.txtNota.TabIndex = 49
        Me.txtNota.Text = "Nota"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.editNama)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.editBerat)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.editHarga)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.tglTerima)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.tglAmbil)
        Me.Panel2.Controls.Add(Me.txtCostumer)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.txtTerima)
        Me.Panel2.Controls.Add(Me.groupStatus)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.groupProgress)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.groupLayanan)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel2.Location = New System.Drawing.Point(23, 127)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(663, 457)
        Me.Panel2.TabIndex = 50
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(108, 365)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(12, 14)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(108, 131)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(12, 14)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(108, 326)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(12, 14)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(108, 273)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(12, 14)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(108, 225)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 14)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(108, 175)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(12, 14)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(108, 79)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(12, 14)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(108, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(12, 14)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = ":"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(23, 13)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1082, 78)
        Me.Panel3.TabIndex = 51
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Cooper Std Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(156, 21)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(254, 38)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "Update Order"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 77)
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'formUpdateOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaundyProject.My.Resources.Resources.th001X0WEA
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1123, 606)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximumSize = New System.Drawing.Size(1133, 639)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1133, 639)
        Me.Name = "formUpdateOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Order"
        Me.groupStatus.ResumeLayout(False)
        Me.groupStatus.PerformLayout()
        Me.groupProgress.ResumeLayout(False)
        Me.groupProgress.PerformLayout()
        Me.groupLayanan.ResumeLayout(False)
        Me.groupLayanan.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents groupStatus As System.Windows.Forms.GroupBox
    Friend WithEvents rbSudahBayar As System.Windows.Forms.RadioButton
    Friend WithEvents rbBelumBayar As System.Windows.Forms.RadioButton
    Friend WithEvents groupProgress As System.Windows.Forms.GroupBox
    Friend WithEvents rbJemur As System.Windows.Forms.RadioButton
    Friend WithEvents rbTerima As System.Windows.Forms.RadioButton
    Friend WithEvents rbCuci As System.Windows.Forms.RadioButton
    Friend WithEvents rbSetrika As System.Windows.Forms.RadioButton
    Friend WithEvents rbSelesai As System.Windows.Forms.RadioButton
    Friend WithEvents rbAmbil As System.Windows.Forms.RadioButton
    Friend WithEvents groupLayanan As System.Windows.Forms.GroupBox
    Friend WithEvents rbStandart As System.Windows.Forms.RadioButton
    Friend WithEvents rbExpress As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTerima As System.Windows.Forms.Label
    Friend WithEvents txtCostumer As System.Windows.Forms.Label
    Friend WithEvents tglTerima As System.Windows.Forms.DateTimePicker
    Friend WithEvents editHarga As System.Windows.Forms.TextBox
    Friend WithEvents editBerat As System.Windows.Forms.TextBox
    Friend WithEvents editNama As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tglAmbil As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents editItem As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnFinish As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents gridItem As System.Windows.Forms.DataGridView
    Friend WithEvents editJumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNota As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents nama_item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_Jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kolEdit As System.Windows.Forms.DataGridViewButtonColumn
End Class
