<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReport))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSelectJenis = New System.Windows.Forms.ComboBox()
        Me.cmbBulan = New System.Windows.Forms.ComboBox()
        Me.editTahun = New System.Windows.Forms.TextBox()
        Me.tglHarian = New System.Windows.Forms.DateTimePicker()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.DGVReport = New System.Windows.Forms.DataGridView()
        Me.Kol_Nota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_Pelanggan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.statusmemebr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_Terima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_Ambil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_Jenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_Berat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diskon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_Progress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.btnGenerate)
        Me.Panel1.Controls.Add(Me.tglHarian)
        Me.Panel1.Controls.Add(Me.editTahun)
        Me.Panel1.Controls.Add(Me.cmbBulan)
        Me.Panel1.Controls.Add(Me.cmbSelectJenis)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(39, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(331, 137)
        Me.Panel1.TabIndex = 103
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cooper Std Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(136, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 38)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Report"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(-4, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(462, 78)
        Me.Panel3.TabIndex = 104
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 24)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Report :"
        '
        'cmbSelectJenis
        '
        Me.cmbSelectJenis.FormattingEnabled = True
        Me.cmbSelectJenis.Items.AddRange(New Object() {"Harian", "Bulanan", "Tahunan"})
        Me.cmbSelectJenis.Location = New System.Drawing.Point(108, 20)
        Me.cmbSelectJenis.Name = "cmbSelectJenis"
        Me.cmbSelectJenis.Size = New System.Drawing.Size(170, 21)
        Me.cmbSelectJenis.TabIndex = 106
        '
        'cmbBulan
        '
        Me.cmbBulan.FormattingEnabled = True
        Me.cmbBulan.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        Me.cmbBulan.Location = New System.Drawing.Point(108, 60)
        Me.cmbBulan.Name = "cmbBulan"
        Me.cmbBulan.Size = New System.Drawing.Size(170, 21)
        Me.cmbBulan.TabIndex = 107
        '
        'editTahun
        '
        Me.editTahun.Location = New System.Drawing.Point(108, 60)
        Me.editTahun.Name = "editTahun"
        Me.editTahun.Size = New System.Drawing.Size(170, 20)
        Me.editTahun.TabIndex = 108
        '
        'tglHarian
        '
        Me.tglHarian.CustomFormat = "MM/dd/yyyy"
        Me.tglHarian.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglHarian.Location = New System.Drawing.Point(108, 60)
        Me.tglHarian.Name = "tglHarian"
        Me.tglHarian.Size = New System.Drawing.Size(170, 20)
        Me.tglHarian.TabIndex = 109
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(128, 98)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(105, 23)
        Me.btnGenerate.TabIndex = 110
        Me.btnGenerate.Text = "Generate Report"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'DGVReport
        '
        Me.DGVReport.AllowUserToAddRows = False
        Me.DGVReport.AllowUserToDeleteRows = False
        Me.DGVReport.AllowUserToResizeColumns = False
        Me.DGVReport.AllowUserToResizeRows = False
        Me.DGVReport.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGVReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kol_Nota, Me.kol_Pelanggan, Me.statusmemebr, Me.kol_Terima, Me.kol_Ambil, Me.kol_Jenis, Me.kol_Berat, Me.kol_Harga, Me.diskon, Me.bayar, Me.kol_Progress, Me.kol_Status})
        Me.DGVReport.Location = New System.Drawing.Point(39, 260)
        Me.DGVReport.Name = "DGVReport"
        Me.DGVReport.ReadOnly = True
        Me.DGVReport.Size = New System.Drawing.Size(607, 134)
        Me.DGVReport.TabIndex = 105
        Me.DGVReport.Visible = False
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
        Me.kol_Pelanggan.Width = 170
        '
        'statusmemebr
        '
        Me.statusmemebr.DataPropertyName = "status_member"
        Me.statusmemebr.HeaderText = "Status Member"
        Me.statusmemebr.Name = "statusmemebr"
        Me.statusmemebr.ReadOnly = True
        '
        'kol_Terima
        '
        Me.kol_Terima.DataPropertyName = "tgl_terima"
        Me.kol_Terima.HeaderText = "Tanggal Terima"
        Me.kol_Terima.Name = "kol_Terima"
        Me.kol_Terima.ReadOnly = True
        Me.kol_Terima.Width = 80
        '
        'kol_Ambil
        '
        Me.kol_Ambil.DataPropertyName = "tgl_diambil"
        Me.kol_Ambil.HeaderText = "Tgl Diambil"
        Me.kol_Ambil.Name = "kol_Ambil"
        Me.kol_Ambil.ReadOnly = True
        Me.kol_Ambil.Width = 80
        '
        'kol_Jenis
        '
        Me.kol_Jenis.DataPropertyName = "jenis_layanan"
        Me.kol_Jenis.HeaderText = "Jenis Layanan"
        Me.kol_Jenis.Name = "kol_Jenis"
        Me.kol_Jenis.ReadOnly = True
        '
        'kol_Berat
        '
        Me.kol_Berat.DataPropertyName = "berat"
        Me.kol_Berat.HeaderText = "Berat"
        Me.kol_Berat.Name = "kol_Berat"
        Me.kol_Berat.ReadOnly = True
        Me.kol_Berat.Width = 50
        '
        'kol_Harga
        '
        Me.kol_Harga.DataPropertyName = "harga"
        Me.kol_Harga.HeaderText = "Harga"
        Me.kol_Harga.Name = "kol_Harga"
        Me.kol_Harga.ReadOnly = True
        '
        'diskon
        '
        Me.diskon.DataPropertyName = "diskon"
        Me.diskon.HeaderText = "Diskon"
        Me.diskon.Name = "diskon"
        Me.diskon.ReadOnly = True
        '
        'bayar
        '
        Me.bayar.DataPropertyName = "bayar"
        Me.bayar.HeaderText = "Bayar"
        Me.bayar.Name = "bayar"
        Me.bayar.ReadOnly = True
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(71, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(285, 16)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = " Lokasi Report : C:\Laundry Report\Report"
        '
        'FormReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaundyProject.My.Resources.Resources.th001X0WEA
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(416, 287)
        Me.Controls.Add(Me.DGVReport)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.Name = "FormReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbSelectJenis As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbBulan As System.Windows.Forms.ComboBox
    Friend WithEvents editTahun As System.Windows.Forms.TextBox
    Friend WithEvents tglHarian As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents DGVReport As System.Windows.Forms.DataGridView
    Friend WithEvents Kol_Nota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_Pelanggan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents statusmemebr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_Terima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_Ambil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_Jenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_Berat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_Harga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents diskon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bayar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_Progress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
