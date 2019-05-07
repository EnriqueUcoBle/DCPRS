Imports Wisej.Web.Ext.RibbonBar
Imports Wisej.Web

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cat_Giros
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
        Dim DataGridViewCellStyle3 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Me.DGVGiros = New Wisej.Web.DataGridView()
        Me.Eliminar = New Wisej.Web.DataGridViewImageColumn()
        Me.DGVGCLAVE = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DGVGGIRO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pCAT_GIROS_B = New DPCRS.DataSet_pCAT_GIROS_B()
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.Menu = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.Opciones = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBNNUEVO = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNACTUALIZAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNGUARDAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNSALIR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.FiltroGrillaSax1 = New DPCRS.filtroGrillaSax()
        Me.RBDesactivado = New Wisej.Web.RadioButton()
        Me.RBHabilitado = New Wisej.Web.RadioButton()
        Me.Label3 = New Wisej.Web.Label()
        Me.TXTGiro = New Wisej.Web.TextBox()
        Me.TXTClave = New Wisej.Web.TextBox()
        Me.Label2 = New Wisej.Web.Label()
        Me.Panel1 = New Wisej.Web.GroupBox()
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
        CType(Me.DGVGiros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCAT_GIROS_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVGiros
        '
        Me.DGVGiros.AutoGenerateColumns = False
        DataGridViewCellStyle3.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = Wisej.Web.DataGridViewTriState.[True]
        Me.DGVGiros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVGiros.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVGiros.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.Eliminar, Me.DGVGCLAVE, Me.DGVGGIRO})
        Me.DGVGiros.DataSource = Me.BindingSource1
        Me.DGVGiros.Dock = Wisej.Web.DockStyle.Fill
        Me.DGVGiros.Location = New System.Drawing.Point(0, 248)
        Me.DGVGiros.Name = "DGVGiros"
        Me.DGVGiros.RowHeadersVisible = False
        Me.DGVGiros.Size = New System.Drawing.Size(918, 275)
        Me.DGVGiros.TabIndex = 4
        '
        'Eliminar
        '
        Me.Eliminar.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        DataGridViewCellStyle4.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        DataGridViewCellStyle4.BackgroundImageSource = "Resources/Icons/Menu/delete-bin.png"
        Me.Eliminar.DefaultCellStyle = DataGridViewCellStyle4
        Me.Eliminar.HeaderText = " "
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = Wisej.Web.DataGridViewTriState.[False]
        Me.Eliminar.ValueType = GetType(String)
        Me.Eliminar.Width = 25
        '
        'DGVGCLAVE
        '
        Me.DGVGCLAVE.DataPropertyName = "CVE_GIRO"
        Me.DGVGCLAVE.HeaderText = "Clave"
        Me.DGVGCLAVE.MinimumWidth = 100
        Me.DGVGCLAVE.Name = "DGVGCLAVE"
        Me.DGVGCLAVE.ReadOnly = True
        Me.DGVGCLAVE.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVGCLAVE.ValueType = GetType(Integer)
        '
        'DGVGGIRO
        '
        Me.DGVGGIRO.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DGVGGIRO.DataPropertyName = "NOMBRE"
        Me.DGVGGIRO.HeaderText = "Giro"
        Me.DGVGGIRO.MinimumWidth = 300
        Me.DGVGGIRO.Name = "DGVGGIRO"
        Me.DGVGGIRO.ReadOnly = True
        Me.DGVGGIRO.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DGVGGIRO.ValueType = GetType(String)
        Me.DGVGGIRO.Width = 300
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "pCAT_GIROS_B"
        Me.BindingSource1.DataSource = Me.DataSet_pCAT_GIROS_B
        '
        'DataSet_pCAT_GIROS_B
        '
        Me.DataSet_pCAT_GIROS_B.DataSetName = "DataSet_pCAT_GIROS_B"
        Me.DataSet_pCAT_GIROS_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Dock = Wisej.Web.DockStyle.Top
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.Menu)
        Me.RibbonBar1.Size = New System.Drawing.Size(918, 145)
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
        Me.FiltroGrillaSax1.Dock = Wisej.Web.DockStyle.Top
        Me.FiltroGrillaSax1.Location = New System.Drawing.Point(0, 208)
        Me.FiltroGrillaSax1.meBackcolorEtiquetas = System.Drawing.Color.AliceBlue
        Me.FiltroGrillaSax1.meBorderStyleEtiquetas = Wisej.Web.BorderStyle.Solid
        Me.FiltroGrillaSax1.meBorderWidthEtiquetas = 1
        Me.FiltroGrillaSax1.meDatagrid = Nothing
        Me.FiltroGrillaSax1.meFiltrarVacios = False
        Me.FiltroGrillaSax1.meLanzarException = False
        Me.FiltroGrillaSax1.meMarginEtiquetas = New Wisej.Web.Padding(1)
        Me.FiltroGrillaSax1.mePaddingEtiquetas = New Wisej.Web.Padding(2)
        Me.FiltroGrillaSax1.Name = "FiltroGrillaSax1"
        Me.FiltroGrillaSax1.Size = New System.Drawing.Size(918, 40)
        Me.FiltroGrillaSax1.TabIndex = 3
        '
        'RBDesactivado
        '
        Me.RBDesactivado.Location = New System.Drawing.Point(800, 27)
        Me.RBDesactivado.Name = "RBDesactivado"
        Me.RBDesactivado.Size = New System.Drawing.Size(100, 23)
        Me.RBDesactivado.TabIndex = 12
        Me.RBDesactivado.TabStop = False
        Me.RBDesactivado.Text = "Desactivado"
        '
        'RBHabilitado
        '
        Me.RBHabilitado.Checked = True
        Me.RBHabilitado.Location = New System.Drawing.Point(698, 27)
        Me.RBHabilitado.Name = "RBHabilitado"
        Me.RBHabilitado.Size = New System.Drawing.Size(85, 23)
        Me.RBHabilitado.TabIndex = 11
        Me.RBHabilitado.Text = "Habilitado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(273, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Giro:"
        '
        'TXTGiro
        '
        Me.TXTGiro.Location = New System.Drawing.Point(312, 24)
        Me.TXTGiro.Name = "TXTGiro"
        Me.TXTGiro.Size = New System.Drawing.Size(353, 22)
        Me.TXTGiro.TabIndex = 2
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
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Clave Giro:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RBHabilitado)
        Me.Panel1.Controls.Add(Me.RBDesactivado)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TXTGiro)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TXTClave)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 145)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.ShowCloseButton = True
        Me.Panel1.Size = New System.Drawing.Size(918, 63)
        Me.Panel1.TabIndex = 5
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
        Me.BindingNavigator1.Size = New System.Drawing.Size(918, 33)
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
        'Cat_Giros
        '
        Me.ClientSize = New System.Drawing.Size(918, 556)
        Me.Controls.Add(Me.DGVGiros)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.FiltroGrillaSax1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Cat_Giros"
        Me.Text = "Cat Giros"
        Me.WindowState = Wisej.Web.FormWindowState.Maximized
        CType(Me.DGVGiros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCAT_GIROS_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVGiros As DataGridView
    Friend WithEvents RibbonBar1 As RibbonBar
    Friend WithEvents Menu As RibbonBarPage
    Friend WithEvents Opciones As RibbonBarGroup
    Friend WithEvents RBNNUEVO As RibbonBarItemButton
    Friend WithEvents RBNSALIR As RibbonBarItemButton
    Friend WithEvents FiltroGrillaSax1 As filtroGrillaSax
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTGiro As TextBox
    Friend WithEvents TXTClave As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents RBNACTUALIZAR As RibbonBarItemButton
    Friend WithEvents RBNGUARDAR As RibbonBarItemButton
    Friend WithEvents DataSet_pCAT_GIROS_B As DataSet_pCAT_GIROS_B
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
    Private WithEvents DGVGCLAVE As DataGridViewTextBoxColumn
    Private WithEvents DGVGGIRO As DataGridViewTextBoxColumn
End Class
