﻿Imports MySql.Data.MySqlClient

Public Class Achievelist
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkCategory.CheckedChanged
        If chkCategory.Checked Then
            'Enabled Category dropdown, search checkbox and input
            cmbCategory.Enabled = True
            txtSearch.Enabled = False
            chkSearch.Enabled = False
        Else
            'Disable Category dropdown
            cmbCategory.Enabled = False
        End If
    End Sub

    Private Sub chkSearch_CheckedChanged(sender As Object, e As EventArgs) Handles chkSearch.CheckedChanged
        If chkSearch.Checked Then
            'Enabled Category dropdown, search checkbox and input
            txtSearch.Enabled = True
            cmbCategory.Enabled = False
            chkCategory.Checked = False
        Else
            'Disable Search input
            txtSearch.Enabled = False
        End If
    End Sub
End Class