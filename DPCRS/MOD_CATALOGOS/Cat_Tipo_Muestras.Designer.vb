Imports Wisej.Web.Ext.RibbonBar
Imports Wisej.Web

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cat_Tipo_Muestras
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
        Me.DGVMuestras = New Wisej.Web.DataGridView()
        Me.Eliminar = New Wisej.Web.DataGridViewImageColumn()
        Me.Editar = New Wisej.Web.DataGridViewImageColumn()
        Me.DGVMCLAVE = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVMMUESTRA = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVMDESCRIPCIONX = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVMOBSERVACION = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pCAT_TIPO_MUESTRAS_B = New DPCRS.DataSet_pCAT_TIPO_MUESTRAS_B()
        Me.DGVDESCRIPCIONX = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVDESCRIPCIONY = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.CLAVE = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.ESTADO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.Menu = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.Opciones = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBNNUEVO = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNACTUALIZAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNGUARDAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNSALIR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.FiltroGrillaSax1 = New DPCRS.filtroGrillaSax()
        Me.RBHabilitado = New Wisej.Web.RadioButton()
        Me.RBDesactivado = New Wisej.Web.RadioButton()
        Me.Label2 = New Wisej.Web.Label()
        Me.TXTMuestra = New Wisej.Web.TextBox()
        Me.Panel_nuevo = New Wisej.Web.Panel()
        Me.TXTObservaciones = New Wisej.Web.TextBox()
        Me.Label3 = New Wisej.Web.Label()
        Me.Label1 = New Wisej.Web.Label()
        Me.TXTClave = New Wisej.Web.TextBox()
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
        CType(Me.DGVMuestras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCAT_TIPO_MUESTRAS_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FiltroGrillaSax1.SuspendLayout()
        Me.Panel_nuevo.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVMuestras
        '
        Me.DGVMuestras.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = Wisej.Web.DataGridViewTriState.[True]
        Me.DGVMuestras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVMuestras.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMuestras.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.Eliminar, Me.Editar, Me.DGVMCLAVE, Me.DGVMMUESTRA, Me.DGVMDESCRIPCIONX, Me.DGVMOBSERVACION})
        Me.DGVMuestras.DataSource = Me.BindingSource1
        Me.DGVMuestras.Dock = Wisej.Web.DockStyle.Fill
        Me.DGVMuestras.Location = New System.Drawing.Point(0, 260)
        Me.DGVMuestras.Name = "DGVMuestras"
        Me.DGVMuestras.RowHeadersVisible = False
        Me.DGVMuestras.Size = New System.Drawing.Size(788, 296)
        Me.DGVMuestras.TabIndex = 3
        '
        'Eliminar
        '
        Me.Eliminar.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.Eliminar.CellImageSource = ""
        DataGridViewCellStyle2.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackgroundImageSource = "Resources/Images/Menu/30/trash.png"
        Me.Eliminar.DefaultCellStyle = DataGridViewCellStyle2
        Me.Eliminar.HeaderText = " "
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = Wisej.Web.DataGridViewTriState.[False]
        Me.Eliminar.Width = 22
        '
        'Editar
        '
        Me.Editar.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.Editar.CellImageSource = ""
        DataGridViewCellStyle3.BackgroundImageSource = "Resources/Images/Menu/30/046-pencil.png"
        Me.Editar.DefaultCellStyle = DataGridViewCellStyle3
        Me.Editar.Name = "Editar"
        Me.Editar.ReadOnly = True
        Me.Editar.Resizable = Wisej.Web.DataGridViewTriState.[False]
        Me.Editar.Width = 22
        '
        'DGVMCLAVE
        '
        Me.DGVMCLAVE.DataPropertyName = "CVE_TIPO_MUESTRA"
        Me.DGVMCLAVE.HeaderText = "Clave"
        Me.DGVMCLAVE.Name = "DGVMCLAVE"
        Me.DGVMCLAVE.ReadOnly = True
        Me.DGVMCLAVE.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'DGVMMUESTRA
        '
        Me.DGVMMUESTRA.DataPropertyName = "DESCRIPCION"
        Me.DGVMMUESTRA.HeaderText = "Tipo Muestra"
        Me.DGVMMUESTRA.Name = "DGVMMUESTRA"
        Me.DGVMMUESTRA.ReadOnly = True
        Me.DGVMMUESTRA.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVMMUESTRA.Width = 300
        '
        'DGVMDESCRIPCIONX
        '
        Me.DGVMDESCRIPCIONX.DataPropertyName = "DESCRIPCIONX"
        Me.DGVMDESCRIPCIONX.HeaderText = "DESCRIPCIONX"
        Me.DGVMDESCRIPCIONX.Name = "DGVMDESCRIPCIONX"
        Me.DGVMDESCRIPCIONX.ReadOnly = True
        Me.DGVMDESCRIPCIONX.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVMDESCRIPCIONX.Visible = False
        '
        'DGVMOBSERVACION
        '
        Me.DGVMOBSERVACION.DataPropertyName = "OBSERVACIONES"
        Me.DGVMOBSERVACION.HeaderText = "Observación"
        Me.DGVMOBSERVACION.Name = "DGVMOBSERVACION"
        Me.DGVMOBSERVACION.ReadOnly = True
        Me.DGVMOBSERVACION.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVMOBSERVACION.Width = 300
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "pCAT_TIPO_MUESTRAS_B"
        Me.BindingSource1.DataSource = Me.DataSet_pCAT_TIPO_MUESTRAS_B
        '
        'DataSet_pCAT_TIPO_MUESTRAS_B
        '
        Me.DataSet_pCAT_TIPO_MUESTRAS_B.DataSetName = "DataSet_pCAT_TIPO_MUESTRAS_B"
        Me.DataSet_pCAT_TIPO_MUESTRAS_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DGVDESCRIPCIONX
        '
        Me.DGVDESCRIPCIONX.DataPropertyName = "DESCRIPCIONX"
        Me.DGVDESCRIPCIONX.HeaderText = "DESCRIPCIONX"
        Me.DGVDESCRIPCIONX.Name = "DGVDESCRIPCIONX"
        Me.DGVDESCRIPCIONX.ReadOnly = True
        Me.DGVDESCRIPCIONX.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVDESCRIPCIONX.Visible = False
        '
        'DGVDESCRIPCIONY
        '
        Me.DGVDESCRIPCIONY.DataPropertyName = "DESCRIPCIONY"
        Me.DGVDESCRIPCIONY.HeaderText = "DESCRIPCIONY"
        Me.DGVDESCRIPCIONY.Name = "DGVDESCRIPCIONY"
        Me.DGVDESCRIPCIONY.ReadOnly = True
        Me.DGVDESCRIPCIONY.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVDESCRIPCIONY.Visible = False
        '
        'CLAVE
        '
        Me.CLAVE.DataPropertyName = "CLAVE"
        Me.CLAVE.HeaderText = "Clave"
        Me.CLAVE.MinimumWidth = 100
        Me.CLAVE.Name = "CLAVE"
        Me.CLAVE.ReadOnly = True
        Me.CLAVE.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'ESTADO
        '
        Me.ESTADO.DataPropertyName = "DESCRIPCION"
        Me.ESTADO.HeaderText = "Estado"
        Me.ESTADO.MinimumWidth = 100
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.ReadOnly = True
        Me.ESTADO.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.ESTADO.Width = 300
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Dock = Wisej.Web.DockStyle.Top
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.Menu)
        Me.RibbonBar1.Size = New System.Drawing.Size(788, 139)
        '
        'Menu
        '
        Me.Menu.Groups.Add(Me.Opciones)
        Me.Menu.Text = "Menú"
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
        'FiltroGrillaSax1
        '
        Me.FiltroGrillaSax1.AutoSize = True
        Me.FiltroGrillaSax1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.FiltroGrillaSax1.BackColor = System.Drawing.Color.Transparent
        Me.FiltroGrillaSax1.Controls.Add(Me.RBHabilitado)
        Me.FiltroGrillaSax1.Controls.Add(Me.RBDesactivado)
        Me.FiltroGrillaSax1.Dock = Wisej.Web.DockStyle.Top
        Me.FiltroGrillaSax1.Location = New System.Drawing.Point(0, 220)
        Me.FiltroGrillaSax1.meBackcolorEtiquetas = System.Drawing.Color.AliceBlue
        Me.FiltroGrillaSax1.meBorderStyleEtiquetas = Wisej.Web.BorderStyle.Solid
        Me.FiltroGrillaSax1.meBorderWidthEtiquetas = 1
        Me.FiltroGrillaSax1.meDatagrid = Nothing
        Me.FiltroGrillaSax1.meFiltrarVacios = False
        Me.FiltroGrillaSax1.meLanzarException = False
        Me.FiltroGrillaSax1.meMarginEtiquetas = New Wisej.Web.Padding(1)
        Me.FiltroGrillaSax1.mePaddingEtiquetas = New Wisej.Web.Padding(2)
        Me.FiltroGrillaSax1.Name = "FiltroGrillaSax1"
        Me.FiltroGrillaSax1.Size = New System.Drawing.Size(788, 40)
        Me.FiltroGrillaSax1.TabIndex = 2
        '
        'RBHabilitado
        '
        Me.RBHabilitado.Checked = True
        Me.RBHabilitado.Location = New System.Drawing.Point(611, 11)
        Me.RBHabilitado.Name = "RBHabilitado"
        Me.RBHabilitado.Size = New System.Drawing.Size(85, 23)
        Me.RBHabilitado.TabIndex = 11
        Me.RBHabilitado.Text = "Habilitado"
        '
        'RBDesactivado
        '
        Me.RBDesactivado.Location = New System.Drawing.Point(718, 11)
        Me.RBDesactivado.Name = "RBDesactivado"
        Me.RBDesactivado.Size = New System.Drawing.Size(100, 23)
        Me.RBDesactivado.TabIndex = 12
        Me.RBDesactivado.TabStop = False
        Me.RBDesactivado.Text = "Desactivado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tipo Muestra"
        '
        'TXTMuestra
        '
        Me.TXTMuestra.Location = New System.Drawing.Point(290, 25)
        Me.TXTMuestra.Name = "TXTMuestra"
        Me.TXTMuestra.Size = New System.Drawing.Size(234, 22)
        Me.TXTMuestra.TabIndex = 1
        '
        'Panel_nuevo
        '
        Me.Panel_nuevo.AutoScroll = True
        Me.Panel_nuevo.Controls.Add(Me.TXTObservaciones)
        Me.Panel_nuevo.Controls.Add(Me.Label3)
        Me.Panel_nuevo.Controls.Add(Me.Label2)
        Me.Panel_nuevo.Controls.Add(Me.TXTMuestra)
        Me.Panel_nuevo.Controls.Add(Me.Label1)
        Me.Panel_nuevo.Controls.Add(Me.TXTClave)
        Me.Panel_nuevo.Dock = Wisej.Web.DockStyle.Top
        Me.Panel_nuevo.Location = New System.Drawing.Point(0, 139)
        Me.Panel_nuevo.Name = "Panel_nuevo"
        Me.Panel_nuevo.Size = New System.Drawing.Size(788, 81)
        Me.Panel_nuevo.TabIndex = 5
        Me.Panel_nuevo.Visible = False
        '
        'TXTObservaciones
        '
        Me.TXTObservaciones.Location = New System.Drawing.Point(621, 24)
        Me.TXTObservaciones.Name = "TXTObservaciones"
        Me.TXTObservaciones.Size = New System.Drawing.Size(234, 22)
        Me.TXTObservaciones.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(530, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Observaciones"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Clave Muestra"
        '
        'TXTClave
        '
        Me.TXTClave.Enabled = False
        Me.TXTClave.Location = New System.Drawing.Point(105, 24)
        Me.TXTClave.Name = "TXTClave"
        Me.TXTClave.Size = New System.Drawing.Size(78, 22)
        Me.TXTClave.TabIndex = 0
        Me.TXTClave.Text = "0"
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
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 523)
        Me.BindingNavigator1.MoveFirstItem = Me.buttonMoveFirst
        Me.BindingNavigator1.MoveLastItem = Me.buttonMoveLast
        Me.BindingNavigator1.MoveNextItem = Me.buttonMoveNext
        Me.BindingNavigator1.MovePreviousItem = Me.buttonMovePrevious
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.textBoxPosition
        Me.BindingNavigator1.Size = New System.Drawing.Size(788, 33)
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
        'Cat_Tipo_Muestras
        '
        Me.ClientSize = New System.Drawing.Size(788, 556)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.DGVMuestras)
        Me.Controls.Add(Me.FiltroGrillaSax1)
        Me.Controls.Add(Me.Panel_nuevo)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Cat_Tipo_Muestras"
        Me.Text = "Cat Tipo Muestra"
        Me.WindowState = Wisej.Web.FormWindowState.Maximized
        CType(Me.DGVMuestras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCAT_TIPO_MUESTRAS_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FiltroGrillaSax1.ResumeLayout(False)
        Me.FiltroGrillaSax1.PerformLayout()
        Me.Panel_nuevo.ResumeLayout(False)
        Me.Panel_nuevo.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVMuestras As DataGridView
    Friend WithEvents RibbonBar1 As RibbonBar
    Friend WithEvents Menu As RibbonBarPage
    Friend WithEvents Opciones As RibbonBarGroup
    Friend WithEvents RBNNUEVO As RibbonBarItemButton
    Friend WithEvents RBNSALIR As RibbonBarItemButton
    Friend WithEvents FiltroGrillaSax1 As filtroGrillaSax
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTMuestra As TextBox
    Friend WithEvents RBNACTUALIZAR As RibbonBarItemButton
    Friend WithEvents RBNGUARDAR As RibbonBarItemButton
    Friend WithEvents Panel_nuevo As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents TXTObservaciones As TextBox
    Friend WithEvents DataSet_pCAT_TIPO_MUESTRAS_B As DataSet_pCAT_TIPO_MUESTRAS_B
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
    Private WithEvents CLAVE As DataGridViewTextBoxColumn
    Private WithEvents ESTADO As DataGridViewTextBoxColumn
    Private WithEvents DGVDESCRIPCIONX As DataGridViewTextBoxColumn
    Private WithEvents DGVDESCRIPCIONY As DataGridViewTextBoxColumn
    Private WithEvents DGVMCLAVE As DataGridViewTextBoxColumn
    Private WithEvents DGVMMUESTRA As DataGridViewTextBoxColumn
    Private WithEvents DGVMDESCRIPCIONX As DataGridViewTextBoxColumn
    Private WithEvents DGVMOBSERVACION As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTClave As TextBox
    Friend WithEvents Editar As DataGridViewImageColumn
End Class
