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
                " (nota VARCHAR(10) PRIMARY KEY, " & _
                " nama_customer VARCHAR(100), " & _
                "tgl_terima	DATE, " & _
                "berat DOUBLE, " & _
                "jenis_layanan VARCHAR(50), " & _
                "harga DOUBLE, " & _
                "progress VARCHAR(50), " & _
                "status	VARCHAR(50), " & _
                "tgl_diambil DATE);"

            Dim create_t_detailorder = "CREATE TABLE t_detailorder " & _
                " (id INT(11) AUTO_INCREMENT PRIMARY KEY, " & _
                "nota VARCHAR(10), " & _
                "nama_item VARCHAR(100), " & _
                "jumlah	INT(11));"


            Dim cmd2 As MySqlCommand = conn.CreateCommand
            Dim cmd3 As MySqlCommand = conn.CreateCommand

            cmd2.CommandText = create_t_order
            cmd3.CommandText = create_t_detailorder

            cmd2.Connection = conn
            cmd3.Connection = conn

            cmd2.ExecuteNonQuery()
            cmd3.ExecuteNonQuery()

            cmd2.Dispose()
            cmd3.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'con.Close()
        End Try

    End Sub

    Private Sub formDB_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            Me.Show()
            createDB()
            progressbarDB.Value = 10
            progressbarDB.Value = 25
            progressbarDB.Value = 35
            progressbarDB.Value = 40
            progressbarDB.Value = 47
            progressbarDB.Value = 50
            progressbarDB.Value = 57
            progressbarDB.Value = 60
            createTable()
            progressbarDB.Value = 75
            progressbarDB.Value = 85
            progressbarDB.Value = 87
            progressbarDB.Value = 90
            progressbarDB.Value = 100
            If (progressbarDB.Value = 100) Then
                If MessageBox.Show("Database Selesai Dibuat", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
                    formListOrder.Show()
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