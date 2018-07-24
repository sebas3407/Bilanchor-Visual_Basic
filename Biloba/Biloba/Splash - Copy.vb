Imports System.Threading

Public Class Splash

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        inicio.Show()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        inicio.Show()
        inicio.Hide()

    End Sub
End Class