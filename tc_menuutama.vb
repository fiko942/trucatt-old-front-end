Imports System.IO
Public Class tc_menuutama

    Dim cursize As Double
    Dim finsize As Double
    Private Sub tc_menuutama_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
    Private Sub tc_menuutama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = tc_prepare.Icon
        tc_shadow.SetShadowForm(Me)
        'tampilkan candaan welcome
        Me.showNotification("Coded by Wiji Fiko Teren")
        'tampilkan menu gametools
        Me.tc_panel_gametools.Visible = True
        Me.tc_panel_gametools.BringToFront()
    End Sub
    Private Sub Guna2ControlBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2ControlBox2.Click
        tc_animaten.SetAnimateWindow(Me)
    End Sub

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click

    End Sub

    Private Sub tc_time_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tc_time.Tick
        tc_tanggal.Text = Format(Now, "hh:mm:ss tt")
    End Sub
    Private Sub tools(ByVal srcPath As String, ByVal destPath As String)

    End Sub

    Private Sub tools_ProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs)

    End Sub
    Private Sub toolsj1t(ByVal srcPath As String, ByVal destPath As String)

    End Sub

    Private Sub toolsj1t_ProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs)

    End Sub

    Private Sub Guna2CircleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2CircleButton1.Click

    End Sub

    Private Sub Guna2CircleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2CircleButton2.Click

    End Sub

    Private Sub Guna2CircleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2CircleButton3.Click

    End Sub

    Private Sub Guna2CircleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2CircleButton4.Click

    End Sub

    Private Sub Guna2CircleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2CircleButton5.Click

    End Sub

    Private Sub Guna2Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button2.Click

    End Sub

    Private Sub Guna2Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button7.Click

    End Sub

    Private Sub Guna2Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button9.Click

    End Sub

    Private Sub Guna2Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button8.Click

    End Sub

    Private Sub Guna2Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button10.Click

    End Sub

    Private Sub Guna2Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button12.Click

    End Sub

    Private Sub Guna2Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button11.Click

    End Sub

    Private Sub Guna2Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button14.Click

    End Sub

    Private Sub Guna2Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button13.Click

    End Sub

    Private Sub Guna2Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button15.Click

    End Sub

    Private Function showNotification(text)
        tc_alert.Timer1.Enabled = True
        tc_alert.Guna2ProgressBar1.Value = 0
        tc_alert.txt_alert.Text = text
        tc_alert.Hide()
        tc_alert.Show()
        Return True
    End Function


    Private Sub Guna2Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button16.Click


    End Sub

    Private Sub Guna2Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Guna2Panel3.Paint

    End Sub


    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click

    End Sub

    Private Sub Guna2Button17_Click(sender As Object, e As EventArgs) Handles Guna2Button17.Click

    End Sub

    Private Sub canda_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub
End Class
