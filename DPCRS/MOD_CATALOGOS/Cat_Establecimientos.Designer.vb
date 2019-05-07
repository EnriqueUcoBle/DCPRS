Imports Wisej.Web.Ext.RibbonBar
Imports Wisej.Web

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cat_Establecimientos
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
        Dim DataGridViewCellStyle2 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBNNUEVO = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNACTUALIZAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNSALIR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.DGVEstablecimientos = New Wisej.Web.DataGridView()
        Me.DataGridViewImageColumn2 = New Wisej.Web.DataGridViewImageColumn()
        Me.Column0 = New Wisej.Web.DataGridViewImageColumn()
        Me.CVE_ESTABLECIMIENTO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVrazon_social = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVpropietario = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVPropietario_Cargo = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGV_Propietario_domicilio = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVPropietario_identificacion = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVTELEFONO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVEMAIL = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVmunicipio = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVgiro = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVscian = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVdomicilio = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVcolonia = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVrfc = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVcodigo_postal = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVvolumen_produccion = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVhorario_labores = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVAVISO_FUNCIONAMIENTO = New Wisej.Web.DataGridViewCheckBoxColumn()
        Me.DGVLICENCIA_SANITARIA = New Wisej.Web.DataGridViewCheckBoxColumn()
        Me.DGVEstatus = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New Wisej.Web.DataGridViewCheckBoxColumn()
        Me.DGVHORA_INICIO_LABORES = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colHORA_FIN_LABORES = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colDIAS_LABORALES = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVTURNOS = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pCAT_ESTABLECIMIENTOS_B1 = New DPCRS.DataSet_pCAT_ESTABLECIMIENTOS_B()
        Me.Giro = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.SCIAN = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Municipio = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Propietario = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Razon_Social = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.RFC = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Domicilio = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Colonia = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.codigo = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.horario = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.volumen = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New Wisej.Web.DataGridViewCheckBoxColumn()
        Me.ErrorProvider1 = New Wisej.Web.ErrorProvider(Me.components)
        Me.ToolTip1 = New Wisej.Web.ToolTip(Me.components)
        Me.BindingNavigator1 = New Wisej.Web.BindingNavigator(Me.components)
        Me.buttonAddNew = New Wisej.Web.Button()
        Me.buttonMoveFirst = New Wisej.Web.Button()
        Me.buttonMovePrevious = New Wisej.Web.Button()
        Me.separatorLeft = New Wisej.Web.Line()
        Me.textBoxPosition = New Wisej.Web.TextBox()
        Me.labelCount = New Wisej.Web.Label()
        Me.separatorRight = New Wisej.Web.Line()
        Me.buttonMoveNext = New Wisej.Web.Button()
        Me.buttonMoveLast = New Wisej.Web.Button()
        Me.separatorControl = New Wisej.Web.Line()
        Me.buttonDelete = New Wisej.Web.Button()
        Me.Panel2 = New Wisej.Web.Panel()
        Me.RBDesactivado = New Wisej.Web.RadioButton()
        Me.RBHabilitado = New Wisej.Web.RadioButton()
        Me.StyleSheet1 = New Wisej.Web.StyleSheet(Me.components)
        Me.FiltroGrillaSax1 = New DPCRS.filtroGrillaSax()
        CType(Me.DGVEstablecimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCAT_ESTABLECIMIENTOS_B1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Dock = Wisej.Web.DockStyle.Top
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(875, 145)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Text = "Menú"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.RBNNUEVO)
        Me.RibbonBarGroup1.Items.Add(Me.RBNACTUALIZAR)
        Me.RibbonBarGroup1.Items.Add(Me.RBNSALIR)
        Me.RibbonBarGroup1.Text = "Opciones"
        '
        'RBNNUEVO
        '
        Me.RBNNUEVO.ColumnBreak = True
        Me.RBNNUEVO.ImageSource = "ribbon-document?color=#FF0000"
        Me.RBNNUEVO.Text = "Nuevo"
        '
        'RBNACTUALIZAR
        '
        Me.RBNACTUALIZAR.ColumnBreak = True
        Me.RBNACTUALIZAR.ImageSource = "icon-redo?color=#006EFF"
        Me.RBNACTUALIZAR.Text = "Actualizar"
        '
        'RBNSALIR
        '
        Me.RBNSALIR.ColumnBreak = True
        Me.RBNSALIR.ImageSource = "Resources\Images\Menu\30\exit-sign-red.png?color=#0000FF"
        Me.RBNSALIR.Text = "Salir"
        '
        'DGVEstablecimientos
        '
        Me.DGVEstablecimientos.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = Wisej.Web.DataGridViewTriState.[True]
        Me.DGVEstablecimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVEstablecimientos.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.DataGridViewImageColumn2, Me.Column0, Me.CVE_ESTABLECIMIENTO, Me.DGVrazon_social, Me.DGVpropietario, Me.DGVPropietario_Cargo, Me.DGV_Propietario_domicilio, Me.DGVPropietario_identificacion, Me.DGVTELEFONO, Me.DGVEMAIL, Me.DGVmunicipio, Me.DGVgiro, Me.DGVscian, Me.DGVdomicilio, Me.DGVcolonia, Me.DGVrfc, Me.DGVcodigo_postal, Me.DGVvolumen_produccion, Me.DGVhorario_labores, Me.DGVAVISO_FUNCIONAMIENTO, Me.DGVLICENCIA_SANITARIA, Me.DGVEstatus, Me.DataGridViewCheckBoxColumn2, Me.DGVHORA_INICIO_LABORES, Me.colHORA_FIN_LABORES, Me.colDIAS_LABORALES, Me.DGVTURNOS})
        Me.DGVEstablecimientos.DataSource = Me.BindingSource1
        Me.DGVEstablecimientos.Dock = Wisej.Web.DockStyle.Fill
        Me.ErrorProvider1.SetIconAlignment(Me.DGVEstablecimientos, Wisej.Web.ErrorIconAlignment.MiddleLeft)
        Me.DGVEstablecimientos.Location = New System.Drawing.Point(0, 185)
        Me.DGVEstablecimientos.Name = "DGVEstablecimientos"
        Me.DGVEstablecimientos.RowHeadersVisible = False
        Me.DGVEstablecimientos.Size = New System.Drawing.Size(875, 152)
        Me.DGVEstablecimientos.TabIndex = 2
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.DataGridViewImageColumn2.CellImageLayout = Wisej.Web.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn2.CellImageSource = "Resources\Icons\Menu\delete-bin.png"
        DataGridViewCellStyle2.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        DataGridViewCellStyle2.BackgroundImageSource = "Resources/Icons/Menu/delete-bin.png"
        Me.DataGridViewImageColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewImageColumn2.FillWeight = 30.0!
        Me.DataGridViewImageColumn2.Frozen = True
        Me.DataGridViewImageColumn2.HeaderText = " "
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Resizable = Wisej.Web.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn2.ValueType = GetType(String)
        Me.DataGridViewImageColumn2.Width = 25
        '
        'Column0
        '
        Me.Column0.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.Column0.CellImageLayout = Wisej.Web.DataGridViewImageCellLayout.Stretch
        DataGridViewCellStyle3.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        DataGridViewCellStyle3.BackgroundImageSource = "Resources/Icons/Menu/edit.png"
        Me.Column0.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column0.Frozen = True
        Me.Column0.Name = "Column0"
        Me.Column0.ReadOnly = True
        Me.Column0.ValueType = GetType(String)
        Me.Column0.Width = 25
        '
        'CVE_ESTABLECIMIENTO
        '
        Me.CVE_ESTABLECIMIENTO.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CVE_ESTABLECIMIENTO.DataPropertyName = "CVE_ESTABLECIMIENTO"
        Me.CVE_ESTABLECIMIENTO.Frozen = True
        Me.CVE_ESTABLECIMIENTO.HeaderText = "Cve Establecimiento"
        Me.CVE_ESTABLECIMIENTO.Name = "CVE_ESTABLECIMIENTO"
        Me.CVE_ESTABLECIMIENTO.ReadOnly = True
        Me.CVE_ESTABLECIMIENTO.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.CVE_ESTABLECIMIENTO.ValueType = GetType(Integer)
        Me.CVE_ESTABLECIMIENTO.Visible = False
        '
        'DGVrazon_social
        '
        Me.DGVrazon_social.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DGVrazon_social.DataPropertyName = "RAZON_SOCIAL"
        Me.DGVrazon_social.HeaderText = "Razón social"
        Me.DGVrazon_social.Name = "DGVrazon_social"
        Me.DGVrazon_social.ReadOnly = True
        Me.DGVrazon_social.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVrazon_social.ValueType = GetType(String)
        Me.DGVrazon_social.Width = 200
        '
        'DGVpropietario
        '
        Me.DGVpropietario.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DGVpropietario.DataPropertyName = "NOM_PROPIETARIO"
        Me.DGVpropietario.HeaderText = "Nombre encargado"
        Me.DGVpropietario.Name = "DGVpropietario"
        Me.DGVpropietario.ReadOnly = True
        Me.DGVpropietario.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVpropietario.ValueType = GetType(String)
        Me.DGVpropietario.Width = 200
        '
        'DGVPropietario_Cargo
        '
        Me.DGVPropietario_Cargo.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DGVPropietario_Cargo.DataPropertyName = "PROPIETARIO_CARGO"
        Me.DGVPropietario_Cargo.HeaderText = "Cargo"
        Me.DGVPropietario_Cargo.Name = "DGVPropietario_Cargo"
        Me.DGVPropietario_Cargo.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVPropietario_Cargo.ValueType = GetType(String)
        Me.DGVPropietario_Cargo.Visible = False
        '
        'DGV_Propietario_domicilio
        '
        Me.DGV_Propietario_domicilio.DataPropertyName = "PROPIETARIO_DOMICILIO"
        Me.DGV_Propietario_domicilio.HeaderText = "Domicilio del encargado"
        Me.DGV_Propietario_domicilio.Name = "DGV_Propietario_domicilio"
        Me.DGV_Propietario_domicilio.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGV_Propietario_domicilio.ValueType = GetType(String)
        Me.DGV_Propietario_domicilio.Visible = False
        '
        'DGVPropietario_identificacion
        '
        Me.DGVPropietario_identificacion.DataPropertyName = "PROPIETARIO_IDENTIFICACION"
        Me.DGVPropietario_identificacion.HeaderText = "Identificación"
        Me.DGVPropietario_identificacion.Name = "DGVPropietario_identificacion"
        Me.DGVPropietario_identificacion.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVPropietario_identificacion.ValueType = GetType(String)
        Me.DGVPropietario_identificacion.Visible = False
        '
        'DGVTELEFONO
        '
        Me.DGVTELEFONO.DataPropertyName = "TELEFONO"
        Me.DGVTELEFONO.HeaderText = "Teléfono"
        Me.DGVTELEFONO.Name = "DGVTELEFONO"
        Me.DGVTELEFONO.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVTELEFONO.ValueType = GetType(String)
        '
        'DGVEMAIL
        '
        Me.DGVEMAIL.DataPropertyName = "EMAIL"
        Me.DGVEMAIL.HeaderText = "Email"
        Me.DGVEMAIL.Name = "DGVEMAIL"
        Me.DGVEMAIL.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVEMAIL.ValueType = GetType(String)
        '
        'DGVmunicipio
        '
        Me.DGVmunicipio.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DGVmunicipio.DataPropertyName = "MUNICIPIOX"
        Me.DGVmunicipio.HeaderText = "Municipio"
        Me.DGVmunicipio.Name = "DGVmunicipio"
        Me.DGVmunicipio.ReadOnly = True
        Me.DGVmunicipio.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVmunicipio.ValueType = GetType(String)
        Me.DGVmunicipio.Width = 160
        '
        'DGVgiro
        '
        Me.DGVgiro.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DGVgiro.DataPropertyName = "GIROX"
        Me.DGVgiro.HeaderText = "Giro"
        Me.DGVgiro.Name = "DGVgiro"
        Me.DGVgiro.ReadOnly = True
        Me.DGVgiro.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVgiro.ValueType = GetType(String)
        Me.DGVgiro.Width = 200
        '
        'DGVscian
        '
        Me.DGVscian.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DGVscian.DataPropertyName = "CVE_SCIAN"
        Me.DGVscian.HeaderText = "Cve SCIAN"
        Me.DGVscian.Name = "DGVscian"
        Me.DGVscian.ReadOnly = True
        Me.DGVscian.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVscian.ValueType = GetType(String)
        '
        'DGVdomicilio
        '
        Me.DGVdomicilio.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DGVdomicilio.DataPropertyName = "DOMICILIO"
        Me.DGVdomicilio.HeaderText = "Domicilio"
        Me.DGVdomicilio.Name = "DGVdomicilio"
        Me.DGVdomicilio.ReadOnly = True
        Me.DGVdomicilio.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVdomicilio.ValueType = GetType(String)
        Me.DGVdomicilio.Width = 220
        '
        'DGVcolonia
        '
        Me.DGVcolonia.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DGVcolonia.DataPropertyName = "COLONIA"
        Me.DGVcolonia.HeaderText = "Colonia"
        Me.DGVcolonia.Name = "DGVcolonia"
        Me.DGVcolonia.ReadOnly = True
        Me.DGVcolonia.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVcolonia.ValueType = GetType(String)
        Me.DGVcolonia.Width = 130
        '
        'DGVrfc
        '
        Me.DGVrfc.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DGVrfc.DataPropertyName = "RFC"
        Me.DGVrfc.HeaderText = "RFC"
        Me.DGVrfc.Name = "DGVrfc"
        Me.DGVrfc.ReadOnly = True
        Me.DGVrfc.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVrfc.ValueType = GetType(String)
        Me.DGVrfc.Width = 130
        '
        'DGVcodigo_postal
        '
        Me.DGVcodigo_postal.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DGVcodigo_postal.DataPropertyName = "CODIGO_POSTAL"
        Me.DGVcodigo_postal.HeaderText = "Codigo postal"
        Me.DGVcodigo_postal.Name = "DGVcodigo_postal"
        Me.DGVcodigo_postal.ReadOnly = True
        Me.DGVcodigo_postal.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVcodigo_postal.ValueType = GetType(String)
        '
        'DGVvolumen_produccion
        '
        Me.DGVvolumen_produccion.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DGVvolumen_produccion.DataPropertyName = "VOLUMEN_PRODUCCION"
        Me.DGVvolumen_produccion.HeaderText = "Volumen produccion"
        Me.DGVvolumen_produccion.Name = "DGVvolumen_produccion"
        Me.DGVvolumen_produccion.ReadOnly = True
        Me.DGVvolumen_produccion.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVvolumen_produccion.ValueType = GetType(String)
        Me.DGVvolumen_produccion.Width = 130
        '
        'DGVhorario_labores
        '
        Me.DGVhorario_labores.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DGVhorario_labores.DataPropertyName = "HORARIO_LABORES"
        Me.DGVhorario_labores.HeaderText = "Horario labores"
        Me.DGVhorario_labores.Name = "DGVhorario_labores"
        Me.DGVhorario_labores.ReadOnly = True
        Me.DGVhorario_labores.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVhorario_labores.ValueType = GetType(String)
        '
        'DGVAVISO_FUNCIONAMIENTO
        '
        Me.DGVAVISO_FUNCIONAMIENTO.DataPropertyName = "AVISO_FUNCIONAMIENTO"
        Me.DGVAVISO_FUNCIONAMIENTO.HeaderText = "Aviso de fucionamiento"
        Me.DGVAVISO_FUNCIONAMIENTO.Name = "DGVAVISO_FUNCIONAMIENTO"
        Me.DGVAVISO_FUNCIONAMIENTO.ValueType = GetType(Boolean)
        '
        'DGVLICENCIA_SANITARIA
        '
        Me.DGVLICENCIA_SANITARIA.DataPropertyName = "LICENCIA_SANITARIA"
        Me.DGVLICENCIA_SANITARIA.HeaderText = "Licencia sanitaria"
        Me.DGVLICENCIA_SANITARIA.Name = "DGVLICENCIA_SANITARIA"
        Me.DGVLICENCIA_SANITARIA.ValueType = GetType(Boolean)
        '
        'DGVEstatus
        '
        Me.DGVEstatus.DataPropertyName = "ESTATUS"
        Me.DGVEstatus.HeaderText = "Estatus"
        Me.DGVEstatus.Name = "DGVEstatus"
        Me.DGVEstatus.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVEstatus.ValueType = GetType(String)
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "HABILITADO"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Habilitado"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.ValueType = GetType(Boolean)
        Me.DataGridViewCheckBoxColumn2.Visible = False
        '
        'DGVHORA_INICIO_LABORES
        '
        Me.DGVHORA_INICIO_LABORES.DataPropertyName = "HORA_INICIO_LABORES"
        Me.DGVHORA_INICIO_LABORES.HeaderText = "Hora Inicio Labores"
        Me.DGVHORA_INICIO_LABORES.Name = "DGVHORA_INICIO_LABORES"
        Me.DGVHORA_INICIO_LABORES.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVHORA_INICIO_LABORES.ValueType = GetType(System.TimeSpan)
        Me.DGVHORA_INICIO_LABORES.Visible = False
        '
        'colHORA_FIN_LABORES
        '
        Me.colHORA_FIN_LABORES.DataPropertyName = "HORA_FIN_LABORES"
        Me.colHORA_FIN_LABORES.HeaderText = "Hora Fin Labores"
        Me.colHORA_FIN_LABORES.Name = "colHORA_FIN_LABORES"
        Me.colHORA_FIN_LABORES.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.colHORA_FIN_LABORES.ValueType = GetType(System.TimeSpan)
        Me.colHORA_FIN_LABORES.Visible = False
        '
        'colDIAS_LABORALES
        '
        Me.colDIAS_LABORALES.DataPropertyName = "DIAS_LABORALES"
        Me.colDIAS_LABORALES.HeaderText = "Dias laborales"
        Me.colDIAS_LABORALES.Name = "colDIAS_LABORALES"
        Me.colDIAS_LABORALES.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.colDIAS_LABORALES.ValueType = GetType(String)
        '
        'DGVTURNOS
        '
        Me.DGVTURNOS.DataPropertyName = "TURNOS"
        Me.DGVTURNOS.HeaderText = "Turnos"
        Me.DGVTURNOS.Name = "DGVTURNOS"
        Me.DGVTURNOS.ValueType = GetType(Integer)
        Me.DGVTURNOS.Visible = False
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "pCAT_ESTABLECIMIENTOS_B"
        Me.BindingSource1.DataSource = Me.DataSet_pCAT_ESTABLECIMIENTOS_B1
        '
        'DataSet_pCAT_ESTABLECIMIENTOS_B1
        '
        Me.DataSet_pCAT_ESTABLECIMIENTOS_B1.DataSetName = "DataSet_pCAT_ESTABLECIMIENTOS_B"
        Me.DataSet_pCAT_ESTABLECIMIENTOS_B1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Giro
        '
        Me.Giro.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.Giro.DataPropertyName = "GIROX"
        Me.Giro.HeaderText = "Giro"
        Me.Giro.Name = "Giro"
        Me.Giro.ReadOnly = True
        Me.Giro.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.Giro.ValueType = GetType(String)
        '
        'SCIAN
        '
        Me.SCIAN.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.SCIAN.DataPropertyName = "CVE_SCIAN"
        Me.SCIAN.HeaderText = "Clave SCIAN"
        Me.SCIAN.Name = "SCIAN"
        Me.SCIAN.ReadOnly = True
        Me.SCIAN.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.SCIAN.ValueType = GetType(String)
        '
        'Municipio
        '
        Me.Municipio.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.Municipio.DataPropertyName = "MUNICIPIOX"
        Me.Municipio.Name = "Municipio"
        Me.Municipio.ReadOnly = True
        Me.Municipio.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.Municipio.ValueType = GetType(String)
        '
        'Propietario
        '
        Me.Propietario.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.Propietario.DataPropertyName = "NOM_PROPIETARIO"
        Me.Propietario.Name = "Propietario"
        Me.Propietario.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.Propietario.ValueType = GetType(String)
        '
        'Razon_Social
        '
        Me.Razon_Social.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.Razon_Social.DataPropertyName = "RAZON_SOCIAL"
        Me.Razon_Social.HeaderText = "Razon Social"
        Me.Razon_Social.Name = "Razon_Social"
        Me.Razon_Social.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.Razon_Social.ValueType = GetType(String)
        '
        'RFC
        '
        Me.RFC.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.RFC.DataPropertyName = "RFC"
        Me.RFC.Name = "RFC"
        Me.RFC.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.RFC.ValueType = GetType(String)
        '
        'Domicilio
        '
        Me.Domicilio.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.Domicilio.DataPropertyName = "DOMICILIO"
        Me.Domicilio.Name = "Domicilio"
        Me.Domicilio.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.Domicilio.ValueType = GetType(String)
        '
        'Colonia
        '
        Me.Colonia.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.Colonia.DataPropertyName = "COLONIA"
        Me.Colonia.Name = "Colonia"
        Me.Colonia.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.Colonia.ValueType = GetType(String)
        '
        'codigo
        '
        Me.codigo.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.codigo.DataPropertyName = "CODIGO_POSTAL"
        Me.codigo.HeaderText = "Codigo Postal"
        Me.codigo.Name = "codigo"
        Me.codigo.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.codigo.ValueType = GetType(String)
        '
        'horario
        '
        Me.horario.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.horario.DataPropertyName = "HORARIO_LABORES"
        Me.horario.HeaderText = "Horario labores"
        Me.horario.Name = "horario"
        Me.horario.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.horario.ValueType = GetType(String)
        '
        'volumen
        '
        Me.volumen.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.volumen.DataPropertyName = "VOLUMEN_PRODUCCION"
        Me.volumen.HeaderText = "Volumen producción"
        Me.volumen.Name = "volumen"
        Me.volumen.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.volumen.ValueType = GetType(String)
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "HABILITADO"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Habilitado"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ValueType = GetType(Boolean)
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 3
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.buttonAddNew
        Me.BindingNavigator1.BindingSource = Me.BindingSource1
        Me.BindingNavigator1.Controls.Add(Me.buttonMoveFirst)
        Me.BindingNavigator1.Controls.Add(Me.buttonMovePrevious)
        Me.BindingNavigator1.Controls.Add(Me.separatorLeft)
        Me.BindingNavigator1.Controls.Add(Me.textBoxPosition)
        Me.BindingNavigator1.Controls.Add(Me.labelCount)
        Me.BindingNavigator1.Controls.Add(Me.separatorRight)
        Me.BindingNavigator1.Controls.Add(Me.buttonMoveNext)
        Me.BindingNavigator1.Controls.Add(Me.buttonMoveLast)
        Me.BindingNavigator1.Controls.Add(Me.separatorControl)
        Me.BindingNavigator1.Controls.Add(Me.buttonAddNew)
        Me.BindingNavigator1.Controls.Add(Me.buttonDelete)
        Me.BindingNavigator1.CountItem = Me.labelCount
        Me.BindingNavigator1.DeleteItem = Me.buttonDelete
        Me.BindingNavigator1.Dock = Wisej.Web.DockStyle.Bottom
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 337)
        Me.BindingNavigator1.MoveFirstItem = Me.buttonMoveFirst
        Me.BindingNavigator1.MoveLastItem = Me.buttonMoveLast
        Me.BindingNavigator1.MoveNextItem = Me.buttonMoveNext
        Me.BindingNavigator1.MovePreviousItem = Me.buttonMovePrevious
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.textBoxPosition
        Me.BindingNavigator1.Size = New System.Drawing.Size(875, 33)
        Me.BindingNavigator1.TabIndex = 13
        '
        'buttonAddNew
        '
        Me.buttonAddNew.ImageSource = "table-row-new"
        Me.buttonAddNew.Location = New System.Drawing.Point(366, 3)
        Me.buttonAddNew.Name = "buttonAddNew"
        Me.buttonAddNew.Size = New System.Drawing.Size(37, 28)
        Me.buttonAddNew.TabIndex = 4
        '
        'buttonMoveFirst
        '
        Me.buttonMoveFirst.ImageSource = "icon-first"
        Me.buttonMoveFirst.Location = New System.Drawing.Point(3, 3)
        Me.buttonMoveFirst.Name = "buttonMoveFirst"
        Me.buttonMoveFirst.Size = New System.Drawing.Size(37, 28)
        Me.buttonMoveFirst.TabIndex = 0
        '
        'buttonMovePrevious
        '
        Me.buttonMovePrevious.ImageSource = "icon-left"
        Me.buttonMovePrevious.Location = New System.Drawing.Point(46, 3)
        Me.buttonMovePrevious.Name = "buttonMovePrevious"
        Me.buttonMovePrevious.Size = New System.Drawing.Size(37, 28)
        Me.buttonMovePrevious.TabIndex = 1
        '
        'separatorLeft
        '
        Me.separatorLeft.Location = New System.Drawing.Point(89, 3)
        Me.separatorLeft.Name = "separatorLeft"
        Me.separatorLeft.Orientation = Wisej.Web.Orientation.Vertical
        Me.separatorLeft.Padding = New Wisej.Web.Padding(0, 5, 0, 5)
        Me.separatorLeft.Size = New System.Drawing.Size(14, 28)
        '
        'textBoxPosition
        '
        Me.textBoxPosition.AutoSize = False
        Me.textBoxPosition.Location = New System.Drawing.Point(109, 3)
        Me.textBoxPosition.Name = "textBoxPosition"
        Me.textBoxPosition.Size = New System.Drawing.Size(50, 28)
        Me.textBoxPosition.TabIndex = 6
        Me.textBoxPosition.Text = "0"
        '
        'labelCount
        '
        Me.labelCount.Location = New System.Drawing.Point(165, 3)
        Me.labelCount.Name = "labelCount"
        Me.labelCount.Size = New System.Drawing.Size(69, 28)
        Me.labelCount.TabIndex = 7
        Me.labelCount.Text = "of {0}"
        Me.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'separatorRight
        '
        Me.separatorRight.Location = New System.Drawing.Point(240, 3)
        Me.separatorRight.Name = "separatorRight"
        Me.separatorRight.Orientation = Wisej.Web.Orientation.Vertical
        Me.separatorRight.Padding = New Wisej.Web.Padding(0, 5, 0, 5)
        Me.separatorRight.Size = New System.Drawing.Size(14, 28)
        '
        'buttonMoveNext
        '
        Me.buttonMoveNext.ImageSource = "icon-right"
        Me.buttonMoveNext.Location = New System.Drawing.Point(260, 3)
        Me.buttonMoveNext.Name = "buttonMoveNext"
        Me.buttonMoveNext.Size = New System.Drawing.Size(37, 28)
        Me.buttonMoveNext.TabIndex = 2
        '
        'buttonMoveLast
        '
        Me.buttonMoveLast.ImageSource = "icon-last"
        Me.buttonMoveLast.Location = New System.Drawing.Point(303, 3)
        Me.buttonMoveLast.Name = "buttonMoveLast"
        Me.buttonMoveLast.Size = New System.Drawing.Size(37, 28)
        Me.buttonMoveLast.TabIndex = 3
        '
        'separatorControl
        '
        Me.separatorControl.Location = New System.Drawing.Point(346, 3)
        Me.separatorControl.Name = "separatorControl"
        Me.separatorControl.Orientation = Wisej.Web.Orientation.Vertical
        Me.separatorControl.Padding = New Wisej.Web.Padding(0, 5, 0, 5)
        Me.separatorControl.Size = New System.Drawing.Size(14, 28)
        '
        'buttonDelete
        '
        Me.buttonDelete.ImageSource = "icon-close"
        Me.buttonDelete.Location = New System.Drawing.Point(409, 3)
        Me.buttonDelete.Name = "buttonDelete"
        Me.buttonDelete.Size = New System.Drawing.Size(37, 28)
        Me.buttonDelete.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RBDesactivado)
        Me.Panel2.Controls.Add(Me.RBHabilitado)
        Me.Panel2.Location = New System.Drawing.Point(303, 107)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(212, 32)
        Me.Panel2.TabIndex = 13
        '
        'RBDesactivado
        '
        Me.RBDesactivado.Location = New System.Drawing.Point(100, 4)
        Me.RBDesactivado.Name = "RBDesactivado"
        Me.RBDesactivado.Size = New System.Drawing.Size(100, 23)
        Me.RBDesactivado.TabIndex = 12
        Me.RBDesactivado.TabStop = False
        Me.RBDesactivado.Text = "Desactivado"
        '
        'RBHabilitado
        '
        Me.RBHabilitado.Checked = True
        Me.RBHabilitado.Location = New System.Drawing.Point(9, 4)
        Me.RBHabilitado.Name = "RBHabilitado"
        Me.RBHabilitado.Size = New System.Drawing.Size(85, 23)
        Me.RBHabilitado.TabIndex = 11
        Me.RBHabilitado.Text = "Habilitado"
        '
        'StyleSheet1
        '
        Me.StyleSheet1.StyleSheetSource = "css\StyleDPCRS.css"
        '
        'FiltroGrillaSax1
        '
        Me.FiltroGrillaSax1.AutoSize = True
        Me.FiltroGrillaSax1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.FiltroGrillaSax1.BackColor = System.Drawing.Color.Transparent
        Me.FiltroGrillaSax1.Dock = Wisej.Web.DockStyle.Top
        Me.FiltroGrillaSax1.Location = New System.Drawing.Point(0, 145)
        Me.FiltroGrillaSax1.meBackcolorEtiquetas = System.Drawing.Color.AliceBlue
        Me.FiltroGrillaSax1.meBorderStyleEtiquetas = Wisej.Web.BorderStyle.Solid
        Me.FiltroGrillaSax1.meBorderWidthEtiquetas = 1
        Me.FiltroGrillaSax1.meDatagrid = Nothing
        Me.FiltroGrillaSax1.meFiltrarVacios = False
        Me.FiltroGrillaSax1.meLanzarException = False
        Me.FiltroGrillaSax1.meMarginEtiquetas = New Wisej.Web.Padding(1)
        Me.FiltroGrillaSax1.mePaddingEtiquetas = New Wisej.Web.Padding(2)
        Me.FiltroGrillaSax1.Name = "FiltroGrillaSax1"
        Me.FiltroGrillaSax1.Size = New System.Drawing.Size(875, 40)
        Me.FiltroGrillaSax1.TabIndex = 1
        '
        'Cat_Establecimientos
        '
        Me.ClientSize = New System.Drawing.Size(875, 370)
        Me.Controls.Add(Me.DGVEstablecimientos)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FiltroGrillaSax1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Cat_Establecimientos"
        Me.Text = "Establecimientos"
        Me.WindowState = Wisej.Web.FormWindowState.Maximized
        CType(Me.DGVEstablecimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCAT_ESTABLECIMIENTOS_B1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonBar1 As RibbonBar
    Friend WithEvents RibbonBarPage1 As RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As RibbonBarGroup
    Friend WithEvents RBNNUEVO As RibbonBarItemButton
    Friend WithEvents RBNSALIR As RibbonBarItemButton
    Friend WithEvents FiltroGrillaSax1 As filtroGrillaSax
    Friend WithEvents DGVEstablecimientos As DataGridView
    Friend WithEvents RBNACTUALIZAR As RibbonBarItemButton
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataSet_pCAT_ESTABLECIMIENTOS_B1 As DataSet_pCAT_ESTABLECIMIENTOS_B
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents RBDesactivado As RadioButton
    Friend WithEvents RBHabilitado As RadioButton
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents buttonAddNew As Button
    Friend WithEvents buttonMoveFirst As Button
    Friend WithEvents buttonMovePrevious As Button
    Friend WithEvents separatorLeft As Line
    Friend WithEvents textBoxPosition As TextBox
    Friend WithEvents labelCount As Label
    Friend WithEvents separatorRight As Line
    Friend WithEvents buttonMoveNext As Button
    Friend WithEvents buttonMoveLast As Button
    Friend WithEvents separatorControl As Line
    Friend WithEvents buttonDelete As Button
    Private WithEvents Giro As DataGridViewTextBoxColumn
    Private WithEvents SCIAN As DataGridViewTextBoxColumn
    Private WithEvents Municipio As DataGridViewTextBoxColumn
    Private WithEvents Propietario As DataGridViewTextBoxColumn
    Private WithEvents Razon_Social As DataGridViewTextBoxColumn
    Private WithEvents RFC As DataGridViewTextBoxColumn
    Private WithEvents Domicilio As DataGridViewTextBoxColumn
    Private WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Private WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Private WithEvents Colonia As DataGridViewTextBoxColumn
    Private WithEvents codigo As DataGridViewTextBoxColumn
    Private WithEvents horario As DataGridViewTextBoxColumn
    Private WithEvents volumen As DataGridViewTextBoxColumn
    Private WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Private WithEvents DGVcve_establecimiento As DataGridViewTextBoxColumn
    Private WithEvents DGVgiro As DataGridViewTextBoxColumn
    Private WithEvents DGVscian As DataGridViewTextBoxColumn
    Private WithEvents DGVmunicipio As DataGridViewTextBoxColumn
    Private WithEvents DGVpropietario As DataGridViewTextBoxColumn
    Private WithEvents DGVrazon_social As DataGridViewTextBoxColumn
    Private WithEvents DGVrfc As DataGridViewTextBoxColumn
    Private WithEvents DGVdomicilio As DataGridViewTextBoxColumn
    Private WithEvents DGVcolonia As DataGridViewTextBoxColumn
    Private WithEvents DGVcodigo_postal As DataGridViewTextBoxColumn
    Private WithEvents DGVvolumen_produccion As DataGridViewTextBoxColumn
    Private WithEvents colPROPIETARIO_CARGO As DataGridViewTextBoxColumn
    Private WithEvents colPROPIETARIO_DOMICILIO As DataGridViewTextBoxColumn
    Private WithEvents colPROPIETARIO_IDENTIFICACION As DataGridViewTextBoxColumn
    Private WithEvents DGVEstatus As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Private WithEvents colHORARIO_LABORES As DataGridViewTextBoxColumn
    Private WithEvents DGVPropietario_Cargo As DataGridViewTextBoxColumn
    Private WithEvents DGV_Propietario_domicilio As DataGridViewTextBoxColumn
    Private WithEvents DGVPropietario_identificacion As DataGridViewTextBoxColumn
    Private WithEvents DGVhorario_labores As DataGridViewTextBoxColumn
    Private WithEvents Column0 As DataGridViewImageColumn
    Private WithEvents DGVHORA_INICIO_LABORES As DataGridViewTextBoxColumn
    Private WithEvents colHORA_FIN_LABORES As DataGridViewTextBoxColumn
    Private WithEvents colDIAS_LABORALES As DataGridViewTextBoxColumn
    Private WithEvents DGVTELEFONO As DataGridViewTextBoxColumn
    Private WithEvents DGVEMAIL As DataGridViewTextBoxColumn
    Friend WithEvents StyleSheet1 As StyleSheet
    Private WithEvents CVE_ESTABLECIMIENTO As DataGridViewTextBoxColumn
    Private WithEvents DGVAVISO_FUNCIONAMIENTO As DataGridViewCheckBoxColumn
    Private WithEvents DGVLICENCIA_SANITARIA As DataGridViewCheckBoxColumn
    Private WithEvents DGVTURNOS As DataGridViewTextBoxColumn
End Class
