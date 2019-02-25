Public Class formListOrder
    Private conn As New MySqlConnection
    Dim connString = "Database=laundryapp;data source=localhost;user id=root;password=;"

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If (e.ColumnIndex = 9) Then 'edit
            'MsgBox(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
            formUpdateOrder.nota = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            Me.Hide()
            formUpdateOrder.Show()
        End If
        If (e.ColumnIndex = 10) Then 'delete
            'MsgBox(DataGridView1.Rows(e.RowIndex).Cells(0).Value)

            conn = New MySqlConnection(connString)
            conn.Open()

            Dim cmdDelete As MySqlCommand = conn.CreateCommand
            Dim cmdDelete2 As MySqlCommand = conn.CreateCommand
            If MessageBox.Show("Anda yakin akan menghapus Data dengan Nota :  " & DataGridView1.Rows(e.RowIndex).Cells(0).Value & " akan dihapus ? ", "Peringatan!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                Try
                    Dim sqlString As String = "delete from t_order where nota=@nota;"
                    Dim sqlString2 As String = "delete from t_detailorder where nota=@nota;"

                    cmdDelete.CommandText = sqlString
                    cmdDelete2.CommandText = sqlString2

                    cmdDelete.Connection = conn
                    cmdDelete2.Connection = conn

                    cmdDelete.Parameters.Add("@nota", MySqlDbType.Int16).Value = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                    cmdDelete2.Parameters.Add("@nota", MySqlDbType.Int16).Value = DataGridView1.Rows(e.RowIndex).Cells(0).Value

                    'cmdDelete.Parameters.Add("@nota", MySqlDbType.Int16).Value = 9
                    'cmdDelete2.Parameters.Add("@nota", MySqlDbType.Int16).Value = 9

                    cmdDelete2.ExecuteNonQuery()
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

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If (e.ColumnIndex <> 10 And e.ColumnIndex <> 9) Then 'double clik to show
            formUpdateOrder.nota = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            Me.Hide()
            formDetail.Show()
        End If
    End Sub

    Private Sub formListOrder_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        tampil()
    End Sub

    Private Sub formListOrder_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub formListOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Public Sub tampil()
        Dim da As New MySqlDataAdapter()
        Dim ds As New DataSet()

        conn = New MySqlConnection(connString)
        conn.Open()

        Dim cmdSelect As MySqlCommand = conn.CreateCommand()
        Dim sqlString As String

        Try
            sqlString = "select * from t_order"
            cmdSelect.CommandText = sqlString
            da.SelectCommand = cmdSelect
            da.Fill(ds, "t_order")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "t_order"
            DataGridView1.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdSelect.Dispose()
            'conn.Close()
        End Try
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Me.Hide()
        formOrder.Show()
    End Sub

    Private Sub btncari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncari.Click
        Dim da As New MySqlDataAdapter()
        Dim ds As New DataSet()

        conn = New MySqlConnection(connString)
        conn.Open()

        Dim cmdSelect As MySqlCommand = conn.CreateCommand()
        Dim sqlString As String

        Try
            sqlString = "select * from t_order where nota=@nota"
            cmdSelect.CommandText = sqlString
            cmdSelect.Parameters.Add("@nota", MySqlDbType.Int16).Value = editCari.Text
            da.SelectCommand = cmdSelect
            da.Fill(ds, "t_order")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "t_order"
            DataGridView1.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdSelect.Dispose()
            'conn.Close()
        End Try
    End Sub

    Private Sub editCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editCari.TextChanged
        If editCari.Text = "" Then
            tampil()
        End If
    End Sub

    
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class