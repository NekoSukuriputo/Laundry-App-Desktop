Public Class FormSettings
    Private conn As New MySqlConnection
    Dim connString = "Database=laundryapp;data source=localhost;user id=root;password=;"

    Sub updateData()
        conn = New MySqlConnection(connString)
        conn.Open()

        Dim cmdInsert As MySqlCommand = conn.CreateCommand
        Try
            Dim sqlString As String = "update t_settings set " & _
                "nama_laundry = @nama_laundry," & _
                "alamat = @alamat," & _
                "notelp = @notelp," & _
                "footer_print = @footer_print where id = 1"
            cmdInsert.CommandText = sqlString
            cmdInsert.Connection = conn
            cmdInsert.Parameters.Add("@nama_laundry", MySqlDbType.VarChar, 100).Value = editNmLaundry.Text
            cmdInsert.Parameters.Add("@alamat", MySqlDbType.Text).Value = editAlamat.Text
            cmdInsert.Parameters.Add("@notelp", MySqlDbType.VarChar, 100).Value = editnotelp.Text
            cmdInsert.Parameters.Add("@footer_print", MySqlDbType.VarChar, 100).Value = editFooter.Text
            cmdInsert.ExecuteNonQuery()

            MessageBox.Show("Data berhasil diUbah", "Update Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            Dim sqlString As String = "select * from t_settings where id = 1;"
            cmdAmbil.CommandText = sqlString
            dr = cmdAmbil.ExecuteReader
            If dr.Read Then
                editNmLaundry.Text = dr("nama_laundry").ToString
                editAlamat.Text = dr("alamat").ToString
                editnotelp.Text = dr("notelp").ToString
                editFooter.Text = dr("footer_print").ToString
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
        updateData()
        Application.DoEvents()
        tampil()
    End Sub

    Private Sub FormSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
    End Sub
End Class