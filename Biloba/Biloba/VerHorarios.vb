Public Class VerHorarios
    Private Sub VerHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarDataGridViewAdmin()
    End Sub

    Public Sub llenarDataGridViewAdmin()

        DataBaseHandler.conectarDB()

        Dim consulta As String

        'si el usuario es un trabajador mostramos un menu sino mostramos otro
        If (inicio.foundW) Then
            'el trabajador solo puede ver su horario
            consulta = "select usuario.nombre, trabaja.*, evento.nombre as Nombre_Evento, evento.fecha from trabaja inner join evento on evento.id_evento = trabaja.id_evento inner join usuario on usuario.dni = trabaja.dni_usuario where trabaja.dni_usuario = '" & inicio.dni & "' order by evento.fecha"
        ElseIf (inicio.foundA) Then
            'el admin puede ver el horario de todos
            consulta = "select usuario.nombre, trabaja.*, evento.nombre as Nombre_Evento, evento.fecha from trabaja inner join evento on evento.id_evento = trabaja.id_evento inner join usuario on usuario.dni = trabaja.dni_usuario order by evento.fecha"
        End If

        DataGridView1.DataSource = DataBaseHandler.consultarTableDB(consulta)

        DataBaseHandler.desconectarDB()
        Me.DataGridView1.Columns(1).Visible = False

        Me.DataGridView1.Columns(2).Visible = False

    End Sub

End Class