Imports System.IO



Public Class BorrarActividad

    Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
    Dim dataTableActividades As DataTable

    Private Sub BorrarActividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llenarDataGridView()
    End Sub

    Public Sub llenarDataGridView()

        DataBaseHandler.conectarDB()

        Dim consulta As String
        'consulta = "select actividad.*, evento.nombre as NOMBRE_EVENTO from actividad left join evento on actividad.id_evento = evento.id_evento;"
        consulta = "select * from actividad"

        DataGridView1.DataSource = DataBaseHandler.consultarTableDB(consulta)
        Me.DataGridView1.Columns(0).Visible = False
        Me.DataGridView1.Columns(3).Visible = False
        Me.DataGridView1.Columns(4).Visible = False


        DataBaseHandler.desconectarDB()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            DataBaseHandler.conectarDB()

            Dim sqlQuery As String = "DELETE FROM actividad WHERE id_actividad='" & DataGridView1.CurrentRow.Cells(0).Value & "' or id_evento=null"

            DataBaseHandler.executeQuery(sqlQuery)
            DataBaseHandler.desconectarDB()

            'Genera nuevamente las actividades
            inicio.actualizarActividades()

            llenarDataGridView()

            CrearXMLActividades()

            MsgBox("Actividad eliminada correctamente")

            Me.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

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

End Class