<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tc_prepare
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tc_prepare))
        Me.tc_elipse = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.tc_shadow = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.tc_load = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2CircleProgressBar1 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.tc_movement1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.tc_movement2 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.tc_movement3 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.SuspendLayout()
        '
        'tc_elipse
        '
        Me.tc_elipse.TargetControl = Me
        '
        'tc_load
        '
        Me.tc_load.Interval = 1
        '
        'Guna2CircleProgressBar1
        '
        Me.Guna2CircleProgressBar1.Animated = True
        Me.Guna2CircleProgressBar1.AnimationSpeed = 1.0!
        Me.Guna2CircleProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CircleProgressBar1.EnsureVisible = True
        Me.Guna2CircleProgressBar1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CircleProgressBar1.FillOffset = 30
        Me.Guna2CircleProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.Guna2CircleProgressBar1.Image = Global.Trucatt.My.Resources.Resources.icon
        Me.Guna2CircleProgressBar1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2CircleProgressBar1.Name = "Guna2CircleProgressBar1"
        Me.Guna2CircleProgressBar1.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.SolidTransition
        Me.Guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.DodgerBlue
        Me.Guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.DodgerBlue
        Me.Guna2CircleProgressBar1.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.Guna2CircleProgressBar1.ProgressOffset = 10
        Me.Guna2CircleProgressBar1.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.Guna2CircleProgressBar1.ProgressThickness = 40
        Me.Guna2CircleProgressBar1.ShadowDecoration.BorderRadius = 10
        Me.Guna2CircleProgressBar1.ShadowDecoration.Depth = 60
        Me.Guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleProgressBar1.ShadowDecoration.Parent = Me.Guna2CircleProgressBar1
        Me.Guna2CircleProgressBar1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2CircleProgressBar1.Size = New System.Drawing.Size(218, 218)
        Me.Guna2CircleProgressBar1.TabIndex = 1
        Me.Guna2CircleProgressBar1.UseTransparentBackground = True
        '
        'tc_movement2
        '
        Me.tc_movement2.TargetControl = Me.Guna2CircleProgressBar1
        '
        'tc_movement3
        '
        Me.tc_movement3.TargetControl = Me
        '
        'tc_prepare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(243, 243)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2CircleProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "tc_prepare"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trucatt - Loading"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tc_elipse As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents tc_shadow As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents tc_load As System.Windows.Forms.Timer
    Friend WithEvents Guna2CircleProgressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents tc_movement2 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents tc_movement1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents tc_movement3 As Guna.UI2.WinForms.Guna2DragControl
End Class
