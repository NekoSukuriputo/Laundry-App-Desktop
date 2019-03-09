Imports System.Globalization

Public Class formListOrder
    Private conn As New MySqlConnection
    Dim connString = "Database=laundryapp;data source=localhost;user id=root;password=;"

    Private Sub formListOrder_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'tampil()
        Application.CurrentCulture = New CultureInfo("EN-US")
    End Sub

    Private Sub formListOrder_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Function DoesDBExist(ByVal DBConnectionString As String) As Boolean

        Dim conn As MySqlConnection = New MySqlConnection(DBConnectionString)
        Dim cmd As MySqlCommand = New MySqlCommand("SELECT IF(EXISTS (SELECT SCHEMA_NAME " & _
            "FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = @DbName), 'Y','N')", conn)
        cmd.Parameters.AddWithValue("@DbName", "laundryapp")
        conn.Open()
        Dim exists As String = cmd.ExecuteScalar().ToString()
        'Console.WriteLine(exists)
        conn.Close()
        Return If(exists = "Y", True, False)

    End Function

    Private Sub formListOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (DoesDBExist("data source=localhost;user id=root;password=;")) Then
            'MsgBox("ada")
            tampil()
        Else
            formDB.Show()
        End If
        'tampil()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If (e.ColumnIndex = 9) Then 'edit
            'MsgBox(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
            formUpdateOrder.nota = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            'Me.Hide()
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
            'Me.Hide()
            formDetail.Show()
        End If
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


    Private Function isLimited() As Boolean
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim cmd As MySqlCommand = New MySqlCommand("SELECT IF((SELECT COUNT(nota)" & _
                "FROM t_order) >= 50, 'Y','N')", conn)
        conn.Open()
        Dim limited As String = cmd.ExecuteScalar().ToString()
        'Console.WriteLine(limited)
        conn.Dispose()
        'conn.Close()
        Return If(limited = "Y", True, False)
    End Function

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        If (isLimited()) Then
            MsgBox("Batasan insert telah terlampaui hapus beberapa data atau seluruh data")
        Else
            formOrder.Show()
        End If
        'Me.Hide()
        'formOrder.Show()
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


    'Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

    'Public Sub New()

    '    ' This call is required by the designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.

    'End Sub

    Private Sub btnDelTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelTable.Click
        conn = New MySqlConnection(connString)
        conn.Open()

        Dim cmdDelete As MySqlCommand = conn.CreateCommand
        Dim cmdDelete2 As MySqlCommand = conn.CreateCommand
        If MessageBox.Show("Menekan Tombol Delete Akan Menghapus SEMUA DATA"& vbNewLine &
                           "Anda yakin akan menghapus SEMUA DATA !!!  ", "Peringatan!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Try
                Dim sqlString As String = "TRUNCATE TABLE t_order;"
                Dim sqlString2 As String = "TRUNCATE TABLE t_detailorder;"

                cmdDelete.CommandText = sqlString
                cmdDelete2.CommandText = sqlString2

                cmdDelete.Connection = conn
                cmdDelete2.Connection = conn

                cmdDelete2.ExecuteNonQuery()
                cmdDelete.ExecuteNonQuery()

                MessageBox.Show("Semua Data Berhasil dihapus", "Delete All Order", MessageBoxButtons.OK, MessageBoxIcon.Information)

                tampil()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cmdDelete.Dispose()
                'conn.Close()
            End Try
        End If
    End Sub
End Class