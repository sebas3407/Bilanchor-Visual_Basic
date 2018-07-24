<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosEvento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatosEvento))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SubirAlbum = New System.Windows.Forms.Button()
        Me.BotonSubirFoto = New System.Windows.Forms.Button()
        Me.archivo = New System.Windows.Forms.RichTextBox()
        Me.TextoLinkFB = New System.Windows.Forms.RichTextBox()
        Me.fotoprincipal = New System.Windows.Forms.Label()
        Me.linkFB = New System.Windows.Forms.Label()
        Me.UploadFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label1.Location = New System.Drawing.Point(690, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Título"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(696, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "dia/mes/año"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Black
        Me.RichTextBox1.Location = New System.Drawing.Point(701, 157)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(536, 316)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Biloba.My.Resources.Resources.Evento1
        Me.PictureBox1.Location = New System.Drawing.Point(36, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(639, 940)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label3.Location = New System.Drawing.Point(698, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "+18"
        '
        'SubirAlbum
        '
        Me.SubirAlbum.BackColor = System.Drawing.Color.LightSeaGreen
        Me.SubirAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubirAlbum.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubirAlbum.ForeColor = System.Drawing.Color.White
        Me.SubirAlbum.Location = New System.Drawing.Point(697, 605)
        Me.SubirAlbum.Name = "SubirAlbum"
        Me.SubirAlbum.Size = New System.Drawing.Size(539, 47)
        Me.SubirAlbum.TabIndex = 11
        Me.SubirAlbum.Text = "Subir álbum"
        Me.SubirAlbum.UseVisualStyleBackColor = False
        '
        'BotonSubirFoto
        '
        Me.BotonSubirFoto.BackColor = System.Drawing.Color.White
        Me.BotonSubirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonSubirFoto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonSubirFoto.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.BotonSubirFoto.Location = New System.Drawing.Point(1043, 492)
        Me.BotonSubirFoto.Name = "BotonSubirFoto"
        Me.BotonSubirFoto.Size = New System.Drawing.Size(193, 32)
        Me.BotonSubirFoto.TabIndex = 22
        Me.BotonSubirFoto.Text = "Subir portada del álbum"
        Me.BotonSubirFoto.UseVisualStyleBackColor = False
        '
        'archivo
        '
        Me.archivo.AcceptsTab = True
        Me.archivo.AutoWordSelection = True
        Me.archivo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.archivo.Enabled = False
        Me.archivo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.archivo.ForeColor = System.Drawing.Color.Silver
        Me.archivo.Location = New System.Drawing.Point(820, 498)
        Me.archivo.Multiline = False
        Me.archivo.Name = "archivo"
        Me.archivo.RightMargin = 50
        Me.archivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.archivo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.archivo.Size = New System.Drawing.Size(199, 35)
        Me.archivo.TabIndex = 20
        Me.archivo.Text = "Ningún archivo selecionado"
        '
        'TextoLinkFB
        '
        Me.TextoLinkFB.AcceptsTab = True
        Me.TextoLinkFB.AutoWordSelection = True
        Me.TextoLinkFB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextoLinkFB.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoLinkFB.Location = New System.Drawing.Point(820, 546)
        Me.TextoLinkFB.Multiline = False
        Me.TextoLinkFB.Name = "TextoLinkFB"
        Me.TextoLinkFB.RightMargin = 50
        Me.TextoLinkFB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextoLinkFB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.TextoLinkFB.Size = New System.Drawing.Size(417, 35)
        Me.TextoLinkFB.TabIndex = 21
        Me.TextoLinkFB.Text = ""
        '
        'fotoprincipal
        '
        Me.fotoprincipal.AutoSize = True
        Me.fotoprincipal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fotoprincipal.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.fotoprincipal.Location = New System.Drawing.Point(698, 498)
        Me.fotoprincipal.Name = "fotoprincipal"
        Me.fotoprincipal.Size = New System.Drawing.Size(107, 18)
        Me.fotoprincipal.TabIndex = 19
        Me.fotoprincipal.Text = "Foto principal:"
        '
        'linkFB
        '
        Me.linkFB.AutoSize = True
        Me.linkFB.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkFB.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.linkFB.Location = New System.Drawing.Point(717, 554)
        Me.linkFB.Name = "linkFB"
        Me.linkFB.Size = New System.Drawing.Size(88, 18)
        Me.linkFB.TabIndex = 18
        Me.linkFB.Text = "Link de FB:"
        '
        'UploadFileDialog
        '
        Me.UploadFileDialog.FileName = "UploadFileDialog"
        '
        'Modificar
        '
        Me.Modificar.BackColor = System.Drawing.Color.White
        Me.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Modificar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modificar.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Modificar.Location = New System.Drawing.Point(698, 658)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(267, 47)
        Me.Modificar.TabIndex = 23
        Me.Modificar.Text = "Modificar evento"
        Me.Modificar.UseVisualStyleBackColor = False
        '
        'Eliminar
        '
        Me.Eliminar.BackColor = System.Drawing.Color.White
        Me.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Eliminar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar.ForeColor = System.Drawing.Color.Crimson
        Me.Eliminar.Location = New System.Drawing.Point(969, 658)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(267, 47)
        Me.Eliminar.TabIndex = 23
        Me.Eliminar.Text = "Eliminar evento"
        Me.Eliminar.UseVisualStyleBackColor = False
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.White
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox2.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold)
        Me.RichTextBox2.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.RichTextBox2.Location = New System.Drawing.Point(698, 39)
        Me.RichTextBox2.Multiline = False
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(466, 44)
        Me.RichTextBox2.TabIndex = 24
        Me.RichTextBox2.Text = ""
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.LightSeaGreen
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(698, 90)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(361, 26)
        Me.DateTimePicker1.TabIndex = 51
        Me.DateTimePicker1.Value = New Date(2017, 5, 16, 0, 0, 0, 0)
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownHeight = 5000
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IntegralHeight = False
        Me.ComboBox1.Location = New System.Drawing.Point(697, 124)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(91, 28)
        Me.ComboBox1.TabIndex = 52
        '
        'DatosEvento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1316, 1023)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.BotonSubirFoto)
        Me.Controls.Add(Me.archivo)
        Me.Controls.Add(Me.TextoLinkFB)
        Me.Controls.Add(Me.fotoprincipal)
        Me.Controls.Add(Me.linkFB)
        Me.Controls.Add(Me.SubirAlbum)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DatosEvento"
        Me.Text = "Biloba - "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SubirAlbum As Button
    Friend WithEvents BotonSubirFoto As Button
    Friend WithEvents archivo As RichTextBox
    Friend WithEvents TextoLinkFB As RichTextBox
    Friend WithEvents fotoprincipal As Label
    Friend WithEvents linkFB As Label
    Friend WithEvents UploadFileDialog As OpenFileDialog
    Friend WithEvents Modificar As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
End Class
