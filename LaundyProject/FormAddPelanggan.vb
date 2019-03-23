Public Class FormAddPelanggan
    Private conn As New MySqlConnection
    Dim connString = "Database=laundryapp;data source=localhost;user id=root;password=;"

    Sub saveData()
        conn = New MySqlConnection(connString)
        conn.Open()

        Dim cmdInsert As MySqlCommand = conn.CreateCommand
        Try
            Dim sqlInsertAdd As String = "insert into t_pelanggan(nama_pelanggan,alamat,nohp) values (@nama_pelanggan,@alamat,@nohp)"

            Dim sqlStringUpdate As String = "update t_pelanggan set " & _
                "nama_laundry = @nama_pelanggan," & _
                "alamat = @alamat," & _
                "nohp = @nohp where id = @id"

            If (FormPelanggan.statusClick = "add") Then
                cmdInsert.CommandText = sqlInsertAdd
            End If

            cmdInsert.Connection = conn
            cmdInsert.Parameters.Add("@nama_pelanggan", MySqlDbType.VarChar, 100).Value = editPelanggan.Text
            cmdInsert.Parameters.Add("@alamat", MySqlDbType.Text).Value = editAlamat.Text
            cmdInsert.Parameters.Add("@nohp", MySqlDbType.VarChar, 100).Value = editNotelp.Text

            If (FormPelanggan.statusClick = "update") Then
                cmdInsert.Parameters.Add("@id", MySqlDbType.VarChar, 100).Value = editID.Text
            End If
            cmdInsert.ExecuteNonQuery()

            MessageBox.Show("Data berhasil disimpan", "Update Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        saveData()
        Me.Close()
    End Sub
End Class