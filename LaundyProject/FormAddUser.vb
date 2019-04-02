Public Class FormAddUser
    Private conn As New MySqlConnection
    Dim connString = "Database=laundryapp;data source=localhost;user id=root;password=;"

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        saveData()
    End Sub

    Sub saveData()
        conn = New MySqlConnection(connString)
        conn.Open()

        Dim cmdInsert As MySqlCommand = conn.CreateCommand
        Dim wrapper As New EncriptClass("abdulrahmat97")
        Dim encPass As String = wrapper.EncryptData(editPassword.Text)
        Try
            Dim sqlInsertAdd As String = "insert into t_users(username,password,rule) values (@username,@password,@rule)"

            cmdInsert.CommandText = sqlInsertAdd

            cmdInsert.Connection = conn
            cmdInsert.Parameters.Add("@username", MySqlDbType.VarChar, 100).Value = editUsername.Text
            cmdInsert.Parameters.Add("@password", MySqlDbType.Text).Value = encPass
            cmdInsert.Parameters.Add("@rule", MySqlDbType.VarChar, 100).Value = cmbRule.Text

            cmdInsert.ExecuteNonQuery()

            MessageBox.Show("Data berhasil disimpan", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Close()
    End Sub
End Class