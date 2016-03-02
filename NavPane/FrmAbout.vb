Public NotInheritable Class FrmAbout

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
    End Sub

    Private Sub Button1_Mousehover(sender As Object, e As EventArgs) Handles BtnBack.MouseHover
        BtnBack.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles BtnBack.MouseLeave
        BtnBack.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel.LinkClicked
        System.Diagnostics.Process.Start("https://twitter.com/rafaelferrezla")
    End Sub
End Class
