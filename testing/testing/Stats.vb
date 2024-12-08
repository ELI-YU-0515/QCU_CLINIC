Imports MySql.Data.MySqlClient
Imports Bunifu.Charts.WinForms

Public Class Stats
    Dim connectionString As String = "server=localhost;Database=qcu_clinic;Uid=root;password=;"
    Dim connection As MySqlConnection

    'Open MySql connection
    Private Sub ConnectToDatabase()
        Try
            connection.Open()
            MsgBox("Connection Successfully.")
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        End Try
    End Sub

    'Close MySql Connection
    Private Sub DisconnectFromDatabase()
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
            MsgBox("Connection Close.")
        End If
    End Sub

    Private Sub LoadCourseData()
        'fetch data from the student table
        Dim query As String = "SELECT Course, COUNT(*) FROM student GROUP BY Course"

        'Create MySql Command object
        Dim cmd As New MySqlCommand(query, connection)

        'Execute the query and retrieve the  result
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        'List to store course names and  student counts
        Dim courseNames As New List(Of String)
        Dim studentCounts As New List(Of Double)

        'Loop through theresult set and populate the list
        While reader.Read()
            courseNames.Add(reader("Course").ToString())
            studentCounts.Add(Convert.ToInt32(reader("COUNT(*)")))
        End While

        'Close the reader
        reader.Close()

        'Create a bar chart dataset
        Dim barChart As New Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart()

        ' Assign the data to the bar chart
        barChart.Data = studentCounts
        barChart.BackgroundColor = New List(Of String) From {
            ColorTranslator.FromHtml("#3498DB"),
            ColorTranslator.FromHtml("#2ECC71"),
            ColorTranslator.FromHtml("#E74C3C"),
            ColorTranslator.FromHtml("#F1C40F"),
            ColorTranslator.FromHtml("#986986")
        
        
        
        
        }
        barChart.Label = "Number of Students"

        ' Assign the course names as labels to the chart canvas
        BunifuChartCanvas1.Labels = courseNames.ToArray()

        Debug.WriteLine(String.Join(", ", courseNames))
        Debug.WriteLine(String.Join(", ", studentCounts))


        ' Add the bar chart to the canvas
        BunifuChartCanvas1.DataSets.Clear()  ' Clear existing datasets
        BunifuChartCanvas1.DataSets.Add(barChart)  ' Add the bar chart dataset



        'Update the chart with the new data
        BunifuChartCanvas1.Update()
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Staff.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TeachingStaff.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HomeDashboard.Show()
    End Sub

    Private Sub Stats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectToDatabase()
        LoadCourseData()
    End Sub
End Class