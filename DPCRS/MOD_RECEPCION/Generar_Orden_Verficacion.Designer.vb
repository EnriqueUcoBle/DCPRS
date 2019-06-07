<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Generar_Orden_Verficacion
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
        Me.RRBnuevo = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RRBgg = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBcancelar = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RRBsalir = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.ContextMenu1 = New Wisej.Web.ContextMenu()
        Me.Label7 = New Wisej.Web.Label()
        Me.tab4 = New Wisej.Web.TabPage()
        Me.tab3 = New Wisej.Web.TabPage()
        Me.Siguiente1 = New Wisej.Web.Button()
        Me.tab2 = New Wisej.Web.TabPage()
        Me.tab1 = New Wisej.Web.TabPage()
        Me.paso1 = New Wisej.Web.Button()
        Me.Panel1 = New Wisej.Web.Panel()
        Me.ComboBoxIDENTICACION = New Wisej.Web.ComboBox()
        Me.TextBoxNOMBRE = New Wisej.Web.TextBox()
        Me.TextBoxDOMICILIO = New Wisej.Web.TextBox()
        Me.Label8 = New Wisej.Web.Label()
        Me.Label9 = New Wisej.Web.Label()
        Me.Label11 = New Wisej.Web.Label()
        Me.Label12 = New Wisej.Web.Label()
        Me.TextBoxCARGO = New Wisej.Web.TextBox()
        Me.Datos_generales = New Wisej.Web.Panel()
        Me.TextBoxPROGRAMA = New Wisej.Web.TextBox()
        Me.Label6 = New Wisej.Web.Label()
        Me.TextBoxCORREO = New Wisej.Web.TextBox()
        Me.Label5 = New Wisej.Web.Label()
        Me.TextBoxTELEFONO = New Wisej.Web.TextBox()
        Me.Label4 = New Wisej.Web.Label()
        Me.TextBoxCODIGO = New Wisej.Web.TextBox()
        Me.Label3 = New Wisej.Web.Label()
        Me.Label2 = New Wisej.Web.Label()
        Me.ComboBoxGIRO = New Wisej.Web.ComboBox()
        Me.Label1 = New Wisej.Web.Label()
        Me.TextBoxRFC = New Wisej.Web.TextBox()
        Me.TabControl1 = New Wisej.Web.TabControl()
        Me.tab3.SuspendLayout()
        Me.tab1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Datos_generales.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Dock = Wisej.Web.DockStyle.Top
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(886, 112)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Text = "Acciones"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.RRBnuevo)
        Me.RibbonBarGroup1.Items.Add(Me.RRBgg)
        Me.RibbonBarGroup1.Items.Add(Me.RBBcancelar)
        Me.RibbonBarGroup1.Items.Add(Me.RRBsalir)
        Me.RibbonBarGroup1.Text = "Acta"
        '
        'RRBnuevo
        '
        Me.RRBnuevo.ImageSource = "ribbon-add-file"
        Me.RRBnuevo.Name = "RRBnuevo"
        Me.RRBnuevo.Text = "Nuevo"
        '
        'RRBgg
        '
        Me.RRBgg.ImageSource = "ribbon-save"
        Me.RRBgg.Name = "RRBgg"
        Me.RRBgg.Text = "Guargar y Generar Orden"
        '
        'RBBcancelar
        '
        Me.RBBcancelar.ImageSource = "ribbon-delete"
        Me.RBBcancelar.Name = "RBBcancelar"
        Me.RBBcancelar.Text = "Cancelar"
        '
        'RRBsalir
        '
        Me.RRBsalir.ImageSource = "Resources\Images\Menu\30\exit-sign-red.png"
        Me.RRBsalir.Name = "RRBsalir"
        Me.RRBsalir.Text = "Salir"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.Name = "ContextMenu1"
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Crimson
        Me.Label7.Location = New System.Drawing.Point(377, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(368, 53)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "complete los formularios para generar la orden de verficacion, si hacen falta dat" &
    "os no se podra completar generacion de la orden"
        '
        'tab4
        '
        Me.tab4.ImageSource = "Resources\Images\Menu\18\016-pipette.png"
        Me.tab4.Location = New System.Drawing.Point(1, 35)
        Me.tab4.Name = "tab4"
        Me.tab4.Text = "Observaciones y Muestras"
        '
        'tab3
        '
        Me.tab3.Controls.Add(Me.Siguiente1)
        Me.tab3.ImageSource = "Resources\Images\Menu\18\calendar-23.png"
        Me.tab3.Location = New System.Drawing.Point(1, 35)
        Me.tab3.Name = "tab3"
        Me.tab3.Text = "Fecha y Testigos"
        '
        'Siguiente1
        '
        Me.Siguiente1.Location = New System.Drawing.Point(350, 601)
        Me.Siguiente1.Name = "Siguiente1"
        Me.Siguiente1.Size = New System.Drawing.Size(100, 27)
        Me.Siguiente1.TabIndex = 0
        Me.Siguiente1.Text = "Siguiente"
        '
        'tab2
        '
        Me.tab2.ImageSource = "Resources\Images\Menu\18\user-49.png"
        Me.tab2.Location = New System.Drawing.Point(1, 35)
        Me.tab2.Name = "tab2"
        Me.tab2.Text = "Operador(es) y Verificadores"
        '
        'tab1
        '
        Me.tab1.Controls.Add(Me.paso1)
        Me.tab1.Controls.Add(Me.Panel1)
        Me.tab1.Controls.Add(Me.Datos_generales)
        Me.tab1.ImageSource = "Resources\Images\Menu\18\grocery-1.png"
        Me.tab1.Location = New System.Drawing.Point(1, 35)
        Me.tab1.Name = "tab1"
        Me.tab1.Text = "Establecimiento & Propietario"
        '
        'paso1
        '
        Me.paso1.AutoSize = True
        Me.paso1.Location = New System.Drawing.Point(370, 450)
        Me.paso1.Name = "paso1"
        Me.paso1.Size = New System.Drawing.Size(100, 27)
        Me.paso1.TabIndex = 19
        Me.paso1.Text = "siguiente"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBoxIDENTICACION)
        Me.Panel1.Controls.Add(Me.TextBoxNOMBRE)
        Me.Panel1.Controls.Add(Me.TextBoxDOMICILIO)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.TextBoxCARGO)
        Me.Panel1.Location = New System.Drawing.Point(2, 160)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(877, 241)
        Me.Panel1.TabIndex = 5
        Me.Panel1.Text = "Datos generales"
        '
        'ComboBoxIDENTICACION
        '
        Me.ComboBoxIDENTICACION.Items.AddRange(New Object() {"CREDENCIAL(INE O IFE)", "PASAPORTE", "LICENCIA DE CONDUCIR", "CARTILLA MILITAR"})
        Me.ComboBoxIDENTICACION.Location = New System.Drawing.Point(32, 98)
        Me.ComboBoxIDENTICACION.Name = "ComboBoxIDENTICACION"
        Me.ComboBoxIDENTICACION.Size = New System.Drawing.Size(244, 22)
        Me.ComboBoxIDENTICACION.TabIndex = 18
        '
        'TextBoxNOMBRE
        '
        Me.TextBoxNOMBRE.Location = New System.Drawing.Point(32, 48)
        Me.TextBoxNOMBRE.Name = "TextBoxNOMBRE"
        Me.TextBoxNOMBRE.Size = New System.Drawing.Size(244, 22)
        Me.TextBoxNOMBRE.TabIndex = 17
        '
        'TextBoxDOMICILIO
        '
        Me.TextBoxDOMICILIO.Location = New System.Drawing.Point(581, 49)
        Me.TextBoxDOMICILIO.Name = "TextBoxDOMICILIO"
        Me.TextBoxDOMICILIO.Size = New System.Drawing.Size(244, 22)
        Me.TextBoxDOMICILIO.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(581, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "DOMICILIO:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(173, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "TIPO DE IDENTIFCACION:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(296, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(172, 16)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "CARGO QUE DESMPEÑA:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(31, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(166, 16)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "NOMBRE PROPIETARIO."
        '
        'TextBoxCARGO
        '
        Me.TextBoxCARGO.Location = New System.Drawing.Point(296, 49)
        Me.TextBoxCARGO.Name = "TextBoxCARGO"
        Me.TextBoxCARGO.Size = New System.Drawing.Size(244, 22)
        Me.TextBoxCARGO.TabIndex = 5
        '
        'Datos_generales
        '
        Me.Datos_generales.Controls.Add(Me.TextBoxPROGRAMA)
        Me.Datos_generales.Controls.Add(Me.Label6)
        Me.Datos_generales.Controls.Add(Me.TextBoxCORREO)
        Me.Datos_generales.Controls.Add(Me.Label5)
        Me.Datos_generales.Controls.Add(Me.TextBoxTELEFONO)
        Me.Datos_generales.Controls.Add(Me.Label4)
        Me.Datos_generales.Controls.Add(Me.TextBoxCODIGO)
        Me.Datos_generales.Controls.Add(Me.Label3)
        Me.Datos_generales.Controls.Add(Me.Label2)
        Me.Datos_generales.Controls.Add(Me.ComboBoxGIRO)
        Me.Datos_generales.Controls.Add(Me.Label1)
        Me.Datos_generales.Controls.Add(Me.TextBoxRFC)
        Me.Datos_generales.Location = New System.Drawing.Point(3, 3)
        Me.Datos_generales.Name = "Datos_generales"
        Me.Datos_generales.Size = New System.Drawing.Size(877, 151)
        Me.Datos_generales.TabIndex = 4
        Me.Datos_generales.Text = "Datos generales"
        '
        'TextBoxPROGRAMA
        '
        Me.TextBoxPROGRAMA.Location = New System.Drawing.Point(580, 98)
        Me.TextBoxPROGRAMA.Name = "TextBoxPROGRAMA"
        Me.TextBoxPROGRAMA.Size = New System.Drawing.Size(244, 22)
        Me.TextBoxPROGRAMA.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(580, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "PROGRAMA:"
        '
        'TextBoxCORREO
        '
        Me.TextBoxCORREO.Location = New System.Drawing.Point(296, 98)
        Me.TextBoxCORREO.Name = "TextBoxCORREO"
        Me.TextBoxCORREO.Size = New System.Drawing.Size(244, 22)
        Me.TextBoxCORREO.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(296, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "CORREO:"
        '
        'TextBoxTELEFONO
        '
        Me.TextBoxTELEFONO.Location = New System.Drawing.Point(31, 98)
        Me.TextBoxTELEFONO.Name = "TextBoxTELEFONO"
        Me.TextBoxTELEFONO.Size = New System.Drawing.Size(244, 22)
        Me.TextBoxTELEFONO.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "TELEFONO:"
        '
        'TextBoxCODIGO
        '
        Me.TextBoxCODIGO.Location = New System.Drawing.Point(580, 48)
        Me.TextBoxCODIGO.Name = "TextBoxCODIGO"
        Me.TextBoxCODIGO.Size = New System.Drawing.Size(244, 22)
        Me.TextBoxCODIGO.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(580, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "CODIGO POSTAL:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(296, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "RFC:"
        '
        'ComboBoxGIRO
        '
        Me.ComboBoxGIRO.Location = New System.Drawing.Point(31, 48)
        Me.ComboBoxGIRO.Name = "ComboBoxGIRO"
        Me.ComboBoxGIRO.Size = New System.Drawing.Size(244, 22)
        Me.ComboBoxGIRO.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "GIRO:"
        '
        'TextBoxRFC
        '
        Me.TextBoxRFC.Location = New System.Drawing.Point(296, 49)
        Me.TextBoxRFC.Name = "TextBoxRFC"
        Me.TextBoxRFC.Size = New System.Drawing.Size(244, 22)
        Me.TextBoxRFC.TabIndex = 5
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab1)
        Me.TabControl1.Controls.Add(Me.tab3)
        Me.TabControl1.Controls.Add(Me.tab2)
        Me.TabControl1.Controls.Add(Me.tab4)
        Me.TabControl1.Location = New System.Drawing.Point(3, 118)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.PageInsets = New Wisej.Web.Padding(1, 35, 1, 1)
        Me.TabControl1.Size = New System.Drawing.Size(882, 687)
        Me.TabControl1.TabIndex = 2
        '
        'Generar_Orden_Verficacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 636)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Generar_Orden_Verficacion"
        Me.Text = "Generar_Orden_Verficacion"
        Me.tab3.ResumeLayout(False)
        Me.tab1.ResumeLayout(False)
        Me.tab1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Datos_generales.ResumeLayout(False)
        Me.Datos_generales.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonBar1 As Wisej.Web.Ext.RibbonBar.RibbonBar
    Friend WithEvents RibbonBarPage1 As Wisej.Web.Ext.RibbonBar.RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As Wisej.Web.Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents RRBnuevo As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RRBgg As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RBBcancelar As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RRBsalir As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents ContextMenu1 As Wisej.Web.ContextMenu
    Friend WithEvents Label7 As Wisej.Web.Label
    Friend WithEvents tab4 As Wisej.Web.TabPage
    Friend WithEvents tab3 As Wisej.Web.TabPage
    Friend WithEvents Siguiente1 As Wisej.Web.Button
    Friend WithEvents tab2 As Wisej.Web.TabPage
    Friend WithEvents tab1 As Wisej.Web.TabPage
    Friend WithEvents paso1 As Wisej.Web.Button
    Friend WithEvents Panel1 As Wisej.Web.Panel
    Friend WithEvents ComboBoxIDENTICACION As Wisej.Web.ComboBox
    Friend WithEvents TextBoxNOMBRE As Wisej.Web.TextBox
    Friend WithEvents TextBoxDOMICILIO As Wisej.Web.TextBox
    Friend WithEvents Label8 As Wisej.Web.Label
    Friend WithEvents Label9 As Wisej.Web.Label
    Friend WithEvents Label11 As Wisej.Web.Label
    Friend WithEvents Label12 As Wisej.Web.Label
    Friend WithEvents TextBoxCARGO As Wisej.Web.TextBox
    Friend WithEvents Datos_generales As Wisej.Web.Panel
    Friend WithEvents TextBoxPROGRAMA As Wisej.Web.TextBox
    Friend WithEvents Label6 As Wisej.Web.Label
    Friend WithEvents TextBoxCORREO As Wisej.Web.TextBox
    Friend WithEvents Label5 As Wisej.Web.Label
    Friend WithEvents TextBoxTELEFONO As Wisej.Web.TextBox
    Friend WithEvents Label4 As Wisej.Web.Label
    Friend WithEvents TextBoxCODIGO As Wisej.Web.TextBox
    Friend WithEvents Label3 As Wisej.Web.Label
    Friend WithEvents Label2 As Wisej.Web.Label
    Friend WithEvents ComboBoxGIRO As Wisej.Web.ComboBox
    Friend WithEvents Label1 As Wisej.Web.Label
    Friend WithEvents TextBoxRFC As Wisej.Web.TextBox
    Friend WithEvents TabControl1 As Wisej.Web.TabControl
End Class
