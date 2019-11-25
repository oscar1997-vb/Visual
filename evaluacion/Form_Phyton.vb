Public Class Form_Phyton
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pbLinux.Click
        Process.Start("https://entrenamiento-python-basico.readthedocs.io/es/latest/leccion1/instalacion.html#instalando-python-en-un-linux")
    End Sub

    Private Sub PbWin_Click(sender As Object, e As EventArgs) Handles pbWin.Click
        Process.Start("https://www.youtube.com/watch?v=VTykmP-a2KY")
    End Sub

    Private Sub PbMac_Click(sender As Object, e As EventArgs) Handles pbMac.Click
        Process.Start("https://es.wikibooks.org/wiki/Python/Instalaci%C3%B3n_de_Python/Python_en_Mac_OS_X")
    End Sub

    Private Sub BtnPython1_Click(sender As Object, e As EventArgs) Handles btnPython1Siguiente.Click
        Me.Hide()
        Form_Phyton2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPython1Menu.Click
        Me.Close()
        Form_menu.Show()
    End Sub

    Private Sub BtnPython1Salir_Click(sender As Object, e As EventArgs) Handles btnPython1Salir.Click
        Me.Close()
        Form_menu.Close()
        Form_Phyton2.Close()
        Form_Phyton3.Close()
    End Sub

    Private Sub Form_Phyton_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class