<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_Muestras_Tipo
    Inherits Wisej.Web.Form

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Wisej Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Wisej Designer
    'It can be modified using the Wisej Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New Wisej.Web.Panel()
        Me.CVE_TIPO = New Wisej.Web.Label()
        Me.CVE_TIPO_MUESTRA = New Wisej.Web.TextBox()
        Me.NUEVO = New Wisej.Web.Button()
        Me.GUARDAR = New Wisej.Web.Button()
        Me.Label2 = New Wisej.Web.Label()
        Me.DESCRIPCION = New Wisej.Web.TextBox()
        Me.Label1 = New Wisej.Web.Label()
        Me.NOMBRE = New Wisej.Web.TextBox()
        Me.ErrorProvider1 = New Wisej.Web.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CVE_TIPO)
        Me.Panel1.Controls.Add(Me.CVE_TIPO_MUESTRA)
        Me.Panel1.Controls.Add(Me.NUEVO)
        Me.Panel1.Controls.Add(Me.GUARDAR)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DESCRIPCION)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.NOMBRE)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(377, 311)
        Me.Panel1.TabIndex = 0
        '
        'CVE_TIPO
        '
        Me.CVE_TIPO.AutoSize = True
        Me.CVE_TIPO.Location = New System.Drawing.Point(141, 25)
        Me.CVE_TIPO.Name = "CVE_TIPO"
        Me.CVE_TIPO.Size = New System.Drawing.Size(99, 16)
        Me.CVE_TIPO.TabIndex = 15
        Me.CVE_TIPO.Text = "Clave Primaria:"
        Me.CVE_TIPO.Visible = False
        '
        'CVE_TIPO_MUESTRA
        '
        Me.CVE_TIPO_MUESTRA.Location = New System.Drawing.Point(61, 47)
        Me.CVE_TIPO_MUESTRA.Name = "CVE_TIPO_MUESTRA"
        Me.CVE_TIPO_MUESTRA.Size = New System.Drawing.Size(262, 22)
        Me.CVE_TIPO_MUESTRA.TabIndex = 14
        Me.CVE_TIPO_MUESTRA.Text = "0"
        Me.CVE_TIPO_MUESTRA.Visible = False
        '
        'NUEVO
        '
        Me.NUEVO.ImageSource = "Resources\Icons\Menu\add.png"
        Me.NUEVO.Location = New System.Drawing.Point(244, 255)
        Me.NUEVO.Name = "NUEVO"
        Me.NUEVO.Size = New System.Drawing.Size(79, 27)
        Me.NUEVO.TabIndex = 13
        Me.NUEVO.Text = "Nuevo"
        '
        'GUARDAR
        '
        Me.GUARDAR.ImageSource = "Resources\Images\Menu\64\002-diskette .png"
        Me.GUARDAR.Location = New System.Drawing.Point(61, 255)
        Me.GUARDAR.Name = "GUARDAR"
        Me.GUARDAR.Size = New System.Drawing.Size(85, 27)
        Me.GUARDAR.TabIndex = 12
        Me.GUARDAR.Text = "Guardar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Descripcion del tipo de Analisis:"
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.Location = New System.Drawing.Point(61, 158)
        Me.DESCRIPCION.Multiline = True
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.Size = New System.Drawing.Size(262, 70)
        Me.DESCRIPCION.TabIndex = 10
        Me.DESCRIPCION.Watermark = "Analisis de laboratorio para detectar moho en la comida"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(131, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre Descriptivo:"
        '
        'NOMBRE
        '
        Me.NOMBRE.Location = New System.Drawing.Point(61, 108)
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.Size = New System.Drawing.Size(262, 22)
        Me.NOMBRE.TabIndex = 8
        Me.NOMBRE.Watermark = "Moho's"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Add_Muestras_Tipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 311)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(389, 355)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(389, 355)
        Me.Name = "Add_Muestras_Tipo"
        Me.Text = "Añadir Tipo de Muestra"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Wisej.Web.Panel
    Friend WithEvents CVE_TIPO As Wisej.Web.Label
    Friend WithEvents CVE_TIPO_MUESTRA As Wisej.Web.TextBox
    Friend WithEvents NUEVO As Wisej.Web.Button
    Friend WithEvents GUARDAR As Wisej.Web.Button
    Friend WithEvents Label2 As Wisej.Web.Label
    Friend WithEvents DESCRIPCION As Wisej.Web.TextBox
    Friend WithEvents Label1 As Wisej.Web.Label
    Friend WithEvents NOMBRE As Wisej.Web.TextBox
    Friend WithEvents ErrorProvider1 As Wisej.Web.ErrorProvider
End Class
