Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cerrar_sql()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        validar_psw(Me.TextBox1.Text, Me.TextBox2.Text)




    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_sql()
    End Sub

    'Private Sub iniciar_evaluación(sender As Object, e As EventArgs) Handles Button1.Click
    ' TextBox1.Text = "" Then
    '       MsgBox("El campo Nombre es obligatorio ")
    'lse
    ' Me.Hide()
    '       Form2.Label3.Text = TextBox1.Text
    '        Form2.Show()
    '      ocultar()
    '   End If


    ' End Sub
End Class
