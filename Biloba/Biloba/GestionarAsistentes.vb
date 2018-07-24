Imports System.IO

Public Class GestionarAsistentes

    Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
    Dim dataTableAsistentes As DataTable




    Private Sub GestionarAsistentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarDataGridView()

        ComboBox1.Items.Add("Si")
        ComboBox1.Items.Add("No")


    End Sub

    Public Sub llenarDataGridView()

        DataBaseHandler.conectarDB()

        Dim consulta As String
        consulta = "SELECT * FROM asistente ORDER BY nombre"

        DataGridView1.DataSource = DataBaseHandler.consultarTableDB(consulta)


        DataBaseHandler.desconectarDB()

        Try
            If DataGridView1.CurrentRow.Cells(2).Value.Equals(True) Then
                ComboBox1.Text = "Si"
            Else
                ComboBox1.Text = "No"
            End If

        Catch
            ComboBox1.Text = "No"
        End Try



        Me.DataGridView1.Columns(2).Visible = False

        'Me.DataGridView1.Columns(0).Visible = False

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Try


            RichTextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
            RichTextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value


            If DataGridView1.CurrentRow.Cells(2).Value.Equals(True) Then
                ComboBox1.Text = "Si"
            Else
                ComboBox1.Text = "No"
            End If


        Catch ex As Exception

        End Try
    End Sub

    Public Sub actualizarXmlAsistentes()
        Dim x As Integer = 0
        Dim ruta As String = "asistentes.xml"

        Using archivo As New StreamWriter(ruta, False, utf8WithoutBom)
            archivo.WriteLine("<?xml version='1.0' encoding='utf-8'?>")
            archivo.WriteLine("<asistentes>")
            Dim consultaAsistentes As String
            consultaAsistentes = "SELECT * FROM asistente"

            DataBaseHandler.conectarDB()
            dataTableAsistentes = DataBaseHandler.consultarTableDB(consultaAsistentes)
            DataBaseHandler.desconectarDB()

            For Each row As DataRow In dataTableAsistentes.Rows
                archivo.WriteLine("<asistente>")
                archivo.WriteLine("<dni>" & row.Item(0) & "</dni>")
                archivo.WriteLine("<nombre>" & row.Item(1) & "</nombre>")
                archivo.WriteLine("<blacklist>" & row.Item(2) & "</blacklist>")
                archivo.WriteLine("</asistente>")
            Next
            archivo.WriteLine("</asistentes>")
            archivo.Close()
            FTPHelper.uploadFile(ruta, “ftp://anchortechlleida.hol.es/archivos/” & ruta)

        End Using

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim blacklist As Integer = 0

        If (ComboBox1.Text = "Si") Then
            blacklist = 1
        End If

        If (RichTextBox1.Text.Equals("") Or RichTextBox2.Text.Equals("")) Then
            MsgBox("Por favor, introduce todos los datos para continuar")
        Else

            Try
                DataBaseHandler.conectarDB()

                Dim sqlQuery As String = "exec sp_crear_asistente '" & RichTextBox1.Text & "', '" & RichTextBox2.Text & "','" & blacklist & "'"

                DataBaseHandler.executeQuery(sqlQuery)
                DataBaseHandler.desconectarDB()

                llenarDataGridView()
                MsgBox("Asistente creado correctamente")
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""

                actualizarXmlAsistentes()


            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Try
            DataBaseHandler.conectarDB()

            Dim sqlQuery As String = "DELETE FROM asistente WHERE dni='" & DataGridView1.CurrentRow.Cells(0).Value & "'"

            DataBaseHandler.executeQuery(sqlQuery)
            DataBaseHandler.desconectarDB()

            llenarDataGridView()
            MsgBox("Asistente eliminado correctamente")
            actualizarXmlAsistentes()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim blacklist As Integer = 0

        If (ComboBox1.Text = "Si") Then
            blacklist = 1
        End If

        If (RichTextBox1.Text.Equals("") Or RichTextBox2.Text.Equals("")) Then
            MsgBox("Por favor, introduce todos los datos para continuar")
        Else

            Try
                DataBaseHandler.conectarDB()

                Dim sqlQuery As String = "update asistente set dni ='" & RichTextBox1.Text & "', nombre = '" & RichTextBox2.Text & " ', blacklist = '" & blacklist & "' where dni='" & DataGridView1.CurrentRow.Cells(0).Value & "'"

                DataBaseHandler.executeQuery(sqlQuery)
                DataBaseHandler.desconectarDB()

                llenarDataGridView()
                MsgBox("Asistente actualizado correctamente")
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""

                actualizarXmlAsistentes()


            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class