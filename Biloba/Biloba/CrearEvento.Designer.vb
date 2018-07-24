<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CrearEvento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrearEvento))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SubirCartel = New System.Windows.Forms.Button()
        Me.UploadFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RichTextBox5 = New System.Windows.Forms.RichTextBox()
        Me.SubirPortada = New System.Windows.Forms.Button()
        Me.RichTextBox6 = New System.Windows.Forms.RichTextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label1.Location = New System.Drawing.Point(124, 345)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label2.Location = New System.Drawing.Point(780, 439)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label3.Location = New System.Drawing.Point(89, 438)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Edad mínima:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label4.Location = New System.Drawing.Point(75, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Cartel principal:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label5.Location = New System.Drawing.Point(134, 391)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Precio:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(502, 668)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(305, 47)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Crear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label6.Location = New System.Drawing.Point(504, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(288, 34)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Crear nuevo evento"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.AcceptsTab = True
        Me.RichTextBox1.AutoWordSelection = True
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(206, 337)
        Me.RichTextBox1.Multiline = False
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.RightMargin = 50
        Me.RichTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.RichTextBox1.Size = New System.Drawing.Size(1000, 35)
        Me.RichTextBox1.TabIndex = 12
        Me.RichTextBox1.Text = ""
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownHeight = 5000
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IntegralHeight = False
        Me.ComboBox1.Location = New System.Drawing.Point(206, 435)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(563, 28)
        Me.ComboBox1.TabIndex = 11
        '
        'RichTextBox3
        '
        Me.RichTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox3.Location = New System.Drawing.Point(206, 481)
        Me.RichTextBox3.Margin = New System.Windows.Forms.Padding(9)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(1000, 150)
        Me.RichTextBox3.TabIndex = 14
        Me.RichTextBox3.Text = ""
        '
        'RichTextBox4
        '
        Me.RichTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox4.Location = New System.Drawing.Point(206, 384)
        Me.RichTextBox4.Margin = New System.Windows.Forms.Padding(9)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.Size = New System.Drawing.Size(1000, 35)
        Me.RichTextBox4.TabIndex = 15
        Me.RichTextBox4.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label7.Location = New System.Drawing.Point(96, 488)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Descripción:"
        '
        'SubirCartel
        '
        Me.SubirCartel.BackColor = System.Drawing.Color.White
        Me.SubirCartel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubirCartel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubirCartel.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.SubirCartel.Location = New System.Drawing.Point(418, 283)
        Me.SubirCartel.Name = "SubirCartel"
        Me.SubirCartel.Size = New System.Drawing.Size(192, 32)
        Me.SubirCartel.TabIndex = 17
        Me.SubirCartel.Text = "Subir cartel principal"
        Me.SubirCartel.UseVisualStyleBackColor = False
        '
        'UploadFileDialog
        '
        Me.UploadFileDialog.FileName = "UploadFileDialog"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label8.Location = New System.Drawing.Point(1210, 391)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "€"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label9.Location = New System.Drawing.Point(657, 292)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Cartel portada:"
        '
        'RichTextBox5
        '
        Me.RichTextBox5.AcceptsTab = True
        Me.RichTextBox5.AutoWordSelection = True
        Me.RichTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox5.Enabled = False
        Me.RichTextBox5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox5.ForeColor = System.Drawing.Color.Silver
        Me.RichTextBox5.Location = New System.Drawing.Point(206, 289)
        Me.RichTextBox5.Multiline = False
        Me.RichTextBox5.Name = "RichTextBox5"
        Me.RichTextBox5.RightMargin = 50
        Me.RichTextBox5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RichTextBox5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.RichTextBox5.Size = New System.Drawing.Size(198, 35)
        Me.RichTextBox5.TabIndex = 12
        Me.RichTextBox5.Text = "Ningún archivo selecionado"
        '
        'SubirPortada
        '
        Me.SubirPortada.BackColor = System.Drawing.Color.White
        Me.SubirPortada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubirPortada.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubirPortada.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.SubirPortada.Location = New System.Drawing.Point(1015, 285)
        Me.SubirPortada.Name = "SubirPortada"
        Me.SubirPortada.Size = New System.Drawing.Size(192, 32)
        Me.SubirPortada.TabIndex = 17
        Me.SubirPortada.Text = "Subir portada"
        Me.SubirPortada.UseVisualStyleBackColor = False
        '
        'RichTextBox6
        '
        Me.RichTextBox6.AcceptsTab = True
        Me.RichTextBox6.AutoWordSelection = True
        Me.RichTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox6.Enabled = False
        Me.RichTextBox6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox6.ForeColor = System.Drawing.Color.Silver
        Me.RichTextBox6.Location = New System.Drawing.Point(783, 292)
        Me.RichTextBox6.Multiline = False
        Me.RichTextBox6.Name = "RichTextBox6"
        Me.RichTextBox6.RightMargin = 50
        Me.RichTextBox6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RichTextBox6.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.RichTextBox6.Size = New System.Drawing.Size(225, 35)
        Me.RichTextBox6.TabIndex = 19
        Me.RichTextBox6.Text = "Ningún archivo selecionado"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.LightSeaGreen
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(845, 436)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(361, 26)
        Me.DateTimePicker1.TabIndex = 50
        Me.DateTimePicker1.Value = New Date(2017, 5, 16, 0, 0, 0, 0)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1278, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'CrearEvento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 741)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.RichTextBox6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SubirPortada)
        Me.Controls.Add(Me.SubirCartel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RichTextBox4)
        Me.Controls.Add(Me.RichTextBox3)
        Me.Controls.Add(Me.RichTextBox5)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CrearEvento"
        Me.Text = "Biloba - Crear nuevo evento"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents RichTextBox4 As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents SubirCartel As Button
    Friend WithEvents UploadFileDialog As OpenFileDialog
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents RichTextBox5 As RichTextBox
    Friend WithEvents SubirPortada As Button
    Friend WithEvents RichTextBox6 As RichTextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
