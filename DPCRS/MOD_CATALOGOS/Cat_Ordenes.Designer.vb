Imports Wisej.Web.Ext.RibbonBar
Imports Wisej.Web

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cat_Ordenes
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
        Dim DataGridViewCellStyle7 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Me.DGVOrdenes = New Wisej.Web.DataGridView()
        Me.Column0 = New Wisej.Web.DataGridViewImageColumn()
        Me.Column1 = New Wisej.Web.DataGridViewImageColumn()
        Me.estatus_img = New Wisej.Web.DataGridViewImageColumn()
        Me.folio = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.archivo = New Wisej.Web.DataGridViewLinkColumn()
        Me.fecha = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colEMISION = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.estatus = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Cargo = New Wisej.Web.DataGridViewColumn()
        Me.ComboBox1 = New Wisej.Web.ComboBox()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pCAT_ORDENES_VERIFICACION_B = New DPCRS.DataSet_pCAT_ORDENES_VERIFICACION_B()
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
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.Menu_ = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.Opciones = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBNNUEVO = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNACTUALIZAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNGUARDAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNSALIR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Label3 = New Wisej.Web.Label()
        Me.TXTFolio = New Wisej.Web.TextBox()
        Me.Label2 = New Wisej.Web.Label()
        Me.Panel_NUEVO = New Wisej.Web.Panel()
        Me.CBemisor = New Wisej.Web.ComboBox()
        Me.Label4 = New Wisej.Web.Label()
        Me.Label1 = New Wisej.Web.Label()
        Me.DTPfecha = New Wisej.Web.DateTimePicker()
        Me.CBestatus = New Wisej.Web.ComboBox()
        Me.Label8 = New Wisej.Web.Label()
        Me.Button2 = New Wisej.Web.Upload()
        Me.ErrorProvider1 = New Wisej.Web.ErrorProvider(Me.components)
        Me.ImageList1 = New Wisej.Web.ImageList(Me.components)
        Me.ColorDialog1 = New Wisej.Web.ColorDialog(Me.components)
        Me.RBHabilitado = New Wisej.Web.RadioButton()
        Me.RBDesactivado = New Wisej.Web.RadioButton()
        Me.Label5 = New Wisej.Web.Label()
        Me.FiltroGrillaSax1 = New DPCRS.filtroGrillaSax()
        CType(Me.DGVOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DGVOrdenes.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCAT_ORDENES_VERIFICACION_B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.Panel_NUEVO.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVOrdenes
        '
        Me.DGVOrdenes.AutoGenerateColumns = False
        DataGridViewCellStyle7.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.WrapMode = Wisej.Web.DataGridViewTriState.[True]
        Me.DGVOrdenes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGVOrdenes.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOrdenes.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.Column0, Me.Column1, Me.estatus_img, Me.folio, Me.archivo, Me.fecha, Me.colEMISION, Me.estatus, Me.Cargo})
        Me.DGVOrdenes.Controls.Add(Me.ComboBox1)
        Me.DGVOrdenes.DataSource = Me.BindingSource1
        Me.DGVOrdenes.Dock = Wisej.Web.DockStyle.Fill
        Me.DGVOrdenes.Location = New System.Drawing.Point(0, 295)
        Me.DGVOrdenes.Name = "DGVOrdenes"
        Me.DGVOrdenes.RowHeadersVisible = False
        Me.DGVOrdenes.Size = New System.Drawing.Size(873, 233)
        Me.DGVOrdenes.TabIndex = 4
        '
        'Column0
        '
        Me.Column0.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.Column0.CellImageSource = ""
        Me.Column0.DataPropertyName = "sDelete"
        DataGridViewCellStyle8.BackgroundImageSource = "Resources/Images/Menu/30/trash.png"
        Me.Column0.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column0.HeaderText = " "
        Me.Column0.Name = "Column0"
        Me.Column0.Width = 25
        '
        'Column1
        '
        Me.Column1.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.Column1.CellImageSource = ""
        Me.Column1.DataPropertyName = "sEdit"
        DataGridViewCellStyle9.BackgroundImageSource = "Resources/Images/Menu/30/046-pencil.png"
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column1.HeaderText = " "
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 25
        '
        'estatus_img
        '
        Me.estatus_img.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.estatus_img.CellImageLayout = Wisej.Web.DataGridViewImageCellLayout.Stretch
        Me.estatus_img.HeaderText = " "
        Me.estatus_img.Name = "estatus_img"
        Me.estatus_img.Width = 35
        '
        'folio
        '
        Me.folio.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.folio.DataPropertyName = "FOLIO_ORDEN"
        Me.folio.HeaderText = "Folio"
        Me.folio.Name = "folio"
        Me.folio.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.folio.Width = 140
        '
        'archivo
        '
        Me.archivo.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.archivo.DataPropertyName = "URL_ARCHIVO"
        Me.archivo.HeaderText = "Archivo Escaneado"
        Me.archivo.Name = "archivo"
        Me.archivo.Text = ""
        Me.archivo.Width = 140
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "FECHA"
        Me.fecha.HeaderText = "Fecha emisión"
        Me.fecha.Name = "fecha"
        Me.fecha.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'colEMISION
        '
        Me.colEMISION.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.colEMISION.DataPropertyName = "EMISION"
        Me.colEMISION.HeaderText = "Expedida por"
        Me.colEMISION.Name = "colEMISION"
        Me.colEMISION.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'estatus
        '
        Me.estatus.DataPropertyName = "ESTATUS"
        Me.estatus.HeaderText = "Estatus"
        Me.estatus.Name = "estatus"
        Me.estatus.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'Cargo
        '
        Me.Cargo.DataPropertyName = "EMISION_CARGO"
        Me.Cargo.HeaderText = "Cargo"
        Me.Cargo.Name = "Cargo"
        '
        'ComboBox1
        '
        Me.ComboBox1.Dock = Wisej.Web.DockStyle.Top
        Me.ComboBox1.Location = New System.Drawing.Point(0, 0)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(871, 22)
        Me.ComboBox1.TabIndex = 0
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "pCAT_ORDENES_VERIFICACION_B"
        Me.BindingSource1.DataSource = Me.DataSet_pCAT_ORDENES_VERIFICACION_B
        '
        'DataSet_pCAT_ORDENES_VERIFICACION_B
        '
        Me.DataSet_pCAT_ORDENES_VERIFICACION_B.DataSetName = "DataSet_pCAT_ORDENES_VERIFICACION_B"
        Me.DataSet_pCAT_ORDENES_VERIFICACION_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 528)
        Me.BindingNavigator1.MoveFirstItem = Me.buttonMoveFirst
        Me.BindingNavigator1.MoveLastItem = Me.buttonMoveLast
        Me.BindingNavigator1.MoveNextItem = Me.buttonMoveNext
        Me.BindingNavigator1.MovePreviousItem = Me.buttonMovePrevious
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.textBoxPosition
        Me.BindingNavigator1.Size = New System.Drawing.Size(873, 28)
        Me.BindingNavigator1.TabIndex = 1
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
        'RibbonBar1
        '
        Me.RibbonBar1.Dock = Wisej.Web.DockStyle.Top
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.Menu_)
        Me.RibbonBar1.Size = New System.Drawing.Size(873, 145)
        '
        'Menu_
        '
        Me.Menu_.Groups.Add(Me.Opciones)
        Me.Menu_.Text = "Menú"
        '
        'Opciones
        '
        Me.Opciones.Items.Add(Me.RBNNUEVO)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Estatus:"
        '
        'TXTFolio
        '
        Me.TXTFolio.Location = New System.Drawing.Point(219, 5)
        Me.TXTFolio.Name = "TXTFolio"
        Me.TXTFolio.Size = New System.Drawing.Size(180, 22)
        Me.TXTFolio.TabIndex = 0
        Me.TXTFolio.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Folio Orden:"
        '
        'Panel_NUEVO
        '
        Me.Panel_NUEVO.AutoScroll = True
        Me.Panel_NUEVO.Controls.Add(Me.CBemisor)
        Me.Panel_NUEVO.Controls.Add(Me.Label4)
        Me.Panel_NUEVO.Controls.Add(Me.Label1)
        Me.Panel_NUEVO.Controls.Add(Me.DTPfecha)
        Me.Panel_NUEVO.Controls.Add(Me.CBestatus)
        Me.Panel_NUEVO.Controls.Add(Me.Label8)
        Me.Panel_NUEVO.Controls.Add(Me.Button2)
        Me.Panel_NUEVO.Controls.Add(Me.Label3)
        Me.Panel_NUEVO.Controls.Add(Me.Label2)
        Me.Panel_NUEVO.Controls.Add(Me.TXTFolio)
        Me.Panel_NUEVO.Dock = Wisej.Web.DockStyle.Top
        Me.Panel_NUEVO.Location = New System.Drawing.Point(0, 145)
        Me.Panel_NUEVO.Name = "Panel_NUEVO"
        Me.Panel_NUEVO.Size = New System.Drawing.Size(873, 110)
        Me.Panel_NUEVO.TabIndex = 5
        Me.Panel_NUEVO.Visible = False
        '
        'CBemisor
        '
        Me.CBemisor.Location = New System.Drawing.Point(641, 4)
        Me.CBemisor.Name = "CBemisor"
        Me.CBemisor.Size = New System.Drawing.Size(120, 22)
        Me.CBemisor.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(499, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "emisor de orden:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(499, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Fecha de emision:"
        '
        'DTPfecha
        '
        Me.DTPfecha.Location = New System.Drawing.Point(641, 73)
        Me.DTPfecha.Name = "DTPfecha"
        Me.DTPfecha.Size = New System.Drawing.Size(200, 22)
        Me.DTPfecha.TabIndex = 21
        Me.DTPfecha.Value = New Date(2019, 4, 23, 12, 36, 2, 403)
        '
        'CBestatus
        '
        Me.CBestatus.Items.AddRange(New Object() {"CAPTURADO", "PENDIENTE", "ELIMINADO", "NOTHING"})
        Me.CBestatus.Location = New System.Drawing.Point(219, 75)
        Me.CBestatus.Name = "CBestatus"
        Me.CBestatus.Size = New System.Drawing.Size(222, 22)
        Me.CBestatus.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(89, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Archivo Escaneado:"
        '
        'Button2
        '
        Me.Button2.AllowedFileTypes = ".pdf"
        Me.Button2.Location = New System.Drawing.Point(219, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(237, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Seleccionar archivo"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 3
        Me.ErrorProvider1.ContainerControl = Me
        '
        'RBHabilitado
        '
        Me.RBHabilitado.Checked = True
        Me.RBHabilitado.ForeColor = System.Drawing.Color.FromName("@table-row-background-focused-selected")
        Me.RBHabilitado.Location = New System.Drawing.Point(307, 77)
        Me.RBHabilitado.Name = "RBHabilitado"
        Me.RBHabilitado.Size = New System.Drawing.Size(281, 23)
        Me.RBHabilitado.TabIndex = 11
        Me.RBHabilitado.Text = "CAPTURADOS, PENDIENTES, NOTHING"
        '
        'RBDesactivado
        '
        Me.RBDesactivado.ForeColor = System.Drawing.Color.DarkOrange
        Me.RBDesactivado.Location = New System.Drawing.Point(605, 77)
        Me.RBDesactivado.Name = "RBDesactivado"
        Me.RBDesactivado.Size = New System.Drawing.Size(108, 23)
        Me.RBDesactivado.TabIndex = 12
        Me.RBDesactivado.TabStop = False
        Me.RBDesactivado.Text = "ELIMINADOS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(483, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "VER ACTAS "
        '
        'FiltroGrillaSax1
        '
        Me.FiltroGrillaSax1.AutoSize = True
        Me.FiltroGrillaSax1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.FiltroGrillaSax1.BackColor = System.Drawing.Color.Transparent
        Me.FiltroGrillaSax1.Dock = Wisej.Web.DockStyle.Top
        Me.FiltroGrillaSax1.Location = New System.Drawing.Point(0, 255)
        Me.FiltroGrillaSax1.meBackcolorEtiquetas = System.Drawing.Color.AliceBlue
        Me.FiltroGrillaSax1.meBorderStyleEtiquetas = Wisej.Web.BorderStyle.Solid
        Me.FiltroGrillaSax1.meBorderWidthEtiquetas = 1
        Me.FiltroGrillaSax1.meDatagrid = Nothing
        Me.FiltroGrillaSax1.meFiltrarVacios = False
        Me.FiltroGrillaSax1.meLanzarException = False
        Me.FiltroGrillaSax1.meMarginEtiquetas = New Wisej.Web.Padding(1)
        Me.FiltroGrillaSax1.mePaddingEtiquetas = New Wisej.Web.Padding(2)
        Me.FiltroGrillaSax1.Name = "FiltroGrillaSax1"
        Me.FiltroGrillaSax1.Size = New System.Drawing.Size(873, 40)
        Me.FiltroGrillaSax1.TabIndex = 3
        '
        'Cat_Ordenes
        '
        Me.ClientSize = New System.Drawing.Size(873, 556)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DGVOrdenes)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.RBDesactivado)
        Me.Controls.Add(Me.RBHabilitado)
        Me.Controls.Add(Me.FiltroGrillaSax1)
        Me.Controls.Add(Me.Panel_NUEVO)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Cat_Ordenes"
        Me.Text = "Ordenes de Verificación Sanitaria"
        Me.WindowState = Wisej.Web.FormWindowState.Maximized
        CType(Me.DGVOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DGVOrdenes.ResumeLayout(False)
        Me.DGVOrdenes.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCAT_ORDENES_VERIFICACION_B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.Panel_NUEVO.ResumeLayout(False)
        Me.Panel_NUEVO.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVOrdenes As DataGridView
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents buttonAddNew As Wisej.Web.Button
    Friend WithEvents buttonMoveFirst As Wisej.Web.Button
    Friend WithEvents buttonMovePrevious As Wisej.Web.Button
    Friend WithEvents separatorLeft As Wisej.Web.Line
    Friend WithEvents textBoxPosition As Wisej.Web.TextBox
    Friend WithEvents labelCount As Wisej.Web.Label
    Friend WithEvents separatorRight As Wisej.Web.Line
    Friend WithEvents buttonMoveNext As Wisej.Web.Button
    Friend WithEvents buttonMoveLast As Wisej.Web.Button
    Friend WithEvents separatorControl As Wisej.Web.Line
    Friend WithEvents buttonDelete As Wisej.Web.Button
    Friend WithEvents RibbonBar1 As RibbonBar
    Friend WithEvents Menu_ As RibbonBarPage
    Friend WithEvents Opciones As RibbonBarGroup
    Friend WithEvents RBNNUEVO As RibbonBarItemButton
    Friend WithEvents RBNSALIR As RibbonBarItemButton
    Friend WithEvents FiltroGrillaSax1 As filtroGrillaSax
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTFolio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents RBNACTUALIZAR As RibbonBarItemButton
    Friend WithEvents RBNGUARDAR As RibbonBarItemButton
    Friend WithEvents Panel_NUEVO As Panel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents RBDesactivado As RadioButton
    Friend WithEvents RBHabilitado As RadioButton
    Friend WithEvents DataSet_pCAT_ORDENES_VERIFICACION_B As DataSet_pCAT_ORDENES_VERIFICACION_B
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Upload
    Private WithEvents folio As DataGridViewTextBoxColumn
    Private WithEvents archivo As DataGridViewLinkColumn
    Private WithEvents fecha As DataGridViewTextBoxColumn
    Private WithEvents estatus As DataGridViewTextBoxColumn
    Private WithEvents estatus_img As DataGridViewImageColumn
    Private WithEvents colEMISION As DataGridViewTextBoxColumn
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Column0 As DataGridViewImageColumn
    Friend WithEvents CBestatus As ComboBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents CBemisor As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DTPfecha As DateTimePicker
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents Cargo As DataGridViewColumn
    Friend WithEvents Label5 As Label
End Class
