<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Combosax_B
    Inherits Wisej.Web.UserControl

    'User overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Combosax_B))
        Me.list_llenado = New Wisej.Web.ListBox()
        Me.listfiltrado = New Wisej.Web.ListBox()
        Me.ToolTip1 = New Wisej.Web.ToolTip(Me.components)
        Me.TableLayoutPanel1 = New Wisej.Web.TableLayoutPanel()
        Me.BtnActivador = New Wisej.Web.PictureBox()
        Me.PictureBox1 = New Wisej.Web.PictureBox()
        Me.Txtbuscador = New Wisej.Web.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BtnActivador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'list_llenado
        '
        Me.list_llenado.Location = New System.Drawing.Point(3, 53)
        Me.list_llenado.Name = "list_llenado"
        Me.list_llenado.Size = New System.Drawing.Size(441, 96)
        Me.list_llenado.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.list_llenado, Nothing)
        '
        'listfiltrado
        '
        Me.listfiltrado.Location = New System.Drawing.Point(56, 172)
        Me.listfiltrado.Name = "listfiltrado"
        Me.listfiltrado.Size = New System.Drawing.Size(379, 96)
        Me.listfiltrado.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.listfiltrado, Nothing)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnActivador, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Txtbuscador, 0, 0)
        Me.TableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(277, 22)
        Me.TableLayoutPanel1.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.TableLayoutPanel1, Nothing)
        '
        'BtnActivador
        '
        Me.BtnActivador.BackgroundImage = CType(resources.GetObject("BtnActivador.BackgroundImage"), System.Drawing.Image)
        Me.BtnActivador.Dock = Wisej.Web.DockStyle.Right
        Me.BtnActivador.Location = New System.Drawing.Point(251, 3)
        Me.BtnActivador.Name = "BtnActivador"
        Me.BtnActivador.Size = New System.Drawing.Size(21, 14)
        Me.BtnActivador.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.BtnActivador, Nothing)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Dock = Wisej.Web.DockStyle.Right
        Me.PictureBox1.Location = New System.Drawing.Point(223, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 14)
        Me.PictureBox1.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.PictureBox1, Nothing)
        '
        'Txtbuscador
        '
        Me.Txtbuscador.BorderStyle = Wisej.Web.BorderStyle.None
        Me.Txtbuscador.CharacterCasing = Wisej.Web.CharacterCasing.Lower
        Me.Txtbuscador.Dock = Wisej.Web.DockStyle.Fill
        Me.Txtbuscador.Location = New System.Drawing.Point(3, 3)
        Me.Txtbuscador.Name = "Txtbuscador"
        Me.Txtbuscador.Size = New System.Drawing.Size(214, 14)
        Me.Txtbuscador.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.Txtbuscador, Nothing)
        Me.Txtbuscador.WordWrap = False
        '
        'Combosax_B
        '
        Me.BackColor = System.Drawing.Color.FromName("@window")
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.listfiltrado)
        Me.Controls.Add(Me.list_llenado)
        Me.Name = "Combosax_B"
        Me.Size = New System.Drawing.Size(277, 22)
        Me.ToolTip1.SetToolTip(Me, Nothing)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.BtnActivador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents list_llenado As Wisej.Web.ListBox
    Friend WithEvents listfiltrado As Wisej.Web.ListBox
    Friend WithEvents ToolTip1 As Wisej.Web.ToolTip
    Friend WithEvents TableLayoutPanel1 As Wisej.Web.TableLayoutPanel
    Friend WithEvents BtnActivador As Wisej.Web.PictureBox
    Friend WithEvents PictureBox1 As Wisej.Web.PictureBox
    Friend WithEvents Txtbuscador As Wisej.Web.TextBox
End Class
