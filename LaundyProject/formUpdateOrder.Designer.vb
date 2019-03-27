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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNota = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.editBerat = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tglAmbil = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tglTerima = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.editNama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCostumer = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTerima = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.groupStatus = New System.Windows.Forms.GroupBox()
        Me.rbSudahBayar = New System.Windows.Forms.RadioButton()
        Me.rbBelumBayar = New System.Windows.Forms.RadioButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.groupProgress = New System.Windows.Forms.GroupBox()
        Me.rbJemur = New System.Windows.Forms.RadioButton()
        Me.rbTerima = New System.Windows.Forms.RadioButton()
        Me.rbCuci = New System.Windows.Forms.RadioButton()
        Me.rbSetrika = New System.Windows.Forms.RadioButton()
        Me.rbSelesai = New System.Windows.Forms.RadioButton()
        Me.rbAmbil = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbNonMember = New System.Windows.Forms.RadioButton()
        Me.rbMember = New System.Windows.Forms.RadioButton()
        Me.groupLayanan = New System.Windows.Forms.GroupBox()
        Me.cmbJenisLayanan = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAddItems = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.groupStatus.SuspendLayout()
        Me.groupProgress.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.groupLayanan.SuspendLayout()
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
        Me.btnUpdate.Location = New System.Drawing.Point(141, 460)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(89, 31)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(36, 102)
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
        Me.txtNota.Location = New System.Drawing.Point(115, 103)
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(63, 30)
        Me.txtNota.TabIndex = 49
        Me.txtNota.Text = "Nota"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtCostumer)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtTerima)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.groupStatus)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.groupProgress)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.groupLayanan)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel2.Location = New System.Drawing.Point(23, 144)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(743, 512)
        Me.Panel2.TabIndex = 50
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.editBerat)
        Me.GroupBox5.Location = New System.Drawing.Point(141, 241)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(591, 43)
        Me.GroupBox5.TabIndex = 68
        Me.GroupBox5.TabStop = False
        '
        'editBerat
        '
        Me.editBerat.Location = New System.Drawing.Point(17, 17)
        Me.editBerat.Name = "editBerat"
        Me.editBerat.Size = New System.Drawing.Size(168, 20)
        Me.editBerat.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tglAmbil)
        Me.GroupBox4.Location = New System.Drawing.Point(141, 395)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(591, 39)
        Me.GroupBox4.TabIndex = 72
        Me.GroupBox4.TabStop = False
        '
        'tglAmbil
        '
        Me.tglAmbil.CustomFormat = "MM/dd/yyyy"
        Me.tglAmbil.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglAmbil.Location = New System.Drawing.Point(17, 13)
        Me.tglAmbil.Name = "tglAmbil"
        Me.tglAmbil.Size = New System.Drawing.Size(178, 20)
        Me.tglAmbil.TabIndex = 14
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tglTerima)
        Me.GroupBox3.Location = New System.Drawing.Point(141, 127)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(591, 39)
        Me.GroupBox3.TabIndex = 71
        Me.GroupBox3.TabStop = False
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.editNama)
        Me.GroupBox2.Location = New System.Drawing.Point(141, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(591, 39)
        Me.GroupBox2.TabIndex = 68
        Me.GroupBox2.TabStop = False
        '
        'editNama
        '
        Me.editNama.Location = New System.Drawing.Point(17, 11)
        Me.editNama.Name = "editNama"
        Me.editNama.Size = New System.Drawing.Size(241, 20)
        Me.editNama.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 15)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Jenis Costumer"
        '
        'txtCostumer
        '
        Me.txtCostumer.AutoSize = True
        Me.txtCostumer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostumer.Location = New System.Drawing.Point(12, 84)
        Me.txtCostumer.Name = "txtCostumer"
        Me.txtCostumer.Size = New System.Drawing.Size(110, 15)
        Me.txtCostumer.TabIndex = 65
        Me.txtCostumer.Text = "Nama Costumer"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(124, 359)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(12, 14)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(124, 301)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(12, 14)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = ":"
        '
        'txtTerima
        '
        Me.txtTerima.AutoSize = True
        Me.txtTerima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerima.Location = New System.Drawing.Point(11, 146)
        Me.txtTerima.Name = "txtTerima"
        Me.txtTerima.Size = New System.Drawing.Size(108, 15)
        Me.txtTerima.TabIndex = 61
        Me.txtTerima.Text = "Tanggal Terima"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(124, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 14)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(124, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 14)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 15)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Jenis Layanan"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(124, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(12, 14)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(125, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 14)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(11, 303)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 15)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "Progress"
        '
        'groupStatus
        '
        Me.groupStatus.Controls.Add(Me.rbSudahBayar)
        Me.groupStatus.Controls.Add(Me.rbBelumBayar)
        Me.groupStatus.Location = New System.Drawing.Point(141, 347)
        Me.groupStatus.Name = "groupStatus"
        Me.groupStatus.Size = New System.Drawing.Size(591, 34)
        Me.groupStatus.TabIndex = 70
        Me.groupStatus.TabStop = False
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
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(11, 358)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 15)
        Me.Label16.TabIndex = 64
        Me.Label16.Text = "Status"
        '
        'groupProgress
        '
        Me.groupProgress.Controls.Add(Me.rbJemur)
        Me.groupProgress.Controls.Add(Me.rbTerima)
        Me.groupProgress.Controls.Add(Me.rbCuci)
        Me.groupProgress.Controls.Add(Me.rbSetrika)
        Me.groupProgress.Controls.Add(Me.rbSelesai)
        Me.groupProgress.Controls.Add(Me.rbAmbil)
        Me.groupProgress.Location = New System.Drawing.Point(141, 290)
        Me.groupProgress.Name = "groupProgress"
        Me.groupProgress.Size = New System.Drawing.Size(591, 37)
        Me.groupProgress.TabIndex = 69
        Me.groupProgress.TabStop = False
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbNonMember)
        Me.GroupBox1.Controls.Add(Me.rbMember)
        Me.GroupBox1.Location = New System.Drawing.Point(141, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(591, 39)
        Me.GroupBox1.TabIndex = 66
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
        'groupLayanan
        '
        Me.groupLayanan.Controls.Add(Me.cmbJenisLayanan)
        Me.groupLayanan.Location = New System.Drawing.Point(141, 188)
        Me.groupLayanan.Name = "groupLayanan"
        Me.groupLayanan.Size = New System.Drawing.Size(591, 43)
        Me.groupLayanan.TabIndex = 67
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
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(108, 404)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(12, 14)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(123, 258)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(12, 14)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 406)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Tanggal Diambil"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Berat (Kg)"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(23, 13)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(939, 78)
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
        'btnAddItems
        '
        Me.btnAddItems.BackColor = System.Drawing.Color.Transparent
        Me.btnAddItems.BackgroundImage = CType(resources.GetObject("btnAddItems.BackgroundImage"), System.Drawing.Image)
        Me.btnAddItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddItems.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddItems.FlatAppearance.BorderSize = 0
        Me.btnAddItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItems.Location = New System.Drawing.Point(648, 93)
        Me.btnAddItems.Name = "btnAddItems"
        Me.btnAddItems.Size = New System.Drawing.Size(108, 45)
        Me.btnAddItems.TabIndex = 52
        Me.btnAddItems.UseVisualStyleBackColor = False
        '
        'formUpdateOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaundyProject.My.Resources.Resources.th001X0WEA
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(787, 668)
        Me.Controls.Add(Me.btnAddItems)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MinimizeBox = False
        Me.Name = "formUpdateOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Order"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.groupStatus.ResumeLayout(False)
        Me.groupStatus.PerformLayout()
        Me.groupProgress.ResumeLayout(False)
        Me.groupProgress.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.groupLayanan.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNota As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tglAmbil As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents editBerat As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tglTerima As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents editNama As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCostumer As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTerima As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents groupStatus As System.Windows.Forms.GroupBox
    Friend WithEvents rbSudahBayar As System.Windows.Forms.RadioButton
    Friend WithEvents rbBelumBayar As System.Windows.Forms.RadioButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents groupProgress As System.Windows.Forms.GroupBox
    Friend WithEvents rbJemur As System.Windows.Forms.RadioButton
    Friend WithEvents rbTerima As System.Windows.Forms.RadioButton
    Friend WithEvents rbCuci As System.Windows.Forms.RadioButton
    Friend WithEvents rbSetrika As System.Windows.Forms.RadioButton
    Friend WithEvents rbSelesai As System.Windows.Forms.RadioButton
    Friend WithEvents rbAmbil As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNonMember As System.Windows.Forms.RadioButton
    Friend WithEvents rbMember As System.Windows.Forms.RadioButton
    Friend WithEvents groupLayanan As System.Windows.Forms.GroupBox
    Friend WithEvents cmbJenisLayanan As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddItems As System.Windows.Forms.Button
End Class
