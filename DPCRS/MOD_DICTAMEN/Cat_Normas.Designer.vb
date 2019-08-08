<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cat_Normas
    Inherits Wisej.Web.Form

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Wisej Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Wisej Designer
    'It can be modified using the Wisej Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ComponentTool1 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.rbNuevo = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.rbActualizar = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.rbSalir = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Panel1 = New Wisej.Web.Panel()
        Me.DGVNormas = New Wisej.Web.DataGridView()
        Me.Desabilitar = New Wisej.Web.DataGridViewImageColumn()
        Me.colEditar = New Wisej.Web.DataGridViewImageColumn()
        Me.CVE_NORMAS = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.NORMA = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DESCRIPCION = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.HABILITADO = New Wisej.Web.DataGridViewCheckBoxColumn()
        Me.DataSetpCATNORMASBBindingSource = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pCAT_NORMAS_B = New DPCRS.DataSet_pCAT_NORMAS_B()
        Me.Estatus = New Wisej.Web.GroupBox()
        Me.RadioButton2 = New Wisej.Web.RadioButton()
        Me.RadioButton1 = New Wisej.Web.RadioButton()
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
        Me.Eliminar = New Wisej.Web.DataGridViewImageColumn()
        Me.FiltroGrillaSax1 = New DPCRS.filtroGrillaSax()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVNormas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetpCATNORMASBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCAT_NORMAS_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Estatus.SuspendLayout()
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
        Me.RibbonBar1.Size = New System.Drawing.Size(990, 114)
        ComponentTool1.ImageSource = "menu-overflow"
        ComponentTool1.ToolTipText = "zzz"
        Me.RibbonBar1.Tools.AddRange(New Wisej.Web.ComponentTool() {ComponentTool1})
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Text = "Menú"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.rbNuevo)
        Me.RibbonBarGroup1.Items.Add(Me.rbActualizar)
        Me.RibbonBarGroup1.Items.Add(Me.rbSalir)
        Me.RibbonBarGroup1.Text = "Opciones"
        '
        'rbNuevo
        '
        Me.rbNuevo.ImageSource = "ribbon-add-file"
        Me.rbNuevo.Name = "rbNuevo"
        Me.rbNuevo.Text = "Nuevo"
        '
        'rbActualizar
        '
        Me.rbActualizar.ImageSource = "Resources\Icons\Menu\undo-retorno-relleno.png"
        Me.rbActualizar.Name = "rbActualizar"
        Me.rbActualizar.Text = "Actualizar"
        '
        'rbSalir
        '
        Me.rbSalir.ImageSource = "Resources\Images\Menu\30\exit-sign-red.png"
        Me.rbSalir.Name = "rbSalir"
        Me.rbSalir.Text = "Salir"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FiltroGrillaSax1)
        Me.Panel1.Controls.Add(Me.DGVNormas)
        Me.Panel1.Controls.Add(Me.Estatus)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(990, 431)
        Me.Panel1.TabIndex = 2
        '
        'DGVNormas
        '
        Me.DGVNormas.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.Desabilitar, Me.colEditar, Me.Eliminar, Me.CVE_NORMAS, Me.NORMA, Me.DESCRIPCION, Me.HABILITADO})
        Me.DGVNormas.DataMember = "pCAT_NORMAS_B"
        Me.DGVNormas.DataSource = Me.DataSetpCATNORMASBBindingSource
        Me.DGVNormas.Dock = Wisej.Web.DockStyle.Bottom
        Me.DGVNormas.Location = New System.Drawing.Point(0, 100)
        Me.DGVNormas.Name = "DGVNormas"
        Me.DGVNormas.Size = New System.Drawing.Size(990, 331)
        Me.DGVNormas.TabIndex = 1
        '
        'Desabilitar
        '
        Me.Desabilitar.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.Desabilitar.CellImageSource = ""
        Me.Desabilitar.Name = "Desabilitar"
        Me.Desabilitar.Width = 30
        '
        'colEditar
        '
        Me.colEditar.CellImage = Global.DPCRS.My.Resources.Resources.pencil_
        Me.colEditar.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.colEditar.Name = "colEditar"
        Me.colEditar.Width = 20
        '
        'CVE_NORMAS
        '
        Me.CVE_NORMAS.DataPropertyName = "CVE_NORMAS"
        Me.CVE_NORMAS.HeaderText = "CVE_NORMAS"
        Me.CVE_NORMAS.Name = "CVE_NORMAS"
        Me.CVE_NORMAS.ReadOnly = True
        '
        'NORMA
        '
        Me.NORMA.DataPropertyName = "NORMA"
        Me.NORMA.HeaderText = "NORMA"
        Me.NORMA.Name = "NORMA"
        Me.NORMA.Width = 200
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.DataPropertyName = "DESCRIPCION"
        Me.DESCRIPCION.HeaderText = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.Width = 500
        '
        'HABILITADO
        '
        Me.HABILITADO.DataPropertyName = "HABILITADO"
        Me.HABILITADO.HeaderText = "HABILITADO"
        Me.HABILITADO.Name = "HABILITADO"
        '
        'DataSetpCATNORMASBBindingSource
        '
        Me.DataSetpCATNORMASBBindingSource.DataSource = Me.DataSet_pCAT_NORMAS_B
        Me.DataSetpCATNORMASBBindingSource.Position = 0
        '
        'DataSet_pCAT_NORMAS_B
        '
        Me.DataSet_pCAT_NORMAS_B.DataSetName = "DataSet_pCAT_NORMAS_B"
        Me.DataSet_pCAT_NORMAS_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Estatus
        '
        Me.Estatus.Controls.Add(Me.RadioButton2)
        Me.Estatus.Controls.Add(Me.RadioButton1)
        Me.Estatus.Location = New System.Drawing.Point(699, 6)
        Me.Estatus.Name = "Estatus"
        Me.Estatus.Size = New System.Drawing.Size(211, 47)
        Me.Estatus.TabIndex = 2
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(97, 11)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(107, 23)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = False
        Me.RadioButton2.Text = "Deshabilitado"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(6, 11)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(85, 23)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = False
        Me.RadioButton1.Text = "Habilitado"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.buttonAddNew
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
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 549)
        Me.BindingNavigator1.MoveFirstItem = Me.buttonMoveFirst
        Me.BindingNavigator1.MoveLastItem = Me.buttonMoveLast
        Me.BindingNavigator1.MoveNextItem = Me.buttonMoveNext
        Me.BindingNavigator1.MovePreviousItem = Me.buttonMovePrevious
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.textBoxPosition
        Me.BindingNavigator1.Size = New System.Drawing.Size(990, 50)
        Me.BindingNavigator1.TabIndex = 2
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
        'Eliminar
        '
        Me.Eliminar.CellImage = Global.DPCRS.My.Resources.Resources.trash_
        Me.Eliminar.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Visible = False
        Me.Eliminar.Width = 20
        '
        'FiltroGrillaSax1
        '
        Me.FiltroGrillaSax1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.FiltroGrillaSax1.BackColor = System.Drawing.Color.Transparent
        Me.FiltroGrillaSax1.Location = New System.Drawing.Point(3, 6)
        Me.FiltroGrillaSax1.meBackcolorEtiquetas = System.Drawing.Color.AliceBlue
        Me.FiltroGrillaSax1.meBorderStyleEtiquetas = Wisej.Web.BorderStyle.Solid
        Me.FiltroGrillaSax1.meBorderWidthEtiquetas = 1
        Me.FiltroGrillaSax1.meDatagrid = Nothing
        Me.FiltroGrillaSax1.meFiltrarVacios = False
        Me.FiltroGrillaSax1.meLanzarException = False
        Me.FiltroGrillaSax1.meMarginEtiquetas = New Wisej.Web.Padding(1)
        Me.FiltroGrillaSax1.mePaddingEtiquetas = New Wisej.Web.Padding(2)
        Me.FiltroGrillaSax1.Name = "FiltroGrillaSax1"
        Me.FiltroGrillaSax1.Size = New System.Drawing.Size(610, 95)
        Me.FiltroGrillaSax1.TabIndex = 4
        '
        'Cat_Normas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 599)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Name = "Cat_Normas"
        Me.Text = "Normas"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGVNormas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetpCATNORMASBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCAT_NORMAS_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Estatus.ResumeLayout(False)
        Me.Estatus.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonBar1 As Wisej.Web.Ext.RibbonBar.RibbonBar
    Friend WithEvents RibbonBarPage1 As Wisej.Web.Ext.RibbonBar.RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As Wisej.Web.Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents rbNuevo As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents rbActualizar As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents rbSalir As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents Panel1 As Wisej.Web.Panel
    Friend WithEvents DGVNormas As Wisej.Web.DataGridView
    Friend WithEvents BindingNavigator1 As Wisej.Web.BindingNavigator
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
    Friend WithEvents CVE_NORMAS As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents NORMA As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents DataSetpCATNORMASBBindingSource As Wisej.Web.BindingSource
    Friend WithEvents DataSet_pCAT_NORMAS_B As DataSet_pCAT_NORMAS_B
    Friend WithEvents Desabilitar As Wisej.Web.DataGridViewImageColumn
    Friend WithEvents colEditar As Wisej.Web.DataGridViewImageColumn
    Friend WithEvents HABILITADO As Wisej.Web.DataGridViewCheckBoxColumn
    Friend WithEvents Estatus As Wisej.Web.GroupBox
    Friend WithEvents RadioButton2 As Wisej.Web.RadioButton
    Friend WithEvents RadioButton1 As Wisej.Web.RadioButton
    Friend WithEvents FiltroGrillaSax1 As filtroGrillaSax
    Friend WithEvents Eliminar As Wisej.Web.DataGridViewImageColumn
End Class
