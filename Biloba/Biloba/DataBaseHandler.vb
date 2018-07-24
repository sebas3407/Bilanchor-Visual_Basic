Imports System.Data.OleDb

' Modules are VB counterparts To C# Static classes. When your Class Is designed solely For helper functions And extension methods 
' And you don't want to allow inheritance and instantiation, you use a Module.

Module DataBaseHandler

    Private provider As String = "Provider = SQLOLEDB;"

    'Direcció utilitzada si ens connectem desde dintre de la xarxa
    'Private server As String = "Data Source = 192.168.1.26,1433; Network Library = DBMSSOCN;"

    'Direcció utilitzada si ens connectem desde fora de la xarxa
    Private server As String = "Data Source = 212.170.161.168,1433; Network Library = DBMSSOCN;"

    Private database As String = "Initial Catalog = DAM2_PROJECTE_ANCHOR;"
    Private user As String = "User ID = DAW2_Novainteractive;"
    Private pass As String = "Password = novaInteractive2018"

    Private connection As OleDbConnection = Nothing
    Private dataAdapter As OleDbDataAdapter = Nothing
    Private commandBuilder As OleDbCommandBuilder = Nothing

    'Tipus de comando diferent segons la operació a fer
    Enum Command
        Update = 0
        Insert = 1
        Delete = 2
    End Enum

    Public Sub conectarDB()
        Try
            Dim cadena As String = provider & server & database & user & pass

            connection = New OleDbConnection()
            connection.ConnectionString = cadena
            connection.Open()

        Catch oleException As OleDbException

        Catch exception As Exception

        End Try

    End Sub

    Public Sub desconectarDB()

        If IsNothing(connection) Then

        ElseIf connection.State = 1 Then
            connection.Dispose()

        End If

        connection = Nothing
        dataAdapter = Nothing
        commandBuilder = Nothing

    End Sub

    Public Function consultarReaderDB(ByVal selectQuery As String) As OleDbDataReader

        Dim comando As New OleDbCommand

        comando = New OleDbCommand(selectQuery, connection)
        Return comando.ExecuteReader

    End Function

    Public Function consultarTableDB(ByVal selectQuery As String) As DataTable

        Dim dataTable As DataTable = New DataTable()

        dataAdapter = New OleDbDataAdapter(selectQuery, connection)
        dataAdapter.Fill(dataTable)

        Return dataTable

    End Function

    'Necessita haber cridat el mètode consultarTableDB abans de fer-se servir
    Public Sub prepareCommand(ByVal Command)

        If IsNothing(dataAdapter) Then
            MsgBox("DataAdapter no inicializado. Has ejecutado antes: consultarTableDB ?")

        Else

            commandBuilder = New OleDbCommandBuilder(dataAdapter)
            commandBuilder.QuotePrefix = "["
            commandBuilder.QuoteSuffix = "]"

            If (Command = Command.Update) Then
                dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand

            ElseIf (Command = Command.Insert) Then
                dataAdapter.InsertCommand = commandBuilder.GetInsertCommand

            ElseIf (Command = Command.Delete) Then
                dataAdapter.DeleteCommand = commandBuilder.GetDeleteCommand

            End If

        End If

    End Sub

    'Necessita haber cridat el mètode prepareCommand abans de fer-se servir
    Public Sub executeCommand(ByVal dataTable As DataTable)

        If IsNothing(commandBuilder) Then
            MsgBox("CommandBuilder no inicializado. Has ejecutado antes prepareCommand ?")

        Else
            dataAdapter.Update(dataTable)

        End If

    End Sub

    'Executa la sentencia pasada per parametre
    Public Sub executeQuery(ByVal sqlQuery As String)

        Dim command As OleDbCommand
        command = New OleDbCommand(sqlQuery, connection)

        If (command.ExecuteNonQuery() > 0) Then
        Else
        End If

    End Sub

End Module