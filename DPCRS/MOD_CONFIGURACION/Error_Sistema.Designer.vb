Imports Wisej.Web.Ext.RibbonBar
Imports Wisej.Web

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Error_Sistema
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
        Dim DataGridViewCellStyle1 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBBACTUALIZAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBSALIR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pERROR_SISTEMA = New DPCRS.DataSet_pERROR_SISTEMA_B()
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
        Me.DGVError = New Wisej.Web.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New Wisej.Web.DataGridViewTextBoxColumn()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pERROR_SISTEMA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.DGVError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Dock = Wisej.Web.DockStyle.Top
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(1501, 145)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Text = "Menú"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.RBBACTUALIZAR)
        Me.RibbonBarGroup1.Items.Add(Me.RBBSALIR)
        '
        'RBBACTUALIZAR
        '
        Me.RBBACTUALIZAR.ImageSource = "icon-redo?color=#006EFF"
        Me.RBBACTUALIZAR.Name = "RBBACTUALIZAR"
        Me.RBBACTUALIZAR.Text = "Actualizar"
        '
        'RBBSALIR
        '
        Me.RBBSALIR.ImageSource = "Resources/Images/Menu/30/exit-sign-red.png?color=#0000FF"
        Me.RBBSALIR.Name = "RBBSALIR"
        Me.RBBSALIR.Text = "Salir"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "pERROR_SISTEMA_B"
        Me.BindingSource1.DataSource = Me.DataSet_pERROR_SISTEMA
        '
        'DataSet_pERROR_SISTEMA
        '
        Me.DataSet_pERROR_SISTEMA.DataSetName = "DataSet_pERROR_SISTEMA"
        Me.DataSet_pERROR_SISTEMA.EnforceConstraints = False
        Me.DataSet_pERROR_SISTEMA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 544)
        Me.BindingNavigator1.MoveFirstItem = Me.buttonMoveFirst
        Me.BindingNavigator1.MoveLastItem = Me.buttonMoveLast
        Me.BindingNavigator1.MoveNextItem = Me.buttonMoveNext
        Me.BindingNavigator1.MovePreviousItem = Me.buttonMovePrevious
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.textBoxPosition
        Me.BindingNavigator1.Size = New System.Drawing.Size(1501, 34)
        Me.BindingNavigator1.TabIndex = 15
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
        Me.FiltroGrillaSax1.Size = New System.Drawing.Size(1501, 40)
        Me.FiltroGrillaSax1.TabIndex = 3
        '
        'DGVError
        '
        Me.DGVError.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = Wisej.Web.DataGridViewTriState.[True]
        Me.DGVError.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVError.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.DGVError.DataSource = Me.BindingSource1
        Me.DGVError.Dock = Wisej.Web.DockStyle.Fill
        Me.DGVError.Location = New System.Drawing.Point(0, 145)
        Me.DGVError.Name = "DGVError"
        Me.DGVError.ResizableEdges = CType((((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.DGVError.RowHeadersVisible = False
        Me.DGVError.RowHeadersWidthSizeMode = Wisej.Web.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGVError.RowTemplate.Height = 30
        Me.DGVError.Size = New System.Drawing.Size(1501, 399)
        Me.DGVError.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CVE_ERROR"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cve. Error"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ERROR"
        Me.DataGridViewTextBoxColumn3.FillWeight = 900.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Error"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 900
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PROCESO"
        Me.DataGridViewTextBoxColumn5.FillWeight = 150.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Proceso"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "OPERADOR"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Operador"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MODULO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Modulo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "FORMULARIO"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Formulario"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FECHA"
        Me.DataGridViewTextBoxColumn7.FillWeight = 200.0!
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 200
        '
        'Error_Sistema
        '
        Me.ClientSize = New System.Drawing.Size(1501, 578)
        Me.Controls.Add(Me.FiltroGrillaSax1)
        Me.Controls.Add(Me.DGVError)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Error_Sistema"
        Me.Text = "Error_Sistema"
        Me.WindowState = Wisej.Web.FormWindowState.Maximized
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pERROR_SISTEMA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        CType(Me.DGVError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonBar1 As RibbonBar
    Friend WithEvents RibbonBarPage1 As RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As RibbonBarGroup
    Friend WithEvents RBBSALIR As RibbonBarItemButton
    Friend WithEvents DGVError As Wisej.Web.DataGridView
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataSet_pERROR_SISTEMA As DataSet_pERROR_SISTEMA_B
    Friend WithEvents RBBACTUALIZAR As RibbonBarItemButton
    Friend WithEvents FiltroGrillaSax1 As filtroGrillaSax
    Private WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Private WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Private WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Private WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Private WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Private WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Private WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
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
End Class
