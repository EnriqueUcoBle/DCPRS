<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Verificacion_Entega_Acta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Verificacion_Entega_Acta))
        Me.Combosax_B1 = New DPCRS.Combosax_B()
        Me.Combosax1 = New DPCRS.combosax()
        Me.SuspendLayout()
        '
        'Combosax_B1
        '
        Me.Combosax_B1.amarillo = False
        Me.Combosax_B1.Ancho = Nothing
        Me.Combosax_B1.BackColor = System.Drawing.Color.FromName("@window")
        Me.Combosax_B1.ColorAtras = System.Drawing.Color.Empty
        Me.Combosax_B1.Count = 0
        Me.Combosax_B1.DataSourceSelect = Nothing
        Me.Combosax_B1.gris = False
        Me.Combosax_B1.Letra = Nothing
        Me.Combosax_B1.Limitar = False
        Me.Combosax_B1.Location = New System.Drawing.Point(165, 52)
        Me.Combosax_B1.MensajeAgua = Nothing
        Me.Combosax_B1.mostrarMensaje = False
        Me.Combosax_B1.Name = "Combosax_B1"
        Me.Combosax_B1.Negritas = False
        Me.Combosax_B1.OBTENERLISTLLENADO = Nothing
        Me.Combosax_B1.procedure = Nothing
        Me.Combosax_B1.SelectedIndex = -1
        Me.Combosax_B1.SelectedItem = ""
        Me.Combosax_B1.SelectedValue = Nothing
        Me.Combosax_B1.Size = New System.Drawing.Size(277, 22)
        Me.Combosax_B1.TabIndex = 0
        Me.Combosax_B1.TODOSS = False
        Me.Combosax_B1.Watermark = Nothing
        '
        'Combosax1
        '
        Me.Combosax1.amarillo = False
        Me.Combosax1.Ancho = "312"
        Me.Combosax1.BackColor = System.Drawing.Color.Transparent
        Me.Combosax1.ColorAtras = System.Drawing.Color.Empty
        Me.Combosax1.Count = 0
        Me.Combosax1.Cursor = Wisej.Web.Cursors.Hand
        Me.Combosax1.DataSource = Nothing
        Me.Combosax1.gris = False
        Me.Combosax1.Letra = Nothing
        Me.Combosax1.Limitar = False
        Me.Combosax1.Location = New System.Drawing.Point(165, 107)
        Me.Combosax1.MensajeAgua = "Ingrese Texto (Enter)..."
        Me.Combosax1.Name = "Combosax1"
        Me.Combosax1.Negritas = False
        Me.Combosax1.procedure = Nothing
        Me.Combosax1.SelectedIndex = -1
        Me.Combosax1.SelectedItem = ""
        Me.Combosax1.SelectedValue = Nothing
        Me.Combosax1.Size = New System.Drawing.Size(300, 21)
        Me.Combosax1.TabIndex = 1
        Me.Combosax1.TODOSS = False
        '
        'Verificacion_Entega_Acta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 480)
        Me.Controls.Add(Me.Combosax1)
        Me.Controls.Add(Me.Combosax_B1)
        Me.Name = "Verificacion_Entega_Acta"
        Me.Text = "Window1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Combosax_B1 As Combosax_B
    Friend WithEvents Combosax1 As combosax
End Class
