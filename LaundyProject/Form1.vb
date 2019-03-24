Imports System.Drawing.Printing
Imports System.IO.Ports
Imports System.Globalization

Public Class formOrder
    Private conn As New MySqlConnection
    Dim connString = "Database=laundryapp;Data source=localhost;user id=root;password=;"

    Private disPersen As Double = 0

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
        'My.Application.Culture.NumberFormat.NumberDecimalSeparator = ","
        'CommPortSetup()
        cmbJenisLayanan.Items.Clear()
        fillDropDownLayanan()
        'Console.WriteLine(DateAdd("d", 10, Date.Now.ToShortDateString))
    End Sub

    Sub fillDropDownLayanan()
        conn = New MySqlConnection(connString)
        conn.Open()

        Dim dr As MySqlDataReader = Nothing
        Dim cmdAmbil As MySqlCommand = conn.CreateCommand

        Try
            Dim sqlString As String = "select nama_layanan from t_jenislayanan;"
            cmdAmbil.CommandText = sqlString
            dr = cmdAmbil.ExecuteReader
            While dr.Read
                cmbJenisLayanan.Items.Add(dr.Item("nama_layanan").ToString)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, "terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdAmbil.Dispose()
            'conn.Close()
            'conn = Nothing
        End Try
    End Sub

    Function getHarga(ByVal layanan As String) As Double
        conn = New MySqlConnection(connString)
        conn.Open()

        Dim dr As MySqlDataReader = Nothing
        Dim cmdAmbil As MySqlCommand = conn.CreateCommand
        Dim hrg As Double
        Try
            Dim sqlString As String = "select harga from t_jenislayanan where nama_layanan=@nama_layanan;"
            cmdAmbil.Parameters.Add("@nama_layanan", MySqlDbType.String, 100).Value = layanan
            cmdAmbil.CommandText = sqlString
            dr = cmdAmbil.ExecuteReader
            If dr.Read Then
                hrg = CDbl(dr("harga").ToString)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdAmbil.Dispose()
            'conn.Close()
            'conn = Nothing
        End Try
        Return hrg
    End Function

    Function getLamaLayanan(ByVal layanan As String) As Double
        conn = New MySqlConnection(connString)
        conn.Open()

        Dim dr As MySqlDataReader = Nothing
        Dim cmdAmbil As MySqlCommand = conn.CreateCommand
        Dim lama As Double
        Try
            Dim sqlString As String = "select lama_hari from t_jenislayanan where nama_layanan=@nama_layanan;"
            cmdAmbil.Parameters.Add("@nama_layanan", MySqlDbType.String, 100).Value = layanan
            cmdAmbil.CommandText = sqlString
            dr = cmdAmbil.ExecuteReader
            If dr.Read Then
                lama = CDbl(dr("lama_hari").ToString)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdAmbil.Dispose()
            'conn.Close()
            'conn = Nothing
        End Try
        Return lama
    End Function

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
        Dim jenislyn$, progress$, status$, member$
        Dim hrgdiskon As Double = 0

        jenislyn = cmbJenisLayanan.Text

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

        If rbMember.Checked Then
            member = rbMember.Text
        ElseIf rbNonMember.Checked Then
            member = rbNonMember.Text
        End If

        conn = New MySqlConnection(connString)
        conn.Open()

        Dim cmdInsert As MySqlCommand = conn.CreateCommand

        If editNama.Text <> "" And tglTerima.Text <> "" And txtBerat.Text <> "" And txtHarga.Text <> "" Then
            Try
                Dim sqlString As String = "insert into t_order(nota,nama_customer,tgl_terima,berat,jenis_layanan,harga,progress,status,tgl_diambil,status_member,diskon,bayar)" & _
                    " values " & _
                    "(@nota,@nama,@tglterima,@berat,@jenis_layanan,@harga,@progress,@status,@tgl_ambil,@status_member,@diskon,@bayar);"
                cmdInsert.CommandText = sqlString
                cmdInsert.Connection = conn
                cmdInsert.Parameters.Add("@nota", MySqlDbType.VarChar, 10).Value = newNota
                cmdInsert.Parameters.Add("@nama", MySqlDbType.VarChar, 100).Value = editNama.Text
                cmdInsert.Parameters.Add("@tglterima", MySqlDbType.Date).Value = CDate(tglTerima.Text)
                cmdInsert.Parameters.Add("@berat", MySqlDbType.Double).Value = txtBerat.Text
                cmdInsert.Parameters.Add("@jenis_layanan", MySqlDbType.VarChar, 50).Value = jenislyn
                cmdInsert.Parameters.Add("@harga", MySqlDbType.Double).Value = txtHarga.Text
                cmdInsert.Parameters.Add("@progress", MySqlDbType.VarChar, 50).Value = progress
                cmdInsert.Parameters.Add("@status", MySqlDbType.VarChar, 50).Value = status
                cmdInsert.Parameters.Add("@tgl_ambil", MySqlDbType.Date).Value = CDate(DateAdd("d", getLamaLayanan(jenislyn), CDate(tglTerima.Text)))
                cmdInsert.Parameters.Add("@status_member", MySqlDbType.VarChar, 50).Value = member

                If rbMember.Checked Then
                    calDiskonDate()
                    hrgdiskon = (CDbl(txtHarga.Text) * disPersen)
                    cmdInsert.Parameters.Add("@diskon", MySqlDbType.Double).Value = hrgdiskon
                ElseIf rbNonMember.Checked Then
                    cmdInsert.Parameters.Add("@diskon", MySqlDbType.Double).Value = 0
                End If

                If rbMember.Checked Then
                    cmdInsert.Parameters.Add("@bayar", MySqlDbType.Double).Value = (txtHarga.Text - hrgdiskon)
                ElseIf rbNonMember.Checked Then
                    cmdInsert.Parameters.Add("@bayar", MySqlDbType.Double).Value = txtHarga.Text
                End If

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
    Private Sub clear()
        editNama.Clear()
        txtBerat.Text = "0.000"
        txtHarga.Text = "000.000"
        rbJemur.Checked = False
        rbSelesai.Checked = False
        rbSetrika.Checked = False
        rbSudahBayar.Checked = False
        rbTerima.Checked = False
        rbAmbil.Checked = False
        rbBelumBayar.Checked = False
        rbCuci.Checked = False
        rbMember.Checked = False
        rbNonMember.Checked = False
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
            txtHarga.Text = Format(harga, "#,##0.00")
        Else
            MsgBox("Set Timbangan ke Nol")
        End If
    End Sub

    Private Sub cmbJenisLayanan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbJenisLayanan.SelectedIndexChanged
        If IsNumeric(txtBerat.Text) AndAlso CDbl(txtBerat.Text) >= 0 Then
            txtBerat.Text = "1"
            Dim hrg As Double = CDbl(txtBerat.Text) * getHarga(cmbJenisLayanan.Text)
            txtHarga.Text = Format(hrg, "#,##0.00")
            Console.WriteLine(hrg)
            Console.WriteLine(CDbl(txtBerat.Text) * getHarga(cmbJenisLayanan.Text))
        Else
            MsgBox("Set Timbangan ke Nol")
        End If
    End Sub

    Public Sub autocompleteData()
        editNama.AutoCompleteMode = AutoCompleteMode.Suggest
        editNama.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim dataCollections As New AutoCompleteStringCollection
        getMember(dataCollections)
        editNama.AutoCompleteCustomSource = dataCollections
    End Sub
    Sub getMember(ByVal dataCollection As AutoCompleteStringCollection)
        conn = New MySqlConnection(connString)
        conn.Open()

        Dim dr As MySqlDataReader = Nothing
        Dim cmdAmbil As MySqlCommand = conn.CreateCommand

        Try
            Dim sqlString As String = "select nama_pelanggan from t_pelanggan;"
            cmdAmbil.CommandText = sqlString
            dr = cmdAmbil.ExecuteReader
            While dr.Read
                dataCollection.Add(dr("nama_pelanggan").ToString)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, "terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdAmbil.Dispose()
            'conn.Close()
            'conn = Nothing
        End Try
    End Sub

    Sub calDiskonDate()
        'Console.WriteLine(Date.Now.ToShortDateString)
        conn = New MySqlConnection(connString)
        conn.Open()

        Dim dr As MySqlDataReader = Nothing
        Dim cmdAmbil As MySqlCommand = conn.CreateCommand

        Try
            Dim sqlString As String = "select * from t_diskon;"
            cmdAmbil.CommandText = sqlString
            dr = cmdAmbil.ExecuteReader
            While dr.Read
                'Console.WriteLine(CDate(dr("dari").ToString) & "|" & CDate(dr("sampai").ToString))
                If (Date.Now.ToShortDateString >= dr("dari")) And
                    (Date.Now.ToShortDateString <= dr("sampai")) Then
                    disPersen = dr("diskon") + disPersen
                    Console.WriteLine(disPersen)
                End If
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, "terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdAmbil.Dispose()
            'conn.Close()
            'conn = Nothing
        End Try
    End Sub
    Private Sub rbMember_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMember.CheckedChanged
        If rbMember.Checked = True Then
            editNama.Clear()
            autocompleteData()
        ElseIf rbMember.Checked = False Then
            editNama.AutoCompleteMode = False
            editNama.Clear()
        End If
    End Sub

    Private Sub rbNonMember_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNonMember.CheckedChanged
        If rbNonMember.Checked = True Then
            editNama.AutoCompleteMode = False
        ElseIf rbNonMember.Checked = False Then
            editNama.Clear()
            autocompleteData()
        End If
    End Sub
End Class
