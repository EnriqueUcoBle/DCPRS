Imports Wisej.Web.Ext.RibbonBar
Imports Wisej.Web

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cat_Actas_Verificacion
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
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBN_Nuevo = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBN_Actualizar = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBN_Salir = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.DGV_Orden = New Wisej.Web.DataGridView()
        Me.Editar = New Wisej.Web.DataGridViewImageColumn()
        Me.Folio = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.cFechaVerificacion = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pCAT_ACTAS_VERIFICACION_B = New DPCRS.DataSet_pCAT_ACTAS_VERIFICACION_B()
        Me.folio_orden = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.folio_acta = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.nom_propietario = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.razon_social = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.fecha_captura = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.fecha_ingreso = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.fecha_verificacion = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.programa = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.fecha_reporte_lsp = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.estatus = New Wisej.Web.DataGridViewTextBoxColumn()
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
        Me.FiltroGrillaSax1 = New DPCRS.filtroGrillaSax()
        CType(Me.DGV_Orden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCAT_ACTAS_VERIFICACION_B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Dock = Wisej.Web.DockStyle.Top
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(982, 109)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Text = "Menú"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.RBN_Nuevo)
        Me.RibbonBarGroup1.Items.Add(Me.RBN_Actualizar)
        Me.RibbonBarGroup1.Items.Add(Me.RBN_Salir)
        Me.RibbonBarGroup1.Text = "Opciones"
        '
        'RBN_Nuevo
        '
        Me.RBN_Nuevo.ImageSource = "ribbon-document?color=#FF0000"
        Me.RBN_Nuevo.Name = "RBN_Nuevo"
        Me.RBN_Nuevo.Text = "Nuevo"
        '
        'RBN_Actualizar
        '
        Me.RBN_Actualizar.ImageSource = "icon-redo?color=#006EFF"
        Me.RBN_Actualizar.Name = "RBN_Actualizar"
        Me.RBN_Actualizar.Text = "Actualizar"
        '
        'RBN_Salir
        '
        Me.RBN_Salir.ImageSource = "Resources\Images\Menu\30\exit-sign-red.png?color=#0000FF"
        Me.RBN_Salir.Name = "RBN_Salir"
        Me.RBN_Salir.Text = "Salir"
        '
        'DGV_Orden
        '
        Me.DGV_Orden.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = Wisej.Web.DataGridViewTriState.[True]
        Me.DGV_Orden.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Orden.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Orden.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.Editar, Me.Folio, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.cFechaVerificacion, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.DGV_Orden.DataSource = Me.BindingSource1
        Me.DGV_Orden.Dock = Wisej.Web.DockStyle.Fill
        Me.DGV_Orden.Location = New System.Drawing.Point(0, 149)
        Me.DGV_Orden.Name = "DGV_Orden"
        Me.DGV_Orden.RowHeadersVisible = False
        Me.DGV_Orden.Size = New System.Drawing.Size(982, 382)
        Me.DGV_Orden.TabIndex = 1
        '
        'Editar
        '
        Me.Editar.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.Editar.CellImageLayout = Wisej.Web.DataGridViewImageCellLayout.Stretch
        Me.Editar.CellImageSource = "table-row-editing"
        Me.Editar.HeaderText = " "
        Me.Editar.Name = "Editar"
        Me.Editar.Width = 30
        '
        'Folio
        '
        Me.Folio.DataPropertyName = "FOLIO_ORDEN"
        Me.Folio.HeaderText = "Folio"
        Me.Folio.Name = "Folio"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CVE_ACTA"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cve Acta"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NOM_PROPIETARIO"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Propietario"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "RAZON_SOCIALX"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Razón Social"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FECHA_CAPTURA"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha capturado"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'cFechaVerificacion
        '
        Me.cFechaVerificacion.DataPropertyName = "FECHA_VERIFICACION"
        Me.cFechaVerificacion.HeaderText = "Fecha verificación"
        Me.cFechaVerificacion.Name = "cFechaVerificacion"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PROGRAMA"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Programa"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FECHA_REPORTE_LSP"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Reporte LSP"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ESTATUS"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "pCAT_ACTAS_VERIFICACION_B"
        Me.BindingSource1.DataSource = Me.DataSet_pCAT_ACTAS_VERIFICACION_B
        '
        'DataSet_pCAT_ACTAS_VERIFICACION_B
        '
        Me.DataSet_pCAT_ACTAS_VERIFICACION_B.DataSetName = "DataSet_pCAT_ACTAS_VERIFICACION_B"
        Me.DataSet_pCAT_ACTAS_VERIFICACION_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'folio_orden
        '
        Me.folio_orden.DataPropertyName = "FOLIO_ORDEN"
        Me.folio_orden.HeaderText = "Folio_Orden"
        Me.folio_orden.Name = "folio_orden"
        Me.folio_orden.ReadOnly = True
        Me.folio_orden.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.folio_orden.Visible = False
        '
        'folio_acta
        '
        Me.folio_acta.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.folio_acta.DataPropertyName = "CVE_ACTA"
        Me.folio_acta.HeaderText = "Cve Acta"
        Me.folio_acta.Name = "folio_acta"
        Me.folio_acta.ReadOnly = True
        Me.folio_acta.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'nom_propietario
        '
        Me.nom_propietario.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.nom_propietario.DataPropertyName = "NOM_PROPIETARIO"
        Me.nom_propietario.HeaderText = "Propietario"
        Me.nom_propietario.Name = "nom_propietario"
        Me.nom_propietario.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'razon_social
        '
        Me.razon_social.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.razon_social.DataPropertyName = "RAZON_SOCIALX"
        Me.razon_social.HeaderText = "Razón social"
        Me.razon_social.Name = "razon_social"
        Me.razon_social.ReadOnly = True
        Me.razon_social.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'fecha_captura
        '
        Me.fecha_captura.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.fecha_captura.DataPropertyName = "FECHA_CAPTURA"
        Me.fecha_captura.HeaderText = "Fecha de Captura"
        Me.fecha_captura.Name = "fecha_captura"
        Me.fecha_captura.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'fecha_ingreso
        '
        Me.fecha_ingreso.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.fecha_ingreso.DataPropertyName = "FECHA_INGRESO_EXPEDIENTE"
        Me.fecha_ingreso.HeaderText = "Fecha de Ingreso"
        Me.fecha_ingreso.Name = "fecha_ingreso"
        Me.fecha_ingreso.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'fecha_verificacion
        '
        Me.fecha_verificacion.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.fecha_verificacion.DataPropertyName = "FECHA_VERIFICACION"
        Me.fecha_verificacion.HeaderText = "Fecha Verificacion"
        Me.fecha_verificacion.Name = "fecha_verificacion"
        Me.fecha_verificacion.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'programa
        '
        Me.programa.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.programa.DataPropertyName = "PROGRAMA"
        Me.programa.HeaderText = "Programa"
        Me.programa.Name = "programa"
        Me.programa.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'fecha_reporte_lsp
        '
        Me.fecha_reporte_lsp.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.fecha_reporte_lsp.DataPropertyName = "FECHA_REPORTE_LSP"
        Me.fecha_reporte_lsp.HeaderText = "Reporte LSP"
        Me.fecha_reporte_lsp.Name = "fecha_reporte_lsp"
        Me.fecha_reporte_lsp.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'estatus
        '
        Me.estatus.DataPropertyName = "ESTATUS"
        Me.estatus.HeaderText = "Estatus"
        Me.estatus.Name = "estatus"
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
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 531)
        Me.BindingNavigator1.MoveFirstItem = Me.buttonMoveFirst
        Me.BindingNavigator1.MoveLastItem = Me.buttonMoveLast
        Me.BindingNavigator1.MoveNextItem = Me.buttonMoveNext
        Me.BindingNavigator1.MovePreviousItem = Me.buttonMovePrevious
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.textBoxPosition
        Me.BindingNavigator1.Size = New System.Drawing.Size(982, 34)
        Me.BindingNavigator1.TabIndex = 4
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
        'FiltroGrillaSax1
        '
        Me.FiltroGrillaSax1.AutoSize = True
        Me.FiltroGrillaSax1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.FiltroGrillaSax1.BackColor = System.Drawing.Color.Transparent
        Me.FiltroGrillaSax1.Dock = Wisej.Web.DockStyle.Top
        Me.FiltroGrillaSax1.Location = New System.Drawing.Point(0, 109)
        Me.FiltroGrillaSax1.meBackcolorEtiquetas = System.Drawing.Color.AliceBlue
        Me.FiltroGrillaSax1.meBorderStyleEtiquetas = Wisej.Web.BorderStyle.Solid
        Me.FiltroGrillaSax1.meBorderWidthEtiquetas = 1
        Me.FiltroGrillaSax1.meDatagrid = Nothing
        Me.FiltroGrillaSax1.meFiltrarVacios = False
        Me.FiltroGrillaSax1.meLanzarException = False
        Me.FiltroGrillaSax1.meMarginEtiquetas = New Wisej.Web.Padding(1)
        Me.FiltroGrillaSax1.mePaddingEtiquetas = New Wisej.Web.Padding(2)
        Me.FiltroGrillaSax1.Name = "FiltroGrillaSax1"
        Me.FiltroGrillaSax1.Size = New System.Drawing.Size(982, 40)
        Me.FiltroGrillaSax1.TabIndex = 3
        '
        'Cat_Actas_Verificacion
        '
        Me.ClientSize = New System.Drawing.Size(982, 565)
        Me.Controls.Add(Me.DGV_Orden)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.FiltroGrillaSax1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Cat_Actas_Verificacion"
        Me.Text = "Actas de Verificación"
        Me.WindowState = Wisej.Web.FormWindowState.Maximized
        CType(Me.DGV_Orden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCAT_ACTAS_VERIFICACION_B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonBar1 As RibbonBar
    Friend WithEvents RibbonBarPage1 As RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As RibbonBarGroup
    Friend WithEvents RBN_Nuevo As RibbonBarItemButton
    Friend WithEvents RBN_Salir As RibbonBarItemButton
    Friend WithEvents DGV_Orden As DataGridView
    Friend WithEvents FiltroGrillaSax1 As filtroGrillaSax
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataSet_pCAT_ACTAS_VERIFICACION_B As DataSet_pCAT_ACTAS_VERIFICACION_B
    Friend WithEvents RBN_Actualizar As RibbonBarItemButton
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
    Private WithEvents fecha_captura As DataGridViewTextBoxColumn
    Private WithEvents fecha_ingreso As DataGridViewTextBoxColumn
    Private WithEvents fecha_verificacion As DataGridViewTextBoxColumn
    Private WithEvents Editar As DataGridViewImageColumn
    Private WithEvents folio_orden As DataGridViewTextBoxColumn
    Private WithEvents folio_acta As DataGridViewTextBoxColumn
    Private WithEvents nom_propietario As DataGridViewTextBoxColumn
    Private WithEvents razon_social As DataGridViewTextBoxColumn
    Private WithEvents programa As DataGridViewTextBoxColumn
    Private WithEvents fecha_reporte_lsp As DataGridViewTextBoxColumn
    Private WithEvents estatus As DataGridViewTextBoxColumn
    Private WithEvents Folio As DataGridViewTextBoxColumn
    Private WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Private WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Private WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Private WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Private WithEvents cFechaVerificacion As DataGridViewTextBoxColumn
    Private WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Private WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Private WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
End Class
