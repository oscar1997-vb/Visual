Public Class Form_Phyton2
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("https://www.youtube.com/watch?v=vDa5Vt002IY")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start("https://www.youtube.com/watch?v=-kFBwApYVtA")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Process.Start("https://www.youtube.com/watch?v=iV-4F0jGWak")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start("https://www.youtube.com/watch?v=YEWxlbffgxE")
    End Sub

    Private Sub BtnPython1Menu_Click(sender As Object, e As EventArgs) Handles btnPython1Menu.Click
        Me.Close()
        Form_menu.Show()
    End Sub

    Private Sub BtnPython1Siguiente_Click(sender As Object, e As EventArgs) Handles btnPython1Siguiente.Click
        Me.Hide()
        Form_Phyton3.Show()
    End Sub

    Private Sub BtnPython1Salir_Click(sender As Object, e As EventArgs) Handles btnPython1Salir.Click
        Me.Close()
        Form_menu.Close()
        Form_Phyton.Close()
        Form_Phyton3.Close()
    End Sub
End Class