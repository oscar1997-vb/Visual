Imports MySql.Data.MySqlClient

Public Class Form_Ingreso
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myconn As New MySqlConnection
        Dim command As MySqlCommand
        myconn.ConnectionString = "server=127.0.0.1;user id=root;password=12345678;database=vbb;persistsecurityinfo=True"

        Try
            myconn.Open()
            Dim passquery As String
            Dim rs As MySqlDataReader
            Dim pass As String
            passquery = "select password from vbb.informacion where documento='" & txtCodigo.Text & "'"
            command = New MySqlCommand(passquery, myconn)
            rs = command.ExecuteReader()
            rs.Read()
            pass = rs(0)

            If (txtCodigo.Text = "1") Then
                If (txtPassword.Text = pass) Then
                    MsgBox("Ingresando...")
                    Me.Hide()
                    Form_admin.Show()
                Else
                    MsgBox("Contraseña incorrecta")
                End If
            ElseIf (txtCodigo.Text <> "1") Then
                If (txtPassword.Text = pass) Then
                    MsgBox("Ingresando...")
                    Me.Hide()
                    Form_menu.Show()
                Else
                    MsgBox("Contraseña incorrecta")
                End If
                myconn.Close()
            End If
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_sql()
    End Sub

    Private Sub BtnIngReg_Click(sender As Object, e As EventArgs) Handles btnIngReg.Click
        Me.Hide()
        Form_registro.Show()
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
