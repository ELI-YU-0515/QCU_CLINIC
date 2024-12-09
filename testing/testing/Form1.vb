Imports System.Drawing.Drawing2D
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
            'Connect to the database
            Dim connectionString As String = "Server=localhost; Database=qcu_clinic; uid=root; password=;"
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "SELECT CONCAT(Firstname, ' ', LEFT(MI, 1), '. ', Lastname, '    ( ',Role,' )') AS Fullname, Role FROM users WHERE Username = @username AND Password = @password"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim fullName As String = reader("Fullname").ToString()
                            Dim role As String = reader("Role").ToString()

                            MessageBox.Show($"Welcome, {fullName}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Open the dashboard form and pass the full name
                            Dim dashboard As New Dashboard()
                            dashboard.LoggedInUser = fullName ' Pass the full name to Dashboard
                            dashboard.Show()
                            Me.Hide()
                            txtUsername.Clear()
                            txtPassword.Clear()
                        Else
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtPassword.PasswordChar = If(CheckBoxShowPassword.Checked, "", "*"c)
    End Sub

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or &H20000 ' CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ' Define the gradient colors
        Dim color1 As Color = ColorTranslator.FromHtml("#98C1D9") ' Light Blue
        Dim color2 As Color = ColorTranslator.FromHtml("#4E95C3") ' Darker Blue

        ' Create a linear gradient brush
        Using gradientBrush As New LinearGradientBrush(Panel1.ClientRectangle, color1, color2, LinearGradientMode.Vertical)
            ' Fill the panel with the gradient
            e.Graphics.FillRectangle(gradientBrush, Panel1.ClientRectangle)
        End Using ' Automatically disposes of the brush
    End Sub

End Class
