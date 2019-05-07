Imports Wisej.Web.Ext.RibbonBar
Imports Wisej.Web

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Acta_Capturar_Muestras
    Inherits Wisej.Web.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Dim ComponentTool1 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Dim DataGridViewCellStyle2 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Dim ComponentTool2 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Dim ComponentTool3 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Dim ComponentTool4 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Me.SplitContainer1 = New Wisej.Web.SplitContainer()
        Me.BindingNavigator1 = New Wisej.Web.BindingNavigator(Me.components)
        Me.GroupBox1 = New Wisej.Web.GroupBox()
        Me.DGVverificadores = New Wisej.Web.DataGridView()
        Me.eliminar = New Wisej.Web.DataGridViewImageColumn()
        Me.clave = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.nombre = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Panel1 = New Wisej.Web.Panel()
        Me.PictureBox2 = New Wisej.Web.PictureBox()
        Me.PictureBox1 = New Wisej.Web.PictureBox()
        Me.btnOperadores = New Wisej.Web.Button()
        Me.CBSverificadores = New Wisej.Web.ComboBox()
        Me.Label5 = New Wisej.Web.Label()
        Me.CBSestablecimiento = New Wisej.Web.ComboBox()
        Me.Label1 = New Wisej.Web.Label()
        Me.Label4 = New Wisej.Web.Label()
        Me.cFechaIngreso = New Wisej.Web.DateTimePicker()
        Me.cFechaVerificacion = New Wisej.Web.DateTimePicker()
        Me.Label3 = New Wisej.Web.Label()
        Me.GroupBox3 = New Wisej.Web.GroupBox()
        Me.RBNtipo_muestras = New Wisej.Web.RadioButton()
        Me.RBNtipo_verificacion = New Wisej.Web.RadioButton()
        Me.GroupBox2 = New Wisej.Web.GroupBox()
        Me.RBNprograma_estatal = New Wisej.Web.RadioButton()
        Me.RBNprograma_fassc = New Wisej.Web.RadioButton()
        Me.grpFolio = New Wisej.Web.GroupBox()
        Me.txtFolio = New Wisej.Web.TextBox()
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBNNUEVO = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNBUSCAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNSALIR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Panel2 = New Wisej.Web.Panel()
        Me.DGVestudios = New Wisej.Web.DataGridView()
        Me.estatus_img = New Wisej.Web.DataGridViewImageColumn()
        Me.estatus = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.folio = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.clave_estudio = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.estudio = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.muestra = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pORDEN_VERIFICACION_ESTUDIOS_B = New DPCRS.DataSet_pORDEN_VERIFICACION_ESTUDIOS_B()
        Me.ExpandableGroupBox2 = New Wisej.Web.GroupBox()
        Me.Label10 = New Wisej.Web.Label()
        Me.cFecha_reporte_lsp = New Wisej.Web.DateTimePicker()
        Me.Label9 = New Wisej.Web.Label()
        Me.cFecha_muestra_recibida = New Wisej.Web.DateTimePicker()
        Me.Button2 = New Wisej.Web.Upload()
        Me.Label7 = New Wisej.Web.Label()
        Me.Label8 = New Wisej.Web.Label()
        Me.CBSestudio = New Wisej.Web.ComboBox()
        Me.Label2 = New Wisej.Web.Label()
        Me.CBSmuestra = New Wisej.Web.ComboBox()
        Me.Label14 = New Wisej.Web.Label()
        Me.BindingNavigator2 = New Wisej.Web.BindingNavigator(Me.components)
        Me.ExpandableGroupBox1 = New Wisej.Web.GroupBox()
        Me.SplitContainer2 = New Wisej.Web.SplitContainer()
        Me.Button1 = New Wisej.Web.Upload()
        Me.Label13 = New Wisej.Web.Label()
        Me.Label12 = New Wisej.Web.Label()
        Me.Combosax1 = New Wisej.Web.ComboBox()
        Me.Label6 = New Wisej.Web.Label()
        Me.RibbonBar2 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.RibbonBarPage2 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup2 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBNGUARDAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNACTUALIZAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.ErrorProvider1 = New Wisej.Web.ErrorProvider(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVverificadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpFolio.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVestudios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pORDEN_VERIFICACION_ESTUDIOS_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExpandableGroupBox2.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExpandableGroupBox1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = Wisej.Web.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.BindingNavigator1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RibbonBar1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.RibbonBar2)
        Me.SplitContainer1.Size = New System.Drawing.Size(988, 744)
        Me.SplitContainer1.SplitterDistance = 354
        Me.SplitContainer1.TabIndex = 0
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.Dock = Wisej.Web.DockStyle.Bottom
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 714)
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.Size = New System.Drawing.Size(352, 28)
        Me.BindingNavigator1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGVverificadores)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.grpFolio)
        Me.GroupBox1.Dock = Wisej.Web.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 645)
        Me.GroupBox1.TabIndex = 1
        '
        'DGVverificadores
        '
        Me.DGVverificadores.AutoGenerateColumns = False
        Me.DGVverificadores.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.eliminar, Me.clave, Me.nombre})
        Me.DGVverificadores.Dock = Wisej.Web.DockStyle.Fill
        Me.DGVverificadores.Location = New System.Drawing.Point(3, 491)
        Me.DGVverificadores.Name = "DGVverificadores"
        Me.DGVverificadores.RowHeadersVisible = False
        Me.DGVverificadores.Size = New System.Drawing.Size(346, 151)
        Me.DGVverificadores.TabIndex = 3
        '
        'eliminar
        '
        Me.eliminar.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.eliminar.CellImageLayout = Wisej.Web.DataGridViewImageCellLayout.Stretch
        Me.eliminar.CellImageSource = "eliminar.Image"
        DataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = Nothing
        Me.eliminar.DefaultCellStyle = DataGridViewCellStyle1
        Me.eliminar.HeaderText = " "
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Width = 35
        '
        'clave
        '
        Me.clave.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.clave.HeaderText = "Clave"
        Me.clave.Name = "clave"
        Me.clave.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.clave.Width = 10
        '
        'nombre
        '
        Me.nombre.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.nombre.Width = 10
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnOperadores)
        Me.Panel1.Controls.Add(Me.CBSverificadores)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.CBSestablecimiento)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cFechaIngreso)
        Me.Panel1.Controls.Add(Me.cFechaVerificacion)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 160)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(346, 331)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        Me.PictureBox2.BackgroundImageSource = "PictureBox2.BackgroundImage"
        Me.PictureBox2.Location = New System.Drawing.Point(9, 56)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 34)
        Me.PictureBox2.TabIndex = 23
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        Me.PictureBox1.BackgroundImageSource = "PictureBox1.BackgroundImage"
        Me.PictureBox1.Location = New System.Drawing.Point(9, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 34)
        Me.PictureBox1.TabIndex = 23
        '
        'btnOperadores
        '
        Me.btnOperadores.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        Me.btnOperadores.BackgroundImageSource = "btnOperadores.BackgroundImage"
        Me.btnOperadores.Location = New System.Drawing.Point(310, 294)
        Me.btnOperadores.Name = "btnOperadores"
        Me.btnOperadores.Size = New System.Drawing.Size(28, 26)
        Me.btnOperadores.TabIndex = 12
        '
        'CBSverificadores
        '
        Me.CBSverificadores.BackColor = System.Drawing.Color.Transparent
        Me.CBSverificadores.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSverificadores.Location = New System.Drawing.Point(9, 298)
        Me.CBSverificadores.Name = "CBSverificadores"
        Me.CBSverificadores.Size = New System.Drawing.Size(292, 22)
        Me.CBSverificadores.TabIndex = 22
        Me.CBSverificadores.Watermark = "Ingrese Texto (Enter)..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Verificadores:"
        '
        'CBSestablecimiento
        '
        Me.CBSestablecimiento.BackColor = System.Drawing.Color.Transparent
        Me.CBSestablecimiento.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSestablecimiento.Location = New System.Drawing.Point(9, 120)
        Me.CBSestablecimiento.Name = "CBSestablecimiento"
        Me.CBSestablecimiento.Size = New System.Drawing.Size(329, 22)
        Me.CBSestablecimiento.TabIndex = 21
        ComponentTool1.ImageSource = "icon-close"
        ComponentTool1.Name = "Borrar"
        Me.CBSestablecimiento.Tools.AddRange(New Wisej.Web.ComponentTool() {ComponentTool1})
        Me.CBSestablecimiento.Watermark = "Ingrese Texto (Enter)..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Establecimiento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Fecha Ingresó:"
        '
        'cFechaIngreso
        '
        Me.cFechaIngreso.CustomFormat = "dd/MM/yyyy"
        Me.cFechaIngreso.Format = Wisej.Web.DateTimePickerFormat.Custom
        Me.cFechaIngreso.Location = New System.Drawing.Point(47, 69)
        Me.cFechaIngreso.Name = "cFechaIngreso"
        Me.cFechaIngreso.Size = New System.Drawing.Size(103, 22)
        Me.cFechaIngreso.TabIndex = 0
        Me.cFechaIngreso.Value = New Date(2019, 4, 4, 14, 44, 35, 896)
        '
        'cFechaVerificacion
        '
        Me.cFechaVerificacion.CustomFormat = "dd/MM/yyyy"
        Me.cFechaVerificacion.Format = Wisej.Web.DateTimePickerFormat.Custom
        Me.cFechaVerificacion.Location = New System.Drawing.Point(47, 23)
        Me.cFechaVerificacion.Name = "cFechaVerificacion"
        Me.cFechaVerificacion.Size = New System.Drawing.Size(103, 22)
        Me.cFechaVerificacion.TabIndex = 0
        Me.cFechaVerificacion.Value = New Date(2019, 4, 4, 14, 44, 35, 898)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Fecha Verificación:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RBNtipo_muestras)
        Me.GroupBox3.Controls.Add(Me.RBNtipo_verificacion)
        Me.GroupBox3.Dock = Wisej.Web.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(3, 120)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(346, 40)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.Text = "Objetivo"
        '
        'RBNtipo_muestras
        '
        Me.RBNtipo_muestras.Appearance = Wisej.Web.Appearance.Button
        Me.RBNtipo_muestras.Location = New System.Drawing.Point(61, 13)
        Me.RBNtipo_muestras.Name = "RBNtipo_muestras"
        Me.RBNtipo_muestras.Size = New System.Drawing.Size(81, 31)
        Me.RBNtipo_muestras.TabIndex = 25
        Me.RBNtipo_muestras.TabStop = False
        Me.RBNtipo_muestras.Text = "Muestras"
        Me.RBNtipo_muestras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RBNtipo_verificacion
        '
        Me.RBNtipo_verificacion.Appearance = Wisej.Web.Appearance.Button
        Me.RBNtipo_verificacion.Checked = True
        Me.RBNtipo_verificacion.Location = New System.Drawing.Point(205, 13)
        Me.RBNtipo_verificacion.Name = "RBNtipo_verificacion"
        Me.RBNtipo_verificacion.Size = New System.Drawing.Size(95, 31)
        Me.RBNtipo_verificacion.TabIndex = 24
        Me.RBNtipo_verificacion.Text = "Verificación"
        Me.RBNtipo_verificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RBNprograma_estatal)
        Me.GroupBox2.Controls.Add(Me.RBNprograma_fassc)
        Me.GroupBox2.Dock = Wisej.Web.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(3, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 40)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.Text = "Programa"
        '
        'RBNprograma_estatal
        '
        Me.RBNprograma_estatal.Appearance = Wisej.Web.Appearance.Button
        Me.RBNprograma_estatal.Checked = True
        Me.RBNprograma_estatal.Location = New System.Drawing.Point(62, 13)
        Me.RBNprograma_estatal.Name = "RBNprograma_estatal"
        Me.RBNprograma_estatal.Size = New System.Drawing.Size(85, 31)
        Me.RBNprograma_estatal.TabIndex = 22
        Me.RBNprograma_estatal.Text = "ESTATAL"
        Me.RBNprograma_estatal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RBNprograma_fassc
        '
        Me.RBNprograma_fassc.Appearance = Wisej.Web.Appearance.Button
        Me.RBNprograma_fassc.Location = New System.Drawing.Point(216, 13)
        Me.RBNprograma_fassc.Name = "RBNprograma_fassc"
        Me.RBNprograma_fassc.Size = New System.Drawing.Size(70, 31)
        Me.RBNprograma_fassc.TabIndex = 23
        Me.RBNprograma_fassc.TabStop = False
        Me.RBNprograma_fassc.Text = "FASSC"
        Me.RBNprograma_fassc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpFolio
        '
        Me.grpFolio.Controls.Add(Me.txtFolio)
        Me.grpFolio.Dock = Wisej.Web.DockStyle.Top
        Me.grpFolio.Location = New System.Drawing.Point(3, 18)
        Me.grpFolio.Name = "grpFolio"
        Me.grpFolio.Size = New System.Drawing.Size(346, 62)
        Me.grpFolio.TabIndex = 1
        Me.grpFolio.Text = "Folio"
        '
        'txtFolio
        '
        Me.txtFolio.BackColor = System.Drawing.Color.LightYellow
        Me.txtFolio.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtFolio.Location = New System.Drawing.Point(9, 23)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(329, 22)
        Me.txtFolio.TabIndex = 0
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Dock = Wisej.Web.DockStyle.Top
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(352, 145)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Text = "Menú"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.RBNNUEVO)
        Me.RibbonBarGroup1.Items.Add(Me.RBNBUSCAR)
        Me.RibbonBarGroup1.Items.Add(Me.RBNSALIR)
        Me.RibbonBarGroup1.Text = "Opciones"
        '
        'RBNNUEVO
        '
        Me.RBNNUEVO.ColumnBreak = True
        Me.RBNNUEVO.ImageSource = "ribbon-document?color=#FF0000"
        Me.RBNNUEVO.Text = "Nuevo"
        '
        'RBNBUSCAR
        '
        Me.RBNBUSCAR.ColumnBreak = True
        Me.RBNBUSCAR.ImageSource = "RBNBUSCAR.Image"
        Me.RBNBUSCAR.Text = "Buscar"
        '
        'RBNSALIR
        '
        Me.RBNSALIR.ColumnBreak = True
        Me.RBNSALIR.ImageSource = "Resources/Images/Menu/30/exit-sign-red.png?color=#0000FF"
        Me.RBNSALIR.Text = "Salir"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DGVestudios)
        Me.Panel2.Controls.Add(Me.ExpandableGroupBox2)
        Me.Panel2.Controls.Add(Me.BindingNavigator2)
        Me.Panel2.Controls.Add(Me.ExpandableGroupBox1)
        Me.Panel2.Dock = Wisej.Web.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 145)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(626, 597)
        Me.Panel2.TabIndex = 2
        '
        'DGVestudios
        '
        Me.DGVestudios.AutoGenerateColumns = False
        Me.DGVestudios.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.estatus_img, Me.estatus, Me.folio, Me.clave_estudio, Me.estudio, Me.muestra, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DGVestudios.DataSource = Me.BindingSource1
        Me.DGVestudios.Dock = Wisej.Web.DockStyle.Top
        Me.DGVestudios.Location = New System.Drawing.Point(0, 260)
        Me.DGVestudios.Name = "DGVestudios"
        Me.DGVestudios.RowHeadersVisible = False
        Me.DGVestudios.Size = New System.Drawing.Size(626, 105)
        Me.DGVestudios.TabIndex = 3
        '
        'estatus_img
        '
        Me.estatus_img.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        DataGridViewCellStyle2.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = Nothing
        Me.estatus_img.DefaultCellStyle = DataGridViewCellStyle2
        Me.estatus_img.HeaderText = " "
        Me.estatus_img.Name = "estatus_img"
        Me.estatus_img.Width = 35
        '
        'estatus
        '
        Me.estatus.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.estatus.DataPropertyName = "ESTATUS_ESTUDIO"
        Me.estatus.HeaderText = "Estatus"
        Me.estatus.Name = "estatus"
        Me.estatus.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.estatus.ValueType = GetType(String)
        Me.estatus.Visible = False
        Me.estatus.Width = 10
        '
        'folio
        '
        Me.folio.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.folio.DataPropertyName = "FOLIO_ACTA"
        Me.folio.HeaderText = "Folio"
        Me.folio.Name = "folio"
        Me.folio.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.folio.ValueType = GetType(String)
        Me.folio.Width = 10
        '
        'clave_estudio
        '
        Me.clave_estudio.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.clave_estudio.DataPropertyName = "CVE_ESTUDIO"
        Me.clave_estudio.HeaderText = "Clave"
        Me.clave_estudio.Name = "clave_estudio"
        Me.clave_estudio.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.clave_estudio.ValueType = GetType(String)
        Me.clave_estudio.Width = 10
        '
        'estudio
        '
        Me.estudio.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.estudio.DataPropertyName = "ESTUDIO"
        Me.estudio.HeaderText = "Estudio"
        Me.estudio.Name = "estudio"
        Me.estudio.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.estudio.ValueType = GetType(String)
        Me.estudio.Width = 10
        '
        'muestra
        '
        Me.muestra.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.muestra.DataPropertyName = "MUESTRA_DESCRIPCION"
        Me.muestra.HeaderText = "Muestra"
        Me.muestra.Name = "muestra"
        Me.muestra.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.muestra.ValueType = GetType(String)
        Me.muestra.Width = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cve_Operador_Creo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 10
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cve_Operador_Modifico"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 10
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "pORDEN_VERIFICACION_ESTUDIOS_B"
        Me.BindingSource1.DataSource = Me.DataSet_pORDEN_VERIFICACION_ESTUDIOS_B
        '
        'DataSet_pORDEN_VERIFICACION_ESTUDIOS_B
        '
        Me.DataSet_pORDEN_VERIFICACION_ESTUDIOS_B.DataSetName = "DataSet_pORDEN_VERIFICACION_ESTUDIOS_B"
        Me.DataSet_pORDEN_VERIFICACION_ESTUDIOS_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExpandableGroupBox2
        '
        Me.ExpandableGroupBox2.Controls.Add(Me.Label10)
        Me.ExpandableGroupBox2.Controls.Add(Me.cFecha_reporte_lsp)
        Me.ExpandableGroupBox2.Controls.Add(Me.Label9)
        Me.ExpandableGroupBox2.Controls.Add(Me.cFecha_muestra_recibida)
        Me.ExpandableGroupBox2.Controls.Add(Me.Button2)
        Me.ExpandableGroupBox2.Controls.Add(Me.Label7)
        Me.ExpandableGroupBox2.Controls.Add(Me.Label8)
        Me.ExpandableGroupBox2.Controls.Add(Me.CBSestudio)
        Me.ExpandableGroupBox2.Controls.Add(Me.Label2)
        Me.ExpandableGroupBox2.Controls.Add(Me.CBSmuestra)
        Me.ExpandableGroupBox2.Controls.Add(Me.Label14)
        Me.ExpandableGroupBox2.Dock = Wisej.Web.DockStyle.Top
        Me.ExpandableGroupBox2.Location = New System.Drawing.Point(0, 121)
        Me.ExpandableGroupBox2.Name = "ExpandableGroupBox2"
        Me.ExpandableGroupBox2.Size = New System.Drawing.Size(626, 139)
        Me.ExpandableGroupBox2.TabIndex = 19
        Me.ExpandableGroupBox2.Text = "Resultados"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(519, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 16)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Fecha reporte LSP:"
        '
        'cFecha_reporte_lsp
        '
        Me.cFecha_reporte_lsp.CustomFormat = "dd/MM/yyyy"
        Me.cFecha_reporte_lsp.Format = Wisej.Web.DateTimePickerFormat.Custom
        Me.cFecha_reporte_lsp.Location = New System.Drawing.Point(519, 99)
        Me.cFecha_reporte_lsp.Name = "cFecha_reporte_lsp"
        Me.cFecha_reporte_lsp.Size = New System.Drawing.Size(103, 22)
        Me.cFecha_reporte_lsp.TabIndex = 0
        Me.cFecha_reporte_lsp.Value = New Date(2019, 4, 4, 14, 44, 36, 66)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(354, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 16)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Fecha recibida muestra:"
        '
        'cFecha_muestra_recibida
        '
        Me.cFecha_muestra_recibida.CustomFormat = "dd/MM/yyyy"
        Me.cFecha_muestra_recibida.Format = Wisej.Web.DateTimePickerFormat.Custom
        Me.cFecha_muestra_recibida.Location = New System.Drawing.Point(354, 99)
        Me.cFecha_muestra_recibida.Name = "cFecha_muestra_recibida"
        Me.cFecha_muestra_recibida.Size = New System.Drawing.Size(103, 22)
        Me.cFecha_muestra_recibida.TabIndex = 0
        Me.cFecha_muestra_recibida.Value = New Date(2019, 4, 4, 14, 44, 36, 72)
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(15, 108)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 22)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Seleccionar archivo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(142, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "nombre_archivo.ext"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Archivo de Resultados:"
        '
        'CBSestudio
        '
        Me.CBSestudio.BackColor = System.Drawing.Color.Transparent
        Me.CBSestudio.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSestudio.Location = New System.Drawing.Point(65, 46)
        Me.CBSestudio.Name = "CBSestudio"
        Me.CBSestudio.Size = New System.Drawing.Size(483, 22)
        Me.CBSestudio.TabIndex = 20
        ComponentTool2.ImageSource = "icon-close"
        ComponentTool2.Name = "Borrar"
        Me.CBSestudio.Tools.AddRange(New Wisej.Web.ComponentTool() {ComponentTool2})
        Me.CBSestudio.Watermark = "Ingrese Texto (Enter)..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Estudios:"
        '
        'CBSmuestra
        '
        Me.CBSmuestra.BackColor = System.Drawing.Color.Transparent
        Me.CBSmuestra.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSmuestra.Location = New System.Drawing.Point(65, 21)
        Me.CBSmuestra.Name = "CBSmuestra"
        Me.CBSmuestra.Size = New System.Drawing.Size(483, 22)
        Me.CBSmuestra.TabIndex = 20
        ComponentTool3.ImageSource = "icon-close"
        ComponentTool3.Name = "Borrar"
        Me.CBSmuestra.Tools.AddRange(New Wisej.Web.ComponentTool() {ComponentTool3})
        Me.CBSmuestra.Watermark = "Ingrese Texto (Enter)..."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 16)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Muestra:"
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 121)
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.Size = New System.Drawing.Size(638, 28)
        Me.BindingNavigator2.TabIndex = 1
        '
        'ExpandableGroupBox1
        '
        Me.ExpandableGroupBox1.Controls.Add(Me.SplitContainer2)
        Me.ExpandableGroupBox1.Dock = Wisej.Web.DockStyle.Top
        Me.ExpandableGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.ExpandableGroupBox1.Name = "ExpandableGroupBox1"
        Me.ExpandableGroupBox1.Size = New System.Drawing.Size(626, 121)
        Me.ExpandableGroupBox1.TabIndex = 19
        Me.ExpandableGroupBox1.Text = "Resultados"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = Wisej.Web.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 18)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label12)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Combosax1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer2.Size = New System.Drawing.Size(620, 100)
        Me.SplitContainer2.SplitterDistance = 222
        Me.SplitContainer2.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 22)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Seleccionar archivo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(125, 16)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "nombre_archivo.ext"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(179, 16)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Archivo de Orden Generada:"
        '
        'Combosax1
        '
        Me.Combosax1.BackColor = System.Drawing.Color.Transparent
        Me.Combosax1.Cursor = Wisej.Web.Cursors.Hand
        Me.Combosax1.Location = New System.Drawing.Point(6, 39)
        Me.Combosax1.Name = "Combosax1"
        Me.Combosax1.Size = New System.Drawing.Size(380, 22)
        Me.Combosax1.TabIndex = 1
        ComponentTool4.ImageSource = "icon-close"
        ComponentTool4.Name = "Borrar"
        Me.Combosax1.Tools.AddRange(New Wisej.Web.ComponentTool() {ComponentTool4})
        Me.Combosax1.Watermark = "Ingrese Texto (Enter)..."
        '
        'Label6
        '
        Me.Label6.Dock = Wisej.Web.DockStyle.Top
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(390, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Anexar observaciones al resultado"
        '
        'RibbonBar2
        '
        Me.RibbonBar2.Dock = Wisej.Web.DockStyle.Top
        Me.RibbonBar2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar2.Name = "RibbonBar2"
        Me.RibbonBar2.Pages.Add(Me.RibbonBarPage2)
        Me.RibbonBar2.Size = New System.Drawing.Size(626, 145)
        '
        'RibbonBarPage2
        '
        Me.RibbonBarPage2.Groups.Add(Me.RibbonBarGroup2)
        Me.RibbonBarPage2.Text = "Menú"
        '
        'RibbonBarGroup2
        '
        Me.RibbonBarGroup2.Items.Add(Me.RBNGUARDAR)
        Me.RibbonBarGroup2.Items.Add(Me.RBNACTUALIZAR)
        Me.RibbonBarGroup2.Text = "Opciones"
        '
        'RBNGUARDAR
        '
        Me.RBNGUARDAR.ColumnBreak = True
        Me.RBNGUARDAR.ImageSource = "ribbon-save?color=#FF0000"
        Me.RBNGUARDAR.Text = "Guardar"
        '
        'RBNACTUALIZAR
        '
        Me.RBNACTUALIZAR.ColumnBreak = True
        Me.RBNACTUALIZAR.ImageSource = "icon-redo?color=#006EFF"
        Me.RBNACTUALIZAR.Text = "Actualizar"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 3
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Acta_Capturar_Muestras
        '
        Me.ClientSize = New System.Drawing.Size(988, 744)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Acta_Capturar_Muestras"
        Me.Text = "Capturar Resultados de Muestras"
        Me.WindowState = Wisej.Web.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGVverificadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpFolio.ResumeLayout(False)
        Me.grpFolio.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGVestudios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pORDEN_VERIFICACION_ESTUDIOS_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExpandableGroupBox2.ResumeLayout(False)
        Me.ExpandableGroupBox2.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExpandableGroupBox1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RibbonBar1 As RibbonBar
    Friend WithEvents RibbonBarPage1 As RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As RibbonBarGroup
    Friend WithEvents RBNNUEVO As RibbonBarItemButton
    Friend WithEvents RBNBUSCAR As RibbonBarItemButton
    Friend WithEvents RBNSALIR As RibbonBarItemButton
    Friend WithEvents RibbonBar2 As RibbonBar
    Friend WithEvents RibbonBarPage2 As RibbonBarPage
    Friend WithEvents RibbonBarGroup2 As RibbonBarGroup
    Friend WithEvents RBNGUARDAR As RibbonBarItemButton
    Friend WithEvents RBNACTUALIZAR As RibbonBarItemButton
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataSet_pORDEN_VERIFICACION_ESTUDIOS_B As DataSet_pORDEN_VERIFICACION_ESTUDIOS_B
    Friend WithEvents BindingNavigator2 As BindingNavigator
    Friend WithEvents RBNtipo_muestras As RadioButton
    Friend WithEvents RBNtipo_verificacion As RadioButton
    Friend WithEvents RBNprograma_estatal As RadioButton
    Friend WithEvents RBNprograma_fassc As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents cFechaIngreso As DateTimePicker
    Friend WithEvents cFechaVerificacion As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents grpFolio As GroupBox
    Friend WithEvents txtFolio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBSestablecimiento As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CBSverificadores As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnOperadores As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ExpandableGroupBox2 As GroupBox
    Friend WithEvents ExpandableGroupBox1 As GroupBox
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents Button1 As Upload
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents CBSmuestra As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CBSestudio As ComboBox
    Friend WithEvents Button2 As Upload
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DGVverificadores As DataGridView
    Friend WithEvents DGVestudios As DataGridView
    Friend WithEvents eliminar As DataGridViewImageColumn
    Friend WithEvents clave As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents estatus As DataGridViewTextBoxColumn
    Friend WithEvents estatus_img As DataGridViewImageColumn
    Friend WithEvents clave_estudio As DataGridViewTextBoxColumn
    Friend WithEvents estudio As DataGridViewTextBoxColumn
    Friend WithEvents muestra As DataGridViewTextBoxColumn
    Friend WithEvents folio As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents cFecha_reporte_lsp As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents cFecha_muestra_recibida As DateTimePicker
    Friend WithEvents Combosax1 As ComboBox
End Class
