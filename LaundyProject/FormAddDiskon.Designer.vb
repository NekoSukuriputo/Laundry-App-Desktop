<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddDiskon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddDiskon))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picSampai = New System.Windows.Forms.DateTimePicker()
        Me.picDari = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.editNmDiskon = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.editDiskon = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(-3, -2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(550, 78)
        Me.Panel3.TabIndex = 103
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cooper Std Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(136, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(363, 38)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Add Diskon Periode"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.picSampai)
        Me.Panel1.Controls.Add(Me.picDari)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.editNmDiskon)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.editDiskon)
        Me.Panel1.Location = New System.Drawing.Point(39, 108)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(458, 339)
        Me.Panel1.TabIndex = 104
        '
        'picSampai
        '
        Me.picSampai.CustomFormat = "MM/dd/yyyy"
        Me.picSampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.picSampai.Location = New System.Drawing.Point(138, 208)
        Me.picSampai.Name = "picSampai"
        Me.picSampai.Size = New System.Drawing.Size(283, 20)
        Me.picSampai.TabIndex = 5
        '
        'picDari
        '
        Me.picDari.CustomFormat = "MM/dd/yyyy"
        Me.picDari.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.picDari.Location = New System.Drawing.Point(138, 152)
        Me.picDari.Name = "picDari"
        Me.picDari.Size = New System.Drawing.Size(283, 20)
        Me.picDari.TabIndex = 5
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(182, 274)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(82, 35)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = " "
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Diskon"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Sampai"
        '
        'editNmDiskon
        '
        Me.editNmDiskon.Location = New System.Drawing.Point(138, 40)
        Me.editNmDiskon.Name = "editNmDiskon"
        Me.editNmDiskon.Size = New System.Drawing.Size(283, 20)
        Me.editNmDiskon.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dari"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Diskon"
        '
        'editDiskon
        '
        Me.editDiskon.Location = New System.Drawing.Point(138, 103)
        Me.editDiskon.Name = "editDiskon"
        Me.editDiskon.Size = New System.Drawing.Size(283, 20)
        Me.editDiskon.TabIndex = 2
        '
        'FormAddDiskon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaundyProject.My.Resources.Resources.th001X0WEA
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(540, 470)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FormAddDiskon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Add Diskon"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents editNmDiskon As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents editDiskon As System.Windows.Forms.TextBox
    Friend WithEvents picDari As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents picSampai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
