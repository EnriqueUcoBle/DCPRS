﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reportar_Queja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reportar_Queja))
        Me.QUEJA = New Wisej.Web.TextBox()
        Me.CVE = New Wisej.Web.TextBox()
        Me.Panel1 = New Wisej.Web.Panel()
        Me.GUARDAR = New Wisej.Web.Button()
        Me.NUEVO = New Wisej.Web.Button()
        Me.ESTABLECIMIENTOS = New DPCRS.Combosax_B()
        Me.ADD_ESTABLECIMIENTO = New Wisej.Web.Button()
        Me.DateTimePicker1 = New Wisej.Web.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'QUEJA
        '
        Me.QUEJA.Location = New System.Drawing.Point(27, 116)
        Me.QUEJA.Multiline = True
        Me.QUEJA.Name = "QUEJA"
        Me.QUEJA.Size = New System.Drawing.Size(366, 157)
        Me.QUEJA.TabIndex = 20
        '
        'CVE
        '
        Me.CVE.Location = New System.Drawing.Point(207, 298)
        Me.CVE.Name = "CVE"
        Me.CVE.ReadOnly = True
        Me.CVE.Size = New System.Drawing.Size(10, 22)
        Me.CVE.TabIndex = 32
        Me.CVE.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromName("@scrollBar")
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.ADD_ESTABLECIMIENTO)
        Me.Panel1.Controls.Add(Me.ESTABLECIMIENTOS)
        Me.Panel1.Controls.Add(Me.NUEVO)
        Me.Panel1.Controls.Add(Me.GUARDAR)
        Me.Panel1.Controls.Add(Me.CVE)
        Me.Panel1.Controls.Add(Me.QUEJA)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Fill
        Me.Panel1.HeaderForeColor = System.Drawing.Color.FromName("@control")
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(414, 355)
        Me.Panel1.TabIndex = 35
        '
        'GUARDAR
        '
        Me.GUARDAR.ImageSource = "Resources\Images\Menu\64\002-diskette .png"
        Me.GUARDAR.Location = New System.Drawing.Point(27, 298)
        Me.GUARDAR.Name = "GUARDAR"
        Me.GUARDAR.Size = New System.Drawing.Size(133, 27)
        Me.GUARDAR.TabIndex = 36
        Me.GUARDAR.Text = "Guardar Queja"
        '
        'NUEVO
        '
        Me.NUEVO.ImageSource = "Resources\Icons\Menu\add.png"
        Me.NUEVO.Location = New System.Drawing.Point(284, 298)
        Me.NUEVO.Name = "NUEVO"
        Me.NUEVO.Size = New System.Drawing.Size(109, 27)
        Me.NUEVO.TabIndex = 37
        Me.NUEVO.Text = "Nuevo"
        '
        'ESTABLECIMIENTOS
        '
        Me.ESTABLECIMIENTOS.amarillo = False
        Me.ESTABLECIMIENTOS.Ancho = Nothing
        Me.ESTABLECIMIENTOS.BackColor = System.Drawing.Color.FromName("@window")
        Me.ESTABLECIMIENTOS.ColorAtras = System.Drawing.Color.Empty
        Me.ESTABLECIMIENTOS.Count = 0
        Me.ESTABLECIMIENTOS.DataSourceSelect = Nothing
        Me.ESTABLECIMIENTOS.gris = False
        Me.ESTABLECIMIENTOS.Letra = Nothing
        Me.ESTABLECIMIENTOS.Limitar = False
        Me.ESTABLECIMIENTOS.Location = New System.Drawing.Point(27, 23)
        Me.ESTABLECIMIENTOS.MensajeAgua = Nothing
        Me.ESTABLECIMIENTOS.mostrarMensaje = False
        Me.ESTABLECIMIENTOS.Name = "ESTABLECIMIENTOS"
        Me.ESTABLECIMIENTOS.Negritas = False
        Me.ESTABLECIMIENTOS.OBTENERLISTLLENADO = Nothing
        Me.ESTABLECIMIENTOS.procedure = Nothing
        Me.ESTABLECIMIENTOS.SelectedIndex = -1
        Me.ESTABLECIMIENTOS.SelectedItem = ""
        Me.ESTABLECIMIENTOS.SelectedValue = Nothing
        Me.ESTABLECIMIENTOS.Size = New System.Drawing.Size(281, 22)
        Me.ESTABLECIMIENTOS.TabIndex = 38
        Me.ESTABLECIMIENTOS.TODOSS = False
        Me.ESTABLECIMIENTOS.Watermark = Nothing
        '
        'ADD_ESTABLECIMIENTO
        '
        Me.ADD_ESTABLECIMIENTO.ImageSource = "Resources\Icons\Menu\add.png"
        Me.ADD_ESTABLECIMIENTO.Location = New System.Drawing.Point(342, 18)
        Me.ADD_ESTABLECIMIENTO.Name = "ADD_ESTABLECIMIENTO"
        Me.ADD_ESTABLECIMIENTO.Size = New System.Drawing.Size(51, 27)
        Me.ADD_ESTABLECIMIENTO.TabIndex = 10
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(27, 74)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(366, 22)
        Me.DateTimePicker1.TabIndex = 39
        Me.DateTimePicker1.Value = New Date(CType(0, Long))
        '
        'Reportar_Queja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 355)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(426, 399)
        Me.MinimumSize = New System.Drawing.Size(426, 399)
        Me.Name = "Reportar_Queja"
        Me.Text = "Reportar Queja"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents QUEJA As Wisej.Web.TextBox
    Friend WithEvents CVE As Wisej.Web.TextBox
    Friend WithEvents Panel1 As Wisej.Web.Panel
    Friend WithEvents ESTABLECIMIENTOS As Combosax_B
    Friend WithEvents NUEVO As Wisej.Web.Button
    Friend WithEvents GUARDAR As Wisej.Web.Button
    Friend WithEvents ADD_ESTABLECIMIENTO As Wisej.Web.Button
    Friend WithEvents DateTimePicker1 As Wisej.Web.DateTimePicker
End Class
