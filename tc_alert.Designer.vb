<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tc_alert
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Guna2ProgressBar1 = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txt_alert = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.DimGray
        Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 75)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'Guna2ProgressBar1
        '
        Me.Guna2ProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2ProgressBar1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Guna2ProgressBar1.Location = New System.Drawing.Point(3, 72)
        Me.Guna2ProgressBar1.Name = "Guna2ProgressBar1"
        Me.Guna2ProgressBar1.ProgressColor = System.Drawing.Color.DimGray
        Me.Guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.DimGray
        Me.Guna2ProgressBar1.ShadowDecoration.Parent = Me.Guna2ProgressBar1
        Me.Guna2ProgressBar1.Size = New System.Drawing.Size(473, 3)
        Me.Guna2ProgressBar1.TabIndex = 1
        Me.Guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        Me.Guna2ProgressBar1.UseTransparentBackground = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'txt_alert
        '
        Me.txt_alert.AutoSize = True
        Me.txt_alert.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_alert.ForeColor = System.Drawing.Color.Black
        Me.txt_alert.Location = New System.Drawing.Point(72, 29)
        Me.txt_alert.Name = "txt_alert"
        Me.txt_alert.Size = New System.Drawing.Size(73, 21)
        Me.txt_alert.TabIndex = 2
        Me.txt_alert.Text = "txt_alert"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.ErrorImage = Global.Trucatt.My.Resources.Resources.icon
        Me.Guna2PictureBox1.Image = Global.Trucatt.My.Resources.Resources.icon
        Me.Guna2PictureBox1.InitialImage = Global.Trucatt.My.Resources.Resources.icon
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(12, 21)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 3
        Me.Guna2PictureBox1.TabStop = False
        '
        'tc_alert_warning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(476, 75)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.txt_alert)
        Me.Controls.Add(Me.Guna2ProgressBar1)
        Me.Controls.Add(Me.Splitter1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "tc_alert_warning"
        Me.ShowInTaskbar = False
        Me.Text = "Trucatt - Warning"
        Me.TopMost = True
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Guna2ProgressBar1 As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txt_alert As System.Windows.Forms.Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
