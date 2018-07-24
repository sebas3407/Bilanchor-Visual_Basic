Imports System.IO
Imports System.Net

Public Class PanelFoto
    Inherits System.Windows.Forms.Panel

    Private resolucion As Decimal = 6.08
    Private foto As PictureBox
    Private titulo As Label
    Private fecha As Label
    Dim eventName As String
    Dim eventData As String
    Dim eventLink As String
    Dim eventFoto As Bitmap

    Public Sub New(ByVal cnt As Integer)

        Me.Width = 50 * resolucion
        Me.Height = 42 * resolucion

        foto = New PictureBox
        titulo = New Label
        fecha = New Label

        'Foto del evento
        foto.SizeMode = PictureBoxSizeMode.StretchImage
        foto.Left = 5
        foto.Top = 5
        foto.Height = (Me.Height - 40)
        foto.Width = (Me.Width - 10)

        'Nombre evento
        titulo.ForeColor = Color.DarkSlateGray
        titulo.Left = 2
        titulo.Top = 225
        titulo.Font = createTitleFont(titulo.Text)
        titulo.Height = 50
        titulo.Width = 200

        'fecha
        fecha.ForeColor = Color.LightSeaGreen
        fecha.Left = 210
        fecha.Top = 225
        fecha.Font = createTime(fecha.Text)
        fecha.Height = 50
        fecha.Width = 160
        AddHandler foto.Click, AddressOf MouseDown


        Me.Controls.Add(foto)
        Me.Controls.Add(titulo)
        Me.Controls.Add(fecha)


    End Sub

    Public Function createTitleFont(ByVal texto As String) As Font
        Return New Font(texto, 12, FontStyle.Bold)
    End Function

    Public Function createTime(ByVal texto As String) As Font
        Return New Font(texto, 12, FontStyle.Regular)
    End Function

    Public Function getEspacioVertical() As Decimal
        Return (45 * resolucion)
    End Function

    Public Function getEspacioHorizontal() As Decimal
        Return (52 * resolucion)
    End Function

    Public Sub MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown

        Try
            System.Diagnostics.Process.Start(Me.eventLink)
        Catch
            MsgBox("Lo sentimos, esta página no está disponible")
        End Try

    End Sub

    Public Sub Name(ByVal _name As String)
        Me.eventName = _name
        titulo.Text = _name
    End Sub

    Public Sub Link(ByVal _link As String)
        Me.eventLink = _link
    End Sub

    Public Sub data(ByVal _data As String)
        Me.eventData = _data
        fecha.Text = _data
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

End Class
