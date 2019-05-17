<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Estado_de_Quejas
    Inherits Wisej.Web.Form

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Dim DataGridViewCellStyle1 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.Salir = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.BDN = New Wisej.Web.BindingNavigator(Me.components)
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
        Me.DGVOperadores = New Wisej.Web.DataGridView()
        Me.colID = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colJURISDICCION = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colPROPIETARIO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colGIRO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colDIRECCION = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colOBSERVACIONES = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colSTATUS = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataSetpCATQUEJASPBindingSource = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pCAT_QUEJAS_P = New DPCRS.DataSet_pCAT_QUEJAS_P()
        CType(Me.BDN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BDN.SuspendLayout()
        CType(Me.DGVOperadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DGVOperadores.SuspendLayout()
        CType(Me.DataSetpCATQUEJASPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCAT_QUEJAS_P, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Dock = Wisej.Web.DockStyle.Top
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(888, 126)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Text = "Acciones"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.Salir)
        '
        'Salir
        '
        Me.Salir.ImageSource = "ribbon-delete?color=#0000FF<<<"
        Me.Salir.Name = "Salir"
        Me.Salir.Text = "Salir"
        '
        'BDN
        '
        Me.BDN.AddNewItem = Me.buttonAddNew
        Me.BDN.Controls.Add(Me.buttonMoveFirst)
        Me.BDN.Controls.Add(Me.buttonMovePrevious)
        Me.BDN.Controls.Add(Me.separatorLeft)
        Me.BDN.Controls.Add(Me.textBoxPosition)
        Me.BDN.Controls.Add(Me.labelCount)
        Me.BDN.Controls.Add(Me.separatorRight)
        Me.BDN.Controls.Add(Me.buttonMoveNext)
        Me.BDN.Controls.Add(Me.buttonMoveLast)
        Me.BDN.Controls.Add(Me.separatorControl)
        Me.BDN.Controls.Add(Me.buttonAddNew)
        Me.BDN.Controls.Add(Me.buttonDelete)
        Me.BDN.CountItem = Me.labelCount
        Me.BDN.DeleteItem = Me.buttonDelete
        Me.BDN.Dock = Wisej.Web.DockStyle.Bottom
        Me.BDN.Location = New System.Drawing.Point(0, 599)
        Me.BDN.MoveFirstItem = Me.buttonMoveFirst
        Me.BDN.MoveLastItem = Me.buttonMoveLast
        Me.BDN.MoveNextItem = Me.buttonMoveNext
        Me.BDN.MovePreviousItem = Me.buttonMovePrevious
        Me.BDN.Name = "BDN"
        Me.BDN.PositionItem = Me.textBoxPosition
        Me.BDN.Size = New System.Drawing.Size(886, 34)
        Me.BDN.TabIndex = 2
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
        'DGVOperadores
        '
        Me.DGVOperadores.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = Wisej.Web.DataGridViewTriState.[True]
        Me.DGVOperadores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVOperadores.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOperadores.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.colID, Me.colJURISDICCION, Me.colPROPIETARIO, Me.colGIRO, Me.colDIRECCION, Me.colSTATUS, Me.colOBSERVACIONES})
        Me.DGVOperadores.Controls.Add(Me.BDN)
        Me.DGVOperadores.DataMember = "pCAT_QUEJAS_B"
        Me.DGVOperadores.DataSource = Me.DataSetpCATQUEJASPBindingSource
        Me.DGVOperadores.Dock = Wisej.Web.DockStyle.Fill
        Me.DGVOperadores.Location = New System.Drawing.Point(0, 126)
        Me.DGVOperadores.Name = "DGVOperadores"
        Me.DGVOperadores.RowHeadersVisible = False
        Me.DGVOperadores.Size = New System.Drawing.Size(888, 635)
        Me.DGVOperadores.TabIndex = 2
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        '
        'colJURISDICCION
        '
        Me.colJURISDICCION.DataPropertyName = "JURISDICCION"
        Me.colJURISDICCION.HeaderText = "JURISDICCION"
        Me.colJURISDICCION.Name = "colJURISDICCION"
        '
        'colPROPIETARIO
        '
        Me.colPROPIETARIO.DataPropertyName = "PROPIETARIO"
        Me.colPROPIETARIO.HeaderText = "PROPIETARIO"
        Me.colPROPIETARIO.Name = "colPROPIETARIO"
        '
        'colGIRO
        '
        Me.colGIRO.DataPropertyName = "GIRO"
        Me.colGIRO.HeaderText = "GIRO"
        Me.colGIRO.Name = "colGIRO"
        '
        'colDIRECCION
        '
        Me.colDIRECCION.DataPropertyName = "DIRECCION"
        Me.colDIRECCION.HeaderText = "DIRECCION"
        Me.colDIRECCION.Name = "colDIRECCION"
        '
        'colOBSERVACIONES
        '
        Me.colOBSERVACIONES.DataPropertyName = "OBSERVACIONES"
        Me.colOBSERVACIONES.HeaderText = "QUEJA"
        Me.colOBSERVACIONES.MinimumWidth = 200
        Me.colOBSERVACIONES.Name = "colOBSERVACIONES"
        Me.colOBSERVACIONES.Width = 500
        '
        'colSTATUS
        '
        Me.colSTATUS.DataPropertyName = "STATUS"
        Me.colSTATUS.HeaderText = "STATUS"
        Me.colSTATUS.Name = "colSTATUS"
        '
        'DataSetpCATQUEJASPBindingSource
        '
        Me.DataSetpCATQUEJASPBindingSource.DataSource = Me.DataSet_pCAT_QUEJAS_P
        Me.DataSetpCATQUEJASPBindingSource.Position = 0
        '
        'DataSet_pCAT_QUEJAS_P
        '
        Me.DataSet_pCAT_QUEJAS_P.DataSetName = "DataSet_pCAT_QUEJAS_P"
        Me.DataSet_pCAT_QUEJAS_P.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Estado_de_Quejas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 761)
        Me.Controls.Add(Me.DGVOperadores)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Estado_de_Quejas"
        Me.Text = "Estado_de_Quejas"
        CType(Me.BDN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BDN.ResumeLayout(False)
        CType(Me.DGVOperadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DGVOperadores.ResumeLayout(False)
        CType(Me.DataSetpCATQUEJASPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCAT_QUEJAS_P, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonBar1 As Wisej.Web.Ext.RibbonBar.RibbonBar
    Friend WithEvents RibbonBarPage1 As Wisej.Web.Ext.RibbonBar.RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As Wisej.Web.Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents Salir As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents BDN As Wisej.Web.BindingNavigator
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
    Friend WithEvents DGVOperadores As Wisej.Web.DataGridView
    Friend WithEvents colID As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colJURISDICCION As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colPROPIETARIO As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colGIRO As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colDIRECCION As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colOBSERVACIONES As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colSTATUS As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents DataSetpCATQUEJASPBindingSource As Wisej.Web.BindingSource
    Friend WithEvents DataSet_pCAT_QUEJAS_P As DataSet_pCAT_QUEJAS_P
End Class
