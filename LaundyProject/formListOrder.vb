Imports System.Globalization
Imports System.IO
Imports Microsoft.Office.Interop

Public Class formListOrder
    Private conn As New MySqlConnection
    Dim connString = "Database=laundryapp;data source=localhost;user id=root;password=;"

    Private Sub formListOrder_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        tampil()
        Application.CurrentCulture = New CultureInfo("EN-US")
        If (FormLogin.rule.ToLower() <> "admin") Then
            SettingsToolStripMenuItem.Visible = False
            UsersToolStripMenuItem.Visible = False
            ReportToolStripMenuItem.Visible = False
        End If
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
        'If (DoesDBExist("data source=localhost;user id=root;password=;")) Then
        '    'MsgBox("ada")
        '    tampil()
        'Else
        '    formDB.Show()
        'End If
        tampil()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If (e.ColumnIndex = 12) Then 'edit
            'MsgBox(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
            formUpdateOrder.nota = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            'Me.Hide()
            formUpdateOrder.Show()
        End If
        If (e.ColumnIndex = 13) Then 'delete
            'MsgBox(DataGridView1.Rows(e.RowIndex).Cells(0).Value)

            conn = New MySqlConnection(connString)
            conn.Open()

            Dim cmdDelete As MySqlCommand = conn.CreateCommand
            Dim cmdDelete2 As MySqlCommand = conn.CreateCommand
            Dim cmdDelete3 As MySqlCommand = conn.CreateCommand
            If MessageBox.Show("Anda yakin akan menghapus Data dengan Nota :  " & DataGridView1.Rows(e.RowIndex).Cells(0).Value & " akan dihapus ? ", "Peringatan!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                Try
                    Dim sqlString As String = "delete from t_order where nota=@nota;"
                    Dim sqlString2 As String = "delete from t_detailorder where nota=@nota;"
                    Dim sqlString3 As String = "delete from t_order_single_item where nota=@nota;"

                    cmdDelete.CommandText = sqlString
                    cmdDelete2.CommandText = sqlString2
                    cmdDelete3.CommandText = sqlString3

                    cmdDelete.Connection = conn
                    cmdDelete2.Connection = conn
                    cmdDelete3.Connection = conn

                    cmdDelete.Parameters.Add("@nota", MySqlDbType.Int16).Value = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                    cmdDelete2.Parameters.Add("@nota", MySqlDbType.Int16).Value = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                    cmdDelete3.Parameters.Add("@nota", MySqlDbType.Int16).Value = DataGridView1.Rows(e.RowIndex).Cells(0).Value


                    'cmdDelete.Parameters.Add("@nota", MySqlDbType.Int16).Value = 9
                    'cmdDelete2.Parameters.Add("@nota", MySqlDbType.Int16).Value = 9

                    cmdDelete3.ExecuteNonQuery()
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
            sqlString = "SELECT nota,nama_customer,status_member," & _
                "tgl_terima,tgl_diambil,jenis_layanan,berat, harga, diskon, bayar, progress ,status FROM t_order;"
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
            sqlString = "SELECT nota,nama_customer,status_member," & _
                "tgl_terima,tgl_diambil,jenis_layanan,berat, harga, diskon, bayar, progress ,status FROM t_order "
            If cmbFilter.Text = "Nota" Then
                sqlString &= " WHERE nota=@where;"
            ElseIf cmbFilter.Text = "Nama Pelanggan" Then
                sqlString &= " WHERE nama_customer=@where;"
            ElseIf cmbFilter.Text = "Tanggal Terima" Then
                sqlString &= " WHERE tgl_terima=@where;"
            ElseIf cmbFilter.Text = "Tanggal Ambil" Then
                sqlString &= " WHERE tgl_diambil=@where;"
            ElseIf cmbFilter.Text = "Jenis Layanan" Then
                sqlString &= " WHERE jenis_layanan=@where;"
            End If
            cmdSelect.CommandText = sqlString
            If cmbFilter.Text = "Nota" Then
                cmdSelect.Parameters.Add("@where", MySqlDbType.Int16).Value = editCari.Text
            ElseIf cmbFilter.Text = "Nama Pelanggan" Then
                cmdSelect.Parameters.Add("@where", MySqlDbType.VarChar, 100).Value = editCari.Text
            ElseIf cmbFilter.Text = "Tanggal Terima" Then
                cmdSelect.Parameters.Add("@where", MySqlDbType.Date, 100).Value = tglFilter.Text
            ElseIf cmbFilter.Text = "Tanggal Ambil" Then
                cmdSelect.Parameters.Add("@where", MySqlDbType.Date, 100).Value = tglFilter.Text
            ElseIf cmbFilter.Text = "Jenis Layanan" Then
                cmdSelect.Parameters.Add("@where", MySqlDbType.VarChar, 100).Value = cmbFilterLayanan.Text
            End If
            da.SelectCommand = cmdSelect
            da.Fill(ds, "t_order")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "t_order"
            DataGridView1.ReadOnly = True
            cmbFilterLayanan.Items.Clear()
            fillDropDownLayanan()
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
        Dim cmdDelete3 As MySqlCommand = conn.CreateCommand
        If MessageBox.Show("Menekan Tombol Delete Akan Menghapus SEMUA DATA" & vbNewLine &
                           "Anda yakin akan menghapus SEMUA DATA !!!  ", "Peringatan!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Try
                Dim sqlString As String = "TRUNCATE TABLE t_order;"
                Dim sqlString2 As String = "TRUNCATE TABLE t_detailorder;"
                Dim sqlString3 As String = "TRUNCATE TABLE t_order_single_item;"

                cmdDelete.CommandText = sqlString
                cmdDelete2.CommandText = sqlString2
                cmdDelete3.CommandText = sqlString3

                cmdDelete.Connection = conn
                cmdDelete2.Connection = conn
                cmdDelete3.Connection = conn

                cmdDelete3.ExecuteNonQuery()
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

    Private Sub LayananToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LayananToolStripMenuItem.Click
        FormLayanan.Show()
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PelangganToolStripMenuItem.Click
        FormPelanggan.Show()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        FormSettings.Show()
    End Sub

    Private Sub HargaItemTetapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HargaItemTetapToolStripMenuItem.Click
        FormSingelItem.Show()
    End Sub

    Private Sub DiskonToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiskonToolStripMenuItem.Click
        FormDiskon.Show()
    End Sub

    Private Sub UsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersToolStripMenuItem.Click
        FormUsers.Show()
    End Sub

    Private Sub cmbFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFilter.SelectedIndexChanged, cmbFilterLayanan.SelectedIndexChanged
        If cmbFilter.Text = "Nota" Then
            editCari.Visible = True
            tglFilter.Visible = False
            cmbFilterLayanan.Visible = False
            cmbFilterLayanan.Items.Clear()
        ElseIf cmbFilter.Text = "Nama Pelanggan" Then
            editCari.Visible = True
            tglFilter.Visible = False
            cmbFilterLayanan.Visible = False
            cmbFilterLayanan.Items.Clear()
        ElseIf cmbFilter.Text = "Tanggal Terima" Then
            editCari.Visible = False
            tglFilter.Visible = True
            cmbFilterLayanan.Visible = False
            cmbFilterLayanan.Items.Clear()
        ElseIf cmbFilter.Text = "Tanggal Ambil" Then
            editCari.Visible = False
            tglFilter.Visible = True
            cmbFilterLayanan.Visible = False
            cmbFilterLayanan.Items.Clear()
        ElseIf cmbFilter.Text = "Jenis Layanan" Then
            editCari.Visible = False
            tglFilter.Visible = False
            cmbFilterLayanan.Visible = True
            'cmbFilterLayanan.Items.Clear()
            fillDropDownLayanan()
        End If
    End Sub

    Sub fillDropDownLayanan()
        conn = New MySqlConnection(connString)
        conn.Open()

        Dim dr As MySqlDataReader = Nothing
        Dim cmdAmbil As MySqlCommand = conn.CreateCommand

        Try
            Dim sqlString As String = "select nama_layanan from t_jenislayanan;"
            cmdAmbil.CommandText = sqlString
            dr = cmdAmbil.ExecuteReader
            While dr.Read
                cmbFilterLayanan.Items.Add(dr.Item("nama_layanan").ToString)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, "terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdAmbil.Dispose()
            'conn.Close()
            'conn = Nothing
        End Try
    End Sub

    Private Sub btnAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAll.Click
        tampil()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportToolStripMenuItem.Click
        FormReport.Show()
    End Sub
End Class