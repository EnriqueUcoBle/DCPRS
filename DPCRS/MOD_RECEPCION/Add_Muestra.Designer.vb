<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Muestra
    Inherits Wisej.Web.Form

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Wisej Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Wisej Designer
    'It can be modified using the Wisej Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New Wisej.Web.Panel()
        Me.AÑADIR_ITEM = New Wisej.Web.Button()
        Me.FECHA_CADUCIDAD = New Wisej.Web.DateTimePicker()
        Me.CANTIDAD = New Wisej.Web.NumericUpDown()
        Me.Label10 = New Wisej.Web.Label()
        Me.Label9 = New Wisej.Web.Label()
        Me.LOTE = New Wisej.Web.TextBox()
        Me.Label8 = New Wisej.Web.Label()
        Me.MARCA = New Wisej.Web.TextBox()
        Me.Label7 = New Wisej.Web.Label()
        Me.CLAVE_VS = New Wisej.Web.TextBox()
        Me.Label6 = New Wisej.Web.Label()
        Me.DESCRIPCION = New Wisej.Web.TextBox()
        Me.Label5 = New Wisej.Web.Label()
        Me.AddAnalisis = New Wisej.Web.Button()
        Me.Label3 = New Wisej.Web.Label()
        Me.DESCRIPCION_TIPO_ANALISIS = New Wisej.Web.TextBox()
        Me.Label4 = New Wisej.Web.Label()
        Me.TIPO_ANALISIS = New DPCRS.Combosax_B()
        Me.AddMuestra = New Wisej.Web.Button()
        Me.Label1 = New Wisej.Web.Label()
        Me.DESCRIPCION_TIPO_MUESTRA = New Wisej.Web.TextBox()
        Me.Label2 = New Wisej.Web.Label()
        Me.TIPO_MUESTRA = New DPCRS.Combosax_B()
        Me.ErrorProvider1 = New Wisej.Web.ErrorProvider(Me.components)
        Me.Button1 = New Wisej.Web.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.CANTIDAD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.AÑADIR_ITEM)
        Me.Panel1.Controls.Add(Me.FECHA_CADUCIDAD)
        Me.Panel1.Controls.Add(Me.CANTIDAD)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.LOTE)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.MARCA)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.CLAVE_VS)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.DESCRIPCION)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.AddAnalisis)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DESCRIPCION_TIPO_ANALISIS)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TIPO_ANALISIS)
        Me.Panel1.Controls.Add(Me.AddMuestra)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DESCRIPCION_TIPO_MUESTRA)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TIPO_MUESTRA)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(534, 557)
        Me.Panel1.TabIndex = 0
        '
        'AÑADIR_ITEM
        '
        Me.AÑADIR_ITEM.ImageSource = "Resources\Icons\Menu\add.png"
        Me.AÑADIR_ITEM.Location = New System.Drawing.Point(49, 485)
        Me.AÑADIR_ITEM.Name = "AÑADIR_ITEM"
        Me.AÑADIR_ITEM.Size = New System.Drawing.Size(131, 27)
        Me.AÑADIR_ITEM.TabIndex = 30
        Me.AÑADIR_ITEM.Text = "Añadir al Acta"
        '
        'FECHA_CADUCIDAD
        '
        Me.FECHA_CADUCIDAD.Location = New System.Drawing.Point(205, 412)
        Me.FECHA_CADUCIDAD.MinDate = New Date(1999, 1, 1, 0, 0, 0, 0)
        Me.FECHA_CADUCIDAD.Name = "FECHA_CADUCIDAD"
        Me.FECHA_CADUCIDAD.Size = New System.Drawing.Size(277, 22)
        Me.FECHA_CADUCIDAD.TabIndex = 29
        Me.FECHA_CADUCIDAD.Value = New Date(CType(0, Long))
        '
        'CANTIDAD
        '
        Me.CANTIDAD.Location = New System.Drawing.Point(205, 377)
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.Size = New System.Drawing.Size(277, 22)
        Me.CANTIDAD.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(49, 418)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 16)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Fecha de Caducidad:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 380)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Cantidad:"
        '
        'LOTE
        '
        Me.LOTE.Location = New System.Drawing.Point(205, 338)
        Me.LOTE.Name = "LOTE"
        Me.LOTE.Size = New System.Drawing.Size(277, 22)
        Me.LOTE.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(49, 341)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 16)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Lote:"
        '
        'MARCA
        '
        Me.MARCA.Location = New System.Drawing.Point(205, 297)
        Me.MARCA.Name = "MARCA"
        Me.MARCA.Size = New System.Drawing.Size(277, 22)
        Me.MARCA.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 300)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Marca:"
        '
        'CLAVE_VS
        '
        Me.CLAVE_VS.Location = New System.Drawing.Point(205, 259)
        Me.CLAVE_VS.Name = "CLAVE_VS"
        Me.CLAVE_VS.Size = New System.Drawing.Size(277, 22)
        Me.CLAVE_VS.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Clave VS:"
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.Location = New System.Drawing.Point(205, 216)
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.Size = New System.Drawing.Size(277, 22)
        Me.DESCRIPCION.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Descripcion: *"
        '
        'AddAnalisis
        '
        Me.AddAnalisis.ImageSource = "Resources\Icons\Menu\add.png"
        Me.AddAnalisis.Location = New System.Drawing.Point(451, 117)
        Me.AddAnalisis.Name = "AddAnalisis"
        Me.AddAnalisis.Size = New System.Drawing.Size(31, 30)
        Me.AddAnalisis.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Tipo Analisis: *"
        '
        'DESCRIPCION_TIPO_ANALISIS
        '
        Me.DESCRIPCION_TIPO_ANALISIS.Location = New System.Drawing.Point(205, 172)
        Me.DESCRIPCION_TIPO_ANALISIS.Name = "DESCRIPCION_TIPO_ANALISIS"
        Me.DESCRIPCION_TIPO_ANALISIS.ReadOnly = True
        Me.DESCRIPCION_TIPO_ANALISIS.Size = New System.Drawing.Size(277, 22)
        Me.DESCRIPCION_TIPO_ANALISIS.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Descripcion Analisis:"
        '
        'TIPO_ANALISIS
        '
        Me.TIPO_ANALISIS.amarillo = False
        Me.TIPO_ANALISIS.Ancho = Nothing
        Me.TIPO_ANALISIS.BackColor = System.Drawing.Color.FromName("@window")
        Me.TIPO_ANALISIS.ColorAtras = System.Drawing.Color.Empty
        Me.TIPO_ANALISIS.Count = 0
        Me.TIPO_ANALISIS.DataSource = Nothing
        Me.TIPO_ANALISIS.DataSourceSelect = Nothing
        Me.TIPO_ANALISIS.gris = False
        Me.TIPO_ANALISIS.Letra = Nothing
        Me.TIPO_ANALISIS.Limitar = False
        Me.TIPO_ANALISIS.Location = New System.Drawing.Point(205, 125)
        Me.TIPO_ANALISIS.MensajeAgua = Nothing
        Me.TIPO_ANALISIS.mostrarMensaje = False
        Me.TIPO_ANALISIS.Name = "TIPO_ANALISIS"
        Me.TIPO_ANALISIS.Negritas = False
        Me.TIPO_ANALISIS.OBTENERLISTLLENADO = Nothing
        Me.TIPO_ANALISIS.procedure = Nothing
        Me.TIPO_ANALISIS.SelectedIndex = -1
        Me.TIPO_ANALISIS.SelectedItem = ""
        Me.TIPO_ANALISIS.SelectedValue = Nothing
        Me.TIPO_ANALISIS.Size = New System.Drawing.Size(239, 22)
        Me.TIPO_ANALISIS.TabIndex = 12
        Me.TIPO_ANALISIS.TODOSS = False
        Me.TIPO_ANALISIS.Watermark = Nothing
        '
        'AddMuestra
        '
        Me.AddMuestra.ImageSource = "Resources\Icons\Menu\add.png"
        Me.AddMuestra.Location = New System.Drawing.Point(451, 27)
        Me.AddMuestra.Name = "AddMuestra"
        Me.AddMuestra.Size = New System.Drawing.Size(34, 28)
        Me.AddMuestra.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Tipo Muestra: *"
        '
        'DESCRIPCION_TIPO_MUESTRA
        '
        Me.DESCRIPCION_TIPO_MUESTRA.Location = New System.Drawing.Point(205, 79)
        Me.DESCRIPCION_TIPO_MUESTRA.Name = "DESCRIPCION_TIPO_MUESTRA"
        Me.DESCRIPCION_TIPO_MUESTRA.ReadOnly = True
        Me.DESCRIPCION_TIPO_MUESTRA.Size = New System.Drawing.Size(277, 22)
        Me.DESCRIPCION_TIPO_MUESTRA.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripcion Muestra:"
        '
        'TIPO_MUESTRA
        '
        Me.TIPO_MUESTRA.amarillo = False
        Me.TIPO_MUESTRA.Ancho = Nothing
        Me.TIPO_MUESTRA.BackColor = System.Drawing.Color.FromName("@window")
        Me.TIPO_MUESTRA.ColorAtras = System.Drawing.Color.Empty
        Me.TIPO_MUESTRA.Count = 0
        Me.TIPO_MUESTRA.DataSource = Nothing
        Me.TIPO_MUESTRA.DataSourceSelect = Nothing
        Me.TIPO_MUESTRA.gris = False
        Me.TIPO_MUESTRA.Letra = Nothing
        Me.TIPO_MUESTRA.Limitar = False
        Me.TIPO_MUESTRA.Location = New System.Drawing.Point(205, 32)
        Me.TIPO_MUESTRA.MensajeAgua = Nothing
        Me.TIPO_MUESTRA.mostrarMensaje = False
        Me.TIPO_MUESTRA.Name = "TIPO_MUESTRA"
        Me.TIPO_MUESTRA.Negritas = False
        Me.TIPO_MUESTRA.OBTENERLISTLLENADO = Nothing
        Me.TIPO_MUESTRA.procedure = Nothing
        Me.TIPO_MUESTRA.SelectedIndex = -1
        Me.TIPO_MUESTRA.SelectedItem = ""
        Me.TIPO_MUESTRA.SelectedValue = Nothing
        Me.TIPO_MUESTRA.Size = New System.Drawing.Size(239, 22)
        Me.TIPO_MUESTRA.TabIndex = 0
        Me.TIPO_MUESTRA.TODOSS = False
        Me.TIPO_MUESTRA.Watermark = Nothing
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Button1
        '
        Me.Button1.ImageSource = "Resources\Images\Menu\64\chemistry .png"
        Me.Button1.Location = New System.Drawing.Point(351, 485)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 27)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Nueva Muestra"
        '
        'Add_Muestra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 557)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(546, 601)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(546, 601)
        Me.Name = "Add_Muestra"
        Me.Text = "Añadir Muestra Para Laboratorio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CANTIDAD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Wisej.Web.Panel
    Friend WithEvents AddAnalisis As Wisej.Web.Button
    Friend WithEvents Label3 As Wisej.Web.Label
    Friend WithEvents DESCRIPCION_TIPO_ANALISIS As Wisej.Web.TextBox
    Friend WithEvents Label4 As Wisej.Web.Label
    Friend WithEvents AddMuestra As Wisej.Web.Button
    Friend WithEvents Label1 As Wisej.Web.Label
    Friend WithEvents DESCRIPCION_TIPO_MUESTRA As Wisej.Web.TextBox
    Friend WithEvents Label2 As Wisej.Web.Label
    Friend WithEvents Label8 As Wisej.Web.Label
    Friend WithEvents Label7 As Wisej.Web.Label
    Friend WithEvents Label6 As Wisej.Web.Label
    Friend WithEvents Label5 As Wisej.Web.Label
    Friend WithEvents Label10 As Wisej.Web.Label
    Friend WithEvents Label9 As Wisej.Web.Label
    Friend WithEvents AÑADIR_ITEM As Wisej.Web.Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ErrorProvider1 As Wisej.Web.ErrorProvider
    Public WithEvents TIPO_ANALISIS As Combosax_B
    Public WithEvents TIPO_MUESTRA As Combosax_B
    Public WithEvents LOTE As Wisej.Web.TextBox
    Public WithEvents MARCA As Wisej.Web.TextBox
    Public WithEvents CLAVE_VS As Wisej.Web.TextBox
    Public WithEvents DESCRIPCION As Wisej.Web.TextBox
    Public WithEvents FECHA_CADUCIDAD As Wisej.Web.DateTimePicker
    Public WithEvents CANTIDAD As Wisej.Web.NumericUpDown
    Friend WithEvents Button1 As Wisej.Web.Button
End Class
