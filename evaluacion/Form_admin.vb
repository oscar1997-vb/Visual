Imports MySql.Data.MySqlClient
Public Class Form_admin
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

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim myconn As New MySqlConnection
        Dim command As MySqlCommand
        myconn.ConnectionString = "server=127.0.0.1;user id=root;password=12345678;database=vbb;persistsecurityinfo=True"

        Try
            If (txtCedula.Text <> "") Then
                myconn.Open()
                Dim docquery As String
                Dim rs As MySqlDataReader
                docquery = "select * from vbb.informacion where documento='" & txtCedula.Text & "'"
                command = New MySqlCommand(docquery, myconn)
                rs = command.ExecuteReader()
                rs.Read()
                txtNombres.Text = rs(0)
                txtApellidos.Text = rs(1)
                txtCorreo.Text = rs(3)
                txtTelefono.Text = rs(4)
                txtDireccion.Text = rs(5)
                txtPrograma.Text = rs(6)
                cbCursos.Text = rs(7)
                myconn.Close()
            Else
                MessageBox.Show("Ingrese un número de documento y haga click en buscar")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Conexion.ConnectionString = "server=127.0.0.1;user id=root;password=12345678;database=vbb;persistsecurityinfo=True"
            Dim consulta As String

            If (txtCedula.Text <> "") Then
                Conexion.Open()
                consulta = "delete from informacion where documento='" & txtCedula.Text & "'"
                comando = New MySqlCommand(consulta, Conexion)
                comando.ExecuteNonQuery()
                'MessageBox.Show(consulta)
                MsgBox("Se ha eliminado al usuario")
                Conexion.Close()
            Else
                MsgBox("Ingrese el número de cédula y haga click en el botón eliminar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Conexion.ConnectionString = "server=127.0.0.1;user id=root;password=12345678;database=vbb;persistsecurityinfo=True"
            Conexion.Open()
            Dim consulta As String

            If txtNombres.Text <> "" And txtApellidos.Text <> "" And txtCedula.Text <> "" And txtCorreo.Text <> "" And txtTelefono.Text <> "" And txtDireccion.Text <> "" And txtPrograma.Text <> "" And cbCursos.Text <> "" And txtPass.Text <> "" Then
                consulta = "update informacion set nombres='" & txtNombres.Text & "', apellidos='" & txtApellidos.Text & "', correo='" & txtCorreo.Text & "', telefono='" & txtTelefono.Text & "', direccion='" & txtDireccion.Text & "', programa='" & txtPrograma.Text & "', curso='" & cbCursos.Text & "', password='" & txtPass.Text & "' where documento='" & txtCedula.Text & "'"
                comando = New MySqlCommand(consulta, Conexion)
                comando.ExecuteNonQuery()
                MsgBox("Usuario modificado correctamente")
                Conexion.Close()
            Else
                MsgBox("Por favor diligencie todos los valores", MsgBoxStyle.Information)
                Conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class