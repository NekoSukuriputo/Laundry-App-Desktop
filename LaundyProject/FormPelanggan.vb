Public Class FormPelanggan

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
            sqlString = "select * from t_pelanggan"
            cmdSelect.CommandText = sqlString
            da.SelectCommand = cmdSelect
            da.Fill(ds, "t_pelanggan")
            DGVPelanggan.DataSource = ds
            DGVPelanggan.DataMember = "t_pelanggan"
            DGVPelanggan.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdSelect.Dispose()
            'conn.Close()
        End Try
    End Sub

    Private Sub FormPelanggan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        tampil()
    End Sub

    Private Sub FormPelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        statusClick = "add"
        FormAddPelanggan.Show()
    End Sub

    Private Sub DGVPelanggan_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVPelanggan.CellContentClick
        If (e.ColumnIndex = 4) Then 'edit
            'MsgBox("edit")
        ElseIf (e.ColumnIndex = 5) Then
            'MsgBox("del")
        End If
    End Sub
End Class