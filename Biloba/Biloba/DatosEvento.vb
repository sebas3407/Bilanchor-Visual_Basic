Imports System.IO
Imports System.Net

Public Class DatosEvento


    Public id_evento As Integer
    Public nombre As String
    Public edad As Integer
    Public fecha As String
    Public descripcion As String
    Public foto As Bitmap
    Public album As String
    Dim comprobarcartel As Boolean
    Dim dataTableEventos As DataTable
    Dim dataTableDescuentos As DataTable
    Dim dataTableActividades As DataTable
    Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
    Private Sub DatosEvento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strFecha() As String
        strFecha = Split(fecha, "-")
        fecha = strFecha(2) & "/" & strFecha(1) & "/" & strFecha(0)
        Label1.Text = nombre
        Label2.Text = fecha
        Label3.Text = "+" & edad
        RichTextBox1.Text = descripcion
        cimage(foto)

        Me.Text = "Biloba - " + nombre

        linkFB.Hide()
        TextoLinkFB.Hide()
        BotonSubirFoto.Hide()
        archivo.Hide()
        SubirAlbum.Hide()
        fotoprincipal.Hide()
        Modificar.Hide()
        Eliminar.Hide()

        RichTextBox2.Hide()
        DateTimePicker1.Hide()
        ComboBox1.Hide()

        For index As Integer = 16 To 35
            ComboBox1.Items.Add(index)
        Next


        'Si eres administrador, mostrará un botón de añadir album
        If (inicio.foundA) Then
            linkFB.Show()
            TextoLinkFB.Show()
            BotonSubirFoto.Show()
            archivo.Show()
            SubirAlbum.Show()
            fotoprincipal.Show()
            Modificar.Show()
            Eliminar.Show()
        End If

        comprobarcartel = False

    End Sub

    Public Sub cimage(ByVal tImage As Bitmap)

        Try
            'Dim tClient As WebClient = New WebClient

            PictureBox1.Image = tImage

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BotonSubirFoto.Click

        If UploadFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim fileName As String = UploadFileDialog.FileName
            Dim FileInfo As New FileInfo(fileName)
            FTPHelper.uploadFile(fileName, “ftp://anchortechlleida.hol.es/img/album/” & FileInfo.Name)
            album = "http://www.anchortechlleida.hol.es/img/album/" & FileInfo.Name
            BotonSubirFoto.Enabled = False
            archivo.Text = FileInfo.Name
            comprobarcartel = True
        End If

    End Sub

    Private Sub SubirAlbum_Click(sender As Object, e As EventArgs) Handles SubirAlbum.Click


        If (TextoLinkFB.Text.Equals("") Or comprobarcartel = False) Then

            MsgBox("Por favor, completa todos los campos o sube la foto destacada")
        Else

            Try
                DataBaseHandler.conectarDB()

                Dim sqlQuery As String = "update evento set ruta_album = '" & TextoLinkFB.Text & "', portada_album = '" & album & "' where id_evento = " & id_evento & ";"

                DataBaseHandler.executeQuery(sqlQuery)
                DataBaseHandler.desconectarDB()

                actualizarXmlEventos()
                actualizarXmlDescuentos()

                'Genera nuevamente las fotos
                inicio.actualizarFotos()

                MsgBox("Evento actualizado correctamente")

            Catch ex As Exception
                MsgBox("Informacion incorrecta")
            End Try

        End If
    End Sub

    Private Sub Eliminar_Click_1(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult

        msg = "¿Estas seguro que desea eliminar el evento?"   ' Define message.
        style = MsgBoxStyle.DefaultButton2 Or
   MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
        title = "Eliminar evento"   ' Define title.
        ' Display message.
        response = MsgBox(msg, style, title)
        If response = MsgBoxResult.Yes Then   ' User chose Yes.

            Try

                DataBaseHandler.conectarDB()

                Dim sqlQuery As String = "DELETE FROM evento WHERE id_evento=" & id_evento

                DataBaseHandler.executeQuery(sqlQuery)
                DataBaseHandler.desconectarDB()

                actualizarXmlEventos()
                actualizarXmlDescuentos()
                CrearXMLActividades()

                'Genera nuevamente los eventos
                inicio.actualizarEventos()


                MsgBox("Evento eliminado correctamente")
                Me.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("No se ha podido eliminar el evento")
        End If
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

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click

        If Modificar.Text Is "Modificar evento" Then

            'Titulo
            RichTextBox2.Show()
            RichTextBox2.Text = Label1.Text

            'Fecha
            DateTimePicker1.Show()
            DateTimePicker1.Text = Label2.Text

            'Edad
            ComboBox1.Show()
            ComboBox1.Text = edad

            'Descripcion
            RichTextBox1.ReadOnly = False
            RichTextBox1.BorderStyle = BorderStyle.Fixed3D

            'Boton
            Modificar.Text = "Guardar"
            Modificar.BackColor = Color.LightSeaGreen
            Modificar.ForeColor = Color.White

        Else
            'Titulo
            RichTextBox2.Hide()
            Label1.Text = RichTextBox2.Text

            'Fecha
            DateTimePicker1.Hide()
            Label2.Text = DateTimePicker1.Text

            'Edad
            ComboBox1.Hide()
            If ComboBox1.SelectedItem Then
                Label3.Text = "+" & ComboBox1.Text
            End If

            'Descripcion
            RichTextBox1.ReadOnly = True
            RichTextBox1.BorderStyle = BorderStyle.None

            'Boton
            Modificar.Text = "Modificar evento"
            Modificar.BackColor = Color.White
            Modificar.ForeColor = Color.LightSeaGreen

            Try
                DataBaseHandler.conectarDB()
                'nombre fecha descripcion edad_minima precio
                Dim sqlQuery As String = "update evento set nombre ='" & RichTextBox2.Text & "',fecha = '" & DateTimePicker1.Text & "',edad_minima = '" & ComboBox1.Text & "',descripcion = '" & RichTextBox1.Text & "' where id_evento=" & id_evento & ""

                DataBaseHandler.executeQuery(sqlQuery)
                DataBaseHandler.desconectarDB()

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            actualizarXmlEventos()
            actualizarXmlDescuentos()

            'Genera nuevamente los eventos
            inicio.actualizarEventos()

            MsgBox("Se han guardado los cambios")
        End If
    End Sub
End Class