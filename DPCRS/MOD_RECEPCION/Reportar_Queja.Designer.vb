﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportar_Queja
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
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RRBNUEVO = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RRBCANCELAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RRBENVIAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.TextBoxDIRECCION = New Wisej.Web.TextBox()
        Me.TextBoxNOMBRE = New Wisej.Web.TextBox()
        Me.TextBoxQUEJA = New Wisej.Web.TextBox()
        Me.TextBoxQUEJAS = New Wisej.Web.TextBox()
        Me.Label1 = New Wisej.Web.Label()
        Me.Label8 = New Wisej.Web.Label()
        Me.Label9 = New Wisej.Web.Label()
        Me.Label10 = New Wisej.Web.Label()
        Me.Label12 = New Wisej.Web.Label()
        Me.ComboBoxGIRO = New Wisej.Web.ComboBox()
        Me.Label13 = New Wisej.Web.Label()
        Me.TextBoxID = New Wisej.Web.TextBox()
        Me.ComboBoxMUNICIPIO = New Wisej.Web.ComboBox()
        Me.Panel1 = New Wisej.Web.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Dock = Wisej.Web.DockStyle.Top
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(684, 126)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Text = "Acciones"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.RRBNUEVO)
        Me.RibbonBarGroup1.Items.Add(Me.RRBCANCELAR)
        Me.RibbonBarGroup1.Items.Add(Me.RRBENVIAR)
        '
        'RRBNUEVO
        '
        Me.RRBNUEVO.ImageSource = "ribbon-document"
        Me.RRBNUEVO.Name = "RRBNUEVO"
        Me.RRBNUEVO.Text = "Nuevo"
        '
        'RRBCANCELAR
        '
        Me.RRBCANCELAR.ImageSource = "ribbon-delete"
        Me.RRBCANCELAR.Name = "RRBCANCELAR"
        Me.RRBCANCELAR.Text = "Cancelar"
        '
        'RRBENVIAR
        '
        Me.RRBENVIAR.ImageSource = "Resources\Images\Menu\64\folder-13.png"
        Me.RRBENVIAR.Name = "RRBENVIAR"
        Me.RRBENVIAR.Text = "Enviar Queja"
        '
        'TextBoxDIRECCION
        '
        Me.TextBoxDIRECCION.Location = New System.Drawing.Point(196, 213)
        Me.TextBoxDIRECCION.Multiline = True
        Me.TextBoxDIRECCION.Name = "TextBoxDIRECCION"
        Me.TextBoxDIRECCION.Size = New System.Drawing.Size(366, 87)
        Me.TextBoxDIRECCION.TabIndex = 15
        '
        'TextBoxNOMBRE
        '
        Me.TextBoxNOMBRE.Location = New System.Drawing.Point(196, 123)
        Me.TextBoxNOMBRE.Name = "TextBoxNOMBRE"
        Me.TextBoxNOMBRE.Size = New System.Drawing.Size(366, 22)
        Me.TextBoxNOMBRE.TabIndex = 17
        '
        'TextBoxQUEJA
        '
        Me.TextBoxQUEJA.Location = New System.Drawing.Point(1341, 548)
        Me.TextBoxQUEJA.Name = "TextBoxQUEJA"
        Me.TextBoxQUEJA.Size = New System.Drawing.Size(366, 22)
        Me.TextBoxQUEJA.TabIndex = 18
        '
        'TextBoxQUEJAS
        '
        Me.TextBoxQUEJAS.Location = New System.Drawing.Point(196, 325)
        Me.TextBoxQUEJAS.Multiline = True
        Me.TextBoxQUEJAS.Name = "TextBoxQUEJAS"
        Me.TextBoxQUEJAS.Size = New System.Drawing.Size(366, 157)
        Me.TextBoxQUEJAS.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Jurisdiccion:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 16)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Nombre Propietario:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 16)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Direccion:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 171)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 16)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Giro:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 328)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(143, 16)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Observaciones(queja):"
        '
        'ComboBoxGIRO
        '
        Me.ComboBoxGIRO.Location = New System.Drawing.Point(196, 165)
        Me.ComboBoxGIRO.Name = "ComboBoxGIRO"
        Me.ComboBoxGIRO.Size = New System.Drawing.Size(366, 22)
        Me.ComboBoxGIRO.TabIndex = 29
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 16)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "ID:"
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(196, 40)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.ReadOnly = True
        Me.TextBoxID.Size = New System.Drawing.Size(366, 22)
        Me.TextBoxID.TabIndex = 32
        '
        'ComboBoxMUNICIPIO
        '
        Me.ComboBoxMUNICIPIO.Location = New System.Drawing.Point(196, 80)
        Me.ComboBoxMUNICIPIO.Name = "ComboBoxMUNICIPIO"
        Me.ComboBoxMUNICIPIO.Size = New System.Drawing.Size(366, 22)
        Me.ComboBoxMUNICIPIO.TabIndex = 34
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromName("@scrollBar")
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.ComboBoxGIRO)
        Me.Panel1.Controls.Add(Me.ComboBoxMUNICIPIO)
        Me.Panel1.Controls.Add(Me.TextBoxID)
        Me.Panel1.Controls.Add(Me.TextBoxNOMBRE)
        Me.Panel1.Controls.Add(Me.TextBoxDIRECCION)
        Me.Panel1.Controls.Add(Me.TextBoxQUEJAS)
        Me.Panel1.HeaderForeColor = System.Drawing.Color.FromName("@control")
        Me.Panel1.Location = New System.Drawing.Point(0, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(685, 562)
        Me.Panel1.TabIndex = 35
        '
        'Reportar_Queja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 683)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBoxQUEJA)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Reportar_Queja"
        Me.Text = "Reportar_Queja"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonBar1 As Wisej.Web.Ext.RibbonBar.RibbonBar
    Friend WithEvents RibbonBarPage1 As Wisej.Web.Ext.RibbonBar.RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As Wisej.Web.Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents RRBNUEVO As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RRBCANCELAR As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RRBENVIAR As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxDIRECCION As Wisej.Web.TextBox
    Friend WithEvents TextBoxNOMBRE As Wisej.Web.TextBox
    Friend WithEvents TextBoxQUEJA As Wisej.Web.TextBox
    Friend WithEvents TextBoxQUEJAS As Wisej.Web.TextBox
    Friend WithEvents Label1 As Wisej.Web.Label
    Friend WithEvents Label8 As Wisej.Web.Label
    Friend WithEvents Label9 As Wisej.Web.Label
    Friend WithEvents Label10 As Wisej.Web.Label
    Friend WithEvents Label12 As Wisej.Web.Label
    Friend WithEvents ComboBoxGIRO As Wisej.Web.ComboBox
    Friend WithEvents Label13 As Wisej.Web.Label
    Friend WithEvents TextBoxID As Wisej.Web.TextBox
    Friend WithEvents ComboBoxMUNICIPIO As Wisej.Web.ComboBox
    Friend WithEvents Panel1 As Wisej.Web.Panel
End Class