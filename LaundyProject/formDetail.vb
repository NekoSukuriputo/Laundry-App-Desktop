Public Class formDetail

    Private conn As New MySqlConnection
    Dim connString = "Database=laundryapp;Data source=localhost;user id=root;password=;"

    Private Sub formDetail_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        tampil()
        showItem()

    End Sub

    Private Sub formDetail_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub formDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
        showItem()
    End Sub

    Sub tampil()

        conn = New MySqlConnection(connString)
        conn.Open()

        Dim dr As MySqlDataReader = Nothing
        Dim cmdAmbil As MySqlCommand = conn.CreateCommand
        Try
            Dim sqlString As String = "select * from t_order where nota = @nota;"
            cmdAmbil.Parameters.Add("@nota", MySqlDbType.Int16).Value = formUpdateOrder.nota
            'cmdAmbil.Parameters.Add("@nota", MySqlDbType.Int16).Value = "8"
            cmdAmbil.CommandText = sqlString
            dr = cmdAmbil.ExecuteReader
            If dr.Read Then
                txtNota.Text = dr("nota").ToString
                txtNama.Text = dr("nama_customer").ToString
                txtTerima.Text = CType(dr("tgl_terima").ToString, DateTime).ToShortDateString
                txtBerat.Text = dr("berat").ToString
                txtJenisLayanan.Text = dr("jenis_layanan").ToString
                txtHarga.Text = dr("harga").ToString
                txtProgress.Text = dr("progress").ToString
                txtStatus.Text = dr("status").ToString
                txtAmbil.Text = CType(dr("tgl_diambil").ToString, DateTime).ToShortDateString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdAmbil.Dispose()
            'conn.Close()
        End Try

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
            cmdSelect.Parameters.Add("@nota", MySqlDbType.Int16).Value = formUpdateOrder.nota
            'cmdSelect.Parameters.Add("@nota", MySqlDbType.Int16).Value = 9

            cmdSelect.CommandText = sqlString
            da.SelectCommand = cmdSelect
            da.Fill(ds, "t_detailorder")
            gridDetail.DataSource = ds
            gridDetail.DataMember = "t_detailorder"
            gridDetail.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdSelect.Dispose()
            'conn.Close()
        End Try
    End Sub

    Private Sub Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update.Click
        formUpdateOrder.nota = txtNota.Text
        formUpdateOrder.Show()
        Me.Hide()
    End Sub

    Private Sub Hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hapus.Click
        conn = New MySqlConnection(connString)
        conn.Open()

        Dim cmdDelete As MySqlCommand = conn.CreateCommand
        Dim cmdDelete2 As MySqlCommand = conn.CreateCommand
        If MessageBox.Show("Anda yakin akan menghapus Data dengan Nota :  " & txtNota.Text & " akan dihapus ? ", "Peringatan!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Try
                Dim sqlString As String = "delete from t_order where nota=@nota;"
                Dim sqlString2 As String = "delete from t_detailorder where nota=@nota;"

                cmdDelete.CommandText = sqlString
                cmdDelete2.CommandText = sqlString2

                cmdDelete.Connection = conn
                cmdDelete2.Connection = conn

                cmdDelete.Parameters.Add("@nota", MySqlDbType.Int16).Value = txtNota.Text
                cmdDelete2.Parameters.Add("@nota", MySqlDbType.Int16).Value = txtNota.Text

                'cmdDelete.Parameters.Add("@nota", MySqlDbType.Int16).Value = 9
                'cmdDelete2.Parameters.Add("@nota", MySqlDbType.Int16).Value = 9

                cmdDelete2.ExecuteNonQuery()
                cmdDelete.ExecuteNonQuery()

                MessageBox.Show("Data Berhasil dihapus", "Delete Order", MessageBoxButtons.OK, MessageBoxIcon.Information)

                formListOrder.Show()
                Me.Hide()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cmdDelete.Dispose()
                conn.Close()
            End Try
        End If
            
    End Sub

    Private Sub btnFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinish.Click
        Me.Hide()
        formUpdateOrder.nota = ""
        formListOrder.Show()
    End Sub
End Class