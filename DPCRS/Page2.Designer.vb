<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Page2
    Inherits Wisej.Web.Page

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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New Wisej.Web.GroupBox()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(314, 180)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 136)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Page2
        '
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Page2"
        Me.Size = New System.Drawing.Size(1224, 683)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As Wisej.Web.GroupBox
End Class
