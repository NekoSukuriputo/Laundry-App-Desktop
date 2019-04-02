Public Class formDB
    Dim connString = "Database=laundryapp;data source=localhost;user id=root;password=;"
    Private conn As New MySqlConnection

    Private Sub createDB()
        Dim stringcon As String = "data source=localhost;user id=root;password=;"
        Dim con As MySqlConnection = New MySqlConnection(stringcon)
        Try
            con.Open()
            Dim createDB = "CREATE DATABASE laundryapp;"
            Dim cmd1 As MySqlCommand = con.CreateCommand
            cmd1.CommandText = createDB
            cmd1.Connection = con
            cmd1.ExecuteNonQuery()
            cmd1.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub createTable()
        Try
            conn = New MySqlConnection(connString)
            conn.Open()

            Dim create_t_order = "CREATE TABLE t_order " & _
                "(nota VARCHAR(10) PRIMARY KEY, " & _
                "nama_customer VARCHAR(100), " & _
                "status_member VARCHAR(100), " & _
                "member_id int(11), " & _
                "tgl_terima	DATE, " & _
                "berat DOUBLE, " & _
                "jenis_layanan VARCHAR(50), " & _
                "harga DOUBLE, " & _
                "diskon DOUBLE, " & _
                "bayar DOUBLE, " & _
                "progress VARCHAR(50), " & _
                "status	VARCHAR(50), " & _
                "tgl_diambil DATE);"

            Dim create_t_detailorder = "CREATE TABLE t_detailorder " & _
                "(id INT(11) AUTO_INCREMENT PRIMARY KEY, " & _
                "nota VARCHAR(10), " & _
                "nama_item VARCHAR(100), " & _
                "jumlah	INT(11));"

            Dim create_t_diskon = "CREATE TABLE t_diskon " & _
                "(id INT(11) AUTO_INCREMENT PRIMARY KEY, " & _
                "nama_diskon VARCHAR(100), " & _
                "diskon DOUBLE, " & _
                "dari DATE, " & _
                "sampai DATE);"

            Dim create_t_jenislayanan = "CREATE TABLE t_jenislayanan " & _
                "(id INT(11) AUTO_INCREMENT PRIMARY KEY, " & _
                "nama_layanan VARCHAR(100), " & _
                "harga DOUBLE, " & _
                "lama_hari INT(11));"

            Dim create_t_order_single_item = "CREATE TABLE t_order_single_item " & _
                "(id INT(11) AUTO_INCREMENT PRIMARY KEY, " & _
                "nota VARCHAR(10), " & _
                "singleitem_id INT(11), " & _
                "jumlah DOUBLE);"

            Dim create_t_pelanggan = "CREATE TABLE t_pelanggan " & _
                "(id INT(11) AUTO_INCREMENT PRIMARY KEY, " & _
                "nama_pelanggan VARCHAR(50), " & _
                "alamat TEXT, " & _
                "nohp TEXT);"

            Dim create_t_settings = "CREATE TABLE t_settings " & _
                "(id INT(11) AUTO_INCREMENT PRIMARY KEY, " & _
                "nama_laundry VARCHAR(100), " & _
                "alamat TEXT, " & _
                "notelp TEXT, " & _
                "footer_print TEXT);"

            Dim create_t_singleitem = "CREATE TABLE t_singleitem " & _
                "(id INT(11) AUTO_INCREMENT PRIMARY KEY, " & _
                "nama_item VARCHAR(100), " & _
                "harga DOUBLE);"

            Dim create_t_users = "CREATE TABLE t_users " & _
                "(username VARCHAR(100) PRIMARY KEY, " & _
                "password TEXT, " & _
                "rule VARCHAR(100));"

            Dim vw_single_item = "CREATE VIEW vw_single_item as " & _
            "SELECT t_order_single_item.id,t_order_single_item.nota, t_singleitem.nama_item, t_order_single_item.jumlah " & _
            "from t_singleitem INNER JOIN t_order_single_item on t_order_single_item.singleitem_id = t_singleitem.id;"

            Dim insert_setting = "INSERT INTO t_settings (nama_laundry, alamat, notelp, footer_print) VALUES " & _
            "('Laundyku', 'Padang', '98765', 'terimakasih');"

            Dim insert_user = "INSERT INTO `t_users` (`username`, `password`, `rule`) VALUES " & _
            "('admin', 'KzSLwSJta2K+uHgt2pOLnw==', 'Admin');"

            Dim cmd1 As MySqlCommand = conn.CreateCommand
            Dim cmd2 As MySqlCommand = conn.CreateCommand
            Dim cmd3 As MySqlCommand = conn.CreateCommand
            Dim cmd4 As MySqlCommand = conn.CreateCommand
            Dim cmd5 As MySqlCommand = conn.CreateCommand
            Dim cmd6 As MySqlCommand = conn.CreateCommand
            Dim cmd7 As MySqlCommand = conn.CreateCommand
            Dim cmd8 As MySqlCommand = conn.CreateCommand
            Dim cmd9 As MySqlCommand = conn.CreateCommand
            Dim cmd10 As MySqlCommand = conn.CreateCommand
            Dim cmd11 As MySqlCommand = conn.CreateCommand
            Dim cmd12 As MySqlCommand = conn.CreateCommand

            cmd1.CommandText = create_t_order
            cmd2.CommandText = create_t_detailorder
            cmd3.CommandText = create_t_diskon
            cmd4.CommandText = create_t_jenislayanan
            cmd5.CommandText = create_t_order_single_item
            cmd6.CommandText = create_t_pelanggan
            cmd7.CommandText = create_t_settings
            cmd8.CommandText = create_t_singleitem
            cmd9.CommandText = create_t_users
            cmd10.CommandText = vw_single_item
            cmd11.CommandText = insert_setting
            cmd12.CommandText = insert_user

            cmd1.Connection = conn
            cmd2.Connection = conn
            cmd3.Connection = conn
            cmd4.Connection = conn
            cmd5.Connection = conn
            cmd6.Connection = conn
            cmd7.Connection = conn
            cmd8.Connection = conn
            cmd9.Connection = conn
            cmd10.Connection = conn
            cmd11.Connection = conn
            cmd12.Connection = conn

            cmd1.ExecuteNonQuery()
            cmd2.ExecuteNonQuery()
            cmd3.ExecuteNonQuery()
            cmd4.ExecuteNonQuery()
            cmd5.ExecuteNonQuery()
            cmd6.ExecuteNonQuery()
            cmd7.ExecuteNonQuery()
            cmd8.ExecuteNonQuery()
            cmd9.ExecuteNonQuery()
            cmd10.ExecuteNonQuery()
            cmd11.ExecuteNonQuery()
            cmd12.ExecuteNonQuery()

            cmd1.Dispose()
            cmd2.Dispose()
            cmd3.Dispose()
            cmd4.Dispose()
            cmd5.Dispose()
            cmd6.Dispose()
            cmd7.Dispose()
            cmd8.Dispose()
            cmd9.Dispose()
            cmd10.Dispose()
            cmd11.Dispose()
            cmd12.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'con.Close()
        End Try

    End Sub

    Private Sub formDB_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            Me.Show()
            progressbarDB.Value = 10
            createDB()
            Application.DoEvents()
            progressbarDB.Value = 25
            progressbarDB.Value = 35
            Application.DoEvents()
            progressbarDB.Value = 40
            progressbarDB.Value = 47
            progressbarDB.Value = 50
            Application.DoEvents()
            progressbarDB.Value = 57
            progressbarDB.Value = 60
            createTable()
            Application.DoEvents()
            progressbarDB.Value = 75
            progressbarDB.Value = 85
            progressbarDB.Value = 90
            progressbarDB.Value = 100
            If (progressbarDB.Value = 100) Then
                If MessageBox.Show("Database Selesai Dibuat", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
                    FormLogin.Show()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub formDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If MessageBox.Show("Database Tidak Ditemukan" & vbNewLine & "Database Akan Dibuat Secara Otomatis", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            'MsgBox("tidakada")
        End If
    End Sub
End Class