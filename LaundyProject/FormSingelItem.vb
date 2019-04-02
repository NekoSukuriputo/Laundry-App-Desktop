Public Class FormSingelItem
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
            sqlString = "select * from t_singleitem"
            cmdSelect.CommandText = sqlString
            da.SelectCommand = cmdSelect
            da.Fill(ds, "t_singleitem")
            DGVSingleItem.DataSource = ds
            DGVSingleItem.DataMember = "t_singleitem"
            DGVSingleItem.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdSelect.Dispose()
            'conn.Close()
        End Try
    End Sub

    Private Sub FormSingelItem_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        tampil()
        If (FormLogin.rule.ToLower() <> "admin") Then
            btntambah.Visible = False
            Me.DGVSingleItem.Columns("kol_Edit").Visible = False
            Me.DGVSingleItem.Columns("kol_Hapus").Visible = False
        End If
    End Sub

    Private Sub FormSingelItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        statusClick = "add"
        FormAddSingleItem.Show()
    End Sub

    Private Sub DGVSingleItem_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVSingleItem.CellContentClick
        If (e.ColumnIndex = 3) Then 'edit
            'MsgBox("edit")
            statusClick = "edit"
            FormAddSingleItem.idItem = DGVSingleItem.Rows(e.RowIndex).Cells(0).Value
            FormAddSingleItem.Show()
        ElseIf (e.ColumnIndex = 4) Then
            'MsgBox("del")
            conn = New MySqlConnection(connString)
            conn.Open()

            If MessageBox.Show("Anda yakin akan menghapus Data dengan Nama :  " & DGVSingleItem.Rows(e.RowIndex).Cells(1).Value & " akan dihapus ? ", "Peringatan!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

                Dim cmdDelete As MySqlCommand = conn.CreateCommand
                Try
                    Dim sqlString As String = "delete from t_singleitem where id=@id;"
                    cmdDelete.CommandText = sqlString
                    cmdDelete.Connection = conn
                    cmdDelete.Parameters.Add("@id", MySqlDbType.Int16).Value = DGVSingleItem.Rows(e.RowIndex).Cells(0).Value
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