Public Class FormAddPelanggan
    Private conn As New MySqlConnection
    Dim connString = "Database=laundryapp;data source=localhost;user id=root;password=;"
    Public idPel As String = ""
    Sub saveData()
        conn = New MySqlConnection(connString)
        conn.Open()

        Dim cmdInsert As MySqlCommand = conn.CreateCommand
        Try
            Dim sqlInsertAdd As String = "insert into t_pelanggan(nama_pelanggan,alamat,nohp) values (@nama_pelanggan,@alamat,@nohp)"

            Dim sqlStringUpdate As String = "update t_pelanggan set " & _
                "nama_pelanggan = @nama_pelanggan," & _
                "alamat = @alamat," & _
                "nohp = @nohp where id = @id"

            If (FormPelanggan.statusClick = "add") Then
                cmdInsert.CommandText = sqlInsertAdd
            ElseIf (FormPelanggan.statusClick = "edit") Then
                cmdInsert.CommandText = sqlStringUpdate
            End If

            cmdInsert.Connection = conn
            cmdInsert.Parameters.Add("@nama_pelanggan", MySqlDbType.VarChar, 100).Value = editPelanggan.Text
            cmdInsert.Parameters.Add("@alamat", MySqlDbType.Text).Value = editAlamat.Text
            cmdInsert.Parameters.Add("@nohp", MySqlDbType.VarChar, 100).Value = editNotelp.Text

            If (FormPelanggan.statusClick = "edit") Then
                cmdInsert.Parameters.Add("@id", MySqlDbType.Int16).Value = idPel
            End If
            cmdInsert.ExecuteNonQuery()

            MessageBox.Show("Data berhasil disimpan", "Update Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub tampil()
        conn = New MySqlConnection(connString)
        conn.Open()

        Dim dr As MySqlDataReader = Nothing
        Dim cmdAmbil As MySqlCommand = conn.CreateCommand

        Try
            Dim sqlString As String = "select * from t_pelanggan where id = @id;"
            cmdAmbil.Parameters.Add("@id", MySqlDbType.Int16).Value = idPel
            cmdAmbil.CommandText = sqlString
            dr = cmdAmbil.ExecuteReader
            If dr.Read Then
                editPelanggan.Text = dr("nama_pelanggan").ToString
                editAlamat.Text = dr("alamat").ToString
                editNotelp.Text = dr("nohp").ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdAmbil.Dispose()
            'conn.Close()
            'conn = Nothing
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        saveData()
        Me.Close()
    End Sub

    Private Sub FormAddPelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (FormPelanggan.statusClick = "edit") Then
            tampil()
        End If
    End Sub
End Class