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
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBNNUEVO = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNACTUALIZAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNSALIR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
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
        Me.DataGridView1 = New Wisej.Web.DataGridView()
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
        Me.DataGridView2 = New Wisej.Web.DataGridView()
        Me.editar = New Wisej.Web.DataGridViewImageColumn()
        Me.borrar = New Wisej.Web.DataGridViewImageColumn()
        Me.colRAZON_SOCIAL = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colESTADO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colJURISDICCION = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colCODIGO_POSTAL = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colDOMICILIO_DETALLE = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colGIRO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colSCIAN = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colHABILITADO = New Wisej.Web.DataGridViewCheckBoxColumn()
        Me.colFECHA_ALTA = New Wisej.Web.DataGridViewDateTimePickerColumn()
        Me.colFECHA_MODIFCADO = New Wisej.Web.DataGridViewDateTimePickerColumn()
        Me.colNOMBRE_PROPIETARIO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colRFC = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colIDENTIFICACION = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colCOLONIA = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colDOMICILIO_PROPIETARIO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colCVE_ESTABLECIMIENTO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colNOM_JURIS_CON = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataSetESTABLECIMIENTOSBindingSource = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_ESTABLECIMIENTOS = New DPCRS.DataSet_ESTABLECIMIENTOS()
        Me.FiltroGrillaSax1 = New DPCRS.filtroGrillaSax()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetESTABLECIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_ESTABLECIMIENTOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Dock = Wisej.Web.DockStyle.Top
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(633, 115)
        Me.ToolTip1.SetToolTip(Me.RibbonBar1, Nothing)
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
        'RBNSALIR
        '
        Me.RBNSALIR.ImageSource = "Resources\Images\Menu\30\exit-sign-red.png?color=#0000FF"
        Me.RBNSALIR.Name = "RBNSALIR"
        Me.RBNSALIR.Text = "Salir"
        '
        'Giro
        '
        Me.Giro.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.Giro.DataPropertyName = "GIROX"
        Me.Giro.HeaderText = "Giro"
        Me.Giro.Name = "Giro"
        Me.Giro.ReadOnly = True
        Me.Giro.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'SCIAN
        '
        Me.SCIAN.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.SCIAN.DataPropertyName = "CVE_SCIAN"
        Me.SCIAN.HeaderText = "Clave SCIAN"
        Me.SCIAN.Name = "SCIAN"
        Me.SCIAN.ReadOnly = True
        Me.SCIAN.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'Municipio
        '
        Me.Municipio.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.Municipio.DataPropertyName = "MUNICIPIOX"
        Me.Municipio.Name = "Municipio"
        Me.Municipio.ReadOnly = True
        Me.Municipio.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'Propietario
        '
        Me.Propietario.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.Propietario.DataPropertyName = "NOM_PROPIETARIO"
        Me.Propietario.Name = "Propietario"
        Me.Propietario.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'Razon_Social
        '
        Me.Razon_Social.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.Razon_Social.DataPropertyName = "RAZON_SOCIAL"
        Me.Razon_Social.HeaderText = "Razon Social"
        Me.Razon_Social.Name = "Razon_Social"
        Me.Razon_Social.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'RFC
        '
        Me.RFC.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.RFC.DataPropertyName = "RFC"
        Me.RFC.Name = "RFC"
        Me.RFC.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'Domicilio
        '
        Me.Domicilio.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.Domicilio.DataPropertyName = "DOMICILIO"
        Me.Domicilio.Name = "Domicilio"
        Me.Domicilio.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'Colonia
        '
        Me.Colonia.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.Colonia.DataPropertyName = "COLONIA"
        Me.Colonia.Name = "Colonia"
        Me.Colonia.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'codigo
        '
        Me.codigo.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.codigo.DataPropertyName = "CODIGO_POSTAL"
        Me.codigo.HeaderText = "Codigo Postal"
        Me.codigo.Name = "codigo"
        Me.codigo.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'horario
        '
        Me.horario.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.horario.DataPropertyName = "HORARIO_LABORES"
        Me.horario.HeaderText = "Horario labores"
        Me.horario.Name = "horario"
        Me.horario.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'volumen
        '
        Me.volumen.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.volumen.DataPropertyName = "VOLUMEN_PRODUCCION"
        Me.volumen.HeaderText = "Volumen producción"
        Me.volumen.Name = "volumen"
        Me.volumen.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "HABILITADO"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Habilitado"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 3
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.buttonAddNew
        Me.BindingNavigator1.Controls.Add(Me.DataGridView1)
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
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 505)
        Me.BindingNavigator1.MoveFirstItem = Me.buttonMoveFirst
        Me.BindingNavigator1.MoveLastItem = Me.buttonMoveLast
        Me.BindingNavigator1.MoveNextItem = Me.buttonMoveNext
        Me.BindingNavigator1.MovePreviousItem = Me.buttonMovePrevious
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.textBoxPosition
        Me.BindingNavigator1.Size = New System.Drawing.Size(633, 33)
        Me.BindingNavigator1.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.BindingNavigator1, Nothing)
        '
        'buttonAddNew
        '
        Me.buttonAddNew.ImageSource = "table-row-new"
        Me.buttonAddNew.Location = New System.Drawing.Point(572, 3)
        Me.buttonAddNew.Name = "buttonAddNew"
        Me.buttonAddNew.Size = New System.Drawing.Size(37, 28)
        Me.buttonAddNew.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.buttonAddNew, Nothing)
        '
        'DataGridView1
        '
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(200, 100)
        Me.DataGridView1.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.DataGridView1, Nothing)
        '
        'buttonMoveFirst
        '
        Me.buttonMoveFirst.ImageSource = "icon-first"
        Me.buttonMoveFirst.Location = New System.Drawing.Point(209, 3)
        Me.buttonMoveFirst.Name = "buttonMoveFirst"
        Me.buttonMoveFirst.Size = New System.Drawing.Size(37, 28)
        Me.buttonMoveFirst.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.buttonMoveFirst, Nothing)
        '
        'buttonMovePrevious
        '
        Me.buttonMovePrevious.ImageSource = "icon-left"
        Me.buttonMovePrevious.Location = New System.Drawing.Point(252, 3)
        Me.buttonMovePrevious.Name = "buttonMovePrevious"
        Me.buttonMovePrevious.Size = New System.Drawing.Size(37, 28)
        Me.buttonMovePrevious.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.buttonMovePrevious, Nothing)
        '
        'separatorLeft
        '
        Me.separatorLeft.Location = New System.Drawing.Point(295, 3)
        Me.separatorLeft.Name = "separatorLeft"
        Me.separatorLeft.Orientation = Wisej.Web.Orientation.Vertical
        Me.separatorLeft.Padding = New Wisej.Web.Padding(0, 5, 0, 5)
        Me.separatorLeft.Size = New System.Drawing.Size(14, 28)
        Me.ToolTip1.SetToolTip(Me.separatorLeft, Nothing)
        '
        'textBoxPosition
        '
        Me.textBoxPosition.AutoSize = False
        Me.textBoxPosition.Location = New System.Drawing.Point(315, 3)
        Me.textBoxPosition.Name = "textBoxPosition"
        Me.textBoxPosition.Size = New System.Drawing.Size(50, 28)
        Me.textBoxPosition.TabIndex = 6
        Me.textBoxPosition.Text = "0"
        Me.ToolTip1.SetToolTip(Me.textBoxPosition, Nothing)
        '
        'labelCount
        '
        Me.labelCount.Location = New System.Drawing.Point(371, 3)
        Me.labelCount.Name = "labelCount"
        Me.labelCount.Size = New System.Drawing.Size(69, 28)
        Me.labelCount.TabIndex = 7
        Me.labelCount.Text = "of {0}"
        Me.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.labelCount, Nothing)
        '
        'separatorRight
        '
        Me.separatorRight.Location = New System.Drawing.Point(446, 3)
        Me.separatorRight.Name = "separatorRight"
        Me.separatorRight.Orientation = Wisej.Web.Orientation.Vertical
        Me.separatorRight.Padding = New Wisej.Web.Padding(0, 5, 0, 5)
        Me.separatorRight.Size = New System.Drawing.Size(14, 28)
        Me.ToolTip1.SetToolTip(Me.separatorRight, Nothing)
        '
        'buttonMoveNext
        '
        Me.buttonMoveNext.ImageSource = "icon-right"
        Me.buttonMoveNext.Location = New System.Drawing.Point(466, 3)
        Me.buttonMoveNext.Name = "buttonMoveNext"
        Me.buttonMoveNext.Size = New System.Drawing.Size(37, 28)
        Me.buttonMoveNext.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.buttonMoveNext, Nothing)
        '
        'buttonMoveLast
        '
        Me.buttonMoveLast.ImageSource = "icon-last"
        Me.buttonMoveLast.Location = New System.Drawing.Point(509, 3)
        Me.buttonMoveLast.Name = "buttonMoveLast"
        Me.buttonMoveLast.Size = New System.Drawing.Size(37, 28)
        Me.buttonMoveLast.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.buttonMoveLast, Nothing)
        '
        'separatorControl
        '
        Me.separatorControl.Location = New System.Drawing.Point(552, 3)
        Me.separatorControl.Name = "separatorControl"
        Me.separatorControl.Orientation = Wisej.Web.Orientation.Vertical
        Me.separatorControl.Padding = New Wisej.Web.Padding(0, 5, 0, 5)
        Me.separatorControl.Size = New System.Drawing.Size(14, 28)
        Me.ToolTip1.SetToolTip(Me.separatorControl, Nothing)
        '
        'buttonDelete
        '
        Me.buttonDelete.ImageSource = "icon-close"
        Me.buttonDelete.Location = New System.Drawing.Point(3, 109)
        Me.buttonDelete.Name = "buttonDelete"
        Me.buttonDelete.Size = New System.Drawing.Size(37, 28)
        Me.buttonDelete.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.buttonDelete, Nothing)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RBDesactivado)
        Me.Panel2.Controls.Add(Me.RBHabilitado)
        Me.Panel2.Location = New System.Drawing.Point(209, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(212, 32)
        Me.Panel2.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.Panel2, Nothing)
        '
        'RBDesactivado
        '
        Me.RBDesactivado.Location = New System.Drawing.Point(100, 4)
        Me.RBDesactivado.Name = "RBDesactivado"
        Me.RBDesactivado.Size = New System.Drawing.Size(100, 23)
        Me.RBDesactivado.TabIndex = 12
        Me.RBDesactivado.TabStop = False
        Me.RBDesactivado.Text = "Desactivado"
        Me.ToolTip1.SetToolTip(Me.RBDesactivado, Nothing)
        '
        'RBHabilitado
        '
        Me.RBHabilitado.Checked = True
        Me.RBHabilitado.Location = New System.Drawing.Point(9, 4)
        Me.RBHabilitado.Name = "RBHabilitado"
        Me.RBHabilitado.Size = New System.Drawing.Size(85, 23)
        Me.RBHabilitado.TabIndex = 11
        Me.RBHabilitado.Text = "Habilitado"
        Me.ToolTip1.SetToolTip(Me.RBHabilitado, Nothing)
        '
        'DataGridView2
        '
        Me.DataGridView2.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.editar, Me.borrar, Me.colRAZON_SOCIAL, Me.colESTADO, Me.colJURISDICCION, Me.colCODIGO_POSTAL, Me.colDOMICILIO_DETALLE, Me.colGIRO, Me.colSCIAN, Me.colHABILITADO, Me.colFECHA_ALTA, Me.colFECHA_MODIFCADO, Me.colNOMBRE_PROPIETARIO, Me.colRFC, Me.colIDENTIFICACION, Me.colCOLONIA, Me.colDOMICILIO_PROPIETARIO, Me.colCVE_ESTABLECIMIENTO, Me.colNOM_JURIS_CON})
        Me.DataGridView2.DataMember = "pCAT_ESTABLECIMIENTOS_B"
        Me.DataGridView2.DataSource = Me.DataSetESTABLECIMIENTOSBindingSource
        Me.DataGridView2.Dock = Wisej.Web.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 155)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(633, 350)
        Me.DataGridView2.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.DataGridView2, Nothing)
        '
        'editar
        '
        'Me.editar.CellImage = Global.DPCRS.My.Resources.Resources.pencil_
        Me.editar.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.editar.Name = "editar"
        Me.editar.Width = 40
        '
        'borrar
        '
        'Me.borrar.CellImage = Global.DPCRS.My.Resources.Resources.trash_
        Me.borrar.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.borrar.Name = "borrar"
        Me.borrar.Width = 40
        '
        'colRAZON_SOCIAL
        '
        Me.colRAZON_SOCIAL.DataPropertyName = "RAZON_SOCIAL"
        Me.colRAZON_SOCIAL.HeaderText = "RAZON_SOCIAL"
        Me.colRAZON_SOCIAL.Name = "colRAZON_SOCIAL"
        '
        'colESTADO
        '
        Me.colESTADO.DataPropertyName = "ESTADO"
        Me.colESTADO.HeaderText = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        '
        'colJURISDICCION
        '
        Me.colJURISDICCION.DataPropertyName = "JURISDICCION"
        Me.colJURISDICCION.HeaderText = "JURISDICCION"
        Me.colJURISDICCION.Name = "colJURISDICCION"
        '
        'colCODIGO_POSTAL
        '
        Me.colCODIGO_POSTAL.DataPropertyName = "CODIGO_POSTAL"
        Me.colCODIGO_POSTAL.HeaderText = "CODIGO POSTAL"
        Me.colCODIGO_POSTAL.Name = "colCODIGO_POSTAL"
        '
        'colDOMICILIO_DETALLE
        '
        Me.colDOMICILIO_DETALLE.DataPropertyName = "DOMICILIO"
        Me.colDOMICILIO_DETALLE.HeaderText = "DOMICILIO DEL  ESTABLECIMIENTO"
        Me.colDOMICILIO_DETALLE.Name = "colDOMICILIO_DETALLE"
        '
        'colGIRO
        '
        Me.colGIRO.DataPropertyName = "GIRO"
        Me.colGIRO.HeaderText = "GIRO"
        Me.colGIRO.Name = "colGIRO"
        '
        'colSCIAN
        '
        Me.colSCIAN.DataPropertyName = "SCIAN"
        Me.colSCIAN.HeaderText = "SCIAN"
        Me.colSCIAN.Name = "colSCIAN"
        '
        'colHABILITADO
        '
        Me.colHABILITADO.DataPropertyName = "HABILITADO"
        Me.colHABILITADO.HeaderText = "HABILITADO"
        Me.colHABILITADO.Name = "colHABILITADO"
        '
        'colFECHA_ALTA
        '
        Me.colFECHA_ALTA.DataPropertyName = "FECHA_ALTA"
        Me.colFECHA_ALTA.HeaderText = "FECHA_ALTA"
        Me.colFECHA_ALTA.Name = "colFECHA_ALTA"
        '
        'colFECHA_MODIFCADO
        '
        Me.colFECHA_MODIFCADO.DataPropertyName = "FECHA_MODIFCADO"
        Me.colFECHA_MODIFCADO.HeaderText = "FECHA_MODIFCADO"
        Me.colFECHA_MODIFCADO.Name = "colFECHA_MODIFCADO"
        '
        'colNOMBRE_PROPIETARIO
        '
        Me.colNOMBRE_PROPIETARIO.DataPropertyName = "NOMBRE_PROPIETARIO"
        Me.colNOMBRE_PROPIETARIO.HeaderText = "NOMBRE DEL PROPIETARIO"
        Me.colNOMBRE_PROPIETARIO.Name = "colNOMBRE_PROPIETARIO"
        '
        'colRFC
        '
        Me.colRFC.DataPropertyName = "RFC"
        Me.colRFC.HeaderText = "RFC"
        Me.colRFC.Name = "colRFC"
        '
        'colIDENTIFICACION
        '
        Me.colIDENTIFICACION.DataPropertyName = "IDENTIFICACION"
        Me.colIDENTIFICACION.HeaderText = "IDENTIFICACION"
        Me.colIDENTIFICACION.Name = "colIDENTIFICACION"
        '
        'colCOLONIA
        '
        Me.colCOLONIA.DataPropertyName = "COLONIA"
        Me.colCOLONIA.HeaderText = "COLONIA"
        Me.colCOLONIA.Name = "colCOLONIA"
        '
        'colDOMICILIO_PROPIETARIO
        '
        Me.colDOMICILIO_PROPIETARIO.DataPropertyName = "DOMICILIO_PROPIETARIO"
        Me.colDOMICILIO_PROPIETARIO.HeaderText = "DOMICILIO DEL PROPIETARIO"
        Me.colDOMICILIO_PROPIETARIO.Name = "colDOMICILIO_PROPIETARIO"
        '
        'colCVE_ESTABLECIMIENTO
        '
        Me.colCVE_ESTABLECIMIENTO.DataPropertyName = "CVE_ESTABLECIMIENTO"
        Me.colCVE_ESTABLECIMIENTO.HeaderText = "CVE_ESTABLECIMIENTO"
        Me.colCVE_ESTABLECIMIENTO.Name = "colCVE_ESTABLECIMIENTO"
        Me.colCVE_ESTABLECIMIENTO.ReadOnly = True
        '
        'colNOM_JURIS_CON
        '
        Me.colNOM_JURIS_CON.DataPropertyName = "NOM_JURIS_CON"
        Me.colNOM_JURIS_CON.HeaderText = "NOM_JURIS_CON"
        Me.colNOM_JURIS_CON.Name = "colNOM_JURIS_CON"
        '
        'DataSetESTABLECIMIENTOSBindingSource
        '
        Me.DataSetESTABLECIMIENTOSBindingSource.DataSource = Me.DataSet_ESTABLECIMIENTOS
        Me.DataSetESTABLECIMIENTOSBindingSource.Position = 0
        '
        'DataSet_ESTABLECIMIENTOS
        '
        Me.DataSet_ESTABLECIMIENTOS.DataSetName = "DataSet_ESTABLECIMIENTOS"
        Me.DataSet_ESTABLECIMIENTOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FiltroGrillaSax1
        '
        Me.FiltroGrillaSax1.AutoSize = True
        Me.FiltroGrillaSax1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.FiltroGrillaSax1.BackColor = System.Drawing.Color.Transparent
        Me.FiltroGrillaSax1.Dock = Wisej.Web.DockStyle.Top
        Me.FiltroGrillaSax1.Location = New System.Drawing.Point(0, 115)
        Me.FiltroGrillaSax1.meBackcolorEtiquetas = System.Drawing.Color.AliceBlue
        Me.FiltroGrillaSax1.meBorderStyleEtiquetas = Wisej.Web.BorderStyle.Solid
        Me.FiltroGrillaSax1.meBorderWidthEtiquetas = 1
        Me.FiltroGrillaSax1.meDatagrid = Nothing
        Me.FiltroGrillaSax1.meFiltrarVacios = False
        Me.FiltroGrillaSax1.meLanzarException = False
        Me.FiltroGrillaSax1.meMarginEtiquetas = New Wisej.Web.Padding(1)
        Me.FiltroGrillaSax1.mePaddingEtiquetas = New Wisej.Web.Padding(2)
        Me.FiltroGrillaSax1.Name = "FiltroGrillaSax1"
        Me.FiltroGrillaSax1.Size = New System.Drawing.Size(633, 40)
        Me.FiltroGrillaSax1.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.FiltroGrillaSax1, Nothing)
        '
        'Cat_Establecimientos
        '
        Me.ClientSize = New System.Drawing.Size(633, 538)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FiltroGrillaSax1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Cat_Establecimientos"
        Me.Text = "Establecimientos"
        Me.ToolTip1.SetToolTip(Me, Nothing)
        Me.WindowState = Wisej.Web.FormWindowState.Maximized
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetESTABLECIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_ESTABLECIMIENTOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonBar1 As RibbonBar
    Friend WithEvents RibbonBarPage1 As RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As RibbonBarGroup
    Friend WithEvents RBNNUEVO As RibbonBarItemButton
    Friend WithEvents RBNSALIR As RibbonBarItemButton
    Friend WithEvents FiltroGrillaSax1 As filtroGrillaSax
    Friend WithEvents RBNACTUALIZAR As RibbonBarItemButton
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
    Private WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Private WithEvents Colonia As DataGridViewTextBoxColumn
    Private WithEvents codigo As DataGridViewTextBoxColumn
    Private WithEvents horario As DataGridViewTextBoxColumn
    Private WithEvents volumen As DataGridViewTextBoxColumn
    Private WithEvents DGVcve_establecimiento As DataGridViewTextBoxColumn
    Private WithEvents colPROPIETARIO_CARGO As DataGridViewTextBoxColumn
    Private WithEvents colPROPIETARIO_DOMICILIO As DataGridViewTextBoxColumn
    Private WithEvents colPROPIETARIO_IDENTIFICACION As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Private WithEvents colHORARIO_LABORES As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents colRAZON_SOCIAL As DataGridViewTextBoxColumn
    Friend WithEvents colFECHA_ALTA As DataGridViewDateTimePickerColumn
    Friend WithEvents colFECHA_MODIFCADO As DataGridViewDateTimePickerColumn
    Friend WithEvents colESTADO As DataGridViewTextBoxColumn
    Friend WithEvents colJURISDICCION As DataGridViewTextBoxColumn
    Friend WithEvents colDOMICILIO_DETALLE As DataGridViewTextBoxColumn
    Friend WithEvents colNOMBRE_PROPIETARIO As DataGridViewTextBoxColumn
    Friend WithEvents colCODIGO_POSTAL As DataGridViewTextBoxColumn
    Friend WithEvents colCOLONIA As DataGridViewTextBoxColumn
    Friend WithEvents colIDENTIFICACION As DataGridViewTextBoxColumn
    Friend WithEvents colDOMICILIO_PROPIETARIO As DataGridViewTextBoxColumn
    Friend WithEvents colRFC As DataGridViewTextBoxColumn
    Friend WithEvents colGIRO As DataGridViewTextBoxColumn
    Friend WithEvents colSCIAN As DataGridViewTextBoxColumn
    Friend WithEvents colHABILITADO As DataGridViewCheckBoxColumn
    Friend WithEvents DataSetESTABLECIMIENTOSBindingSource As BindingSource
    Friend WithEvents DataSet_ESTABLECIMIENTOS As DataSet_ESTABLECIMIENTOS
    Friend WithEvents editar As DataGridViewImageColumn
    Friend WithEvents colCVE_ESTABLECIMIENTO As DataGridViewTextBoxColumn
    Friend WithEvents borrar As DataGridViewImageColumn
    Friend WithEvents colNOM_JURIS_CON As DataGridViewTextBoxColumn
End Class
