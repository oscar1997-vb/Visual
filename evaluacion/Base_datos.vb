Imports System.Data.SqlClient
Module Base_datos
    Dim conexion As SqlConnection
    Dim comandos As SqlCommand
    Dim resultado As SqlDataReader
    Dim resultados As String = ""

    Public Sub cerrar_sql()
        'conexion.Close()

    End Sub
    'funcion para validar el usuario y contraseña de ingreso
    Public Sub validar_psw(ByVal id_al As String, pswd As String)
        Dim resultado1 As SqlDataReader
        resultados = ""

        comandos = conexion.CreateCommand
        comandos.CommandText = "SELECT pass FROM Password where id_alumn='" & id_al & "'"
        resultado1 = comandos.ExecuteReader()
        Do While resultado1.Read()
            resultados = resultado1.GetString(0)
        Loop
        If resultados = pswd Then

            Form_Ingreso.Hide()
            Form_menu.Show()
        Else
            MsgBox("usuario o contraseña erronea")
        End If
        resultado1.Close()
    End Sub

    Public Sub conectar_sql()

        Try
            'creo el objeto  conexión con sql y establesco parametros de conexión
            conexion = New SqlConnection("Initial Catalog=Alumnos;" & "Data Source=localhost;Integrated Security=SSPI;" & "User Id=sql_user;Password=cajon76")
            conexion.Open()

        Catch exc As Exception
            MsgBox(exc)
        End Try
    End Sub

    Public Sub eliminar_registro(ByVal id As String)
        Dim confirmacion
        confirmacion = MsgBox("Esta operación eliminara el registro y no se prodra deshacer, esta seguro?", vbYesNo)
        If confirmacion = DialogResult.Yes Then

            comandos = conexion.CreateCommand
            comandos.CommandText = "DELETE FROM Password where id_alumn='" & id & "'"
            resultado = comandos.ExecuteReader()
            resultado.Close()
            comandos.CommandText = "DELETE FROM Alumno where Cedula='" & id & "'"
            resultado = comandos.ExecuteReader()
            resultado.Close()
            MsgBox("Registro eliminado correctamemnte")

        End If
        limpiar_form_registro()

    End Sub

    Public Sub agregar_registro()
        Dim valores As String = ""
        Dim codigo_curso = 0
        'asigno un los codigos relacionados al curso 
        Select Case Form_registro.cbCursos.SelectedIndex
            Case 0
                codigo_curso = 9081
            Case 1
                codigo_curso = 9082
            Case 2
                codigo_curso = 9083
            Case 3
                codigo_curso = 9084
            Case 4
                codigo_curso = 9085
            Case Else
                MsgBox("error al asignar codigo al curso seleccionado")

        End Select
        'armo el string de valores a utilizar con la sentencia de insersion
        valores = "'" & Form_registro.txtNombres.Text & "','" & Form_registro.txtApellidos.Text & "','" & Form_registro.txtCedula.Text & "','" & Form_registro.txtCorreo.Text & "','" & Form_registro.txtTelefono.Text & "','" & Form_registro.txtDireccion.Text & "','" & Form_registro.txtPrograma.Text & "','" & codigo_curso & "'"
        Try
            ' ejecuto comando insert sobre la base de datos
            comandos = conexion.CreateCommand
            comandos.CommandText = "INSERT INTO Alumno VALUES (" & valores & ")"
            resultado = comandos.ExecuteReader()
            resultado.Close()
            MsgBox("Registro añadido correctamente")
        Catch ex As Exception
            MsgBox(ex)
        End Try
        limpiar_form_registro()
    End Sub

    Public Sub buscar_sql(ByVal id As String)
        comandos = conexion.CreateCommand
        comandos.CommandText = "SELECT * FROM Alumno where Cedula='" & id & "'"
        resultado = comandos.ExecuteReader()
        Do While resultado.Read()
            Form_registro.txtNombres.Text = resultado.GetString(0)
            Form_registro.txtApellidos.Text = resultado.GetString(1)
            Form_registro.txtCedula.Text = resultado.GetString(2)
            Form_registro.txtCorreo.Text = resultado.GetString(4)
            Form_registro.txtTelefono.Text = resultado.GetString(7)
            Form_registro.txtDireccion.Text = resultado.GetString(3)
            Form_registro.txtPrograma.Text = resultado.GetString(5)

        Loop
        resultado.Close()
    End Sub

    Public Sub modificar_sql()
        Dim actualizar As String = ""
        Dim confirmar = vbYes
        Dim codigo_curso = 0

        Select Case Form_registro.cbCursos.SelectedIndex
            Case 0
                codigo_curso = 9081
            Case 1
                codigo_curso = 9082
            Case 2
                codigo_curso = 9083
            Case 3
                codigo_curso = 9084
            Case 4
                codigo_curso = 9085
            Case Else
                MsgBox("error al asignar codigo al curso seleccionado")
        End Select
        Try

            If (Form_registro.txtCedula.Text IsNot "") Then
                If (vacio_registro()) Then
                    confirmar = MsgBox("Existen campos en blanco esta seguro de continuar ", vbYesNo)
                End If

            Else
                MsgBox("por favor digite la cedula del alumno a modificar y luego haga click en buscar ")
                Form_busqueda.Show()
                Return
            End If
            If confirmar = vbYes Then
                actualizar = "Nombre = '" & Form_registro.txtNombres.Text & "',Apellido = '" & Form_registro.txtApellidos.Text & "',Cedula = '" & Form_registro.txtCedula.Text & "',Email = '" & Form_registro.txtCorreo.Text & "',Telefono = '" & Form_registro.txtTelefono.Text & "', Direccion = '" & Form_registro.txtDireccion.Text & "', Programa = '" & Form_registro.txtPrograma.Text & "',Cursos = '" & codigo_curso & "'"
                comandos = conexion.CreateCommand
                comandos.CommandText = "UPDATE Alumno SET " & actualizar & "Where Cedula = '" & Form_registro.txtCedula.Text & "'"
                resultado = comandos.ExecuteReader()
                resultado.Close()
                MsgBox("Registro actualizado correctamente ")
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
End Module
