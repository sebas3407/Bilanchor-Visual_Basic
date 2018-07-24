Public Class GestionarHorarios


    Dim dataTableTrabajos As DataTable

    Dim dataTableEventos As DataTable

    Dim id_evento As Integer

    Private Sub GestionarHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarDataGridView()
        llenarDataGridViewEventos()
        llenarDataGridViewTrabajadores()
        llenarListaTrabajos()

    End Sub
    Public Sub llenarDataGridView()
        DataBaseHandler.conectarDB()

        Dim consulta As String
        consulta = "SELECT tr.*, eve.nombre  FROM trabaja tr inner join evento eve on eve.id_evento = tr.id_evento "

        DataGridView2.DataSource = DataBaseHandler.consultarTableDB(consulta)


        DataBaseHandler.desconectarDB()
        Me.DataGridView2.Columns(1).Visible = False


    End Sub


    Public Sub llenarDataGridViewEventos()
        DataBaseHandler.conectarDB()

        Dim consulta As String
        consulta = "SELECT * from evento"

        dataTableEventos = DataBaseHandler.consultarTableDB(consulta)


        DataBaseHandler.desconectarDB()

        For Each row As DataRow In dataTableEventos.Rows

            ComboBox2.Items.Add(row.Item(1).ToString)
            ComboBox2.Text = row.Item(1).ToString
        Next



    End Sub

    Public Sub llenarDataGridViewTrabajadores()
        DataBaseHandler.conectarDB()

        Dim consulta As String
        consulta = "SELECT * from usuario where nombre <> 'root'"

        DataGridView3.DataSource = DataBaseHandler.consultarTableDB(consulta)


        DataBaseHandler.desconectarDB()
        'Me.DataGridView1.Columns(0).Visible = False
        Me.DataGridView3.Columns(2).Visible = False
        Me.DataGridView3.Columns(3).Visible = False
        Me.DataGridView3.Columns(4).Visible = False
        Me.DataGridView3.Columns(5).Visible = False
        Me.DataGridView3.Columns(6).Visible = False


    End Sub

    Public Sub llenarListaTrabajos()


        DataBaseHandler.conectarDB()

        Dim consulta As String
        consulta = "SELECT * FROM tipo_trabajo"

        dataTableTrabajos = DataBaseHandler.consultarTableDB(consulta)


        DataBaseHandler.desconectarDB()

        For Each row As DataRow In dataTableTrabajos.Rows

            ComboBox1.Items.Add(row.Item(0).ToString)
            ComboBox1.Text = row.Item(0).ToString


        Next

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try


            DataBaseHandler.conectarDB()

            Dim sqlQuery2 As String = "select id_evento from evento where nombre = '" & ComboBox2.SelectedItem & "' "

            DataGridView4.DataSource = DataBaseHandler.consultarTableDB(sqlQuery2)

            DataBaseHandler.desconectarDB()

            id_evento = DataGridView4.CurrentRow.Cells(0).Value



            DataBaseHandler.conectarDB()

            Dim sqlQuery As String = "  insert into trabaja values ('" & DataGridView3.CurrentRow.Cells(0).Value & "'," & id_evento & ",'" & ComboBox1.SelectedItem & "')"

            DataBaseHandler.executeQuery(sqlQuery)
            DataBaseHandler.desconectarDB()
            llenarDataGridView()
        Catch ex As Exception
            If (ex.Message.Contains("PRIMARY KEY")) Then


                MsgBox("Esta persona ya trabaja en el evento")

            End If

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            DataBaseHandler.conectarDB()

            Dim sqlQuery As String = "DELETE FROM trabaja WHERE dni_usuario='" & DataGridView2.CurrentRow.Cells(0).Value & "' and id_evento='" & DataGridView2.CurrentRow.Cells(1).Value & "'"

            DataBaseHandler.executeQuery(sqlQuery)
            DataBaseHandler.desconectarDB()

            llenarDataGridView()
            MsgBox("Eliminacion correcta")

        Catch ex As Exception

            MsgBox(ex.Message)



        End Try

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class