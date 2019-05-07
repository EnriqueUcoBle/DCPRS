
Imports Wisej.Web
Imports Wisej.Web.Ext.RibbonBar

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class C_contra
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RibbonBarButtonItem1 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RibbonBarButtonItem2 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Label1 = New Wisej.Web.Label()
        Me.Label2 = New Wisej.Web.Label()
        Me.Label3 = New Wisej.Web.Label()
        Me.TxtC_anterior = New Wisej.Web.TextBox()
        Me.txtN_contrasena = New Wisej.Web.TextBox()
        Me.txtC_contra = New Wisej.Web.TextBox()
        Me.CBMostrar = New Wisej.Web.CheckBox()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.ErrorProvider1 = New Wisej.Web.ErrorProvider(Me.components)
        Me.Label5 = New Wisej.Web.Label()
        Me.TBContrasena = New Wisej.Web.TextBox()
        Me.Label4 = New Wisej.Web.Label()
        Me.txtN_contra = New Wisej.Web.TextBox()
        Me.Label6 = New Wisej.Web.Label()
        Me.txtconfirmar = New Wisej.Web.TextBox()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Dock = Wisej.Web.DockStyle.Top
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(516, 145)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Text = "Menu"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.RibbonBarButtonItem1)
        Me.RibbonBarGroup1.Items.Add(Me.RibbonBarButtonItem2)
        Me.RibbonBarGroup1.Text = "Opciones"
        '
        'RibbonBarButtonItem1
        '
        Me.RibbonBarButtonItem1.ColumnBreak = True
        Me.RibbonBarButtonItem1.ImageSource = "RibbonBarButtonItem1.Image"
        Me.RibbonBarButtonItem1.Text = "Guardar"
        '
        'RibbonBarButtonItem2
        '
        Me.RibbonBarButtonItem2.ColumnBreak = True
        Me.RibbonBarButtonItem2.ImageSource = "RibbonBarButtonItem2.Image"
        Me.RibbonBarButtonItem2.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Contraseña anterior"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(159, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nueva contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(159, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Confirmar contraseña"
        '
        'TxtC_anterior
        '
        Me.TxtC_anterior.Location = New System.Drawing.Point(162, 182)
        Me.TxtC_anterior.Name = "TxtC_anterior"
        Me.TxtC_anterior.Size = New System.Drawing.Size(100, 20)
        Me.TxtC_anterior.TabIndex = 2
        '
        'txtN_contrasena
        '
        Me.txtN_contrasena.Location = New System.Drawing.Point(162, 260)
        Me.txtN_contrasena.Name = "txtN_contrasena"
        Me.txtN_contrasena.Size = New System.Drawing.Size(100, 20)
        Me.txtN_contrasena.TabIndex = 2
        '
        'txtC_contra
        '
        Me.txtC_contra.Location = New System.Drawing.Point(162, 342)
        Me.txtC_contra.Name = "txtC_contra"
        Me.txtC_contra.Size = New System.Drawing.Size(100, 20)
        Me.txtC_contra.TabIndex = 2
        '
        'CBMostrar
        '
        Me.CBMostrar.Location = New System.Drawing.Point(311, 150)
        Me.CBMostrar.Name = "CBMostrar"
        Me.CBMostrar.Size = New System.Drawing.Size(144, 23)
        Me.CBMostrar.TabIndex = 3
        Me.CBMostrar.Text = "Mostrar Contraseña"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 3
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contraseña Actual"
        '
        'TBContrasena
        '
        Me.TBContrasena.Location = New System.Drawing.Point(166, 147)
        Me.TBContrasena.Name = "TBContrasena"
        Me.TBContrasena.Size = New System.Drawing.Size(130, 22)
        Me.TBContrasena.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nueva Contraseña"
        '
        'txtN_contra
        '
        Me.txtN_contra.InputType.Type = Wisej.Web.TextBoxType.Password
        Me.txtN_contra.Location = New System.Drawing.Point(166, 186)
        Me.txtN_contra.Name = "txtN_contra"
        Me.txtN_contra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtN_contra.Size = New System.Drawing.Size(130, 22)
        Me.txtN_contra.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Confirmar Contraseña"
        '
        'txtconfirmar
        '
        Me.txtconfirmar.InputType.Type = Wisej.Web.TextBoxType.Password
        Me.txtconfirmar.Location = New System.Drawing.Point(166, 225)
        Me.txtconfirmar.Name = "txtconfirmar"
        Me.txtconfirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfirmar.Size = New System.Drawing.Size(130, 22)
        Me.txtconfirmar.TabIndex = 5
        '
        'C_contra
        '
        Me.ClientSize = New System.Drawing.Size(516, 397)
        Me.Controls.Add(Me.txtconfirmar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtN_contra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBContrasena)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CBMostrar)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "C_contra"
        Me.Text = "Modificar Contraseña"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonBar1 As RibbonBar
    Friend WithEvents RibbonBarPage1 As RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As RibbonBarGroup
    Friend WithEvents RibbonBarButtonItem1 As RibbonBarItemButton
    Friend WithEvents RibbonBarButtonItem2 As RibbonBarItemButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtC_anterior As TextBox
    Friend WithEvents txtN_contrasena As TextBox
    Friend WithEvents txtC_contra As TextBox
    Friend WithEvents CBMostrar As CheckBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ErrorProvider1 As ErrorProvider
    '  Friend WithEvents DataSet_pCAT_OPERADORES_B As DataSet_pCAT_OPERADORES_B
    Friend WithEvents Label5 As Label
    Friend WithEvents TBContrasena As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtN_contra As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtconfirmar As TextBox
End Class
