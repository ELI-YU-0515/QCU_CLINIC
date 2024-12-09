Imports System.Drawing.Drawing2D

Public Class DashboardAccess
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DashboardAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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