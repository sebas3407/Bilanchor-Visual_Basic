<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inicio))
        Me.MenuLateral = New System.Windows.Forms.MenuStrip()
        Me.EventosMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.FotosMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActividadMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAdministrador = New System.Windows.Forms.MenuStrip()
        Me.ActividadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearActividadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarActividadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerAsistentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevosAsistentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrabajadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearTrabajosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearDiasDeTrabajoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerHorarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuTrabajador = New System.Windows.Forms.MenuStrip()
        Me.AsistentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerHorarioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirEvento = New System.Windows.Forms.PictureBox()
        Me.splash = New System.Windows.Forms.PictureBox()
        Me.LISTA_ASISTENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DAM2PROJECTEANCHORDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EVENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuLateral.SuspendLayout()
        Me.MenuAdministrador.SuspendLayout()
        Me.MenuTrabajador.SuspendLayout()
        CType(Me.AñadirEvento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LISTA_ASISTENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAM2PROJECTEANCHORDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EVENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuLateral
        '
        Me.MenuLateral.BackColor = System.Drawing.Color.MediumTurquoise
        resources.ApplyResources(Me.MenuLateral, "MenuLateral")
        Me.MenuLateral.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EventosMenu, Me.FotosMenu, Me.ActividadMenu, Me.LoginMenu, Me.LogoutMenu})
        Me.MenuLateral.Name = "MenuLateral"
        '
        'EventosMenu
        '
        Me.EventosMenu.Checked = True
        Me.EventosMenu.CheckState = System.Windows.Forms.CheckState.Checked
        resources.ApplyResources(Me.EventosMenu, "EventosMenu")
        Me.EventosMenu.ForeColor = System.Drawing.Color.White
        Me.EventosMenu.Image = Global.Biloba.My.Resources.Resources.eventos
        Me.EventosMenu.Margin = New System.Windows.Forms.Padding(20, 20, 0, 0)
        Me.EventosMenu.Name = "EventosMenu"
        Me.EventosMenu.Padding = New System.Windows.Forms.Padding(10, 10, 75, 5)
        '
        'FotosMenu
        '
        resources.ApplyResources(Me.FotosMenu, "FotosMenu")
        Me.FotosMenu.ForeColor = System.Drawing.Color.White
        Me.FotosMenu.Image = Global.Biloba.My.Resources.Resources.fotos
        Me.FotosMenu.Margin = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.FotosMenu.Name = "FotosMenu"
        Me.FotosMenu.Padding = New System.Windows.Forms.Padding(10, 10, 75, 5)
        '
        'ActividadMenu
        '
        resources.ApplyResources(Me.ActividadMenu, "ActividadMenu")
        Me.ActividadMenu.ForeColor = System.Drawing.Color.White
        Me.ActividadMenu.Image = Global.Biloba.My.Resources.Resources.actividad
        Me.ActividadMenu.Margin = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.ActividadMenu.Name = "ActividadMenu"
        Me.ActividadMenu.Padding = New System.Windows.Forms.Padding(10, 10, 75, 5)
        '
        'LoginMenu
        '
        resources.ApplyResources(Me.LoginMenu, "LoginMenu")
        Me.LoginMenu.ForeColor = System.Drawing.Color.White
        Me.LoginMenu.Image = Global.Biloba.My.Resources.Resources.perfil
        Me.LoginMenu.Margin = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.LoginMenu.Name = "LoginMenu"
        Me.LoginMenu.Padding = New System.Windows.Forms.Padding(10, 10, 75, 5)
        '
        'LogoutMenu
        '
        resources.ApplyResources(Me.LogoutMenu, "LogoutMenu")
        Me.LogoutMenu.ForeColor = System.Drawing.Color.White
        Me.LogoutMenu.Image = Global.Biloba.My.Resources.Resources.perfil
        Me.LogoutMenu.Margin = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.LogoutMenu.Name = "LogoutMenu"
        Me.LogoutMenu.Padding = New System.Windows.Forms.Padding(10, 10, 75, 5)
        '
        'MenuAdministrador
        '
        Me.MenuAdministrador.BackColor = System.Drawing.Color.LightSeaGreen
        resources.ApplyResources(Me.MenuAdministrador, "MenuAdministrador")
        Me.MenuAdministrador.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActividadToolStripMenuItem, Me.EditarToolStripMenuItem, Me.VerToolStripMenuItem, Me.TrabajadoresToolStripMenuItem, Me.TestToolStripMenuItem})
        Me.MenuAdministrador.Name = "MenuAdministrador"
        '
        'ActividadToolStripMenuItem
        '
        Me.ActividadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearActividadToolStripMenuItem, Me.EliminarActividadToolStripMenuItem})
        Me.ActividadToolStripMenuItem.Name = "ActividadToolStripMenuItem"
        resources.ApplyResources(Me.ActividadToolStripMenuItem, "ActividadToolStripMenuItem")
        '
        'CrearActividadToolStripMenuItem
        '
        Me.CrearActividadToolStripMenuItem.Name = "CrearActividadToolStripMenuItem"
        resources.ApplyResources(Me.CrearActividadToolStripMenuItem, "CrearActividadToolStripMenuItem")
        '
        'EliminarActividadToolStripMenuItem
        '
        Me.EliminarActividadToolStripMenuItem.Name = "EliminarActividadToolStripMenuItem"
        resources.ApplyResources(Me.EliminarActividadToolStripMenuItem, "EliminarActividadToolStripMenuItem")
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerUsuariosToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        resources.ApplyResources(Me.EditarToolStripMenuItem, "EditarToolStripMenuItem")
        '
        'VerUsuariosToolStripMenuItem
        '
        Me.VerUsuariosToolStripMenuItem.Name = "VerUsuariosToolStripMenuItem"
        resources.ApplyResources(Me.VerUsuariosToolStripMenuItem, "VerUsuariosToolStripMenuItem")
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerAsistentesToolStripMenuItem, Me.NuevosAsistentesToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        resources.ApplyResources(Me.VerToolStripMenuItem, "VerToolStripMenuItem")
        '
        'VerAsistentesToolStripMenuItem
        '
        Me.VerAsistentesToolStripMenuItem.Name = "VerAsistentesToolStripMenuItem"
        resources.ApplyResources(Me.VerAsistentesToolStripMenuItem, "VerAsistentesToolStripMenuItem")
        '
        'NuevosAsistentesToolStripMenuItem
        '
        Me.NuevosAsistentesToolStripMenuItem.Name = "NuevosAsistentesToolStripMenuItem"
        resources.ApplyResources(Me.NuevosAsistentesToolStripMenuItem, "NuevosAsistentesToolStripMenuItem")
        '
        'TrabajadoresToolStripMenuItem
        '
        Me.TrabajadoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearTrabajosToolStripMenuItem, Me.CrearDiasDeTrabajoToolStripMenuItem, Me.VerHorarioToolStripMenuItem})
        Me.TrabajadoresToolStripMenuItem.Name = "TrabajadoresToolStripMenuItem"
        resources.ApplyResources(Me.TrabajadoresToolStripMenuItem, "TrabajadoresToolStripMenuItem")
        '
        'CrearTrabajosToolStripMenuItem
        '
        Me.CrearTrabajosToolStripMenuItem.Name = "CrearTrabajosToolStripMenuItem"
        resources.ApplyResources(Me.CrearTrabajosToolStripMenuItem, "CrearTrabajosToolStripMenuItem")
        '
        'CrearDiasDeTrabajoToolStripMenuItem
        '
        Me.CrearDiasDeTrabajoToolStripMenuItem.Name = "CrearDiasDeTrabajoToolStripMenuItem"
        resources.ApplyResources(Me.CrearDiasDeTrabajoToolStripMenuItem, "CrearDiasDeTrabajoToolStripMenuItem")
        '
        'VerHorarioToolStripMenuItem
        '
        Me.VerHorarioToolStripMenuItem.Name = "VerHorarioToolStripMenuItem"
        resources.ApplyResources(Me.VerHorarioToolStripMenuItem, "VerHorarioToolStripMenuItem")
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        resources.ApplyResources(Me.TestToolStripMenuItem, "TestToolStripMenuItem")
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuTrabajador
        '
        Me.MenuTrabajador.BackColor = System.Drawing.Color.LightSeaGreen
        Me.MenuTrabajador.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsistentesToolStripMenuItem, Me.HorarioToolStripMenuItem})
        resources.ApplyResources(Me.MenuTrabajador, "MenuTrabajador")
        Me.MenuTrabajador.Name = "MenuTrabajador"
        '
        'AsistentesToolStripMenuItem
        '
        Me.AsistentesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearListaToolStripMenuItem})
        resources.ApplyResources(Me.AsistentesToolStripMenuItem, "AsistentesToolStripMenuItem")
        Me.AsistentesToolStripMenuItem.Name = "AsistentesToolStripMenuItem"
        '
        'CrearListaToolStripMenuItem
        '
        Me.CrearListaToolStripMenuItem.Name = "CrearListaToolStripMenuItem"
        resources.ApplyResources(Me.CrearListaToolStripMenuItem, "CrearListaToolStripMenuItem")
        '
        'HorarioToolStripMenuItem
        '
        Me.HorarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerHorarioToolStripMenuItem1})
        resources.ApplyResources(Me.HorarioToolStripMenuItem, "HorarioToolStripMenuItem")
        Me.HorarioToolStripMenuItem.Name = "HorarioToolStripMenuItem"
        '
        'VerHorarioToolStripMenuItem1
        '
        Me.VerHorarioToolStripMenuItem1.Name = "VerHorarioToolStripMenuItem1"
        resources.ApplyResources(Me.VerHorarioToolStripMenuItem1, "VerHorarioToolStripMenuItem1")
        '
        'AñadirEvento
        '
        Me.AñadirEvento.BackColor = System.Drawing.Color.MediumTurquoise
        resources.ApplyResources(Me.AñadirEvento, "AñadirEvento")
        Me.AñadirEvento.Name = "AñadirEvento"
        Me.AñadirEvento.TabStop = False
        '
        'splash
        '
        Me.splash.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.splash, "splash")
        Me.splash.Name = "splash"
        Me.splash.TabStop = False
        '
        'LISTA_ASISTENTEBindingSource
        '
        Me.LISTA_ASISTENTEBindingSource.DataMember = "LISTA_ASISTENTE"
        '
        'inicio
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Controls.Add(Me.AñadirEvento)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.splash)
        Me.Controls.Add(Me.MenuLateral)
        Me.Controls.Add(Me.MenuAdministrador)
        Me.Controls.Add(Me.MenuTrabajador)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.HelpButton = True
        Me.MainMenuStrip = Me.MenuAdministrador
        Me.Name = "inicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuLateral.ResumeLayout(False)
        Me.MenuLateral.PerformLayout()
        Me.MenuAdministrador.ResumeLayout(False)
        Me.MenuAdministrador.PerformLayout()
        Me.MenuTrabajador.ResumeLayout(False)
        Me.MenuTrabajador.PerformLayout()
        CType(Me.AñadirEvento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.splash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LISTA_ASISTENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAM2PROJECTEANCHORDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EVENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuLateral As MenuStrip
    Friend WithEvents EventosMenu As ToolStripMenuItem
    Friend WithEvents FotosMenu As ToolStripMenuItem
    Friend WithEvents ActividadMenu As ToolStripMenuItem
    Friend WithEvents LoginMenu As ToolStripMenuItem
    Friend WithEvents MenuAdministrador As MenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerAsistentesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevosAsistentesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents splash As PictureBox
    Friend WithEvents MenuTrabajador As MenuStrip
    Friend WithEvents LISTA_ASISTENTEBindingSource As BindingSource
    Friend WithEvents DAM2PROJECTEANCHORDataSetBindingSource As BindingSource
    Friend WithEvents EVENTOBindingSource As BindingSource
    Friend WithEvents ActividadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutMenu As ToolStripMenuItem
    Friend WithEvents HorarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrabajadoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearDiasDeTrabajoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerHorarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerHorarioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CrearTrabajosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarActividadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearActividadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsistentesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearListaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirEvento As PictureBox
End Class
