Imports System.Security.Cryptography
Imports System.Text

Public Class GestionarUsuarios
    Dim password As String
    Dim check As Boolean = false
    Private Sub GestionarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarDataGridView()
        'TextBox1.PasswordChar = "*"
        ComboBox1.Items.Add("Administrador")
        ComboBox1.Items.Add("Trabajador")
        ComboBox1.SelectedItem = "Administrador"

        DateTimePicker1.MaxDate = DateTime.Now.ToString("yyyy/MM/dd")

        DateTimePicker1.CustomFormat = " yyyy-MM-dd"
        DateTimePicker1.Format = DateTimePickerFormat.Custom

        RichTextBox3.Text = ""
        RichTextBox2.Text = ""
        TextBox1.Text = ""
        DateTimePicker1.Text = DateTime.Now.ToString("yyyy/MM/dd")
        RichTextBox5.Text = ""
        RichTextBox6.Text = ""
        ComboBox1.Text = ""


    End Sub
    Public Sub llenarDataGridView()

        DataBaseHandler.conectarDB()

        Dim consulta As String
        consulta = "select * from usuario ORDER BY nombre;"
        '  consulta = "select * from usuario where nombre <> 'root' ORDER BY nombre;"

        DataGridView1.DataSource = DataBaseHandler.consultarTableDB(consulta)

        DataBaseHandler.desconectarDB()

        Me.DataGridView1.Columns(2).Visible = False

    End Sub


    Public Function Encriptar(ByVal cadena As String) As String
        Dim enc As New UTF8Encoding
        Dim data() As Byte = enc.GetBytes(cadena)
        Dim result() As Byte

        Dim sha As New SHA1CryptoServiceProvider

        result = sha.ComputeHash(data)

        Dim sb As New StringBuilder
        Dim max As Int32 = result.Length



        For i As Integer = 0 To max - 1


            'Convertimos los valores en hexadecimal
            'cuando tiene una cifra hay que rellenarlo con cero
            'para que siempre ocupen dos dígitos.
            If (result(i) < 16) Then
                sb.Append("0")
            End If

            sb.Append(result(i).ToString("x"))


        Next


        'Devolvemos la cadena con el hash en mayúsculas para que quede más chuli 🙂


        Return sb.ToString


    End Function

    Private Sub bt_nuevo_Click(sender As Object, e As EventArgs) Handles bt_nuevo.Click



        ' password = Encriptar(TextBox1.Text)



        Try
            DataBaseHandler.conectarDB()

            Dim sqlQuery As String = "exec sp_crear_usuario '" & RichTextBox3.Text.ToUpper & "','" & RichTextBox2.Text & "','" & TextBox1.Text & "','" & DateTimePicker1.Text & "','" & RichTextBox5.Text & "','" & RichTextBox6.Text & "','" & ComboBox1.SelectedItem.ToString & "'"


            DataBaseHandler.executeQuery(sqlQuery)
            DataBaseHandler.desconectarDB()

            llenarDataGridView()
            MsgBox("Usuario creado correctamente")

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As System.EventArgs) Handles DataGridView1.SelectionChanged

        If check = True Then

            Try
                RichTextBox3.Text = DataGridView1.CurrentRow.Cells(0).Value
                RichTextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value
                TextBox1.Text = DataGridView1.CurrentRow.Cells(2).Value
                DateTimePicker1.Text = DataGridView1.CurrentRow.Cells(3).Value
                RichTextBox5.Text = DataGridView1.CurrentRow.Cells(4).Value
                RichTextBox6.Text = DataGridView1.CurrentRow.Cells(5).Value
                ComboBox1.Text = DataGridView1.CurrentRow.Cells(6).Value

            Catch ex As Exception

            End Try
        End If
        check = True

    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click

        Try
            DataBaseHandler.conectarDB()

            Dim sqlQuery As String = "DELETE FROM USUARIO WHERE dni='" & DataGridView1.CurrentRow.Cells(0).Value & "'"

            DataBaseHandler.executeQuery(sqlQuery)
            DataBaseHandler.desconectarDB()

            llenarDataGridView()
            MsgBox("Usuario eliminado correctamente")

        Catch ex As Exception



            If (ex.Message.Contains("REFERENCE")) Then


                MsgBox("No se puede eliminar este usuario, ya que actualmente se encuentra en una lista de trabajo")

            End If


        End Try

    End Sub

    Private Sub bt_actual_Click(sender As Object, e As EventArgs) Handles bt_actual.Click
        password = Encriptar(TextBox1.Text)

        Try
            DataBaseHandler.conectarDB()


            Dim sqlQuery As String = "exec sp_actualizar_usuario '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "','" & RichTextBox3.Text.ToUpper & "','" & RichTextBox2.Text & "','" & password & "','" & DateTimePicker1.Text & "','" & RichTextBox5.Text & "','" & RichTextBox6.Text & "','" & ComboBox1.SelectedItem.ToString & "'"

            DataBaseHandler.executeQuery(sqlQuery)
            DataBaseHandler.desconectarDB()

            llenarDataGridView()
            MsgBox("Usuario actualizado correctamente")

        Catch ex As Exception

            If (ex.Message.Contains("REFERENCE")) Then


                MsgBox("No se puede actualizar este usuario, ya que actualmente se encuentra en una lista de trabajo")

            End If

        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged

    End Sub
End Class