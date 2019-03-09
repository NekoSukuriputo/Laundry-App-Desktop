Imports System.Drawing.Printing
Imports System.IO.Ports
Imports System.Globalization

Public Class formOrder
    Private conn As New MySqlConnection
    Dim connString = "Database=laundryapp;Data source=localhost;user id=root;password=;"

    Private noNota%, newNota$
    Private mySerialPort As New SerialPort
    Private comBuffer As Byte()
    Private Delegate Sub UpdateFormDelegate()
    Private UpdateFormDelegate1 As UpdateFormDelegate

    Private Sub CommPortSetup()
        With mySerialPort
            .PortName = "COM9"
            .BaudRate = 9600
            .DataBits = 8
            .Parity = Parity.None
            .StopBits = StopBits.One
            .Handshake = Handshake.None
        End With
        Try
            mySerialPort.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub mySerialPort_DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs)
        'Handles serial port data received events
        UpdateFormDelegate1 = New UpdateFormDelegate(AddressOf UpdateDisplay)
        Dim n As Integer = mySerialPort.BytesToRead 'find number of bytes in buf
        comBuffer = New Byte(n - 1) {} 're dimension storage buffer
        mySerialPort.Read(comBuffer, 0, n) 'read data from the buffer
        Me.Invoke(UpdateFormDelegate1) 'call the delegate
    End Sub
    Private Sub UpdateDisplay()
        'txtBerat.Text = mySerialPort.ReadLine
        'Label4.Text = Label3.Text.Trim("T.GS.+kg".ToCharArray())
        Dim b As String = mySerialPort.ReadLine.ToString.Trim("N,.T,$,US,T,GS,+kg".ToCharArray())
        txtBerat.Text = b.Substring(0, b.Length - 3)
    End Sub
    Private Sub formOrder_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        clear()
        getNewNota()
        'AddHandler mySerialPort.DataReceived, AddressOf mySerialPort_DataReceived
        Application.CurrentCulture = New CultureInfo("EN-US")
        'CommPortSetup()
    End Sub

    Private Sub formOrder_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Application.Exit()
        Me.Hide()
        clear()
        formListOrder.tampil()
        formListOrder.Show()
    End Sub

    Private Sub formOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'getNewNota()
        AddHandler mySerialPort.DataReceived, AddressOf mySerialPort_DataReceived
        CommPortSetup()
        'Label4.Text = Label3.Text.Trim("T.GS.+kg".ToCharArray())
        'txtBerat.Text = "0"
    End Sub
    Sub getNewNota()
        getLastNota()
        If noNota < 0 Then
            noNota = 1
            newNota = String.Format("{0:D5}", noNota)
        Else
            noNota += 1
            newNota = String.Format("{0:D5}", noNota)
        End If
    End Sub

    Sub getLastNota()

        conn = New MySqlConnection(connString)
        conn.Open()

        Dim dr As MySqlDataReader = Nothing
        Dim cmdAmbil As MySqlCommand = conn.CreateCommand
        Try
            Dim sqlString As String = "SELECT nota FROM t_order ORDER BY nota DESC LIMIT 1"
            cmdAmbil.CommandText = sqlString
            dr = cmdAmbil.ExecuteReader
            If dr.Read Then
                formUpdateOrder.nota = dr("nota").ToString
                noNota = CInt(dr("nota").ToString)
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdAmbil.Dispose()
            'conn.Close()
        End Try
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Dim jenislyn$, progress$, status$

        If (rbStandart.Checked) Then
            jenislyn = rbStandart.Text
        ElseIf (rbExpress.Checked) Then
            jenislyn = rbExpress.Text
        End If

        If (rbTerima.Checked) Then
            progress = rbTerima.Text
        ElseIf (rbCuci.Checked) Then
            progress = rbCuci.Text
        ElseIf (rbSetrika.Checked) Then
            progress = rbSetrika.Text
        ElseIf (rbJemur.Checked) Then
            progress = rbJemur.Text
        ElseIf (rbSelesai.Checked) Then
            progress = rbSelesai.Text
        ElseIf (rbAmbil.Checked) Then
            progress = rbAmbil.Text
        End If

        If (rbSudahBayar.Checked) Then
            status = rbSudahBayar.Text
        ElseIf (rbBelumBayar.Checked) Then
            status = rbBelumBayar.Text
        End If

        conn = New MySqlConnection(connString)
        conn.Open()

        Dim cmdInsert As MySqlCommand = conn.CreateCommand

        If editNama.Text <> "" And tglTerima.Text <> "" And txtBerat.Text <> "" And txtHarga.Text <> "" Then
            Try
                Dim sqlString As String = "insert into t_order(nota,nama_customer,tgl_terima,berat,jenis_layanan,harga,progress,status,tgl_diambil)" & _
                    " values " & _
                    "(@nota,@nama,@tglterima,@berat,@jenis_layanan,@harga,@progress,@status,@tgl_ambil);"
                cmdInsert.CommandText = sqlString
                cmdInsert.Connection = conn
                cmdInsert.Parameters.Add("@nota", MySqlDbType.VarChar, 10).Value = newNota
                cmdInsert.Parameters.Add("@nama", MySqlDbType.VarChar, 100).Value = editNama.Text
                cmdInsert.Parameters.Add("@tglterima", MySqlDbType.Date).Value = tglTerima.Text
                cmdInsert.Parameters.Add("@berat", MySqlDbType.Double).Value = txtBerat.Text
                cmdInsert.Parameters.Add("@jenis_layanan", MySqlDbType.VarChar, 50).Value = jenislyn
                cmdInsert.Parameters.Add("@harga", MySqlDbType.Double).Value = txtHarga.Text
                'cmdInsert.Parameters.Add("@harga", MySqlDbType.Double).Value = editHarga.Text
                cmdInsert.Parameters.Add("@progress", MySqlDbType.VarChar, 50).Value = progress
                cmdInsert.Parameters.Add("@status", MySqlDbType.VarChar, 50).Value = status
                cmdInsert.Parameters.Add("@tgl_ambil", MySqlDbType.Date).Value = tglTerima.Text
                cmdInsert.ExecuteNonQuery()

                MessageBox.Show("Data berhasil ditambahkan", "Create Order", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If MsgBoxResult.Ok Then
                    getLastNota()
                    clear()
                    formUpdateOrder.Show()
                    Me.Hide()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Terjadi kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Anda Harus Isi semua", "Create Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub rbStandart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbStandart.CheckedChanged
        If IsNumeric(txtBerat.Text) AndAlso CDbl(txtBerat.Text) >= 0 Then
            Dim harga As Double
            harga = 5000 * CDbl(txtBerat.Text)
            txtHarga.Text = Format(harga, "#,##0.00")
        Else
            MsgBox("Set Timbangan ke Nol")
        End If
    End Sub
    Private Sub clear()
        editNama.Clear()
        txtBerat.Text = "0.000"
        txtHarga.Text = "000.000"
        rbStandart.Checked = False
        rbExpress.Checked = False
        rbJemur.Checked = False
        rbSelesai.Checked = False
        rbSetrika.Checked = False
        rbSudahBayar.Checked = False
        rbTerima.Checked = False
        rbAmbil.Checked = False
        rbBelumBayar.Checked = False
        rbCuci.Checked = False
    End Sub
    Private Sub rbExpress_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbExpress.CheckedChanged
        If IsNumeric(txtBerat.Text) AndAlso CDbl(txtBerat.Text) >= 0 Then
            Dim harga As Double
            harga = 8000 * CDbl(txtBerat.Text)
            txtHarga.Text = Format(harga, "#,##0.00")
        Else
            MsgBox("Set Timbangan ke Nol")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        formListOrder.tampil()
        formListOrder.Show()
    End Sub

    Private Sub txtBerat_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBerat.TextChanged
        'If (CDbl(txtBerat.Text) <> 0) Then
        Dim harga As Double
        If IsNumeric(txtBerat.Text) AndAlso CDbl(txtBerat.Text) >= 0 Then
            If (rbStandart.Checked) Then
                harga = 5000 * CDbl(txtBerat.Text)
            ElseIf (rbExpress.Checked) Then
                harga = 8000 * CDbl(txtBerat.Text)
            End If
            txtHarga.Text = Format(harga, "#,##0.00")
        Else
            MsgBox("Set Timbangan ke Nol")
        End If
    End Sub
End Class
