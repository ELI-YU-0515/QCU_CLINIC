<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Achievelist
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.chkCategory = New System.Windows.Forms.CheckBox()
        Me.chkSearch = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(61, 247)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(861, 286)
        Me.DataGridView1.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(761, 125)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(161, 26)
        Me.txtSearch.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(116, 160)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(238, 22)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "From:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(402, 158)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(238, 22)
        Me.DateTimePicker2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(365, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "To:"
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(761, 75)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(161, 28)
        Me.cmbCategory.TabIndex = 4
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(791, 193)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(99, 30)
        Me.btnLoad.TabIndex = 5
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'chkCategory
        '
        Me.chkCategory.AutoSize = True
        Me.chkCategory.Location = New System.Drawing.Point(655, 80)
        Me.chkCategory.Name = "chkCategory"
        Me.chkCategory.Size = New System.Drawing.Size(92, 24)
        Me.chkCategory.TabIndex = 6
        Me.chkCategory.Text = "Category"
        Me.chkCategory.UseVisualStyleBackColor = True
        '
        'chkSearch
        '
        Me.chkSearch.AutoSize = True
        Me.chkSearch.Location = New System.Drawing.Point(656, 126)
        Me.chkSearch.Name = "chkSearch"
        Me.chkSearch.Size = New System.Drawing.Size(79, 24)
        Me.chkSearch.TabIndex = 6
        Me.chkSearch.Text = "Search"
        Me.chkSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(63, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Previous History"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 39)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Archieve"
        '
        'Achievelist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1019, 594)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkSearch)
        Me.Controls.Add(Me.chkCategory)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Achievelist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Achievelist"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents chkCategory As CheckBox
    Friend WithEvents chkSearch As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
