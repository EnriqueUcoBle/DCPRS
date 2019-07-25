Imports Wisej.Web.Ext.RibbonBar
Imports Wisej.Web

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MyDesktop
    Inherits Wisej.Web.Desktop

    'Form overrides dispose to clean up the component list.
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

    'Required by the Wisej Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Wisej Form Designer
    'It can be modified using the Wisej Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyDesktop))
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.pgADMIN = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.Modificar = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.Cskin = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Cpass = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Cfondo = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Usuario = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.Datos = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.session = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Hsessiones = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RibbonBarItemButton1 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RibbonBarItemButton2 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RibbonBarItemButton3 = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.DesktopTaskBarItemDateTime1 = New Wisej.Web.DesktopTaskBarItemDateTime()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        resources.ApplyResources(Me.RibbonBar1, "RibbonBar1")
        '
        '
        '
        Me.RibbonBar1.AppButton.ImageIndex = CType(resources.GetObject("RibbonBar1.AppButton.ImageIndex"), Integer)
        Me.RibbonBar1.AppButton.ImageKey = resources.GetString("RibbonBar1.AppButton.ImageKey")
        Me.RibbonBar1.AppButton.Text = resources.GetString("RibbonBar1.AppButton.Text")
        Me.RibbonBar1.AppButton.ToolTipText = resources.GetString("RibbonBar1.AppButton.ToolTipText")
        Me.RibbonBar1.AppButton.Visible = CType(resources.GetObject("RibbonBar1.AppButton.Visible"), Boolean)
        Me.RibbonBar1.Font = New System.Drawing.Font("default, Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.pgADMIN)
        '
        'pgADMIN
        '
        resources.ApplyResources(Me.pgADMIN, "pgADMIN")
        Me.pgADMIN.Groups.Add(Me.Modificar)
        Me.pgADMIN.Groups.Add(Me.Usuario)
        Me.pgADMIN.TabBackColor = System.Drawing.Color.FromArgb(183, 183, 183)
        '
        'Modificar
        '
        resources.ApplyResources(Me.Modificar, "Modificar")
        Me.Modificar.Items.Add(Me.Cskin)
        Me.Modificar.Items.Add(Me.Cpass)
        Me.Modificar.Items.Add(Me.Cfondo)
        '
        'Cskin
        '
        resources.ApplyResources(Me.Cskin, "Cskin")
        Me.Cskin.Name = "Cskin"
        '
        'Cpass
        '
        resources.ApplyResources(Me.Cpass, "Cpass")
        Me.Cpass.Name = "Cpass"
        '
        'Cfondo
        '
        resources.ApplyResources(Me.Cfondo, "Cfondo")
        Me.Cfondo.Name = "Cfondo"
        '
        'Usuario
        '
        resources.ApplyResources(Me.Usuario, "Usuario")
        Me.Usuario.Items.Add(Me.Datos)
        Me.Usuario.Items.Add(Me.session)
        Me.Usuario.Items.Add(Me.Hsessiones)
        '
        'Datos
        '
        resources.ApplyResources(Me.Datos, "Datos")
        Me.Datos.Name = "Datos"
        Me.Datos.Orientation = Wisej.Web.Orientation.Horizontal
        '
        'session
        '
        resources.ApplyResources(Me.session, "session")
        Me.session.Name = "session"
        Me.session.Orientation = Wisej.Web.Orientation.Horizontal
        '
        'Hsessiones
        '
        resources.ApplyResources(Me.Hsessiones, "Hsessiones")
        Me.Hsessiones.Name = "Hsessiones"
        Me.Hsessiones.Orientation = Wisej.Web.Orientation.Horizontal
        '
        'RibbonBarItemButton1
        '
        resources.ApplyResources(Me.RibbonBarItemButton1, "RibbonBarItemButton1")
        Me.RibbonBarItemButton1.Name = "RibbonBarItemButton1"
        Me.RibbonBarItemButton1.Orientation = Wisej.Web.Orientation.Horizontal
        '
        'RibbonBarItemButton2
        '
        resources.ApplyResources(Me.RibbonBarItemButton2, "RibbonBarItemButton2")
        Me.RibbonBarItemButton2.Name = "RibbonBarItemButton2"
        Me.RibbonBarItemButton2.Orientation = Wisej.Web.Orientation.Horizontal
        '
        'RibbonBarItemButton3
        '
        resources.ApplyResources(Me.RibbonBarItemButton3, "RibbonBarItemButton3")
        Me.RibbonBarItemButton3.Name = "RibbonBarItemButton3"
        Me.RibbonBarItemButton3.Orientation = Wisej.Web.Orientation.Horizontal
        '
        'DesktopTaskBarItemDateTime1
        '
        resources.ApplyResources(Me.DesktopTaskBarItemDateTime1, "DesktopTaskBarItemDateTime1")
        Me.DesktopTaskBarItemDateTime1.Name = "DesktopTaskBarItemDateTime1"
        '
        'MyDesktop
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.RibbonBar1)
        Me.ForeColor = System.Drawing.Color.FromName("@appWorkspace")
        Me.Items.AddRange(New Wisej.Web.DesktopTaskBarItem() {Me.DesktopTaskBarItemDateTime1})
        Me.Name = "MyDesktop"
        Me.ResumeLayout(False)

    End Sub
    'Friend WithEvents pnlDatosUsuarios As Panel
    Friend WithEvents RibbonBar1 As RibbonBar
    Public WithEvents pgADMIN As RibbonBarPage
    Friend WithEvents Modificar As RibbonBarGroup
    Friend WithEvents Cskin As RibbonBarItemButton
    Friend WithEvents Cpass As RibbonBarItemButton
    Friend WithEvents Usuario As RibbonBarGroup
    Friend WithEvents RibbonBarItemButton1 As RibbonBarItemButton
    Friend WithEvents RibbonBarItemButton2 As RibbonBarItemButton
    Friend WithEvents RibbonBarItemButton3 As RibbonBarItemButton
    Friend WithEvents Datos As RibbonBarItemButton
    Friend WithEvents session As RibbonBarItemButton
    Friend WithEvents Cfondo As RibbonBarItemButton
    Friend WithEvents DesktopTaskBarItemDateTime1 As DesktopTaskBarItemDateTime
    Friend WithEvents Hsessiones As RibbonBarItemButton
End Class
