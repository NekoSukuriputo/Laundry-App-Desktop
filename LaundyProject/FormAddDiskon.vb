Imports System.Globalization

Public Class FormAddDiskon
    Private conn As New MySqlConnection
    Dim connString = "Database=laundryapp;data source=localhost;user id=root;password=;"
    Public idDiskon As String = ""

    Sub saveData()
        conn = New MySqlConnection(connString)
        conn.Open()

        Dim cmdInsert As MySqlCommand = conn.CreateCommand
        Try
            Dim sqlInsertAdd As String = "insert into t_diskon(nama_diskon,diskon,dari,sampai) values (@nama_diskon,@diskon,@dari,@sampai)"

            Dim sqlStringUpdate As String = "update t_diskon set " & _
                "nama_diskon = @nama_diskon," & _
                "diskon = @diskon," & _
                "dari = @dari, " & _
                "sampai = @sampai where id = @id"

            If (FormDiskon.statusClick = "add") Then
                cmdInsert.CommandText = sqlInsertAdd
            ElseIf (FormDiskon.statusClick = "edit") Then
                cmdInsert.CommandText = sqlStringUpdate
            End If

            cmdInsert.Connection = conn
            cmdInsert.Parameters.Add("@nama_diskon", MySqlDbType.VarChar, 100).Value = editNmDiskon.Text
            cmdInsert.Parameters.Add("@diskon", MySqlDbType.Double).Value = editDiskon.Text
            cmdInsert.Parameters.Add("@dari", MySqlDbType.Date).Value = CDate(picDari.Text)
            cmdInsert.Parameters.Add("@sampai", MySqlDbType.Date).Value = CDate(picSampai.Text)


            If (FormDiskon.statusClick = "edit") Then
                cmdInsert.Parameters.Add("@id", MySqlDbType.Int16).Value = idDiskon
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
            Dim sqlString As String = "select * from t_diskon where id = @id;"
            cmdAmbil.Parameters.Add("@id", MySqlDbType.Int16).Value = idDiskon
            cmdAmbil.CommandText = sqlString
            dr = cmdAmbil.ExecuteReader
            If dr.Read Then
                editNmDiskon.Text = dr("nama_diskon").ToString
                editDiskon.Text = dr("diskon").ToString
                picDari.Text = dr("dari").ToString
                picSampai.Text = dr("sampai").ToString
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

    Private Sub FormAddDiskon_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Application.CurrentCulture = New CultureInfo("EN-US")
    End Sub

    Private Sub FormAddDiskon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (FormDiskon.statusClick = "edit") Then
            tampil()
        End If
    End Sub

End Class