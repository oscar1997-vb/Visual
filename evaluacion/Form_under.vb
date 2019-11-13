Public Class Form_under
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form_menu.Show()
    End Sub

    Private Sub Form_under_close(sender As Object, e As EventArgs) Handles MyBase.Load
        Form_menu.Show()
    End Sub
End Class