Public Class FormAddLayanan
    Private conn As New MySqlConnection
    Dim connString = "Database=laundryapp;data source=localhost;user id=root;password=;"
    Public idLayanan As String = ""

    Sub saveData()
        conn = New MySqlConnection(connString)
        conn.Open()

        Dim cmdInsert As MySqlCommand = conn.CreateCommand
        Try
            Dim sqlInsertAdd As String = "insert into t_jenislayanan(nama_layanan,harga,lama_hari) values (@nama_layanan,@harga,@lama_hari)"

            Dim sqlStringUpdate As String = "update t_jenislayanan set " & _
                "nama_layanan = @nama_layanan," & _
                "harga = @harga," & _
                "lama_hari = @lama_hari where id = @id"

            If (FormLayanan.statusClick = "add") Then
                cmdInsert.CommandText = sqlInsertAdd
            ElseIf (FormLayanan.statusClick = "edit") Then
                cmdInsert.CommandText = sqlStringUpdate
            End If

            cmdInsert.Connection = conn
            cmdInsert.Parameters.Add("@nama_layanan", MySqlDbType.VarChar, 100).Value = editLayanan.Text
            cmdInsert.Parameters.Add("@harga", MySqlDbType.Double).Value = editHarga.Text
            cmdInsert.Parameters.Add("@lama_hari", MySqlDbType.Int16).Value = editLama.Text

            If (FormLayanan.statusClick = "edit") Then
                cmdInsert.Parameters.Add("@id", MySqlDbType.Int16).Value = idLayanan
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
            Dim sqlString As String = "select * from t_jenislayanan where id = @id;"
            cmdAmbil.Parameters.Add("@id", MySqlDbType.Int16).Value = idLayanan
            cmdAmbil.CommandText = sqlString
            dr = cmdAmbil.ExecuteReader
            If dr.Read Then
                editLayanan.Text = dr("nama_layanan").ToString
                editHarga.Text = dr("harga").ToString
                editLama.Text = dr("lama_hari").ToString
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

    Private Sub FormAddLayanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (FormLayanan.statusClick = "edit") Then
            tampil()
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub editHarga_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editHarga.TextChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub editLayanan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editLayanan.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub editLama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editLama.TextChanged

    End Sub
End Class