Public Class Form_Phyton3
    Private Sub BtnPython1Menu_Click(sender As Object, e As EventArgs) Handles btnPython1Menu.Click
        Me.Close()
        Form_menu.Show()
    End Sub

    Private Sub BtnPython1Siguiente_Click(sender As Object, e As EventArgs) Handles btnPython1Siguiente.Click
        Me.Hide()
        Form_Phyton2.Show()
    End Sub

    Private Sub BtnPython1Salir_Click(sender As Object, e As EventArgs) Handles btnPython1Salir.Click
        Me.Close()
        Form_menu.Close()
        Form_Phyton.Close()
        Form_Phyton2.Close()
    End Sub
End Class