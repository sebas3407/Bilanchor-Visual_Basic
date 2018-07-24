Imports System.IO
Imports System.Net

Module FTPHelper

    Public Sub readDirectory(ByRef output As TextBox)

        Try

            Dim log As TextBox = CType(output, TextBox)
            log.Text = ""

            'Dim request As FtpWebRequest = FtpWebRequest.Create(“ftp://ftp.google.com”)
            Dim request As FtpWebRequest = FtpWebRequest.Create(“ftp://192.168.1.102”)
            request.Credentials = New NetworkCredential("vcasas@ilerna.com", "1234")
            request.Method = WebRequestMethods.Ftp.ListDirectory

            Dim sr As New StreamReader(request.GetResponse().GetResponseStream())
            Dim str As String = sr.ReadLine()
            While Not str Is Nothing
                log.AppendText(str & Environment.NewLine)
                str = sr.ReadLine()
            End While
            sr.Close()
            sr = Nothing
            request = Nothing

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub uploadFile(ByVal origFile As String, ByVal destFile As String)

        Dim ftpRequest As FtpWebRequest = CType(WebRequest.Create(destFile), FtpWebRequest)

        Try
            ftpRequest.Method = WebRequestMethods.Ftp.UploadFile
            ftpRequest.Credentials = New NetworkCredential("u447569669", "AnchorDSV1234")

            Dim bytes() As Byte = System.IO.File.ReadAllBytes(origFile)
            ftpRequest.ContentLength = bytes.Length

            Using UploadStream As Stream = ftpRequest.GetRequestStream()
                UploadStream.Write(bytes, 0, bytes.Length)
                UploadStream.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub

        End Try


    End Sub

    Public Sub downloadFile(ByVal origFile As String, ByVal destFile As String)

        Dim request As New WebClient()
        request.Credentials = New NetworkCredential("vcasas@ilerna.com", "1234")

        Dim bytes() As Byte = request.DownloadData(origFile)

        Try

            Dim downloadStream As FileStream = IO.File.Create(destFile)
            downloadStream.Write(bytes, 0, bytes.Length)
            downloadStream.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Exit Sub

        End Try


    End Sub


End Module
