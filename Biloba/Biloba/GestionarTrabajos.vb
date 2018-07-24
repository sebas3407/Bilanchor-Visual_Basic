Public Class GestionarTrabajos
    Private Sub GestionarTrabajos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llenarDatagridView()
    End Sub

    Private Sub llenarDatagridView()
        DataBaseHandler.conectarDB()

        Dim consulta As String
        consulta = "SELECT * FROM tipo_trabajo"

        DataGridView1.DataSource = DataBaseHandler.consultarTableDB(consulta)


        DataBaseHandler.desconectarDB()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            DataBaseHandler.conectarDB()

            Dim sqlQuery As String = "Insert into tipo_trabajo values ('" & RichTextBox1.Text & "')"

            DataBaseHandler.executeQuery(sqlQuery)
            DataBaseHandler.desconectarDB()

            RichTextBox1.Text = ""

            MsgBox("Trabajo creado correctamente")
            llenarDatagridView()


        Catch ex As Exception

            If (ex.Message.Contains("PRIMARY KEY")) Then


                MsgBox("Este trabajo ya existe")

            End If
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            DataBaseHandler.conectarDB()

            Dim sqlQuery As String = "delete from tipo_trabajo where tipo_trabajo = '" & RichTextBox1.Text & "'"

            DataBaseHandler.executeQuery(sqlQuery)
            DataBaseHandler.desconectarDB()

            RichTextBox1.Text = ""

            MsgBox("Trabajo eliminado correctamente")
            llenarDatagridView()


        Catch ex As Exception



            If (ex.Message.Contains("REFERENCE")) Then


                MsgBox("No se puede eliminar este trabajo, ya que actualmente se encuentra en una lista de trabajo")

            End If

        End Try
    End Sub


    'Llenar 2 TextBox con el contenido de la fila de la DataGridView actualmente seleccionada
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Try
            RichTextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value




        Catch ex As Exception



        End Try

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            DataBaseHandler.conectarDB()

            Dim sqlQuery As String = "update tipo_trabajo set tipo_trabajo ='" & RichTextBox1.Text & "' where tipo_trabajo = '" & DataGridView1.CurrentRow.Cells(0).Value & "'"

            DataBaseHandler.executeQuery(sqlQuery)
            DataBaseHandler.desconectarDB()

            MsgBox("Trabajo actualizado correctamente")
            llenarDatagridView()


        Catch ex As Exception



            If (ex.Message.Contains("REFERENCE")) Then


                MsgBox("No se puede actualizar este trabajo, ya que actualmente se encuentra en una lista de trabajo")

            End If

        End Try
    End Sub
End Class