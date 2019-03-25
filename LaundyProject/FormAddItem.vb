Public Class FormAddItem
    Private conn As New MySqlConnection
    Dim connString = "Database=laundryapp;Data source=localhost;user id=root;password=;"

    Private Sub FormAddItem_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        showItem()
        showItemSingle()
    End Sub
    Private Sub FormAddItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showItem()
        showItemSingle()
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        conn = New MySqlConnection(connString)
        conn.Open()

        Dim cmdInsert As MySqlCommand = conn.CreateCommand
        If (editItem.Text <> "" And editJumlah.Text <> "") Then
            Try
                Dim sqlString As String = "insert into t_detailorder(nota,nama_item,jumlah)" & _
                    " values " & _
                    "(@nota,@item,@jumlah);"
                cmdInsert.CommandText = sqlString
                cmdInsert.Connection = conn
                cmdInsert.Parameters.Add("@nota", MySqlDbType.VarChar, 100).Value = formUpdateOrder.txtNota.Text
                'cmdInsert.Parameters.Add("@nota", MySqlDbType.VarChar, 100).Value = 9
                cmdInsert.Parameters.Add("@item", MySqlDbType.VarChar, 100).Value = editItem.Text
                cmdInsert.Parameters.Add("@jumlah", MySqlDbType.Int16).Value = editJumlah.Text
                cmdInsert.ExecuteNonQuery()
                'MessageBox.Show("Data berhasil ditambahkan", "Create Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
                editItem.Clear()
                editJumlah.Clear()
                showItem()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Terjadi kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
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
            gridItem.DataSource = ds
            gridItem.DataMember = "t_detailorder"
            gridItem.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdSelect.Dispose()
            conn.Close()
        End Try
    End Sub

    Sub showItemSingle()
        Dim da As New MySqlDataAdapter()
        Dim ds As New DataSet()

        conn = New MySqlConnection(connString)
        conn.Open()

        Dim cmdSelect As MySqlCommand = conn.CreateCommand()
        Dim sqlString As String

        Try
            sqlString = "Select nama_item,jumlah from vw_single_item where nota=@nota;"
            cmdSelect.Parameters.Add("@nota", MySqlDbType.VarChar, 50).Value = formUpdateOrder.nota
            'cmdSelect.Parameters.Add("@nota", MySqlDbType.Int16).Value = 9

            cmdSelect.CommandText = sqlString
            da.SelectCommand = cmdSelect
            da.Fill(ds, "vw_single_item")
            gridItem.DataSource = ds
            gridItem.DataMember = "vw_single_item"
            gridItem.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdSelect.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub gridItem_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridItem.CellContentClick
        If (e.ColumnIndex = 3) Then
            Dim id As Integer = gridItem.Rows(e.RowIndex).Cells(0).Value
            'MsgBox(gridItem.Rows(e.RowIndex).Cells(0).Value)

            conn = New MySqlConnection(connString)
            conn.Open()

            Dim cmdDel As MySqlCommand = conn.CreateCommand
            Try
                Dim sqlString As String = "delete from t_detailorder where id=@id;"
                cmdDel.CommandText = sqlString
                cmdDel.Connection = conn
                cmdDel.Parameters.Add("@id", MySqlDbType.Int16).Value = id
                cmdDel.ExecuteNonQuery()
                'MessageBox.Show("Data berhasil ditambahkan", "Create Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
                showItem()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Terjadi kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class