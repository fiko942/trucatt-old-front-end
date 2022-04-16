Public Class tc_prepare
    Private Sub tc_prepare_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
    Private Sub tc_prepare_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tc_shadow.SetShadowForm(Me)
        tc_load.Enabled = True
    End Sub
    Private Sub tc_Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tc_load.Tick
        Guna2CircleProgressBar1.Value += 1
        If Guna2CircleProgressBar1.Value = 100 Then
            Me.Hide()
            tc_menuutama.Show()
            tc_load.Enabled = False
            tc_load.Stop()
        End If
    End Sub
End Class