Public Class FormLogin
    Private conn As New MySqlConnection
    Dim connString = "Database=laundryapp;Data source=localhost;user id=root;password=;"
    Public username$ = "", pass$ = "", rule$ = ""
    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (DoesDBExist("data source=localhost;user id=root;password=;")) Then
            'MsgBox("ada")
        Else
            formDB.Show()
        End If
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

    Sub getData(ByVal user As String, ByVal password As String)
        conn = New MySqlConnection(connString)
        conn.Open()

        Dim dr As MySqlDataReader = Nothing
        Dim cmdAmbil As MySqlCommand = conn.CreateCommand

        Try
            Dim sqlString As String = "select username,password,rule from t_users where username=@username;"
            cmdAmbil.Parameters.Add("@username", MySqlDbType.VarChar, 100).Value = user
            cmdAmbil.CommandText = sqlString
            dr = cmdAmbil.ExecuteReader
            If dr.Read Then
                username = dr("username").ToString
                pass = dr("password").ToString
                rule = dr("rule").ToString
            Else
                username = ""
                pass = ""
                rule = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "terjadi Kegagalan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdAmbil.Dispose()
            'conn.Close()
            'conn = Nothing
        End Try
    End Sub

    Function cekUsernameExis(ByVal user_name As String) As Boolean

        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim cmd As MySqlCommand = New MySqlCommand("SELECT IF(EXISTS (SELECT username " & _
                          "FROM t_users WHERE username = @username), 'Y','N')", conn)
        cmd.Parameters.AddWithValue("@username", user_name)
        conn.Open()
        Dim exists As String = cmd.ExecuteScalar().ToString()
        'Console.WriteLine(exists)
        conn.Close()
        Return If(exists = "Y", True, False)
    End Function


    Private Sub btnLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        
        'Dim chiper As String = wrapper.EncryptData("12345")
        'Console.WriteLine("en : " & chiper)


        'Console.WriteLine("dec : " & text)
        If editUsername.Text <> "" And editPass.Text <> "" Then
            If (cekUsernameExis(editUsername.Text)) Then
                getData(editUsername.Text, editPass.Text)
                Dim wrapper As New EncriptClass("abdulrahmat97")
                Dim pass_decrtp$ = wrapper.DecryptData(pass)
                If editUsername.Text = username And editPass.Text = pass_decrtp Then
                    formListOrder.Show()
                    'Application.DoEvents()
                    Me.Hide()
                Else
                    MessageBox.Show("Username atau Password Salah", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Username atau Password Salah", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Username atau Password Salah", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class