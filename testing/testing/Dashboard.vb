Public Class Dashboard

    Private Sub Panel5_paint(sende As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Sub switchpanel(ByVal panel As Form)
        Panel5.Controls.Clear() 'Clear existing controls in Panel 3
        panel.TopLevel = False 'Treat the form as a control
        panel.FormBorderStyle = FormBorderStyle.None 'Remove border and title bar
        panel.Dock = DockStyle.Fill 'Fill the entire panel3 Area
        Panel5.Controls.Add(panel) 'Add the form to panel3
        panel.Show() 'Display the embedded form
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Automatically load DashboardAccess form
        Dim dashboardAccess As New DashboardAccess()
        switchpanel(dashboardAccess)
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Date.Now.ToString("hh:mm:ss     dddd-MMMM-dd-yyyy")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class