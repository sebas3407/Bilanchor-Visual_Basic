Imports System.IO


Public Class CrearEvento

    Dim nombre_vertical As String
    Dim nombre_horitzontal As String
    Dim dataTableEventos As DataTable
    Dim dataTableDescuentos As DataTable
    Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
    Dim comprobarcartel1, comprobarcartel2 As Boolean



    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RichTextBox4.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                MsgBox("Solo son permitidos números")
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub CrearEvento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        comprobarcartel1 = False
        comprobarcartel2 = False
        RichTextBox1.MaxLength = 50
        RichTextBox3.MaxLength = 400
        RichTextBox4.MaxLength = 3
        DateTimePicker1.MinDate = DateTime.Now.ToString("yyyy/MM/dd")

        For index As Integer = 16 To 35
            ComboBox1.Items.Add(index)
        Next

        ComboBox1.SelectedItem = 18

        DateTimePicker1.CustomFormat = " yyyy-MM-dd"
        DateTimePicker1.Format = DateTimePickerFormat.Custom

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If (RichTextBox1.Text.Equals("") Or RichTextBox3.Text.Equals("") Or RichTextBox4.Text.Equals("") Or comprobarcartel1 = False Or comprobarcartel2 = False) Then
            If (comprobarcartel1 = False Or comprobarcartel2 = False) Then


                MsgBox("Por favor, sube las imágenes del evento")

            Else
                MsgBox("Por favor, completa todos los campos")

            End If


        Else

            Try
                DataBaseHandler.conectarDB()

                Dim sqlQuery As String = "exec sp_crear_evento '" & RichTextBox1.Text & "', '" & DateTimePicker1.Text & " ','" & RichTextBox3.Text & "'," & ComboBox1.SelectedItem & ",'" & nombre_horitzontal & "','" & nombre_vertical & "','" & RichTextBox4.Text & "'"

                DataBaseHandler.executeQuery(sqlQuery)
                DataBaseHandler.desconectarDB()

                RichTextBox1.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = ""
                ComboBox1.SelectedItem = ""


                actualizarXmlEventos()
                actualizarXmlDescuentos()

                'Genera nuevamente los eventos
                inicio.actualizarEventos()

                MsgBox("Evento creado correctamente")

                Me.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Public Sub actualizarXmlEventos()
        Dim x As Integer = 0
        Dim ruta As String = "eventos.xml"

        Using archivo As New StreamWriter(ruta, False, utf8WithoutBom)
            archivo.WriteLine("<?xml version='1.0' encoding='utf-8'?>")
            archivo.WriteLine("<eventos>")
            Dim consultaEventos As String
            consultaEventos = "SELECT * FROM evento"

            DataBaseHandler.conectarDB()
            dataTableEventos = DataBaseHandler.consultarTableDB(consultaEventos)
            DataBaseHandler.desconectarDB()

            For Each row As DataRow In dataTableEventos.Rows

                archivo.WriteLine("<evento>")
                archivo.WriteLine("<id_evento>" & row.Item(0) & "</id_evento>")
                archivo.WriteLine("<nombre>" & row.Item(1) & "</nombre>")
                archivo.WriteLine("<fecha>" & row.Item(2) & "</fecha>")
                archivo.WriteLine("<descripcion>" & row.Item(3) & "</descripcion>")
                archivo.WriteLine("<edad_minima>" & row.Item(4) & "</edad_minima>")
                archivo.WriteLine("<imagen_horizontal>" & row.Item(5) & "</imagen_horizontal>")
                archivo.WriteLine("<imagen_vertical>" & row.Item(6) & "</imagen_vertical>")
                archivo.WriteLine("<precio>" & row.Item(7) & "</precio>")
                archivo.WriteLine("<ruta_album>" & row.Item(8) & "</ruta_album>")
                archivo.WriteLine("<portada_album>" & row.Item(9) & "</portada_album>")
                archivo.WriteLine("</evento>")
            Next
            archivo.WriteLine("</eventos>")
            archivo.Close()
            FTPHelper.uploadFile(ruta, “ftp://anchortechlleida.hol.es/archivos/” & ruta)

        End Using


    End Sub

    Public Sub actualizarXmlDescuentos()
        Dim x As Integer = 0
        Dim ruta As String = "descuentos.xml"

        Using archivo As New StreamWriter(ruta, False, utf8WithoutBom)
            archivo.WriteLine("<?xml version='1.0' encoding='utf-8'?>")
            archivo.WriteLine("<descuentos>")
            Dim consultaDescuentos As String
            consultaDescuentos = "SELECT * FROM descuento"

            DataBaseHandler.conectarDB()
            dataTableDescuentos = DataBaseHandler.consultarTableDB(consultaDescuentos)
            DataBaseHandler.desconectarDB()

            For Each row As DataRow In dataTableDescuentos.Rows
                archivo.WriteLine("<descuento>")
                archivo.WriteLine("<id_descuento>" & row.Item(0) & "</id_descuento>")
                archivo.WriteLine("<id_evento>" & row.Item(1) & "</id_evento>")
                archivo.WriteLine("<precio>" & row.Item(3) & "</precio>")
                archivo.WriteLine("</descuento>")
            Next
            archivo.WriteLine("</descuentos>")
            archivo.Close()
            FTPHelper.uploadFile(ruta, “ftp://anchortechlleida.hol.es/archivos/” & ruta)
        End Using
    End Sub

    Private Sub SubirCartel_Click(sender As Object, e As EventArgs) Handles SubirCartel.Click

        If UploadFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim fileName As String = UploadFileDialog.FileName
            Dim FileInfo As New FileInfo(fileName)
            FTPHelper.uploadFile(fileName, “ftp://anchortechlleida.hol.es/img/verticales/” & FileInfo.Name)
            nombre_vertical = "http://www.anchortechlleida.hol.es/img/verticales/" & FileInfo.Name
            SubirCartel.Enabled = False
            RichTextBox5.Text = FileInfo.Name
            comprobarcartel1 = True
        End If

    End Sub

    Private Sub SubirPortada_Click(sender As Object, e As EventArgs) Handles SubirPortada.Click


        If UploadFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim fileName As String = UploadFileDialog.FileName
            Dim FileInfo As New FileInfo(fileName)
            FTPHelper.uploadFile(fileName, “ftp://anchortechlleida.hol.es/img/horizontales/” & FileInfo.Name)
            nombre_horitzontal = "http://www.anchortechlleida.hol.es/img/horizontales/" & FileInfo.Name
            SubirPortada.Enabled = False
            RichTextBox6.Text = FileInfo.Name
            comprobarcartel2 = True
        End If
    End Sub
End Class