Public Class FormDiskon
    Private conn As New MySqlConnection
    Dim connString = "Database=laundryapp;data source=localhost;user id=root;password=;"
    Public statusClick As String = ""

    Sub tampil()
        Dim da As New MySqlDataAdapter()
        Dim ds As New DataSet()

        conn = New MySqlConnection(connString)
        conn.Open()

        Dim cmdSelect As MySqlCommand = conn.CreateCommand()
        Dim sqlString As String

        Try
            sqlString = "select * from t_diskon"
            cmdSelect.CommandText = sqlString
            da.SelectCommand = cmdSelect
            da.Fill(ds, "t_diskon")
            DGVDiskon.DataSource = ds
            DGVDiskon.DataMember = "t_diskon"
            DGVDiskon.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdSelect.Dispose()
            'conn.Close()
        End Try
    End Sub

    Private Sub FormDiskon_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        tampil()
    End Sub

    Private Sub FormDiskon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        statusClick = "add"
        FormAddDiskon.Show()
    End Sub

    Private Sub DGVDiskon_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVDiskon.CellContentClick
        If (e.ColumnIndex = 5) Then 'edit
            'MsgBox("edit")
            statusClick = "edit"
            FormAddDiskon.idDIskon = DGVDiskon.Rows(e.RowIndex).Cells(0).Value
            FormAddDiskon.Show()
        ElseIf (e.ColumnIndex = 6) Then
            'MsgBox("del")
            conn = New MySqlConnection(connString)
            conn.Open()

            If MessageBox.Show("Anda yakin akan menghapus Data dengan Nama :  " & DGVDiskon.Rows(e.RowIndex).Cells(1).Value & " akan dihapus ? ", "Peringatan!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

                Dim cmdDelete As MySqlCommand = conn.CreateCommand
                Try
                    Dim sqlString As String = "delete from t_diskon where id=@id;"
                    cmdDelete.CommandText = sqlString
                    cmdDelete.Connection = conn
                    cmdDelete.Parameters.Add("@id", MySqlDbType.Int16).Value = DGVDiskon.Rows(e.RowIndex).Cells(0).Value
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