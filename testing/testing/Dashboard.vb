Imports System.Drawing.Drawing2D


Public Class Dashboard
    Public Property LoggedInUser As String

    Sub switchpanel(ByVal panel As Form)
        Panel5.Controls.Clear() 'Clear existing controls in Panel 3
        panel.TopLevel = False 'Treat the form as a control
        panel.FormBorderStyle = FormBorderStyle.None 'Remove border and title bar
        panel.Dock = DockStyle.Fill 'Fill the entire panel3 Area
        Panel5.Controls.Add(panel) 'Add the form to panel3
        panel.Show() 'Display the embedded form
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Automatically load DashboardAccess form
        Dim dashboardAccess As New DashboardAccess()
        switchpanel(dashboardAccess)

        ' Display the logged-in user's full name
        If Not String.IsNullOrEmpty(LoggedInUser) Then
            Label3.Text = LoggedInUser
        End If

        Timer1.Enabled = True
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHome.Click

        switchpanel(DashboardAccess)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnArchieve.Click
        switchpanel(Achievelist)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnPatientsList.Click
        switchpanel(List)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        switchpanel(Stats)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Date.Now.ToString("hh:mm:ss     dddd-MMMM-dd-yyyy")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Form1.Show()
        Me.Close()
    End Sub


    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or &H20000 ' CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim connectionString As String = "Server=localhost; Database=qcu_clinic; uid=root; password=;"
        Dim query As String = "SELECT lastname, firstname FROM users"

        Try
            Dim conn As New MySql.Data.MySqlClient.MySqlConnection(connectionString)
            Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(query, conn)
            Dim table As New DataTable()

            adapter.Fill(table)

            ' Loop through the DataTable rows and add them to the label
            For Each row As DataRow In table.Rows
                Label3.Text &= $"{row("lastname")}, {row("firstname")}" & Environment.NewLine
            Next
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub



End Class