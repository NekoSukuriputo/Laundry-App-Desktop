<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formOrder))
        Me.editNama = New System.Windows.Forms.TextBox()
        Me.tglTerima = New System.Windows.Forms.DateTimePicker()
        Me.rbCuci = New System.Windows.Forms.RadioButton()
        Me.rbTerima = New System.Windows.Forms.RadioButton()
        Me.rbJemur = New System.Windows.Forms.RadioButton()
        Me.rbSetrika = New System.Windows.Forms.RadioButton()
        Me.rbAmbil = New System.Windows.Forms.RadioButton()
        Me.rbSelesai = New System.Windows.Forms.RadioButton()
        Me.rbSudahBayar = New System.Windows.Forms.RadioButton()
        Me.rbBelumBayar = New System.Windows.Forms.RadioButton()
        Me.txtCostumer = New System.Windows.Forms.Label()
        Me.txtTerima = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.groupLayanan = New System.Windows.Forms.GroupBox()
        Me.cmbJenisLayanan = New System.Windows.Forms.ComboBox()
        Me.groupProgress = New System.Windows.Forms.GroupBox()
        Me.groupStatus = New System.Windows.Forms.GroupBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtHarga = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtBerat = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbNonMember = New System.Windows.Forms.RadioButton()
        Me.rbMember = New System.Windows.Forms.RadioButton()
        Me.groupLayanan.SuspendLayout()
        Me.groupProgress.SuspendLayout()
        Me.groupStatus.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'editNama
        '
        Me.editNama.Location = New System.Drawing.Point(17, 11)
        Me.editNama.Name = "editNama"
        Me.editNama.Size = New System.Drawing.Size(241, 20)
        Me.editNama.TabIndex = 0
        '
        'tglTerima
        '
        Me.tglTerima.CustomFormat = "MM/dd/yyyy"
        Me.tglTerima.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglTerima.Location = New System.Drawing.Point(15, 13)
        Me.tglTerima.Name = "tglTerima"
        Me.tglTerima.Size = New System.Drawing.Size(196, 20)
        Me.tglTerima.TabIndex = 1
        '
        'rbCuci
        '
        Me.rbCuci.AutoSize = True
        Me.rbCuci.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbCuci.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCuci.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbCuci.Location = New System.Drawing.Point(114, 11)
        Me.rbCuci.Name = "rbCuci"
        Me.rbCuci.Size = New System.Drawing.Size(61, 17)
        Me.rbCuci.TabIndex = 7
        Me.rbCuci.Text = "Dicuci"
        Me.rbCuci.UseVisualStyleBackColor = True
        '
        'rbTerima
        '
        Me.rbTerima.AutoSize = True
        Me.rbTerima.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbTerima.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTerima.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbTerima.Location = New System.Drawing.Point(21, 11)
        Me.rbTerima.Name = "rbTerima"
        Me.rbTerima.Size = New System.Drawing.Size(71, 17)
        Me.rbTerima.TabIndex = 6
        Me.rbTerima.Text = "Diterima"
        Me.rbTerima.UseVisualStyleBackColor = True
        '
        'rbJemur
        '
        Me.rbJemur.AutoSize = True
        Me.rbJemur.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbJemur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbJemur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbJemur.Location = New System.Drawing.Point(311, 11)
        Me.rbJemur.Name = "rbJemur"
        Me.rbJemur.Size = New System.Drawing.Size(67, 17)
        Me.rbJemur.TabIndex = 9
        Me.rbJemur.Text = "Dijemur"
        Me.rbJemur.UseVisualStyleBackColor = True
        '
        'rbSetrika
        '
        Me.rbSetrika.AutoSize = True
        Me.rbSetrika.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbSetrika.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSetrika.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbSetrika.Location = New System.Drawing.Point(205, 11)
        Me.rbSetrika.Name = "rbSetrika"
        Me.rbSetrika.Size = New System.Drawing.Size(75, 17)
        Me.rbSetrika.TabIndex = 8
        Me.rbSetrika.Text = "Disetrika"
        Me.rbSetrika.UseVisualStyleBackColor = True
        '
        'rbAmbil
        '
        Me.rbAmbil.AutoSize = True
        Me.rbAmbil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbAmbil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAmbil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbAmbil.Location = New System.Drawing.Point(503, 11)
        Me.rbAmbil.Name = "rbAmbil"
        Me.rbAmbil.Size = New System.Drawing.Size(66, 17)
        Me.rbAmbil.TabIndex = 11
        Me.rbAmbil.Text = "Diambil"
        Me.rbAmbil.UseVisualStyleBackColor = True
        '
        'rbSelesai
        '
        Me.rbSelesai.AutoSize = True
        Me.rbSelesai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbSelesai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSelesai.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbSelesai.Location = New System.Drawing.Point(406, 11)
        Me.rbSelesai.Name = "rbSelesai"
        Me.rbSelesai.Size = New System.Drawing.Size(66, 17)
        Me.rbSelesai.TabIndex = 10
        Me.rbSelesai.Text = "Selesai"
        Me.rbSelesai.UseVisualStyleBackColor = True
        '
        'rbSudahBayar
        '
        Me.rbSudahBayar.AutoSize = True
        Me.rbSudahBayar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbSudahBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSudahBayar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbSudahBayar.Location = New System.Drawing.Point(131, 11)
        Me.rbSudahBayar.Name = "rbSudahBayar"
        Me.rbSudahBayar.Size = New System.Drawing.Size(108, 17)
        Me.rbSudahBayar.TabIndex = 13
        Me.rbSudahBayar.Text = "Sudah Dibayar"
        Me.rbSudahBayar.UseVisualStyleBackColor = True
        '
        'rbBelumBayar
        '
        Me.rbBelumBayar.AutoSize = True
        Me.rbBelumBayar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbBelumBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBelumBayar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbBelumBayar.Location = New System.Drawing.Point(19, 11)
        Me.rbBelumBayar.Name = "rbBelumBayar"
        Me.rbBelumBayar.Size = New System.Drawing.Size(106, 17)
        Me.rbBelumBayar.TabIndex = 12
        Me.rbBelumBayar.Text = "Belum Dibayar"
        Me.rbBelumBayar.UseVisualStyleBackColor = True
        '
        'txtCostumer
        '
        Me.txtCostumer.AutoSize = True
        Me.txtCostumer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostumer.Location = New System.Drawing.Point(23, 199)
        Me.txtCostumer.Name = "txtCostumer"
        Me.txtCostumer.Size = New System.Drawing.Size(110, 15)
        Me.txtCostumer.TabIndex = 23
        Me.txtCostumer.Text = "Nama Costumer"
        '
        'txtTerima
        '
        Me.txtTerima.AutoSize = True
        Me.txtTerima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerima.Location = New System.Drawing.Point(22, 261)
        Me.txtTerima.Name = "txtTerima"
        Me.txtTerima.Size = New System.Drawing.Size(108, 15)
        Me.txtTerima.TabIndex = 22
        Me.txtTerima.Text = "Tanggal Terima"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Berat (Kg)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 318)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Jenis Layanan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(341, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 379)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 15)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Progress"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 434)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 15)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Status"
        '
        'groupLayanan
        '
        Me.groupLayanan.Controls.Add(Me.cmbJenisLayanan)
        Me.groupLayanan.Location = New System.Drawing.Point(152, 303)
        Me.groupLayanan.Name = "groupLayanan"
        Me.groupLayanan.Size = New System.Drawing.Size(591, 43)
        Me.groupLayanan.TabIndex = 24
        Me.groupLayanan.TabStop = False
        '
        'cmbJenisLayanan
        '
        Me.cmbJenisLayanan.FormattingEnabled = True
        Me.cmbJenisLayanan.Location = New System.Drawing.Point(15, 14)
        Me.cmbJenisLayanan.Name = "cmbJenisLayanan"
        Me.cmbJenisLayanan.Size = New System.Drawing.Size(170, 21)
        Me.cmbJenisLayanan.TabIndex = 0
        '
        'groupProgress
        '
        Me.groupProgress.Controls.Add(Me.rbJemur)
        Me.groupProgress.Controls.Add(Me.rbTerima)
        Me.groupProgress.Controls.Add(Me.rbCuci)
        Me.groupProgress.Controls.Add(Me.rbSetrika)
        Me.groupProgress.Controls.Add(Me.rbSelesai)
        Me.groupProgress.Controls.Add(Me.rbAmbil)
        Me.groupProgress.Location = New System.Drawing.Point(152, 366)
        Me.groupProgress.Name = "groupProgress"
        Me.groupProgress.Size = New System.Drawing.Size(591, 37)
        Me.groupProgress.TabIndex = 25
        Me.groupProgress.TabStop = False
        '
        'groupStatus
        '
        Me.groupStatus.Controls.Add(Me.rbSudahBayar)
        Me.groupStatus.Controls.Add(Me.rbBelumBayar)
        Me.groupStatus.Location = New System.Drawing.Point(152, 423)
        Me.groupStatus.Name = "groupStatus"
        Me.groupStatus.Size = New System.Drawing.Size(591, 34)
        Me.groupStatus.TabIndex = 26
        Me.groupStatus.TabStop = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.Transparent
        Me.btnTambah.BackgroundImage = CType(resources.GetObject("btnTambah.BackgroundImage"), System.Drawing.Image)
        Me.btnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTambah.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTambah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Location = New System.Drawing.Point(152, 476)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(108, 39)
        Me.btnTambah.TabIndex = 14
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(139, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 37)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Create Order"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(136, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 14)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(135, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 14)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(135, 318)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(12, 14)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(135, 377)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(12, 14)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(135, 435)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(12, 14)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = ":"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(26, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(889, 71)
        Me.Panel1.TabIndex = 36
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 76)
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txtCostumer)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtTerima)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.btnTambah)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.groupStatus)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.groupProgress)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.groupLayanan)
        Me.Panel2.Location = New System.Drawing.Point(26, 106)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(889, 571)
        Me.Panel2.TabIndex = 37
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tglTerima)
        Me.GroupBox3.Location = New System.Drawing.Point(152, 242)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(591, 39)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.editNama)
        Me.GroupBox2.Location = New System.Drawing.Point(152, 181)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(591, 39)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(281, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 25)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Kg"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightBlue
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.txtHarga)
        Me.Panel4.Location = New System.Drawing.Point(403, 23)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(298, 58)
        Me.Panel4.TabIndex = 38
        '
        'txtHarga
        '
        Me.txtHarga.AutoSize = True
        Me.txtHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga.Location = New System.Drawing.Point(14, 7)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(147, 39)
        Me.txtHarga.TabIndex = 0
        Me.txtHarga.Text = "000.000"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txtBerat)
        Me.Panel3.Location = New System.Drawing.Point(129, 23)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(148, 58)
        Me.Panel3.TabIndex = 37
        '
        'txtBerat
        '
        Me.txtBerat.AutoSize = True
        Me.txtBerat.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBerat.Location = New System.Drawing.Point(32, 8)
        Me.txtBerat.Name = "txtBerat"
        Me.txtBerat.Size = New System.Drawing.Size(107, 39)
        Me.txtBerat.TabIndex = 0
        Me.txtBerat.Text = "0.000"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(283, 475)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 39)
        Me.Button1.TabIndex = 36
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(22, 138)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 15)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Jenis Costumer"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(135, 139)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(12, 14)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = ":"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbNonMember)
        Me.GroupBox1.Controls.Add(Me.rbMember)
        Me.GroupBox1.Location = New System.Drawing.Point(152, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(591, 39)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'rbNonMember
        '
        Me.rbNonMember.AutoSize = True
        Me.rbNonMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbNonMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNonMember.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbNonMember.Location = New System.Drawing.Point(14, 14)
        Me.rbNonMember.Name = "rbNonMember"
        Me.rbNonMember.Size = New System.Drawing.Size(96, 17)
        Me.rbNonMember.TabIndex = 6
        Me.rbNonMember.Text = "Non Member"
        Me.rbNonMember.UseVisualStyleBackColor = True
        '
        'rbMember
        '
        Me.rbMember.AutoSize = True
        Me.rbMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMember.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbMember.Location = New System.Drawing.Point(141, 14)
        Me.rbMember.Name = "rbMember"
        Me.rbMember.Size = New System.Drawing.Size(69, 17)
        Me.rbMember.TabIndex = 6
        Me.rbMember.Text = "Member"
        Me.rbMember.UseVisualStyleBackColor = True
        '
        'formOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.LaundyProject.My.Resources.Resources.th001X0WEA
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(945, 689)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(835, 584)
        Me.Name = "formOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Order"
        Me.groupLayanan.ResumeLayout(False)
        Me.groupProgress.ResumeLayout(False)
        Me.groupProgress.PerformLayout()
        Me.groupStatus.ResumeLayout(False)
        Me.groupStatus.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents editNama As System.Windows.Forms.TextBox
    Friend WithEvents tglTerima As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbCuci As System.Windows.Forms.RadioButton
    Friend WithEvents rbTerima As System.Windows.Forms.RadioButton
    Friend WithEvents rbJemur As System.Windows.Forms.RadioButton
    Friend WithEvents rbSetrika As System.Windows.Forms.RadioButton
    Friend WithEvents rbAmbil As System.Windows.Forms.RadioButton
    Friend WithEvents rbSelesai As System.Windows.Forms.RadioButton
    Friend WithEvents rbSudahBayar As System.Windows.Forms.RadioButton
    Friend WithEvents rbBelumBayar As System.Windows.Forms.RadioButton
    Friend WithEvents txtCostumer As System.Windows.Forms.Label
    Friend WithEvents txtTerima As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents groupLayanan As System.Windows.Forms.GroupBox
    Friend WithEvents groupProgress As System.Windows.Forms.GroupBox
    Friend WithEvents groupStatus As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtHarga As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBerat As System.Windows.Forms.Label
    Friend WithEvents cmbJenisLayanan As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNonMember As System.Windows.Forms.RadioButton
    Friend WithEvents rbMember As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

End Class
