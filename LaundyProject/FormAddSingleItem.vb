Public Class FormAddSingleItem
    Private conn As New MySqlConnection
    Dim connString = "Database=laundryapp;data source=localhost;user id=root;password=;"
    Public idItem As String = ""

    Sub saveData()
        conn = New MySqlConnection(connString)
        conn.Open()

        Dim cmdInsert As MySqlCommand = conn.CreateCommand
        Try
            Dim sqlInsertAdd As String = "insert into t_singleitem(nama_item,harga) values (@nama_item,@harga)"

            Dim sqlStringUpdate As String = "update t_singleitem set " & _
                "nama_item = @nama_item," & _
                "harga = @harga where id = @id"

            If (FormSingelItem.statusClick = "add") Then
                cmdInsert.CommandText = sqlInsertAdd
            ElseIf (FormSingelItem.statusClick = "edit") Then
                cmdInsert.CommandText = sqlStringUpdate
            End If

            cmdInsert.Connection = conn
            cmdInsert.Parameters.Add("@nama_item", MySqlDbType.VarChar, 100).Value = editNmItem.Text
            cmdInsert.Parameters.Add("@harga", MySqlDbType.Double).Value = editHarga.Text

            If (FormSingelItem.statusClick = "edit") Then
                cmdInsert.Parameters.Add("@id", MySqlDbType.Int16).Value = idItem
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
            Dim sqlString As String = "select * from t_singleitem where id = @id;"
            cmdAmbil.Parameters.Add("@id", MySqlDbType.Int16).Value = idItem
            cmdAmbil.CommandText = sqlString
            dr = cmdAmbil.ExecuteReader
            If dr.Read Then
                editNmItem.Text = dr("nama_item").ToString
                editHarga.Text = dr("harga").ToString
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

    Private Sub FormAddSingleItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (FormSingelItem.statusClick = "edit") Then
            tampil()
        End If
    End Sub
End Class