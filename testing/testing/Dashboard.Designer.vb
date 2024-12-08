<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.mainpanel = New System.Windows.Forms.Panel()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnArchieve = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnPatientsList = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.mainpanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainpanel
        '
        Me.mainpanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.mainpanel.Controls.Add(Me.btnSignOut)
        Me.mainpanel.Controls.Add(Me.PictureBox1)
        Me.mainpanel.Controls.Add(Me.btnArchieve)
        Me.mainpanel.Controls.Add(Me.btnHome)
        Me.mainpanel.Controls.Add(Me.btnPatientsList)
        Me.mainpanel.Controls.Add(Me.btnDashboard)
        Me.mainpanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.mainpanel.Location = New System.Drawing.Point(0, 70)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.Size = New System.Drawing.Size(300, 630)
        Me.mainpanel.TabIndex = 0
        '
        'btnSignOut
        '
        Me.btnSignOut.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSignOut.ForeColor = System.Drawing.Color.White
        Me.btnSignOut.Image = CType(resources.GetObject("btnSignOut.Image"), System.Drawing.Image)
        Me.btnSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSignOut.Location = New System.Drawing.Point(3, 558)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(298, 50)
        Me.btnSignOut.TabIndex = 2
        Me.btnSignOut.Text = "SIGN OUT"
        Me.btnSignOut.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(64, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnArchieve
        '
        Me.btnArchieve.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnArchieve.ForeColor = System.Drawing.Color.White
        Me.btnArchieve.Image = CType(resources.GetObject("btnArchieve.Image"), System.Drawing.Image)
        Me.btnArchieve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArchieve.Location = New System.Drawing.Point(1, 441)
        Me.btnArchieve.Name = "btnArchieve"
        Me.btnArchieve.Size = New System.Drawing.Size(300, 55)
        Me.btnArchieve.TabIndex = 0
        Me.btnArchieve.Text = "CLINIC ARCHIEVE"
        Me.btnArchieve.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(0, 233)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(300, 55)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "HOME"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnPatientsList
        '
        Me.btnPatientsList.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnPatientsList.ForeColor = System.Drawing.Color.White
        Me.btnPatientsList.Image = CType(resources.GetObject("btnPatientsList.Image"), System.Drawing.Image)
        Me.btnPatientsList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPatientsList.Location = New System.Drawing.Point(1, 370)
        Me.btnPatientsList.Name = "btnPatientsList"
        Me.btnPatientsList.Size = New System.Drawing.Size(300, 55)
        Me.btnPatientsList.TabIndex = 0
        Me.btnPatientsList.Text = "PATIENTS LIST"
        Me.btnPatientsList.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 299)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(300, 55)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "DASHBOARD"
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1356, 70)
        Me.Panel2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1032, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(296, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(65, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "QCU CLINIC"
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(297, 70)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 100)
        Me.Panel3.TabIndex = 2
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(1284, 8)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(60, 55)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "X"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(300, 70)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1056, 630)
        Me.Panel5.TabIndex = 2
        '
        'Timer1
        '
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1356, 700)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.mainpanel)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.mainpanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainpanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents btnArchieve As Button
    Friend WithEvents btnPatientsList As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSignOut As Button
End Class
