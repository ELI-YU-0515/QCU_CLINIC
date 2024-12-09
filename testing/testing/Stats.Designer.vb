<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Stats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stats))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuChartCanvas1 = New Bunifu.Charts.WinForms.BunifuChartCanvas()
        Me.BunifuChartCanvas2 = New Bunifu.Charts.WinForms.BunifuChartCanvas()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.BunifuChartCanvas1)
        Me.Panel1.Controls.Add(Me.BunifuChartCanvas2)
        Me.Panel1.Location = New System.Drawing.Point(2, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(749, 431)
        Me.Panel1.TabIndex = 0
        '
        'BunifuChartCanvas1
        '
        Me.BunifuChartCanvas1.AnimationDuration = 1000
        Me.BunifuChartCanvas1.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart
        Me.BunifuChartCanvas1.BackColor = System.Drawing.Color.White
        Me.BunifuChartCanvas1.CanvasPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuChartCanvas1.Labels = Nothing
        Me.BunifuChartCanvas1.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center
        Me.BunifuChartCanvas1.LegendDisplay = True
        Me.BunifuChartCanvas1.LegendFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuChartCanvas1.LegendForeColor = System.Drawing.Color.DarkGray
        Me.BunifuChartCanvas1.LegendFullWidth = True
        Me.BunifuChartCanvas1.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top
        Me.BunifuChartCanvas1.LegendRevese = False
        Me.BunifuChartCanvas1.LegendRTL = False
        Me.BunifuChartCanvas1.Location = New System.Drawing.Point(42, 31)
        Me.BunifuChartCanvas1.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuChartCanvas1.Name = "BunifuChartCanvas1"
        Me.BunifuChartCanvas1.ShowXAxis = True
        Me.BunifuChartCanvas1.ShowYAxis = True
        Me.BunifuChartCanvas1.Size = New System.Drawing.Size(638, 321)
        Me.BunifuChartCanvas1.TabIndex = 3
        Me.BunifuChartCanvas1.Title = ""
        Me.BunifuChartCanvas1.TitleLineHeight = 1.2R
        Me.BunifuChartCanvas1.TitlePadding = 10
        Me.BunifuChartCanvas1.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top
        Me.BunifuChartCanvas1.TooltipBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas1.TooltipFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas1.TooltipForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuChartCanvas1.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest
        Me.BunifuChartCanvas1.TooltipsEnabled = True
        Me.BunifuChartCanvas1.XAxesBeginAtZero = True
        Me.BunifuChartCanvas1.XAxesDrawTicks = True
        Me.BunifuChartCanvas1.XAxesFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas1.XAxesForeColor = System.Drawing.SystemColors.ControlText
        Me.BunifuChartCanvas1.XAxesGridColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas1.XAxesGridLines = True
        Me.BunifuChartCanvas1.XAxesLabel = ""
        Me.BunifuChartCanvas1.XAxesLabelFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas1.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText
        Me.BunifuChartCanvas1.XAxesLineWidth = 1
        Me.BunifuChartCanvas1.XAxesStacked = False
        Me.BunifuChartCanvas1.XAxesZeroLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas1.XAxesZeroLineWidth = 1
        Me.BunifuChartCanvas1.YAxesBeginAtZero = True
        Me.BunifuChartCanvas1.YAxesDrawTicks = True
        Me.BunifuChartCanvas1.YAxesFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas1.YAxesForeColor = System.Drawing.SystemColors.ControlText
        Me.BunifuChartCanvas1.YAxesGridColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas1.YAxesGridLines = True
        Me.BunifuChartCanvas1.YAxesLabel = ""
        Me.BunifuChartCanvas1.YAxesLabelFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas1.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText
        Me.BunifuChartCanvas1.YAxesLineWidth = 1
        Me.BunifuChartCanvas1.YAxesStacked = False
        Me.BunifuChartCanvas1.YAxesZeroLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas1.YAxesZeroLineWidth = 1
        '
        'BunifuChartCanvas2
        '
        Me.BunifuChartCanvas2.AnimationDuration = 1000
        Me.BunifuChartCanvas2.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart
        Me.BunifuChartCanvas2.BackColor = System.Drawing.Color.White
        Me.BunifuChartCanvas2.CanvasPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuChartCanvas2.Labels = Nothing
        Me.BunifuChartCanvas2.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center
        Me.BunifuChartCanvas2.LegendDisplay = True
        Me.BunifuChartCanvas2.LegendFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuChartCanvas2.LegendForeColor = System.Drawing.Color.DarkGray
        Me.BunifuChartCanvas2.LegendFullWidth = True
        Me.BunifuChartCanvas2.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top
        Me.BunifuChartCanvas2.LegendRevese = False
        Me.BunifuChartCanvas2.LegendRTL = False
        Me.BunifuChartCanvas2.Location = New System.Drawing.Point(42, 378)
        Me.BunifuChartCanvas2.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuChartCanvas2.Name = "BunifuChartCanvas2"
        Me.BunifuChartCanvas2.ShowXAxis = True
        Me.BunifuChartCanvas2.ShowYAxis = True
        Me.BunifuChartCanvas2.Size = New System.Drawing.Size(638, 300)
        Me.BunifuChartCanvas2.TabIndex = 2
        Me.BunifuChartCanvas2.Title = ""
        Me.BunifuChartCanvas2.TitleLineHeight = 1.2R
        Me.BunifuChartCanvas2.TitlePadding = 10
        Me.BunifuChartCanvas2.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top
        Me.BunifuChartCanvas2.TooltipBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas2.TooltipFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas2.TooltipForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuChartCanvas2.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest
        Me.BunifuChartCanvas2.TooltipsEnabled = True
        Me.BunifuChartCanvas2.XAxesBeginAtZero = True
        Me.BunifuChartCanvas2.XAxesDrawTicks = True
        Me.BunifuChartCanvas2.XAxesFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas2.XAxesForeColor = System.Drawing.SystemColors.ControlText
        Me.BunifuChartCanvas2.XAxesGridColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas2.XAxesGridLines = True
        Me.BunifuChartCanvas2.XAxesLabel = ""
        Me.BunifuChartCanvas2.XAxesLabelFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas2.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText
        Me.BunifuChartCanvas2.XAxesLineWidth = 1
        Me.BunifuChartCanvas2.XAxesStacked = False
        Me.BunifuChartCanvas2.XAxesZeroLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas2.XAxesZeroLineWidth = 1
        Me.BunifuChartCanvas2.YAxesBeginAtZero = True
        Me.BunifuChartCanvas2.YAxesDrawTicks = True
        Me.BunifuChartCanvas2.YAxesFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas2.YAxesForeColor = System.Drawing.SystemColors.ControlText
        Me.BunifuChartCanvas2.YAxesGridColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas2.YAxesGridLines = True
        Me.BunifuChartCanvas2.YAxesLabel = ""
        Me.BunifuChartCanvas2.YAxesLabelFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas2.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText
        Me.BunifuChartCanvas2.YAxesLineWidth = 1
        Me.BunifuChartCanvas2.YAxesStacked = False
        Me.BunifuChartCanvas2.YAxesZeroLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas2.YAxesZeroLineWidth = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(859, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 67)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "STUDENTS"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(781, 185)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(859, 300)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(164, 67)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "FACULTY"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(781, 297)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(859, 413)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(164, 67)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "STAFF"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(781, 410)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Location = New System.Drawing.Point(238, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Analytics"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 39)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Dashboard"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 50
        Me.BunifuElipse1.TargetControl = Me.Button1
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 50
        Me.BunifuElipse2.TargetControl = Me.Button2
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 50
        Me.BunifuElipse3.TargetControl = Me.Button3
        '
        'Stats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1051, 594)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Stats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "v"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuChartCanvas2 As Bunifu.Charts.WinForms.BunifuChartCanvas
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuChartCanvas1 As Bunifu.Charts.WinForms.BunifuChartCanvas
End Class
