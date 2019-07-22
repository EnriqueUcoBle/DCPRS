<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cat_juridicciones_get
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
        Dim Panel1 As Wisej.Web.Panel
        Me.TextBoxCVE_JURISDICCION = New Wisej.Web.TextBox()
        Me.CheckBoxHABILITADO = New Wisej.Web.CheckBox()
        Me.Label6 = New Wisej.Web.Label()
        Me.TextBoxCP = New Wisej.Web.TextBox()
        Me.Label5 = New Wisej.Web.Label()
        Me.Label4 = New Wisej.Web.Label()
        Me.Label3 = New Wisej.Web.Label()
        Me.Label2 = New Wisej.Web.Label()
        Me.Label1 = New Wisej.Web.Label()
        Me.TextBoxTELEFONO = New Wisej.Web.TextBox()
        Me.TextBoxCLAVE = New Wisej.Web.TextBox()
        Me.TextBoxDIRECCION = New Wisej.Web.TextBox()
        Me.ComboBoxCOLONIA = New Wisej.Web.ComboBox()
        Me.ComboBoxMUNICIPIO = New Wisej.Web.ComboBox()
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RRBnuevo = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RRBcancelar = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RRBguardar = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RRBactualizar = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RRBsalir = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.ErrorProvider1 = New Wisej.Web.ErrorProvider(Me.components)
        Me.DataSetJURIDICCIONBindingSource = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_JURIDICCION = New DPCRS.DataSet_JURIDICCION()
        Me.FiltroGrillaSax1 = New DPCRS.filtroGrillaSax()
        Me.DataGridView1 = New Wisej.Web.DataGridView()
        Me.colJURISDICCION = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colASENTAMIENTO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colTIPO_ASENTAMIENTO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colTEL = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colCLAVE = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colDISPONIBLE = New Wisej.Web.DataGridViewCheckBoxColumn()
        Me.colDIRECCION = New Wisej.Web.DataGridViewTextBoxColumn()
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
        Panel1 = New Wisej.Web.Panel()
        Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetJURIDICCIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_JURIDICCION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataGridView1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Panel1.Controls.Add(Me.TextBoxCVE_JURISDICCION)
        Panel1.Controls.Add(Me.CheckBoxHABILITADO)
        Panel1.Controls.Add(Me.Label6)
        Panel1.Controls.Add(Me.TextBoxCP)
        Panel1.Controls.Add(Me.Label5)
        Panel1.Controls.Add(Me.Label4)
        Panel1.Controls.Add(Me.Label3)
        Panel1.Controls.Add(Me.Label2)
        Panel1.Controls.Add(Me.Label1)
        Panel1.Controls.Add(Me.TextBoxTELEFONO)
        Panel1.Controls.Add(Me.TextBoxCLAVE)
        Panel1.Controls.Add(Me.TextBoxDIRECCION)
        Panel1.Controls.Add(Me.ComboBoxCOLONIA)
        Panel1.Controls.Add(Me.ComboBoxMUNICIPIO)
        Panel1.Location = New System.Drawing.Point(4, 109)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(1129, 104)
        Panel1.TabIndex = 17
        '
        'TextBoxCVE_JURISDICCION
        '
        Me.TextBoxCVE_JURISDICCION.Location = New System.Drawing.Point(292, 48)
        Me.TextBoxCVE_JURISDICCION.Name = "TextBoxCVE_JURISDICCION"
        Me.TextBoxCVE_JURISDICCION.Size = New System.Drawing.Size(34, 22)
        Me.TextBoxCVE_JURISDICCION.TabIndex = 5
        Me.TextBoxCVE_JURISDICCION.Visible = False
        '
        'CheckBoxHABILITADO
        '
        Me.CheckBoxHABILITADO.Location = New System.Drawing.Point(740, 73)
        Me.CheckBoxHABILITADO.Name = "CheckBoxHABILITADO"
        Me.CheckBoxHABILITADO.ReadOnly = True
        Me.CheckBoxHABILITADO.Size = New System.Drawing.Size(158, 23)
        Me.CheckBoxHABILITADO.TabIndex = 12
        Me.CheckBoxHABILITADO.Text = "Disponible (habilitado)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("default, Arial Black", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label6.Location = New System.Drawing.Point(9, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Codigo Postal:"
        '
        'TextBoxCP
        '
        Me.TextBoxCP.Location = New System.Drawing.Point(113, 78)
        Me.TextBoxCP.Name = "TextBoxCP"
        Me.TextBoxCP.ReadOnly = True
        Me.TextBoxCP.Size = New System.Drawing.Size(163, 22)
        Me.TextBoxCP.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("default, Arial Black", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label5.Location = New System.Drawing.Point(643, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Telefono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("default, Arial Black", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label4.Location = New System.Drawing.Point(643, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Clave:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("default, Arial Black", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.Location = New System.Drawing.Point(292, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Direccion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("default, Arial Black", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label2.Location = New System.Drawing.Point(9, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Colonia:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("default, Arial Black", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Municipio:"
        '
        'TextBoxTELEFONO
        '
        Me.TextBoxTELEFONO.Location = New System.Drawing.Point(740, 45)
        Me.TextBoxTELEFONO.Name = "TextBoxTELEFONO"
        Me.TextBoxTELEFONO.ReadOnly = True
        Me.TextBoxTELEFONO.Size = New System.Drawing.Size(157, 22)
        Me.TextBoxTELEFONO.TabIndex = 4
        '
        'TextBoxCLAVE
        '
        Me.TextBoxCLAVE.Location = New System.Drawing.Point(740, 9)
        Me.TextBoxCLAVE.Name = "TextBoxCLAVE"
        Me.TextBoxCLAVE.ReadOnly = True
        Me.TextBoxCLAVE.Size = New System.Drawing.Size(157, 22)
        Me.TextBoxCLAVE.TabIndex = 3
        '
        'TextBoxDIRECCION
        '
        Me.TextBoxDIRECCION.Location = New System.Drawing.Point(377, 9)
        Me.TextBoxDIRECCION.Multiline = True
        Me.TextBoxDIRECCION.Name = "TextBoxDIRECCION"
        Me.TextBoxDIRECCION.ReadOnly = True
        Me.TextBoxDIRECCION.Size = New System.Drawing.Size(238, 88)
        Me.TextBoxDIRECCION.TabIndex = 2
        '
        'ComboBoxCOLONIA
        '
        Me.ComboBoxCOLONIA.Location = New System.Drawing.Point(113, 44)
        Me.ComboBoxCOLONIA.Name = "ComboBoxCOLONIA"
        Me.ComboBoxCOLONIA.ReadOnly = True
        Me.ComboBoxCOLONIA.Size = New System.Drawing.Size(163, 22)
        Me.ComboBoxCOLONIA.TabIndex = 1
        '
        'ComboBoxMUNICIPIO
        '
        Me.ComboBoxMUNICIPIO.Items.AddRange(New Object() {"Balancán", "Cárdenas", "Centla", "Centro", "Comalcalco", "Cunduacán", "Emiliano Zapata", "Huimanguillo", "Jalapa", "Jalpa de Méndez", "Jonuta", "Macuspana", "Nacajuca", "Paraíso", "Tacotalpa", "Teapa", "Tenosique"})
        Me.ComboBoxMUNICIPIO.Location = New System.Drawing.Point(113, 9)
        Me.ComboBoxMUNICIPIO.Name = "ComboBoxMUNICIPIO"
        Me.ComboBoxMUNICIPIO.ReadOnly = True
        Me.ComboBoxMUNICIPIO.Size = New System.Drawing.Size(163, 22)
        Me.ComboBoxMUNICIPIO.TabIndex = 0
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Dock = Wisej.Web.DockStyle.Top
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(1130, 262)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Text = "Acciones"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.RRBnuevo)
        Me.RibbonBarGroup1.Items.Add(Me.RRBcancelar)
        Me.RibbonBarGroup1.Items.Add(Me.RRBguardar)
        Me.RibbonBarGroup1.Items.Add(Me.RRBactualizar)
        Me.RibbonBarGroup1.Items.Add(Me.RRBsalir)
        '
        'RRBnuevo
        '
        Me.RRBnuevo.ImageSource = "Resources\Icons\Menu\add.png"
        Me.RRBnuevo.Name = "RRBnuevo"
        Me.RRBnuevo.Text = "Nuevo"
        '
        'RRBcancelar
        '
        Me.RRBcancelar.ImageSource = "Resources\Icons\Menu\error_blue.png"
        Me.RRBcancelar.Name = "RRBcancelar"
        Me.RRBcancelar.Text = "Cancelar"
        '
        'RRBguardar
        '
        Me.RRBguardar.ImageSource = "Resources\Icons\Menu\add-file.png"
        Me.RRBguardar.Name = "RRBguardar"
        Me.RRBguardar.Text = "Guardar"
        Me.RRBguardar.Visible = False
        '
        'RRBactualizar
        '
        Me.RRBactualizar.ImageSource = "Resources\Icons\Menu\refresh.png"
        Me.RRBactualizar.Name = "RRBactualizar"
        Me.RRBactualizar.Text = "Actualizar"
        '
        'RRBsalir
        '
        Me.RRBsalir.ImageSource = "Resources\Icons\Menu\exit-sign.png"
        Me.RRBsalir.Name = "RRBsalir"
        Me.RRBsalir.Text = "Salir"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 3
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DataSetJURIDICCIONBindingSource
        '
        Me.DataSetJURIDICCIONBindingSource.DataSource = Me.DataSet_JURIDICCION
        Me.DataSetJURIDICCIONBindingSource.Position = 0
        '
        'DataSet_JURIDICCION
        '
        Me.DataSet_JURIDICCION.DataSetName = "DataSet_JURIDICCION"
        Me.DataSet_JURIDICCION.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FiltroGrillaSax1
        '
        Me.FiltroGrillaSax1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.FiltroGrillaSax1.BackColor = System.Drawing.Color.Transparent
        Me.FiltroGrillaSax1.Location = New System.Drawing.Point(3, 219)
        Me.FiltroGrillaSax1.meBackcolorEtiquetas = System.Drawing.Color.AliceBlue
        Me.FiltroGrillaSax1.meBorderStyleEtiquetas = Wisej.Web.BorderStyle.Solid
        Me.FiltroGrillaSax1.meBorderWidthEtiquetas = 1
        Me.FiltroGrillaSax1.meDatagrid = Nothing
        Me.FiltroGrillaSax1.meFiltrarVacios = False
        Me.FiltroGrillaSax1.meLanzarException = False
        Me.FiltroGrillaSax1.meMarginEtiquetas = New Wisej.Web.Padding(1)
        Me.FiltroGrillaSax1.mePaddingEtiquetas = New Wisej.Web.Padding(2)
        Me.FiltroGrillaSax1.Name = "FiltroGrillaSax1"
        Me.FiltroGrillaSax1.Size = New System.Drawing.Size(1124, 37)
        Me.FiltroGrillaSax1.TabIndex = 15
        '
        'DataGridView1
        '
        Me.DataGridView1.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.colJURISDICCION, Me.colASENTAMIENTO, Me.colTIPO_ASENTAMIENTO, Me.colTEL, Me.colCLAVE, Me.colDISPONIBLE, Me.colDIRECCION})
        Me.DataGridView1.Controls.Add(Me.BindingNavigator1)
        Me.DataGridView1.DataMember = "pCAT_JURISDICCION_B"
        Me.DataGridView1.DataSource = Me.DataSetJURIDICCIONBindingSource
        Me.DataGridView1.Dock = Wisej.Web.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 262)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1130, 416)
        Me.DataGridView1.TabIndex = 13
        '
        'colJURISDICCION
        '
        Me.colJURISDICCION.DataPropertyName = "JURISDICCION"
        Me.colJURISDICCION.HeaderText = "JURISDICCION"
        Me.colJURISDICCION.Name = "colJURISDICCION"
        Me.colJURISDICCION.Width = 150
        '
        'colASENTAMIENTO
        '
        Me.colASENTAMIENTO.DataPropertyName = "ASENTAMIENTO"
        Me.colASENTAMIENTO.HeaderText = "ASENTAMIENTO"
        Me.colASENTAMIENTO.Name = "colASENTAMIENTO"
        Me.colASENTAMIENTO.Width = 150
        '
        'colTIPO_ASENTAMIENTO
        '
        Me.colTIPO_ASENTAMIENTO.DataPropertyName = "TIPO_ASENTAMIENTO"
        Me.colTIPO_ASENTAMIENTO.HeaderText = "TIPO_ASENTAMIENTO"
        Me.colTIPO_ASENTAMIENTO.Name = "colTIPO_ASENTAMIENTO"
        '
        'colTEL
        '
        Me.colTEL.DataPropertyName = "TEL"
        Me.colTEL.HeaderText = "TEL"
        Me.colTEL.Name = "colTEL"
        '
        'colCLAVE
        '
        Me.colCLAVE.DataPropertyName = "CLAVE"
        Me.colCLAVE.HeaderText = "CLAVE"
        Me.colCLAVE.Name = "colCLAVE"
        '
        'colDISPONIBLE
        '
        Me.colDISPONIBLE.DataPropertyName = "DISPONIBLE"
        Me.colDISPONIBLE.HeaderText = "DISPONIBLE"
        Me.colDISPONIBLE.Name = "colDISPONIBLE"
        '
        'colDIRECCION
        '
        Me.colDIRECCION.DataPropertyName = "DIRECCION"
        Me.colDIRECCION.HeaderText = "DIRECCION"
        Me.colDIRECCION.Name = "colDIRECCION"
        Me.colDIRECCION.Width = 500
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
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 376)
        Me.BindingNavigator1.MoveFirstItem = Me.buttonMoveFirst
        Me.BindingNavigator1.MoveLastItem = Me.buttonMoveLast
        Me.BindingNavigator1.MoveNextItem = Me.buttonMoveNext
        Me.BindingNavigator1.MovePreviousItem = Me.buttonMovePrevious
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.textBoxPosition
        Me.BindingNavigator1.Size = New System.Drawing.Size(1128, 38)
        Me.BindingNavigator1.TabIndex = 0
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
        'Cat_juridicciones_get
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 678)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Panel1)
        Me.Controls.Add(Me.FiltroGrillaSax1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.MaximizeBox = False
        Me.Name = "Cat_juridicciones_get"
        Me.Text = "Jurisdicciones"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetJURIDICCIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_JURIDICCION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataGridView1.ResumeLayout(False)
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonBar1 As Wisej.Web.Ext.RibbonBar.RibbonBar
    Friend WithEvents RibbonBarPage1 As Wisej.Web.Ext.RibbonBar.RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As Wisej.Web.Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents RRBnuevo As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RRBactualizar As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RRBsalir As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents ErrorProvider1 As Wisej.Web.ErrorProvider
    Friend WithEvents RRBguardar As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RRBcancelar As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents FiltroGrillaSax1 As filtroGrillaSax
    Friend WithEvents TextBoxCVE_JURISDICCION As Wisej.Web.TextBox
    Friend WithEvents CheckBoxHABILITADO As Wisej.Web.CheckBox
    Friend WithEvents Label6 As Wisej.Web.Label
    Friend WithEvents TextBoxCP As Wisej.Web.TextBox
    Friend WithEvents Label5 As Wisej.Web.Label
    Friend WithEvents Label4 As Wisej.Web.Label
    Friend WithEvents Label3 As Wisej.Web.Label
    Friend WithEvents Label2 As Wisej.Web.Label
    Friend WithEvents Label1 As Wisej.Web.Label
    Friend WithEvents TextBoxTELEFONO As Wisej.Web.TextBox
    Friend WithEvents TextBoxCLAVE As Wisej.Web.TextBox
    Friend WithEvents TextBoxDIRECCION As Wisej.Web.TextBox
    Friend WithEvents ComboBoxCOLONIA As Wisej.Web.ComboBox
    Friend WithEvents ComboBoxMUNICIPIO As Wisej.Web.ComboBox
    Friend WithEvents DataSetJURIDICCIONBindingSource As Wisej.Web.BindingSource
    Friend WithEvents DataSet_JURIDICCION As DataSet_JURIDICCION
    Friend WithEvents DataGridView1 As Wisej.Web.DataGridView
    Friend WithEvents colJURISDICCION As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colASENTAMIENTO As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colTIPO_ASENTAMIENTO As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colTEL As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colCLAVE As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colDISPONIBLE As Wisej.Web.DataGridViewCheckBoxColumn
    Friend WithEvents colDIRECCION As Wisej.Web.DataGridViewTextBoxColumn
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
End Class
