﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Prueba
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
        Me.OpenFileDialog1 = New Wisej.Web.OpenFileDialog(Me.components)
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.Importar = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.XD = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.TextBox1 = New Wisej.Web.TextBox()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Dock = Wisej.Web.DockStyle.Top
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(1020, 145)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Text = "Menu"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.Importar)
        Me.RibbonBarGroup1.Items.Add(Me.XD)
        Me.RibbonBarGroup1.Text = "Pruevas"
        '
        'Importar
        '
        Me.Importar.ImageSource = "Resources\Images\Menu\64\015-pipette .png"
        Me.Importar.Name = "Importar"
        Me.Importar.Text = "Importar"
        '
        'XD
        '
        Me.XD.ImageSource = "Resources\Images\Menu\64\001-security .png"
        Me.XD.Name = "XD"
        Me.XD.Text = "XD"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(42, 151)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(600, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Prueba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 480)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Prueba"
        Me.Text = "|"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As Wisej.Web.OpenFileDialog
    Friend WithEvents RibbonBar1 As Wisej.Web.Ext.RibbonBar.RibbonBar
    Friend WithEvents RibbonBarPage1 As Wisej.Web.Ext.RibbonBar.RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As Wisej.Web.Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents Importar As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents XD As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents TextBox1 As Wisej.Web.TextBox
End Class
