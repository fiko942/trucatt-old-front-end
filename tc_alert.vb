Public Class tc_alert

    Private Sub tc_alert_warning_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Enabled = False
    End Sub

    Private Sub tc_alert_warning_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        Guna2ProgressBar1.Value = 0
        Me.Icon = tc_prepare.Icon
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Guna2ProgressBar1.Value += 1
        If Guna2ProgressBar1.Value = 100 Then
            Me.Hide()
            Guna2ProgressBar1.Value = 0
            Timer1.Enabled = False
        End If
    End Sub
End Class