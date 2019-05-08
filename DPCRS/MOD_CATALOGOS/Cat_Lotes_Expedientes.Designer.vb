Imports Wisej.Web.Ext.RibbonBar
Imports Wisej.Web

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cat_Lotes_Expedientes
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
        Dim DataGridViewCellStyle4 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Dim ComponentTool1 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Me.DGVExpedientes = New Wisej.Web.DataGridView()
        Me.Eliminar = New Wisej.Web.DataGridViewImageColumn()
        Me.Column0 = New Wisej.Web.DataGridViewImageColumn()
        Me.colCVE_LOTE = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colNUM_CONSECUTIVO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVGCLAVE = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colCVE_ESTABLECIMIENTO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colRAZON_SOCIAL = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colPROPIETARIO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colCVE_MUNICIPIO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colMUNICIPIO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colFECHA = New Wisej.Web.DataGridViewDateTimePickerColumn()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pCat_Lotes_Expedientes_B = New DPCRS.DataSet_pACTAS_VERIFICACION_LOTES_B()
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.Menu = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.Opciones = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBNNUEVO = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNACTUALIZAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNGUARDAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNSALIR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBHabilitado = New Wisej.Web.RadioButton()
        Me.RBDesactivado = New Wisej.Web.RadioButton()
        Me.Label3 = New Wisej.Web.Label()
        Me.TXTClave = New Wisej.Web.TextBox()
        Me.Label2 = New Wisej.Web.Label()
        Me.Panel1 = New Wisej.Web.GroupBox()
        Me.CBSEstablecimiento = New Wisej.Web.ComboBox()
        Me.ErrorProvider1 = New Wisej.Web.ErrorProvider(Me.components)
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
        Me.RBNCANCELAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.FiltroGrillaSax1 = New DPCRS.filtroGrillaSax()
        CType(Me.DGVExpedientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCat_Lotes_Expedientes_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVExpedientes
        '
        Me.DGVExpedientes.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = Wisej.Web.DataGridViewTriState.[True]
        Me.DGVExpedientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVExpedientes.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVExpedientes.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.Eliminar, Me.Column0, Me.colCVE_LOTE, Me.colNUM_CONSECUTIVO, Me.DGVGCLAVE, Me.colCVE_ESTABLECIMIENTO, Me.colRAZON_SOCIAL, Me.colPROPIETARIO, Me.colCVE_MUNICIPIO, Me.colMUNICIPIO, Me.colFECHA})
        Me.DGVExpedientes.DataSource = Me.BindingSource1
        Me.DGVExpedientes.Dock = Wisej.Web.DockStyle.Fill
        Me.DGVExpedientes.Location = New System.Drawing.Point(0, 252)
        Me.DGVExpedientes.Name = "DGVExpedientes"
        Me.DGVExpedientes.RowHeadersVisible = False
        Me.DGVExpedientes.Size = New System.Drawing.Size(947, 235)
        Me.DGVExpedientes.TabIndex = 4
        '
        'Eliminar
        '
        Me.Eliminar.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        DataGridViewCellStyle2.BackgroundImageSource = "Resources/Images/Menu/30/trash.png"
        Me.Eliminar.DefaultCellStyle = DataGridViewCellStyle2
        Me.Eliminar.HeaderText = " "
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = Wisej.Web.DataGridViewTriState.[False]
        Me.Eliminar.Width = 25
        '
        'Column0
        '
        Me.Column0.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.Column0.CellImageSource = ""
        DataGridViewCellStyle3.BackgroundImageSource = "Resources/Images/Menu/30/file-4.png"
        Me.Column0.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column0.HeaderText = " "
        Me.Column0.Name = "Column0"
        Me.Column0.Width = 25
        '
        'colCVE_LOTE
        '
        Me.colCVE_LOTE.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCVE_LOTE.DataPropertyName = "CVE_LOTE"
        Me.colCVE_LOTE.HeaderText = "Cve Lote"
        Me.colCVE_LOTE.Name = "colCVE_LOTE"
        Me.colCVE_LOTE.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.colCVE_LOTE.Visible = False
        '
        'colNUM_CONSECUTIVO
        '
        Me.colNUM_CONSECUTIVO.DataPropertyName = "NUM_CONSECUTIVO"
        Me.colNUM_CONSECUTIVO.HeaderText = "Num Consecutivo"
        Me.colNUM_CONSECUTIVO.Name = "colNUM_CONSECUTIVO"
        '
        'DGVGCLAVE
        '
        Me.DGVGCLAVE.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DGVGCLAVE.DataPropertyName = "CVE_ACTA"
        Me.DGVGCLAVE.HeaderText = "Folio Acta"
        Me.DGVGCLAVE.Name = "DGVGCLAVE"
        Me.DGVGCLAVE.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'colCVE_ESTABLECIMIENTO
        '
        Me.colCVE_ESTABLECIMIENTO.DataPropertyName = "CVE_ESTABLECIMIENTO"
        Me.colCVE_ESTABLECIMIENTO.HeaderText = "CVE_ESTABLECIMIENTO"
        Me.colCVE_ESTABLECIMIENTO.Name = "colCVE_ESTABLECIMIENTO"
        Me.colCVE_ESTABLECIMIENTO.Visible = False
        '
        'colRAZON_SOCIAL
        '
        Me.colRAZON_SOCIAL.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colRAZON_SOCIAL.DataPropertyName = "RAZON_SOCIAL"
        Me.colRAZON_SOCIAL.HeaderText = "Razón Social"
        Me.colRAZON_SOCIAL.Name = "colRAZON_SOCIAL"
        Me.colRAZON_SOCIAL.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.colRAZON_SOCIAL.Width = 200
        '
        'colPROPIETARIO
        '
        Me.colPROPIETARIO.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.colPROPIETARIO.DataPropertyName = "PROPIETARIO"
        Me.colPROPIETARIO.HeaderText = "Propietario"
        Me.colPROPIETARIO.Name = "colPROPIETARIO"
        Me.colPROPIETARIO.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.colPROPIETARIO.Width = 200
        '
        'colCVE_MUNICIPIO
        '
        Me.colCVE_MUNICIPIO.DataPropertyName = "CVE_MUNICIPIO"
        Me.colCVE_MUNICIPIO.HeaderText = "CVE_MUNICIPIO"
        Me.colCVE_MUNICIPIO.Name = "colCVE_MUNICIPIO"
        Me.colCVE_MUNICIPIO.Visible = False
        '
        'colMUNICIPIO
        '
        Me.colMUNICIPIO.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.colMUNICIPIO.DataPropertyName = "MUNICIPIO"
        Me.colMUNICIPIO.HeaderText = "Municipio"
        Me.colMUNICIPIO.Name = "colMUNICIPIO"
        Me.colMUNICIPIO.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'colFECHA
        '
        Me.colFECHA.DataPropertyName = "FECHA"
        DataGridViewCellStyle4.Format = "d"
        Me.colFECHA.DefaultCellStyle = DataGridViewCellStyle4
        Me.colFECHA.Format = Wisej.Web.DateTimePickerFormat.[Short]
        Me.colFECHA.HeaderText = "Fecha Captura"
        Me.colFECHA.Name = "colFECHA"
        Me.colFECHA.ReadOnly = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "pACTAS_VERIFICACION_LOTES_B"
        Me.BindingSource1.DataSource = Me.DataSet_pCat_Lotes_Expedientes_B
        '
        'DataSet_pCat_Lotes_Expedientes_B
        '
        Me.DataSet_pCat_Lotes_Expedientes_B.DataSetName = "DataSet_pACTAS_VERIFICACION_LOTES_B"
        Me.DataSet_pCat_Lotes_Expedientes_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Dock = Wisej.Web.DockStyle.Top
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.Menu)
        Me.RibbonBar1.Size = New System.Drawing.Size(947, 145)
        '
        'Menu
        '
        Me.Menu.Groups.Add(Me.Opciones)
        Me.Menu.Text = "Menú"
        '
        'Opciones
        '
        Me.Opciones.Items.Add(Me.RBNNUEVO)
        Me.Opciones.Items.Add(Me.RBNCANCELAR)
        Me.Opciones.Items.Add(Me.RBNACTUALIZAR)
        Me.Opciones.Items.Add(Me.RBNGUARDAR)
        Me.Opciones.Items.Add(Me.RBNSALIR)
        Me.Opciones.Text = "Opciones"
        '
        'RBNNUEVO
        '
        Me.RBNNUEVO.ImageSource = "ribbon-document?color=#FF0000"
        Me.RBNNUEVO.Name = "RBNNUEVO"
        Me.RBNNUEVO.Text = "Nuevo"
        '
        'RBNACTUALIZAR
        '
        Me.RBNACTUALIZAR.ImageSource = "icon-redo?color=#006EFF"
        Me.RBNACTUALIZAR.Name = "RBNACTUALIZAR"
        Me.RBNACTUALIZAR.Text = "Actualizar"
        '
        'RBNGUARDAR
        '
        Me.RBNGUARDAR.ImageSource = "ribbon-save?color=#FF0000"
        Me.RBNGUARDAR.Name = "RBNGUARDAR"
        Me.RBNGUARDAR.Text = "Guardar"
        Me.RBNGUARDAR.Visible = False
        '
        'RBNSALIR
        '
        Me.RBNSALIR.ImageSource = "Resources\Images\Menu\30\exit-sign-red.png?color=#0000FF"
        Me.RBNSALIR.Name = "RBNSALIR"
        Me.RBNSALIR.Text = "Salir"
        '
        'RBHabilitado
        '
        Me.RBHabilitado.Checked = True
        Me.RBHabilitado.Location = New System.Drawing.Point(273, 79)
        Me.RBHabilitado.Name = "RBHabilitado"
        Me.RBHabilitado.Size = New System.Drawing.Size(85, 23)
        Me.RBHabilitado.TabIndex = 11
        Me.RBHabilitado.Text = "Habilitado"
        '
        'RBDesactivado
        '
        Me.RBDesactivado.Location = New System.Drawing.Point(379, 79)
        Me.RBDesactivado.Name = "RBDesactivado"
        Me.RBDesactivado.Size = New System.Drawing.Size(100, 23)
        Me.RBDesactivado.TabIndex = 12
        Me.RBDesactivado.TabStop = False
        Me.RBDesactivado.Text = "Desactivado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(273, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Paquetes:"
        '
        'TXTClave
        '
        Me.TXTClave.Enabled = False
        Me.TXTClave.Location = New System.Drawing.Point(80, 24)
        Me.TXTClave.Name = "TXTClave"
        Me.TXTClave.Size = New System.Drawing.Size(180, 22)
        Me.TXTClave.TabIndex = 0
        Me.TXTClave.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Folio Acta:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CBSEstablecimiento)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TXTClave)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 145)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.ShowCloseButton = True
        Me.Panel1.Size = New System.Drawing.Size(947, 67)
        Me.Panel1.TabIndex = 5
        Me.Panel1.Text = "Datos"
        Me.Panel1.Visible = False
        '
        'CBSEstablecimiento
        '
        Me.CBSEstablecimiento.BackColor = System.Drawing.Color.Transparent
        Me.CBSEstablecimiento.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSEstablecimiento.Location = New System.Drawing.Point(379, 24)
        Me.CBSEstablecimiento.Name = "CBSEstablecimiento"
        Me.CBSEstablecimiento.Size = New System.Drawing.Size(300, 22)
        Me.CBSEstablecimiento.TabIndex = 6
        ComponentTool1.ImageSource = "icon-close"
        ComponentTool1.Name = "Borrar"
        Me.CBSEstablecimiento.Tools.AddRange(New Wisej.Web.ComponentTool() {ComponentTool1})
        Me.CBSEstablecimiento.Watermark = "Ingrese Texto (Enter)..."
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
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 487)
        Me.BindingNavigator1.MoveFirstItem = Me.buttonMoveFirst
        Me.BindingNavigator1.MoveLastItem = Me.buttonMoveLast
        Me.BindingNavigator1.MoveNextItem = Me.buttonMoveNext
        Me.BindingNavigator1.MovePreviousItem = Me.buttonMovePrevious
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.textBoxPosition
        Me.BindingNavigator1.Size = New System.Drawing.Size(947, 33)
        Me.BindingNavigator1.TabIndex = 6
        '
        'buttonAddNew
        '
        Me.buttonAddNew.ImageSource = "table-row-new"
        Me.buttonAddNew.Location = New System.Drawing.Point(336, 3)
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
        Me.labelCount.Size = New System.Drawing.Size(39, 28)
        Me.labelCount.TabIndex = 7
        Me.labelCount.Text = "of {0}"
        Me.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'separatorRight
        '
        Me.separatorRight.Location = New System.Drawing.Point(210, 3)
        Me.separatorRight.Name = "separatorRight"
        Me.separatorRight.Orientation = Wisej.Web.Orientation.Vertical
        Me.separatorRight.Padding = New Wisej.Web.Padding(0, 5, 0, 5)
        Me.separatorRight.Size = New System.Drawing.Size(14, 28)
        '
        'buttonMoveNext
        '
        Me.buttonMoveNext.ImageSource = "icon-right"
        Me.buttonMoveNext.Location = New System.Drawing.Point(230, 3)
        Me.buttonMoveNext.Name = "buttonMoveNext"
        Me.buttonMoveNext.Size = New System.Drawing.Size(37, 28)
        Me.buttonMoveNext.TabIndex = 2
        '
        'buttonMoveLast
        '
        Me.buttonMoveLast.ImageSource = "icon-last"
        Me.buttonMoveLast.Location = New System.Drawing.Point(273, 3)
        Me.buttonMoveLast.Name = "buttonMoveLast"
        Me.buttonMoveLast.Size = New System.Drawing.Size(37, 28)
        Me.buttonMoveLast.TabIndex = 3
        '
        'separatorControl
        '
        Me.separatorControl.Location = New System.Drawing.Point(316, 3)
        Me.separatorControl.Name = "separatorControl"
        Me.separatorControl.Orientation = Wisej.Web.Orientation.Vertical
        Me.separatorControl.Padding = New Wisej.Web.Padding(0, 5, 0, 5)
        Me.separatorControl.Size = New System.Drawing.Size(14, 28)
        '
        'buttonDelete
        '
        Me.buttonDelete.ImageSource = "icon-close"
        Me.buttonDelete.Location = New System.Drawing.Point(379, 3)
        Me.buttonDelete.Name = "buttonDelete"
        Me.buttonDelete.Size = New System.Drawing.Size(37, 28)
        Me.buttonDelete.TabIndex = 5
        '
        'RBNCANCELAR
        '
        Me.RBNCANCELAR.ImageSource = "ribbon-delete?color=#0000FF"
        Me.RBNCANCELAR.Name = "RBNCANCELAR"
        Me.RBNCANCELAR.Text = "Cancelar"
        Me.RBNCANCELAR.Visible = False
        '
        'FiltroGrillaSax1
        '
        Me.FiltroGrillaSax1.AutoSize = True
        Me.FiltroGrillaSax1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.FiltroGrillaSax1.BackColor = System.Drawing.Color.Transparent
        Me.FiltroGrillaSax1.Dock = Wisej.Web.DockStyle.Top
        Me.FiltroGrillaSax1.Location = New System.Drawing.Point(0, 212)
        Me.FiltroGrillaSax1.meBackcolorEtiquetas = System.Drawing.Color.AliceBlue
        Me.FiltroGrillaSax1.meBorderStyleEtiquetas = Wisej.Web.BorderStyle.Solid
        Me.FiltroGrillaSax1.meBorderWidthEtiquetas = 1
        Me.FiltroGrillaSax1.meDatagrid = Nothing
        Me.FiltroGrillaSax1.meFiltrarVacios = False
        Me.FiltroGrillaSax1.meLanzarException = False
        Me.FiltroGrillaSax1.meMarginEtiquetas = New Wisej.Web.Padding(1)
        Me.FiltroGrillaSax1.mePaddingEtiquetas = New Wisej.Web.Padding(2)
        Me.FiltroGrillaSax1.Name = "FiltroGrillaSax1"
        Me.FiltroGrillaSax1.Size = New System.Drawing.Size(947, 40)
        Me.FiltroGrillaSax1.TabIndex = 3
        '
        'Cat_Lotes_Expedientes
        '
        Me.ClientSize = New System.Drawing.Size(947, 520)
        Me.Controls.Add(Me.DGVExpedientes)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.RBHabilitado)
        Me.Controls.Add(Me.FiltroGrillaSax1)
        Me.Controls.Add(Me.RBDesactivado)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Cat_Lotes_Expedientes"
        Me.Text = "Paquete de Expedientes"
        Me.WindowState = Wisej.Web.FormWindowState.Maximized
        CType(Me.DGVExpedientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCat_Lotes_Expedientes_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVExpedientes As DataGridView
    Friend WithEvents RibbonBar1 As RibbonBar
    Friend WithEvents Menu As RibbonBarPage
    Friend WithEvents Opciones As RibbonBarGroup
    Friend WithEvents RBNNUEVO As RibbonBarItemButton
    Friend WithEvents RBNSALIR As RibbonBarItemButton
    Friend WithEvents FiltroGrillaSax1 As filtroGrillaSax
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTClave As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents RBNACTUALIZAR As RibbonBarItemButton
    Friend WithEvents RBNGUARDAR As RibbonBarItemButton
    Friend WithEvents DataSet_pCat_Lotes_Expedientes_B As DataSet_pACTAS_VERIFICACION_LOTES_B
    Friend WithEvents Panel1 As GroupBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
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
    Private WithEvents Eliminar As DataGridViewImageColumn
    Private WithEvents colCVE_LOTE As DataGridViewTextBoxColumn
    Private WithEvents colNUM_CONSECUTIVO As DataGridViewTextBoxColumn
    Private WithEvents colCVE_ACTA As DataGridViewTextBoxColumn
    Private WithEvents colCVE_ESTABLECIMIENTO As DataGridViewTextBoxColumn
    Private WithEvents colRAZON_SOCIAL As DataGridViewTextBoxColumn
    Private WithEvents colPROPIETARIO As DataGridViewTextBoxColumn
    Private WithEvents colCVE_MUNICIPIO As DataGridViewTextBoxColumn
    Private WithEvents colMUNICIPIO As DataGridViewTextBoxColumn
    Friend WithEvents CBSEstablecimiento As ComboBox
    Private WithEvents DGVGCLAVE As DataGridViewTextBoxColumn
    Private WithEvents colFECHA As DataGridViewDateTimePickerColumn
    Private WithEvents Column0 As DataGridViewImageColumn
    Friend WithEvents RBNCANCELAR As RibbonBarItemButton
End Class
