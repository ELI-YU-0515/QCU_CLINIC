Imports MySql.Data.MySqlClient
Imports Bunifu.Charts.WinForms
Imports Bunifu.Charts.WinForms.ChartTypes
Imports System.Drawing.Drawing2D

Public Class Stats
    Dim connectionString As String = "server=localhost;Database=qcu_clinic;Uid=root;password=;"
    Dim connection As MySqlConnection

    ' Open MySql connection
    Private Sub ConnectToDatabase()
        Try
            connection = New MySqlConnection(connectionString)
            connection.Open()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Close MySql connection
    Private Sub DisconnectFromDatabase()
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
            MsgBox("Connection Closed.")
        End If
    End Sub



    Private Sub Stats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectToDatabase()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HomeDashboard.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TeachingStaff.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Staff.Show()
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
End Class
