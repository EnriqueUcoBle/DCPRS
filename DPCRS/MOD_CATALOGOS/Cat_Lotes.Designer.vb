<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cat_Lotes
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
        Dim DataGridViewCellStyle1 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.Menú = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RibbonBarItemButton1 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RibbonBarItemButton2 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.TableLayoutPanel1 = New Wisej.Web.TableLayoutPanel()
        Me.BNLotes = New Wisej.Web.BindingNavigator(Me.components)
        Me.Button1 = New Wisej.Web.Button()
        Me.Button2 = New Wisej.Web.Button()
        Me.Button3 = New Wisej.Web.Button()
        Me.Line1 = New Wisej.Web.Line()
        Me.TextBox1 = New Wisej.Web.TextBox()
        Me.Label1 = New Wisej.Web.Label()
        Me.Line2 = New Wisej.Web.Line()
        Me.Button4 = New Wisej.Web.Button()
        Me.Button5 = New Wisej.Web.Button()
        Me.Line3 = New Wisej.Web.Line()
        Me.Button6 = New Wisej.Web.Button()
        Me.BNActas = New Wisej.Web.BindingNavigator(Me.components)
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
        Me.FiltroGrillaSax2 = New DPCRS.filtroGrillaSax()
        Me.DGVLotes = New Wisej.Web.DataGridView()
        Me.Column0 = New Wisej.Web.DataGridViewImageColumn()
        Me.Column1 = New Wisej.Web.DataGridViewImageColumn()
        Me.colCVE_OPERADOR_3 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.CVE_PAQUETE = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colNOMBRE_3 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colFECHA_EXPEDICION_3 = New Wisej.Web.DataGridViewDateTimePickerColumn()
        Me.colFECHA_DICTAMINADO_3 = New Wisej.Web.DataGridViewDateTimePickerColumn()
        Me.colFECHA_RETORNO_3 = New Wisej.Web.DataGridViewDateTimePickerColumn()
        Me.colHABILITADO_3 = New Wisej.Web.DataGridViewCheckBoxColumn()
        Me.colJURISDICCION_3 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colNOMPRE_OPERADOR_3 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pCAT_PAQUETES_ACTAS_B = New DPCRS.DataSet_pCAT_PAQUETES_ACTAS_B()
        Me.DGVActas = New Wisej.Web.DataGridView()
        Me.colCVE_ACTA = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colFOLIO_ACTA = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colFOLIO_ORDEN = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colNOM_PROPIETARIO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colRAZON_SOCIAL = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colRAZON_SOCIALX = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colFECHA_VERIFICACION = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colHORA_VERIFICACION = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colFECHA_CAPTURA = New Wisej.Web.DataGridViewDateTimePickerColumn()
        Me.colFECHA_MODIFICADO = New Wisej.Web.DataGridViewDateTimePickerColumn()
        Me.colFECHA_INGRESO_EXPEDIENTE = New Wisej.Web.DataGridViewDateTimePickerColumn()
        Me.colPROGRAMA = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colFECHA_REPORTE_LSP = New Wisej.Web.DataGridViewDateTimePickerColumn()
        Me.colESTATUS = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colNOMBRE_TESTIGO_1 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colDOMICILIO_TESTIGO_1 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colTESTIGO_IDENTIFICACION_1 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colNOMBRE_TESTIGO_2 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colDOMICILIO_TESTIGO_2 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colTESTIGO_IDENTIFICACION_2 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colOBESERVACIONES = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colMEDIDAS_SEGURIDAD = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colFOLIO_ASEGURAMIENTO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colFOLIO_SUSPENCION = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colFOLIO_REUBICACION = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colDOCUMENTACION = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colNUMERO_ANEXOS = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colDESCRIBIR = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colFIRMADO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colMUNICIPIO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.BindingSource2 = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pCAT_ACTAS_VERIFICACION_B = New DPCRS.DataSet_pCAT_ACTAS_VERIFICACION_B()
        Me.FiltroGrillaSax1 = New DPCRS.filtroGrillaSax()
        Me.colNOMPRE_OPERADOR = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colHABILITADO = New Wisej.Web.DataGridViewCheckBoxColumn()
        Me.colFECHA_RETORNO = New Wisej.Web.DataGridViewDateTimePickerColumn()
        Me.colFECHA_DICTAMINADO = New Wisej.Web.DataGridViewDateTimePickerColumn()
        Me.colFECHA_EXPEDICION = New Wisej.Web.DataGridViewDateTimePickerColumn()
        Me.colJURISDICCION = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colNOMBRE = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colCVE_PAQUETE = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colCVE_OPERADOR = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colNOMPRE_OPERADOR_1 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colNOMBRE_1 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colJURISDICCION_1 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colHABILITADO_1 = New Wisej.Web.DataGridViewCheckBoxColumn()
        Me.colFECHA_RETORNO_1 = New Wisej.Web.DataGridViewDateTimePickerColumn()
        Me.colFECHA_DICTAMINADO_1 = New Wisej.Web.DataGridViewDateTimePickerColumn()
        Me.colFECHA_EXPEDICION_1 = New Wisej.Web.DataGridViewDateTimePickerColumn()
        Me.colCVE_PAQUETE_1 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colCVE_OPERADOR_1 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colNOMPRE_OPERADOR_2 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colNOMBRE_2 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colJURISDICCION_2 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colHABILITADO_2 = New Wisej.Web.DataGridViewCheckBoxColumn()
        Me.colFECHA_RETORNO_2 = New Wisej.Web.DataGridViewDateTimePickerColumn()
        Me.colFECHA_DICTAMINADO_2 = New Wisej.Web.DataGridViewDateTimePickerColumn()
        Me.colFECHA_EXPEDICION_2 = New Wisej.Web.DataGridViewDateTimePickerColumn()
        Me.colCVE_PAQUETE_2 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colCVE_OPERADOR_2 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.PCAT_PAQUETES_ACTAS_BTableAdapter = New DPCRS.DataSet_pCAT_PAQUETES_ACTAS_BTableAdapters.pCAT_PAQUETES_ACTAS_BTableAdapter()
        Me.PCAT_ACTAS_VERIFICACION_BTableAdapter = New DPCRS.DataSet_pCAT_ACTAS_VERIFICACION_BTableAdapters.pCAT_ACTAS_VERIFICACION_BTableAdapter()
        Me.Vacta = New Wisej.Web.DataGridViewButtonColumn()
        Me.Cacta = New Wisej.Web.DataGridViewButtonColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BNLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BNLotes.SuspendLayout()
        CType(Me.BNActas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BNActas.SuspendLayout()
        CType(Me.DGVLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCAT_PAQUETES_ACTAS_B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVActas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCAT_ACTAS_VERIFICACION_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Dock = Wisej.Web.DockStyle.Top
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.Menú)
        Me.RibbonBar1.Size = New System.Drawing.Size(1114, 145)
        '
        'Menú
        '
        Me.Menú.Groups.Add(Me.RibbonBarGroup1)
        Me.Menú.Text = "Menú"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.RibbonBarItemButton1)
        Me.RibbonBarGroup1.Items.Add(Me.RibbonBarItemButton2)
        Me.RibbonBarGroup1.Text = "Menú"
        '
        'RibbonBarItemButton1
        '
        Me.RibbonBarItemButton1.ImageSource = "Resources\Icons\Menu\available-updates.png"
        Me.RibbonBarItemButton1.Name = "RibbonBarItemButton1"
        Me.RibbonBarItemButton1.Text = "Actualizar"
        '
        'RibbonBarItemButton2
        '
        Me.RibbonBarItemButton2.ImageSource = "Resources\Icons\Menu\exit-sign-red.png"
        Me.RibbonBarItemButton2.Name = "RibbonBarItemButton2"
        Me.RibbonBarItemButton2.Text = "Salir"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BNLotes, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BNActas, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FiltroGrillaSax2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DGVLotes, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DGVActas, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FiltroGrillaSax1, 1, 0)
        Me.TableLayoutPanel1.Dock = Wisej.Web.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 145)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 268.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1114, 406)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'BNLotes
        '
        Me.BNLotes.AddNewItem = Me.Button1
        Me.BNLotes.Controls.Add(Me.Button2)
        Me.BNLotes.Controls.Add(Me.Button3)
        Me.BNLotes.Controls.Add(Me.Line1)
        Me.BNLotes.Controls.Add(Me.TextBox1)
        Me.BNLotes.Controls.Add(Me.Label1)
        Me.BNLotes.Controls.Add(Me.Line2)
        Me.BNLotes.Controls.Add(Me.Button4)
        Me.BNLotes.Controls.Add(Me.Button5)
        Me.BNLotes.Controls.Add(Me.Line3)
        Me.BNLotes.Controls.Add(Me.Button1)
        Me.BNLotes.Controls.Add(Me.Button6)
        Me.BNLotes.CountItem = Me.Label1
        Me.BNLotes.DeleteItem = Me.Button6
        Me.BNLotes.Dock = Wisej.Web.DockStyle.Fill
        Me.BNLotes.Location = New System.Drawing.Point(3, 367)
        Me.BNLotes.MoveFirstItem = Me.Button2
        Me.BNLotes.MoveLastItem = Me.Button5
        Me.BNLotes.MoveNextItem = Me.Button4
        Me.BNLotes.MovePreviousItem = Me.Button3
        Me.BNLotes.Name = "BNLotes"
        Me.BNLotes.PositionItem = Me.TextBox1
        Me.BNLotes.Size = New System.Drawing.Size(551, 36)
        Me.BNLotes.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.ImageSource = "table-row-new"
        Me.Button1.Location = New System.Drawing.Point(336, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 28)
        Me.Button1.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.ImageSource = "icon-first"
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 28)
        Me.Button2.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.ImageSource = "icon-left"
        Me.Button3.Location = New System.Drawing.Point(46, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(37, 28)
        Me.Button3.TabIndex = 1
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(89, 3)
        Me.Line1.Name = "Line1"
        Me.Line1.Orientation = Wisej.Web.Orientation.Vertical
        Me.Line1.Padding = New Wisej.Web.Padding(0, 5, 0, 5)
        Me.Line1.Size = New System.Drawing.Size(14, 28)
        '
        'TextBox1
        '
        Me.TextBox1.AutoSize = False
        Me.TextBox1.Location = New System.Drawing.Point(109, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(50, 28)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "0"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(165, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 28)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "of {0}"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Line2
        '
        Me.Line2.Location = New System.Drawing.Point(210, 3)
        Me.Line2.Name = "Line2"
        Me.Line2.Orientation = Wisej.Web.Orientation.Vertical
        Me.Line2.Padding = New Wisej.Web.Padding(0, 5, 0, 5)
        Me.Line2.Size = New System.Drawing.Size(14, 28)
        '
        'Button4
        '
        Me.Button4.ImageSource = "icon-right"
        Me.Button4.Location = New System.Drawing.Point(230, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(37, 28)
        Me.Button4.TabIndex = 2
        '
        'Button5
        '
        Me.Button5.ImageSource = "icon-last"
        Me.Button5.Location = New System.Drawing.Point(273, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(37, 28)
        Me.Button5.TabIndex = 3
        '
        'Line3
        '
        Me.Line3.Location = New System.Drawing.Point(316, 3)
        Me.Line3.Name = "Line3"
        Me.Line3.Orientation = Wisej.Web.Orientation.Vertical
        Me.Line3.Padding = New Wisej.Web.Padding(0, 5, 0, 5)
        Me.Line3.Size = New System.Drawing.Size(14, 28)
        '
        'Button6
        '
        Me.Button6.ImageSource = "icon-close"
        Me.Button6.Location = New System.Drawing.Point(379, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(37, 28)
        Me.Button6.TabIndex = 5
        '
        'BNActas
        '
        Me.BNActas.AddNewItem = Me.buttonAddNew
        Me.BNActas.Controls.Add(Me.buttonMoveFirst)
        Me.BNActas.Controls.Add(Me.buttonMovePrevious)
        Me.BNActas.Controls.Add(Me.separatorLeft)
        Me.BNActas.Controls.Add(Me.textBoxPosition)
        Me.BNActas.Controls.Add(Me.labelCount)
        Me.BNActas.Controls.Add(Me.separatorRight)
        Me.BNActas.Controls.Add(Me.buttonMoveNext)
        Me.BNActas.Controls.Add(Me.buttonMoveLast)
        Me.BNActas.Controls.Add(Me.separatorControl)
        Me.BNActas.Controls.Add(Me.buttonAddNew)
        Me.BNActas.Controls.Add(Me.buttonDelete)
        Me.BNActas.CountItem = Me.labelCount
        Me.BNActas.DeleteItem = Me.buttonDelete
        Me.BNActas.Dock = Wisej.Web.DockStyle.Fill
        Me.BNActas.Location = New System.Drawing.Point(560, 367)
        Me.BNActas.MoveFirstItem = Me.buttonMoveFirst
        Me.BNActas.MoveLastItem = Me.buttonMoveLast
        Me.BNActas.MoveNextItem = Me.buttonMoveNext
        Me.BNActas.MovePreviousItem = Me.buttonMovePrevious
        Me.BNActas.Name = "BNActas"
        Me.BNActas.PositionItem = Me.textBoxPosition
        Me.BNActas.Size = New System.Drawing.Size(551, 36)
        Me.BNActas.TabIndex = 6
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
        'FiltroGrillaSax2
        '
        Me.FiltroGrillaSax2.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.FiltroGrillaSax2.BackColor = System.Drawing.Color.Transparent
        Me.FiltroGrillaSax2.Dock = Wisej.Web.DockStyle.Fill
        Me.FiltroGrillaSax2.Location = New System.Drawing.Point(3, 3)
        Me.FiltroGrillaSax2.meBackcolorEtiquetas = System.Drawing.Color.AliceBlue
        Me.FiltroGrillaSax2.meBorderStyleEtiquetas = Wisej.Web.BorderStyle.Solid
        Me.FiltroGrillaSax2.meBorderWidthEtiquetas = 1
        Me.FiltroGrillaSax2.meDatagrid = Nothing
        Me.FiltroGrillaSax2.meFiltrarVacios = False
        Me.FiltroGrillaSax2.meLanzarException = False
        Me.FiltroGrillaSax2.meMarginEtiquetas = New Wisej.Web.Padding(1)
        Me.FiltroGrillaSax2.mePaddingEtiquetas = New Wisej.Web.Padding(2)
        Me.FiltroGrillaSax2.Name = "FiltroGrillaSax2"
        Me.FiltroGrillaSax2.Size = New System.Drawing.Size(551, 90)
        Me.FiltroGrillaSax2.TabIndex = 2
        '
        'DGVLotes
        '
        Me.DGVLotes.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.Column0, Me.Column1, Me.colCVE_OPERADOR_3, Me.CVE_PAQUETE, Me.colNOMBRE_3, Me.colFECHA_EXPEDICION_3, Me.colFECHA_DICTAMINADO_3, Me.colFECHA_RETORNO_3, Me.colHABILITADO_3, Me.colJURISDICCION_3, Me.colNOMPRE_OPERADOR_3})
        Me.DGVLotes.DataSource = Me.BindingSource1
        Me.DGVLotes.Dock = Wisej.Web.DockStyle.Fill
        Me.DGVLotes.Location = New System.Drawing.Point(3, 99)
        Me.DGVLotes.Name = "DGVLotes"
        Me.DGVLotes.ShowColumnVisibilityMenu = False
        Me.DGVLotes.Size = New System.Drawing.Size(551, 262)
        Me.DGVLotes.TabIndex = 0
        '
        'Column0
        '
        Me.Column0.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.Column0.Name = "Column0"
        Me.Column0.Visible = False
        '
        'Column1
        '
        Me.Column1.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'colCVE_OPERADOR_3
        '
        Me.colCVE_OPERADOR_3.DataPropertyName = "CVE_OPERADOR"
        Me.colCVE_OPERADOR_3.HeaderText = "CVE_OPERADOR"
        Me.colCVE_OPERADOR_3.Name = "colCVE_OPERADOR_3"
        Me.colCVE_OPERADOR_3.Visible = False
        '
        'CVE_PAQUETE
        '
        Me.CVE_PAQUETE.DataPropertyName = "CVE_PAQUETE"
        Me.CVE_PAQUETE.HeaderText = "Clave Paquete"
        Me.CVE_PAQUETE.Name = "CVE_PAQUETE"
        Me.CVE_PAQUETE.ReadOnly = True
        '
        'colNOMBRE_3
        '
        Me.colNOMBRE_3.DataPropertyName = "NOMBRE"
        Me.colNOMBRE_3.HeaderText = "Nombre"
        Me.colNOMBRE_3.Name = "colNOMBRE_3"
        Me.colNOMBRE_3.ReadOnly = True
        Me.colNOMBRE_3.Visible = False
        '
        'colFECHA_EXPEDICION_3
        '
        Me.colFECHA_EXPEDICION_3.DataPropertyName = "FECHA_EXPEDICION"
        Me.colFECHA_EXPEDICION_3.HeaderText = "Fecha Expedicion"
        Me.colFECHA_EXPEDICION_3.Name = "colFECHA_EXPEDICION_3"
        '
        'colFECHA_DICTAMINADO_3
        '
        Me.colFECHA_DICTAMINADO_3.DataPropertyName = "FECHA_DICTAMINADO"
        Me.colFECHA_DICTAMINADO_3.HeaderText = "Fecha Dictaminado"
        Me.colFECHA_DICTAMINADO_3.Name = "colFECHA_DICTAMINADO_3"
        '
        'colFECHA_RETORNO_3
        '
        Me.colFECHA_RETORNO_3.DataPropertyName = "FECHA_RETORNO"
        Me.colFECHA_RETORNO_3.HeaderText = "Fecha Retorno a Jurisdiccion"
        Me.colFECHA_RETORNO_3.Name = "colFECHA_RETORNO_3"
        '
        'colHABILITADO_3
        '
        Me.colHABILITADO_3.DataPropertyName = "HABILITADO"
        Me.colHABILITADO_3.HeaderText = "HABILITADO"
        Me.colHABILITADO_3.Name = "colHABILITADO_3"
        Me.colHABILITADO_3.Visible = False
        '
        'colJURISDICCION_3
        '
        Me.colJURISDICCION_3.DataPropertyName = "JURISDICCION"
        Me.colJURISDICCION_3.HeaderText = "Jurisdiccion"
        Me.colJURISDICCION_3.Name = "colJURISDICCION_3"
        '
        'colNOMPRE_OPERADOR_3
        '
        Me.colNOMPRE_OPERADOR_3.DataPropertyName = "NOMPRE_OPERADOR"
        Me.colNOMPRE_OPERADOR_3.HeaderText = "Nombre Operador"
        Me.colNOMPRE_OPERADOR_3.Name = "colNOMPRE_OPERADOR_3"
        Me.colNOMPRE_OPERADOR_3.ReadOnly = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "pCAT_PAQUETES_ACTAS_B"
        Me.BindingSource1.DataSource = Me.DataSet_pCAT_PAQUETES_ACTAS_B
        '
        'DataSet_pCAT_PAQUETES_ACTAS_B
        '
        Me.DataSet_pCAT_PAQUETES_ACTAS_B.DataSetName = "DataSet_pCAT_PAQUETES_ACTAS_B"
        Me.DataSet_pCAT_PAQUETES_ACTAS_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DGVActas
        '
        Me.DGVActas.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.Vacta, Me.Cacta, Me.colCVE_ACTA, Me.colFOLIO_ACTA, Me.colFOLIO_ORDEN, Me.colNOM_PROPIETARIO, Me.colRAZON_SOCIAL, Me.colRAZON_SOCIALX, Me.colFECHA_VERIFICACION, Me.colHORA_VERIFICACION, Me.colFECHA_CAPTURA, Me.colFECHA_MODIFICADO, Me.colFECHA_INGRESO_EXPEDIENTE, Me.colPROGRAMA, Me.colFECHA_REPORTE_LSP, Me.colESTATUS, Me.colNOMBRE_TESTIGO_1, Me.colDOMICILIO_TESTIGO_1, Me.colTESTIGO_IDENTIFICACION_1, Me.colNOMBRE_TESTIGO_2, Me.colDOMICILIO_TESTIGO_2, Me.colTESTIGO_IDENTIFICACION_2, Me.colOBESERVACIONES, Me.colMEDIDAS_SEGURIDAD, Me.colFOLIO_ASEGURAMIENTO, Me.colFOLIO_SUSPENCION, Me.colFOLIO_REUBICACION, Me.colDOCUMENTACION, Me.colNUMERO_ANEXOS, Me.colDESCRIBIR, Me.colFIRMADO, Me.colMUNICIPIO})
        Me.DGVActas.DataSource = Me.BindingSource2
        Me.DGVActas.Dock = Wisej.Web.DockStyle.Fill
        Me.DGVActas.Location = New System.Drawing.Point(560, 99)
        Me.DGVActas.Name = "DGVActas"
        Me.DGVActas.ShowColumnVisibilityMenu = False
        Me.DGVActas.Size = New System.Drawing.Size(551, 262)
        Me.DGVActas.TabIndex = 1
        '
        'colCVE_ACTA
        '
        Me.colCVE_ACTA.DataPropertyName = "CVE_ACTA"
        Me.colCVE_ACTA.HeaderText = "Consecutivo Acta"
        Me.colCVE_ACTA.Name = "colCVE_ACTA"
        Me.colCVE_ACTA.ReadOnly = True
        Me.colCVE_ACTA.Visible = False
        '
        'colFOLIO_ACTA
        '
        Me.colFOLIO_ACTA.DataPropertyName = "FOLIO_ACTA"
        Me.colFOLIO_ACTA.HeaderText = "Folio Acta"
        Me.colFOLIO_ACTA.Name = "colFOLIO_ACTA"
        '
        'colFOLIO_ORDEN
        '
        Me.colFOLIO_ORDEN.DataPropertyName = "FOLIO_ORDEN"
        Me.colFOLIO_ORDEN.HeaderText = "Folio Orden"
        Me.colFOLIO_ORDEN.Name = "colFOLIO_ORDEN"
        '
        'colNOM_PROPIETARIO
        '
        Me.colNOM_PROPIETARIO.DataPropertyName = "NOM_PROPIETARIO"
        Me.colNOM_PROPIETARIO.HeaderText = "Propietario"
        Me.colNOM_PROPIETARIO.Name = "colNOM_PROPIETARIO"
        '
        'colRAZON_SOCIAL
        '
        Me.colRAZON_SOCIAL.DataPropertyName = "RAZON_SOCIAL"
        Me.colRAZON_SOCIAL.HeaderText = "Razon Social"
        Me.colRAZON_SOCIAL.Name = "colRAZON_SOCIAL"
        '
        'colRAZON_SOCIALX
        '
        Me.colRAZON_SOCIALX.DataPropertyName = "RAZON_SOCIALX"
        Me.colRAZON_SOCIALX.HeaderText = "RAZON_SOCIALX"
        Me.colRAZON_SOCIALX.Name = "colRAZON_SOCIALX"
        Me.colRAZON_SOCIALX.ReadOnly = True
        Me.colRAZON_SOCIALX.Visible = False
        '
        'colFECHA_VERIFICACION
        '
        Me.colFECHA_VERIFICACION.DataPropertyName = "FECHA_VERIFICACION"
        Me.colFECHA_VERIFICACION.HeaderText = "Fecha Vericacion"
        Me.colFECHA_VERIFICACION.Name = "colFECHA_VERIFICACION"
        Me.colFECHA_VERIFICACION.ReadOnly = True
        '
        'colHORA_VERIFICACION
        '
        Me.colHORA_VERIFICACION.DataPropertyName = "HORA_VERIFICACION"
        Me.colHORA_VERIFICACION.HeaderText = "Hora Verificacion"
        Me.colHORA_VERIFICACION.Name = "colHORA_VERIFICACION"
        Me.colHORA_VERIFICACION.ReadOnly = True
        '
        'colFECHA_CAPTURA
        '
        Me.colFECHA_CAPTURA.DataPropertyName = "FECHA_CAPTURA"
        Me.colFECHA_CAPTURA.HeaderText = "Fecha Captura"
        Me.colFECHA_CAPTURA.Name = "colFECHA_CAPTURA"
        '
        'colFECHA_MODIFICADO
        '
        Me.colFECHA_MODIFICADO.DataPropertyName = "FECHA_MODIFICADO"
        Me.colFECHA_MODIFICADO.HeaderText = "Fecha Modificado"
        Me.colFECHA_MODIFICADO.Name = "colFECHA_MODIFICADO"
        '
        'colFECHA_INGRESO_EXPEDIENTE
        '
        Me.colFECHA_INGRESO_EXPEDIENTE.DataPropertyName = "FECHA_INGRESO_EXPEDIENTE"
        Me.colFECHA_INGRESO_EXPEDIENTE.HeaderText = "Fecha ingreso a Expediente"
        Me.colFECHA_INGRESO_EXPEDIENTE.Name = "colFECHA_INGRESO_EXPEDIENTE"
        '
        'colPROGRAMA
        '
        Me.colPROGRAMA.DataPropertyName = "PROGRAMA"
        Me.colPROGRAMA.HeaderText = "Programa"
        Me.colPROGRAMA.Name = "colPROGRAMA"
        '
        'colFECHA_REPORTE_LSP
        '
        Me.colFECHA_REPORTE_LSP.DataPropertyName = "FECHA_REPORTE_LSP"
        Me.colFECHA_REPORTE_LSP.HeaderText = "Fecha de Reporte LTS"
        Me.colFECHA_REPORTE_LSP.Name = "colFECHA_REPORTE_LSP"
        '
        'colESTATUS
        '
        Me.colESTATUS.DataPropertyName = "ESTATUS"
        Me.colESTATUS.HeaderText = "Estado de Establecimiento"
        Me.colESTATUS.Name = "colESTATUS"
        '
        'colNOMBRE_TESTIGO_1
        '
        Me.colNOMBRE_TESTIGO_1.DataPropertyName = "NOMBRE_TESTIGO_1"
        Me.colNOMBRE_TESTIGO_1.HeaderText = "NOMBRE_TESTIGO_1"
        Me.colNOMBRE_TESTIGO_1.Name = "colNOMBRE_TESTIGO_1"
        Me.colNOMBRE_TESTIGO_1.Visible = False
        '
        'colDOMICILIO_TESTIGO_1
        '
        Me.colDOMICILIO_TESTIGO_1.DataPropertyName = "DOMICILIO_TESTIGO_1"
        Me.colDOMICILIO_TESTIGO_1.HeaderText = "DOMICILIO_TESTIGO_1"
        Me.colDOMICILIO_TESTIGO_1.Name = "colDOMICILIO_TESTIGO_1"
        Me.colDOMICILIO_TESTIGO_1.Visible = False
        '
        'colTESTIGO_IDENTIFICACION_1
        '
        Me.colTESTIGO_IDENTIFICACION_1.DataPropertyName = "TESTIGO_IDENTIFICACION_1"
        Me.colTESTIGO_IDENTIFICACION_1.HeaderText = "TESTIGO_IDENTIFICACION_1"
        Me.colTESTIGO_IDENTIFICACION_1.Name = "colTESTIGO_IDENTIFICACION_1"
        Me.colTESTIGO_IDENTIFICACION_1.Visible = False
        '
        'colNOMBRE_TESTIGO_2
        '
        Me.colNOMBRE_TESTIGO_2.DataPropertyName = "NOMBRE_TESTIGO_2"
        Me.colNOMBRE_TESTIGO_2.HeaderText = "NOMBRE_TESTIGO_2"
        Me.colNOMBRE_TESTIGO_2.Name = "colNOMBRE_TESTIGO_2"
        Me.colNOMBRE_TESTIGO_2.Visible = False
        '
        'colDOMICILIO_TESTIGO_2
        '
        Me.colDOMICILIO_TESTIGO_2.DataPropertyName = "DOMICILIO_TESTIGO_2"
        Me.colDOMICILIO_TESTIGO_2.HeaderText = "DOMICILIO_TESTIGO_2"
        Me.colDOMICILIO_TESTIGO_2.Name = "colDOMICILIO_TESTIGO_2"
        Me.colDOMICILIO_TESTIGO_2.Visible = False
        '
        'colTESTIGO_IDENTIFICACION_2
        '
        Me.colTESTIGO_IDENTIFICACION_2.DataPropertyName = "TESTIGO_IDENTIFICACION_2"
        Me.colTESTIGO_IDENTIFICACION_2.HeaderText = "TESTIGO_IDENTIFICACION_2"
        Me.colTESTIGO_IDENTIFICACION_2.Name = "colTESTIGO_IDENTIFICACION_2"
        Me.colTESTIGO_IDENTIFICACION_2.Visible = False
        '
        'colOBESERVACIONES
        '
        Me.colOBESERVACIONES.DataPropertyName = "OBESERVACIONES"
        Me.colOBESERVACIONES.HeaderText = "OBESERVACIONES"
        Me.colOBESERVACIONES.Name = "colOBESERVACIONES"
        Me.colOBESERVACIONES.Visible = False
        '
        'colMEDIDAS_SEGURIDAD
        '
        Me.colMEDIDAS_SEGURIDAD.DataPropertyName = "MEDIDAS_SEGURIDAD"
        Me.colMEDIDAS_SEGURIDAD.HeaderText = "MEDIDAS_SEGURIDAD"
        Me.colMEDIDAS_SEGURIDAD.Name = "colMEDIDAS_SEGURIDAD"
        Me.colMEDIDAS_SEGURIDAD.Visible = False
        '
        'colFOLIO_ASEGURAMIENTO
        '
        Me.colFOLIO_ASEGURAMIENTO.DataPropertyName = "FOLIO_ASEGURAMIENTO"
        Me.colFOLIO_ASEGURAMIENTO.HeaderText = "FOLIO_ASEGURAMIENTO"
        Me.colFOLIO_ASEGURAMIENTO.Name = "colFOLIO_ASEGURAMIENTO"
        Me.colFOLIO_ASEGURAMIENTO.Visible = False
        '
        'colFOLIO_SUSPENCION
        '
        Me.colFOLIO_SUSPENCION.DataPropertyName = "FOLIO_SUSPENCION"
        Me.colFOLIO_SUSPENCION.HeaderText = "Folio Suspencion"
        Me.colFOLIO_SUSPENCION.Name = "colFOLIO_SUSPENCION"
        '
        'colFOLIO_REUBICACION
        '
        Me.colFOLIO_REUBICACION.DataPropertyName = "FOLIO_REUBICACION"
        Me.colFOLIO_REUBICACION.HeaderText = "FOLIO_REUBICACION"
        Me.colFOLIO_REUBICACION.Name = "colFOLIO_REUBICACION"
        Me.colFOLIO_REUBICACION.Visible = False
        '
        'colDOCUMENTACION
        '
        Me.colDOCUMENTACION.DataPropertyName = "DOCUMENTACION"
        Me.colDOCUMENTACION.HeaderText = "DOCUMENTACION"
        Me.colDOCUMENTACION.Name = "colDOCUMENTACION"
        Me.colDOCUMENTACION.Visible = False
        '
        'colNUMERO_ANEXOS
        '
        Me.colNUMERO_ANEXOS.DataPropertyName = "NUMERO_ANEXOS"
        Me.colNUMERO_ANEXOS.HeaderText = "NUMERO_ANEXOS"
        Me.colNUMERO_ANEXOS.Name = "colNUMERO_ANEXOS"
        Me.colNUMERO_ANEXOS.Visible = False
        '
        'colDESCRIBIR
        '
        Me.colDESCRIBIR.DataPropertyName = "DESCRIBIR"
        Me.colDESCRIBIR.HeaderText = "Descipcion de la Visita"
        Me.colDESCRIBIR.Name = "colDESCRIBIR"
        '
        'colFIRMADO
        '
        Me.colFIRMADO.DataPropertyName = "FIRMADO"
        Me.colFIRMADO.Name = "colFIRMADO"
        Me.colFIRMADO.Visible = False
        '
        'colMUNICIPIO
        '
        Me.colMUNICIPIO.DataPropertyName = "MUNICIPIO"
        Me.colMUNICIPIO.HeaderText = "Jurisdiccion"
        Me.colMUNICIPIO.Name = "colMUNICIPIO"
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "pCAT_ACTAS_VERIFICACION_B"
        Me.BindingSource2.DataSource = Me.DataSet_pCAT_ACTAS_VERIFICACION_B
        '
        'DataSet_pCAT_ACTAS_VERIFICACION_B
        '
        Me.DataSet_pCAT_ACTAS_VERIFICACION_B.DataSetName = "DataSet_pCAT_ACTAS_VERIFICACION_B"
        Me.DataSet_pCAT_ACTAS_VERIFICACION_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FiltroGrillaSax1
        '
        Me.FiltroGrillaSax1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.FiltroGrillaSax1.BackColor = System.Drawing.Color.Transparent
        Me.FiltroGrillaSax1.Dock = Wisej.Web.DockStyle.Fill
        Me.FiltroGrillaSax1.Location = New System.Drawing.Point(560, 3)
        Me.FiltroGrillaSax1.meBackcolorEtiquetas = System.Drawing.Color.AliceBlue
        Me.FiltroGrillaSax1.meBorderStyleEtiquetas = Wisej.Web.BorderStyle.Solid
        Me.FiltroGrillaSax1.meBorderWidthEtiquetas = 1
        Me.FiltroGrillaSax1.meDatagrid = Nothing
        Me.FiltroGrillaSax1.meFiltrarVacios = False
        Me.FiltroGrillaSax1.meLanzarException = False
        Me.FiltroGrillaSax1.meMarginEtiquetas = New Wisej.Web.Padding(1)
        Me.FiltroGrillaSax1.mePaddingEtiquetas = New Wisej.Web.Padding(2)
        Me.FiltroGrillaSax1.Name = "FiltroGrillaSax1"
        Me.FiltroGrillaSax1.Size = New System.Drawing.Size(551, 90)
        Me.FiltroGrillaSax1.TabIndex = 1
        '
        'colNOMPRE_OPERADOR
        '
        Me.colNOMPRE_OPERADOR.DataPropertyName = "NOMPRE_OPERADOR"
        Me.colNOMPRE_OPERADOR.HeaderText = "NOMPRE_OPERADOR"
        Me.colNOMPRE_OPERADOR.Name = "colNOMPRE_OPERADOR"
        Me.colNOMPRE_OPERADOR.ReadOnly = True
        Me.colNOMPRE_OPERADOR.Visible = False
        '
        'colHABILITADO
        '
        Me.colHABILITADO.DataPropertyName = "HABILITADO"
        Me.colHABILITADO.HeaderText = "HABILITADO"
        Me.colHABILITADO.Name = "colHABILITADO"
        Me.colHABILITADO.Visible = False
        '
        'colFECHA_RETORNO
        '
        Me.colFECHA_RETORNO.DataPropertyName = "FECHA_RETORNO"
        Me.colFECHA_RETORNO.HeaderText = "FECHA_RETORNO"
        Me.colFECHA_RETORNO.Name = "colFECHA_RETORNO"
        '
        'colFECHA_DICTAMINADO
        '
        Me.colFECHA_DICTAMINADO.DataPropertyName = "FECHA_DICTAMINADO"
        Me.colFECHA_DICTAMINADO.HeaderText = "FECHA_DICTAMINADO"
        Me.colFECHA_DICTAMINADO.Name = "colFECHA_DICTAMINADO"
        '
        'colFECHA_EXPEDICION
        '
        Me.colFECHA_EXPEDICION.DataPropertyName = "FECHA_EXPEDICION"
        Me.colFECHA_EXPEDICION.HeaderText = "FECHA_EXPEDICION"
        Me.colFECHA_EXPEDICION.Name = "colFECHA_EXPEDICION"
        '
        'colJURISDICCION
        '
        Me.colJURISDICCION.DataPropertyName = "JURISDICCION"
        Me.colJURISDICCION.HeaderText = "JURISDICCION"
        Me.colJURISDICCION.Name = "colJURISDICCION"
        '
        'colNOMBRE
        '
        Me.colNOMBRE.DataPropertyName = "NOMBRE"
        Me.colNOMBRE.HeaderText = "NOMBRE"
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.ReadOnly = True
        '
        'colCVE_PAQUETE
        '
        Me.colCVE_PAQUETE.DataPropertyName = "CVE_PAQUETE"
        Me.colCVE_PAQUETE.HeaderText = "CVE_PAQUETE"
        Me.colCVE_PAQUETE.Name = "colCVE_PAQUETE"
        Me.colCVE_PAQUETE.ReadOnly = True
        '
        'colCVE_OPERADOR
        '
        Me.colCVE_OPERADOR.DataPropertyName = "CVE_OPERADOR"
        Me.colCVE_OPERADOR.HeaderText = "CVE_OPERADOR"
        Me.colCVE_OPERADOR.Name = "colCVE_OPERADOR"
        Me.colCVE_OPERADOR.Visible = False
        '
        'colNOMPRE_OPERADOR_1
        '
        Me.colNOMPRE_OPERADOR_1.DataPropertyName = "NOMPRE_OPERADOR"
        Me.colNOMPRE_OPERADOR_1.HeaderText = "NOMPRE_OPERADOR"
        Me.colNOMPRE_OPERADOR_1.Name = "colNOMPRE_OPERADOR_1"
        Me.colNOMPRE_OPERADOR_1.ReadOnly = True
        '
        'colNOMBRE_1
        '
        Me.colNOMBRE_1.DataPropertyName = "NOMBRE"
        Me.colNOMBRE_1.HeaderText = "NOMBRE"
        Me.colNOMBRE_1.Name = "colNOMBRE_1"
        Me.colNOMBRE_1.ReadOnly = True
        '
        'colJURISDICCION_1
        '
        Me.colJURISDICCION_1.DataPropertyName = "JURISDICCION"
        Me.colJURISDICCION_1.HeaderText = "JURISDICCION"
        Me.colJURISDICCION_1.Name = "colJURISDICCION_1"
        '
        'colHABILITADO_1
        '
        Me.colHABILITADO_1.DataPropertyName = "HABILITADO"
        Me.colHABILITADO_1.HeaderText = "HABILITADO"
        Me.colHABILITADO_1.Name = "colHABILITADO_1"
        '
        'colFECHA_RETORNO_1
        '
        Me.colFECHA_RETORNO_1.DataPropertyName = "FECHA_RETORNO"
        Me.colFECHA_RETORNO_1.HeaderText = "FECHA_RETORNO"
        Me.colFECHA_RETORNO_1.Name = "colFECHA_RETORNO_1"
        '
        'colFECHA_DICTAMINADO_1
        '
        Me.colFECHA_DICTAMINADO_1.DataPropertyName = "FECHA_DICTAMINADO"
        Me.colFECHA_DICTAMINADO_1.HeaderText = "FECHA_DICTAMINADO"
        Me.colFECHA_DICTAMINADO_1.Name = "colFECHA_DICTAMINADO_1"
        '
        'colFECHA_EXPEDICION_1
        '
        Me.colFECHA_EXPEDICION_1.DataPropertyName = "FECHA_EXPEDICION"
        Me.colFECHA_EXPEDICION_1.HeaderText = "FECHA_EXPEDICION"
        Me.colFECHA_EXPEDICION_1.Name = "colFECHA_EXPEDICION_1"
        '
        'colCVE_PAQUETE_1
        '
        Me.colCVE_PAQUETE_1.DataPropertyName = "CVE_PAQUETE"
        Me.colCVE_PAQUETE_1.HeaderText = "CVE_PAQUETE"
        Me.colCVE_PAQUETE_1.Name = "colCVE_PAQUETE_1"
        Me.colCVE_PAQUETE_1.ReadOnly = True
        '
        'colCVE_OPERADOR_1
        '
        Me.colCVE_OPERADOR_1.DataPropertyName = "CVE_OPERADOR"
        Me.colCVE_OPERADOR_1.HeaderText = "CVE_OPERADOR"
        Me.colCVE_OPERADOR_1.Name = "colCVE_OPERADOR_1"
        '
        'colNOMPRE_OPERADOR_2
        '
        Me.colNOMPRE_OPERADOR_2.DataPropertyName = "NOMPRE_OPERADOR"
        Me.colNOMPRE_OPERADOR_2.HeaderText = "NOMPRE_OPERADOR"
        Me.colNOMPRE_OPERADOR_2.Name = "colNOMPRE_OPERADOR_2"
        Me.colNOMPRE_OPERADOR_2.ReadOnly = True
        '
        'colNOMBRE_2
        '
        Me.colNOMBRE_2.DataPropertyName = "NOMBRE"
        Me.colNOMBRE_2.HeaderText = "NOMBRE"
        Me.colNOMBRE_2.Name = "colNOMBRE_2"
        Me.colNOMBRE_2.ReadOnly = True
        '
        'colJURISDICCION_2
        '
        Me.colJURISDICCION_2.DataPropertyName = "JURISDICCION"
        Me.colJURISDICCION_2.HeaderText = "JURISDICCION"
        Me.colJURISDICCION_2.Name = "colJURISDICCION_2"
        '
        'colHABILITADO_2
        '
        Me.colHABILITADO_2.DataPropertyName = "HABILITADO"
        Me.colHABILITADO_2.HeaderText = "HABILITADO"
        Me.colHABILITADO_2.Name = "colHABILITADO_2"
        '
        'colFECHA_RETORNO_2
        '
        Me.colFECHA_RETORNO_2.DataPropertyName = "FECHA_RETORNO"
        Me.colFECHA_RETORNO_2.HeaderText = "FECHA_RETORNO"
        Me.colFECHA_RETORNO_2.Name = "colFECHA_RETORNO_2"
        '
        'colFECHA_DICTAMINADO_2
        '
        Me.colFECHA_DICTAMINADO_2.DataPropertyName = "FECHA_DICTAMINADO"
        Me.colFECHA_DICTAMINADO_2.HeaderText = "FECHA_DICTAMINADO"
        Me.colFECHA_DICTAMINADO_2.Name = "colFECHA_DICTAMINADO_2"
        '
        'colFECHA_EXPEDICION_2
        '
        Me.colFECHA_EXPEDICION_2.DataPropertyName = "FECHA_EXPEDICION"
        Me.colFECHA_EXPEDICION_2.HeaderText = "FECHA_EXPEDICION"
        Me.colFECHA_EXPEDICION_2.Name = "colFECHA_EXPEDICION_2"
        '
        'colCVE_PAQUETE_2
        '
        Me.colCVE_PAQUETE_2.DataPropertyName = "CVE_PAQUETE"
        Me.colCVE_PAQUETE_2.HeaderText = "CVE_PAQUETE"
        Me.colCVE_PAQUETE_2.Name = "colCVE_PAQUETE_2"
        Me.colCVE_PAQUETE_2.ReadOnly = True
        '
        'colCVE_OPERADOR_2
        '
        Me.colCVE_OPERADOR_2.DataPropertyName = "CVE_OPERADOR"
        Me.colCVE_OPERADOR_2.HeaderText = "CVE_OPERADOR"
        Me.colCVE_OPERADOR_2.Name = "colCVE_OPERADOR_2"
        '
        'PCAT_PAQUETES_ACTAS_BTableAdapter
        '
        Me.PCAT_PAQUETES_ACTAS_BTableAdapter.ClearBeforeFill = True
        '
        'PCAT_ACTAS_VERIFICACION_BTableAdapter
        '
        Me.PCAT_ACTAS_VERIFICACION_BTableAdapter.ClearBeforeFill = True
        '
        'Vacta
        '
        DataGridViewCellStyle1.BackgroundImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackgroundImageLayout = Wisej.Web.ImageLayout.Center
        DataGridViewCellStyle1.BackgroundImageSource = "Resources/Icons/Menu/approval.png"
        Me.Vacta.DefaultCellStyle = DataGridViewCellStyle1
        Me.Vacta.Name = "Vacta"
        '
        'Cacta
        '
        DataGridViewCellStyle2.BackgroundImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackgroundImageLayout = Wisej.Web.ImageLayout.Center
        DataGridViewCellStyle2.BackgroundImageSource = "Resources/Icons/Menu/undo-retorno-relleno.png"
        Me.Cacta.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cacta.Name = "Cacta"
        '
        'Cat_Lotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 554)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Cat_Lotes"
        Me.Text = "Catálogo Paquetes de Actas"
        Me.WindowState = Wisej.Web.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.BNLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BNLotes.ResumeLayout(False)
        CType(Me.BNActas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BNActas.ResumeLayout(False)
        CType(Me.DGVLotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCAT_PAQUETES_ACTAS_B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVActas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCAT_ACTAS_VERIFICACION_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonBar1 As Wisej.Web.Ext.RibbonBar.RibbonBar
    Friend WithEvents Menú As Wisej.Web.Ext.RibbonBar.RibbonBarPage
    Friend WithEvents FiltroGrillaSax1 As filtroGrillaSax
    Friend WithEvents TableLayoutPanel1 As Wisej.Web.TableLayoutPanel
    Friend WithEvents DGVActas As Wisej.Web.DataGridView
    Friend WithEvents DGVLotes As Wisej.Web.DataGridView
    Friend WithEvents Column0 As Wisej.Web.DataGridViewImageColumn
    Friend WithEvents Column1 As Wisej.Web.DataGridViewImageColumn
    Friend WithEvents FiltroGrillaSax2 As filtroGrillaSax
    Friend WithEvents BNLotes As Wisej.Web.BindingNavigator
    Friend WithEvents Button1 As Wisej.Web.Button
    Friend WithEvents Button2 As Wisej.Web.Button
    Friend WithEvents Button3 As Wisej.Web.Button
    Friend WithEvents Line1 As Wisej.Web.Line
    Friend WithEvents TextBox1 As Wisej.Web.TextBox
    Friend WithEvents Label1 As Wisej.Web.Label
    Friend WithEvents Line2 As Wisej.Web.Line
    Friend WithEvents Button4 As Wisej.Web.Button
    Friend WithEvents Button5 As Wisej.Web.Button
    Friend WithEvents Line3 As Wisej.Web.Line
    Friend WithEvents Button6 As Wisej.Web.Button
    Friend WithEvents BNActas As Wisej.Web.BindingNavigator
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
    Friend WithEvents colNOMPRE_OPERADOR As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colHABILITADO As Wisej.Web.DataGridViewCheckBoxColumn
    Friend WithEvents colFECHA_RETORNO As Wisej.Web.DataGridViewDateTimePickerColumn
    Friend WithEvents colFECHA_DICTAMINADO As Wisej.Web.DataGridViewDateTimePickerColumn
    Friend WithEvents colFECHA_EXPEDICION As Wisej.Web.DataGridViewDateTimePickerColumn
    Friend WithEvents colJURISDICCION As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colNOMBRE As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colCVE_PAQUETE As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colCVE_OPERADOR As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colNOMPRE_OPERADOR_1 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colNOMBRE_1 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colJURISDICCION_1 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colHABILITADO_1 As Wisej.Web.DataGridViewCheckBoxColumn
    Friend WithEvents colFECHA_RETORNO_1 As Wisej.Web.DataGridViewDateTimePickerColumn
    Friend WithEvents colFECHA_DICTAMINADO_1 As Wisej.Web.DataGridViewDateTimePickerColumn
    Friend WithEvents colFECHA_EXPEDICION_1 As Wisej.Web.DataGridViewDateTimePickerColumn
    Friend WithEvents colCVE_PAQUETE_1 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colCVE_OPERADOR_1 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colNOMPRE_OPERADOR_2 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colNOMBRE_2 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colJURISDICCION_2 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colHABILITADO_2 As Wisej.Web.DataGridViewCheckBoxColumn
    Friend WithEvents colFECHA_RETORNO_2 As Wisej.Web.DataGridViewDateTimePickerColumn
    Friend WithEvents colFECHA_DICTAMINADO_2 As Wisej.Web.DataGridViewDateTimePickerColumn
    Friend WithEvents colFECHA_EXPEDICION_2 As Wisej.Web.DataGridViewDateTimePickerColumn
    Friend WithEvents colCVE_PAQUETE_2 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colCVE_OPERADOR_2 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents DataSet_pCAT_PAQUETES_ACTAS_B As DataSet_pCAT_PAQUETES_ACTAS_B
    Friend WithEvents colCVE_OPERADOR_3 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents CVE_PAQUETE As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colFECHA_EXPEDICION_3 As Wisej.Web.DataGridViewDateTimePickerColumn
    Friend WithEvents colFECHA_DICTAMINADO_3 As Wisej.Web.DataGridViewDateTimePickerColumn
    Friend WithEvents colFECHA_RETORNO_3 As Wisej.Web.DataGridViewDateTimePickerColumn
    Friend WithEvents colHABILITADO_3 As Wisej.Web.DataGridViewCheckBoxColumn
    Friend WithEvents colJURISDICCION_3 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colNOMBRE_3 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colNOMPRE_OPERADOR_3 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents BindingSource1 As Wisej.Web.BindingSource
    Friend WithEvents colCVE_ACTA As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colFOLIO_ACTA As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colFOLIO_ORDEN As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colNOM_PROPIETARIO As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colRAZON_SOCIAL As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colRAZON_SOCIALX As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colFECHA_VERIFICACION As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colHORA_VERIFICACION As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colFECHA_CAPTURA As Wisej.Web.DataGridViewDateTimePickerColumn
    Friend WithEvents colFECHA_MODIFICADO As Wisej.Web.DataGridViewDateTimePickerColumn
    Friend WithEvents colFECHA_INGRESO_EXPEDIENTE As Wisej.Web.DataGridViewDateTimePickerColumn
    Friend WithEvents colPROGRAMA As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colFECHA_REPORTE_LSP As Wisej.Web.DataGridViewDateTimePickerColumn
    Friend WithEvents colESTATUS As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colNOMBRE_TESTIGO_1 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colDOMICILIO_TESTIGO_1 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colTESTIGO_IDENTIFICACION_1 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colNOMBRE_TESTIGO_2 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colDOMICILIO_TESTIGO_2 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colTESTIGO_IDENTIFICACION_2 As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colOBESERVACIONES As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colMEDIDAS_SEGURIDAD As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colFOLIO_ASEGURAMIENTO As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colFOLIO_SUSPENCION As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colFOLIO_REUBICACION As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colDOCUMENTACION As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colNUMERO_ANEXOS As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colDESCRIBIR As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colFIRMADO As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colMUNICIPIO As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents BindingSource2 As Wisej.Web.BindingSource
    Friend WithEvents DataSet_pCAT_ACTAS_VERIFICACION_B As DataSet_pCAT_ACTAS_VERIFICACION_B
    Friend WithEvents PCAT_PAQUETES_ACTAS_BTableAdapter As DataSet_pCAT_PAQUETES_ACTAS_BTableAdapters.pCAT_PAQUETES_ACTAS_BTableAdapter
    Friend WithEvents PCAT_ACTAS_VERIFICACION_BTableAdapter As DataSet_pCAT_ACTAS_VERIFICACION_BTableAdapters.pCAT_ACTAS_VERIFICACION_BTableAdapter
    Friend WithEvents RibbonBarGroup1 As Wisej.Web.Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents RibbonBarItemButton1 As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RibbonBarItemButton2 As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents Vacta As Wisej.Web.DataGridViewButtonColumn
    Friend WithEvents Cacta As Wisej.Web.DataGridViewButtonColumn
End Class
