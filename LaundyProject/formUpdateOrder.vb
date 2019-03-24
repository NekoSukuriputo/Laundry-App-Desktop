Imports System.Globalization

Public Class formUpdateOrder
    Private conn As New MySqlConnection
    Public nota As String = ""
    Dim connString = "Database=laundryapp;Data source=localhost;user id=root;password=;"

    Private disPersen As Double = 0

    Private Sub formUpdateOrder_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        tampil()
        showItem()
        Application.CurrentCulture = New CultureInfo("EN-US")
        cmbJenisLayanan.Items.Clear()
        fillDropDownLayanan()
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

    Private Sub formUpdateOrder_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Application.Exit()
        Me.Hide()
        formListOrder.tampil()
    End Sub

    Private Sub formUpdateOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
        showItem()
    End Sub

    Sub tampil()
        conn = New MySqlConnection(connString)
        conn.Open()

        Dim progress$, status$, status_member$

        Dim dr As MySqlDataReader = Nothing
        Dim cmdAmbil As MySqlCommand = conn.CreateCommand
        Try
            Dim sqlString As String = "select * from t_order where nota = @nota;"
            cmdAmbil.Parameters.Add("@nota", MySqlDbType.Int16).Value = nota
            'cmdAmbil.Parameters.Add("@nota", MySqlDbType.Int16).Value = 9
            cmdAmbil.CommandText = sqlString
            dr = cmdAmbil.ExecuteReader
            If dr.Read Then
                txtNota.Text = dr("nota").ToString
                editNama.Text = dr("nama_customer").ToString
                tglTerima.Text = dr("tgl_terima").ToString
                editBerat.Text = dr("berat").ToString
                tglAmbil.Text = dr("tgl_diambil").ToString
                cmbJenisLayanan.Text = dr("jenis_layanan").ToString
                progress = dr("progress").ToString
                status = dr("status").ToString
                status_member = dr("status_member").ToString

                If (progress = rbTerima.Text) Then
                    rbTerima.Checked = True
                ElseIf (progress = rbCuci.Text) Then
                    rbCuci.Checked = True
                ElseIf (progress = rbSetrika.Text) Then
                    rbSetrika.Checked = True
                ElseIf (progress = rbJemur.Text) Then
                    rbJemur.Checked = True
                ElseIf (progress = rbSelesai.Text) Then
                    rbSelesai.Checked = True
                ElseIf (progress = rbAmbil.Text) Then
                    rbAmbil.Checked = True
                End If

                If (status = rbBelumBayar.Text) Then
                    rbBelumBayar.Checked = True
                ElseIf (status = rbSudahBayar.Text) Then
                    rbSudahBayar.Checked = True
                End If

                If status_member = rbMember.Text Then
                    rbMember.Checked = True
                ElseIf status_member = rbNonMember.Text Then
                    rbNonMember.Checked = True
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdAmbil.Dispose()
            conn.Close()
            conn = Nothing
        End Try

    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click

        conn = New MySqlConnection(connString)
        conn.Open()

        Dim cmdInsert As MySqlCommand = conn.CreateCommand
        If (editItem.Text <> "" And editJumlah.Text <> "") Then
            Try
                Dim sqlString As String = "insert into t_detailorder(nota,nama_item,jumlah)" & _
                    " values " & _
                    "(@nota,@item,@jumlah);"
                cmdInsert.CommandText = sqlString
                cmdInsert.Connection = conn
                cmdInsert.Parameters.Add("@nota", MySqlDbType.VarChar, 100).Value = txtNota.Text
                'cmdInsert.Parameters.Add("@nota", MySqlDbType.VarChar, 100).Value = 9
                cmdInsert.Parameters.Add("@item", MySqlDbType.VarChar, 100).Value = editItem.Text
                cmdInsert.Parameters.Add("@jumlah", MySqlDbType.Int16).Value = editJumlah.Text
                cmdInsert.ExecuteNonQuery()
                'MessageBox.Show("Data berhasil ditambahkan", "Create Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
                editItem.Clear()
                editJumlah.Clear()
                showItem()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Terjadi kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Sub showItem()
        Dim da As New MySqlDataAdapter()
        Dim ds As New DataSet()

        conn = New MySqlConnection(connString)
        conn.Open()

        Dim cmdSelect As MySqlCommand = conn.CreateCommand()
        Dim sqlString As String

        Try
            sqlString = "Select id,nama_item,jumlah from t_detailorder where nota=@nota;"
            cmdSelect.Parameters.Add("@nota", MySqlDbType.Int16).Value = nota
            'cmdSelect.Parameters.Add("@nota", MySqlDbType.Int16).Value = 9

            cmdSelect.CommandText = sqlString
            da.SelectCommand = cmdSelect
            da.Fill(ds, "t_detailorder")
            gridItem.DataSource = ds
            gridItem.DataMember = "t_detailorder"
            gridItem.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdSelect.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub gridItem_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridItem.CellContentClick
        If (e.ColumnIndex = 3) Then
            Dim id As Integer = gridItem.Rows(e.RowIndex).Cells(0).Value
            'MsgBox(gridItem.Rows(e.RowIndex).Cells(0).Value)

            conn = New MySqlConnection(connString)
            conn.Open()

            Dim cmdDel As MySqlCommand = conn.CreateCommand
            Try
                Dim sqlString As String = "delete from t_detailorder where id=@id;"
                cmdDel.CommandText = sqlString
                cmdDel.Connection = conn
                cmdDel.Parameters.Add("@id", MySqlDbType.Int16).Value = id
                cmdDel.ExecuteNonQuery()
                'MessageBox.Show("Data berhasil ditambahkan", "Create Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
                showItem()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Terjadi kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub updateData()
        Dim jenislyn$, progress$, status$, member$
        Dim hrgdiskon As Double = 0

        jenislyn = cmbJenisLayanan.Text

        Dim hargaKotor As Double = CDbl(editBerat.Text) * getHarga(cmbJenisLayanan.Text)

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

        If editNama.Text <> "" And tglTerima.Text <> "" And editBerat.Text <> "" Then
            Try
                Dim sqlString As String = "update t_order set " & _
                "nama_customer = @nama," & _
                "tgl_terima = @tglterima," & _
                "berat = @berat," & _
                "jenis_layanan = @jenis_layanan," & _
                "harga = @harga," & _
                "progress = @progress," & _
                "status = @status, " & _
                "tgl_diambil = @tgl_ambil, " & _
                "status_member = @status_member, " & _
                "diskon = @diskon , " & _
                "bayar = @bayar where nota = @nota"
                cmdInsert.CommandText = sqlString
                cmdInsert.Connection = conn
                cmdInsert.Parameters.Add("@nama", MySqlDbType.VarChar, 100).Value = editNama.Text
                cmdInsert.Parameters.Add("@tglterima", MySqlDbType.Date).Value = tglTerima.Text
                cmdInsert.Parameters.Add("@berat", MySqlDbType.Double).Value = editBerat.Text
                cmdInsert.Parameters.Add("@jenis_layanan", MySqlDbType.VarChar, 50).Value = jenislyn
                cmdInsert.Parameters.Add("@harga", MySqlDbType.Double).Value = hargaKotor
                cmdInsert.Parameters.Add("@progress", MySqlDbType.VarChar, 50).Value = progress
                cmdInsert.Parameters.Add("@status", MySqlDbType.VarChar, 50).Value = status
                cmdInsert.Parameters.Add("@tgl_ambil", MySqlDbType.Date).Value = tglAmbil.Text
                cmdInsert.Parameters.Add("@nota", MySqlDbType.VarChar, 11).Value = txtNota.Text
                'cmdInsert.Parameters.Add("@nota", MySqlDbType.Int16).Value = 9
                cmdInsert.Parameters.Add("@status_member", MySqlDbType.VarChar, 50).Value = member

                If rbMember.Checked Then
                    calDiskonDate()
                    hrgdiskon = hargaKotor * disPersen
                    cmdInsert.Parameters.Add("@diskon", MySqlDbType.Double).Value = hrgdiskon
                ElseIf rbNonMember.Checked Then
                    cmdInsert.Parameters.Add("@diskon", MySqlDbType.Double).Value = 0
                End If

                If rbMember.Checked Then
                    cmdInsert.Parameters.Add("@bayar", MySqlDbType.Double).Value = (hargaKotor - hrgdiskon)
                ElseIf rbNonMember.Checked Then
                    cmdInsert.Parameters.Add("@bayar", MySqlDbType.Double).Value = hargaKotor
                End If

                cmdInsert.ExecuteNonQuery()

                MessageBox.Show("Data berhasil diUbah", "Update Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tampil()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Terjadi kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Anda Harus Isi semua", "Create Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        updateData()
    End Sub

    Private Sub btnFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinish.Click
        Me.Hide()
        formListOrder.tampil()
        formDetail.Show()
    End Sub

    Private Sub cmbJenisLayanan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbJenisLayanan.SelectedIndexChanged
        'If IsNumeric(editBerat.Text) AndAlso CDbl(editBerat.Text) >= 0 Then
        '    'editBerat.Text = "1"
        '    'Dim hrg As Double = CDbl(editBerat.Text) * getHarga(cmbJenisLayanan.Text)
        '    'editBerat.Text = Format(hrg, "#,##0.00")
        '    'Console.WriteLine(hrg)
        '    'Console.WriteLine(CDbl(txtBerat.Text) * getHarga(cmbJenisLayanan.Text))
        'Else
        '    MsgBox("Set Timbangan ke Nol")
        'End If
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