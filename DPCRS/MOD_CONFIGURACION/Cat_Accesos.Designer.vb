Imports Wisej.Web
Imports Wisej.Web.Ext
Imports Wisej.Web.Ext.RibbonBar
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cat_Accesos
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
        Dim ComponentTool1 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RibbonBarButtonItem2 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RibbonBarItemButton1 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.GroupBox1 = New Wisej.Web.GroupBox()
        Me.Label1 = New Wisej.Web.Label()
        Me.cbsRol = New Wisej.Web.ComboBox()
        Me.ssGrouupbox = New Wisej.Web.GroupBox()
        Me.DataGridView1 = New Wisej.Web.DataGridView()
        Me.Clave_operador = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Contrase = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.ROL = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Fecha = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pCAT_OPERADORES_B1 = New DPCRS.DataSet_pCAT_OPERADORES_B()
        Me.TreeView1 = New Wisej.Web.TreeView()
        Me.Fecha_Alta = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Contrasena = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Label2 = New Wisej.Web.Label()
        Me.GroupBox1.SuspendLayout()
        Me.ssGrouupbox.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCAT_OPERADORES_B1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Dock = Wisej.Web.DockStyle.Top
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(867, 145)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Text = "Men�"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.RibbonBarButtonItem2)
        Me.RibbonBarGroup1.Items.Add(Me.RibbonBarItemButton1)
        Me.RibbonBarGroup1.Text = "Procesos"
        '
        'RibbonBarButtonItem2
        '
        Me.RibbonBarButtonItem2.ImageSource = "ribbon-save?color=#FF0000"
        Me.RibbonBarButtonItem2.Name = "RibbonBarButtonItem2"
        Me.RibbonBarButtonItem2.Text = "Guardar"
        '
        'RibbonBarItemButton1
        '
        Me.RibbonBarItemButton1.ImageSource = "Resources\Images\Menu\30\exit-sign-red.png?color=#0000FF"
        Me.RibbonBarItemButton1.Name = "RibbonBarItemButton1"
        Me.RibbonBarItemButton1.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbsRol)
        Me.GroupBox1.Dock = Wisej.Web.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(867, 71)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.Text = "Accesos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TIPO DE USUARIO"
        '
        'cbsRol
        '
        Me.cbsRol.BackColor = System.Drawing.Color.Transparent
        Me.cbsRol.Cursor = Wisej.Web.Cursors.Hand
        Me.cbsRol.Location = New System.Drawing.Point(179, 21)
        Me.cbsRol.Name = "cbsRol"
        Me.cbsRol.Size = New System.Drawing.Size(307, 22)
        Me.cbsRol.TabIndex = 0
        ComponentTool1.ImageSource = "icon-close"
        ComponentTool1.Name = "Borrar"
        Me.cbsRol.Tools.AddRange(New Wisej.Web.ComponentTool() {ComponentTool1})
        Me.cbsRol.Watermark = "Ingrese Texto (Enter)..."
        '
        'ssGrouupbox
        '
        Me.ssGrouupbox.Controls.Add(Me.DataGridView1)
        Me.ssGrouupbox.Controls.Add(Me.TreeView1)
        Me.ssGrouupbox.Dock = Wisej.Web.DockStyle.Fill
        Me.ssGrouupbox.Location = New System.Drawing.Point(0, 216)
        Me.ssGrouupbox.Name = "ssGrouupbox"
        Me.ssGrouupbox.Size = New System.Drawing.Size(867, 184)
        Me.ssGrouupbox.TabIndex = 1
        Me.ssGrouupbox.Text = "Administraci�n"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.Clave_operador, Me.Contrase, Me.ROL, Me.Fecha})
        Me.DataGridView1.DataSource = Me.BindingSource1
        Me.DataGridView1.Dock = Wisej.Web.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(326, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(538, 163)
        Me.DataGridView1.TabIndex = 1
        '
        'Clave_operador
        '
        Me.Clave_operador.DataPropertyName = "Cve_Operador"
        Me.Clave_operador.HeaderText = "Clave operador"
        Me.Clave_operador.Name = "Clave_operador"
        Me.Clave_operador.ReadOnly = True
        '
        'Contrase
        '
        Me.Contrase.DataPropertyName = "Contrasena"
        Me.Contrase.HeaderText = "Password"
        Me.Contrase.Name = "Contrase"
        Me.Contrase.ReadOnly = True
        '
        'ROL
        '
        Me.ROL.DataPropertyName = "ROL"
        Me.ROL.Name = "ROL"
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha_Alta"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "pCAT_OPERADORES_B"
        Me.BindingSource1.DataSource = Me.DataSet_pCAT_OPERADORES_B1
        '
        'DataSet_pCAT_OPERADORES_B1
        '
        Me.DataSet_pCAT_OPERADORES_B1.DataSetName = "DataSet_pCAT_OPERADORES_B"
        Me.DataSet_pCAT_OPERADORES_B1.EnforceConstraints = False
        Me.DataSet_pCAT_OPERADORES_B1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TreeView1
        '
        Me.TreeView1.Dock = Wisej.Web.DockStyle.Left
        Me.TreeView1.Location = New System.Drawing.Point(3, 18)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(323, 163)
        Me.TreeView1.TabIndex = 0
        '
        'Fecha_Alta
        '
        Me.Fecha_Alta.DataPropertyName = "Fecha_Alta"
        Me.Fecha_Alta.HeaderText = "Fecha de alta"
        Me.Fecha_Alta.Name = "Fecha_Alta"
        '
        'Contrasena
        '
        Me.Contrasena.DataPropertyName = "Contrasena"
        Me.Contrasena.HeaderText = "Contrase�a"
        Me.Contrasena.Name = "Contrasena"
        Me.Contrasena.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(264, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(436, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Antes de conceder permisos o revocarlos relecciones un tipo de usuario"
        '
        'Cat_Accesos
        '
        Me.ClientSize = New System.Drawing.Size(867, 400)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ssGrouupbox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Cat_Accesos"
        Me.Text = "Accesos"
        Me.WindowState = Wisej.Web.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ssGrouupbox.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCAT_OPERADORES_B1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonBar1 As RibbonBar
    Friend WithEvents RibbonBarPage1 As RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As RibbonBarGroup
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ssGrouupbox As GroupBox
    Friend WithEvents cbsRol As ComboBox
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataSet_pCAT_OPERADORES_B1 As DataSet_pCAT_OPERADORES_B
    Private WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents RibbonBarButtonItem2 As RibbonBarItemButton
    Friend WithEvents RibbonBarItemButton1 As RibbonBarItemButton
    Private WithEvents Clave_operador As DataGridViewTextBoxColumn
    Private WithEvents Fecha_Alta As DataGridViewTextBoxColumn
    Private WithEvents Contrasena As DataGridViewTextBoxColumn
    Private WithEvents Contrase As DataGridViewTextBoxColumn
    Private WithEvents ROL As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
End Class