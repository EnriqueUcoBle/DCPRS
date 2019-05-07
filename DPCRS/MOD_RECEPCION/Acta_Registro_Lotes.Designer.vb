Imports Wisej.Web.Ext.RibbonBar
Imports Wisej.Web

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Acta_Registro_Lotes
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
        Dim ComponentTool1 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Me.DGVExpedientes = New Wisej.Web.DataGridView()
        Me.Eliminar = New Wisej.Web.DataGridViewImageColumn()
        Me.DGVCONSECUTIVO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVCLAVEACTA = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVESTABLECIMIENTO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVPROPIETARIO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVDIRECCION = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVCLAVEESTABLECIMIENTO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.BD = New Wisej.Web.DataGridViewCheckBoxColumn()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pACTAS_VERIFICACION_LOTES_B = New DPCRS.DataSet_pACTAS_VERIFICACION_LOTES_B()
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.Menu = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.Opciones = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBNNUEVO = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNGUARDAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNIMPRIMIR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNSALIR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Panel1 = New Wisej.Web.Panel()
        Me.BTNAgregar = New Wisej.Web.Button()
        Me.CBSEstablecimiento = New Wisej.Web.ComboBox()
        Me.TXTClaveActa = New Wisej.Web.TextBox()
        Me.Label2 = New Wisej.Web.Label()
        Me.Label1 = New Wisej.Web.Label()
        Me.ErrorProvider1 = New Wisej.Web.ErrorProvider(Me.components)
        Me.LBLMunicipio = New Wisej.Web.Label()
        Me.DTPFecha = New Wisej.Web.DateTimePicker()
        Me.colCVE_EXPEDIENTE = New Wisej.Web.DataGridViewTextBoxColumn()
        CType(Me.DGVExpedientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pACTAS_VERIFICACION_LOTES_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVExpedientes
        '
        Me.DGVExpedientes.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = Wisej.Web.DataGridViewTriState.[True]
        Me.DGVExpedientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVExpedientes.ColumnHeadersHeight = 32
        Me.DGVExpedientes.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVExpedientes.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.Eliminar, Me.colCVE_EXPEDIENTE, Me.DGVCONSECUTIVO, Me.DGVCLAVEACTA, Me.DGVESTABLECIMIENTO, Me.DGVPROPIETARIO, Me.DGVDIRECCION, Me.DGVCLAVEESTABLECIMIENTO, Me.BD})
        Me.DGVExpedientes.DataSource = Me.BindingSource1
        Me.DGVExpedientes.Dock = Wisej.Web.DockStyle.Fill
        Me.DGVExpedientes.Location = New System.Drawing.Point(0, 229)
        Me.DGVExpedientes.Name = "DGVExpedientes"
        Me.DGVExpedientes.RowHeadersVisible = False
        Me.DGVExpedientes.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect
        Me.DGVExpedientes.Size = New System.Drawing.Size(1135, 321)
        Me.DGVExpedientes.TabIndex = 4
        '
        'Eliminar
        '
        Me.Eliminar.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        DataGridViewCellStyle2.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        DataGridViewCellStyle2.BackgroundImageSource = "Resources/Icons/Menu/delete-bin.png"
        Me.Eliminar.DefaultCellStyle = DataGridViewCellStyle2
        Me.Eliminar.HeaderText = " "
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = Wisej.Web.DataGridViewTriState.[False]
        Me.Eliminar.Width = 25
        '
        'DGVCONSECUTIVO
        '
        Me.DGVCONSECUTIVO.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DGVCONSECUTIVO.DataPropertyName = "NUM_CONSECUTIVO"
        Me.DGVCONSECUTIVO.HeaderText = "Num consecutivo"
        Me.DGVCONSECUTIVO.Name = "DGVCONSECUTIVO"
        Me.DGVCONSECUTIVO.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'DGVCLAVEACTA
        '
        Me.DGVCLAVEACTA.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DGVCLAVEACTA.DataPropertyName = "CVE_ACTA"
        Me.DGVCLAVEACTA.HeaderText = "Clave acta"
        Me.DGVCLAVEACTA.MinimumWidth = 150
        Me.DGVCLAVEACTA.Name = "DGVCLAVEACTA"
        Me.DGVCLAVEACTA.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVCLAVEACTA.Width = 150
        '
        'DGVESTABLECIMIENTO
        '
        Me.DGVESTABLECIMIENTO.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DGVESTABLECIMIENTO.DataPropertyName = "RAZON_SOCIAL"
        Me.DGVESTABLECIMIENTO.HeaderText = "Establecimiento"
        Me.DGVESTABLECIMIENTO.MinimumWidth = 250
        Me.DGVESTABLECIMIENTO.Name = "DGVESTABLECIMIENTO"
        Me.DGVESTABLECIMIENTO.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVESTABLECIMIENTO.Width = 250
        '
        'DGVPROPIETARIO
        '
        Me.DGVPROPIETARIO.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DGVPROPIETARIO.DataPropertyName = "PROPIETARIO"
        Me.DGVPROPIETARIO.HeaderText = "Propietario"
        Me.DGVPROPIETARIO.MinimumWidth = 250
        Me.DGVPROPIETARIO.Name = "DGVPROPIETARIO"
        Me.DGVPROPIETARIO.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVPROPIETARIO.Width = 250
        '
        'DGVDIRECCION
        '
        Me.DGVDIRECCION.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DGVDIRECCION.DataPropertyName = "DOMICILIO"
        Me.DGVDIRECCION.HeaderText = "Dirección"
        Me.DGVDIRECCION.MinimumWidth = 250
        Me.DGVDIRECCION.Name = "DGVDIRECCION"
        Me.DGVDIRECCION.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVDIRECCION.Width = 250
        '
        'DGVCLAVEESTABLECIMIENTO
        '
        Me.DGVCLAVEESTABLECIMIENTO.DataPropertyName = "CVE_ESTABLECIMIENTO"
        Me.DGVCLAVEESTABLECIMIENTO.HeaderText = "CVE_ESTABLECIMIENTO"
        Me.DGVCLAVEESTABLECIMIENTO.Name = "DGVCLAVEESTABLECIMIENTO"
        Me.DGVCLAVEESTABLECIMIENTO.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVCLAVEESTABLECIMIENTO.Visible = False
        '
        'BD
        '
        Me.BD.HeaderText = "Base de Datos"
        Me.BD.Name = "BD"
        Me.BD.Visible = False
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "pACTAS_VERIFICACION_LOTES_B"
        Me.BindingSource1.DataSource = Me.DataSet_pACTAS_VERIFICACION_LOTES_B
        '
        'DataSet_pACTAS_VERIFICACION_LOTES_B
        '
        Me.DataSet_pACTAS_VERIFICACION_LOTES_B.DataSetName = "DataSet_pACTAS_VERIFICACION_LOTES_B"
        Me.DataSet_pACTAS_VERIFICACION_LOTES_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Dock = Wisej.Web.DockStyle.Top
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.Menu)
        Me.RibbonBar1.Size = New System.Drawing.Size(1135, 145)
        '
        'Menu
        '
        Me.Menu.Groups.Add(Me.Opciones)
        Me.Menu.Text = "Menú"
        '
        'Opciones
        '
        Me.Opciones.Items.Add(Me.RBNNUEVO)
        Me.Opciones.Items.Add(Me.RBNGUARDAR)
        Me.Opciones.Items.Add(Me.RBNIMPRIMIR)
        Me.Opciones.Items.Add(Me.RBNSALIR)
        Me.Opciones.Text = "Opciones"
        '
        'RBNNUEVO
        '
        Me.RBNNUEVO.ColumnBreak = True
        Me.RBNNUEVO.ImageSource = "ribbon-document?color=#FF0000"
        Me.RBNNUEVO.Text = "Nuevo"
        '
        'RBNGUARDAR
        '
        Me.RBNGUARDAR.ColumnBreak = True
        Me.RBNGUARDAR.ImageSource = "ribbon-save?color=#FF0000"
        Me.RBNGUARDAR.Text = "Guardar"
        '
        'RBNIMPRIMIR
        '
        Me.RBNIMPRIMIR.ColumnBreak = True
        Me.RBNIMPRIMIR.ImageSource = "icon-print?color=#006EFF"
        Me.RBNIMPRIMIR.Text = "Imprimir"
        '
        'RBNSALIR
        '
        Me.RBNSALIR.ColumnBreak = True
        Me.RBNSALIR.ImageSource = "Resources\Images\Menu\30\exit-sign-red.png?color=#0000FF"
        Me.RBNSALIR.Text = "Salir"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BTNAgregar)
        Me.Panel1.Controls.Add(Me.CBSEstablecimiento)
        Me.Panel1.Controls.Add(Me.TXTClaveActa)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 145)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1135, 84)
        Me.Panel1.TabIndex = 5
        '
        'BTNAgregar
        '
        Me.BTNAgregar.Location = New System.Drawing.Point(447, 26)
        Me.BTNAgregar.Name = "BTNAgregar"
        Me.BTNAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BTNAgregar.TabIndex = 5
        Me.BTNAgregar.Text = "Agregar"
        '
        'CBSEstablecimiento
        '
        Me.CBSEstablecimiento.BackColor = System.Drawing.Color.Transparent
        Me.CBSEstablecimiento.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSEstablecimiento.Location = New System.Drawing.Point(116, 42)
        Me.CBSEstablecimiento.Name = "CBSEstablecimiento"
        Me.CBSEstablecimiento.Size = New System.Drawing.Size(300, 22)
        Me.CBSEstablecimiento.TabIndex = 4
        ComponentTool1.ImageSource = "icon-close"
        ComponentTool1.Name = "Borrar"
        Me.CBSEstablecimiento.Tools.AddRange(New Wisej.Web.ComponentTool() {ComponentTool1})
        Me.CBSEstablecimiento.Watermark = "Ingrese Texto (Enter)..."
        '
        'TXTClaveActa
        '
        Me.TXTClaveActa.BackColor = System.Drawing.Color.LightYellow
        Me.TXTClaveActa.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.TXTClaveActa.Location = New System.Drawing.Point(116, 6)
        Me.TXTClaveActa.Name = "TXTClaveActa"
        Me.TXTClaveActa.Size = New System.Drawing.Size(300, 22)
        Me.TXTClaveActa.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Establecimiento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave acta"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 3
        Me.ErrorProvider1.ContainerControl = Me
        '
        'LBLMunicipio
        '
        Me.LBLMunicipio.AutoSize = True
        Me.LBLMunicipio.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LBLMunicipio.Location = New System.Drawing.Point(351, 78)
        Me.LBLMunicipio.Name = "LBLMunicipio"
        Me.LBLMunicipio.Size = New System.Drawing.Size(171, 21)
        Me.LBLMunicipio.TabIndex = 6
        Me.LBLMunicipio.Text = "Jurisdicción: Municipio"
        '
        'DTPFecha
        '
        Me.DTPFecha.CustomFormat = "dd/MM/yyyy"
        Me.DTPFecha.Enabled = False
        Me.DTPFecha.Format = Wisej.Web.DateTimePickerFormat.Custom
        Me.DTPFecha.Location = New System.Drawing.Point(582, 76)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(200, 22)
        Me.DTPFecha.TabIndex = 7
        Me.DTPFecha.Value = New Date(2018, 4, 9, 15, 28, 47, 898)
        '
        'colCVE_EXPEDIENTE
        '
        Me.colCVE_EXPEDIENTE.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colCVE_EXPEDIENTE.DataPropertyName = "CVE_EXPEDIENTE"
        Me.colCVE_EXPEDIENTE.HeaderText = "CVE_EXPEDIENTE"
        Me.colCVE_EXPEDIENTE.Name = "CVE_EXPEDIENTE"
        Me.colCVE_EXPEDIENTE.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.colCVE_EXPEDIENTE.Visible = False
        '
        'Acta_Registro_Lotes
        '
        Me.ClientSize = New System.Drawing.Size(1135, 550)
        Me.Controls.Add(Me.DGVExpedientes)
        Me.Controls.Add(Me.DTPFecha)
        Me.Controls.Add(Me.LBLMunicipio)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Acta_Registro_Lotes"
        Me.Text = "Registro Expedientes"
        Me.WindowState = Wisej.Web.FormWindowState.Maximized
        CType(Me.DGVExpedientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pACTAS_VERIFICACION_LOTES_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVExpedientes As DataGridView
    Friend WithEvents RibbonBar1 As RibbonBar
    Friend WithEvents Menu As RibbonBarPage
    Friend WithEvents Opciones As RibbonBarGroup
    Friend WithEvents RBNNUEVO As RibbonBarItemButton
    Friend WithEvents RBNSALIR As RibbonBarItemButton
    Friend WithEvents RBNGUARDAR As RibbonBarItemButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents TXTClaveActa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CBSEstablecimiento As ComboBox
    Friend WithEvents LBLMunicipio As Label
    Friend WithEvents DTPFecha As DateTimePicker
    Friend WithEvents BTNAgregar As Button
    Friend WithEvents RBNIMPRIMIR As RibbonBarItemButton
    Private WithEvents Eliminar As DataGridViewImageColumn
    Private WithEvents DGVCONSECUTIVO As DataGridViewTextBoxColumn
    Private WithEvents DGVCLAVEACTA As DataGridViewTextBoxColumn
    Private WithEvents DGVESTABLECIMIENTO As DataGridViewTextBoxColumn
    Private WithEvents DGVPROPIETARIO As DataGridViewTextBoxColumn
    Private WithEvents DGVDIRECCION As DataGridViewTextBoxColumn
    Private WithEvents DGVCLAVEESTABLECIMIENTO As DataGridViewTextBoxColumn
    Friend WithEvents DataSet_pACTAS_VERIFICACION_LOTES_B As DataSet_pACTAS_VERIFICACION_LOTES_B
    Friend WithEvents BindingSource1 As BindingSource
    Private WithEvents Column0 As DataGridViewCheckBoxColumn
    Private WithEvents colCVE_EXPEDIENTE As DataGridViewTextBoxColumn
    Private WithEvents BD As DataGridViewCheckBoxColumn
End Class
