Imports System.IO

Public Class CrearActividad


    Dim dataTable As DataTable
    Dim dataTableActividades As DataTable
    Dim nombre_horitzontal As String
    Dim comprobarcartel As Boolean
    Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
    Dim id_evento As Integer



    Private Sub GestionarActividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comprobarcartel = False

        llenarEventos()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (comprobarcartel = False Or RichTextBox1.Text.Equals("") Or RichTextBox3.Text.Equals("")) Then


            MsgBox("Introduce todos los datos de la actividad")

        Else



            Try

                DataBaseHandler.conectarDB()

                ' Dim sqlQuery As String = "  insert into lista_asistente values ('" & ComboBox1.SelectedItem & "', '" & ComboBox2.SelectedItem & "')"
                Dim sqlQuery2 As String = "select id_evento from evento where nombre = '" & ComboBox1.SelectedItem & "' "


                DataGridView1.DataSource = DataBaseHandler.consultarTableDB(sqlQuery2)

                DataBaseHandler.desconectarDB()

                id_evento = DataGridView1.CurrentRow.Cells(0).Value


                DataBaseHandler.conectarDB()

                ' Dim sqlQuery As String = "  insert into lista_asistente values ('" & ComboBox1.SelectedItem & "', '" & ComboBox2.SelectedItem & "')"
                Dim sqlQuery As String = "insert into actividad values ('" & RichTextBox1.Text & "','" & RichTextBox3.Text & "','" & nombre_horitzontal & "'," & id_evento & ")"

                DataBaseHandler.executeQuery(sqlQuery)
                DataBaseHandler.desconectarDB()

                CrearXMLActividades()

                'Genera nuevamente las actividades
                inicio.actualizarActividades()

                MsgBox("Actividad creada correctamente")

                Me.Close()


            Catch ex As Exception
                MsgBox("Esta actividad ya esta creada")

            End Try
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub
    Public Sub CrearXMLActividades()
        Dim x As Integer = 0
        Dim ruta As String = "actividades.xml"

        Using archivo As New StreamWriter(ruta, False, utf8WithoutBom)
            archivo.WriteLine("<?xml version='1.0' encoding='utf-8'?>")
            archivo.WriteLine("<actividades>")
            Dim consultaActividades As String
            consultaActividades = "SELECT * FROM actividad"

            DataBaseHandler.conectarDB()
            dataTableActividades = DataBaseHandler.consultarTableDB(consultaActividades)
            DataBaseHandler.desconectarDB()

            For Each row As DataRow In dataTableActividades.Rows
                archivo.WriteLine("<actividad>")
                archivo.WriteLine("<id_actividad>" & row.Item(0) & "</id_actividad>")
                archivo.WriteLine("<titulo_actividad>" & row.Item(1) & "</titulo_actividad>")
                archivo.WriteLine("<descripcion>" & row.Item(2) & "</descripcion>")
                archivo.WriteLine("<foto_actividad>" & row.Item(3) & "</foto_actividad>")
                archivo.WriteLine("<id_evento>" & row.Item(4) & "</id_evento>")
                archivo.WriteLine("</actividad>")
            Next
            archivo.WriteLine("</actividades>")
            archivo.Close()
            FTPHelper.uploadFile(ruta, “ftp://anchortechlleida.hol.es/archivos/” & ruta)

        End Using
    End Sub

    Public Sub llenarEventos()

        DataBaseHandler.conectarDB()

        Dim consulta As String
        consulta = "SELECT * FROM evento"

        dataTable = DataBaseHandler.consultarTableDB(consulta)

        DataBaseHandler.desconectarDB()

        For Each row As DataRow In dataTable.Rows

            ComboBox1.Items.Add(row.Item(1).ToString)
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If UploadFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim fileName As String = UploadFileDialog.FileName
            Dim FileInfo As New FileInfo(fileName)
            FTPHelper.uploadFile(fileName, “ftp://anchortechlleida.hol.es/img/horizontales/” & FileInfo.Name)
            nombre_horitzontal = "http://www.anchortechlleida.hol.es/img/horizontales/" & FileInfo.Name
            Button2.Enabled = False
            RichTextBox5.Text = FileInfo.Name
            comprobarcartel = True
        End If

    End Sub
End Class