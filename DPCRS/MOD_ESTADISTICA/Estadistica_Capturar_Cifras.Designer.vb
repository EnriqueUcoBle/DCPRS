Imports Wisej.Web.Ext.RibbonBar
Imports Wisej.Web

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estadistica_Capturar_Cifras
    Inherits Wisej.Web.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Visual WebGui Designer
    Private Shadows components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Visual WebGui Designer
    'It can be modified using the Visual WebGui Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ComponentTool1 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Dim ComponentTool2 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Dim ComponentTool3 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBNNUEVO = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNGUARDAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNBUSCAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNSALIR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.GroupBox1 = New Wisej.Web.GroupBox()
        Me.Label3 = New Wisej.Web.Label()
        Me.Combosax2 = New Wisej.Web.ComboBox()
        Me.Label2 = New Wisej.Web.Label()
        Me.Combosax1 = New Wisej.Web.ComboBox()
        Me.CBSmes = New Wisej.Web.ComboBox()
        Me.Label1 = New Wisej.Web.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Dock = Wisej.Web.DockStyle.Top
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(755, 145)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Text = "Menú"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.RBNNUEVO)
        Me.RibbonBarGroup1.Items.Add(Me.RBNGUARDAR)
        Me.RibbonBarGroup1.Items.Add(Me.RBNBUSCAR)
        Me.RibbonBarGroup1.Items.Add(Me.RBNSALIR)
        Me.RibbonBarGroup1.Text = "Opciones"
        '
        'RBNNUEVO
        '
        Me.RBNNUEVO.ImageSource = "ribbon-document?color=#FF0000"
        Me.RBNNUEVO.Name = "RBNNUEVO"
        Me.RBNNUEVO.Text = "Nuevo"
        '
        'RBNGUARDAR
        '
        Me.RBNGUARDAR.ImageSource = "ribbon-save?color=#FF0000"
        Me.RBNGUARDAR.Name = "RBNGUARDAR"
        Me.RBNGUARDAR.Text = "Guardar"
        '
        'RBNBUSCAR
        '
        Me.RBNBUSCAR.ImageSource = "Resources\Images\Menu\30\044-search.png"
        Me.RBNBUSCAR.Name = "RBNBUSCAR"
        Me.RBNBUSCAR.Text = "Buscar"
        '
        'RBNSALIR
        '
        Me.RBNSALIR.ImageSource = "Resources\Images\Menu\30\exit-sign-red.png?color=#0000FF"
        Me.RBNSALIR.Name = "RBNSALIR"
        Me.RBNSALIR.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Combosax2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Combosax1)
        Me.GroupBox1.Controls.Add(Me.CBSmes)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = Wisej.Web.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(755, 115)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.Text = "Datos Generales"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(262, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Municipio:"
        '
        'Combosax2
        '
        Me.Combosax2.BackColor = System.Drawing.Color.Transparent
        Me.Combosax2.Cursor = Wisej.Web.Cursors.Hand
        Me.Combosax2.Location = New System.Drawing.Point(316, 31)
        Me.Combosax2.Name = "Combosax2"
        Me.Combosax2.Size = New System.Drawing.Size(201, 22)
        Me.Combosax2.TabIndex = 1
        ComponentTool1.ImageSource = "icon-close"
        ComponentTool1.Name = "Borrar"
        Me.Combosax2.Tools.AddRange(New Wisej.Web.ComponentTool() {ComponentTool1})
        Me.Combosax2.Watermark = "Ingrese Texto (Enter)..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(546, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Año:"
        '
        'Combosax1
        '
        Me.Combosax1.BackColor = System.Drawing.Color.Transparent
        Me.Combosax1.Cursor = Wisej.Web.Cursors.Hand
        Me.Combosax1.Location = New System.Drawing.Point(576, 31)
        Me.Combosax1.Name = "Combosax1"
        Me.Combosax1.Size = New System.Drawing.Size(124, 22)
        Me.Combosax1.TabIndex = 1
        ComponentTool2.ImageSource = "icon-close"
        ComponentTool2.Name = "Borrar"
        Me.Combosax1.Tools.AddRange(New Wisej.Web.ComponentTool() {ComponentTool2})
        Me.Combosax1.Watermark = "Ingrese Texto (Enter)..."
        '
        'CBSmes
        '
        Me.CBSmes.BackColor = System.Drawing.Color.Transparent
        Me.CBSmes.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSmes.Location = New System.Drawing.Point(39, 31)
        Me.CBSmes.Name = "CBSmes"
        Me.CBSmes.Size = New System.Drawing.Size(201, 22)
        Me.CBSmes.TabIndex = 1
        ComponentTool3.ImageSource = "icon-close"
        ComponentTool3.Name = "Borrar"
        Me.CBSmes.Tools.AddRange(New Wisej.Web.ComponentTool() {ComponentTool3})
        Me.CBSmes.Watermark = "Ingrese Texto (Enter)..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mes:"
        '
        'Estadistica_Capturar_Cifras
        '
        Me.ClientSize = New System.Drawing.Size(755, 613)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Estadistica_Capturar_Cifras"
        Me.Text = "Informe mensual de actividades"
        Me.WindowState = Wisej.Web.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonBar1 As RibbonBar
    Friend WithEvents RibbonBarPage1 As RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As RibbonBarGroup
    Friend WithEvents RBNNUEVO As RibbonBarItemButton
    Friend WithEvents RBNGUARDAR As RibbonBarItemButton
    Friend WithEvents RBNBUSCAR As RibbonBarItemButton
    Friend WithEvents RBNSALIR As RibbonBarItemButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBSmes As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Combosax2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Combosax1 As ComboBox
End Class
