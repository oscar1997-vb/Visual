Imports MySql.Data.MySqlClient
Public Class Form_registro
    Dim Conexion As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim comando As New MySqlCommand
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form_Ingreso.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click ' boton agregar 
        Try
            Conexion.ConnectionString = "server=127.0.0.1;user id=root;password=12345678;database=vbb;persistsecurityinfo=True"
            Conexion.Open()
            Dim consulta As String
            Dim nombres As String = txtNombres.Text
            Dim apellidos As String = txtApellidos.Text
            Dim documento As String = txtCedula.Text
            Dim correo As String = txtCorreo.Text
            Dim telefono As String = txtTelefono.Text
            Dim direccion As String = txtDireccion.Text
            Dim programa As String = txtPrograma.Text
            Dim curso As String = cbCursos.Text
            Dim password As String = txtPass.Text

            If txtNombres.Text <> "" And txtApellidos.Text <> "" And txtCedula.Text <> "" And txtCorreo.Text <> "" And txtTelefono.Text <> "" And txtDireccion.Text <> "" And txtPrograma.Text <> "" And cbCursos.Text <> "" Then
                consulta = "insert into informacion values ('" & nombres & "','" & apellidos & "','" & documento & "','" & correo & "','" & telefono & "','" & direccion & "','" & programa & "','" & curso & "','" & password & "')"
                comando = New MySqlCommand(consulta, Conexion)
                comando.ExecuteNonQuery()
                MsgBox("Usuario creado correctamente")
                Conexion.Close()
                Me.Close()
                Form_Ingreso.Show()
            Else
                MsgBox("Por favor diligencie todos los valores", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)  ' boton eliminar
        If txtCedula.Text IsNot "" Then
            eliminar_registro(txtCedula.Text)
        Else
            MsgBox("Por favor digite la cedula del estudiante a eliminar ")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)  ' boton modificar 
        modificar_sql()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombres.KeyPress
        Letras(e)
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidos.KeyPress
        Letras(e)
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCedula.KeyPress
        Numeros(e)
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        Numeros(e)
    End Sub

    Private Sub Form_registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cbCursos.SelectedIndex = 0
    End Sub

End Class