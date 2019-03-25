<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddItem))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.editItem = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.editJumlah = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.gridItem = New System.Windows.Forms.DataGridView()
        Me.nama_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kol_Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kolEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGVSingleItem = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVSingleItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Linen
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Controls.Add(Me.gridItem)
        Me.Panel1.Location = New System.Drawing.Point(426, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(416, 529)
        Me.Panel1.TabIndex = 48
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.editItem)
        Me.GroupBox6.Controls.Add(Me.btnTambah)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.editJumlah)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Location = New System.Drawing.Point(13, 9)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(389, 152)
        Me.GroupBox6.TabIndex = 50
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Other Item"
        '
        'editItem
        '
        Me.editItem.Location = New System.Drawing.Point(95, 57)
        Me.editItem.Name = "editItem"
        Me.editItem.Size = New System.Drawing.Size(204, 20)
        Me.editItem.TabIndex = 16
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
        Me.btnTambah.Location = New System.Drawing.Point(319, 55)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(53, 57)
        Me.btnTambah.TabIndex = 18
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Jumlah"
        '
        'editJumlah
        '
        Me.editJumlah.Location = New System.Drawing.Point(95, 92)
        Me.editJumlah.Name = "editJumlah"
        Me.editJumlah.Size = New System.Drawing.Size(204, 20)
        Me.editJumlah.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Nama Item"
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
        Me.btnFinish.Location = New System.Drawing.Point(373, 32)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(93, 31)
        Me.btnFinish.TabIndex = 19
        Me.btnFinish.UseVisualStyleBackColor = False
        '
        'gridItem
        '
        Me.gridItem.AllowUserToAddRows = False
        Me.gridItem.AllowUserToResizeRows = False
        Me.gridItem.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.gridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nama_item, Me.kol_Jumlah, Me.idItem, Me.kolEdit})
        Me.gridItem.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gridItem.Location = New System.Drawing.Point(24, 181)
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Linen
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.DGVSingleItem)
        Me.Panel2.Location = New System.Drawing.Point(4, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(416, 529)
        Me.Panel2.TabIndex = 48
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 152)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Single Item"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(319, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 57)
        Me.Button1.TabIndex = 18
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Jumlah"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(95, 92)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(204, 20)
        Me.TextBox2.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Nama Item"
        '
        'DGVSingleItem
        '
        Me.DGVSingleItem.AllowUserToAddRows = False
        Me.DGVSingleItem.AllowUserToResizeRows = False
        Me.DGVSingleItem.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DGVSingleItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSingleItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewButtonColumn1})
        Me.DGVSingleItem.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGVSingleItem.Location = New System.Drawing.Point(24, 181)
        Me.DGVSingleItem.Name = "DGVSingleItem"
        Me.DGVSingleItem.ReadOnly = True
        Me.DGVSingleItem.Size = New System.Drawing.Size(365, 292)
        Me.DGVSingleItem.TabIndex = 49
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "nama_item"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nama Item"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Width = 220
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "jumlah"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Jumlah"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "id"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewButtonColumn1
        '
        Me.DataGridViewButtonColumn1.DataPropertyName = "id"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.NullValue = "Delete"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewButtonColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewButtonColumn1.HeaderText = "Aksi"
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.ReadOnly = True
        Me.DataGridViewButtonColumn1.Text = "Delete"
        Me.DataGridViewButtonColumn1.UseColumnTextForButtonValue = True
        Me.DataGridViewButtonColumn1.Width = 50
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(95, 50)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(204, 21)
        Me.ComboBox1.TabIndex = 49
        '
        'FormAddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 671)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormAddItem"
        Me.Text = "Form Add Item"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVSingleItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents editItem As System.Windows.Forms.TextBox
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents editJumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnFinish As System.Windows.Forms.Button
    Friend WithEvents gridItem As System.Windows.Forms.DataGridView
    Friend WithEvents nama_item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_Jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kolEdit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DGVSingleItem As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
