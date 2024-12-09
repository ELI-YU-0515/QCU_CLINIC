<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.DtpBirthday = New System.Windows.Forms.DateTimePicker()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtMI = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Firebrick
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(477, 423)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Firebrick
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(465, 412)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(170, 55)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "BACK"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.BackColor = System.Drawing.Color.Teal
        Me.btnCreateAccount.FlatAppearance.BorderSize = 0
        Me.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAccount.ForeColor = System.Drawing.Color.Black
        Me.btnCreateAccount.Location = New System.Drawing.Point(274, 412)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(170, 55)
        Me.btnCreateAccount.TabIndex = 8
        Me.btnCreateAccount.Text = "CREATE ACCOUNT"
        Me.btnCreateAccount.UseVisualStyleBackColor = False
        '
        'DtpBirthday
        '
        Me.DtpBirthday.CustomFormat = "yyyy-MM-dd"
        Me.DtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpBirthday.Location = New System.Drawing.Point(428, 215)
        Me.DtpBirthday.Name = "DtpBirthday"
        Me.DtpBirthday.Size = New System.Drawing.Size(104, 26)
        Me.DtpBirthday.TabIndex = 7
        '
        'cmbRole
        '
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Location = New System.Drawing.Point(121, 291)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(104, 28)
        Me.cmbRole.TabIndex = 6
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Location = New System.Drawing.Point(428, 247)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(104, 28)
        Me.cmbGender.TabIndex = 6
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(328, 161)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(242, 26)
        Me.txtFirstName.TabIndex = 5
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(121, 249)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(218, 26)
        Me.txtPassword.TabIndex = 5
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(121, 215)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(218, 26)
        Me.txtUsername.TabIndex = 5
        '
        'txtMI
        '
        Me.txtMI.Location = New System.Drawing.Point(576, 161)
        Me.txtMI.Name = "txtMI"
        Me.txtMI.Size = New System.Drawing.Size(56, 26)
        Me.txtMI.TabIndex = 5
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(121, 161)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(201, 26)
        Me.txtLastName.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(73, 294)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 20)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Role"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(37, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(355, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 20)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Birthday"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(359, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(32, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(538, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Age"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(173, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Lastname"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(203, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(298, 39)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Register Account"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(64, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 20)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label11.Location = New System.Drawing.Point(410, 193)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 16)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Firstname"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(576, 215)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(56, 26)
        Me.txtAge.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label3.Location = New System.Drawing.Point(594, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "M.I"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtAge)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.txtLastName)
        Me.Panel1.Controls.Add(Me.DtpBirthday)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnCreateAccount)
        Me.Panel1.Controls.Add(Me.txtMI)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmbRole)
        Me.Panel1.Controls.Add(Me.txtFirstName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbGender)
        Me.Panel1.Location = New System.Drawing.Point(234, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(698, 499)
        Me.Panel1.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 217)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(930, 496)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMI As TextBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DtpBirthday As DateTimePicker
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
