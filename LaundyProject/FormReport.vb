Imports System.Globalization
Imports System.IO

Public Class FormReport

    Private conn As New MySqlConnection
    Dim connString = "Database=laundryapp;data source=localhost;user id=root;password=;"


    Private Sub cmbSelectJenis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSelectJenis.SelectedIndexChanged
        If cmbSelectJenis.Text = "Harian" Then
            'Console.WriteLine(Date.Now.Day)
            tglHarian.Visible = True
            cmbBulan.Visible = False
            editTahun.Visible = False
        ElseIf cmbSelectJenis.Text = "Bulanan" Then
            'Console.WriteLine(Date.Now.Month)
            tglHarian.Visible = False
            cmbBulan.Visible = True
            editTahun.Visible = False
        ElseIf cmbSelectJenis.Text = "Tahunan" Then
            'Console.WriteLine(Date.Now.Year)
            tglHarian.Visible = False
            cmbBulan.Visible = False
            editTahun.Visible = True
        End If
    End Sub

    Private Sub FormReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Application.CurrentCulture = New CultureInfo("EN-US")
        tglHarian.Visible = False
        cmbBulan.Visible = False
        editTahun.Visible = False
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        tampil()
        'Application.DoEvents()
        If DGVReport.RowCount = 0 Then
            MsgBox("Tidak ada Data untuk dijadikan report")
            Return
        End If

        btnGenerate.Text = "Mohon Tunggu..."
        btnGenerate.Enabled = False
        Application.DoEvents()
        Dim forDate As String = "dd-MMMM-yyyy"
        'Dim FlNm As String
        Dim path As String
        Dim RPT = New ReportClass

        If cmbSelectJenis.Text = "Harian" Then
            RPT.FlNm = "C:\Laundry Report\Report\Report (" & cmbSelectJenis.Text & ")\Report - " & CType(tglHarian.Text, DateTime).ToString(forDate, New CultureInfo("id")) & ".xls"
            path = "C:\Laundry Report\Report\Report (" & cmbSelectJenis.Text & ")"
        ElseIf cmbSelectJenis.Text = "Bulanan" Then
            RPT.FlNm = "C:\Laundry Report\Report\Report (" & cmbSelectJenis.Text & ")\Report - " & cmbBulan.Text & "-" & CStr(Date.Now.Year) & ".xls"
            path = "C:\Laundry Report\Report\Report (" & cmbSelectJenis.Text & ")"
        ElseIf cmbSelectJenis.Text = "Tahunan" Then
            RPT.FlNm = "C:\Laundry Report\Report\Report (" & cmbSelectJenis.Text & ")\Report - " & editTahun.Text & ".xls"
            path = "C:\Laundry Report\Report\Report (" & cmbSelectJenis.Text & ")"
        End If

        If (Not System.IO.Directory.Exists(path)) Then
            System.IO.Directory.CreateDirectory(path)
        End If

        If File.Exists(RPT.FlNm) Then File.Delete(RPT.FlNm)
        RPT.ReportHari("Report Harian", DGVReport)
        Application.DoEvents()
        Process.Start(RPT.FlNm)
        Application.DoEvents()
        btnGenerate.Enabled = True
        btnGenerate.Text = "Generate Report"
    End Sub

    Public Sub tampil()

        Dim bln%

        Select Case cmbBulan.Text
            Case "Januari"
                bln = 1
            Case "Februari"
                bln = 2
            Case "Maret"
                bln = 3
            Case "April"
                bln = 4
            Case "Mei"
                bln = 5
            Case "Juni"
                bln = 6
            Case "Juli"
                bln = 7
            Case "Agustus"
                bln = 8
            Case "September"
                bln = 9
            Case "Oktober"
                bln = 10
            Case "November"
                bln = 11
            Case "Desember"
                bln = 12
        End Select


        Dim da As New MySqlDataAdapter()
        Dim ds As New DataSet()

        conn = New MySqlConnection(connString)
        conn.Open()

        Dim cmdSelect As MySqlCommand = conn.CreateCommand()
        Dim sqlString As String

        Try
            sqlString = "SELECT nota,nama_customer,status_member," & _
                "tgl_terima,tgl_diambil,jenis_layanan,berat, harga, diskon, bayar, progress ,status FROM t_order "

            If cmbSelectJenis.Text = "Harian" Then
                'cmdSelect.Parameters.AddWithValue("@where", "tgl_terima = " & tglHarian.Text)
                sqlString &= " WHERE tgl_terima = @where;"
                cmdSelect.Parameters.Add("@where", MySqlDbType.VarChar, 100).Value = tglHarian.Text
            ElseIf cmbSelectJenis.Text = "Bulanan" Then
                'cmdSelect.Parameters.AddWithValue("@where", "year(tgl_terima) = '" & CStr(Date.Now.Year) & "' and month(tgl_terima) = " & bln)
                sqlString &= " WHERE year(tgl_terima)= @thn AND month(tgl_terima) = @bln;"
                cmdSelect.Parameters.Add("@thn", MySqlDbType.VarChar, 100).Value = CStr(Date.Now.Year)
                cmdSelect.Parameters.Add("@bln", MySqlDbType.VarChar, 100).Value = bln
            ElseIf cmbSelectJenis.Text = "Tahunan" Then
                'cmdSelect.Parameters.AddWithValue("@where", "year(tgl_terima) = '" & editTahun.Text)
                sqlString &= " WHERE year(tgl_terima)= @where;"
                cmdSelect.Parameters.Add("@where", MySqlDbType.VarChar, 100).Value = editTahun.Text
            End If

            cmdSelect.CommandText = sqlString
            da.SelectCommand = cmdSelect
            da.Fill(ds, "t_order")
            DGVReport.DataSource = ds
            DGVReport.DataMember = "t_order"
            DGVReport.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdSelect.Dispose()
            'conn.Close()
        End Try
    End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    ExportExcel(DataGridView1)
    'End Sub
    'Sub ExportExcel(ByVal obj As Object)
    '    Dim rowsTotal, colsTotal As Short
    '    Dim I, j, iC As Short
    '    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
    '    Dim xlApp As New Excel.Application
    '    Try
    '        Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
    '        Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
    '        xlApp.Visible = True

    '        rowsTotal = obj.RowCount
    '        colsTotal = obj.Columns.Count - 1
    '        With excelWorksheet
    '            .Cells.Select()
    '            .Cells.Delete()
    '            For iC = 0 To colsTotal
    '                .Cells(1, iC + 1).Value = obj.Columns(iC).HeaderText
    '            Next
    '            For I = 0 To rowsTotal - 1
    '                For j = 0 To colsTotal
    '                    .Cells(I + 2, j + 1).value = obj.Rows(I).Cells(j).Value
    '                Next j
    '            Next I
    '            .Rows("1:1").Font.FontStyle = "Bold"
    '            .Rows("1:1").Font.Size = 12

    '            .Cells.Columns.AutoFit()
    '            .Cells.Select()
    '            .Cells.EntireColumn.AutoFit()
    '            .Cells(1, 1).Select()
    '        End With
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        'RELEASE ALLOACTED RESOURCES
    '        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    '        xlApp = Nothing
    '    End Try
    'End Sub

End Class