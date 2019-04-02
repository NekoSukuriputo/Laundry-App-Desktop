Public Class FormUsers
    Private conn As New MySqlConnection
    Dim connString = "Database=laundryapp;data source=localhost;user id=root;password=;"

    Private Sub FormUsers_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        tampil()
    End Sub

    Private Sub FormUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Sub tampil()
        Dim da As New MySqlDataAdapter()
        Dim ds As New DataSet()

        conn = New MySqlConnection(connString)
        conn.Open()

        Dim cmdSelect As MySqlCommand = conn.CreateCommand()
        Dim sqlString As String

        Try
            sqlString = "select username,rule from t_users"
            cmdSelect.CommandText = sqlString
            da.SelectCommand = cmdSelect
            da.Fill(ds, "t_users")
            DGVUsers.DataSource = ds
            DGVUsers.DataMember = "t_users"
            DGVUsers.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdSelect.Dispose()
            'conn.Close()
        End Try
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        FormAddUser.Show()
    End Sub

    Private Sub DGVUsers_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVUsers.CellContentClick
        If (e.ColumnIndex = 2) Then
            'MsgBox("del")
            conn = New MySqlConnection(connString)
            conn.Open()

            If MessageBox.Show("Anda yakin akan menghapus Data dengan username :  " & DGVUsers.Rows(e.RowIndex).Cells(0).Value & " akan dihapus ? ", "Peringatan!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

                Dim cmdDelete As MySqlCommand = conn.CreateCommand
                Try
                    Dim sqlString As String = "delete from t_users where username=@username;"
                    cmdDelete.CommandText = sqlString
                    cmdDelete.Connection = conn
                    cmdDelete.Parameters.Add("@username", MySqlDbType.VarChar, 100).Value = DGVUsers.Rows(e.RowIndex).Cells(0).Value
                    cmdDelete.ExecuteNonQuery()
                    MessageBox.Show("Data Berhasil dihapus", "Delete Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    tampil()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cmdDelete.Dispose()
                    'conn.Close()
                End Try
            End If
        End If
    End Sub
End Class