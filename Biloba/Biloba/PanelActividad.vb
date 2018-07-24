Imports System.IO
Imports System.Net

Public Class PanelActividad

    Inherits System.Windows.Forms.Panel

    Private resolucion As Decimal = 5
    Private foto As PictureBox
    Private titulo As Label
    Private descripcion As Label
    Dim actiName As String
    Dim actiDescription As String
    Dim actiFoto As Bitmap

    Public Sub New(ByVal cnt As Integer)

        Me.Width = 190 * resolucion
        Me.Height = 33.3 * resolucion

        foto = New PictureBox
        titulo = New Label
        descripcion = New Label

        'Cartel del evento
        foto.SizeMode = PictureBoxSizeMode.StretchImage
        foto.Left = 5
        foto.Top = 5
        foto.Height = (Me.Height - 10)
        foto.Width = (400)

        'Nombre evento
        titulo.ForeColor = Color.DarkSlateGray
        titulo.Left = 410
        titulo.Top = 10
        titulo.Font = createTitleFont(titulo.Text)
        titulo.Height = 50
        titulo.Width = 500

        'Descripción
        descripcion.ForeColor = Color.Gray
        descripcion.Left = 410
        descripcion.Top = 35
        descripcion.Font = createTitleAge(descripcion.Text)
        descripcion.Height = 130
        descripcion.Width = 500

        Me.Controls.Add(descripcion)
        Me.Controls.Add(foto)
        Me.Controls.Add(titulo)

    End Sub

    Public Sub name(ByVal _name As String)

        Me.actiName = _name
        titulo.Text = _name

    End Sub


    Public Sub description(ByVal _description As String)

        Me.actiDescription = _description
        descripcion.Text = _description

    End Sub
    Public Sub actiimage(ByVal _ruta As String)

        Try
            Dim tClient As WebClient = New WebClient
            actiFoto = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(_ruta)))

            foto.Image = actiFoto

        Catch ex As Exception

        End Try
        Me.actiFoto = actiFoto

    End Sub

    Public Function createTitleFont(ByVal texto As String) As Font
        Return New Font(texto, 12, FontStyle.Bold)
    End Function

    Public Function createTitleAge(ByVal texto As String) As Font
        Return New Font(texto, 10, FontStyle.Regular)
    End Function

    Public Function getEspacioVertical() As Decimal
        Return (35 * resolucion)
    End Function

    Public Function getEspacioHorizontal() As Decimal
        Return (52 * resolucion)
    End Function
End Class