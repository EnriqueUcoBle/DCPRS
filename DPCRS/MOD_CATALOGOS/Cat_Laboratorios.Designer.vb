Imports Wisej.Web.Ext.RibbonBar
Imports Wisej.Web

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cat_Laboratorios
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Me.DGVLaboratorios = New Wisej.Web.DataGridView()
        Me.Eliminar = New Wisej.Web.DataGridViewImageColumn()
        Me.DGVLCLAVE = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVLLABORATORIO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVLDESCRIPCIONX = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVLRESPONSABLE = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVLDESCRIPCIONY = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pCAT_LABORATORIOS_B = New DPCRS.DataSet_pCAT_LABORATORIOS_B()
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
        Me.Label2 = New Wisej.Web.Label()
        Me.TXTLaboratorio = New Wisej.Web.TextBox()
        Me.TXTClave = New Wisej.Web.TextBox()
        Me.Label1 = New Wisej.Web.Label()
        Me.Panel1 = New Wisej.Web.Panel()
        Me.TXTResponsable = New Wisej.Web.TextBox()
        Me.Label3 = New Wisej.Web.Label()
        Me.ErrorProvider1 = New Wisej.Web.ErrorProvider(Me.components)
        Me.RBDesactivado = New Wisej.Web.RadioButton()
        Me.RBHabilitado = New Wisej.Web.RadioButton()
        Me.BindingNavigator1 = New Wisej.Web.BindingNavigator(Me.components)
        Me.buttonMoveFirst = New Wisej.Web.Button()
        Me.buttonMovePrevious = New Wisej.Web.Button()
        Me.separatorLeft = New Wisej.Web.Line()
        Me.textBoxPosition = New Wisej.Web.TextBox()
        Me.labelCount = New Wisej.Web.Label()
        Me.separatorRight = New Wisej.Web.Line()
        Me.buttonMoveNext = New Wisej.Web.Button()
        Me.buttonMoveLast = New Wisej.Web.Button()
        Me.separatorControl = New Wisej.Web.Line()
        Me.buttonAddNew = New Wisej.Web.Button()
        Me.buttonDelete = New Wisej.Web.Button()
        CType(Me.DGVLaboratorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCAT_LABORATORIOS_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FiltroGrillaSax1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVLaboratorios
        '
        Me.DGVLaboratorios.AutoGenerateColumns = False
        DataGridViewCellStyle3.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = Wisej.Web.DataGridViewTriState.[True]
        Me.DGVLaboratorios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVLaboratorios.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVLaboratorios.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.Eliminar, Me.DGVLCLAVE, Me.DGVLLABORATORIO, Me.DGVLDESCRIPCIONX, Me.DGVLRESPONSABLE, Me.DGVLDESCRIPCIONY})
        Me.DGVLaboratorios.DataSource = Me.BindingSource1
        Me.DGVLaboratorios.Dock = Wisej.Web.DockStyle.Fill
        Me.DGVLaboratorios.Location = New System.Drawing.Point(0, 266)
        Me.DGVLaboratorios.Name = "DGVLaboratorios"
        Me.DGVLaboratorios.RowHeadersVisible = False
        Me.DGVLaboratorios.Size = New System.Drawing.Size(788, 253)
        Me.DGVLaboratorios.TabIndex = 3
        '
        'Eliminar
        '
        DataGridViewCellStyle4.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        DataGridViewCellStyle4.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackgroundImageSource = "Resources/Icons/Menu/delete-bin.png"
        Me.Eliminar.DefaultCellStyle = DataGridViewCellStyle4
        Me.Eliminar.HeaderText = " "
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = Wisej.Web.DataGridViewTriState.[False]
        Me.Eliminar.Width = 22
        '
        'DGVLCLAVE
        '
        Me.DGVLCLAVE.DataPropertyName = "CVE_LABORATORIO"
        Me.DGVLCLAVE.HeaderText = "Clave"
        Me.DGVLCLAVE.Name = "DGVLCLAVE"
        Me.DGVLCLAVE.ReadOnly = True
        Me.DGVLCLAVE.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVLCLAVE.ValueType = GetType(Integer)
        '
        'DGVLLABORATORIO
        '
        Me.DGVLLABORATORIO.DataPropertyName = "LABORATORIO"
        Me.DGVLLABORATORIO.HeaderText = "Laboratorio"
        Me.DGVLLABORATORIO.Name = "DGVLLABORATORIO"
        Me.DGVLLABORATORIO.ReadOnly = True
        Me.DGVLLABORATORIO.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVLLABORATORIO.ValueType = GetType(String)
        Me.DGVLLABORATORIO.Width = 300
        '
        'DGVLDESCRIPCIONX
        '
        Me.DGVLDESCRIPCIONX.DataPropertyName = "DESCRIPCIONX"
        Me.DGVLDESCRIPCIONX.HeaderText = "DESCRIPCIONX"
        Me.DGVLDESCRIPCIONX.Name = "DGVLDESCRIPCIONX"
        Me.DGVLDESCRIPCIONX.ReadOnly = True
        Me.DGVLDESCRIPCIONX.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVLDESCRIPCIONX.ValueType = GetType(String)
        Me.DGVLDESCRIPCIONX.Visible = False
        '
        'DGVLRESPONSABLE
        '
        Me.DGVLRESPONSABLE.DataPropertyName = "RESPONSABLE"
        Me.DGVLRESPONSABLE.HeaderText = "Responsable"
        Me.DGVLRESPONSABLE.Name = "DGVLRESPONSABLE"
        Me.DGVLRESPONSABLE.ReadOnly = True
        Me.DGVLRESPONSABLE.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVLRESPONSABLE.ValueType = GetType(String)
        Me.DGVLRESPONSABLE.Width = 300
        '
        'DGVLDESCRIPCIONY
        '
        Me.DGVLDESCRIPCIONY.DataPropertyName = "DESCRIPCIONY"
        Me.DGVLDESCRIPCIONY.HeaderText = "DESCRIPCIONY"
        Me.DGVLDESCRIPCIONY.Name = "DGVLDESCRIPCIONY"
        Me.DGVLDESCRIPCIONY.ReadOnly = True
        Me.DGVLDESCRIPCIONY.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVLDESCRIPCIONY.ValueType = GetType(String)
        Me.DGVLDESCRIPCIONY.Visible = False
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "pCAT_LABORATORIOS_B"
        Me.BindingSource1.DataSource = Me.DataSet_pCAT_LABORATORIOS_B
        '
        'DataSet_pCAT_LABORATORIOS_B
        '
        Me.DataSet_pCAT_LABORATORIOS_B.DataSetName = "DataSet_pCAT_LABORATORIOS_B"
        Me.DataSet_pCAT_LABORATORIOS_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.RibbonBar1.Size = New System.Drawing.Size(788, 145)
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
        'RBNGUARDAR
        '
        Me.RBNGUARDAR.ColumnBreak = True
        Me.RBNGUARDAR.ImageSource = "ribbon-save?color=#FF0000"
        Me.RBNGUARDAR.Text = "Guardar"
        '
        'RBNSALIR
        '
        Me.RBNSALIR.ColumnBreak = True
        Me.RBNSALIR.ImageSource = "Resources\Images\Menu\30\exit-sign-red.png?color=#0000FF"
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
        Me.FiltroGrillaSax1.Location = New System.Drawing.Point(0, 226)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Laboratorio"
        '
        'TXTLaboratorio
        '
        Me.TXTLaboratorio.Location = New System.Drawing.Point(294, 24)
        Me.TXTLaboratorio.Name = "TXTLaboratorio"
        Me.TXTLaboratorio.Size = New System.Drawing.Size(234, 22)
        Me.TXTLaboratorio.TabIndex = 1
        '
        'TXTClave
        '
        Me.TXTClave.Enabled = False
        Me.TXTClave.Location = New System.Drawing.Point(122, 24)
        Me.TXTClave.Name = "TXTClave"
        Me.TXTClave.Size = New System.Drawing.Size(78, 22)
        Me.TXTClave.TabIndex = 0
        Me.TXTClave.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Clave Laboratorio"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.TXTResponsable)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TXTLaboratorio)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TXTClave)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 145)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(788, 81)
        Me.Panel1.TabIndex = 5
        '
        'TXTResponsable
        '
        Me.TXTResponsable.Location = New System.Drawing.Point(629, 24)
        Me.TXTResponsable.Name = "TXTResponsable"
        Me.TXTResponsable.Size = New System.Drawing.Size(234, 22)
        Me.TXTResponsable.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(545, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Responsable"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 3
        Me.ErrorProvider1.ContainerControl = Me
        '
        'RBDesactivado
        '
        Me.RBDesactivado.Location = New System.Drawing.Point(718, 6)
        Me.RBDesactivado.Name = "RBDesactivado"
        Me.RBDesactivado.Size = New System.Drawing.Size(100, 23)
        Me.RBDesactivado.TabIndex = 12
        Me.RBDesactivado.TabStop = False
        Me.RBDesactivado.Text = "Desactivado"
        '
        'RBHabilitado
        '
        Me.RBHabilitado.Checked = True
        Me.RBHabilitado.Location = New System.Drawing.Point(611, 6)
        Me.RBHabilitado.Name = "RBHabilitado"
        Me.RBHabilitado.Size = New System.Drawing.Size(85, 23)
        Me.RBHabilitado.TabIndex = 11
        Me.RBHabilitado.Text = "Habilitado"
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
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 519)
        Me.BindingNavigator1.MoveFirstItem = Me.buttonMoveFirst
        Me.BindingNavigator1.MoveLastItem = Me.buttonMoveLast
        Me.BindingNavigator1.MoveNextItem = Me.buttonMoveNext
        Me.BindingNavigator1.MovePreviousItem = Me.buttonMovePrevious
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.textBoxPosition
        Me.BindingNavigator1.Size = New System.Drawing.Size(788, 37)
        Me.BindingNavigator1.TabIndex = 6
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
        'buttonAddNew
        '
        Me.buttonAddNew.ImageSource = "table-row-new"
        Me.buttonAddNew.Location = New System.Drawing.Point(336, 3)
        Me.buttonAddNew.Name = "buttonAddNew"
        Me.buttonAddNew.Size = New System.Drawing.Size(37, 28)
        Me.buttonAddNew.TabIndex = 4
        '
        'buttonDelete
        '
        Me.buttonDelete.ImageSource = "icon-close"
        Me.buttonDelete.Location = New System.Drawing.Point(379, 3)
        Me.buttonDelete.Name = "buttonDelete"
        Me.buttonDelete.Size = New System.Drawing.Size(37, 28)
        Me.buttonDelete.TabIndex = 5
        '
        'Cat_Laboratorios
        '
        Me.ClientSize = New System.Drawing.Size(788, 556)
        Me.Controls.Add(Me.DGVLaboratorios)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.FiltroGrillaSax1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Cat_Laboratorios"
        Me.Text = "Cat Laboratorios"
        Me.WindowState = Wisej.Web.FormWindowState.Maximized
        CType(Me.DGVLaboratorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCAT_LABORATORIOS_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FiltroGrillaSax1.ResumeLayout(False)
        Me.FiltroGrillaSax1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVLaboratorios As DataGridView
    Friend WithEvents RibbonBar1 As RibbonBar
    Friend WithEvents Menu As RibbonBarPage
    Friend WithEvents Opciones As RibbonBarGroup
    Friend WithEvents RBNNUEVO As RibbonBarItemButton
    Friend WithEvents RBNSALIR As RibbonBarItemButton
    Friend WithEvents FiltroGrillaSax1 As filtroGrillaSax
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTLaboratorio As TextBox
    Friend WithEvents TXTClave As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RBNACTUALIZAR As RibbonBarItemButton
    Friend WithEvents RBNGUARDAR As RibbonBarItemButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents TXTResponsable As TextBox
    Friend WithEvents DataSet_pCAT_LABORATORIOS_B As DataSet_pCAT_LABORATORIOS_B
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
    Private WithEvents DGVLCLAVE As DataGridViewTextBoxColumn
    Private WithEvents DGVLLABORATORIO As DataGridViewTextBoxColumn
    Private WithEvents DGVLDESCRIPCIONX As DataGridViewTextBoxColumn
    Private WithEvents DGVLRESPONSABLE As DataGridViewTextBoxColumn
    Private WithEvents DGVLDESCRIPCIONY As DataGridViewTextBoxColumn
End Class
