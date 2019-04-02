Imports System.Globalization

Public Class formUpdateOrder
    Private conn As New MySqlConnection
    Public nota As String = ""
    Dim connString = "Database=laundryapp;Data source=localhost;user id=root;password=;"

    Private disPersen As Double = 0

    Public bayarItem As Double = 0
    Private hrgDB As Double = 0
    Private disDB As Double = 0

    Private Sub formUpdateOrder_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        tampil()
        'showItem()
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
        'showItem()
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

                'var baray from db
                'hrgDB = CDbl(dr("bayar").ToString)

                'var diskon DB 
                disDB = CDbl(dr("diskon").ToString)

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

    Private Sub updateData()
        Dim jenislyn$, progress$, status$, member$
        Dim hrgdiskon As Double = 0

        jenislyn = cmbJenisLayanan.Text

        Dim hargaKotor As Double = CDbl(editBerat.Text) * getHarga(cmbJenisLayanan.Text)
        'hrgDB = editBerat.Text

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
                cmdInsert.Parameters.Add("@harga", MySqlDbType.Double).Value = (hargaKotor + bayarItem)
                cmdInsert.Parameters.Add("@progress", MySqlDbType.VarChar, 50).Value = progress
                cmdInsert.Parameters.Add("@status", MySqlDbType.VarChar, 50).Value = status
                cmdInsert.Parameters.Add("@tgl_ambil", MySqlDbType.Date).Value = tglAmbil.Text
                cmdInsert.Parameters.Add("@nota", MySqlDbType.VarChar, 11).Value = txtNota.Text
                'cmdInsert.Parameters.Add("@nota", MySqlDbType.Int16).Value = 9
                cmdInsert.Parameters.Add("@status_member", MySqlDbType.VarChar, 50).Value = member

                If rbMember.Checked Then
                    If (cekMemberExis(editNama.Text)) Then
                        'If (disDB > 0) Then
                        '    calDiskonDateDB()
                        'Else
                        calDiskonDate()
                        'End If
                        hrgdiskon = (hargaKotor + bayarItem) * disPersen
                        cmdInsert.Parameters.Add("@diskon", MySqlDbType.Double).Value = hrgdiskon
                        cmdInsert.Parameters.Add("@bayar", MySqlDbType.Double).Value = ((hargaKotor + bayarItem) - hrgdiskon)
                        cmdInsert.Parameters.Add("@member_id", MySqlDbType.Int16).Value = getMemberID(editNama.Text)
                    Else
                        MsgBox("Nama yang diinput bukan member")
                    End If

                ElseIf rbNonMember.Checked Then
                    cmdInsert.Parameters.Add("@diskon", MySqlDbType.Double).Value = 0
                    cmdInsert.Parameters.Add("@bayar", MySqlDbType.Double).Value = (hargaKotor + bayarItem)
                    cmdInsert.Parameters.Add("@member_id", MySqlDbType.Int16).Value = 0
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
        disPersen = 0
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

    'Public Sub autocompleteItem()
    '    editItem.AutoCompleteMode = AutoCompleteMode.Suggest
    '    editItem.AutoCompleteSource = AutoCompleteSource.CustomSource
    '    Dim dataCollections As New AutoCompleteStringCollection
    '    getItem(dataCollections)
    '    editItem.AutoCompleteCustomSource = dataCollections
    'End Sub
    'Sub getItem(ByVal dataCollection As AutoCompleteStringCollection)
    '    conn = New MySqlConnection(connString)
    '    conn.Open()

    '    Dim dr As MySqlDataReader = Nothing
    '    Dim cmdAmbil As MySqlCommand = conn.CreateCommand

    '    Try
    '        Dim sqlString As String = "select nama_item from t_singleitem;"
    '        cmdAmbil.CommandText = sqlString
    '        dr = cmdAmbil.ExecuteReader
    '        While dr.Read
    '            dataCollection.Add(dr("nama_item").ToString)
    '        End While
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        cmdAmbil.Dispose()
    '        'conn.Close()
    '        'conn = Nothing
    '    End Try
    'End Sub

    Sub calDiskonDateDB()
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
                If ((tglTerima.Text >= dr("dari")) And
                    (tglTerima.Text <= dr("sampai"))) Then
                    'Or
                    '((tglTerima.Text <= dr("dari")) And
                    '    (tglAmbil.Text <= dr("sampai"))) Then
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
                If ((CDate(tglTerima.Text) >= dr("dari")) And
                    (CDate(tglTerima.Text) <= dr("sampai"))) Then
                    'Or
                    '((tglTerima.Text <= dr("dari")) And
                    '    (tglAmbil.Text <= dr("sampai"))) Then
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


    Function getMemberID(ByVal namaMember As String) As Integer
        conn = New MySqlConnection(connString)
        conn.Open()

        Dim dr As MySqlDataReader = Nothing
        Dim cmdAmbil As MySqlCommand = conn.CreateCommand
        Dim memberID As String
        Try
            Dim sqlString As String = "select id from t_pelanggan where nama_pelanggan=@nama_pelanggan;"
            cmdAmbil.Parameters.Add("@nama_pelanggan", MySqlDbType.String, 100).Value = namaMember
            cmdAmbil.CommandText = sqlString
            dr = cmdAmbil.ExecuteReader
            If dr.Read Then
                memberID = dr("id").ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdAmbil.Dispose()
            'conn.Close()
            'conn = Nothing
        End Try
        Return memberID
    End Function

    Function cekMemberExis(ByVal name_member As String) As Boolean

        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim cmd As MySqlCommand = New MySqlCommand("SELECT IF(EXISTS (SELECT id " & _
                          "FROM t_pelanggan WHERE nama_pelanggan = @nama_pelanggan), 'Y','N')", conn)
        cmd.Parameters.AddWithValue("@nama_pelanggan", name_member)
        conn.Open()
        Dim exists As String = cmd.ExecuteScalar().ToString()
        'Console.WriteLine(exists)
        conn.Close()
        Return If(exists = "Y", True, False)
    End Function

    Private Sub btnAddItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItems.Click
        FormAddItem.Show()
    End Sub
End Class