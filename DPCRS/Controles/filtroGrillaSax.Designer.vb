Imports Wisej.Web

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class filtroGrillaSax
    Inherits Wisej.Web.UserControl

    'UserControl1 overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Visual WebGui Designer
    Private Shadows components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Visual WebGui Designer
    'It can be modified using the Visual WebGui Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblBuscar = New Wisej.Web.Label()
        Me.cmbBuscar = New Wisej.Web.ComboBox()
        Me.txtFiltros = New Wisej.Web.TextBox()
        Me.btnBuscar = New Wisej.Web.Button()
        Me.btnLimpiar = New Wisej.Web.Button()
        Me.panelEtiquetas = New Wisej.Web.FlowLayoutPanel()
        Me.panelFiltros = New Wisej.Web.Panel()
        Me.dtpFecha = New Wisej.Web.DateTimePicker()
        Me.cmbExpresion = New Wisej.Web.ComboBox()
        Me.panelFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBuscar
        '
        Me.lblBuscar.Anchor = Wisej.Web.AnchorStyles.Left
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblBuscar.Location = New System.Drawing.Point(8, 11)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(39, 15)
        Me.lblBuscar.TabIndex = 1
        Me.lblBuscar.Text = "Filtrar"
        Me.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbBuscar
        '
        Me.cmbBuscar.Anchor = Wisej.Web.AnchorStyles.Left
        Me.cmbBuscar.AutoCompleteMode = Wisej.Web.AutoCompleteMode.Append
        Me.cmbBuscar.FormattingEnabled = True
        Me.cmbBuscar.Location = New System.Drawing.Point(49, 9)
        Me.cmbBuscar.Name = "cmbBuscar"
        Me.cmbBuscar.Size = New System.Drawing.Size(216, 22)
        Me.cmbBuscar.TabIndex = 0
        '
        'txtFiltros
        '
        Me.txtFiltros.Anchor = Wisej.Web.AnchorStyles.Left
        Me.txtFiltros.Location = New System.Drawing.Point(321, 9)
        Me.txtFiltros.Margin = New Wisej.Web.Padding(0)
        Me.txtFiltros.Name = "txtFiltros"
        Me.txtFiltros.Size = New System.Drawing.Size(218, 22)
        Me.txtFiltros.TabIndex = 3
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = Wisej.Web.AnchorStyles.Left
        Me.btnBuscar.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.btnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscar.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        Me.btnBuscar.BackgroundImageSource = "Resources/Icons/Menu/search.png"
        Me.btnBuscar.Location = New System.Drawing.Point(544, 6)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(27, 27)
        Me.btnBuscar.TabIndex = 4
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = Wisej.Web.AnchorStyles.Left
        Me.btnLimpiar.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.btnLimpiar.BackColor = System.Drawing.Color.Transparent
        Me.btnLimpiar.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        Me.btnLimpiar.BackgroundImageSource = "Resources/Icons/Menu/clear-filters.png"
        Me.btnLimpiar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLimpiar.Location = New System.Drawing.Point(571, 6)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(27, 27)
        Me.btnLimpiar.TabIndex = 5
        '
        'panelEtiquetas
        '
        Me.panelEtiquetas.AutoSize = True
        Me.panelEtiquetas.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.panelEtiquetas.BackColor = System.Drawing.Color.Transparent
        Me.panelEtiquetas.Dock = Wisej.Web.DockStyle.Fill
        Me.panelEtiquetas.Location = New System.Drawing.Point(0, 36)
        Me.panelEtiquetas.Name = "panelEtiquetas"
        Me.panelEtiquetas.Padding = New Wisej.Web.Padding(2)
        Me.panelEtiquetas.Size = New System.Drawing.Size(965, 20)
        Me.panelEtiquetas.TabIndex = 0
        '
        'panelFiltros
        '
        Me.panelFiltros.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.panelFiltros.BackColor = System.Drawing.Color.White
        Me.panelFiltros.Controls.Add(Me.dtpFecha)
        Me.panelFiltros.Controls.Add(Me.cmbExpresion)
        Me.panelFiltros.Controls.Add(Me.lblBuscar)
        Me.panelFiltros.Controls.Add(Me.cmbBuscar)
        Me.panelFiltros.Controls.Add(Me.btnLimpiar)
        Me.panelFiltros.Controls.Add(Me.btnBuscar)
        Me.panelFiltros.Controls.Add(Me.txtFiltros)
        Me.panelFiltros.Dock = Wisej.Web.DockStyle.Top
        Me.panelFiltros.Location = New System.Drawing.Point(0, 0)
        Me.panelFiltros.Name = "panelFiltros"
        Me.panelFiltros.Size = New System.Drawing.Size(965, 36)
        Me.panelFiltros.TabIndex = 1
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = Wisej.Web.AnchorStyles.Left
        Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecha.Format = Wisej.Web.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(321, 9)
        Me.dtpFecha.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.dtpFecha.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(108, 22)
        Me.dtpFecha.TabIndex = 2
        Me.dtpFecha.Value = New Date(2018, 3, 23, 12, 48, 18, 509)
        Me.dtpFecha.Visible = False
        '
        'cmbExpresion
        '
        Me.cmbExpresion.Anchor = Wisej.Web.AnchorStyles.Left
        Me.cmbExpresion.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList
        Me.cmbExpresion.FormattingEnabled = True
        Me.cmbExpresion.Location = New System.Drawing.Point(271, 9)
        Me.cmbExpresion.Name = "cmbExpresion"
        Me.cmbExpresion.Size = New System.Drawing.Size(44, 22)
        Me.cmbExpresion.TabIndex = 1
        '
        'filtroGrillaSax
        '
        Me.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.panelEtiquetas)
        Me.Controls.Add(Me.panelFiltros)
        Me.Name = "filtroGrillaSax"
        Me.Size = New System.Drawing.Size(965, 56)
        Me.panelFiltros.ResumeLayout(False)
        Me.panelFiltros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents panelEtiquetas As FlowLayoutPanel
    Private WithEvents panelFiltros As Panel
    Private WithEvents lblBuscar As Label
    Private WithEvents cmbBuscar As ComboBox
    Private WithEvents txtFiltros As TextBox
    Private WithEvents btnBuscar As Button
    Private WithEvents btnLimpiar As Button
    Friend WithEvents cmbExpresion As ComboBox
    Friend WithEvents dtpFecha As DateTimePicker
End Class

