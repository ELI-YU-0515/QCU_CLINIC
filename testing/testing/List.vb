Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class List

    Private Sub loadstudentData()
        'Connection String
        Dim connectionString As String = "Server=localhost; Database = qcu_clinic; uid=root; password=;"
        Dim query As String = "SELECT * FROM student"

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                'Command and Adapter
                Dim cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)

                'Fill table
                Dim table As New DataTable()
                adapter.Fill(table)

                'Bind to DataGridView
                DataGridView1.DataSource = table

            End Using
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        End Try
    End Sub

    Private Sub loadFacultyData()
        'Connection String
        Dim connectionString As String = "Server=localhost; Database = qcu_clinic; uid=root; password=;"
        Dim query As String = "SELECT * FROM faculty"

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                'Command and Adapter
                Dim cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)

                'Fill table
                Dim table As New DataTable()
                adapter.Fill(table)

                'Bind to DataGridView
                DataGridView1.DataSource = table

            End Using
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        End Try
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub List_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub List_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        loadstudentData()
        loadFacultyData()
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