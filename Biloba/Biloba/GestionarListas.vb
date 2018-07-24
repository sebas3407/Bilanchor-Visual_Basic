Public Class GestionarListas

    Dim dataTable As DataTable

    Dim id_evento As Integer
    Dim dni As String

    Private Sub GestionarListas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarDataGridView()
        llenarEventos()
        llenarDataGridView2()
        DataGridView1.Hide()
        DataGridView3.Hide()


        'si el usuario es un trabajador mostramos un menu sino mostramos otro
        If (inicio.foundW) Then
            'el trabajador no ve el botón de borrar
            Button2.Hide()

        ElseIf (inicio.foundA) Then
            'el admin puede ver el botón borrar
            Button2.Show()
        End If

    End Sub
    Public Sub llenarDataGridView()

        DataBaseHandler.conectarDB()

        Dim consulta As String
        consulta = "SELECT * FROM asistente where blacklist = 0"

        dataTable = DataBaseHandler.consultarTableDB(consulta)


        DataBaseHandler.desconectarDB()


        For Each row As DataRow In dataTable.Rows

            ComboBox2.Items.Add(row.Item(1).ToString)
        Next
    End Sub

    Public Sub llenarEventos()

        DataBaseHandler.conectarDB()

        Dim consulta As String
        consulta = "SELECT * FROM evento"

        dataTable = DataBaseHandler.consultarTableDB(consulta)


        DataBaseHandler.desconectarDB()

        For Each row As DataRow In dataTable.Rows

            ComboBox1.Items.Add(row.Item(1).ToString)
            ComboBox1.Text = row.Item(1).ToString
        Next





    End Sub



    Public Sub llenarDataGridView2()

        DataBaseHandler.conectarDB()

        Dim consulta As String
        consulta = "SELECT  ev.nombre as nombre_evento ,  asi.nombre as nombre , la.dni_asistente FROM lista_asistente la inner join evento ev on la.id_evento = ev.id_evento inner join asistente asi on asi.dni = la.dni_asistente order by ev.nombre, asi.nombre"

        DataGridView2.DataSource = DataBaseHandler.consultarTableDB(consulta)


        DataBaseHandler.desconectarDB()
        'Me.DataGridView1.Columns(2).Visible = False
    End Sub



    Private Sub DataGridView2_SelectionChanged(sender As Object, e As System.EventArgs) Handles DataGridView2.SelectionChanged


        Try
            ComboBox2.Text = DataGridView2.CurrentRow.Cells(1).Value

        Catch ex As Exception

        End Try




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            DataBaseHandler.conectarDB()

            ' Dim sqlQuery As String = "  insert into lista_asistente values ('" & ComboBox1.SelectedItem & "', '" & ComboBox2.SelectedItem & "')"
            Dim sqlQuery2 As String = "select id_evento from evento where nombre = '" & ComboBox1.SelectedItem & "' "

            DataGridView1.DataSource = DataBaseHandler.consultarTableDB(sqlQuery2)

            DataBaseHandler.desconectarDB()

            id_evento = DataGridView1.CurrentRow.Cells(0).Value


            DataBaseHandler.conectarDB()

            ' Dim sqlQuery As String = "  insert into lista_asistente values ('" & ComboBox1.SelectedItem & "', '" & ComboBox2.SelectedItem & "')"
            Dim sqlQuery3 As String = "select dni from asistente where nombre = '" & ComboBox2.SelectedItem & "' "

            DataGridView3.DataSource = DataBaseHandler.consultarTableDB(sqlQuery3)

            DataBaseHandler.desconectarDB()

            dni = DataGridView3.CurrentRow.Cells(0).Value

            DataBaseHandler.conectarDB()

            ' Dim sqlQuery As String = "  insert into lista_asistente values ('" & ComboBox1.SelectedItem & "', '" & ComboBox2.SelectedItem & "')"
            Dim sqlQuery As String = "  insert into lista_asistente values ('" & id_evento & "', '" & dni & "')"

            DataBaseHandler.executeQuery(sqlQuery)
            DataBaseHandler.desconectarDB()

        Catch ex As Exception

            MsgBox("Esta persona ya esta registrada en la lista")

        End Try

        llenarDataGridView2()
    End Sub





    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        DataBaseHandler.conectarDB()

        ' Dim sqlQuery As String = "  insert into lista_asistente values ('" & ComboBox1.SelectedItem & "', '" & ComboBox2.SelectedItem & "')"
        Dim sqlQuery2 As String = "select id_evento from evento where nombre = '" & ComboBox1.SelectedItem & "' "


        DataGridView1.DataSource = DataBaseHandler.consultarTableDB(sqlQuery2)

        DataBaseHandler.desconectarDB()

        id_evento = DataGridView1.CurrentRow.Cells(0).Value


        DataBaseHandler.conectarDB()

        Dim consulta As String
        consulta = "SELECT * FROM lista_asistente where id_evento =" & id_evento

        DataGridView2.DataSource = DataBaseHandler.consultarTableDB(consulta)
        Me.DataGridView2.Columns(0).Visible = False


        DataBaseHandler.desconectarDB()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try


            DataBaseHandler.conectarDB()

            ' Dim sqlQuery As String = "  insert into lista_asistente values ('" & ComboBox1.SelectedItem & "', '" & ComboBox2.SelectedItem & "')"
            Dim sqlQuery2 As String = "select dni from asistente where nombre = '" & ComboBox2.SelectedItem & "' "

            DataGridView3.DataSource = DataBaseHandler.consultarTableDB(sqlQuery2)

            DataBaseHandler.desconectarDB()

            dni = DataGridView3.CurrentRow.Cells(0).Value



            DataBaseHandler.conectarDB()

            Dim consulta As String
            consulta = "delete FROM lista_asistente where id_evento =  " & id_evento & " and dni_asistente = '" & dni & "'"

            DataGridView2.DataSource = DataBaseHandler.consultarTableDB(consulta)

            MsgBox("Asistente eliminado del evento")
            llenarDataGridView2()


            DataBaseHandler.desconectarDB()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class