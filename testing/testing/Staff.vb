Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient


Public Class Staff
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand

    Private Sub uploadData()
        sqlConn.ConnectionString = "server=localhost; userid=root; password=; database=qcu_clinic; port=3306"
        sqlConn.Open()

    End Sub

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate Combobox with roles
        txtDepartment.Items.Add("Utility")
        txtDepartment.Items.Add("Security Guard")
        txtDepartment.Items.Add("Lunch Lady")
        txtDepartment.Items.Add("Gardeneer")

        txtGender.Items.Add("Male")
        txtGender.Items.Add("Female")
        txtGender.Items.Add("Others")

        txtRelationship.Items.Add("Parent")
        txtRelationship.Items.Add("Guardian")
        txtRelationship.Items.Add("Wife")

        cmbYear.Items.Add("2024")
        cmbYear.Items.Add("2023")
        cmbYear.Items.Add("2022")
        cmbYear.Items.Add("2021")
        cmbYear.Items.Add("2020")
        cmbYear.Items.Add("2019")

        cmbStatus.Items.Add("Single")
        cmbStatus.Items.Add("Married")
        cmbStatus.Items.Add("In a Relationship")

        cmbNationality.Items.Add("Natural Filipino")
        cmbNationality.Items.Add("American")
        cmbNationality.Items.Add("Indian")

    End Sub

    Private Sub Label31_Click(sender As Object, e As EventArgs)
        Dashboard.Show()
        Me.Hide()
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub btnPatientAdd_Click_1(sender As Object, e As EventArgs)
        'Connection to Database
        Dim connStr As String = "server=localhost; userid=root; password=; database=qcu_clinic; port=3306"
        Dim sqlConn As New MySqlConnection(connStr)
        Dim sqlCmd As New MySqlCommand

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        Try
            sqlCmd.CommandText = "INSERT INTO staff(EmployeeID, Department, Year, Surname, Firstname, MiddleInitial, Prefix, Birthday, Address, PhoneNumber, Gender, Age, Height, Weight, BloodType, BloodPressure, Status, Nationality, Religion, Relatives, Relationship, ContactNumber)" &
            "VALUES(@EmployeeID,@Department,@Year,@Surname,@FirstName,@middleInitial,@Prefix,@Birthday,@Address,@Phonenumber,@Gender,@Age,@Height,@Weight,@BloodType,@BloodPressure,@Status,@Nationality,@Religion,@Relatives,@Relationship,@Contactnumber)"

            'Format the Date
            Dim formattedDate As String = DtpBirthday.Value.ToString("yyyy-MM-dd")

            sqlCmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text)
            sqlCmd.Parameters.AddWithValue("@Department", txtDepartment.Text)
            sqlCmd.Parameters.AddWithValue("@Year", cmbYear.Text)
            sqlCmd.Parameters.AddWithValue("@Surname", txtSurname.Text)
            sqlCmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text)
            sqlCmd.Parameters.AddWithValue("@middleInitial", txtMiddlename.Text)
            sqlCmd.Parameters.AddWithValue("@Prefix", txtPrefix.Text)
            sqlCmd.Parameters.AddWithValue("@Birthday", formattedDate)
            sqlCmd.Parameters.AddWithValue("@Address", txtAddress.Text)
            sqlCmd.Parameters.AddWithValue("@Phonenumber", txtPhone.Text)
            sqlCmd.Parameters.AddWithValue("Gender", txtGender.Text)
            sqlCmd.Parameters.AddWithValue("@Age", txtAge.Text)
            sqlCmd.Parameters.AddWithValue("@Height", txtHeight.Text)
            sqlCmd.Parameters.AddWithValue("@Weight", txtWeight.Text)
            sqlCmd.Parameters.AddWithValue("@BloodType", txtBloodType.Text)
            sqlCmd.Parameters.AddWithValue("@BloodPressure", txtBP.Text)
            sqlCmd.Parameters.AddWithValue("@Status", cmbStatus.Text)
            sqlCmd.Parameters.AddWithValue("@Nationality", cmbNationality.Text)
            sqlCmd.Parameters.AddWithValue("@Religion", txtReligion.Text)
            sqlCmd.Parameters.AddWithValue("@Relatives", txtRelatives.Text)
            sqlCmd.Parameters.AddWithValue("@Relationship", txtRelationship.Text)
            sqlCmd.Parameters.AddWithValue("@Contactnumber", txtCNumber.Text)
            sqlCmd.ExecuteNonQuery()
            MessageBox.Show("Patients info inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            sqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "QCU Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If
        End Try

    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        txtEmployeeID.Clear()
        txtSurname.Clear()
        txtFirstname.Clear()
        txtMiddlename.Clear()
        txtPrefix.Clear()
        txtAddress.Clear()
        txtPhone.Clear()
        txtAge.Clear()
        txtHeight.Clear()
        txtWeight.Clear()
        txtBloodType.Clear()
        txtBP.Clear()
        txtReligion.Clear()
        txtRelatives.Clear()
        txtCNumber.Clear()

        ' Reset ComboBox selections
        cmbYear.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1
        cmbNationality.SelectedIndex = -1
        txtDepartment.SelectedIndex = -1
        txtGender.SelectedIndex = -1
        txtRelationship.SelectedIndex = -1

        ' Reset DateTimePicker to today's date
        DtpBirthday.Value = DateTime.Now

        MessageBox.Show("All fields have been cleared.", "Clear Form", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub



    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or &H20000 ' CS_DROPSHADOW
            Return cp
        End Get
    End Property


    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ' Define the gradient colors
        Dim color1 As Color = ColorTranslator.FromHtml("#98C1D9") ' Light Blue
        Dim color2 As Color = ColorTranslator.FromHtml("#4E95C3") ' Darker Blue

        ' Create a linear gradient brush
        Dim gradientBrush As New LinearGradientBrush(Panel1.ClientRectangle, color1, color2, LinearGradientMode.Vertical)

        ' Fill the panel with the gradient
        e.Graphics.FillRectangle(gradientBrush, Panel1.ClientRectangle)

        ' Dispose of the brush to release resources
        gradientBrush.Dispose()
    End Sub
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
End Class