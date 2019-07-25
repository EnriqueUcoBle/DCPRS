<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historial_Sessiones
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
        Me.Panel1 = New Wisej.Web.Panel()
        Me.DataGridView1 = New Wisej.Web.DataGridView()
        Me.colFECHA_INICIO_SESSION = New Wisej.Web.DataGridViewDateTimePickerColumn()
        Me.colHORA = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colDIA = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colMES = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colAÑO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colHORA_ = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colMINUTOS = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colSEGUNDOS = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataSetSESSIONESBBindingSource = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_SESSIONES_B = New DPCRS.DataSet_SESSIONES_B()
        Me.colDIA_MES = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSESSIONESBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_SESSIONES_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(891, 628)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.colFECHA_INICIO_SESSION, Me.colDIA, Me.colDIA_MES, Me.colMES, Me.colAÑO, Me.colHORA_, Me.colMINUTOS, Me.colSEGUNDOS, Me.colHORA})
        Me.DataGridView1.DataMember = "pCAT_SESSIONES_B_ALL"
        Me.DataGridView1.DataSource = Me.DataSetSESSIONESBBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 107)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(885, 411)
        Me.DataGridView1.TabIndex = 0
        '
        'colFECHA_INICIO_SESSION
        '
        Me.colFECHA_INICIO_SESSION.DataPropertyName = "FECHA_INICIO_SESSION"
        Me.colFECHA_INICIO_SESSION.HeaderText = "FECHA_INICIO_SESSION"
        Me.colFECHA_INICIO_SESSION.Name = "colFECHA_INICIO_SESSION"
        Me.colFECHA_INICIO_SESSION.Visible = False
        '
        'colHORA
        '
        Me.colHORA.DataPropertyName = "HORA"
        Me.colHORA.HeaderText = "Hora Completa"
        Me.colHORA.Name = "colHORA"
        Me.colHORA.ReadOnly = True
        '
        'colDIA
        '
        Me.colDIA.DataPropertyName = "DIA"
        Me.colDIA.HeaderText = "Dia Semana"
        Me.colDIA.Name = "colDIA"
        Me.colDIA.ReadOnly = True
        '
        'colMES
        '
        Me.colMES.DataPropertyName = "MES"
        Me.colMES.HeaderText = "Mes"
        Me.colMES.Name = "colMES"
        Me.colMES.ReadOnly = True
        '
        'colAÑO
        '
        Me.colAÑO.DataPropertyName = "AÑO"
        Me.colAÑO.HeaderText = "Año"
        Me.colAÑO.Name = "colAÑO"
        Me.colAÑO.ReadOnly = True
        '
        'colHORA_
        '
        Me.colHORA_.DataPropertyName = "HORA_"
        Me.colHORA_.HeaderText = "Hora"
        Me.colHORA_.Name = "colHORA_"
        Me.colHORA_.ReadOnly = True
        '
        'colMINUTOS
        '
        Me.colMINUTOS.DataPropertyName = "MINUTOS"
        Me.colMINUTOS.HeaderText = "Minuto"
        Me.colMINUTOS.Name = "colMINUTOS"
        Me.colMINUTOS.ReadOnly = True
        '
        'colSEGUNDOS
        '
        Me.colSEGUNDOS.DataPropertyName = "SEGUNDOS"
        Me.colSEGUNDOS.HeaderText = "Segundo"
        Me.colSEGUNDOS.Name = "colSEGUNDOS"
        Me.colSEGUNDOS.ReadOnly = True
        '
        'DataSetSESSIONESBBindingSource
        '
        Me.DataSetSESSIONESBBindingSource.DataSource = Me.DataSet_SESSIONES_B
        Me.DataSetSESSIONESBBindingSource.Position = 0
        '
        'DataSet_SESSIONES_B
        '
        Me.DataSet_SESSIONES_B.DataSetName = "DataSet_SESSIONES_B"
        Me.DataSet_SESSIONES_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colDIA_MES
        '
        Me.colDIA_MES.DataPropertyName = "DIA_MES"
        Me.colDIA_MES.HeaderText = "Dia Mes"
        Me.colDIA_MES.Name = "colDIA_MES"
        Me.colDIA_MES.ReadOnly = True
        '
        'Historial_Sessiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 628)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "Historial_Sessiones"
        Me.Text = "Historial de Sessiones"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSESSIONESBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_SESSIONES_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Wisej.Web.Panel
    Friend WithEvents DataGridView1 As Wisej.Web.DataGridView
    Friend WithEvents colFECHA_INICIO_SESSION As Wisej.Web.DataGridViewDateTimePickerColumn
    Friend WithEvents colHORA As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colDIA As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colMES As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colAÑO As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colHORA_ As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colMINUTOS As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colSEGUNDOS As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents DataSetSESSIONESBBindingSource As Wisej.Web.BindingSource
    Friend WithEvents DataSet_SESSIONES_B As DataSet_SESSIONES_B
    Friend WithEvents colDIA_MES As Wisej.Web.DataGridViewTextBoxColumn
End Class
