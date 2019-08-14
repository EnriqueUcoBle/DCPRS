<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Generar_Orden_Verficacion
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
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.NUEVO = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.SALIR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Panel1 = New Wisej.Web.Panel()
        Me.FASE1 = New Wisej.Web.Panel()
        Me.Line1 = New Wisej.Web.Line()
        Me.Label25 = New Wisej.Web.Label()
        Me.Label26 = New Wisej.Web.Label()
        Me.Label28 = New Wisej.Web.Label()
        Me.ID_TESTIGO2 = New Wisej.Web.ComboBox()
        Me.DOM_TESTIGO2 = New Wisej.Web.TextBox()
        Me.NOMBRE_TESTIGO2 = New Wisej.Web.TextBox()
        Me.Label23 = New Wisej.Web.Label()
        Me.Label18 = New Wisej.Web.Label()
        Me.Label17 = New Wisej.Web.Label()
        Me.Label16 = New Wisej.Web.Label()
        Me.Label15 = New Wisej.Web.Label()
        Me.Label14 = New Wisej.Web.Label()
        Me.TESTIGO2 = New Wisej.Web.CheckBox()
        Me.TESTIGO1 = New Wisej.Web.CheckBox()
        Me.Label46 = New Wisej.Web.Label()
        Me.ID_TESTIGO1 = New Wisej.Web.ComboBox()
        Me.DOM_TESTIGO1 = New Wisej.Web.TextBox()
        Me.NOMBRE_TESTIGO1 = New Wisej.Web.TextBox()
        Me.GroupBox2 = New Wisej.Web.GroupBox()
        Me.no = New Wisej.Web.RadioButton()
        Me.PROPIETARIO_RESPONSABLE = New Wisej.Web.RadioButton()
        Me.CARGO_RESPONSABLE = New Wisej.Web.TextBox()
        Me.Label45 = New Wisej.Web.Label()
        Me.ID_RESPONSABLE = New Wisej.Web.ComboBox()
        Me.DOMICILIO_RESPONSABLE = New Wisej.Web.TextBox()
        Me.NOMBRE_RESPONSABLE = New Wisej.Web.TextBox()
        Me.Label12 = New Wisej.Web.Label()
        Me.Label8 = New Wisej.Web.Label()
        Me.Label6 = New Wisej.Web.Label()
        Me.Label5 = New Wisej.Web.Label()
        Me.Label4 = New Wisej.Web.Label()
        Me.Label3 = New Wisej.Web.Label()
        Me.Label2 = New Wisej.Web.Label()
        Me.Label1 = New Wisej.Web.Label()
        Me.RFC_EST = New Wisej.Web.TextBox()
        Me.ID_PROPIETARIO = New Wisej.Web.ComboBox()
        Me.Label48 = New Wisej.Web.Label()
        Me.Editar_Propietario = New Wisej.Web.CheckBox()
        Me.Label9 = New Wisej.Web.Label()
        Me.DOMICILIO_PROPIETARIO = New Wisej.Web.TextBox()
        Me.NOMBRE_PROPIETARIO = New Wisej.Web.TextBox()
        Me.Label11 = New Wisej.Web.Label()
        Me.ESTABLECIMIENTO = New DPCRS.Combosax_B()
        Me.COLONIA_ESTABLECIMIENTOS = New DPCRS.Combosax_B()
        Me.CP_EST = New Wisej.Web.TextBox()
        Me.Editar_Domicilio = New Wisej.Web.CheckBox()
        Me.JURISDICCION_EST = New Wisej.Web.TextBox()
        Me.DOMICILIO_EST = New Wisej.Web.TextBox()
        Me.AddEstablecimiento = New Wisej.Web.Button()
        Me.GIRO_EST = New Wisej.Web.TextBox()
        Me.RAZON_SOCIAL_EST = New Wisej.Web.TextBox()
        Me.Label13 = New Wisej.Web.Label()
        Me.TabControl1 = New Wisej.Web.TabControl()
        Me.TabPage1 = New Wisej.Web.TabPage()
        Me.sig_pag1 = New Wisej.Web.Button()
        Me.TabPage2 = New Wisej.Web.TabPage()
        Me.FASE2 = New Wisej.Web.Panel()
        Me.Add_Muestras = New Wisej.Web.Button()
        Me.GroupBox1 = New Wisej.Web.GroupBox()
        Me.NO_MUESTRAS = New Wisej.Web.RadioButton()
        Me.ADD_MUESTRAS_TABLA = New Wisej.Web.RadioButton()
        Me.Label47 = New Wisej.Web.Label()
        Me.OBSERVACIONES_MUESTRAS = New Wisej.Web.TextBox()
        Me.MUESTRAS_GRID = New Wisej.Web.DataGridView()
        Me.cenum = New Wisej.Web.DataGridViewImageColumn()
        Me.CVE_TIPO_MUESTRA = New Wisej.Web.DataGridViewColumn()
        Me.CVE_TIPO_ANALISIS = New Wisej.Web.DataGridViewColumn()
        Me.DESCRIPCION = New Wisej.Web.DataGridViewColumn()
        Me.CLAVE_VS = New Wisej.Web.DataGridViewColumn()
        Me.MARCA = New Wisej.Web.DataGridViewColumn()
        Me.LOTE = New Wisej.Web.DataGridViewColumn()
        Me.FECHA = New Wisej.Web.DataGridViewColumn()
        Me.CANTIDAD = New Wisej.Web.DataGridViewColumn()
        Me.Label27 = New Wisej.Web.Label()
        Me.VERIFICADORES_GRID = New Wisej.Web.DataGridView()
        Me.Eliminar = New Wisej.Web.DataGridViewImageColumn()
        Me.Nombre = New Wisej.Web.DataGridViewColumn()
        Me.Jurisdiccion = New Wisej.Web.DataGridViewColumn()
        Me.CVE_VERIFICADOR = New Wisej.Web.DataGridViewColumn()
        Me.Sexo = New Wisej.Web.DataGridViewColumn()
        Me.Clave_Trabajador = New Wisej.Web.DataGridViewColumn()
        Me.AddVerificador = New Wisej.Web.Button()
        Me.VERIFICADORES = New DPCRS.Combosax_B()
        Me.sig_pag2 = New Wisej.Web.Button()
        Me.ant_pag2 = New Wisej.Web.Button()
        Me.TabPage3 = New Wisej.Web.TabPage()
        Me.FASE3 = New Wisej.Web.Panel()
        Me.HORA = New Wisej.Web.DateTimePicker()
        Me.NUM_ANEXOS = New Wisej.Web.NumericUpDown()
        Me.Anexar_Orden = New Wisej.Web.CheckBox()
        Me.Label20 = New Wisej.Web.Label()
        Me.Label7 = New Wisej.Web.Label()
        Me.FOLIO_ACTA_VERIFICACION = New Wisej.Web.TextBox()
        Me.Label39 = New Wisej.Web.Label()
        Me.OBSERVACIONES_GENERALES = New Wisej.Web.TextBox()
        Me.FECHA_VERIFICACION = New Wisej.Web.DateTimePicker()
        Me.Label22 = New Wisej.Web.Label()
        Me.FECHA_ORDEN = New Wisej.Web.DateTimePicker()
        Me.Label21 = New Wisej.Web.Label()
        Me.Label19 = New Wisej.Web.Label()
        Me.FOLIO_ORDEN = New Wisej.Web.TextBox()
        Me.Label41 = New Wisej.Web.Label()
        Me.TIPO_ACTA = New Wisej.Web.ComboBox()
        Me.Label42 = New Wisej.Web.Label()
        Me.MOTIVO = New Wisej.Web.ComboBox()
        Me.Label43 = New Wisej.Web.Label()
        Me.PROGRAMA = New Wisej.Web.ComboBox()
        Me.Label52 = New Wisej.Web.Label()
        Me.RESPONSABLE_ANALISIS = New Wisej.Web.ComboBox()
        Me.TIPO_OBJETIVO = New DPCRS.Combosax_B()
        Me.Label53 = New Wisej.Web.Label()
        Me.add_objetivo_alcance = New Wisej.Web.Button()
        Me.Panel7 = New Wisej.Web.Panel()
        Me.RadioButton5 = New Wisej.Web.RadioButton()
        Me.ANEXO = New Wisej.Web.RadioButton()
        Me.Panel14 = New Wisej.Web.Panel()
        Me.RadioButton7 = New Wisej.Web.RadioButton()
        Me.F_reubicacion_si = New Wisej.Web.RadioButton()
        Me.Panel16 = New Wisej.Web.Panel()
        Me.RadioButton9 = New Wisej.Web.RadioButton()
        Me.F_suspencion_si = New Wisej.Web.RadioButton()
        Me.Panel17 = New Wisej.Web.Panel()
        Me.RadioButton11 = New Wisej.Web.RadioButton()
        Me.F_aseguramiento_si = New Wisej.Web.RadioButton()
        Me.RadioButton13 = New Wisej.Web.RadioButton()
        Me.MEDIDAS_SEGURIDAD = New Wisej.Web.RadioButton()
        Me.FOLIO_REUBICACION = New Wisej.Web.TextBox()
        Me.FOLIO_SUSPENCION = New Wisej.Web.TextBox()
        Me.FOLIO_ASEGURAMIENTO = New Wisej.Web.TextBox()
        Me.Label56 = New Wisej.Web.Label()
        Me.Label57 = New Wisej.Web.Label()
        Me.Label58 = New Wisej.Web.Label()
        Me.Label59 = New Wisej.Web.Label()
        Me.Label60 = New Wisej.Web.Label()
        Me.Label61 = New Wisej.Web.Label()
        Me.Label62 = New Wisej.Web.Label()
        Me.Label63 = New Wisej.Web.Label()
        Me.Label64 = New Wisej.Web.Label()
        Me.sig_pag3 = New Wisej.Web.Button()
        Me.ant_pag3 = New Wisej.Web.Button()
        Me.TabPage4 = New Wisej.Web.TabPage()
        Me.FASE4 = New Wisej.Web.Panel()
        Me.finalizar = New Wisej.Web.Button()
        Me.ant_pag4 = New Wisej.Web.Button()
        Me.TabPage5 = New Wisej.Web.TabPage()
        Me.Button1 = New Wisej.Web.Button()
        Me.FASE5 = New Wisej.Web.Panel()
        Me.Button2 = New Wisej.Web.Button()
        Me.CVE_ACTA_TEXT = New Wisej.Web.TextBox()
        Me.ErrorProvider1 = New Wisej.Web.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.FASE1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.FASE2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MUESTRAS_GRID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VERIFICADORES_GRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.FASE3.SuspendLayout()
        CType(Me.NUM_ANEXOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Dock = Wisej.Web.DockStyle.Top
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(1198, 109)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Text = "Acciones"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.NUEVO)
        Me.RibbonBarGroup1.Items.Add(Me.SALIR)
        Me.RibbonBarGroup1.Text = "Acta"
        '
        'NUEVO
        '
        Me.NUEVO.ImageSource = "Resources\Images\Menu\64\doc .png"
        Me.NUEVO.Name = "NUEVO"
        Me.NUEVO.Text = "Nuevo"
        '
        'SALIR
        '
        Me.SALIR.ImageSource = "Resources\Images\Menu\30\exit-sign-red.png"
        Me.SALIR.Name = "SALIR"
        Me.SALIR.Text = "Salir"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FASE1)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.ScrollBars = Wisej.Web.ScrollBars.Vertical
        Me.Panel1.Size = New System.Drawing.Size(1189, 545)
        Me.Panel1.TabIndex = 6
        '
        'FASE1
        '
        Me.FASE1.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.FASE1.Controls.Add(Me.Line1)
        Me.FASE1.Controls.Add(Me.Label25)
        Me.FASE1.Controls.Add(Me.Label26)
        Me.FASE1.Controls.Add(Me.Label28)
        Me.FASE1.Controls.Add(Me.ID_TESTIGO2)
        Me.FASE1.Controls.Add(Me.DOM_TESTIGO2)
        Me.FASE1.Controls.Add(Me.NOMBRE_TESTIGO2)
        Me.FASE1.Controls.Add(Me.Label23)
        Me.FASE1.Controls.Add(Me.Label18)
        Me.FASE1.Controls.Add(Me.Label17)
        Me.FASE1.Controls.Add(Me.Label16)
        Me.FASE1.Controls.Add(Me.Label15)
        Me.FASE1.Controls.Add(Me.Label14)
        Me.FASE1.Controls.Add(Me.TESTIGO2)
        Me.FASE1.Controls.Add(Me.TESTIGO1)
        Me.FASE1.Controls.Add(Me.Label46)
        Me.FASE1.Controls.Add(Me.ID_TESTIGO1)
        Me.FASE1.Controls.Add(Me.DOM_TESTIGO1)
        Me.FASE1.Controls.Add(Me.NOMBRE_TESTIGO1)
        Me.FASE1.Controls.Add(Me.GroupBox2)
        Me.FASE1.Controls.Add(Me.CARGO_RESPONSABLE)
        Me.FASE1.Controls.Add(Me.Label45)
        Me.FASE1.Controls.Add(Me.ID_RESPONSABLE)
        Me.FASE1.Controls.Add(Me.DOMICILIO_RESPONSABLE)
        Me.FASE1.Controls.Add(Me.NOMBRE_RESPONSABLE)
        Me.FASE1.Controls.Add(Me.Label12)
        Me.FASE1.Controls.Add(Me.Label8)
        Me.FASE1.Controls.Add(Me.Label6)
        Me.FASE1.Controls.Add(Me.Label5)
        Me.FASE1.Controls.Add(Me.Label4)
        Me.FASE1.Controls.Add(Me.Label3)
        Me.FASE1.Controls.Add(Me.Label2)
        Me.FASE1.Controls.Add(Me.Label1)
        Me.FASE1.Controls.Add(Me.RFC_EST)
        Me.FASE1.Controls.Add(Me.ID_PROPIETARIO)
        Me.FASE1.Controls.Add(Me.Label48)
        Me.FASE1.Controls.Add(Me.Editar_Propietario)
        Me.FASE1.Controls.Add(Me.Label9)
        Me.FASE1.Controls.Add(Me.DOMICILIO_PROPIETARIO)
        Me.FASE1.Controls.Add(Me.NOMBRE_PROPIETARIO)
        Me.FASE1.Controls.Add(Me.Label11)
        Me.FASE1.Controls.Add(Me.ESTABLECIMIENTO)
        Me.FASE1.Controls.Add(Me.COLONIA_ESTABLECIMIENTOS)
        Me.FASE1.Controls.Add(Me.CP_EST)
        Me.FASE1.Controls.Add(Me.Editar_Domicilio)
        Me.FASE1.Controls.Add(Me.JURISDICCION_EST)
        Me.FASE1.Controls.Add(Me.DOMICILIO_EST)
        Me.FASE1.Controls.Add(Me.AddEstablecimiento)
        Me.FASE1.Controls.Add(Me.GIRO_EST)
        Me.FASE1.Controls.Add(Me.RAZON_SOCIAL_EST)
        Me.FASE1.Dock = Wisej.Web.DockStyle.Top
        Me.FASE1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.FASE1.HeaderForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.FASE1.Location = New System.Drawing.Point(0, 0)
        Me.FASE1.Name = "FASE1"
        Me.FASE1.ShowCloseButton = False
        Me.FASE1.ShowHeader = True
        Me.FASE1.Size = New System.Drawing.Size(1189, 542)
        Me.FASE1.TabIndex = 8
        Me.FASE1.Text = "Verifique o Actualice Datos del Establecimiento"
        '
        'Line1
        '
        Me.Line1.LineColor = System.Drawing.Color.FromName("@switchUndetermined")
        Me.Line1.LineSize = 2
        Me.Line1.LineStyle = Wisej.Web.LineStyle.Dashed
        Me.Line1.Location = New System.Drawing.Point(8, 253)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(1162, 10)
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label25.Location = New System.Drawing.Point(800, 447)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(227, 16)
        Me.Label25.TabIndex = 171
        Me.Label25.Text = "Identificacion Oficial"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label26.Location = New System.Drawing.Point(800, 357)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(227, 16)
        Me.Label26.TabIndex = 170
        Me.Label26.Text = "Domicilio"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label28.Location = New System.Drawing.Point(800, 311)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(227, 16)
        Me.Label28.TabIndex = 169
        Me.Label28.Text = "Nombre Completo"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ID_TESTIGO2
        '
        Me.ID_TESTIGO2.Enabled = False
        Me.ID_TESTIGO2.Items.AddRange(New Object() {"INE o IFE", "Pasaporte", "Licencia de Conducir", "Cartilla Militar", "Otro.."})
        Me.ID_TESTIGO2.Location = New System.Drawing.Point(800, 469)
        Me.ID_TESTIGO2.Name = "ID_TESTIGO2"
        Me.ID_TESTIGO2.Size = New System.Drawing.Size(356, 22)
        Me.ID_TESTIGO2.TabIndex = 168
        '
        'DOM_TESTIGO2
        '
        Me.DOM_TESTIGO2.AutoSize = False
        Me.DOM_TESTIGO2.Enabled = False
        Me.DOM_TESTIGO2.Location = New System.Drawing.Point(800, 374)
        Me.DOM_TESTIGO2.Multiline = True
        Me.DOM_TESTIGO2.Name = "DOM_TESTIGO2"
        Me.DOM_TESTIGO2.Size = New System.Drawing.Size(356, 70)
        Me.DOM_TESTIGO2.TabIndex = 167
        '
        'NOMBRE_TESTIGO2
        '
        Me.NOMBRE_TESTIGO2.Enabled = False
        Me.NOMBRE_TESTIGO2.Location = New System.Drawing.Point(800, 333)
        Me.NOMBRE_TESTIGO2.Name = "NOMBRE_TESTIGO2"
        Me.NOMBRE_TESTIGO2.Size = New System.Drawing.Size(356, 22)
        Me.NOMBRE_TESTIGO2.TabIndex = 166
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label23.Location = New System.Drawing.Point(400, 447)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(227, 16)
        Me.Label23.TabIndex = 165
        Me.Label23.Text = "Identificacion Oficial"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label18.Location = New System.Drawing.Point(400, 357)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(227, 16)
        Me.Label18.TabIndex = 164
        Me.Label18.Text = "Domicilio"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label17.Location = New System.Drawing.Point(400, 311)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(227, 16)
        Me.Label17.TabIndex = 163
        Me.Label17.Text = "Nombre Completo"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label16.Location = New System.Drawing.Point(14, 457)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(227, 16)
        Me.Label16.TabIndex = 162
        Me.Label16.Text = "Cargo del Responsable"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label15.Location = New System.Drawing.Point(14, 407)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(227, 16)
        Me.Label15.TabIndex = 161
        Me.Label15.Text = "Indentificacion Oficial"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label14.Location = New System.Drawing.Point(14, 364)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(227, 16)
        Me.Label14.TabIndex = 160
        Me.Label14.Text = "Domicilio del Responsable"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TESTIGO2
        '
        Me.TESTIGO2.Location = New System.Drawing.Point(802, 284)
        Me.TESTIGO2.Name = "TESTIGO2"
        Me.TESTIGO2.Size = New System.Drawing.Size(169, 23)
        Me.TESTIGO2.TabIndex = 159
        Me.TESTIGO2.Text = "Asignar segundo testigo"
        '
        'TESTIGO1
        '
        Me.TESTIGO1.Location = New System.Drawing.Point(406, 284)
        Me.TESTIGO1.Name = "TESTIGO1"
        Me.TESTIGO1.Size = New System.Drawing.Size(170, 23)
        Me.TESTIGO1.TabIndex = 158
        Me.TESTIGO1.Text = "Asignar el primer testigo"
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label46.Location = New System.Drawing.Point(406, 269)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(183, 16)
        Me.Label46.TabIndex = 157
        Me.Label46.Text = "Testigos:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ID_TESTIGO1
        '
        Me.ID_TESTIGO1.Enabled = False
        Me.ID_TESTIGO1.Items.AddRange(New Object() {"INE o IFE", "Pasaporte", "Licencia de Conducir", "Cartilla Militar", "Otro.."})
        Me.ID_TESTIGO1.Location = New System.Drawing.Point(400, 469)
        Me.ID_TESTIGO1.Name = "ID_TESTIGO1"
        Me.ID_TESTIGO1.Size = New System.Drawing.Size(356, 22)
        Me.ID_TESTIGO1.TabIndex = 156
        '
        'DOM_TESTIGO1
        '
        Me.DOM_TESTIGO1.AutoSize = False
        Me.DOM_TESTIGO1.Enabled = False
        Me.DOM_TESTIGO1.Location = New System.Drawing.Point(400, 374)
        Me.DOM_TESTIGO1.Multiline = True
        Me.DOM_TESTIGO1.Name = "DOM_TESTIGO1"
        Me.DOM_TESTIGO1.Size = New System.Drawing.Size(356, 70)
        Me.DOM_TESTIGO1.TabIndex = 155
        '
        'NOMBRE_TESTIGO1
        '
        Me.NOMBRE_TESTIGO1.Enabled = False
        Me.NOMBRE_TESTIGO1.Location = New System.Drawing.Point(400, 333)
        Me.NOMBRE_TESTIGO1.Name = "NOMBRE_TESTIGO1"
        Me.NOMBRE_TESTIGO1.Size = New System.Drawing.Size(356, 22)
        Me.NOMBRE_TESTIGO1.TabIndex = 154
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.no)
        Me.GroupBox2.Controls.Add(Me.PROPIETARIO_RESPONSABLE)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 269)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 45)
        Me.GroupBox2.TabIndex = 148
        Me.GroupBox2.Text = "¿El dueño es quien recibio a los Verificadores?"
        '
        'no
        '
        Me.no.AutoSize = False
        Me.no.Checked = True
        Me.no.Location = New System.Drawing.Point(183, 21)
        Me.no.Name = "no"
        Me.no.Size = New System.Drawing.Size(72, 22)
        Me.no.TabIndex = 3
        Me.no.Text = "NO"
        '
        'PROPIETARIO_RESPONSABLE
        '
        Me.PROPIETARIO_RESPONSABLE.AutoSize = False
        Me.PROPIETARIO_RESPONSABLE.Location = New System.Drawing.Point(26, 21)
        Me.PROPIETARIO_RESPONSABLE.Name = "PROPIETARIO_RESPONSABLE"
        Me.PROPIETARIO_RESPONSABLE.Size = New System.Drawing.Size(86, 22)
        Me.PROPIETARIO_RESPONSABLE.TabIndex = 2
        Me.PROPIETARIO_RESPONSABLE.TabStop = False
        Me.PROPIETARIO_RESPONSABLE.Text = "SI"
        '
        'CARGO_RESPONSABLE
        '
        Me.CARGO_RESPONSABLE.Location = New System.Drawing.Point(14, 477)
        Me.CARGO_RESPONSABLE.Name = "CARGO_RESPONSABLE"
        Me.CARGO_RESPONSABLE.Size = New System.Drawing.Size(356, 22)
        Me.CARGO_RESPONSABLE.TabIndex = 153
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label45.Location = New System.Drawing.Point(14, 318)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(227, 16)
        Me.Label45.TabIndex = 152
        Me.Label45.Text = "Nombre Completo del Responsable"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ID_RESPONSABLE
        '
        Me.ID_RESPONSABLE.Items.AddRange(New Object() {"INE o IFE", "Pasaporte", "Licencia de Conducir", "Cartilla Militar", "Otro.."})
        Me.ID_RESPONSABLE.Location = New System.Drawing.Point(14, 429)
        Me.ID_RESPONSABLE.Name = "ID_RESPONSABLE"
        Me.ID_RESPONSABLE.ReadOnly = True
        Me.ID_RESPONSABLE.Size = New System.Drawing.Size(356, 22)
        Me.ID_RESPONSABLE.TabIndex = 151
        '
        'DOMICILIO_RESPONSABLE
        '
        Me.DOMICILIO_RESPONSABLE.Location = New System.Drawing.Point(14, 381)
        Me.DOMICILIO_RESPONSABLE.Name = "DOMICILIO_RESPONSABLE"
        Me.DOMICILIO_RESPONSABLE.Size = New System.Drawing.Size(356, 22)
        Me.DOMICILIO_RESPONSABLE.TabIndex = 150
        '
        'NOMBRE_RESPONSABLE
        '
        Me.NOMBRE_RESPONSABLE.Location = New System.Drawing.Point(14, 340)
        Me.NOMBRE_RESPONSABLE.Name = "NOMBRE_RESPONSABLE"
        Me.NOMBRE_RESPONSABLE.Size = New System.Drawing.Size(356, 22)
        Me.NOMBRE_RESPONSABLE.TabIndex = 149
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label12.Location = New System.Drawing.Point(406, 203)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 16)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Codigo Postal"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label8.Location = New System.Drawing.Point(406, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(288, 16)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Descripcion del Domicilio del Establecimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label6.Location = New System.Drawing.Point(406, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(338, 16)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Seleccione una Colonia en caso de Editar el domicilio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label5.Location = New System.Drawing.Point(12, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 16)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "RFC del Establecimiento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label4.Location = New System.Drawing.Point(14, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 16)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Giro:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.Location = New System.Drawing.Point(14, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Razon Social:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Jurisdiccion:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.Location = New System.Drawing.Point(12, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 16)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Seleccionar Establecimiento"
        '
        'RFC_EST
        '
        Me.RFC_EST.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.RFC_EST.Location = New System.Drawing.Point(12, 225)
        Me.RFC_EST.Name = "RFC_EST"
        Me.RFC_EST.ReadOnly = True
        Me.RFC_EST.Size = New System.Drawing.Size(356, 22)
        Me.RFC_EST.TabIndex = 36
        '
        'ID_PROPIETARIO
        '
        Me.ID_PROPIETARIO.DisplayMember = "documento con el que valida su identidad"
        Me.ID_PROPIETARIO.Items.AddRange(New Object() {"INE o IFE", "Pasaporte", "Licencia de Conducir", "Cartilla Militar", "Otro.."})
        Me.ID_PROPIETARIO.Location = New System.Drawing.Point(801, 103)
        Me.ID_PROPIETARIO.Name = "ID_PROPIETARIO"
        Me.ID_PROPIETARIO.ReadOnly = True
        Me.ID_PROPIETARIO.Size = New System.Drawing.Size(355, 22)
        Me.ID_PROPIETARIO.TabIndex = 35
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label48.Location = New System.Drawing.Point(800, 81)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(165, 16)
        Me.Label48.TabIndex = 34
        Me.Label48.Text = "Identificacion Propietario:"
        '
        'Editar_Propietario
        '
        Me.Editar_Propietario.AutoSize = False
        Me.Editar_Propietario.Font = New System.Drawing.Font("default", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Editar_Propietario.Location = New System.Drawing.Point(800, -2)
        Me.Editar_Propietario.Name = "Editar_Propietario"
        Me.Editar_Propietario.Size = New System.Drawing.Size(189, 24)
        Me.Editar_Propietario.TabIndex = 27
        Me.Editar_Propietario.Text = "Editar Propietario"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label9.Location = New System.Drawing.Point(802, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(163, 16)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Domicilio del Propietario:"
        '
        'DOMICILIO_PROPIETARIO
        '
        Me.DOMICILIO_PROPIETARIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.DOMICILIO_PROPIETARIO.Location = New System.Drawing.Point(801, 153)
        Me.DOMICILIO_PROPIETARIO.Multiline = True
        Me.DOMICILIO_PROPIETARIO.Name = "DOMICILIO_PROPIETARIO"
        Me.DOMICILIO_PROPIETARIO.ReadOnly = True
        Me.DOMICILIO_PROPIETARIO.Size = New System.Drawing.Size(355, 94)
        Me.DOMICILIO_PROPIETARIO.TabIndex = 32
        '
        'NOMBRE_PROPIETARIO
        '
        Me.NOMBRE_PROPIETARIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.NOMBRE_PROPIETARIO.Location = New System.Drawing.Point(800, 53)
        Me.NOMBRE_PROPIETARIO.Name = "NOMBRE_PROPIETARIO"
        Me.NOMBRE_PROPIETARIO.ReadOnly = True
        Me.NOMBRE_PROPIETARIO.Size = New System.Drawing.Size(356, 22)
        Me.NOMBRE_PROPIETARIO.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label11.Location = New System.Drawing.Point(801, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(155, 16)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Nombre del Propietario:"
        '
        'ESTABLECIMIENTO
        '
        Me.ESTABLECIMIENTO.amarillo = False
        Me.ESTABLECIMIENTO.Ancho = Nothing
        Me.ESTABLECIMIENTO.BackColor = System.Drawing.Color.FromName("@window")
        Me.ESTABLECIMIENTO.ColorAtras = System.Drawing.Color.Empty
        Me.ESTABLECIMIENTO.Count = 0
        Me.ESTABLECIMIENTO.DataSource = Nothing
        Me.ESTABLECIMIENTO.DataSourceSelect = Nothing
        Me.ESTABLECIMIENTO.gris = False
        Me.ESTABLECIMIENTO.Letra = Nothing
        Me.ESTABLECIMIENTO.Limitar = False
        Me.ESTABLECIMIENTO.Location = New System.Drawing.Point(12, 25)
        Me.ESTABLECIMIENTO.MensajeAgua = Nothing
        Me.ESTABLECIMIENTO.mostrarMensaje = False
        Me.ESTABLECIMIENTO.Name = "ESTABLECIMIENTO"
        Me.ESTABLECIMIENTO.Negritas = False
        Me.ESTABLECIMIENTO.OBTENERLISTLLENADO = Nothing
        Me.ESTABLECIMIENTO.procedure = Nothing
        Me.ESTABLECIMIENTO.SelectedIndex = -1
        Me.ESTABLECIMIENTO.SelectedItem = ""
        Me.ESTABLECIMIENTO.SelectedValue = Nothing
        Me.ESTABLECIMIENTO.Size = New System.Drawing.Size(310, 22)
        Me.ESTABLECIMIENTO.TabIndex = 26
        Me.ESTABLECIMIENTO.TODOSS = False
        Me.ESTABLECIMIENTO.Watermark = Nothing
        '
        'COLONIA_ESTABLECIMIENTOS
        '
        Me.COLONIA_ESTABLECIMIENTOS.amarillo = False
        Me.COLONIA_ESTABLECIMIENTOS.Ancho = Nothing
        Me.COLONIA_ESTABLECIMIENTOS.BackColor = System.Drawing.Color.FromName("@window")
        Me.COLONIA_ESTABLECIMIENTOS.ColorAtras = System.Drawing.Color.Empty
        Me.COLONIA_ESTABLECIMIENTOS.Count = 0
        Me.COLONIA_ESTABLECIMIENTOS.DataSource = Nothing
        Me.COLONIA_ESTABLECIMIENTOS.DataSourceSelect = Nothing
        Me.COLONIA_ESTABLECIMIENTOS.gris = False
        Me.COLONIA_ESTABLECIMIENTOS.Letra = Nothing
        Me.COLONIA_ESTABLECIMIENTOS.Limitar = False
        Me.COLONIA_ESTABLECIMIENTOS.Location = New System.Drawing.Point(406, 53)
        Me.COLONIA_ESTABLECIMIENTOS.MensajeAgua = Nothing
        Me.COLONIA_ESTABLECIMIENTOS.mostrarMensaje = False
        Me.COLONIA_ESTABLECIMIENTOS.Name = "COLONIA_ESTABLECIMIENTOS"
        Me.COLONIA_ESTABLECIMIENTOS.Negritas = False
        Me.COLONIA_ESTABLECIMIENTOS.OBTENERLISTLLENADO = Nothing
        Me.COLONIA_ESTABLECIMIENTOS.procedure = Nothing
        Me.COLONIA_ESTABLECIMIENTOS.SelectedIndex = -1
        Me.COLONIA_ESTABLECIMIENTOS.SelectedItem = ""
        Me.COLONIA_ESTABLECIMIENTOS.SelectedValue = Nothing
        Me.COLONIA_ESTABLECIMIENTOS.Size = New System.Drawing.Size(350, 22)
        Me.COLONIA_ESTABLECIMIENTOS.TabIndex = 25
        Me.COLONIA_ESTABLECIMIENTOS.TODOSS = False
        Me.COLONIA_ESTABLECIMIENTOS.Watermark = Nothing
        '
        'CP_EST
        '
        Me.CP_EST.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.CP_EST.Location = New System.Drawing.Point(406, 225)
        Me.CP_EST.Name = "CP_EST"
        Me.CP_EST.ReadOnly = True
        Me.CP_EST.Size = New System.Drawing.Size(350, 22)
        Me.CP_EST.TabIndex = 19
        '
        'Editar_Domicilio
        '
        Me.Editar_Domicilio.AutoSize = False
        Me.Editar_Domicilio.Font = New System.Drawing.Font("default", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Editar_Domicilio.Location = New System.Drawing.Point(429, -2)
        Me.Editar_Domicilio.Name = "Editar_Domicilio"
        Me.Editar_Domicilio.Size = New System.Drawing.Size(299, 24)
        Me.Editar_Domicilio.TabIndex = 16
        Me.Editar_Domicilio.Text = "Editar Direccion del Establecimiento:"
        '
        'JURISDICCION_EST
        '
        Me.JURISDICCION_EST.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.JURISDICCION_EST.Location = New System.Drawing.Point(12, 75)
        Me.JURISDICCION_EST.Name = "JURISDICCION_EST"
        Me.JURISDICCION_EST.ReadOnly = True
        Me.JURISDICCION_EST.Size = New System.Drawing.Size(356, 22)
        Me.JURISDICCION_EST.TabIndex = 14
        '
        'DOMICILIO_EST
        '
        Me.DOMICILIO_EST.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.DOMICILIO_EST.Location = New System.Drawing.Point(406, 103)
        Me.DOMICILIO_EST.Multiline = True
        Me.DOMICILIO_EST.Name = "DOMICILIO_EST"
        Me.DOMICILIO_EST.ReadOnly = True
        Me.DOMICILIO_EST.Size = New System.Drawing.Size(350, 96)
        Me.DOMICILIO_EST.TabIndex = 10
        '
        'AddEstablecimiento
        '
        Me.AddEstablecimiento.AutoSize = True
        Me.AddEstablecimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.AddEstablecimiento.ImageSource = "Resources\Icons\Menu\add.png"
        Me.AddEstablecimiento.Location = New System.Drawing.Point(328, 20)
        Me.AddEstablecimiento.Name = "AddEstablecimiento"
        Me.AddEstablecimiento.Size = New System.Drawing.Size(40, 27)
        Me.AddEstablecimiento.TabIndex = 9
        '
        'GIRO_EST
        '
        Me.GIRO_EST.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.GIRO_EST.Location = New System.Drawing.Point(12, 175)
        Me.GIRO_EST.Name = "GIRO_EST"
        Me.GIRO_EST.ReadOnly = True
        Me.GIRO_EST.Size = New System.Drawing.Size(356, 22)
        Me.GIRO_EST.TabIndex = 8
        '
        'RAZON_SOCIAL_EST
        '
        Me.RAZON_SOCIAL_EST.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.RAZON_SOCIAL_EST.Location = New System.Drawing.Point(14, 125)
        Me.RAZON_SOCIAL_EST.Name = "RAZON_SOCIAL_EST"
        Me.RAZON_SOCIAL_EST.ReadOnly = True
        Me.RAZON_SOCIAL_EST.Size = New System.Drawing.Size(356, 22)
        Me.RAZON_SOCIAL_EST.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(35, 150)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(4, 15)
        Me.Label13.TabIndex = 6
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Dock = Wisej.Web.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 109)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.PageInsets = New Wisej.Web.Padding(1, 30, 1, 1)
        Me.TabControl1.Size = New System.Drawing.Size(1198, 637)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.sig_pag1)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.ImageSource = "Resources\Images\Menu\64\establecimiento1.png"
        Me.TabPage1.Location = New System.Drawing.Point(1, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Text = "Establecimiento & Propietario"
        '
        'sig_pag1
        '
        Me.sig_pag1.AutoSize = True
        Me.sig_pag1.Location = New System.Drawing.Point(510, 569)
        Me.sig_pag1.Name = "sig_pag1"
        Me.sig_pag1.Size = New System.Drawing.Size(110, 27)
        Me.sig_pag1.TabIndex = 7
        Me.sig_pag1.Text = "Siguiente"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.FASE2)
        Me.TabPage2.Controls.Add(Me.sig_pag2)
        Me.TabPage2.Controls.Add(Me.ant_pag2)
        Me.TabPage2.ImageSource = "Resources\Images\Menu\64\certificate .png"
        Me.TabPage2.Location = New System.Drawing.Point(1, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Text = "Verificadores & Muestreo"
        '
        'FASE2
        '
        Me.FASE2.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.FASE2.Controls.Add(Me.Add_Muestras)
        Me.FASE2.Controls.Add(Me.GroupBox1)
        Me.FASE2.Controls.Add(Me.Label47)
        Me.FASE2.Controls.Add(Me.OBSERVACIONES_MUESTRAS)
        Me.FASE2.Controls.Add(Me.MUESTRAS_GRID)
        Me.FASE2.Controls.Add(Me.Label27)
        Me.FASE2.Controls.Add(Me.VERIFICADORES_GRID)
        Me.FASE2.Controls.Add(Me.AddVerificador)
        Me.FASE2.Controls.Add(Me.VERIFICADORES)
        Me.FASE2.Location = New System.Drawing.Point(3, 3)
        Me.FASE2.Name = "FASE2"
        Me.FASE2.ShowCloseButton = False
        Me.FASE2.ShowHeader = True
        Me.FASE2.Size = New System.Drawing.Size(1189, 537)
        Me.FASE2.TabIndex = 61
        Me.FASE2.Text = "Recoleccion de Muestras & Verificadores"
        '
        'Add_Muestras
        '
        Me.Add_Muestras.Enabled = False
        Me.Add_Muestras.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Add_Muestras.ImageSource = "Resources\Images\Menu\64\015-pipette .png"
        Me.Add_Muestras.Location = New System.Drawing.Point(19, 297)
        Me.Add_Muestras.Name = "Add_Muestras"
        Me.Add_Muestras.Size = New System.Drawing.Size(275, 27)
        Me.Add_Muestras.TabIndex = 109
        Me.Add_Muestras.Text = "Ingresar Muestras al Acta"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NO_MUESTRAS)
        Me.GroupBox1.Controls.Add(Me.ADD_MUESTRAS_TABLA)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 238)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 37)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.Text = "¿Se toma muestra de producto?"
        '
        'NO_MUESTRAS
        '
        Me.NO_MUESTRAS.AutoSize = False
        Me.NO_MUESTRAS.Checked = True
        Me.NO_MUESTRAS.Location = New System.Drawing.Point(131, 12)
        Me.NO_MUESTRAS.Name = "NO_MUESTRAS"
        Me.NO_MUESTRAS.Size = New System.Drawing.Size(59, 23)
        Me.NO_MUESTRAS.TabIndex = 1
        Me.NO_MUESTRAS.Text = "NO"
        '
        'ADD_MUESTRAS_TABLA
        '
        Me.ADD_MUESTRAS_TABLA.AutoSize = False
        Me.ADD_MUESTRAS_TABLA.Location = New System.Drawing.Point(48, 12)
        Me.ADD_MUESTRAS_TABLA.Name = "ADD_MUESTRAS_TABLA"
        Me.ADD_MUESTRAS_TABLA.Size = New System.Drawing.Size(55, 23)
        Me.ADD_MUESTRAS_TABLA.TabIndex = 0
        Me.ADD_MUESTRAS_TABLA.TabStop = False
        Me.ADD_MUESTRAS_TABLA.Text = "SI"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label47.Location = New System.Drawing.Point(19, 393)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(215, 16)
        Me.Label47.TabIndex = 107
        Me.Label47.Text = "Observaciones sobre el Muestreo"
        '
        'OBSERVACIONES_MUESTRAS
        '
        Me.OBSERVACIONES_MUESTRAS.AutoSize = False
        Me.OBSERVACIONES_MUESTRAS.Enabled = False
        Me.OBSERVACIONES_MUESTRAS.Location = New System.Drawing.Point(19, 415)
        Me.OBSERVACIONES_MUESTRAS.Multiline = True
        Me.OBSERVACIONES_MUESTRAS.Name = "OBSERVACIONES_MUESTRAS"
        Me.OBSERVACIONES_MUESTRAS.Size = New System.Drawing.Size(1136, 85)
        Me.OBSERVACIONES_MUESTRAS.TabIndex = 106
        '
        'MUESTRAS_GRID
        '
        Me.MUESTRAS_GRID.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.cenum, Me.CVE_TIPO_MUESTRA, Me.CVE_TIPO_ANALISIS, Me.DESCRIPCION, Me.CLAVE_VS, Me.MARCA, Me.LOTE, Me.FECHA, Me.CANTIDAD})
        Me.MUESTRAS_GRID.Enabled = False
        Me.MUESTRAS_GRID.Location = New System.Drawing.Point(308, 221)
        Me.MUESTRAS_GRID.Name = "MUESTRAS_GRID"
        Me.MUESTRAS_GRID.Size = New System.Drawing.Size(849, 166)
        Me.MUESTRAS_GRID.TabIndex = 99
        '
        'cenum
        '
        Me.cenum.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        Me.cenum.CellImageSource = "Resources\Icons\Menu\error_color.png"
        Me.cenum.Name = "cenum"
        Me.cenum.Width = 30
        '
        'CVE_TIPO_MUESTRA
        '
        Me.CVE_TIPO_MUESTRA.HeaderText = "CVE_TIPO_MUESTRA"
        Me.CVE_TIPO_MUESTRA.Name = "CVE_TIPO_MUESTRA"
        Me.CVE_TIPO_MUESTRA.Visible = False
        '
        'CVE_TIPO_ANALISIS
        '
        Me.CVE_TIPO_ANALISIS.HeaderText = "CVE_TIPO_ANALISIS"
        Me.CVE_TIPO_ANALISIS.Name = "CVE_TIPO_ANALISIS"
        Me.CVE_TIPO_ANALISIS.Visible = False
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.HeaderText = "Descripcion"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.Width = 250
        '
        'CLAVE_VS
        '
        Me.CLAVE_VS.HeaderText = "Clave VS"
        Me.CLAVE_VS.Name = "CLAVE_VS"
        '
        'MARCA
        '
        Me.MARCA.HeaderText = "Marca"
        Me.MARCA.Name = "MARCA"
        Me.MARCA.Width = 150
        '
        'LOTE
        '
        Me.LOTE.HeaderText = "Lote"
        Me.LOTE.Name = "LOTE"
        Me.LOTE.Width = 150
        '
        'FECHA
        '
        Me.FECHA.HeaderText = "Caducidad"
        Me.FECHA.Name = "FECHA"
        Me.FECHA.Width = 200
        '
        'CANTIDAD
        '
        Me.CANTIDAD.HeaderText = "Cantidad"
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.Width = 200
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label27.ForeColor = System.Drawing.Color.FromName("@windowText")
        Me.Label27.Location = New System.Drawing.Point(67, 39)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(191, 16)
        Me.Label27.TabIndex = 67
        Me.Label27.Text = "Selecciones los Verifcadores:"
        '
        'VERIFICADORES_GRID
        '
        Me.VERIFICADORES_GRID.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.Eliminar, Me.Nombre, Me.Jurisdiccion, Me.CVE_VERIFICADOR, Me.Sexo, Me.Clave_Trabajador})
        Me.VERIFICADORES_GRID.Location = New System.Drawing.Point(308, 3)
        Me.VERIFICADORES_GRID.Name = "VERIFICADORES_GRID"
        Me.VERIFICADORES_GRID.Size = New System.Drawing.Size(849, 192)
        Me.VERIFICADORES_GRID.TabIndex = 62
        '
        'Eliminar
        '
        Me.Eliminar.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.Eliminar.CellImageSource = "Resources\Icons\Menu\error_color.png"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Width = 30
        '
        'Nombre
        '
        Me.Nombre.FillWeight = 200.0!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 300
        '
        'Jurisdiccion
        '
        Me.Jurisdiccion.FillWeight = 150.0!
        Me.Jurisdiccion.HeaderText = "Jurisdiccion"
        Me.Jurisdiccion.Name = "Jurisdiccion"
        Me.Jurisdiccion.Width = 250
        '
        'CVE_VERIFICADOR
        '
        Me.CVE_VERIFICADOR.FillWeight = 50.0!
        Me.CVE_VERIFICADOR.HeaderText = "Cve_Verificador"
        Me.CVE_VERIFICADOR.Name = "CVE_VERIFICADOR"
        Me.CVE_VERIFICADOR.Width = 150
        '
        'Sexo
        '
        Me.Sexo.FillWeight = 50.0!
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.Name = "Sexo"
        Me.Sexo.Width = 150
        '
        'Clave_Trabajador
        '
        Me.Clave_Trabajador.HeaderText = "Clave Trabajador"
        Me.Clave_Trabajador.Name = "Clave_Trabajador"
        Me.Clave_Trabajador.Width = 200
        '
        'AddVerificador
        '
        Me.AddVerificador.AutoSize = True
        Me.AddVerificador.ImageSource = "Resources\Icons\Menu\add.png"
        Me.AddVerificador.Location = New System.Drawing.Point(19, 111)
        Me.AddVerificador.Name = "AddVerificador"
        Me.AddVerificador.Size = New System.Drawing.Size(275, 27)
        Me.AddVerificador.TabIndex = 64
        Me.AddVerificador.Text = "Alta de Nuevo Verificador Sanitario"
        '
        'VERIFICADORES
        '
        Me.VERIFICADORES.amarillo = False
        Me.VERIFICADORES.Ancho = Nothing
        Me.VERIFICADORES.BackColor = System.Drawing.Color.FromName("@window")
        Me.VERIFICADORES.ColorAtras = System.Drawing.Color.Empty
        Me.VERIFICADORES.Count = 0
        Me.VERIFICADORES.DataSource = Nothing
        Me.VERIFICADORES.DataSourceSelect = Nothing
        Me.VERIFICADORES.gris = False
        Me.VERIFICADORES.Letra = Nothing
        Me.VERIFICADORES.Limitar = False
        Me.VERIFICADORES.Location = New System.Drawing.Point(19, 74)
        Me.VERIFICADORES.MensajeAgua = Nothing
        Me.VERIFICADORES.mostrarMensaje = False
        Me.VERIFICADORES.Name = "VERIFICADORES"
        Me.VERIFICADORES.Negritas = False
        Me.VERIFICADORES.OBTENERLISTLLENADO = Nothing
        Me.VERIFICADORES.procedure = Nothing
        Me.VERIFICADORES.SelectedIndex = -1
        Me.VERIFICADORES.SelectedItem = ""
        Me.VERIFICADORES.SelectedValue = Nothing
        Me.VERIFICADORES.Size = New System.Drawing.Size(275, 22)
        Me.VERIFICADORES.TabIndex = 0
        Me.VERIFICADORES.TODOSS = False
        Me.VERIFICADORES.Watermark = Nothing
        '
        'sig_pag2
        '
        Me.sig_pag2.Location = New System.Drawing.Point(1072, 565)
        Me.sig_pag2.Name = "sig_pag2"
        Me.sig_pag2.Size = New System.Drawing.Size(100, 27)
        Me.sig_pag2.TabIndex = 60
        Me.sig_pag2.Text = "Siguiente"
        '
        'ant_pag2
        '
        Me.ant_pag2.Location = New System.Drawing.Point(3, 565)
        Me.ant_pag2.Name = "ant_pag2"
        Me.ant_pag2.Size = New System.Drawing.Size(100, 27)
        Me.ant_pag2.TabIndex = 59
        Me.ant_pag2.Text = "Anterior"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.FASE3)
        Me.TabPage3.Controls.Add(Me.sig_pag3)
        Me.TabPage3.Controls.Add(Me.ant_pag3)
        Me.TabPage3.ImageSource = "Resources\Images\Menu\64\learning .png"
        Me.TabPage3.Location = New System.Drawing.Point(1, 30)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Text = "Datos del Acta"
        '
        'FASE3
        '
        Me.FASE3.AutoScroll = True
        Me.FASE3.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.FASE3.Controls.Add(Me.HORA)
        Me.FASE3.Controls.Add(Me.NUM_ANEXOS)
        Me.FASE3.Controls.Add(Me.Anexar_Orden)
        Me.FASE3.Controls.Add(Me.Label20)
        Me.FASE3.Controls.Add(Me.Label7)
        Me.FASE3.Controls.Add(Me.FOLIO_ACTA_VERIFICACION)
        Me.FASE3.Controls.Add(Me.Label39)
        Me.FASE3.Controls.Add(Me.OBSERVACIONES_GENERALES)
        Me.FASE3.Controls.Add(Me.FECHA_VERIFICACION)
        Me.FASE3.Controls.Add(Me.Label22)
        Me.FASE3.Controls.Add(Me.FECHA_ORDEN)
        Me.FASE3.Controls.Add(Me.Label21)
        Me.FASE3.Controls.Add(Me.Label19)
        Me.FASE3.Controls.Add(Me.FOLIO_ORDEN)
        Me.FASE3.Controls.Add(Me.Label41)
        Me.FASE3.Controls.Add(Me.TIPO_ACTA)
        Me.FASE3.Controls.Add(Me.Label42)
        Me.FASE3.Controls.Add(Me.MOTIVO)
        Me.FASE3.Controls.Add(Me.Label43)
        Me.FASE3.Controls.Add(Me.PROGRAMA)
        Me.FASE3.Controls.Add(Me.Label52)
        Me.FASE3.Controls.Add(Me.RESPONSABLE_ANALISIS)
        Me.FASE3.Controls.Add(Me.TIPO_OBJETIVO)
        Me.FASE3.Controls.Add(Me.Label53)
        Me.FASE3.Controls.Add(Me.add_objetivo_alcance)
        Me.FASE3.Controls.Add(Me.Panel7)
        Me.FASE3.Controls.Add(Me.Panel14)
        Me.FASE3.Controls.Add(Me.Panel16)
        Me.FASE3.Controls.Add(Me.Panel17)
        Me.FASE3.Controls.Add(Me.RadioButton13)
        Me.FASE3.Controls.Add(Me.MEDIDAS_SEGURIDAD)
        Me.FASE3.Controls.Add(Me.FOLIO_REUBICACION)
        Me.FASE3.Controls.Add(Me.FOLIO_SUSPENCION)
        Me.FASE3.Controls.Add(Me.FOLIO_ASEGURAMIENTO)
        Me.FASE3.Controls.Add(Me.Label56)
        Me.FASE3.Controls.Add(Me.Label57)
        Me.FASE3.Controls.Add(Me.Label58)
        Me.FASE3.Controls.Add(Me.Label59)
        Me.FASE3.Controls.Add(Me.Label60)
        Me.FASE3.Controls.Add(Me.Label61)
        Me.FASE3.Controls.Add(Me.Label62)
        Me.FASE3.Controls.Add(Me.Label63)
        Me.FASE3.Controls.Add(Me.Label64)
        Me.FASE3.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.FASE3.Location = New System.Drawing.Point(3, 0)
        Me.FASE3.Name = "FASE3"
        Me.FASE3.ShowCloseButton = False
        Me.FASE3.ShowHeader = True
        Me.FASE3.Size = New System.Drawing.Size(1193, 556)
        Me.FASE3.TabIndex = 127
        Me.FASE3.Text = "Observaciones"
        '
        'HORA
        '
        Me.HORA.CustomFormat = "hh:mm tt"
        Me.HORA.Format = Wisej.Web.DateTimePickerFormat.Time
        Me.HORA.Location = New System.Drawing.Point(784, 137)
        Me.HORA.Name = "HORA"
        Me.HORA.ShowCalendar = False
        Me.HORA.ShowUpDown = True
        Me.HORA.Size = New System.Drawing.Size(305, 22)
        Me.HORA.TabIndex = 162
        Me.HORA.Value = New Date(CType(0, Long))
        '
        'NUM_ANEXOS
        '
        Me.NUM_ANEXOS.Enabled = False
        Me.NUM_ANEXOS.Location = New System.Drawing.Point(48, 448)
        Me.NUM_ANEXOS.Name = "NUM_ANEXOS"
        Me.NUM_ANEXOS.Size = New System.Drawing.Size(301, 22)
        Me.NUM_ANEXOS.TabIndex = 160
        '
        'Anexar_Orden
        '
        Me.Anexar_Orden.Location = New System.Drawing.Point(381, 333)
        Me.Anexar_Orden.Name = "Anexar_Orden"
        Me.Anexar_Orden.Size = New System.Drawing.Size(166, 23)
        Me.Anexar_Orden.TabIndex = 159
        Me.Anexar_Orden.Text = "Asignar Info de Orden"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label20.Location = New System.Drawing.Point(782, 113)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(142, 16)
        Me.Label20.TabIndex = 134
        Me.Label20.Text = "Hora de Verificacion:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label7.Location = New System.Drawing.Point(784, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(191, 16)
        Me.Label7.TabIndex = 133
        Me.Label7.Text = "Folio de Acta de Verificacion"
        '
        'FOLIO_ACTA_VERIFICACION
        '
        Me.FOLIO_ACTA_VERIFICACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.FOLIO_ACTA_VERIFICACION.Location = New System.Drawing.Point(783, 35)
        Me.FOLIO_ACTA_VERIFICACION.Name = "FOLIO_ACTA_VERIFICACION"
        Me.FOLIO_ACTA_VERIFICACION.Size = New System.Drawing.Size(307, 22)
        Me.FOLIO_ACTA_VERIFICACION.TabIndex = 132
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label39.Location = New System.Drawing.Point(782, 167)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(168, 16)
        Me.Label39.TabIndex = 130
        Me.Label39.Text = "Obsevaciones Generales:"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OBSERVACIONES_GENERALES
        '
        Me.OBSERVACIONES_GENERALES.Font = New System.Drawing.Font("default, Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.OBSERVACIONES_GENERALES.Location = New System.Drawing.Point(781, 189)
        Me.OBSERVACIONES_GENERALES.Multiline = True
        Me.OBSERVACIONES_GENERALES.Name = "OBSERVACIONES_GENERALES"
        Me.OBSERVACIONES_GENERALES.Size = New System.Drawing.Size(309, 167)
        Me.OBSERVACIONES_GENERALES.TabIndex = 131
        '
        'FECHA_VERIFICACION
        '
        Me.FECHA_VERIFICACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.FECHA_VERIFICACION.Format = Wisej.Web.DateTimePickerFormat.[Short]
        Me.FECHA_VERIFICACION.Location = New System.Drawing.Point(783, 85)
        Me.FECHA_VERIFICACION.Name = "FECHA_VERIFICACION"
        Me.FECHA_VERIFICACION.Size = New System.Drawing.Size(306, 22)
        Me.FECHA_VERIFICACION.TabIndex = 129
        Me.FECHA_VERIFICACION.Value = New Date(CType(0, Long))
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label22.Location = New System.Drawing.Point(783, 63)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(150, 16)
        Me.Label22.TabIndex = 128
        Me.Label22.Text = "Fecha de Verificacion:"
        '
        'FECHA_ORDEN
        '
        Me.FECHA_ORDEN.CustomFormat = "yyyy/MM/dd"
        Me.FECHA_ORDEN.Enabled = False
        Me.FECHA_ORDEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.FECHA_ORDEN.Format = Wisej.Web.DateTimePickerFormat.Custom
        Me.FECHA_ORDEN.Location = New System.Drawing.Point(380, 445)
        Me.FECHA_ORDEN.Name = "FECHA_ORDEN"
        Me.FECHA_ORDEN.Size = New System.Drawing.Size(355, 22)
        Me.FECHA_ORDEN.TabIndex = 127
        Me.FECHA_ORDEN.Value = New Date(CType(0, Long))
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label21.Location = New System.Drawing.Point(380, 423)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(210, 16)
        Me.Label21.TabIndex = 126
        Me.Label21.Text = "Fecha de Generacion de Orden:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label19.Location = New System.Drawing.Point(381, 372)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(107, 16)
        Me.Label19.TabIndex = 125
        Me.Label19.Text = "Folio de Orden:"
        '
        'FOLIO_ORDEN
        '
        Me.FOLIO_ORDEN.Enabled = False
        Me.FOLIO_ORDEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.FOLIO_ORDEN.Location = New System.Drawing.Point(380, 394)
        Me.FOLIO_ORDEN.Name = "FOLIO_ORDEN"
        Me.FOLIO_ORDEN.Size = New System.Drawing.Size(356, 22)
        Me.FOLIO_ORDEN.TabIndex = 124
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label41.Location = New System.Drawing.Point(381, 268)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(183, 16)
        Me.Label41.TabIndex = 123
        Me.Label41.Text = "Tipo de acta de verificacion"
        '
        'TIPO_ACTA
        '
        Me.TIPO_ACTA.Items.AddRange(New Object() {"ACTA DE VERIFICACIÓN SANITARIA CHATARRERAS, TALLERES MECÁNICOS, ELÉCTRICOS, DE SO" &
                "LDADURA Y OTROS (DEMAR)", "ACTA DE VERIFICACIÓN SANITARIA DE ALBERCAS (DEMAR)", "ACTA DE VERIFICACION SANITARIA DE ESTABLECIMIENTOS QUE GENERAN RPBI´s (DEMAR)", "ACTA DE VERIFICACIÓN SANITARIA PARA VULCANIZADORAS (DEMAR)", "ACTA DE VERIFICACIÓN SANITARIA GENERAL (DEMAR)", "ACTA DE VERIFICACIÓN SANITARIA PARA ESTABLECIMIENTOS DE DIAGNÓSTICO MÉDICO CON RA" &
                "YOS X (DEMAR)", "ACTA DE VERIFICACIÓN SANITARIA DE ESTABLECIMIENTOS QUE ALMACENAN Y COMERCIALIZAN " &
                "PLAGUICIDAS, NUTRIENTES VEGETALES Y SUSTANCIAS TÓXICAS (DEMAR)", "ACTA DE VERIFICACIÓN PARA SISTEMA PÚBLICO O PRIVADO DE ABASTECIMIENTO DE AGUA  (D" &
                "EMAR)", "ACTA DE VERIFICACIÓN SANITARIA PARA FARMACIAS, BOTICAS Y DROGUERÍAS (DOS)", "ACTA DE VERIFICACIÓN SANITARIA PARA ALMACENES DE DEPÓSITO Y DISTRIBUCIÓN DE MEDIC" &
                "AMENTOS Y DEMÁS INSUMOS PARA LA SALUD (DOS)", "ACTA DE VERIFICACIÓN SANITARIA PARA ESTABLECIMIENTOS FABRICANTES DE PRODUCTOS DEL" &
                " TABACO (DOS)", "ACTA DE VERIFICACIÓN SANITARIA PARA ESTABLECIMIENTOS O ZONAS DONDE SE PRACTICA EL" &
                " SEXO SERVICIO (DOS)", "ACTA DE VERIFICACIÓN SANITARIA PARA ESTABLECIMIENTOS QUE VENDEN PRODUCTOS DEL TAB" &
                "ACO (DOS)", "ACTA DE VERIFICACIÓN SANITARIA PARA ESTABLECIMIENTOS SEMIFIJOS Y AMBULANTES QUE P" &
                "REPAREN Y/O EXPENDAN ALIMENTOS Y BEBIDAS (DOS)", "ACTA DE VERIFICACIÓN SANITARIA PARA ESTABLECIMIENTOS QUE APLICAN PLAGUICIDAS (DOS" &
                ")", "ACTA DE VERIFICACIÓN SANITARIA POR LICENCIA SANITARIA PARA APLICADORAS DE PLAGUIC" &
                "IDAS (DOS)", "ACTA DE VERIFICACIÓN SANITARIA DE LA LEY GENERAL PARA EL CONTROL DEL TABACO Y DEL" &
                " REGLAMENTO DE LA LEY GENERAL PARA EL CONTROL DEL TABACO (DOS)", "ACTA DE VERIFICACIÓN SANITARIA DE NO VENTA DE BEBIDAS ALCOHÓLICAS A MENORES DE ED" &
                "AD (DOS)", "ACTA DE VERIFICACIÓN SANITARIA DE PRÁCTICAS DE HIGIENE PARA EMBARCACIONES QUE CAP" &
                "TURAN Y ALMACENAN PRODUCTOS DE LA PESCA (DOS)", "ACTA DE VERIFICACIÓN SANITARIA DE PRÁCTICAS DE HIGIENE PARA EXPENDIOS DE ALIMENTO" &
                "S, BEBIDAS O SUPLEMENTOS ALIMENTICIOS (DOS)", "ACTA DE VERIFICACIÓN SANITARIA DE PRÁCTICAS DE HIGIENE PARA EL PROCESO DE PRODUCT" &
                "OS DE LA PESCA (DOS)", "ACTA DE VERIFICACIÓN SANITARIA DE PRÁCTICAS DE HIGIENE PARA ESTABLECIMIENTOS DE S" &
                "ERVICIO DE ALIMENTOS O BEBIDAS (DOS)", "ACTA DE VERIFICACIÓN SANITARIA DE PRÁCTICAS DE HIGIENE PARA RASTROS Y UNIDADES DE" &
                " SACRIFICIO O MATADEROS (DOS)", "ACTA DE VERIFICACIÓN SANITARIA DE PRÁCTICAS DE HIGIENE PARA TORTILLERÍAS Y PANADE" &
                "RÍAS (DOS)", "ACTA DE VERIFICACIÓN SANITARIA DE PRÁCTICAS DE HIGIENE PARA FÁBRICAS DE ALIMENTOS" &
                ", BEBIDAS O SUPLEMENTOS ALIMENTICIOS (DOS)", "ACTA DE VERIFICACIÓN SANITARIA DE PRÁCTICAS DE HIGIENE PARA EL PROCESO DE AGUA Y " &
                "HIELO (DOS)"})
        Me.TIPO_ACTA.Location = New System.Drawing.Point(381, 287)
        Me.TIPO_ACTA.Name = "TIPO_ACTA"
        Me.TIPO_ACTA.Size = New System.Drawing.Size(355, 22)
        Me.TIPO_ACTA.TabIndex = 122
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label42.Location = New System.Drawing.Point(381, 204)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(169, 16)
        Me.Label42.TabIndex = 121
        Me.Label42.Text = "Motivo de la Verificacion:"
        '
        'MOTIVO
        '
        Me.MOTIVO.Items.AddRange(New Object() {"Muestreo de Producto", "Verifcacion Sanitaria", "No especificado"})
        Me.MOTIVO.Location = New System.Drawing.Point(381, 223)
        Me.MOTIVO.Name = "MOTIVO"
        Me.MOTIVO.Size = New System.Drawing.Size(355, 22)
        Me.MOTIVO.TabIndex = 120
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label43.Location = New System.Drawing.Point(381, 137)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(75, 16)
        Me.Label43.TabIndex = 119
        Me.Label43.Text = "Programa:"
        '
        'PROGRAMA
        '
        Me.PROGRAMA.Items.AddRange(New Object() {"Federal (Subsidio)", "Estatal ", "Municipal", "No especificado", "Sin Resultados de laboratorio"})
        Me.PROGRAMA.Location = New System.Drawing.Point(381, 158)
        Me.PROGRAMA.Name = "PROGRAMA"
        Me.PROGRAMA.Size = New System.Drawing.Size(355, 22)
        Me.PROGRAMA.TabIndex = 118
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label52.Location = New System.Drawing.Point(381, 63)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(355, 16)
        Me.Label52.TabIndex = 103
        Me.Label52.Text = "Gastos y Analisis de la Muestreo Se Responsabilisa a:"
        '
        'RESPONSABLE_ANALISIS
        '
        Me.RESPONSABLE_ANALISIS.Items.AddRange(New Object() {"Autoridad Sanitaria", "Interesado (Propietario)"})
        Me.RESPONSABLE_ANALISIS.Location = New System.Drawing.Point(381, 93)
        Me.RESPONSABLE_ANALISIS.Name = "RESPONSABLE_ANALISIS"
        Me.RESPONSABLE_ANALISIS.Size = New System.Drawing.Size(355, 22)
        Me.RESPONSABLE_ANALISIS.TabIndex = 102
        '
        'TIPO_OBJETIVO
        '
        Me.TIPO_OBJETIVO.amarillo = False
        Me.TIPO_OBJETIVO.Ancho = Nothing
        Me.TIPO_OBJETIVO.BackColor = System.Drawing.Color.FromName("@window")
        Me.TIPO_OBJETIVO.ColorAtras = System.Drawing.Color.Empty
        Me.TIPO_OBJETIVO.Count = 0
        Me.TIPO_OBJETIVO.DataSource = Nothing
        Me.TIPO_OBJETIVO.DataSourceSelect = Nothing
        Me.TIPO_OBJETIVO.gris = False
        Me.TIPO_OBJETIVO.Letra = Nothing
        Me.TIPO_OBJETIVO.Limitar = False
        Me.TIPO_OBJETIVO.Location = New System.Drawing.Point(382, 35)
        Me.TIPO_OBJETIVO.MensajeAgua = Nothing
        Me.TIPO_OBJETIVO.mostrarMensaje = False
        Me.TIPO_OBJETIVO.Name = "TIPO_OBJETIVO"
        Me.TIPO_OBJETIVO.Negritas = False
        Me.TIPO_OBJETIVO.OBTENERLISTLLENADO = Nothing
        Me.TIPO_OBJETIVO.procedure = Nothing
        Me.TIPO_OBJETIVO.SelectedIndex = -1
        Me.TIPO_OBJETIVO.SelectedItem = ""
        Me.TIPO_OBJETIVO.SelectedValue = Nothing
        Me.TIPO_OBJETIVO.Size = New System.Drawing.Size(308, 22)
        Me.TIPO_OBJETIVO.TabIndex = 101
        Me.TIPO_OBJETIVO.TODOSS = False
        Me.TIPO_OBJETIVO.Watermark = Nothing
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label53.ForeColor = System.Drawing.Color.FromName("@windowText")
        Me.Label53.Location = New System.Drawing.Point(381, 13)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(319, 16)
        Me.Label53.TabIndex = 100
        Me.Label53.Text = "Objetivo y Alcance de la orden de visita sanitaria"
        '
        'add_objetivo_alcance
        '
        Me.add_objetivo_alcance.AutoSize = True
        Me.add_objetivo_alcance.ImageSource = "Resources\Icons\Menu\add.png"
        Me.add_objetivo_alcance.Location = New System.Drawing.Point(696, 32)
        Me.add_objetivo_alcance.Name = "add_objetivo_alcance"
        Me.add_objetivo_alcance.Size = New System.Drawing.Size(40, 27)
        Me.add_objetivo_alcance.TabIndex = 99
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.RadioButton5)
        Me.Panel7.Controls.Add(Me.ANEXO)
        Me.Panel7.Location = New System.Drawing.Point(26, 394)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(118, 29)
        Me.Panel7.TabIndex = 49
        '
        'RadioButton5
        '
        Me.RadioButton5.Checked = True
        Me.RadioButton5.Location = New System.Drawing.Point(53, 3)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(44, 23)
        Me.RadioButton5.TabIndex = 20
        Me.RadioButton5.Text = "No"
        '
        'ANEXO
        '
        Me.ANEXO.AutoSize = False
        Me.ANEXO.Location = New System.Drawing.Point(3, 3)
        Me.ANEXO.Name = "ANEXO"
        Me.ANEXO.Size = New System.Drawing.Size(49, 23)
        Me.ANEXO.TabIndex = 19
        Me.ANEXO.TabStop = False
        Me.ANEXO.Text = "Si"
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.RadioButton7)
        Me.Panel14.Controls.Add(Me.F_reubicacion_si)
        Me.Panel14.Location = New System.Drawing.Point(26, 287)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(118, 29)
        Me.Panel14.TabIndex = 48
        '
        'RadioButton7
        '
        Me.RadioButton7.Checked = True
        Me.RadioButton7.Location = New System.Drawing.Point(53, 3)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(44, 23)
        Me.RadioButton7.TabIndex = 20
        Me.RadioButton7.Text = "No"
        '
        'F_reubicacion_si
        '
        Me.F_reubicacion_si.AutoSize = False
        Me.F_reubicacion_si.Location = New System.Drawing.Point(3, 3)
        Me.F_reubicacion_si.Name = "F_reubicacion_si"
        Me.F_reubicacion_si.Size = New System.Drawing.Size(49, 23)
        Me.F_reubicacion_si.TabIndex = 19
        Me.F_reubicacion_si.TabStop = False
        Me.F_reubicacion_si.Text = "Si"
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.RadioButton9)
        Me.Panel16.Controls.Add(Me.F_suspencion_si)
        Me.Panel16.Location = New System.Drawing.Point(26, 182)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(118, 29)
        Me.Panel16.TabIndex = 47
        '
        'RadioButton9
        '
        Me.RadioButton9.Checked = True
        Me.RadioButton9.Location = New System.Drawing.Point(53, 3)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(44, 23)
        Me.RadioButton9.TabIndex = 20
        Me.RadioButton9.Text = "No"
        '
        'F_suspencion_si
        '
        Me.F_suspencion_si.AutoSize = False
        Me.F_suspencion_si.Location = New System.Drawing.Point(3, 3)
        Me.F_suspencion_si.Name = "F_suspencion_si"
        Me.F_suspencion_si.Size = New System.Drawing.Size(44, 23)
        Me.F_suspencion_si.TabIndex = 19
        Me.F_suspencion_si.TabStop = False
        Me.F_suspencion_si.Text = "Si"
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.RadioButton11)
        Me.Panel17.Controls.Add(Me.F_aseguramiento_si)
        Me.Panel17.Location = New System.Drawing.Point(26, 86)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(118, 29)
        Me.Panel17.TabIndex = 46
        '
        'RadioButton11
        '
        Me.RadioButton11.Checked = True
        Me.RadioButton11.Location = New System.Drawing.Point(53, 3)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(44, 23)
        Me.RadioButton11.TabIndex = 20
        Me.RadioButton11.Text = "No"
        '
        'F_aseguramiento_si
        '
        Me.F_aseguramiento_si.AutoSize = False
        Me.F_aseguramiento_si.Location = New System.Drawing.Point(3, 3)
        Me.F_aseguramiento_si.Name = "F_aseguramiento_si"
        Me.F_aseguramiento_si.Size = New System.Drawing.Size(44, 23)
        Me.F_aseguramiento_si.TabIndex = 19
        Me.F_aseguramiento_si.TabStop = False
        Me.F_aseguramiento_si.Text = "Si"
        '
        'RadioButton13
        '
        Me.RadioButton13.Checked = True
        Me.RadioButton13.Location = New System.Drawing.Point(79, 34)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(44, 23)
        Me.RadioButton13.TabIndex = 45
        Me.RadioButton13.Text = "No"
        '
        'MEDIDAS_SEGURIDAD
        '
        Me.MEDIDAS_SEGURIDAD.AutoSize = False
        Me.MEDIDAS_SEGURIDAD.Location = New System.Drawing.Point(23, 34)
        Me.MEDIDAS_SEGURIDAD.Name = "MEDIDAS_SEGURIDAD"
        Me.MEDIDAS_SEGURIDAD.Size = New System.Drawing.Size(50, 23)
        Me.MEDIDAS_SEGURIDAD.TabIndex = 44
        Me.MEDIDAS_SEGURIDAD.TabStop = False
        Me.MEDIDAS_SEGURIDAD.Text = "Si"
        '
        'FOLIO_REUBICACION
        '
        Me.FOLIO_REUBICACION.Enabled = False
        Me.FOLIO_REUBICACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.FOLIO_REUBICACION.Location = New System.Drawing.Point(48, 344)
        Me.FOLIO_REUBICACION.Name = "FOLIO_REUBICACION"
        Me.FOLIO_REUBICACION.Size = New System.Drawing.Size(301, 22)
        Me.FOLIO_REUBICACION.TabIndex = 41
        '
        'FOLIO_SUSPENCION
        '
        Me.FOLIO_SUSPENCION.Enabled = False
        Me.FOLIO_SUSPENCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.FOLIO_SUSPENCION.Location = New System.Drawing.Point(48, 240)
        Me.FOLIO_SUSPENCION.Name = "FOLIO_SUSPENCION"
        Me.FOLIO_SUSPENCION.Size = New System.Drawing.Size(301, 22)
        Me.FOLIO_SUSPENCION.TabIndex = 40
        '
        'FOLIO_ASEGURAMIENTO
        '
        Me.FOLIO_ASEGURAMIENTO.Enabled = False
        Me.FOLIO_ASEGURAMIENTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.FOLIO_ASEGURAMIENTO.Location = New System.Drawing.Point(48, 140)
        Me.FOLIO_ASEGURAMIENTO.Name = "FOLIO_ASEGURAMIENTO"
        Me.FOLIO_ASEGURAMIENTO.Size = New System.Drawing.Size(301, 22)
        Me.FOLIO_ASEGURAMIENTO.TabIndex = 39
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label56.Location = New System.Drawing.Point(26, 426)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(154, 16)
        Me.Label56.TabIndex = 37
        Me.Label56.Text = "5.1 Número de anexos:"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label57.Location = New System.Drawing.Point(13, 372)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(188, 16)
        Me.Label57.TabIndex = 36
        Me.Label57.Text = "5. Se anexa documentación:"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label58.Location = New System.Drawing.Point(26, 322)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(291, 16)
        Me.Label58.TabIndex = 35
        Me.Label58.Text = "4.1 Número de folio de sello(s) reubicado(s):"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label59.Location = New System.Drawing.Point(13, 268)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(168, 16)
        Me.Label59.TabIndex = 34
        Me.Label59.Text = "4. Reubicación de sellos:"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label60.Location = New System.Drawing.Point(26, 218)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(318, 16)
        Me.Label60.TabIndex = 33
        Me.Label60.Text = "3.1 Número de folio de los sellos de suspención:"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label61.Location = New System.Drawing.Point(13, 168)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(252, 16)
        Me.Label61.TabIndex = 32
        Me.Label61.Text = "3. Suspención de trabajos o servicios:"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label62.Location = New System.Drawing.Point(26, 121)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(339, 16)
        Me.Label62.TabIndex = 31
        Me.Label62.Text = "2.1 Número de folio de los sellos de aseguramiento:"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label63.Location = New System.Drawing.Point(13, 63)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(276, 16)
        Me.Label63.TabIndex = 30
        Me.Label63.Text = "2. Aseguramiento de productos u objetos:"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label64.Location = New System.Drawing.Point(13, 13)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(224, 16)
        Me.Label64.TabIndex = 29
        Me.Label64.Text = "1. Se aplica medida de Seguridad:"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sig_pag3
        '
        Me.sig_pag3.Location = New System.Drawing.Point(1072, 565)
        Me.sig_pag3.Name = "sig_pag3"
        Me.sig_pag3.Size = New System.Drawing.Size(100, 27)
        Me.sig_pag3.TabIndex = 1
        Me.sig_pag3.Text = "Siguiente"
        '
        'ant_pag3
        '
        Me.ant_pag3.Location = New System.Drawing.Point(3, 565)
        Me.ant_pag3.Name = "ant_pag3"
        Me.ant_pag3.Size = New System.Drawing.Size(100, 27)
        Me.ant_pag3.TabIndex = 0
        Me.ant_pag3.Text = "Anterior"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.FASE4)
        Me.TabPage4.Controls.Add(Me.finalizar)
        Me.TabPage4.Controls.Add(Me.ant_pag4)
        Me.TabPage4.ImageSource = "Resources\Icons\Menu\adjuntar-attach.png"
        Me.TabPage4.Location = New System.Drawing.Point(1, 30)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Text = "Datos Extra"
        '
        'FASE4
        '
        Me.FASE4.AutoScroll = True
        Me.FASE4.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.FASE4.Location = New System.Drawing.Point(2, 3)
        Me.FASE4.Name = "FASE4"
        Me.FASE4.RightToLeft = Wisej.Web.RightToLeft.No
        Me.FASE4.RightToLeftLayout = True
        Me.FASE4.ScrollBars = Wisej.Web.ScrollBars.Vertical
        Me.FASE4.ShowCloseButton = False
        Me.FASE4.ShowHeader = True
        Me.FASE4.Size = New System.Drawing.Size(1191, 556)
        Me.FASE4.TabIndex = 52
        Me.FASE4.Text = "Datos extra"
        '
        'finalizar
        '
        Me.finalizar.AutoSize = True
        Me.finalizar.Location = New System.Drawing.Point(1072, 565)
        Me.finalizar.Name = "finalizar"
        Me.finalizar.Size = New System.Drawing.Size(100, 27)
        Me.finalizar.TabIndex = 3
        Me.finalizar.Text = "Siguiente"
        '
        'ant_pag4
        '
        Me.ant_pag4.Location = New System.Drawing.Point(3, 565)
        Me.ant_pag4.Name = "ant_pag4"
        Me.ant_pag4.Size = New System.Drawing.Size(100, 27)
        Me.ant_pag4.TabIndex = 2
        Me.ant_pag4.Text = "Anterior"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Button1)
        Me.TabPage5.Controls.Add(Me.FASE5)
        Me.TabPage5.Controls.Add(Me.Button2)
        Me.TabPage5.ImageSource = "Resources\Icons\Menu\PDF.png"
        Me.TabPage5.Location = New System.Drawing.Point(1, 30)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Text = "Acta Escaneada"
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.ImageSource = "Resources\Icons\Menu\018-checked.png"
        Me.Button1.Location = New System.Drawing.Point(1012, 565)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 27)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Finalizar & Guardar"
        '
        'FASE5
        '
        Me.FASE5.AutoScroll = True
        Me.FASE5.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.FASE5.Location = New System.Drawing.Point(0, 3)
        Me.FASE5.Name = "FASE5"
        Me.FASE5.RightToLeft = Wisej.Web.RightToLeft.No
        Me.FASE5.RightToLeftLayout = True
        Me.FASE5.ScrollBars = Wisej.Web.ScrollBars.Vertical
        Me.FASE5.ShowCloseButton = False
        Me.FASE5.ShowHeader = True
        Me.FASE5.Size = New System.Drawing.Size(1191, 556)
        Me.FASE5.TabIndex = 53
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(3, 565)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 27)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Anterior"
        '
        'CVE_ACTA_TEXT
        '
        Me.CVE_ACTA_TEXT.Location = New System.Drawing.Point(534, 47)
        Me.CVE_ACTA_TEXT.Name = "CVE_ACTA_TEXT"
        Me.CVE_ACTA_TEXT.Size = New System.Drawing.Size(21, 22)
        Me.CVE_ACTA_TEXT.TabIndex = 124
        Me.CVE_ACTA_TEXT.Text = "0"
        Me.CVE_ACTA_TEXT.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Generar_Orden_Verficacion
        '
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.None
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1198, 748)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Controls.Add(Me.CVE_ACTA_TEXT)
        Me.MaximizeBox = False
        Me.Name = "Generar_Orden_Verficacion"
        Me.Text = "      "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FASE1.ResumeLayout(False)
        Me.FASE1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.FASE2.ResumeLayout(False)
        Me.FASE2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.MUESTRAS_GRID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VERIFICADORES_GRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.FASE3.ResumeLayout(False)
        Me.FASE3.PerformLayout()
        CType(Me.NUM_ANEXOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonBar1 As Wisej.Web.Ext.RibbonBar.RibbonBar
    Friend WithEvents RibbonBarPage1 As Wisej.Web.Ext.RibbonBar.RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As Wisej.Web.Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents NUEVO As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents SALIR As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents JURISDICCION_EST As Wisej.Web.TextBox
    Friend WithEvents DOMICILIO_EST As Wisej.Web.TextBox
    Friend WithEvents AddEstablecimiento As Wisej.Web.Button
    Friend WithEvents GIRO_EST As Wisej.Web.TextBox
    Friend WithEvents RAZON_SOCIAL_EST As Wisej.Web.TextBox
    Friend WithEvents Label13 As Wisej.Web.Label
    Friend WithEvents TabControl1 As Wisej.Web.TabControl
    Friend WithEvents TabPage1 As Wisej.Web.TabPage
    Friend WithEvents TabPage2 As Wisej.Web.TabPage
    Friend WithEvents sig_pag1 As Wisej.Web.Button
    Friend WithEvents sig_pag2 As Wisej.Web.Button
    Friend WithEvents ant_pag2 As Wisej.Web.Button
    Friend WithEvents TabPage3 As Wisej.Web.TabPage
    Friend WithEvents FASE2 As Wisej.Web.Panel
    Friend WithEvents sig_pag3 As Wisej.Web.Button
    Friend WithEvents ant_pag3 As Wisej.Web.Button
    Friend WithEvents TabPage4 As Wisej.Web.TabPage
    Friend WithEvents finalizar As Wisej.Web.Button
    Friend WithEvents ant_pag4 As Wisej.Web.Button
    Friend WithEvents CP_EST As Wisej.Web.TextBox
    Friend WithEvents Editar_Domicilio As Wisej.Web.CheckBox
    Friend WithEvents Panel1 As Wisej.Web.Panel
    Friend WithEvents FASE1 As Wisej.Web.Panel
    Friend WithEvents COLONIA_ESTABLECIMIENTOS As Combosax_B
    Friend WithEvents ESTABLECIMIENTO As Combosax_B
    Friend WithEvents Label24 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents VERIFICADORES As Combosax_B
    Friend WithEvents AddVerificador As Wisej.Web.Button
    Friend WithEvents VERIFICADORES_GRID As Wisej.Web.DataGridView
    Friend WithEvents Label27 As Wisej.Web.Label
    Friend WithEvents ErrorProvider1 As Wisej.Web.ErrorProvider
    Friend WithEvents Eliminar As Wisej.Web.DataGridViewImageColumn
    Friend WithEvents Nombre As Wisej.Web.DataGridViewColumn
    Friend WithEvents Jurisdiccion As Wisej.Web.DataGridViewColumn
    Friend WithEvents CVE_VERIFICADOR As Wisej.Web.DataGridViewColumn
    Friend WithEvents Sexo As Wisej.Web.DataGridViewColumn
    Friend WithEvents Clave_Trabajador As Wisej.Web.DataGridViewColumn
    Friend WithEvents MUESTRAS_GRID As Wisej.Web.DataGridView
    Friend WithEvents CVE_TIPO_MUESTRA As Wisej.Web.DataGridViewColumn
    Friend WithEvents CVE_TIPO_ANALISIS As Wisej.Web.DataGridViewColumn
    Friend WithEvents DESCRIPCION As Wisej.Web.DataGridViewColumn
    Friend WithEvents CLAVE_VS As Wisej.Web.DataGridViewColumn
    Friend WithEvents MARCA As Wisej.Web.DataGridViewColumn
    Friend WithEvents LOTE As Wisej.Web.DataGridViewColumn
    Friend WithEvents FECHA As Wisej.Web.DataGridViewColumn
    Friend WithEvents CANTIDAD As Wisej.Web.DataGridViewColumn
    Friend WithEvents cenum As Wisej.Web.DataGridViewImageColumn
    Friend WithEvents FASE3 As Wisej.Web.Panel
    Friend WithEvents CVE_ACTA_TEXT As Wisej.Web.TextBox
    Friend WithEvents Label41 As Wisej.Web.Label
    Friend WithEvents TIPO_ACTA As Wisej.Web.ComboBox
    Friend WithEvents Label42 As Wisej.Web.Label
    Friend WithEvents MOTIVO As Wisej.Web.ComboBox
    Friend WithEvents Label43 As Wisej.Web.Label
    Friend WithEvents PROGRAMA As Wisej.Web.ComboBox
    Friend WithEvents Label52 As Wisej.Web.Label
    Friend WithEvents RESPONSABLE_ANALISIS As Wisej.Web.ComboBox
    Friend WithEvents TIPO_OBJETIVO As Combosax_B
    Friend WithEvents Label53 As Wisej.Web.Label
    Friend WithEvents add_objetivo_alcance As Wisej.Web.Button
    Friend WithEvents Panel7 As Wisej.Web.Panel
    Friend WithEvents RadioButton5 As Wisej.Web.RadioButton
    Friend WithEvents ANEXO As Wisej.Web.RadioButton
    Friend WithEvents Panel14 As Wisej.Web.Panel
    Friend WithEvents RadioButton7 As Wisej.Web.RadioButton
    Friend WithEvents F_reubicacion_si As Wisej.Web.RadioButton
    Friend WithEvents Panel16 As Wisej.Web.Panel
    Friend WithEvents RadioButton9 As Wisej.Web.RadioButton
    Friend WithEvents F_suspencion_si As Wisej.Web.RadioButton
    Friend WithEvents Panel17 As Wisej.Web.Panel
    Friend WithEvents RadioButton11 As Wisej.Web.RadioButton
    Friend WithEvents F_aseguramiento_si As Wisej.Web.RadioButton
    Friend WithEvents RadioButton13 As Wisej.Web.RadioButton
    Friend WithEvents MEDIDAS_SEGURIDAD As Wisej.Web.RadioButton
    Friend WithEvents FOLIO_REUBICACION As Wisej.Web.TextBox
    Friend WithEvents FOLIO_SUSPENCION As Wisej.Web.TextBox
    Friend WithEvents FOLIO_ASEGURAMIENTO As Wisej.Web.TextBox
    Friend WithEvents Label58 As Wisej.Web.Label
    Friend WithEvents Label59 As Wisej.Web.Label
    Friend WithEvents Label60 As Wisej.Web.Label
    Friend WithEvents Label61 As Wisej.Web.Label
    Friend WithEvents Label62 As Wisej.Web.Label
    Friend WithEvents Label63 As Wisej.Web.Label
    Friend WithEvents Label64 As Wisej.Web.Label
    Friend WithEvents FASE4 As Wisej.Web.Panel
    Friend WithEvents Label47 As Wisej.Web.Label
    Friend WithEvents OBSERVACIONES_MUESTRAS As Wisej.Web.TextBox
    Friend WithEvents RFC_EST As Wisej.Web.TextBox
    Friend WithEvents ID_PROPIETARIO As Wisej.Web.ComboBox
    Friend WithEvents Label48 As Wisej.Web.Label
    Friend WithEvents Editar_Propietario As Wisej.Web.CheckBox
    Friend WithEvents Label9 As Wisej.Web.Label
    Friend WithEvents DOMICILIO_PROPIETARIO As Wisej.Web.TextBox
    Friend WithEvents NOMBRE_PROPIETARIO As Wisej.Web.TextBox
    Friend WithEvents Label11 As Wisej.Web.Label
    Friend WithEvents Label12 As Wisej.Web.Label
    Friend WithEvents Label8 As Wisej.Web.Label
    Friend WithEvents Label6 As Wisej.Web.Label
    Friend WithEvents Label5 As Wisej.Web.Label
    Friend WithEvents Label4 As Wisej.Web.Label
    Friend WithEvents Label3 As Wisej.Web.Label
    Friend WithEvents Label2 As Wisej.Web.Label
    Friend WithEvents Label1 As Wisej.Web.Label
    Friend WithEvents Label25 As Wisej.Web.Label
    Friend WithEvents Label26 As Wisej.Web.Label
    Friend WithEvents Label28 As Wisej.Web.Label
    Friend WithEvents ID_TESTIGO2 As Wisej.Web.ComboBox
    Friend WithEvents DOM_TESTIGO2 As Wisej.Web.TextBox
    Friend WithEvents NOMBRE_TESTIGO2 As Wisej.Web.TextBox
    Friend WithEvents Label23 As Wisej.Web.Label
    Friend WithEvents Label18 As Wisej.Web.Label
    Friend WithEvents Label17 As Wisej.Web.Label
    Friend WithEvents Label16 As Wisej.Web.Label
    Friend WithEvents Label15 As Wisej.Web.Label
    Friend WithEvents Label14 As Wisej.Web.Label
    Friend WithEvents TESTIGO2 As Wisej.Web.CheckBox
    Friend WithEvents TESTIGO1 As Wisej.Web.CheckBox
    Friend WithEvents Label46 As Wisej.Web.Label
    Friend WithEvents ID_TESTIGO1 As Wisej.Web.ComboBox
    Friend WithEvents DOM_TESTIGO1 As Wisej.Web.TextBox
    Friend WithEvents NOMBRE_TESTIGO1 As Wisej.Web.TextBox
    Friend WithEvents GroupBox2 As Wisej.Web.GroupBox
    Friend WithEvents no As Wisej.Web.RadioButton
    Friend WithEvents PROPIETARIO_RESPONSABLE As Wisej.Web.RadioButton
    Friend WithEvents CARGO_RESPONSABLE As Wisej.Web.TextBox
    Friend WithEvents Label45 As Wisej.Web.Label
    Friend WithEvents ID_RESPONSABLE As Wisej.Web.ComboBox
    Friend WithEvents DOMICILIO_RESPONSABLE As Wisej.Web.TextBox
    Friend WithEvents NOMBRE_RESPONSABLE As Wisej.Web.TextBox
    Friend WithEvents Line1 As Wisej.Web.Line
    Friend WithEvents GroupBox1 As Wisej.Web.GroupBox
    Friend WithEvents ADD_MUESTRAS_TABLA As Wisej.Web.RadioButton
    Friend WithEvents NO_MUESTRAS As Wisej.Web.RadioButton
    Friend WithEvents Label56 As Wisej.Web.Label
    Friend WithEvents Label57 As Wisej.Web.Label
    Friend WithEvents Anexar_Orden As Wisej.Web.CheckBox
    Friend WithEvents Label20 As Wisej.Web.Label
    Friend WithEvents Label7 As Wisej.Web.Label
    Friend WithEvents FOLIO_ACTA_VERIFICACION As Wisej.Web.TextBox
    Friend WithEvents Label39 As Wisej.Web.Label
    Friend WithEvents OBSERVACIONES_GENERALES As Wisej.Web.TextBox
    Friend WithEvents FECHA_VERIFICACION As Wisej.Web.DateTimePicker
    Friend WithEvents Label22 As Wisej.Web.Label
    Friend WithEvents FECHA_ORDEN As Wisej.Web.DateTimePicker
    Friend WithEvents Label21 As Wisej.Web.Label
    Friend WithEvents Label19 As Wisej.Web.Label
    Friend WithEvents FOLIO_ORDEN As Wisej.Web.TextBox
    Friend WithEvents NUM_ANEXOS As Wisej.Web.NumericUpDown
    Friend WithEvents Add_Muestras As Wisej.Web.Button
    Friend WithEvents HORA As Wisej.Web.DateTimePicker
    Friend WithEvents TabPage5 As Wisej.Web.TabPage
    Friend WithEvents Button1 As Wisej.Web.Button
    Friend WithEvents FASE5 As Wisej.Web.Panel
    Friend WithEvents Button2 As Wisej.Web.Button
End Class
