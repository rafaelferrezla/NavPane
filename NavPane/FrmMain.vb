'Developed for Theboss
'03/01/2016
'Venezuela
Public Class FrmMain

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel.Dock = DockStyle.Left
        Timer1.Enabled = False
        Timer2.Enabled = True
        Btn2.Visible = False
        BtnAbout.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Panel.Width < 150 Then
            Panel.Width = Panel.Width + 20
            Btn1.Visible = False
            Btn2.Visible = True
        ElseIf Panel.Width = 150 Then
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Panel.Width > 0 Then
            Panel.Width = Panel.Width - 15
            Btn1.Visible = True
        ElseIf Panel.Width = 0 Then
            Timer2.Enabled = False
            Btn2.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click
        Timer2.Enabled = True
        FrmAbout.StartPosition = FormStartPosition.CenterParent
        FrmAbout.ShowDialog()
    End Sub

End Class
