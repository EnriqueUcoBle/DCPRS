Imports Wisej.Web.Ext.RibbonBar
Imports Wisej.Web

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cat_operadores
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
        Dim ComponentTool1 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Dim ComponentTool2 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cat_operadores))
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.Menu = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.Opciones = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBNNUEVO = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNACTUALIZAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNGUARDAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBNSALIR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.GroupBox1 = New Wisej.Web.GroupBox()
        Me.cbxestudio = New Wisej.Web.ComboBox()
        Me.cbxsexo = New Wisej.Web.ComboBox()
        Me.DTPFechaNacimiento = New Wisej.Web.DateTimePicker()
        Me.txtClaveDelTrabajador = New Wisej.Web.TextBox()
        Me.txtEmail = New Wisej.Web.TextBox()
        Me.txtTelefono = New Wisej.Web.TextBox()
        Me.txtUsuario = New Wisej.Web.TextBox()
        Me.txtApellidos = New Wisej.Web.TextBox()
        Me.CBSMunicipio = New Wisej.Web.ComboBox()
        Me.txtNombre = New Wisej.Web.TextBox()
        Me.BtnEliminar = New Wisej.Web.Button()
        Me.BtnAnexar = New Wisej.Web.Upload()
        Me.PictureBox1 = New Wisej.Web.PictureBox()
        Me.CBxMostrar = New Wisej.Web.CheckBox()
        Me.chkHabilitado = New Wisej.Web.CheckBox()
        Me.txtContrasena = New Wisej.Web.TextBox()
        Me.CBSrol = New Wisej.Web.ComboBox()
        Me.Panel1 = New Wisej.Web.Panel()
        Me.RBDesactivado = New Wisej.Web.RadioButton()
        Me.RBHabilitado = New Wisej.Web.RadioButton()
        Me.ErrorProvider1 = New Wisej.Web.ErrorProvider(Me.components)
        Me.DataGridViewTextBoxColumn1 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.buttonAddNew = New Wisej.Web.Button()
        Me.labelCount = New Wisej.Web.Label()
        Me.buttonDelete = New Wisej.Web.Button()
        Me.buttonMoveFirst = New Wisej.Web.Button()
        Me.buttonMoveLast = New Wisej.Web.Button()
        Me.buttonMoveNext = New Wisej.Web.Button()
        Me.buttonMovePrevious = New Wisej.Web.Button()
        Me.textBoxPosition = New Wisej.Web.TextBox()
        Me.separatorControl = New Wisej.Web.Line()
        Me.separatorRight = New Wisej.Web.Line()
        Me.separatorLeft = New Wisej.Web.Line()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn3 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1 = New Wisej.Web.TableLayoutPanel()
        Me.DGVOperadores = New Wisej.Web.DataGridView()
        Me.ELIMINAR = New Wisej.Web.DataGridViewImageColumn()
        Me.USUARIO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.contrasena = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.rol = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colXNOMBRE = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.NOMBRE = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.APELLIDOS = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.TELEFONO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.CORREO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.SEXO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.FECHA_NACIMIENTO = New Wisej.Web.DataGridViewDateTimePickerColumn()
        Me.GRADO_ESTUDIO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.CLAVE_TRABAJADOR = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.CVE_PERSONA = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.JURISDICCION = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Habilitado = New Wisej.Web.DataGridViewCheckBoxColumn()
        Me.CVE_OPERADOR = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataSetpCATOPERADORESBBindingSource = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pCAT_OPERADORES_B = New DPCRS.DataSet_pCAT_OPERADORES_B()
        Me.BDN = New Wisej.Web.BindingNavigator(Me.components)
        Me.buttonAddNew1 = New Wisej.Web.Button()
        Me.buttonMoveFirst1 = New Wisej.Web.Button()
        Me.buttonMovePrevious1 = New Wisej.Web.Button()
        Me.separatorLeft1 = New Wisej.Web.Line()
        Me.textBoxPosition1 = New Wisej.Web.TextBox()
        Me.labelCount1 = New Wisej.Web.Label()
        Me.separatorRight1 = New Wisej.Web.Line()
        Me.buttonMoveNext1 = New Wisej.Web.Button()
        Me.buttonMoveLast1 = New Wisej.Web.Button()
        Me.separatorControl1 = New Wisej.Web.Line()
        Me.buttonDelete1 = New Wisej.Web.Button()
        Me.DataGridViewTextBoxColumn4 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New Wisej.Web.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.FiltroGrillaSax1 = New DPCRS.filtroGrillaSax()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DGVOperadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetpCATOPERADORESBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCAT_OPERADORES_B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BDN.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Dock = Wisej.Web.DockStyle.Top
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.Menu)
        Me.RibbonBar1.Size = New System.Drawing.Size(1036, 131)
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
        '
        'RBNSALIR
        '
        Me.RBNSALIR.ImageSource = "Resources\Images\Menu\30\exit-sign-red.png?color=#0000FF"
        Me.RBNSALIR.Name = "RBNSALIR"
        Me.RBNSALIR.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxestudio)
        Me.GroupBox1.Controls.Add(Me.cbxsexo)
        Me.GroupBox1.Controls.Add(Me.DTPFechaNacimiento)
        Me.GroupBox1.Controls.Add(Me.txtClaveDelTrabajador)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.txtApellidos)
        Me.GroupBox1.Controls.Add(Me.CBSMunicipio)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.BtnAnexar)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.CBxMostrar)
        Me.GroupBox1.Controls.Add(Me.chkHabilitado)
        Me.GroupBox1.Controls.Add(Me.txtContrasena)
        Me.GroupBox1.Controls.Add(Me.CBSrol)
        Me.GroupBox1.Dock = Wisej.Web.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1036, 200)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.Text = "Datos Operador"
        '
        'cbxestudio
        '
        Me.cbxestudio.AutoSize = False
        Me.cbxestudio.Items.AddRange(New Object() {"Nivel inicial (PREESCOLAR)", "Nivel Basico (PRIMARIA & SECUNDARIA)", "Nivel Medio Superior(CARRERA TECNICA y/o BACHILLERATO)", "Nivel Superior (LICENCIATURA, DOCTORADO, MAESTRIA, ETC)"})
        Me.cbxestudio.Location = New System.Drawing.Point(451, 151)
        Me.cbxestudio.Name = "cbxestudio"
        Me.cbxestudio.Size = New System.Drawing.Size(257, 22)
        Me.cbxestudio.TabIndex = 43
        Me.cbxestudio.Watermark = "Seleccione el grado de estudios"
        '
        'cbxsexo
        '
        Me.cbxsexo.AutoSize = False
        Me.cbxsexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.cbxsexo.Location = New System.Drawing.Point(150, 151)
        Me.cbxsexo.Name = "cbxsexo"
        Me.cbxsexo.Size = New System.Drawing.Size(257, 22)
        Me.cbxsexo.TabIndex = 42
        Me.cbxsexo.Watermark = "Selecciones el sexo"
        '
        'DTPFechaNacimiento
        '
        Me.DTPFechaNacimiento.CustomFormat = "dd/MM/yyyy"
        Me.DTPFechaNacimiento.Format = Wisej.Web.DateTimePickerFormat.Custom
        Me.DTPFechaNacimiento.Location = New System.Drawing.Point(763, 151)
        Me.DTPFechaNacimiento.Name = "DTPFechaNacimiento"
        Me.DTPFechaNacimiento.Size = New System.Drawing.Size(257, 22)
        Me.DTPFechaNacimiento.TabIndex = 41
        Me.DTPFechaNacimiento.Value = New Date(CType(0, Long))
        Me.DTPFechaNacimiento.Watermark = "Fecha de Nacimiento"
        '
        'txtClaveDelTrabajador
        '
        Me.txtClaveDelTrabajador.Location = New System.Drawing.Point(763, 107)
        Me.txtClaveDelTrabajador.Name = "txtClaveDelTrabajador"
        Me.txtClaveDelTrabajador.Size = New System.Drawing.Size(257, 22)
        Me.txtClaveDelTrabajador.TabIndex = 34
        Me.txtClaveDelTrabajador.Watermark = "Clave de trabajdor"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(763, 64)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(257, 22)
        Me.txtEmail.TabIndex = 33
        Me.txtEmail.Watermark = "Correo"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(763, 21)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(257, 22)
        Me.txtTelefono.TabIndex = 32
        Me.txtTelefono.Watermark = "Telefono Celular"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(150, 21)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(257, 22)
        Me.txtUsuario.TabIndex = 29
        Me.txtUsuario.Watermark = "Usuario o Nickname para iniciar sesion"
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(451, 62)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(257, 22)
        Me.txtApellidos.TabIndex = 14
        Me.txtApellidos.Watermark = "Apellido(s)"
        '
        'CBSMunicipio
        '
        Me.CBSMunicipio.BackColor = System.Drawing.Color.Transparent
        Me.CBSMunicipio.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSMunicipio.Location = New System.Drawing.Point(150, 107)
        Me.CBSMunicipio.Name = "CBSMunicipio"
        Me.CBSMunicipio.Size = New System.Drawing.Size(257, 22)
        Me.CBSMunicipio.TabIndex = 11
        ComponentTool1.ImageSource = "icon-close"
        ComponentTool1.Name = "Borrar"
        Me.CBSMunicipio.Tools.AddRange(New Wisej.Web.ComponentTool() {ComponentTool1})
        Me.CBSMunicipio.Watermark = "Seleccione la jusirsdiccion"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(451, 21)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(257, 22)
        Me.txtNombre.TabIndex = 3
        Me.txtNombre.Watermark = "Nombre(s)"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(18, 179)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(113, 23)
        Me.BtnEliminar.TabIndex = 10
        Me.BtnEliminar.Text = "Eliminar Foto"
        '
        'BtnAnexar
        '
        Me.BtnAnexar.AllowedFileTypes = "image/*"
        Me.BtnAnexar.HideValue = True
        Me.BtnAnexar.Location = New System.Drawing.Point(18, 140)
        Me.BtnAnexar.Name = "BtnAnexar"
        Me.BtnAnexar.Size = New System.Drawing.Size(113, 22)
        Me.BtnAnexar.TabIndex = 9
        Me.BtnAnexar.Text = "Cambiar Foto"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        Me.PictureBox1.BackgroundImageSource = "Resources/Images/User.png"
        Me.PictureBox1.Location = New System.Drawing.Point(18, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 113)
        Me.PictureBox1.TabIndex = 8
        '
        'CBxMostrar
        '
        Me.CBxMostrar.Location = New System.Drawing.Point(336, 62)
        Me.CBxMostrar.Name = "CBxMostrar"
        Me.CBxMostrar.Size = New System.Drawing.Size(71, 23)
        Me.CBxMostrar.TabIndex = 7
        Me.CBxMostrar.Text = "Mostrar"
        '
        'chkHabilitado
        '
        Me.chkHabilitado.Checked = True
        Me.chkHabilitado.CheckState = CType(Wisej.Web.CheckState.Checked, Wisej.Web.CheckState)
        Me.chkHabilitado.Location = New System.Drawing.Point(150, 179)
        Me.chkHabilitado.Name = "chkHabilitado"
        Me.chkHabilitado.Size = New System.Drawing.Size(348, 23)
        Me.chkHabilitado.TabIndex = 6
        Me.chkHabilitado.Text = "Habilitar Usuario inmediatamente despues del registro"
        '
        'txtContrasena
        '
        Me.txtContrasena.InputType.Type = Wisej.Web.TextBoxType.Password
        Me.txtContrasena.Location = New System.Drawing.Point(150, 63)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.Size = New System.Drawing.Size(180, 22)
        Me.txtContrasena.TabIndex = 4
        Me.txtContrasena.Watermark = "Contraseña"
        '
        'CBSrol
        '
        Me.CBSrol.BackColor = System.Drawing.Color.Transparent
        Me.CBSrol.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSrol.Location = New System.Drawing.Point(451, 107)
        Me.CBSrol.Name = "CBSrol"
        Me.CBSrol.Size = New System.Drawing.Size(257, 22)
        Me.CBSrol.TabIndex = 0
        ComponentTool2.ImageSource = "icon-close"
        ComponentTool2.Name = "Borrar"
        Me.CBSrol.Tools.AddRange(New Wisej.Web.ComponentTool() {ComponentTool2})
        Me.CBSrol.Watermark = "Seleccione el Rol"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 131)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1036, 200)
        Me.Panel1.TabIndex = 7
        '
        'RBDesactivado
        '
        Me.RBDesactivado.Location = New System.Drawing.Point(726, 6)
        Me.RBDesactivado.Name = "RBDesactivado"
        Me.RBDesactivado.Size = New System.Drawing.Size(106, 23)
        Me.RBDesactivado.TabIndex = 6
        Me.RBDesactivado.TabStop = False
        Me.RBDesactivado.Text = "Desactivados"
        '
        'RBHabilitado
        '
        Me.RBHabilitado.Checked = True
        Me.RBHabilitado.Location = New System.Drawing.Point(619, 6)
        Me.RBHabilitado.Name = "RBHabilitado"
        Me.RBHabilitado.Size = New System.Drawing.Size(92, 23)
        Me.RBHabilitado.TabIndex = 5
        Me.RBHabilitado.Text = "Habilitados"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 3
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NOMBRE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'buttonAddNew
        '
        Me.buttonAddNew.ImageSource = "table-row-new"
        Me.buttonAddNew.Location = New System.Drawing.Point(336, 3)
        Me.buttonAddNew.Name = "buttonAddNew"
        Me.buttonAddNew.Size = New System.Drawing.Size(37, 28)
        Me.buttonAddNew.TabIndex = 4
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
        'buttonDelete
        '
        Me.buttonDelete.ImageSource = "icon-close"
        Me.buttonDelete.Location = New System.Drawing.Point(379, 3)
        Me.buttonDelete.Name = "buttonDelete"
        Me.buttonDelete.Size = New System.Drawing.Size(37, 28)
        Me.buttonDelete.TabIndex = 5
        '
        'buttonMoveFirst
        '
        Me.buttonMoveFirst.ImageSource = "icon-first"
        Me.buttonMoveFirst.Location = New System.Drawing.Point(3, 3)
        Me.buttonMoveFirst.Name = "buttonMoveFirst"
        Me.buttonMoveFirst.Size = New System.Drawing.Size(37, 28)
        Me.buttonMoveFirst.TabIndex = 0
        '
        'buttonMoveLast
        '
        Me.buttonMoveLast.ImageSource = "icon-last"
        Me.buttonMoveLast.Location = New System.Drawing.Point(273, 3)
        Me.buttonMoveLast.Name = "buttonMoveLast"
        Me.buttonMoveLast.Size = New System.Drawing.Size(37, 28)
        Me.buttonMoveLast.TabIndex = 3
        '
        'buttonMoveNext
        '
        Me.buttonMoveNext.ImageSource = "icon-right"
        Me.buttonMoveNext.Location = New System.Drawing.Point(230, 3)
        Me.buttonMoveNext.Name = "buttonMoveNext"
        Me.buttonMoveNext.Size = New System.Drawing.Size(37, 28)
        Me.buttonMoveNext.TabIndex = 2
        '
        'buttonMovePrevious
        '
        Me.buttonMovePrevious.ImageSource = "icon-left"
        Me.buttonMovePrevious.Location = New System.Drawing.Point(46, 3)
        Me.buttonMovePrevious.Name = "buttonMovePrevious"
        Me.buttonMovePrevious.Size = New System.Drawing.Size(37, 28)
        Me.buttonMovePrevious.TabIndex = 1
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
        'separatorControl
        '
        Me.separatorControl.Location = New System.Drawing.Point(316, 3)
        Me.separatorControl.Name = "separatorControl"
        Me.separatorControl.Orientation = Wisej.Web.Orientation.Vertical
        Me.separatorControl.Padding = New Wisej.Web.Padding(0, 5, 0, 5)
        Me.separatorControl.Size = New System.Drawing.Size(14, 28)
        '
        'separatorRight
        '
        Me.separatorRight.Location = New System.Drawing.Point(210, 3)
        Me.separatorRight.Name = "separatorRight"
        Me.separatorRight.Orientation = Wisej.Web.Orientation.Vertical
        Me.separatorRight.Padding = New Wisej.Web.Padding(0, 5, 0, 5)
        Me.separatorRight.Size = New System.Drawing.Size(14, 28)
        '
        'separatorLeft
        '
        Me.separatorLeft.Location = New System.Drawing.Point(89, 3)
        Me.separatorLeft.Name = "separatorLeft"
        Me.separatorLeft.Orientation = Wisej.Web.Orientation.Vertical
        Me.separatorLeft.Padding = New Wisej.Web.Padding(0, 5, 0, 5)
        Me.separatorLeft.Size = New System.Drawing.Size(14, 28)
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NOMBRE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FiltroGrillaSax1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DGVOperadores, 0, 1)
        Me.TableLayoutPanel1.Dock = Wisej.Web.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 331)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 14.24051!))
        Me.TableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 85.75949!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1036, 336)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'DGVOperadores
        '
        Me.DGVOperadores.AutoGenerateColumns = False
        Me.DGVOperadores.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.ELIMINAR, Me.USUARIO, Me.contrasena, Me.rol, Me.colXNOMBRE, Me.NOMBRE, Me.APELLIDOS, Me.TELEFONO, Me.CORREO, Me.SEXO, Me.FECHA_NACIMIENTO, Me.GRADO_ESTUDIO, Me.CLAVE_TRABAJADOR, Me.CVE_PERSONA, Me.JURISDICCION, Me.Habilitado, Me.CVE_OPERADOR})
        Me.DGVOperadores.DataMember = "pCAT_OPERADORES_B"
        Me.DGVOperadores.DataSource = Me.DataSetpCATOPERADORESBBindingSource
        Me.DGVOperadores.Dock = Wisej.Web.DockStyle.Fill
        Me.DGVOperadores.Location = New System.Drawing.Point(3, 50)
        Me.DGVOperadores.Name = "DGVOperadores"
        Me.DGVOperadores.Size = New System.Drawing.Size(1030, 283)
        Me.DGVOperadores.TabIndex = 9
        '
        'ELIMINAR
        '
        Me.ELIMINAR.CellImage = CType(resources.GetObject("ELIMINAR.CellImage"), System.Drawing.Image)
        Me.ELIMINAR.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.Width = 30
        '
        'USUARIO
        '
        Me.USUARIO.DataPropertyName = "USUARIO"
        Me.USUARIO.HeaderText = "Usuario"
        Me.USUARIO.Name = "USUARIO"
        Me.USUARIO.Width = 150
        '
        'contrasena
        '
        Me.contrasena.DataPropertyName = "contrasena"
        Me.contrasena.HeaderText = "Contraseña"
        Me.contrasena.Name = "contrasena"
        Me.contrasena.ReadOnly = True
        Me.contrasena.Width = 150
        '
        'rol
        '
        Me.rol.DataPropertyName = "ROL"
        Me.rol.HeaderText = "Rol"
        Me.rol.Name = "rol"
        '
        'colXNOMBRE
        '
        Me.colXNOMBRE.DataPropertyName = "XNOMBRE"
        Me.colXNOMBRE.HeaderText = "Nombre"
        Me.colXNOMBRE.Name = "colXNOMBRE"
        Me.colXNOMBRE.ReadOnly = True
        Me.colXNOMBRE.Width = 250
        '
        'NOMBRE
        '
        Me.NOMBRE.DataPropertyName = "NOMBRE"
        Me.NOMBRE.HeaderText = "NOMBREN"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.Visible = False
        '
        'APELLIDOS
        '
        Me.APELLIDOS.DataPropertyName = "APELLIDOS"
        Me.APELLIDOS.HeaderText = "APELLIDOS"
        Me.APELLIDOS.Name = "APELLIDOS"
        Me.APELLIDOS.Visible = False
        '
        'TELEFONO
        '
        Me.TELEFONO.DataPropertyName = "TELEFONO"
        Me.TELEFONO.HeaderText = "Teléfono"
        Me.TELEFONO.Name = "TELEFONO"
        '
        'CORREO
        '
        Me.CORREO.DataPropertyName = "CORREO"
        Me.CORREO.HeaderText = "Correo"
        Me.CORREO.Name = "CORREO"
        Me.CORREO.Width = 150
        '
        'SEXO
        '
        Me.SEXO.DataPropertyName = "SEXO"
        Me.SEXO.HeaderText = "Sexo"
        Me.SEXO.Name = "SEXO"
        Me.SEXO.Width = 80
        '
        'FECHA_NACIMIENTO
        '
        Me.FECHA_NACIMIENTO.DataPropertyName = "FECHA_NACIMIENTO"
        Me.FECHA_NACIMIENTO.HeaderText = "FECHA_NACIMIENTO"
        Me.FECHA_NACIMIENTO.Name = "FECHA_NACIMIENTO"
        Me.FECHA_NACIMIENTO.Visible = False
        '
        'GRADO_ESTUDIO
        '
        Me.GRADO_ESTUDIO.DataPropertyName = "GRADO_ESTUDIO"
        Me.GRADO_ESTUDIO.HeaderText = "GRADO_ESTUDIO"
        Me.GRADO_ESTUDIO.Name = "GRADO_ESTUDIO"
        Me.GRADO_ESTUDIO.Visible = False
        '
        'CLAVE_TRABAJADOR
        '
        Me.CLAVE_TRABAJADOR.DataPropertyName = "CLAVE_TRABAJADOR"
        Me.CLAVE_TRABAJADOR.HeaderText = "Clave de Trabajador"
        Me.CLAVE_TRABAJADOR.Name = "CLAVE_TRABAJADOR"
        Me.CLAVE_TRABAJADOR.Width = 150
        '
        'CVE_PERSONA
        '
        Me.CVE_PERSONA.DataPropertyName = "CVE_PERSONA"
        Me.CVE_PERSONA.HeaderText = "CVE_PERSONA"
        Me.CVE_PERSONA.Name = "CVE_PERSONA"
        Me.CVE_PERSONA.Visible = False
        Me.CVE_PERSONA.Width = 150
        '
        'JURISDICCION
        '
        Me.JURISDICCION.DataPropertyName = "JURISDICCION"
        Me.JURISDICCION.HeaderText = "Jurisdicción"
        Me.JURISDICCION.Name = "JURISDICCION"
        Me.JURISDICCION.ReadOnly = True
        '
        'Habilitado
        '
        Me.Habilitado.DataPropertyName = "Habilitado"
        Me.Habilitado.HeaderText = "Habilitado"
        Me.Habilitado.Name = "Habilitado"
        Me.Habilitado.Width = 80
        '
        'CVE_OPERADOR
        '
        Me.CVE_OPERADOR.DataPropertyName = "CVE_OPERADOR"
        Me.CVE_OPERADOR.HeaderText = "CVE_OPERADOR"
        Me.CVE_OPERADOR.Name = "CVE_OPERADOR"
        Me.CVE_OPERADOR.ReadOnly = True
        Me.CVE_OPERADOR.Visible = False
        '
        'DataSetpCATOPERADORESBBindingSource
        '
        Me.DataSetpCATOPERADORESBBindingSource.DataSource = Me.DataSet_pCAT_OPERADORES_B
        Me.DataSetpCATOPERADORESBBindingSource.Position = 0
        '
        'DataSet_pCAT_OPERADORES_B
        '
        Me.DataSet_pCAT_OPERADORES_B.DataSetName = "DataSet_pCAT_OPERADORES_B"
        Me.DataSet_pCAT_OPERADORES_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BDN
        '
        Me.BDN.AddNewItem = Me.buttonAddNew1
        Me.BDN.Controls.Add(Me.buttonMoveFirst1)
        Me.BDN.Controls.Add(Me.buttonMovePrevious1)
        Me.BDN.Controls.Add(Me.separatorLeft1)
        Me.BDN.Controls.Add(Me.textBoxPosition1)
        Me.BDN.Controls.Add(Me.labelCount1)
        Me.BDN.Controls.Add(Me.separatorRight1)
        Me.BDN.Controls.Add(Me.buttonMoveNext1)
        Me.BDN.Controls.Add(Me.buttonMoveLast1)
        Me.BDN.Controls.Add(Me.separatorControl1)
        Me.BDN.Controls.Add(Me.buttonAddNew1)
        Me.BDN.Controls.Add(Me.buttonDelete1)
        Me.BDN.CountItem = Me.labelCount1
        Me.BDN.DeleteItem = Me.buttonDelete1
        Me.BDN.Dock = Wisej.Web.DockStyle.Top
        Me.BDN.Location = New System.Drawing.Point(0, 667)
        Me.BDN.MoveFirstItem = Me.buttonMoveFirst1
        Me.BDN.MoveLastItem = Me.buttonMoveLast1
        Me.BDN.MoveNextItem = Me.buttonMoveNext1
        Me.BDN.MovePreviousItem = Me.buttonMovePrevious1
        Me.BDN.Name = "BDN"
        Me.BDN.PositionItem = Me.textBoxPosition1
        Me.BDN.Size = New System.Drawing.Size(1036, 39)
        Me.BDN.TabIndex = 12
        '
        'buttonAddNew1
        '
        Me.buttonAddNew1.ImageSource = "table-row-new"
        Me.buttonAddNew1.Location = New System.Drawing.Point(336, 3)
        Me.buttonAddNew1.Name = "buttonAddNew1"
        Me.buttonAddNew1.Size = New System.Drawing.Size(37, 28)
        Me.buttonAddNew1.TabIndex = 4
        '
        'buttonMoveFirst1
        '
        Me.buttonMoveFirst1.ImageSource = "icon-first"
        Me.buttonMoveFirst1.Location = New System.Drawing.Point(3, 3)
        Me.buttonMoveFirst1.Name = "buttonMoveFirst1"
        Me.buttonMoveFirst1.Size = New System.Drawing.Size(37, 28)
        Me.buttonMoveFirst1.TabIndex = 0
        '
        'buttonMovePrevious1
        '
        Me.buttonMovePrevious1.ImageSource = "icon-left"
        Me.buttonMovePrevious1.Location = New System.Drawing.Point(46, 3)
        Me.buttonMovePrevious1.Name = "buttonMovePrevious1"
        Me.buttonMovePrevious1.Size = New System.Drawing.Size(37, 28)
        Me.buttonMovePrevious1.TabIndex = 1
        '
        'separatorLeft1
        '
        Me.separatorLeft1.Location = New System.Drawing.Point(89, 3)
        Me.separatorLeft1.Name = "separatorLeft1"
        Me.separatorLeft1.Orientation = Wisej.Web.Orientation.Vertical
        Me.separatorLeft1.Padding = New Wisej.Web.Padding(0, 5, 0, 5)
        Me.separatorLeft1.Size = New System.Drawing.Size(14, 28)
        '
        'textBoxPosition1
        '
        Me.textBoxPosition1.AutoSize = False
        Me.textBoxPosition1.Location = New System.Drawing.Point(109, 3)
        Me.textBoxPosition1.Name = "textBoxPosition1"
        Me.textBoxPosition1.Size = New System.Drawing.Size(50, 28)
        Me.textBoxPosition1.TabIndex = 6
        Me.textBoxPosition1.Text = "0"
        '
        'labelCount1
        '
        Me.labelCount1.Location = New System.Drawing.Point(165, 3)
        Me.labelCount1.Name = "labelCount1"
        Me.labelCount1.Size = New System.Drawing.Size(39, 28)
        Me.labelCount1.TabIndex = 7
        Me.labelCount1.Text = "of {0}"
        Me.labelCount1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'separatorRight1
        '
        Me.separatorRight1.Location = New System.Drawing.Point(210, 3)
        Me.separatorRight1.Name = "separatorRight1"
        Me.separatorRight1.Orientation = Wisej.Web.Orientation.Vertical
        Me.separatorRight1.Padding = New Wisej.Web.Padding(0, 5, 0, 5)
        Me.separatorRight1.Size = New System.Drawing.Size(14, 28)
        '
        'buttonMoveNext1
        '
        Me.buttonMoveNext1.ImageSource = "icon-right"
        Me.buttonMoveNext1.Location = New System.Drawing.Point(230, 3)
        Me.buttonMoveNext1.Name = "buttonMoveNext1"
        Me.buttonMoveNext1.Size = New System.Drawing.Size(37, 28)
        Me.buttonMoveNext1.TabIndex = 2
        '
        'buttonMoveLast1
        '
        Me.buttonMoveLast1.ImageSource = "icon-last"
        Me.buttonMoveLast1.Location = New System.Drawing.Point(273, 3)
        Me.buttonMoveLast1.Name = "buttonMoveLast1"
        Me.buttonMoveLast1.Size = New System.Drawing.Size(37, 28)
        Me.buttonMoveLast1.TabIndex = 3
        '
        'separatorControl1
        '
        Me.separatorControl1.Location = New System.Drawing.Point(316, 3)
        Me.separatorControl1.Name = "separatorControl1"
        Me.separatorControl1.Orientation = Wisej.Web.Orientation.Vertical
        Me.separatorControl1.Padding = New Wisej.Web.Padding(0, 5, 0, 5)
        Me.separatorControl1.Size = New System.Drawing.Size(14, 28)
        '
        'buttonDelete1
        '
        Me.buttonDelete1.ImageSource = "icon-close"
        Me.buttonDelete1.Location = New System.Drawing.Point(379, 3)
        Me.buttonDelete1.Name = "buttonDelete1"
        Me.buttonDelete1.Size = New System.Drawing.Size(37, 28)
        Me.buttonDelete1.TabIndex = 5
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Contrasena"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Contrasena"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Contrasena"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Contrasena"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Contrasena"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Contrasena"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Contrasena"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Contrasena"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ROL"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ROL"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NOMBRE"
        Me.DataGridViewTextBoxColumn9.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "NOMBRE"
        Me.DataGridViewTextBoxColumn10.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Habilitado"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Habilitado"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "NOMBRE"
        Me.DataGridViewTextBoxColumn11.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "CVE_OPERADOR"
        Me.DataGridViewTextBoxColumn12.HeaderText = "CVE_OPERADOR"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'FiltroGrillaSax1
        '
        Me.FiltroGrillaSax1.AutoSize = True
        Me.FiltroGrillaSax1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.FiltroGrillaSax1.BackColor = System.Drawing.Color.Transparent
        Me.FiltroGrillaSax1.Dock = Wisej.Web.DockStyle.Fill
        Me.FiltroGrillaSax1.Location = New System.Drawing.Point(3, 3)
        Me.FiltroGrillaSax1.meBackcolorEtiquetas = System.Drawing.Color.AliceBlue
        Me.FiltroGrillaSax1.meBorderStyleEtiquetas = Wisej.Web.BorderStyle.Solid
        Me.FiltroGrillaSax1.meBorderWidthEtiquetas = 1
        Me.FiltroGrillaSax1.meDatagrid = Nothing
        Me.FiltroGrillaSax1.meFiltrarVacios = False
        Me.FiltroGrillaSax1.meLanzarException = False
        Me.FiltroGrillaSax1.meMarginEtiquetas = New Wisej.Web.Padding(1)
        Me.FiltroGrillaSax1.mePaddingEtiquetas = New Wisej.Web.Padding(2)
        Me.FiltroGrillaSax1.Name = "FiltroGrillaSax1"
        Me.FiltroGrillaSax1.Size = New System.Drawing.Size(1030, 41)
        Me.FiltroGrillaSax1.TabIndex = 3
        '
        'Cat_operadores
        '
        Me.ClientSize = New System.Drawing.Size(1036, 562)
        Me.Controls.Add(Me.BDN)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Cat_operadores"
        Me.Text = "Operadores"
        Me.WindowState = Wisej.Web.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DGVOperadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetpCATOPERADORESBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCAT_OPERADORES_B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BDN.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonBar1 As RibbonBar
    Friend WithEvents Menu As RibbonBarPage
    Friend WithEvents Opciones As RibbonBarGroup
    Friend WithEvents RBNNUEVO As RibbonBarItemButton
    Friend WithEvents RBNSALIR As RibbonBarItemButton
    Friend WithEvents FiltroGrillaSax1 As filtroGrillaSax
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnAnexar As Upload
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CBxMostrar As CheckBox
    Friend WithEvents chkHabilitado As CheckBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RBNACTUALIZAR As RibbonBarItemButton
    Friend WithEvents RBNGUARDAR As RibbonBarItemButton
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents RBHabilitado As RadioButton
    Friend WithEvents RBDesactivado As RadioButton
    Friend WithEvents Panel1 As Panel
    Private WithEvents colHabilitado As DataGridViewCheckBoxColumn
    Private WithEvents colMUNICIPIOX As DataGridViewTextBoxColumn
    Private WithEvents colROL As DataGridViewTextBoxColumn
    Private WithEvents colNombre As DataGridViewTextBoxColumn
    Private WithEvents colContrasena As DataGridViewTextBoxColumn
    Private WithEvents colCve_Operador As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents CBSMunicipio As ComboBox
    Friend WithEvents txtUsuario As TextBox
    Private WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Private WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents buttonAddNew As Button
    Friend WithEvents labelCount As Label
    Friend WithEvents buttonDelete As Button
    Friend WithEvents buttonMoveFirst As Button
    Friend WithEvents buttonMoveLast As Button
    Friend WithEvents buttonMoveNext As Button
    Friend WithEvents buttonMovePrevious As Button
    Friend WithEvents textBoxPosition As TextBox
    Friend WithEvents separatorControl As Line
    Friend WithEvents separatorRight As Line
    Friend WithEvents separatorLeft As Line
    Friend WithEvents BindingSource1 As BindingSource
    Private WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BDN As BindingNavigator
    Friend WithEvents buttonAddNew1 As Button
    Friend WithEvents buttonMoveFirst1 As Button
    Friend WithEvents buttonMovePrevious1 As Button
    Friend WithEvents separatorLeft1 As Line
    Friend WithEvents textBoxPosition1 As TextBox
    Friend WithEvents labelCount1 As Label
    Friend WithEvents separatorRight1 As Line
    Friend WithEvents buttonMoveNext1 As Button
    Friend WithEvents buttonMoveLast1 As Button
    Friend WithEvents separatorControl1 As Line
    Friend WithEvents buttonDelete1 As Button
    Friend WithEvents DGVOperadores As DataGridView
    Friend WithEvents DataSetpCATOPERADORESBBindingSource As BindingSource
    Friend WithEvents DataSet_pCAT_OPERADORES_B As DataSet_pCAT_OPERADORES_B
    Private WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Private WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents contrasena As DataGridViewTextBoxColumn
    Private WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Private WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents USUARIO As DataGridViewTextBoxColumn
    Friend WithEvents rol As DataGridViewTextBoxColumn
    Friend WithEvents colXNOMBRE As DataGridViewTextBoxColumn
    Private WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Private WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Private WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents ELIMINAR As DataGridViewImageColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOS As DataGridViewTextBoxColumn
    Friend WithEvents Habilitado As DataGridViewCheckBoxColumn
    Private WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Private WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents TELEFONO As DataGridViewTextBoxColumn
    Friend WithEvents CORREO As DataGridViewTextBoxColumn
    Friend WithEvents SEXO As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_NACIMIENTO As DataGridViewDateTimePickerColumn
    Friend WithEvents GRADO_ESTUDIO As DataGridViewTextBoxColumn
    Friend WithEvents CLAVE_TRABAJADOR As DataGridViewTextBoxColumn
    Friend WithEvents CVE_PERSONA As DataGridViewTextBoxColumn
    Friend WithEvents JURISDICCION As DataGridViewTextBoxColumn
    Friend WithEvents CVE_OPERADOR As DataGridViewTextBoxColumn
    Private WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents cbxestudio As ComboBox
    Friend WithEvents cbxsexo As ComboBox
    Friend WithEvents DTPFechaNacimiento As DateTimePicker
    Friend WithEvents txtClaveDelTrabajador As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents CBSrol As ComboBox
End Class
