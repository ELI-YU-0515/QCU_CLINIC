Imports MySql.Data.MySqlClient

Public Class Register


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        Dim lastName As String = txtLastName.Text
        Dim firstName As String = txtFirstName.Text
        Dim middleInitial As String = txtMI.Text
        Dim age As Integer
        Dim gender As String = cmbGender.SelectedItem?.ToString()
        Dim birthday As Date = DtpBirthday.Value.ToString("yyyy-MM-dd") 'formatted birthday
        Dim role As String = cmbRole.SelectedItem?.ToString()
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        'Validate input
        If String.IsNullOrWhiteSpace(lastName) OrElse String.IsNullOrWhiteSpace(firstName) OrElse String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Not Integer.TryParse(txtAge.Text, age) Then
            MessageBox.Show("Invalid age entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            'Connect to the database
            Using conn As New MySqlConnection(ConnectionString)
                conn.Open()

                'Insert user into the database
                Dim query As String = "INSERT INTO users (Lastname,Firstname,MI,Age,Gender,Birthday,Role,Username,Password)" &
                    "VALUES (@lastname,firstname,@mi,@age,@gender,@birthday,@role,@username,@password)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@lastname", lastName)
                    cmd.Parameters.AddWithValue("@firstname", firstName)
                    cmd.Parameters.AddWithValue("@mi", middleInitial)
                    cmd.Parameters.AddWithValue("@age", age)
                    cmd.Parameters.AddWithValue("@gender", gender)
                    cmd.Parameters.AddWithValue("@birthday", birthday)
                    cmd.Parameters.AddWithValue("@role", role)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Account Created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()

        Catch ex As MysqlException When ex.Number = 1062 'Duplicate entry error
            MessageBox.Show("Username already exists.Please choose a different username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show($"An error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ClearFields()
        txtLastName.Clear()
        txtFirstName.Clear()
        txtMI.Clear()
        txtAge.Clear()
        cmbGender.SelectedIndex = -1
        DtpBirthday.Value = DateTime.Now
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbGender.Items.Add("Male")
        cmbGender.Items.Add("Female")
        cmbGender.Items.Add("Other")

        cmbRole.Items.Add("Admin")
        cmbRole.Items.Add("Nurse")

    End Sub
End Class