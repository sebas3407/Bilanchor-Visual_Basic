Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading

Public Class inicio

    Dim pa1() As PanelEvento
    Dim pa1Shown As Boolean
    Dim numpaneles As Integer = 6
    Dim dataTable As DataTable
    Dim dataTableFoto As DataTable
    Dim dataTableActividad As DataTable
    Dim dataTableUsuarios As DataTable

    Dim estadisticaPrecioMedio As DataTable
    Dim asistentesPorEvento As DataTable

    Dim pa2() As PanelFoto
    Dim pa2Shown As Boolean
    Dim numfotos As Integer = 9

    Dim pa3() As PanelActividad
    Dim pa3Shown As Boolean
    Public numactividad As Integer = 5

    Dim foto As PictureBox
    Dim TextBox1 As TextBox
    Dim TextBox2 As TextBox

    Dim pa4Shown As Boolean

    Dim topMargin, leftMargin As Integer

    Public foundW As Boolean = False
    Public foundA As Boolean = False

    Public dni As String
    Public pwd As String

    Dim worker As Boolean = False
    Dim passworddesc As String
    Dim password As String

    ' ////////////////////////////////////////// ON LOAD //////////////////////////////////////////

    Public Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        foto = New PictureBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()

        MenuTrabajador.Hide() 'trabajadores
        MenuAdministrador.Hide() 'admin

        LogoutMenu.Visible = False

        ''ocultar iniciar sesion
        'TextBox1.Hide()
        'TextBox2.Hide()
        'Button1.Hide()
        'foto.Hide()

        llenarDataGridView()
        llenarDataGridView2()
        llenarDataGridView3()

        pa1Shown = True
        pa2Shown = False
        pa3Shown = False
        pa4Shown = False

        ReDim Preserve pa1(numpaneles)
        ReDim Preserve pa2(numfotos)
        ReDim Preserve pa3(numactividad)

        Dim resolucion As Decimal = 10.3

        topMargin = 50
        leftMargin = 275

        generarPanelesEvento(topMargin, leftMargin)
        generarPanelesFoto(topMargin, leftMargin)
        generarPanelesActividad(topMargin, leftMargin)
        generarCuenta(topMargin, leftMargin)

        EventosMenu.Font = createTitleFont(" Eventos")
        FotosMenu.Font = createTitleFont2(" Fotos")
        ActividadMenu.Font = createTitleFont2(" Actividad")
        LoginMenu.Font = createTitleFont2(" Login")

        splash.Hide()

    End Sub

    ' ////////////////////////////////////////// GENERAR EVENTOS //////////////////////////////////////////

    Public Sub generarPanelesEvento(ByVal topMargin As Integer, ByVal leftMargin As Integer)

        Dim i As Integer = 0

        For Each row As DataRow In dataTable.Rows

            pa1(i) = New PanelEvento()
            pa1(i).id_evento(row.Item(0))
            pa1(i).name(row.Item(1).ToString)
            pa1(i).data(row.Item(2).ToString)
            pa1(i).description(row.Item(3).ToString)
            pa1(i).age("+" & row.Item(4).ToString)
            pa1(i).cimage(row.Item(6).ToString)

            'Creacion de paneles de eventos
            If i Mod 3 = 0 And i <> 0 Then
                topMargin += pa1(i).getEspacioVertical()
                leftMargin = 275
            End If

            'Creamos un elemento nuevo como un panel
            pa1(i).Left = leftMargin
            pa1(i).Top = topMargin
            leftMargin += pa1(i).getEspacioHorizontal()

            'Agregamos control de formulario
            Me.Controls.Add(pa1(i))

            pa1(i).BackColor = Color.LightGray

            AddHandler pa1(i).Click, AddressOf MouseDown
            'AddHandler foto.Click, AddressOf MouseDown

            'mostrar panel
            pa1(i).Show()

            i = i + 1
        Next

    End Sub

    ' ////////////////////////////////////////// GENERAR FOTOS //////////////////////////////////////////

    Public Sub generarPanelesFoto(ByVal topMargin As Integer, ByVal leftMargin As Integer)

        Dim i As Integer = 0

        For Each row As DataRow In dataTableFoto.Rows

            pa2(i) = New PanelFoto(i)

            'Creacion de paneles de eventos
            If i Mod 3 = 0 And i <> 0 Then
                topMargin += pa2(i).getEspacioVertical()
                leftMargin = 275
            End If

            'Creamos un nuevo panel
            pa2(i).Name(row.Item(0).ToString)
            pa2(i).data(row.Item(1).ToString)
            pa2(i).Link(row.Item(2).ToString)
            pa2(i).cimage(row.Item(3).ToString)
            pa2(i).Text = i
            pa2(i).Left = leftMargin
            pa2(i).Top = topMargin
            If IsNothing(pa1(i)) Then

            Else
                leftMargin += pa1(i).getEspacioHorizontal()
            End If

            'Agregamos control de formulario
            Me.Controls.Add(pa2(i))

            pa2(i).BackColor = Color.LightGray

            AddHandler pa2(i).Click, AddressOf MouseDown
            'AddHandler foto.Click, AddressOf MouseDown

            'mostrar panel
            pa2(i).Hide()

            i = i + 1
        Next

    End Sub

    ' ////////////////////////////////////////// GENERAR ACTIVIDAD //////////////////////////////////////////

    Public Sub generarPanelesActividad(ByVal topMargin As Integer, ByVal leftMargin As Integer)

        Dim i As Integer = 0

        For Each row As DataRow In dataTableActividad.Rows

            pa3(i) = New PanelActividad(i)

            'Creacion de paneles de eventos
            If i Mod 1 = 0 And i <> 0 Then
                topMargin += pa3(i).getEspacioVertical()
                leftMargin = 275
            End If

            'Creamos un nuevo panel
            pa3(i).name(row.Item(1).ToString)
            pa3(i).description(row.Item(2).ToString)
            pa3(i).actiimage(row.Item(3).ToString)
            pa3(i).Text = i
            pa3(i).Left = leftMargin
            pa3(i).Top = topMargin
            If IsNothing(pa1(i)) Then

            Else
                leftMargin += pa1(i).getEspacioHorizontal()
            End If

            'Agregamos control de formulario
            Me.Controls.Add(pa3(i))

            pa3(i).BackColor = Color.LightGray

            'mostrar panel
            pa3(i).Hide()

            i = i + 1
        Next

    End Sub

    ' ////////////////////////////////////////// GENERAR LOGIN //////////////////////////////////////////

    Public Sub generarCuenta(ByVal topMargin As Integer, ByVal leftMargin As Integer)

        topMargin = 300
        leftMargin = 650

        'estilos de TextBox
        TextBox1.Text = "Usuario"
        TextBox1.Font = createTitleFont(Name)
        TextBox1.ForeColor = Color.Gray
        TextBox1.Left = leftMargin
        TextBox1.Top = topMargin
        TextBox1.Width = 250

        'estilos de TextBox
        TextBox2.Text = "Contraseña"
        TextBox2.Font = createTitleFont(Name)
        TextBox2.ForeColor = Color.Gray
        TextBox2.Left = leftMargin
        TextBox2.Top = topMargin + 45
        TextBox2.Width = 250

        'estilos de Button
        Button1.Text = "Login"
        Button1.Font = createTitleFont(Name)
        Button1.ForeColor = Color.White
        Button1.Left = leftMargin
        Button1.Top = topMargin + 90
        Button1.Width = 250
        Button1.Height = 40
        Button1.BackColor = Color.LightSeaGreen

        'creamos la Foto
        foto.Image = Image.FromFile("..\..\Resources\Login.png")
        foto.BackColor = Color.Transparent
        foto.SizeMode = PictureBoxSizeMode.StretchImage
        foto.Left = (leftMargin - 175)
        foto.Top = (topMargin - 10)
        foto.Height = 150
        foto.Width = 150

        'Agregamos control de formulario
        Me.Controls.Add(foto)
        Me.Controls.Add(TextBox1)
        Me.Controls.Add(TextBox2)

        AddHandler TextBox1.Click, AddressOf MouseDown
        AddHandler TextBox2.Click, AddressOf MouseDown

        'ocultar panel
        foto.Hide()
    End Sub

    ' ////////////////////////////////////////// CLICS DEL MENU SUPERIOR //////////////////////////////////////////

    Private Sub GestionarAsistentesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        GestionarAsistentes.Show()
    End Sub

    Private Sub CrearListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearListaToolStripMenuItem.Click
        GestionarListas.Show()
    End Sub

    Private Sub EliminarActividadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarActividadToolStripMenuItem.Click
        BorrarActividad.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles AñadirEvento.Click
        CrearEvento.Show()
    End Sub

    Private Sub VerHorarioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VerHorarioToolStripMenuItem1.Click
        VerHorarios.Show()
    End Sub

    Private Sub CrearActividadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearActividadToolStripMenuItem.Click
        CrearActividad.Show()
    End Sub

    Private Sub CrearDiasDeTrabajoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearDiasDeTrabajoToolStripMenuItem.Click
        GestionarHorarios.Show()
    End Sub

    Private Sub CrearTrabajosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearTrabajosToolStripMenuItem.Click
        GestionarTrabajos.Show()
    End Sub

    Private Sub VerHorarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerHorarioToolStripMenuItem.Click
        VerHorarios.Show()
    End Sub

    Private Sub VerUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerUsuariosToolStripMenuItem.Click
        GestionarUsuarios.Show()
    End Sub

    Private Sub VerAsistentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerAsistentesToolStripMenuItem.Click
        GestionarAsistentes.Show()
    End Sub

    Private Sub NuevosAsistentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevosAsistentesToolStripMenuItem.Click
        GestionarListas.Show()

    End Sub

    ' ////////////////////////////////////////// CLICS DEL MENU LATERAL //////////////////////////////////////////

    ' ////////////////////////////////////////// EVENTOS //////////////////////////////////////////

    Private Sub MenuLateral_Click(sender As Object, e As EventArgs) Handles EventosMenu.Click

        EventosMenu.Font = createTitleFont(" Eventos")
        FotosMenu.Font = createTitleFont2(" Fotos")
        ActividadMenu.Font = createTitleFont2(" Actividad")
        LoginMenu.Font = createTitleFont2(" Login")

        If pa1Shown Then
            Return
        End If

        For i = 0 To (numfotos - 1)
            If IsNothing(pa2(i)) Then

            Else
                pa2(i).Hide()
            End If
        Next
        For i = 0 To (numpaneles - 1)

            If IsNothing(pa1(i)) Then

            Else
                pa1(i).Show()
            End If
        Next
        For i = 0 To (numactividad - 1)
            If IsNothing(pa3(i)) Then

            Else
                pa3(i).Hide()
            End If

        Next

        'ocultar panel
        TextBox1.Hide()
        TextBox2.Hide()
        Button1.Hide()
        foto.Hide()

        If foundA = True Then
            AñadirEvento.Show()
        Else
            AñadirEvento.Hide()
        End If

        BackgroundImage = Nothing

        pa1Shown = True
        pa2Shown = False
        pa3Shown = False
        pa4Shown = False

    End Sub

    ' ////////////////////////////////////////// FOTOS //////////////////////////////////////////

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles FotosMenu.Click

        EventosMenu.Font = createTitleFont2(" Eventos")
        FotosMenu.Font = createTitleFont(" Fotos")
        ActividadMenu.Font = createTitleFont2(" Actividad")
        LoginMenu.Font = createTitleFont2(" Login")

        If pa2Shown Then
            Return
        End If

        For i = 0 To (pa1.Count - 1)
            If IsNothing(pa1(i)) Then

            Else
                pa1(i).Hide()
            End If
        Next
        For i = 0 To (numfotos - 1)
            If IsNothing(pa2(i)) Then

            Else
                pa2(i).Show()
            End If
        Next
        For i = 0 To (numactividad - 1)
            If IsNothing(pa3(i)) Then

            Else
                pa3(i).Hide()
            End If

        Next

        'ocultar panel
        TextBox1.Hide()
        TextBox2.Hide()
        Button1.Hide()
        foto.Hide()
        AñadirEvento.Hide()

        BackgroundImage = Nothing

        pa1Shown = False
        pa2Shown = True
        pa3Shown = False
        pa4Shown = False

    End Sub

    ' ////////////////////////////////////////// ACTIVIDAD //////////////////////////////////////////

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ActividadMenu.Click

        EventosMenu.Font = createTitleFont2(" Eventos")
        FotosMenu.Font = createTitleFont2(" Fotos")
        ActividadMenu.Font = createTitleFont(" Actividad")
        LoginMenu.Font = createTitleFont2(" Login")

        If pa3Shown Then
            Return
        End If

        For i = 0 To (numpaneles - 1)
            If IsNothing(pa1(i)) Then

            Else
                pa1(i).Hide()
            End If
        Next
        For i = 0 To (numfotos - 1)
            If IsNothing(pa2(i)) Then

            Else
                pa2(i).Hide()
            End If
        Next
        For i = 0 To (numactividad - 1)
            If IsNothing(pa3(i)) Then

            Else
                pa3(i).Show()
            End If

        Next

        BackgroundImage = Nothing

        'ocultar panel
        TextBox1.Hide()
        TextBox2.Hide()
        Button1.Hide()
        foto.Hide()
        AñadirEvento.Hide()

        pa1Shown = False
        pa2Shown = False
        pa3Shown = True
        pa4Shown = False


    End Sub

    ' ////////////////////////////////////////// LOGIN //////////////////////////////////////////

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles LoginMenu.Click

        EventosMenu.Font = createTitleFont2(" Eventos")
        FotosMenu.Font = createTitleFont2(" Fotos")
        ActividadMenu.Font = createTitleFont2(" Actividad")
        LoginMenu.Font = createTitleFont(" Login")

        If pa4Shown Then
            Return
        End If

        For i = 0 To (numpaneles - 1)
            If IsNothing(pa1(i)) Then

            Else
                pa1(i).Hide()
            End If
        Next
        For i = 0 To (numfotos - 1)
            If IsNothing(pa2(i)) Then

            Else
                pa2(i).Hide()
            End If
        Next
        For i = 0 To (numactividad - 1)
            If IsNothing(pa3(i)) Then

            Else
                pa3(i).Hide()
            End If

        Next

        'Mostrar panel
        TextBox1.Show()
        TextBox2.Show()
        Button1.Show()
        foto.Show()
        AñadirEvento.Hide()

        BackgroundImage = Image.FromFile("..\..\Resources\fondo.jpg")

        pa1Shown = False
        pa2Shown = False
        pa3Shown = False
        pa4Shown = True

        TextBox1.MaxLength = 9
        TextBox2.PasswordChar = "*"
        TextBox2.MaxLength = 14

    End Sub

    ' ////////////////////////////////////////// MOUSE DOWN EN LOGIN //////////////////////////////////////////

    Public Sub MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown

        If (sender.Text.Equals("Usuario") Or sender.Text.Equals("Contraseña")) Then
            If (sender.Text.Equals("Contraseña")) Then
                TextBox2.PasswordChar = "*"
            End If
            If e.Button = System.Windows.Forms.MouseButtons.Left Then
                sender.ForeColor = Color.Black
                sender.Text = ""
            End If
        End If

    End Sub

    ' ////////////////////////////////////////// ESTILOS DE TEXTO //////////////////////////////////////////

    Public Function createTitleFont(ByVal texto As String) As Font
        Return New Font(texto, 12, FontStyle.Bold)
    End Function

    Public Function createTitleFont2(ByVal texto As String) As Font
        Return New Font(texto, 12, FontStyle.Regular)
    End Function

    ' ////////////////////////////////////////// BOTÓN LOGIN //////////////////////////////////////////

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataBaseHandler.conectarDB()

        Dim consultaUsuarios As String
        consultaUsuarios = "SELECT * FROM usuario"

        dataTableUsuarios = DataBaseHandler.consultarTableDB(consultaUsuarios)

        DataBaseHandler.desconectarDB()

        dni = TextBox1.Text
        pwd = TextBox2.Text

        passworddesc = Encriptar(pwd)

        dni = dni.ToUpper

        For Each row As DataRow In dataTableUsuarios.Rows

            password = row.Item(2)

            If (dni.Equals(row.Item(0)) And passworddesc.Equals(password) And row.Item(6).Equals("Trabajador")) Then

                foundW = True
            End If
            If (dni.Equals(row.Item(0)) And passworddesc.Equals(password) And (row.Item(6).Equals("Administrador") Or row.Item(6).Equals("root"))) Then

                foundA = True
            End If
        Next

        'si el usuario es un trabajador mostramos un menu
        If (foundW) Then
            MenuTrabajador.Show()
            LoginMenu.Visible = False
            LogoutMenu.Visible = True
            TextBox1.Text = "Usuario"
            TextBox2.Text = "Contraseña"
            TextBox2.ForeColor = Color.Gray
            TextBox1.ForeColor = Color.Gray
            Me.MenuLateral_Click(Nothing, Nothing)

            'sino mostramos otro
        ElseIf (foundA) Then
            MenuAdministrador.Show()
            LoginMenu.Visible = False
            LogoutMenu.Visible = True
            TextBox1.Text = "Usuario"
            TextBox2.Text = "Contraseña"
            TextBox2.ForeColor = Color.Gray
            TextBox1.ForeColor = Color.Gray
            Me.MenuLateral_Click(Nothing, Nothing)
        Else

            MsgBox("Usuario o contraseña incorrectos")

        End If

        MenuAdministrador.Show()
        LoginMenu.Visible = False
        LogoutMenu.Visible = True
        TextBox1.Text = "Usuario"
        TextBox2.Text = "Contraseña"
        TextBox2.ForeColor = Color.Gray
        TextBox1.ForeColor = Color.Gray
        Me.MenuLateral_Click(Nothing, Nothing)
    End Sub

    ' ////////////////////////////////////////// BOTÓN LOGOUT //////////////////////////////////////////

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogoutMenu.Click

        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult

        msg = "¿Estas seguro que desea cerrar sesion?"   ' Define message.

        style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo

        title = "Cerrar sesión"   ' Define title.

        ' Display message.
        response = MsgBox(msg, style, title)
        If response = MsgBoxResult.Yes Then   ' User chose Yes.

            Try

                LoginMenu.Visible = True
                LogoutMenu.Visible = False

                AñadirEvento.Hide()

                MenuTrabajador.Hide() 'trabajadores
                MenuAdministrador.Hide() 'admin

                foundA = False
                foundW = False

                MsgBox("Sesion cerrada correctamente")

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

        ElseIf response = MsgBoxResult.No Then   ' User chose NO.

        Else
            MsgBox("No se ha podido cerrar sesion")
        End If

    End Sub

    ' ////////////////////////////////////////// CREAR XMLS //////////////////////////////////////////

    Private Sub SubirXMLToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim obj As Object
        Dim archivo As Object
        Dim x As Integer = 0
        Dim ruta As String = "eventos.xml"

        obj = CreateObject("Scripting.FileSystemObject")
        archivo = obj.CreateTextFile(ruta, True)
        archivo.WriteLine("<?xml version='1.0' encoding='utf-8'?>")
        archivo.WriteLine("<eventos>")

        For Each row As DataRow In dataTable.Rows

            archivo.WriteLine("<evento>")
            archivo.WriteLine("<id_evento>" & row.Item(0) & "</id_evento>")
            archivo.WriteLine("<nombre>" & row.Item(1) & "</nombre>")
            archivo.WriteLine("<fecha>" & row.Item(2) & "</fecha>")
            archivo.WriteLine("<descripcion>" & row.Item(3) & "</descripcion>")
            archivo.WriteLine("<edad>" & row.Item(4) & "</edad>")
            archivo.WriteLine("<imagen_vertical>" & row.Item(5) & "</imagen_vertical>")
            archivo.WriteLine("<imagen_horizontal>" & row.Item(6) & "</imagen_horizontal>")
            archivo.WriteLine("<precio>" & row.Item(7) & "</fotos>")
            archivo.WriteLine("<fotos>" & row.Item(8) & "</fotos>")
            archivo.WriteLine("</evento>")
        Next

        archivo.WriteLine("</eventos>")
        archivo.close()
        FTPHelper.uploadFile(ruta, “ftp://anchortechlleida.hol.es/img/verticales/” & ruta)

    End Sub

    ' ////////////////////////////////////////// LLENAR DATAGRIDS CON DATOS //////////////////////////////////////////

    'Eventos
    Public Sub llenarDataGridView()

        DataBaseHandler.conectarDB()

        Dim consulta As String
        consulta = "select top(6) *  from evento order by fecha"

        dataTable = DataBaseHandler.consultarTableDB(consulta)
        DataBaseHandler.desconectarDB()

    End Sub

    'Actividad
    Public Sub llenarDataGridView2()

        DataBaseHandler.conectarDB()

        Dim consulta As String
        consulta = "select *  from actividad order by id_actividad desc"

        dataTableActividad = DataBaseHandler.consultarTableDB(consulta)
        DataBaseHandler.desconectarDB()

    End Sub

    'Foto
    Public Sub llenarDataGridView3()

        DataBaseHandler.conectarDB()

        Dim consulta As String
        consulta = "select nombre, fecha, ruta_album, portada_album  from evento  where ruta_album <> 'null'"

        dataTableFoto = DataBaseHandler.consultarTableDB(consulta)
        DataBaseHandler.desconectarDB()

    End Sub

    ' ////////////////////////////////////////// ACTUALIZAR PANELES //////////////////////////////////////////

    Public Sub actualizarEventos()

        'Elimina los controles ya cargados del formulario
        For i = 0 To (pa1.Count - 1)
            Me.Controls.Remove(pa1(i))
        Next

        'Actualizamos los datos con la BBDD de eventos
        llenarDataGridView()

        'Generación de paneles
        topMargin = 50
        leftMargin = 275

        generarPanelesEvento(topMargin, leftMargin)

    End Sub

    Public Sub actualizarActividades()

        'Elimina los controles ya cargados del formulario
        For i = 0 To (pa3.Count - 1)
            Me.Controls.Remove(pa3(i))
        Next

        'Actualizamos los datos con la BBDD de eventos
        llenarDataGridView2()

        'Generación de paneles
        topMargin = 50
        leftMargin = 275

        generarPanelesActividad(topMargin, leftMargin)

    End Sub

    Public Sub actualizarFotos()

        'Elimina los controles ya cargados del formulario
        For i = 0 To (pa2.Count - 1)
            Me.Controls.Remove(pa2(i))
        Next

        'Actualizamos los datos con la BBDD de eventos
        llenarDataGridView3()

        'Generación de paneles
        topMargin = 50
        leftMargin = 275

        generarPanelesFoto(topMargin, leftMargin)

    End Sub

    ' ////////////////////////////////////////// FUNCIÓN ENCRIPTAR //////////////////////////////////////////

    Public Function Encriptar(ByVal cadena As String) As String
        Dim enc As New UTF8Encoding
        Dim data() As Byte = enc.GetBytes(cadena)
        Dim result() As Byte

        Dim sha As New SHA1CryptoServiceProvider

        result = sha.ComputeHash(data)

        Dim sb As New StringBuilder
        Dim max As Int32 = result.Length



        For i As Integer = 0 To max - 1

            'Convertimos los valores en hexadecimal
            'cuando tiene una cifra hay que rellenarlo con cero
            'para que siempre ocupen dos dígitos.
            If (result(i) < 16) Then
                sb.Append("0")
            End If
            sb.Append(result(i).ToString("x"))
        Next

        'Devolvemos la cadena con el hash en mayúsculas para que quede más chuli 🙂
        Return sb.ToString

    End Function

    Private Sub splash_Click(sender As Object, e As EventArgs) Handles splash.Click

    End Sub

    Private Sub MenuLateral_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    ' ////////////////////////////////////////// ESTADISTICAS JAVA //////////////////////////////////////////

    Private Sub TestToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click

        DataBaseHandler.conectarDB()

        Dim consulta As String
        consulta = "SELECT nombre, precio from evento"

        estadisticaPrecioMedio = DataBaseHandler.consultarTableDB(consulta)

        DataBaseHandler.desconectarDB()


        Dim obj As New Object
        Dim archivo As New Object
        Dim ruta As String = "estadisticas.txt" 'Ej: Documentos\archivo1.txt

        obj = CreateObject("Scripting.FileSystemObject")
        archivo = obj.CreateTextFile(ruta)
        'Luego agregas las lineas que quieras al archivo
        For Each row As DataRow In estadisticaPrecioMedio.Rows
            archivo.WriteLine(row.Item(0).ToString & "#" & row.Item(1).ToString)

        Next

        archivo.close() 'Al final cierras el archivo para que se libere de la memoria

        MsgBox("Estadisticas generadas correctamente")


    End Sub

End Class