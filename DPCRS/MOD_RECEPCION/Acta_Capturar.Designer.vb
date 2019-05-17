Imports Wisej.Web.Ext.RibbonBar
Imports Wisej.Web

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Acta_Capturar
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
        Dim ComponentTool3 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Dim ComponentTool4 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Dim ComponentTool5 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Acta_Capturar))
        Dim ComponentTool1 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Dim ComponentTool2 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBBNUEVO = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBGUARDAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNBUSCAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNIMPRIMIR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBSALIR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.ErrorProvider1 = New Wisej.Web.ErrorProvider(Me.components)
        Me.Label1 = New Wisej.Web.Label()
        Me.Label3 = New Wisej.Web.Label()
        Me.DTPFecha = New Wisej.Web.DateTimePicker()
        Me.Panel1 = New Wisej.Web.Panel()
        Me.TabControl1 = New Wisej.Web.TabControl()
        Me.TabPage3 = New Wisej.Web.TabPage()
        Me.PdfViewer1 = New Wisej.Web.PdfViewer()
        Me.TabPage1 = New Wisej.Web.TabPage()
        Me.GroupBox4 = New Wisej.Web.GroupBox()
        Me.CBSVerificadores_Adscritos = New Wisej.Web.ComboBox()
        Me.Label16 = New Wisej.Web.Label()
        Me.txtAreaOperadores = New Wisej.Web.TextBox()
        Me.DGVOperadores = New Wisej.Web.DataGridView()
        Me.colCve_Operador = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colNombre = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Column1 = New Wisej.Web.DataGridViewColumn()
        Me.enviar = New Wisej.Web.DataGridViewCheckBoxColumn()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pCAT_OPERADORES_B = New DPCRS.DataSet_pCAT_OPERADORES_B()
        Me.GroupBox1 = New Wisej.Web.GroupBox()
        Me.txtEmision_Cargo = New Wisej.Web.TextBox()
        Me.txtEmision_orden = New Wisej.Web.TextBox()
        Me.Label14 = New Wisej.Web.Label()
        Me.Label11 = New Wisej.Web.Label()
        Me.TXTClaveActa = New Wisej.Web.LinkLabel()
        Me.DTPFecha_Emision_Orden = New Wisej.Web.DateTimePicker()
        Me.Label9 = New Wisej.Web.Label()
        Me.Label10 = New Wisej.Web.Label()
        Me.TabPage2 = New Wisej.Web.TabPage()
        Me.Panel2 = New Wisej.Web.Panel()
        Me.GroupBox2 = New Wisej.Web.GroupBox()
        Me.txtPropietario_Domicilio = New Wisej.Web.TextBox()
        Me.Label44 = New Wisej.Web.Label()
        Me.txtPropietario_Nombre = New Wisej.Web.TextBox()
        Me.Label12 = New Wisej.Web.Label()
        Me.CBSPropietario_Cargo = New Wisej.Web.ComboBox()
        Me.Label8 = New Wisej.Web.Label()
        Me.Label13 = New Wisej.Web.Label()
        Me.txtPropietario_Identificacion = New Wisej.Web.TextBox()
        Me.RBNIdentificacion_Credencial = New Wisej.Web.RadioButton()
        Me.RBNIdentificacion_Pasaporte = New Wisej.Web.RadioButton()
        Me.RBNIdentificacion_Otro = New Wisej.Web.RadioButton()
        Me.RBNIdentificacion_Conducir = New Wisej.Web.RadioButton()
        Me.GroupBox6 = New Wisej.Web.GroupBox()
        Me.txtTelefono = New Wisej.Web.TextBox()
        Me.Label23 = New Wisej.Web.Label()
        Me.txtCorreo = New Wisej.Web.TextBox()
        Me.Label22 = New Wisej.Web.Label()
        Me.txtCodigoPostal = New Wisej.Web.TextBox()
        Me.Label21 = New Wisej.Web.Label()
        Me.txtRFC = New Wisej.Web.TextBox()
        Me.Label20 = New Wisej.Web.Label()
        Me.txtGiro = New Wisej.Web.TextBox()
        Me.Label19 = New Wisej.Web.Label()
        Me.CBSPropietario = New Wisej.Web.ComboBox()
        Me.TXTPrograma = New Wisej.Web.TextBox()
        Me.Label4 = New Wisej.Web.Label()
        Me.TabPage4 = New Wisej.Web.TabPage()
        Me.GroupBox8 = New Wisej.Web.GroupBox()
        Me.Panel4 = New Wisej.Web.Panel()
        Me.Label25 = New Wisej.Web.Label()
        Me.RadioButton8 = New Wisej.Web.RadioButton()
        Me.RadioButton7 = New Wisej.Web.RadioButton()
        Me.Label29 = New Wisej.Web.Label()
        Me.CheckBox7 = New Wisej.Web.CheckBox()
        Me.CheckBox6 = New Wisej.Web.CheckBox()
        Me.CheckBox5 = New Wisej.Web.CheckBox()
        Me.CheckBox4 = New Wisej.Web.CheckBox()
        Me.CheckBox3 = New Wisej.Web.CheckBox()
        Me.CheckBox2 = New Wisej.Web.CheckBox()
        Me.txtTurnos = New Wisej.Web.NumericUpDown()
        Me.DTPLabores_Fin = New Wisej.Web.DateTimePicker()
        Me.DTPLabores_Inicio = New Wisej.Web.DateTimePicker()
        Me.TextBox7 = New Wisej.Web.TextBox()
        Me.CheckBox1 = New Wisej.Web.CheckBox()
        Me.RadioButton6 = New Wisej.Web.RadioButton()
        Me.RadioButton5 = New Wisej.Web.RadioButton()
        Me.Label28 = New Wisej.Web.Label()
        Me.Label27 = New Wisej.Web.Label()
        Me.Label24 = New Wisej.Web.Label()
        Me.Label26 = New Wisej.Web.Label()
        Me.GroupBox7 = New Wisej.Web.GroupBox()
        Me.txtObjetivo_Verificacion = New Wisej.Web.TextBox()
        Me.TabPage8 = New Wisej.Web.TabPage()
        Me.GroupBox5 = New Wisej.Web.GroupBox()
        Me.txtTestigo_identificacion2 = New Wisej.Web.TextBox()
        Me.Label45 = New Wisej.Web.Label()
        Me.txtTestigo_identificacion1 = New Wisej.Web.TextBox()
        Me.Label46 = New Wisej.Web.Label()
        Me.txtTestigo_Domicilio2 = New Wisej.Web.TextBox()
        Me.Label42 = New Wisej.Web.Label()
        Me.txtTestigo_Domicilio1 = New Wisej.Web.TextBox()
        Me.Label43 = New Wisej.Web.Label()
        Me.txtTestigo2 = New Wisej.Web.TextBox()
        Me.Label18 = New Wisej.Web.Label()
        Me.txtTestigo1 = New Wisej.Web.TextBox()
        Me.Label17 = New Wisej.Web.Label()
        Me.TabPage5 = New Wisej.Web.TabPage()
        Me.GroupBox10 = New Wisej.Web.GroupBox()
        Me.Panel8 = New Wisej.Web.Panel()
        Me.RadioButton17 = New Wisej.Web.RadioButton()
        Me.RadioButton18 = New Wisej.Web.RadioButton()
        Me.Panel7 = New Wisej.Web.Panel()
        Me.RadioButton15 = New Wisej.Web.RadioButton()
        Me.RadioButton16 = New Wisej.Web.RadioButton()
        Me.Panel6 = New Wisej.Web.Panel()
        Me.RadioButton13 = New Wisej.Web.RadioButton()
        Me.RadioButton14 = New Wisej.Web.RadioButton()
        Me.Panel5 = New Wisej.Web.Panel()
        Me.RadioButton11 = New Wisej.Web.RadioButton()
        Me.RadioButton12 = New Wisej.Web.RadioButton()
        Me.RadioButton10 = New Wisej.Web.RadioButton()
        Me.RadioButton9 = New Wisej.Web.RadioButton()
        Me.txtDescribir = New Wisej.Web.TextBox()
        Me.txtNumeroAnexos = New Wisej.Web.TextBox()
        Me.txtSellosReubicados = New Wisej.Web.TextBox()
        Me.txtSellosSuspendidos = New Wisej.Web.TextBox()
        Me.txtSellosAsegurados = New Wisej.Web.TextBox()
        Me.Label39 = New Wisej.Web.Label()
        Me.Label38 = New Wisej.Web.Label()
        Me.Label37 = New Wisej.Web.Label()
        Me.Label36 = New Wisej.Web.Label()
        Me.Label35 = New Wisej.Web.Label()
        Me.Label34 = New Wisej.Web.Label()
        Me.Label33 = New Wisej.Web.Label()
        Me.Label32 = New Wisej.Web.Label()
        Me.Label31 = New Wisej.Web.Label()
        Me.Label30 = New Wisej.Web.Label()
        Me.GroupBox9 = New Wisej.Web.GroupBox()
        Me.txtObservaciones_Generales = New Wisej.Web.TextBox()
        Me.TabPage6 = New Wisej.Web.TabPage()
        Me.RadioButton21 = New Wisej.Web.RadioButton()
        Me.RBNDesacuerdo = New Wisej.Web.RadioButton()
        Me.RBNAcuerdo = New Wisej.Web.RadioButton()
        Me.txtOtro_Acuerdo = New Wisej.Web.TextBox()
        Me.Label40 = New Wisej.Web.Label()
        Me.TabPage7 = New Wisej.Web.TabPage()
        Me.Panel3 = New Wisej.Web.Panel()
        Me.RadioButton23 = New Wisej.Web.RadioButton()
        Me.RadioButton22 = New Wisej.Web.RadioButton()
        Me.Label41 = New Wisej.Web.Label()
        Me.UserPopup1 = New Wisej.Web.UserPopup(Me.components)
        Me.CBSOrden = New Wisej.Web.ComboBox()
        Me.CBSEstablecimiento = New Wisej.Web.ComboBox()
        Me.GroupBox3 = New Wisej.Web.GroupBox()
        Me.Button2 = New Wisej.Web.Button()
        Me.Button1 = New Wisej.Web.Button()
        Me.Label6 = New Wisej.Web.Label()
        Me.TextBox2 = New Wisej.Web.TextBox()
        Me.txtPropietario = New Wisej.Web.Label()
        Me.Label15 = New Wisej.Web.Label()
        Me.txtMunicipio = New Wisej.Web.Label()
        Me.Label5 = New Wisej.Web.Label()
        Me.Label2 = New Wisej.Web.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGVOperadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCAT_OPERADORES_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.txtTurnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Dock = Wisej.Web.DockStyle.Top
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(1110, 158)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Text = "Menú"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.RBBNUEVO)
        Me.RibbonBarGroup1.Items.Add(Me.RBBGUARDAR)
        Me.RibbonBarGroup1.Items.Add(Me.RBNBUSCAR)
        Me.RibbonBarGroup1.Items.Add(Me.RBNIMPRIMIR)
        Me.RibbonBarGroup1.Items.Add(Me.RBBSALIR)
        Me.RibbonBarGroup1.Text = "Opciones"
        '
        'RBBNUEVO
        '
        Me.RBBNUEVO.ImageSource = "ribbon-document?color=#FF0000"
        Me.RBBNUEVO.Name = "RBBNUEVO"
        Me.RBBNUEVO.Text = "Nuevo"
        '
        'RBBGUARDAR
        '
        Me.RBBGUARDAR.ImageSource = "ribbon-save?color=#FF0000"
        Me.RBBGUARDAR.Name = "RBBGUARDAR"
        Me.RBBGUARDAR.Text = "Guardar"
        '
        'RBNBUSCAR
        '
        Me.RBNBUSCAR.ImageSource = "icon-search?color=#006EFF"
        Me.RBNBUSCAR.Name = "RBNBUSCAR"
        Me.RBNBUSCAR.Text = "Buscar"
        '
        'RBNIMPRIMIR
        '
        Me.RBNIMPRIMIR.ImageSource = "ribbon-print"
        Me.RBNIMPRIMIR.Name = "RBNIMPRIMIR"
        Me.RBNIMPRIMIR.Text = "Imprimir"
        '
        'RBBSALIR
        '
        Me.RBBSALIR.ImageSource = "Resources\Images\Menu\30\exit-sign-red.png?color=#0000FF<<<"
        Me.RBBSALIR.Name = "RBBSALIR"
        Me.RBBSALIR.Text = "Salir"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 3
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Folio/Clave:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(259, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fecha captura:"
        '
        'DTPFecha
        '
        Me.DTPFecha.CustomFormat = "dd/MM/yyyy"
        Me.DTPFecha.Format = Wisej.Web.DateTimePickerFormat.Custom
        Me.DTPFecha.Location = New System.Drawing.Point(259, 37)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(159, 22)
        Me.DTPFecha.TabIndex = 10
        Me.DTPFecha.Value = New Date(2018, 5, 3, 12, 30, 20, 0)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 158)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1110, 467)
        Me.Panel1.TabIndex = 11
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Dock = Wisej.Web.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.PageInsets = New Wisej.Web.Padding(1, 35, 1, 1)
        Me.TabControl1.Size = New System.Drawing.Size(1110, 467)
        Me.TabControl1.TabIndex = 16
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PdfViewer1)
        Me.TabPage3.ImageSource = "Resources\Icons\Menu\PDF.png"
        Me.TabPage3.Location = New System.Drawing.Point(1, 35)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New Wisej.Web.Padding(3)
        Me.TabPage3.Text = "PDF"
        '
        'PdfViewer1
        '
        Me.PdfViewer1.Dock = Wisej.Web.DockStyle.Fill
        Me.PdfViewer1.Location = New System.Drawing.Point(3, 3)
        Me.PdfViewer1.Name = "PdfViewer1"
        Me.PdfViewer1.Size = New System.Drawing.Size(1102, 425)
        Me.PdfViewer1.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.ImageSource = "Resources\Icons\Menu\edit-file.png"
        Me.TabPage1.Location = New System.Drawing.Point(1, 35)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Text = "Datos de la Orden"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CBSVerificadores_Adscritos)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.txtAreaOperadores)
        Me.GroupBox4.Controls.Add(Me.DGVOperadores)
        Me.GroupBox4.Dock = Wisej.Web.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(0, 142)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1108, 200)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.Text = "Verificadores"
        '
        'CBSVerificadores_Adscritos
        '
        Me.CBSVerificadores_Adscritos.BackColor = System.Drawing.Color.Transparent
        Me.CBSVerificadores_Adscritos.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSVerificadores_Adscritos.Items.AddRange(New Object() {"Jurisdicción Sanitaria"})
        Me.CBSVerificadores_Adscritos.Location = New System.Drawing.Point(482, 28)
        Me.CBSVerificadores_Adscritos.Name = "CBSVerificadores_Adscritos"
        Me.CBSVerificadores_Adscritos.Size = New System.Drawing.Size(246, 22)
        Me.CBSVerificadores_Adscritos.TabIndex = 15
        ComponentTool3.ImageSource = "icon-close"
        ComponentTool3.Name = "Borrar"
        Me.CBSVerificadores_Adscritos.Tools.AddRange(New Wisej.Web.ComponentTool() {ComponentTool3})
        Me.CBSVerificadores_Adscritos.Watermark = "Ingrese Texto (Enter)..."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(399, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 16)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Adscrito(s) a:"
        '
        'txtAreaOperadores
        '
        Me.txtAreaOperadores.Location = New System.Drawing.Point(399, 65)
        Me.txtAreaOperadores.Multiline = True
        Me.txtAreaOperadores.Name = "txtAreaOperadores"
        Me.txtAreaOperadores.Size = New System.Drawing.Size(329, 45)
        Me.txtAreaOperadores.TabIndex = 1
        '
        'DGVOperadores
        '
        Me.DGVOperadores.AutoGenerateColumns = False
        Me.DGVOperadores.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.colCve_Operador, Me.colNombre, Me.Column1, Me.enviar})
        Me.DGVOperadores.DataSource = Me.BindingSource1
        Me.DGVOperadores.Dock = Wisej.Web.DockStyle.Left
        Me.DGVOperadores.Location = New System.Drawing.Point(3, 18)
        Me.DGVOperadores.Name = "DGVOperadores"
        Me.DGVOperadores.RowHeadersVisible = False
        Me.DGVOperadores.ShowColumnVisibilityMenu = False
        Me.DGVOperadores.Size = New System.Drawing.Size(381, 179)
        Me.DGVOperadores.TabIndex = 0
        '
        'colCve_Operador
        '
        Me.colCve_Operador.DataPropertyName = "Cve_Operador"
        Me.colCve_Operador.HeaderText = "Cve_Operador"
        Me.colCve_Operador.Name = "colCve_Operador"
        Me.colCve_Operador.Visible = False
        '
        'colNombre
        '
        Me.colNombre.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill
        Me.colNombre.DataPropertyName = "Nombre"
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Name = "colNombre"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Credencial"
        Me.Column1.Name = "Column1"
        '
        'enviar
        '
        Me.enviar.HeaderText = " "
        Me.enviar.Name = "enviar"
        Me.enviar.Width = 35
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "pCAT_OPERADORES_B"
        Me.BindingSource1.DataSource = Me.DataSet_pCAT_OPERADORES_B
        '
        'DataSet_pCAT_OPERADORES_B
        '
        Me.DataSet_pCAT_OPERADORES_B.DataSetName = "DataSet_pCAT_OPERADORES_B"
        Me.DataSet_pCAT_OPERADORES_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEmision_Cargo)
        Me.GroupBox1.Controls.Add(Me.txtEmision_orden)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TXTClaveActa)
        Me.GroupBox1.Controls.Add(Me.DTPFecha_Emision_Orden)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Dock = Wisej.Web.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1108, 142)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.Text = "Datos de la Orden"
        '
        'txtEmision_Cargo
        '
        Me.txtEmision_Cargo.Location = New System.Drawing.Point(325, 100)
        Me.txtEmision_Cargo.Name = "txtEmision_Cargo"
        Me.txtEmision_Cargo.Size = New System.Drawing.Size(243, 22)
        Me.txtEmision_Cargo.TabIndex = 18
        '
        'txtEmision_orden
        '
        Me.txtEmision_orden.Location = New System.Drawing.Point(27, 100)
        Me.txtEmision_orden.Name = "txtEmision_orden"
        Me.txtEmision_orden.Size = New System.Drawing.Size(273, 22)
        Me.txtEmision_orden.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(325, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 16)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Cargo:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 16)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Emitida por:"
        '
        'TXTClaveActa
        '
        Me.TXTClaveActa.AutoSize = True
        Me.TXTClaveActa.Font = New System.Drawing.Font("default", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.TXTClaveActa.Location = New System.Drawing.Point(27, 43)
        Me.TXTClaveActa.Name = "TXTClaveActa"
        Me.TXTClaveActa.Size = New System.Drawing.Size(82, 17)
        Me.TXTClaveActa.TabIndex = 12
        Me.TXTClaveActa.Text = "Seleccione"
        '
        'DTPFecha_Emision_Orden
        '
        Me.DTPFecha_Emision_Orden.CustomFormat = "dd/MM/yyyy"
        Me.DTPFecha_Emision_Orden.Format = Wisej.Web.DateTimePickerFormat.Custom
        Me.DTPFecha_Emision_Orden.Location = New System.Drawing.Point(325, 43)
        Me.DTPFecha_Emision_Orden.Name = "DTPFecha_Emision_Orden"
        Me.DTPFecha_Emision_Orden.Size = New System.Drawing.Size(159, 22)
        Me.DTPFecha_Emision_Orden.TabIndex = 11
        Me.DTPFecha_Emision_Orden.Value = New Date(2018, 4, 27, 17, 13, 26, 835)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Orden de Verificación:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(325, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Fecha Emisión:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.ImageSource = "Resources\Icons\Menu\martillo.png"
        Me.TabPage2.Location = New System.Drawing.Point(1, 35)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Text = "Establecimiento (solo lectura)"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox6)
        Me.Panel2.Dock = Wisej.Web.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.ScrollBars = Wisej.Web.ScrollBars.Vertical
        Me.Panel2.Size = New System.Drawing.Size(1108, 335)
        Me.Panel2.TabIndex = 32
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPropietario_Domicilio)
        Me.GroupBox2.Controls.Add(Me.Label44)
        Me.GroupBox2.Controls.Add(Me.txtPropietario_Nombre)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.CBSPropietario_Cargo)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtPropietario_Identificacion)
        Me.GroupBox2.Controls.Add(Me.RBNIdentificacion_Credencial)
        Me.GroupBox2.Controls.Add(Me.RBNIdentificacion_Pasaporte)
        Me.GroupBox2.Controls.Add(Me.RBNIdentificacion_Otro)
        Me.GroupBox2.Controls.Add(Me.RBNIdentificacion_Conducir)
        Me.GroupBox2.Dock = Wisej.Web.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.ShowCloseButton = True
        Me.GroupBox2.Size = New System.Drawing.Size(1108, 137)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.Text = "Datos del propietario"
        '
        'txtPropietario_Domicilio
        '
        Me.txtPropietario_Domicilio.Location = New System.Drawing.Point(639, 47)
        Me.txtPropietario_Domicilio.Name = "txtPropietario_Domicilio"
        Me.txtPropietario_Domicilio.Size = New System.Drawing.Size(266, 22)
        Me.txtPropietario_Domicilio.TabIndex = 38
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(639, 24)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(66, 16)
        Me.Label44.TabIndex = 37
        Me.Label44.Text = "Domicilio:"
        '
        'txtPropietario_Nombre
        '
        Me.txtPropietario_Nombre.Location = New System.Drawing.Point(30, 47)
        Me.txtPropietario_Nombre.Name = "txtPropietario_Nombre"
        Me.txtPropietario_Nombre.Size = New System.Drawing.Size(277, 22)
        Me.txtPropietario_Nombre.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(30, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(277, 16)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Nombre del propietario o representante legal:"
        '
        'CBSPropietario_Cargo
        '
        Me.CBSPropietario_Cargo.BackColor = System.Drawing.Color.Transparent
        Me.CBSPropietario_Cargo.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSPropietario_Cargo.Items.AddRange(New Object() {"Propietario", "Encargado", "Representante legal", "Responsable", "Ocupante"})
        Me.CBSPropietario_Cargo.Location = New System.Drawing.Point(359, 46)
        Me.CBSPropietario_Cargo.Name = "CBSPropietario_Cargo"
        Me.CBSPropietario_Cargo.Size = New System.Drawing.Size(255, 22)
        Me.CBSPropietario_Cargo.TabIndex = 28
        ComponentTool4.ImageSource = "icon-close"
        ComponentTool4.Name = "Borrar"
        Me.CBSPropietario_Cargo.Tools.AddRange(New Wisej.Web.ComponentTool() {ComponentTool4})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(30, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(178, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Identificación del propietario:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(358, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(148, 16)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Cargo que desempeña:"
        '
        'txtPropietario_Identificacion
        '
        Me.txtPropietario_Identificacion.Enabled = False
        Me.txtPropietario_Identificacion.Location = New System.Drawing.Point(476, 103)
        Me.txtPropietario_Identificacion.Name = "txtPropietario_Identificacion"
        Me.txtPropietario_Identificacion.Size = New System.Drawing.Size(204, 22)
        Me.txtPropietario_Identificacion.TabIndex = 18
        '
        'RBNIdentificacion_Credencial
        '
        Me.RBNIdentificacion_Credencial.Checked = True
        Me.RBNIdentificacion_Credencial.Location = New System.Drawing.Point(30, 103)
        Me.RBNIdentificacion_Credencial.Name = "RBNIdentificacion_Credencial"
        Me.RBNIdentificacion_Credencial.Size = New System.Drawing.Size(90, 23)
        Me.RBNIdentificacion_Credencial.TabIndex = 20
        Me.RBNIdentificacion_Credencial.Text = "Credencial"
        '
        'RBNIdentificacion_Pasaporte
        '
        Me.RBNIdentificacion_Pasaporte.Location = New System.Drawing.Point(144, 103)
        Me.RBNIdentificacion_Pasaporte.Name = "RBNIdentificacion_Pasaporte"
        Me.RBNIdentificacion_Pasaporte.Size = New System.Drawing.Size(87, 23)
        Me.RBNIdentificacion_Pasaporte.TabIndex = 21
        Me.RBNIdentificacion_Pasaporte.TabStop = False
        Me.RBNIdentificacion_Pasaporte.Text = "Pasaporte"
        '
        'RBNIdentificacion_Otro
        '
        Me.RBNIdentificacion_Otro.Location = New System.Drawing.Point(414, 103)
        Me.RBNIdentificacion_Otro.Name = "RBNIdentificacion_Otro"
        Me.RBNIdentificacion_Otro.Size = New System.Drawing.Size(56, 23)
        Me.RBNIdentificacion_Otro.TabIndex = 23
        Me.RBNIdentificacion_Otro.TabStop = False
        Me.RBNIdentificacion_Otro.Text = "Otro:"
        '
        'RBNIdentificacion_Conducir
        '
        Me.RBNIdentificacion_Conducir.Location = New System.Drawing.Point(259, 103)
        Me.RBNIdentificacion_Conducir.Name = "RBNIdentificacion_Conducir"
        Me.RBNIdentificacion_Conducir.Size = New System.Drawing.Size(129, 23)
        Me.RBNIdentificacion_Conducir.TabIndex = 22
        Me.RBNIdentificacion_Conducir.TabStop = False
        Me.RBNIdentificacion_Conducir.Text = "Licencia conducir"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtTelefono)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Controls.Add(Me.txtCorreo)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.txtCodigoPostal)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.txtRFC)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.txtGiro)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.CBSPropietario)
        Me.GroupBox6.Controls.Add(Me.TXTPrograma)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Dock = Wisej.Web.DockStyle.Top
        Me.GroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.ShowCloseButton = True
        Me.GroupBox6.Size = New System.Drawing.Size(1108, 191)
        Me.GroupBox6.TabIndex = 31
        Me.GroupBox6.Text = "Datos generales"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(30, 95)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(200, 22)
        Me.txtTelefono.TabIndex = 35
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(30, 76)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(60, 16)
        Me.Label23.TabIndex = 36
        Me.Label23.Text = "Teléfono"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(245, 95)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(200, 22)
        Me.txtCorreo.TabIndex = 33
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(245, 76)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(117, 16)
        Me.Label22.TabIndex = 34
        Me.Label22.Text = "Correo electrónico"
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.Location = New System.Drawing.Point(461, 36)
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Size = New System.Drawing.Size(100, 22)
        Me.txtCodigoPostal.TabIndex = 31
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(461, 17)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(91, 16)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "Código Postal"
        '
        'txtRFC
        '
        Me.txtRFC.Location = New System.Drawing.Point(244, 36)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(200, 22)
        Me.txtRFC.TabIndex = 29
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(244, 17)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(35, 16)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "RFC"
        '
        'txtGiro
        '
        Me.txtGiro.Enabled = False
        Me.txtGiro.Location = New System.Drawing.Point(30, 36)
        Me.txtGiro.Name = "txtGiro"
        Me.txtGiro.Size = New System.Drawing.Size(200, 22)
        Me.txtGiro.TabIndex = 27
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(30, 17)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(33, 16)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "Giro"
        '
        'CBSPropietario
        '
        Me.CBSPropietario.BackColor = System.Drawing.Color.Transparent
        Me.CBSPropietario.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSPropietario.Location = New System.Drawing.Point(414, 151)
        Me.CBSPropietario.Name = "CBSPropietario"
        Me.CBSPropietario.Size = New System.Drawing.Size(255, 22)
        Me.CBSPropietario.TabIndex = 26
        ComponentTool5.ImageSource = "icon-close"
        ComponentTool5.Name = "Borrar"
        Me.CBSPropietario.Tools.AddRange(New Wisej.Web.ComponentTool() {ComponentTool5})
        Me.CBSPropietario.Watermark = "Ingrese Texto (Enter)..."
        '
        'TXTPrograma
        '
        Me.TXTPrograma.Location = New System.Drawing.Point(30, 152)
        Me.TXTPrograma.Name = "TXTPrograma"
        Me.TXTPrograma.Size = New System.Drawing.Size(322, 22)
        Me.TXTPrograma.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(30, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Programa"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox8)
        Me.TabPage4.Controls.Add(Me.GroupBox7)
        Me.TabPage4.ImageSource = "Resources\Icons\Menu\checklist.png"
        Me.TabPage4.Location = New System.Drawing.Point(1, 35)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New Wisej.Web.Padding(3)
        Me.TabPage4.Text = "Visita Sanitaria"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Panel4)
        Me.GroupBox8.Controls.Add(Me.Label29)
        Me.GroupBox8.Controls.Add(Me.CheckBox7)
        Me.GroupBox8.Controls.Add(Me.CheckBox6)
        Me.GroupBox8.Controls.Add(Me.CheckBox5)
        Me.GroupBox8.Controls.Add(Me.CheckBox4)
        Me.GroupBox8.Controls.Add(Me.CheckBox3)
        Me.GroupBox8.Controls.Add(Me.CheckBox2)
        Me.GroupBox8.Controls.Add(Me.txtTurnos)
        Me.GroupBox8.Controls.Add(Me.DTPLabores_Fin)
        Me.GroupBox8.Controls.Add(Me.DTPLabores_Inicio)
        Me.GroupBox8.Controls.Add(Me.TextBox7)
        Me.GroupBox8.Controls.Add(Me.CheckBox1)
        Me.GroupBox8.Controls.Add(Me.RadioButton6)
        Me.GroupBox8.Controls.Add(Me.RadioButton5)
        Me.GroupBox8.Controls.Add(Me.Label28)
        Me.GroupBox8.Controls.Add(Me.Label27)
        Me.GroupBox8.Controls.Add(Me.Label24)
        Me.GroupBox8.Controls.Add(Me.Label26)
        Me.GroupBox8.Dock = Wisej.Web.DockStyle.Top
        Me.GroupBox8.Location = New System.Drawing.Point(3, 138)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(1102, 243)
        Me.GroupBox8.TabIndex = 1
        Me.GroupBox8.Text = "Información administrativa"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Controls.Add(Me.RadioButton8)
        Me.Panel4.Controls.Add(Me.RadioButton7)
        Me.Panel4.Location = New System.Drawing.Point(279, 21)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(226, 67)
        Me.Panel4.TabIndex = 37
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label25.Location = New System.Drawing.Point(18, 10)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(190, 16)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Cuenta con licencia sanitaria:"
        '
        'RadioButton8
        '
        Me.RadioButton8.Location = New System.Drawing.Point(24, 32)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(38, 23)
        Me.RadioButton8.TabIndex = 23
        Me.RadioButton8.TabStop = False
        Me.RadioButton8.Text = "Si"
        '
        'RadioButton7
        '
        Me.RadioButton7.Location = New System.Drawing.Point(100, 32)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(43, 23)
        Me.RadioButton7.TabIndex = 24
        Me.RadioButton7.TabStop = False
        Me.RadioButton7.Text = "No"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label29.Location = New System.Drawing.Point(294, 191)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(16, 16)
        Me.Label29.TabIndex = 36
        Me.Label29.Text = "a"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox7
        '
        Me.CheckBox7.Appearance = Wisej.Web.Appearance.Button
        Me.CheckBox7.Location = New System.Drawing.Point(297, 114)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(36, 31)
        Me.CheckBox7.TabIndex = 35
        Me.CheckBox7.Text = "D"
        Me.CheckBox7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox6
        '
        Me.CheckBox6.Appearance = Wisej.Web.Appearance.Button
        Me.CheckBox6.Location = New System.Drawing.Point(252, 114)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(35, 31)
        Me.CheckBox6.TabIndex = 34
        Me.CheckBox6.Text = "S"
        Me.CheckBox6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox5
        '
        Me.CheckBox5.Appearance = Wisej.Web.Appearance.Button
        Me.CheckBox5.Location = New System.Drawing.Point(207, 114)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(35, 31)
        Me.CheckBox5.TabIndex = 33
        Me.CheckBox5.Text = "V"
        Me.CheckBox5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox4
        '
        Me.CheckBox4.Appearance = Wisej.Web.Appearance.Button
        Me.CheckBox4.Location = New System.Drawing.Point(162, 114)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(33, 31)
        Me.CheckBox4.TabIndex = 32
        Me.CheckBox4.Text = "J"
        Me.CheckBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox3
        '
        Me.CheckBox3.Appearance = Wisej.Web.Appearance.Button
        Me.CheckBox3.Location = New System.Drawing.Point(117, 114)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(37, 31)
        Me.CheckBox3.TabIndex = 31
        Me.CheckBox3.Text = "M"
        Me.CheckBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox2
        '
        Me.CheckBox2.Appearance = Wisej.Web.Appearance.Button
        Me.CheckBox2.Location = New System.Drawing.Point(72, 114)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(37, 31)
        Me.CheckBox2.TabIndex = 30
        Me.CheckBox2.Text = "M"
        Me.CheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTurnos
        '
        Me.txtTurnos.Location = New System.Drawing.Point(27, 186)
        Me.txtTurnos.Name = "txtTurnos"
        Me.txtTurnos.Size = New System.Drawing.Size(90, 22)
        Me.txtTurnos.TabIndex = 29
        '
        'DTPLabores_Fin
        '
        Me.DTPLabores_Fin.CustomFormat = "hh:mm tt"
        Me.DTPLabores_Fin.Format = Wisej.Web.DateTimePickerFormat.Time
        Me.DTPLabores_Fin.Location = New System.Drawing.Point(318, 186)
        Me.DTPLabores_Fin.Name = "DTPLabores_Fin"
        Me.DTPLabores_Fin.Size = New System.Drawing.Size(125, 22)
        Me.DTPLabores_Fin.TabIndex = 28
        Me.DTPLabores_Fin.Value = New Date(2018, 5, 10, 13, 31, 0, 0)
        '
        'DTPLabores_Inicio
        '
        Me.DTPLabores_Inicio.CustomFormat = "hh:mm tt"
        Me.DTPLabores_Inicio.Format = Wisej.Web.DateTimePickerFormat.Time
        Me.DTPLabores_Inicio.Location = New System.Drawing.Point(162, 186)
        Me.DTPLabores_Inicio.Name = "DTPLabores_Inicio"
        Me.DTPLabores_Inicio.Size = New System.Drawing.Size(125, 22)
        Me.DTPLabores_Inicio.TabIndex = 27
        Me.DTPLabores_Inicio.Value = New Date(2018, 5, 10, 13, 31, 0, 0)
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(161, 214)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(197, 22)
        Me.TextBox7.TabIndex = 26
        Me.TextBox7.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Appearance = Wisej.Web.Appearance.Button
        Me.CheckBox1.Location = New System.Drawing.Point(27, 114)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(33, 31)
        Me.CheckBox1.TabIndex = 25
        Me.CheckBox1.Text = "L"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton6
        '
        Me.RadioButton6.Location = New System.Drawing.Point(103, 53)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(43, 23)
        Me.RadioButton6.TabIndex = 22
        Me.RadioButton6.TabStop = False
        Me.RadioButton6.Text = "No"
        '
        'RadioButton5
        '
        Me.RadioButton5.Checked = True
        Me.RadioButton5.Location = New System.Drawing.Point(27, 53)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(38, 23)
        Me.RadioButton5.TabIndex = 21
        Me.RadioButton5.TabStop = False
        Me.RadioButton5.Text = "Si"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label28.Location = New System.Drawing.Point(21, 164)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(55, 16)
        Me.Label28.TabIndex = 5
        Me.Label28.Text = "Turnos:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label27.Location = New System.Drawing.Point(162, 164)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(122, 16)
        Me.Label27.TabIndex = 4
        Me.Label27.Text = "Horario de labores"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label24.Location = New System.Drawing.Point(21, 31)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(236, 16)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Cuenta con aviso de funcionamiento:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label26.Location = New System.Drawing.Point(21, 92)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(96, 16)
        Me.Label26.TabIndex = 3
        Me.Label26.Text = "Días laborales"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtObjetivo_Verificacion)
        Me.GroupBox7.Dock = Wisej.Web.DockStyle.Top
        Me.GroupBox7.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1102, 135)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.Text = "Objetivo"
        '
        'txtObjetivo_Verificacion
        '
        Me.txtObjetivo_Verificacion.Location = New System.Drawing.Point(21, 25)
        Me.txtObjetivo_Verificacion.Multiline = True
        Me.txtObjetivo_Verificacion.Name = "txtObjetivo_Verificacion"
        Me.txtObjetivo_Verificacion.Size = New System.Drawing.Size(646, 96)
        Me.txtObjetivo_Verificacion.TabIndex = 0
        Me.txtObjetivo_Verificacion.Text = resources.GetString("txtObjetivo_Verificacion.Text")
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.GroupBox5)
        Me.TabPage8.ImageSource = "Resources\Icons\Menu\testigos.png"
        Me.TabPage8.Location = New System.Drawing.Point(1, 35)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Text = "Testigos"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtTestigo_identificacion2)
        Me.GroupBox5.Controls.Add(Me.Label45)
        Me.GroupBox5.Controls.Add(Me.txtTestigo_identificacion1)
        Me.GroupBox5.Controls.Add(Me.Label46)
        Me.GroupBox5.Controls.Add(Me.txtTestigo_Domicilio2)
        Me.GroupBox5.Controls.Add(Me.Label42)
        Me.GroupBox5.Controls.Add(Me.txtTestigo_Domicilio1)
        Me.GroupBox5.Controls.Add(Me.Label43)
        Me.GroupBox5.Controls.Add(Me.txtTestigo2)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.txtTestigo1)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Dock = Wisej.Web.DockStyle.Top
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.ShowCloseButton = True
        Me.GroupBox5.Size = New System.Drawing.Size(1108, 241)
        Me.GroupBox5.TabIndex = 31
        Me.GroupBox5.Text = "Testigos"
        '
        'txtTestigo_identificacion2
        '
        Me.txtTestigo_identificacion2.Location = New System.Drawing.Point(359, 167)
        Me.txtTestigo_identificacion2.Name = "txtTestigo_identificacion2"
        Me.txtTestigo_identificacion2.Size = New System.Drawing.Size(266, 22)
        Me.txtTestigo_identificacion2.TabIndex = 42
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(359, 144)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(90, 16)
        Me.Label45.TabIndex = 41
        Me.Label45.Text = "Identificación:"
        '
        'txtTestigo_identificacion1
        '
        Me.txtTestigo_identificacion1.Location = New System.Drawing.Point(30, 167)
        Me.txtTestigo_identificacion1.Name = "txtTestigo_identificacion1"
        Me.txtTestigo_identificacion1.Size = New System.Drawing.Size(266, 22)
        Me.txtTestigo_identificacion1.TabIndex = 40
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(30, 80)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(66, 16)
        Me.Label46.TabIndex = 39
        Me.Label46.Text = "Domicilio:"
        '
        'txtTestigo_Domicilio2
        '
        Me.txtTestigo_Domicilio2.Location = New System.Drawing.Point(359, 103)
        Me.txtTestigo_Domicilio2.Name = "txtTestigo_Domicilio2"
        Me.txtTestigo_Domicilio2.Size = New System.Drawing.Size(266, 22)
        Me.txtTestigo_Domicilio2.TabIndex = 38
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(359, 80)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(66, 16)
        Me.Label42.TabIndex = 37
        Me.Label42.Text = "Domicilio:"
        '
        'txtTestigo_Domicilio1
        '
        Me.txtTestigo_Domicilio1.Location = New System.Drawing.Point(30, 103)
        Me.txtTestigo_Domicilio1.Name = "txtTestigo_Domicilio1"
        Me.txtTestigo_Domicilio1.Size = New System.Drawing.Size(266, 22)
        Me.txtTestigo_Domicilio1.TabIndex = 36
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(30, 145)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(90, 16)
        Me.Label43.TabIndex = 35
        Me.Label43.Text = "Identificación:"
        '
        'txtTestigo2
        '
        Me.txtTestigo2.Location = New System.Drawing.Point(359, 45)
        Me.txtTestigo2.Name = "txtTestigo2"
        Me.txtTestigo2.Size = New System.Drawing.Size(266, 22)
        Me.txtTestigo2.TabIndex = 34
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(359, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(135, 16)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "Nombre del testigo 2:"
        '
        'txtTestigo1
        '
        Me.txtTestigo1.Location = New System.Drawing.Point(30, 45)
        Me.txtTestigo1.Name = "txtTestigo1"
        Me.txtTestigo1.Size = New System.Drawing.Size(266, 22)
        Me.txtTestigo1.TabIndex = 32
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(30, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(135, 16)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Nombre del testigo 1:"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox10)
        Me.TabPage5.Controls.Add(Me.GroupBox9)
        Me.TabPage5.ImageSource = "icon-search?color=#006EFF"
        Me.TabPage5.Location = New System.Drawing.Point(1, 35)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Text = "Observaciones"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Panel8)
        Me.GroupBox10.Controls.Add(Me.Panel7)
        Me.GroupBox10.Controls.Add(Me.Panel6)
        Me.GroupBox10.Controls.Add(Me.Panel5)
        Me.GroupBox10.Controls.Add(Me.RadioButton10)
        Me.GroupBox10.Controls.Add(Me.RadioButton9)
        Me.GroupBox10.Controls.Add(Me.txtDescribir)
        Me.GroupBox10.Controls.Add(Me.txtNumeroAnexos)
        Me.GroupBox10.Controls.Add(Me.txtSellosReubicados)
        Me.GroupBox10.Controls.Add(Me.txtSellosSuspendidos)
        Me.GroupBox10.Controls.Add(Me.txtSellosAsegurados)
        Me.GroupBox10.Controls.Add(Me.Label39)
        Me.GroupBox10.Controls.Add(Me.Label38)
        Me.GroupBox10.Controls.Add(Me.Label37)
        Me.GroupBox10.Controls.Add(Me.Label36)
        Me.GroupBox10.Controls.Add(Me.Label35)
        Me.GroupBox10.Controls.Add(Me.Label34)
        Me.GroupBox10.Controls.Add(Me.Label33)
        Me.GroupBox10.Controls.Add(Me.Label32)
        Me.GroupBox10.Controls.Add(Me.Label31)
        Me.GroupBox10.Controls.Add(Me.Label30)
        Me.GroupBox10.Dock = Wisej.Web.DockStyle.Top
        Me.GroupBox10.Location = New System.Drawing.Point(0, 168)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(1108, 224)
        Me.GroupBox10.TabIndex = 1
        Me.GroupBox10.Text = "Medidas de Seguridad"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.RadioButton17)
        Me.Panel8.Controls.Add(Me.RadioButton18)
        Me.Panel8.Location = New System.Drawing.Point(813, 83)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(118, 29)
        Me.Panel8.TabIndex = 28
        '
        'RadioButton17
        '
        Me.RadioButton17.Checked = True
        Me.RadioButton17.Location = New System.Drawing.Point(53, 3)
        Me.RadioButton17.Name = "RadioButton17"
        Me.RadioButton17.Size = New System.Drawing.Size(43, 23)
        Me.RadioButton17.TabIndex = 20
        Me.RadioButton17.Text = "No"
        '
        'RadioButton18
        '
        Me.RadioButton18.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton18.Name = "RadioButton18"
        Me.RadioButton18.Size = New System.Drawing.Size(38, 23)
        Me.RadioButton18.TabIndex = 19
        Me.RadioButton18.TabStop = False
        Me.RadioButton18.Text = "Si"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.RadioButton15)
        Me.Panel7.Controls.Add(Me.RadioButton16)
        Me.Panel7.Location = New System.Drawing.Point(813, 20)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(118, 29)
        Me.Panel7.TabIndex = 27
        '
        'RadioButton15
        '
        Me.RadioButton15.Checked = True
        Me.RadioButton15.Location = New System.Drawing.Point(53, 3)
        Me.RadioButton15.Name = "RadioButton15"
        Me.RadioButton15.Size = New System.Drawing.Size(43, 23)
        Me.RadioButton15.TabIndex = 20
        Me.RadioButton15.Text = "No"
        '
        'RadioButton16
        '
        Me.RadioButton16.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton16.Name = "RadioButton16"
        Me.RadioButton16.Size = New System.Drawing.Size(38, 23)
        Me.RadioButton16.TabIndex = 19
        Me.RadioButton16.TabStop = False
        Me.RadioButton16.Text = "Si"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.RadioButton13)
        Me.Panel6.Controls.Add(Me.RadioButton14)
        Me.Panel6.Location = New System.Drawing.Point(306, 118)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(118, 29)
        Me.Panel6.TabIndex = 26
        '
        'RadioButton13
        '
        Me.RadioButton13.Checked = True
        Me.RadioButton13.Location = New System.Drawing.Point(53, 3)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(43, 23)
        Me.RadioButton13.TabIndex = 20
        Me.RadioButton13.Text = "No"
        '
        'RadioButton14
        '
        Me.RadioButton14.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton14.Name = "RadioButton14"
        Me.RadioButton14.Size = New System.Drawing.Size(38, 23)
        Me.RadioButton14.TabIndex = 19
        Me.RadioButton14.TabStop = False
        Me.RadioButton14.Text = "Si"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.RadioButton11)
        Me.Panel5.Controls.Add(Me.RadioButton12)
        Me.Panel5.Location = New System.Drawing.Point(306, 51)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(118, 29)
        Me.Panel5.TabIndex = 25
        '
        'RadioButton11
        '
        Me.RadioButton11.Checked = True
        Me.RadioButton11.Location = New System.Drawing.Point(53, 3)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(43, 23)
        Me.RadioButton11.TabIndex = 20
        Me.RadioButton11.Text = "No"
        '
        'RadioButton12
        '
        Me.RadioButton12.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(38, 23)
        Me.RadioButton12.TabIndex = 19
        Me.RadioButton12.TabStop = False
        Me.RadioButton12.Text = "Si"
        '
        'RadioButton10
        '
        Me.RadioButton10.Checked = True
        Me.RadioButton10.Location = New System.Drawing.Point(360, 30)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(43, 23)
        Me.RadioButton10.TabIndex = 16
        Me.RadioButton10.Text = "No"
        '
        'RadioButton9
        '
        Me.RadioButton9.Location = New System.Drawing.Point(310, 30)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(38, 23)
        Me.RadioButton9.TabIndex = 15
        Me.RadioButton9.TabStop = False
        Me.RadioButton9.Text = "Si"
        '
        'txtDescribir
        '
        Me.txtDescribir.Location = New System.Drawing.Point(511, 166)
        Me.txtDescribir.Multiline = True
        Me.txtDescribir.Name = "txtDescribir"
        Me.txtDescribir.Size = New System.Drawing.Size(301, 47)
        Me.txtDescribir.TabIndex = 14
        '
        'txtNumeroAnexos
        '
        Me.txtNumeroAnexos.Location = New System.Drawing.Point(676, 118)
        Me.txtNumeroAnexos.Name = "txtNumeroAnexos"
        Me.txtNumeroAnexos.Size = New System.Drawing.Size(131, 22)
        Me.txtNumeroAnexos.TabIndex = 13
        '
        'txtSellosReubicados
        '
        Me.txtSellosReubicados.Location = New System.Drawing.Point(800, 55)
        Me.txtSellosReubicados.Name = "txtSellosReubicados"
        Me.txtSellosReubicados.Size = New System.Drawing.Size(131, 22)
        Me.txtSellosReubicados.TabIndex = 12
        '
        'txtSellosSuspendidos
        '
        Me.txtSellosSuspendidos.Location = New System.Drawing.Point(60, 168)
        Me.txtSellosSuspendidos.Name = "txtSellosSuspendidos"
        Me.txtSellosSuspendidos.Size = New System.Drawing.Size(301, 22)
        Me.txtSellosSuspendidos.TabIndex = 11
        '
        'txtSellosAsegurados
        '
        Me.txtSellosAsegurados.Location = New System.Drawing.Point(60, 93)
        Me.txtSellosAsegurados.Name = "txtSellosAsegurados"
        Me.txtSellosAsegurados.Size = New System.Drawing.Size(301, 22)
        Me.txtSellosAsegurados.TabIndex = 10
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label39.Location = New System.Drawing.Point(511, 142)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(67, 16)
        Me.Label39.TabIndex = 9
        Me.Label39.Text = "Describir:"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label38.Location = New System.Drawing.Point(511, 118)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(151, 16)
        Me.Label38.TabIndex = 8
        Me.Label38.Text = "5.1 Número de anexos:"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label37.Location = New System.Drawing.Point(511, 86)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(183, 16)
        Me.Label37.TabIndex = 7
        Me.Label37.Text = "5. Se anexa documentación:"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label36.Location = New System.Drawing.Point(511, 57)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(282, 16)
        Me.Label36.TabIndex = 6
        Me.Label36.Text = "4.1 Número de folio de sello(s) reubicado(s):"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label35.Location = New System.Drawing.Point(511, 26)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(162, 16)
        Me.Label35.TabIndex = 5
        Me.Label35.Text = "4. Reubicación de sellos:"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label34.Location = New System.Drawing.Point(39, 146)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(306, 16)
        Me.Label34.TabIndex = 4
        Me.Label34.Text = "3.1 Número de folio de los sellos de suspención:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label33.Location = New System.Drawing.Point(39, 124)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(242, 16)
        Me.Label33.TabIndex = 3
        Me.Label33.Text = "3. Suspención de trabajos o servicios:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label32.Location = New System.Drawing.Point(39, 77)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(327, 16)
        Me.Label32.TabIndex = 2
        Me.Label32.Text = "2.1 Número de folio de los sellos de aseguramiento:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label31.Location = New System.Drawing.Point(39, 55)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(264, 16)
        Me.Label31.TabIndex = 1
        Me.Label31.Text = "2. Aseguramiento de productos u objetos:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label30.Location = New System.Drawing.Point(39, 33)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(219, 16)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "1. Se aplica medida de Seguridad:"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.txtObservaciones_Generales)
        Me.GroupBox9.Dock = Wisej.Web.DockStyle.Top
        Me.GroupBox9.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(1108, 168)
        Me.GroupBox9.TabIndex = 0
        Me.GroupBox9.Text = "Observaciones generales"
        '
        'txtObservaciones_Generales
        '
        Me.txtObservaciones_Generales.Dock = Wisej.Web.DockStyle.Fill
        Me.txtObservaciones_Generales.Font = New System.Drawing.Font("default, Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtObservaciones_Generales.Location = New System.Drawing.Point(3, 18)
        Me.txtObservaciones_Generales.Multiline = True
        Me.txtObservaciones_Generales.Name = "txtObservaciones_Generales"
        Me.txtObservaciones_Generales.Size = New System.Drawing.Size(1102, 147)
        Me.txtObservaciones_Generales.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.RadioButton21)
        Me.TabPage6.Controls.Add(Me.RBNDesacuerdo)
        Me.TabPage6.Controls.Add(Me.RBNAcuerdo)
        Me.TabPage6.Controls.Add(Me.txtOtro_Acuerdo)
        Me.TabPage6.Controls.Add(Me.Label40)
        Me.TabPage6.ImageSource = "Resources\Icons\Menu\firma.png"
        Me.TabPage6.Location = New System.Drawing.Point(1, 35)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New Wisej.Web.Padding(3)
        Me.TabPage6.Text = "Firmas"
        '
        'RadioButton21
        '
        Me.RadioButton21.Font = New System.Drawing.Font("default", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton21.Location = New System.Drawing.Point(26, 190)
        Me.RadioButton21.Name = "RadioButton21"
        Me.RadioButton21.Size = New System.Drawing.Size(68, 32)
        Me.RadioButton21.TabIndex = 5
        Me.RadioButton21.TabStop = False
        Me.RadioButton21.Text = "Otro"
        '
        'RBNDesacuerdo
        '
        Me.RBNDesacuerdo.Font = New System.Drawing.Font("default", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RBNDesacuerdo.Location = New System.Drawing.Point(290, 117)
        Me.RBNDesacuerdo.Name = "RBNDesacuerdo"
        Me.RBNDesacuerdo.Size = New System.Drawing.Size(166, 32)
        Me.RBNDesacuerdo.TabIndex = 4
        Me.RBNDesacuerdo.TabStop = False
        Me.RBNDesacuerdo.Text = "En desacuerdo"
        '
        'RBNAcuerdo
        '
        Me.RBNAcuerdo.Font = New System.Drawing.Font("default", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RBNAcuerdo.Location = New System.Drawing.Point(26, 117)
        Me.RBNAcuerdo.Name = "RBNAcuerdo"
        Me.RBNAcuerdo.Size = New System.Drawing.Size(188, 32)
        Me.RBNAcuerdo.TabIndex = 3
        Me.RBNAcuerdo.TabStop = False
        Me.RBNAcuerdo.Text = "Estoy de acuerdo"
        '
        'txtOtro_Acuerdo
        '
        Me.txtOtro_Acuerdo.AutoSize = False
        Me.txtOtro_Acuerdo.Enabled = False
        Me.txtOtro_Acuerdo.Location = New System.Drawing.Point(102, 190)
        Me.txtOtro_Acuerdo.Name = "txtOtro_Acuerdo"
        Me.txtOtro_Acuerdo.Size = New System.Drawing.Size(354, 46)
        Me.txtOtro_Acuerdo.TabIndex = 2
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Dock = Wisej.Web.DockStyle.Top
        Me.Label40.Location = New System.Drawing.Point(3, 3)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(1102, 61)
        Me.Label40.TabIndex = 0
        Me.Label40.Text = resources.GetString("Label40.Text")
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.Panel3)
        Me.TabPage7.ImageSource = "Resources\Icons\Menu\jeringa.png"
        Me.TabPage7.Location = New System.Drawing.Point(1, 35)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Text = "Recolección de muestra"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RadioButton23)
        Me.Panel3.Controls.Add(Me.RadioButton22)
        Me.Panel3.Controls.Add(Me.Label41)
        Me.Panel3.Dock = Wisej.Web.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1108, 431)
        Me.Panel3.TabIndex = 0
        '
        'RadioButton23
        '
        Me.RadioButton23.Location = New System.Drawing.Point(295, 16)
        Me.RadioButton23.Name = "RadioButton23"
        Me.RadioButton23.Size = New System.Drawing.Size(43, 23)
        Me.RadioButton23.TabIndex = 2
        Me.RadioButton23.TabStop = False
        Me.RadioButton23.Text = "No"
        '
        'RadioButton22
        '
        Me.RadioButton22.Location = New System.Drawing.Point(235, 16)
        Me.RadioButton22.Name = "RadioButton22"
        Me.RadioButton22.Size = New System.Drawing.Size(38, 23)
        Me.RadioButton22.TabIndex = 1
        Me.RadioButton22.TabStop = False
        Me.RadioButton22.Text = "Sí"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(30, 21)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(188, 16)
        Me.Label41.TabIndex = 0
        Me.Label41.Text = "Se toma muestra de producto:"
        '
        'UserPopup1
        '
        Me.UserPopup1.Location = New System.Drawing.Point(398, 107)
        Me.UserPopup1.Name = "UserPopup1"
        Me.UserPopup1.PlacementModeX = Wisej.Web.PlacementMode.Direct
        Me.UserPopup1.Size = New System.Drawing.Size(363, 213)
        Me.UserPopup1.TabIndex = 37
        '
        'CBSOrden
        '
        Me.CBSOrden.BackColor = System.Drawing.Color.Transparent
        Me.CBSOrden.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSOrden.Font = New System.Drawing.Font("default", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CBSOrden.Location = New System.Drawing.Point(7, 37)
        Me.CBSOrden.Name = "CBSOrden"
        Me.CBSOrden.Size = New System.Drawing.Size(246, 22)
        Me.CBSOrden.TabIndex = 1
        ComponentTool1.ImageSource = "icon-close"
        ComponentTool1.Name = "Borrar"
        Me.CBSOrden.Tools.AddRange(New Wisej.Web.ComponentTool() {ComponentTool1})
        Me.CBSOrden.Watermark = "Ingrese Texto (Enter)..."
        '
        'CBSEstablecimiento
        '
        Me.CBSEstablecimiento.BackColor = System.Drawing.Color.Transparent
        Me.CBSEstablecimiento.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSEstablecimiento.Font = New System.Drawing.Font("default", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CBSEstablecimiento.Location = New System.Drawing.Point(7, 81)
        Me.CBSEstablecimiento.Name = "CBSEstablecimiento"
        Me.CBSEstablecimiento.Size = New System.Drawing.Size(383, 22)
        Me.CBSEstablecimiento.TabIndex = 0
        ComponentTool2.ImageSource = "icon-close"
        ComponentTool2.Name = "Borrar"
        Me.CBSEstablecimiento.Tools.AddRange(New Wisej.Web.ComponentTool() {ComponentTool2})
        Me.CBSEstablecimiento.Watermark = "Ingrese Texto (Enter)..."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.UserPopup1)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.txtPropietario)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtMunicipio)
        Me.GroupBox3.Controls.Add(Me.CBSOrden)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.DTPFecha)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.CBSEstablecimiento)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(316, 31)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(742, 121)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.Text = "Datos generales"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(537, 76)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 27)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Detalles"
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        Me.Button1.BackgroundImageSource = "Resources/Icons/Menu/add.png?color=#FFFFFF"
        Me.Button1.Location = New System.Drawing.Point(398, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(424, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Hora captura:"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("default", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBox2.Location = New System.Drawing.Point(424, 37)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(98, 22)
        Me.TextBox2.TabIndex = 29
        '
        'txtPropietario
        '
        Me.txtPropietario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPropietario.ForeColor = System.Drawing.Color.Navy
        Me.txtPropietario.Location = New System.Drawing.Point(537, 37)
        Me.txtPropietario.Name = "txtPropietario"
        Me.txtPropietario.Size = New System.Drawing.Size(189, 31)
        Me.txtPropietario.TabIndex = 17
        Me.txtPropietario.Text = "Seleccione"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(537, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Propietario:"
        '
        'txtMunicipio
        '
        Me.txtMunicipio.AutoSize = True
        Me.txtMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtMunicipio.ForeColor = System.Drawing.Color.Navy
        Me.txtMunicipio.Location = New System.Drawing.Point(439, 86)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(68, 15)
        Me.txtMunicipio.TabIndex = 13
        Me.txtMunicipio.Text = "Seleccione"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(439, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Jurisdicción:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Establecimiento:"
        '
        'Acta_Capturar
        '
        Me.ClientSize = New System.Drawing.Size(1110, 625)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Acta_Capturar"
        Me.Text = "Capturar acta"
        Me.WindowState = Wisej.Web.FormWindowState.Maximized
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DGVOperadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCAT_OPERADORES_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.txtTurnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonBar1 As RibbonBar
    Friend WithEvents RibbonBarPage1 As RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As RibbonBarGroup
    Friend WithEvents RBBNUEVO As RibbonBarItemButton
    Friend WithEvents RBBGUARDAR As RibbonBarItemButton
    Friend WithEvents RBBSALIR As RibbonBarItemButton
    Friend WithEvents RBNBUSCAR As RibbonBarItemButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DTPFecha As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataSet_pCAT_OPERADORES_B As DataSet_pCAT_OPERADORES_B
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CBSEstablecimiento As ComboBox
    Friend WithEvents txtMunicipio As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DTPFecha_Emision_Orden As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents CBSOrden As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents RBNIdentificacion_Otro As RadioButton
    Friend WithEvents RBNIdentificacion_Conducir As RadioButton
    Friend WithEvents RBNIdentificacion_Pasaporte As RadioButton
    Friend WithEvents RBNIdentificacion_Credencial As RadioButton
    Friend WithEvents txtPropietario_Identificacion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXTPrograma As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents PdfViewer1 As PdfViewer
    Friend WithEvents TXTClaveActa As LinkLabel
    Friend WithEvents Label11 As Label
    Friend WithEvents CBSPropietario_Cargo As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents CBSPropietario As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DGVOperadores As DataGridView
    Private WithEvents colNombre As DataGridViewTextBoxColumn
    Private WithEvents Column0 As DataGridViewCheckBoxColumn
    Friend WithEvents txtAreaOperadores As TextBox
    Friend WithEvents txtPropietario As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CBSVerificadores_Adscritos As ComboBox
    Friend WithEvents Label16 As Label
    Private WithEvents colCve_Operador As DataGridViewTextBoxColumn
    Private WithEvents Column1 As DataGridViewColumn
    Private WithEvents enviar As DataGridViewCheckBoxColumn
    Friend WithEvents txtPropietario_Nombre As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtRFC As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtGiro As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtCodigoPostal As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents txtObjetivo_Verificacion As TextBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents DTPLabores_Fin As DateTimePicker
    Friend WithEvents DTPLabores_Inicio As DateTimePicker
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label29 As Label
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents txtTurnos As NumericUpDown
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents txtObservaciones_Generales As TextBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents txtSellosSuspendidos As TextBox
    Friend WithEvents txtSellosAsegurados As TextBox
    Friend WithEvents txtDescribir As TextBox
    Friend WithEvents txtNumeroAnexos As TextBox
    Friend WithEvents txtSellosReubicados As TextBox
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RBNIMPRIMIR As RibbonBarItemButton
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Label40 As Label
    Friend WithEvents txtOtro_Acuerdo As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RadioButton21 As RadioButton
    Friend WithEvents RBNDesacuerdo As RadioButton
    Friend WithEvents RBNAcuerdo As RadioButton
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RadioButton23 As RadioButton
    Friend WithEvents RadioButton22 As RadioButton
    Friend WithEvents Label41 As Label
    Private WithEvents RadioButton5 As RadioButton
    Private WithEvents RadioButton7 As RadioButton
    Private WithEvents RadioButton8 As RadioButton
    Private WithEvents RadioButton6 As RadioButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents RadioButton13 As RadioButton
    Friend WithEvents RadioButton14 As RadioButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents RadioButton12 As RadioButton
    Friend WithEvents Panel8 As Panel
    Friend WithEvents RadioButton17 As RadioButton
    Friend WithEvents RadioButton18 As RadioButton
    Friend WithEvents Panel7 As Panel
    Friend WithEvents RadioButton15 As RadioButton
    Friend WithEvents RadioButton16 As RadioButton
    Friend WithEvents txtEmision_Cargo As TextBox
    Friend WithEvents txtEmision_orden As TextBox
    Friend WithEvents txtPropietario_Domicilio As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtTestigo_Domicilio2 As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents txtTestigo_Domicilio1 As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents txtTestigo2 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtTestigo1 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtTestigo_identificacion2 As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents txtTestigo_identificacion1 As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents UserPopup1 As UserPopup
End Class
