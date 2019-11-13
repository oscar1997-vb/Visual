
Module comunes



    Public Sub limpiar_form_registro()
        Form_registro.TextBox1.Text = ""
        Form_registro.TextBox2.Text = ""
        Form_registro.TextBox3.Text = ""
        Form_registro.TextBox4.Text = ""
        Form_registro.TextBox5.Text = ""
        Form_registro.TextBox6.Text = ""
        Form_registro.TextBox7.Text = ""

    End Sub

    Public Function vacio_registro() As Boolean
        If Form_registro.TextBox1.Text Is "" Or Form_registro.TextBox2.Text Is "" Or Form_registro.TextBox3.Text Is "" Or Form_registro.TextBox4.Text Is "" Or Form_registro.TextBox5.Text Is "" Or Form_registro.TextBox6.Text Is "" Or Form_registro.TextBox7.Text Is "" Then
            Return True
        Else
            Return False
        End If
    End Function

    'Funcion utilizada para validar que solo se escriban letras dentro de un texbox
    Public Sub Letras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub
    'Funcion utilizada para validar que solo se escriban Números dentro de un texbox
    Public Sub Numeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub
End Module
