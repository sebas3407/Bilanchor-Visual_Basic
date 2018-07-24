Imports System.IO
Imports System.Net

Public Class PanelEvento
    Inherits System.Windows.Forms.Panel

    Private resolucion As Decimal = 16

    Private foto As PictureBox
    Private titulo As Label
    Private edad As Label
    Private DataGridView1 As DataGridView
    Dim eventId As Integer
    Dim eventName As String
    Dim eventAge As Integer
    Dim eventData As String
    Dim eventDescription As String
    Dim eventFoto As Bitmap

    Public Sub New()

        Me.Width = 18.5 * resolucion
        Me.Height = 27 * resolucion

        foto = New PictureBox
        titulo = New Label
        edad = New Label

        'Cartel del evento
        foto.SizeMode = PictureBoxSizeMode.StretchImage
        foto.Left = 5
        foto.Top = 5
        foto.Height = (Me.Height - 40)
        foto.Width = (Me.Width - 10)

        AddHandler foto.Click, AddressOf MouseDown

        'Nombre evento
        titulo.ForeColor = Color.DarkSlateGray
        titulo.Left = 2
        titulo.Top = 402
        titulo.Font = createTitleFont(titulo.Text)
        titulo.Height = 50
        titulo.Width = 255

        'edad
        edad.ForeColor = Color.LightSeaGreen
        edad.Left = 260
        edad.Top = 402
        edad.Font = createTitleAge(edad.Text)
        edad.Height = 20
        edad.Width = 50

        'Añadimos el control
        Me.Controls.Add(edad)
        Me.Controls.Add(foto)
        Me.Controls.Add(titulo)


    End Sub

    Public Sub MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            DatosEvento.id_evento = eventId
            DatosEvento.nombre = eventName
            DatosEvento.edad = eventAge
            DatosEvento.fecha = eventData
            DatosEvento.descripcion = eventDescription
            DatosEvento.foto = eventFoto
            DatosEvento.Show()
        End If

    End Sub

    Public Sub id_evento(ByVal _id As Integer)
        Me.eventId = _id
    End Sub

    Public Sub name(ByVal _name As String)
        Me.eventName = _name
        titulo.Text = _name
    End Sub
    Public Sub age(ByVal _age As String)
        Me.eventAge = _age
        edad.Text = _age
    End Sub

    Public Sub data(ByVal _data As String)
        Me.eventData = _data
        edad.Text = _data
    End Sub

    Public Sub description(ByVal _description As String)
        Me.eventDescription = _description
        edad.Text = _description
    End Sub

    Public Sub cimage(ByVal _ruta As String)
        Try
            Dim tClient As WebClient = New WebClient
            eventFoto = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(_ruta)))
            foto.Image = eventFoto
        Catch ex As Exception

        End Try
        Me.eventFoto = eventFoto
    End Sub

    Public Function createTitleFont(ByVal texto As String) As Font
        Return New Font(texto, 12, FontStyle.Bold)
    End Function

    Public Function createTitleAge(ByVal texto As String) As Font
        Return New Font(texto, 10, FontStyle.Regular)
    End Function

    Public Function getEspacioVertical() As Decimal
        Return (28 * resolucion)
    End Function

    Public Function getEspacioHorizontal() As Decimal
        Return (20 * resolucion)
    End Function

End Class
