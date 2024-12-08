Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            'Connect  to the database 
            Using conn As New MySqlConnection(ConnectionString)
                conn.Open()

                Dim query As String = "SELECT CONCAT(Firstname,' ',Lastname) As  Fullname, Role FROM users WHERE Username = @username AND Password = @password"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim fullName As String = reader("Fullname").ToString()
                            Dim role As String = reader("role").ToString()

                            MessageBox.Show($"Welcome, {fullName}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            'OPen the dashboard form
                            Dim dashboard As New Dashboard
                            dashboard.Show()
                            Me.Hide()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An Error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPassword.CheckedChanged

        'Toggle the Password char
        If CheckBoxShowPassword.Checked Then
            txtPassword.PasswordChar = "" 'Show password
        Else
            txtPassword.PasswordChar = "*" 'Hide Password
        End If
    End Sub
End Class
