<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion_Orden_Verificacion
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
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.PGGENERAR = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.GPgenerar = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.Acta_Taller = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Acta_Alberca = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Acta_Hospitales = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Acta_Vulca = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Acta_General = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Acta_Rayos = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Acta_Agro = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Acta_Agua = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Acciones = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.Seguimiento = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Salir = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()

        Me.SuspendLayout
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Dock = Wisej.Web.DockStyle.Top
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.PGGENERAR)
        Me.RibbonBar1.Size = New System.Drawing.Size(881, 139)
        '
        'PGGENERAR
        '
        Me.PGGENERAR.Groups.Add(Me.GPgenerar)
        Me.PGGENERAR.Groups.Add(Me.Acciones)
        Me.PGGENERAR.Text = "Generar Orden Verificacion"
        '
        'GPgenerar
        '
        Me.GPgenerar.Items.Add(Me.Acta_Taller)
        Me.GPgenerar.Items.Add(Me.Acta_Alberca)
        Me.GPgenerar.Items.Add(Me.Acta_Hospitales)
        Me.GPgenerar.Items.Add(Me.Acta_Vulca)
        Me.GPgenerar.Items.Add(Me.Acta_General)
        Me.GPgenerar.Items.Add(Me.Acta_Rayos)
        Me.GPgenerar.Items.Add(Me.Acta_Agro)
        Me.GPgenerar.Items.Add(Me.Acta_Agua)
        Me.GPgenerar.Text = "Generar"
        '
        'Acta_Taller
        '
        Me.Acta_Taller.Name = "Acta_Taller"
        Me.Acta_Taller.Text = "Talleres"
        '
        'Acta_Alberca
        '
        Me.Acta_Alberca.Name = "Acta_Alberca"
        Me.Acta_Alberca.Text = "Albercas"
        '
        'Acta_Hospitales
        '
        Me.Acta_Hospitales.Name = "Acta_Hospitales"
        Me.Acta_Hospitales.Text = "Hospitales"
        '
        'Acta_Vulca
        '
        Me.Acta_Vulca.Name = "Acta_Vulca"
        Me.Acta_Vulca.Text = "Vulcanizadoras"
        '
        'Acta_General
        '
        Me.Acta_General.Name = "Acta_General"
        Me.Acta_General.Text = "Acta General"
        '
        'Acta_Rayos
        '
        Me.Acta_Rayos.Name = "Acta_Rayos"
        Me.Acta_Rayos.Text = "Rayos X"
        '
        'Acta_Agro
        '
        Me.Acta_Agro.Name = "Acta_Agro"
        Me.Acta_Agro.Text = "Industria Agrupecuaria"
        '
        'Acta_Agua
        '
        Me.Acta_Agua.Name = "Acta_Agua"
        Me.Acta_Agua.Text = "Sistema de agua"
        '
        'Acciones
        '
        Me.Acciones.Items.Add(Me.Seguimiento)
        Me.Acciones.Items.Add(Me.Salir)
        Me.Acciones.Text = "Acciones"
        '
        'Seguimiento
        '
        Me.Seguimiento.Name = "Seguimiento"
        Me.Seguimiento.Text = "Seguimiento de Ordenes Generadas"
        '
        'Salir
        '
        Me.Salir.Name = "Salir"
        Me.Salir.Text = "Salir"
        '

        'Gestion_Orden_Verificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 787)

        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Gestion_Orden_Verificacion"
        Me.Text = "Gestion_Actas_Verificacion"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonBar1 As Wisej.Web.Ext.RibbonBar.RibbonBar
    Friend WithEvents PGGENERAR As Wisej.Web.Ext.RibbonBar.RibbonBarPage
    Friend WithEvents GPgenerar As Wisej.Web.Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents Acta_Taller As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents Acta_Alberca As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents Acta_Hospitales As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents Acta_Vulca As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents Acta_General As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents Acta_Rayos As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents Acta_Agro As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents Acta_Agua As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents Acciones As Wisej.Web.Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents Seguimiento As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents Salir As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents Talleres As Panel
End Class
