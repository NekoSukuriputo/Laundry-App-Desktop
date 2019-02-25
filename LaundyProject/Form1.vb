Public Class formOrder
    Private conn As New MySqlConnection
    Dim connString = "Database=laundryapp;Data source=localhost;user id=root;password=;"

    Private noNota%, newNota$

    Private Sub formOrder_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        editNama.Clear()
        editBerat.Clear()
        editHarga.Clear()
        getNewNota()
    End Sub

    Private Sub formOrder_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub formOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getNewNota()
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
            conn.Close()
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
            status = rbSudahBayar.Text
        End If

        conn = New MySqlConnection(connString)
        conn.Open()

        Dim cmdInsert As MySqlCommand = conn.CreateCommand

        If editNama.Text <> "" And tglTerima.Text <> "" And editBerat.Text <> "" And editHarga.Text <> "" Then
            Try
                Dim sqlString As String = "insert into t_order(nota,nama_customer,tgl_terima,berat,jenis_layanan,harga,progress,status,tgl_diambil)" & _
                    " values " & _
                    "(@nota,@nama,@tglterima,@berat,@jenis_layanan,@harga,@progress,@status,@tgl_ambil);"
                cmdInsert.CommandText = sqlString
                cmdInsert.Connection = conn
                cmdInsert.Parameters.Add("@nota", MySqlDbType.VarChar, 10).Value = newNota
                cmdInsert.Parameters.Add("@nama", MySqlDbType.VarChar, 100).Value = editNama.Text
                cmdInsert.Parameters.Add("@tglterima", MySqlDbType.Date).Value = tglTerima.Text
                cmdInsert.Parameters.Add("@berat", MySqlDbType.Double).Value = editBerat.Text
                cmdInsert.Parameters.Add("@jenis_layanan", MySqlDbType.VarChar, 50).Value = jenislyn
                cmdInsert.Parameters.Add("@harga", MySqlDbType.Double).Value = editHarga.Text
                cmdInsert.Parameters.Add("@progress", MySqlDbType.VarChar, 50).Value = progress
                cmdInsert.Parameters.Add("@status", MySqlDbType.VarChar, 50).Value = status
                cmdInsert.Parameters.Add("@tgl_ambil", MySqlDbType.Date).Value = tglTerima.Text
                cmdInsert.ExecuteNonQuery()

                MessageBox.Show("Data berhasil ditambahkan", "Create Order", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If MsgBoxResult.Ok Then
                    getLastNota()
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

    Private Sub editBerat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editBerat.TextChanged
        If (editBerat.Text <> "" And editBerat.Text <> "0") Then
            Dim harga As Double
            If (rbStandart.Checked) Then
                harga = 5000 * CDbl(editBerat.Text)
            ElseIf (rbExpress.Checked) Then
                harga = 8000 * CDbl(editBerat.Text)
            End If
            editHarga.Text = CStr(harga)
        Else
            editHarga.Text = "0"
        End If

    End Sub

    Private Sub rbStandart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbStandart.CheckedChanged
        If (editBerat.Text <> "" And editBerat.Text <> "0") Then
            Dim harga As Double
            harga = 5000 * CDbl(editBerat.Text)
            editHarga.Text = CStr(harga)
        Else
            editHarga.Text = "0"
        End If
        
    End Sub

    Private Sub rbExpress_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbExpress.CheckedChanged
        If (editBerat.Text <> "" And editBerat.Text <> "0") Then
            Dim harga As Double
            harga = 8000 * CDbl(editBerat.Text)
            editHarga.Text = CStr(harga)
        Else
            editHarga.Text = "0"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        formListOrder.Show()
    End Sub
End Class

