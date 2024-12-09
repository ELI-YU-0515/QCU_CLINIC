Imports System.Drawing.Drawing2D
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
                    "VALUES (@lastname,@firstname,@mi,@age,@gender,@birthday,@role,@username,@password)"
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
        ClearFields()

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



    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or &H20000 ' CS_DROPSHADOW
            Return cp
        End Get
    End Property


    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        ' Define your colors
        Dim color1 As Color = ColorTranslator.FromHtml("#F89B57")
        Dim color2 As Color = ColorTranslator.FromHtml("#FFE4BF")

        ' Create a linear gradient brush
        Using gradientBrush As New LinearGradientBrush(Me.ClientRectangle, color1, color2, 255)
            ' Fill the form with the gradient
            e.Graphics.FillRectangle(gradientBrush, Me.ClientRectangle)
        End Using ' Automatically disposes the brush
    End Sub

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