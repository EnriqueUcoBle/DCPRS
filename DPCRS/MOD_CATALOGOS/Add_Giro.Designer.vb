<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Giro
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New Wisej.Web.Label()
        Me.NOMBRE = New Wisej.Web.TextBox()
        Me.HABILITADO = New Wisej.Web.CheckBox()
        Me.Button1 = New Wisej.Web.Button()
        Me.Button2 = New Wisej.Web.Button()
        Me.ErrorProvider1 = New Wisej.Web.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre  descriptivo"
        '
        'NOMBRE
        '
        Me.NOMBRE.Location = New System.Drawing.Point(46, 66)
        Me.NOMBRE.Multiline = True
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.Size = New System.Drawing.Size(326, 39)
        Me.NOMBRE.TabIndex = 1
        '
        'HABILITADO
        '
        Me.HABILITADO.Location = New System.Drawing.Point(113, 111)
        Me.HABILITADO.Name = "HABILITADO"
        Me.HABILITADO.Size = New System.Drawing.Size(201, 23)
        Me.HABILITADO.TabIndex = 2
        Me.HABILITADO.Text = "Habilitar despues de registrar"
        '
        'Button1
        '
        Me.Button1.ImageSource = "Resources\Images\Menu\64\002-diskette .png"
        Me.Button1.Location = New System.Drawing.Point(46, 149)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 27)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Guardar"
        '
        'Button2
        '
        Me.Button2.ImageSource = "Resources\Icons\Menu\add.png"
        Me.Button2.Location = New System.Drawing.Point(272, 149)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 27)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Nuevo"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Add_Giro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 206)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.HABILITADO)
        Me.Controls.Add(Me.NOMBRE)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(399, 245)
        Me.MinimumSize = New System.Drawing.Size(399, 245)
        Me.Name = "Add_Giro"
        Me.Text = "Agregar Giro"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

    End Sub

    Friend WithEvents Label1 As Wisej.Web.Label
    Friend WithEvents NOMBRE As Wisej.Web.TextBox
    Friend WithEvents HABILITADO As Wisej.Web.CheckBox
    Friend WithEvents Button1 As Wisej.Web.Button
    Friend WithEvents Button2 As Wisej.Web.Button
    Friend WithEvents ErrorProvider1 As Wisej.Web.ErrorProvider
End Class
