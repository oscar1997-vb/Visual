Public Class Form_registro
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form_menu.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click ' boton agregar 
        agregar_registro()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click ' boton eliminar
        If TextBox3.Text IsNot "" Then
            eliminar_registro(TextBox3.Text)
        Else
            MsgBox("Por favor digite la cedula del estudiante a eliminar ")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click ' boton buscar
        Form_busqueda.Show()

        'If Me.TextBox3.Text IsNot "" Then
        ' buscar_sql(Me.TextBox3.Text)
        ' Else
        'MsgBox("Por favor digite la Cedula del alumno a buscar ")
        ' End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click ' boton modificar 
        modificar_sql()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Letras(e)
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        Letras(e)
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        Numeros(e)
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        Numeros(e)
    End Sub

    Private Sub Form_registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ComboBox1.SelectedIndex = 0
    End Sub
End Class