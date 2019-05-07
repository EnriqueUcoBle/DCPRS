<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Sub_Acta_General
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sub_Acta_General))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.DataSet_pACTAS_VERIFICACION_LOTES_B1 = New DPCRS.DataSet_pACTAS_VERIFICACION_LOTES_B()
        Me.PACTAS_VERIFICACION_LOTES_BTableAdapter = New DPCRS.DataSet_pACTAS_VERIFICACION_LOTES_BTableAdapters.pACTAS_VERIFICACION_LOTES_BTableAdapter()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pACTAS_VERIFICACION_LOTES_B1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrRichText1, Me.XrLabel1})
        Me.Detail.HeightF = 417.7083!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrRichText1
        '
        Me.XrRichText1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 38.54167!)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.SizeF = New System.Drawing.SizeF(650.0!, 54.25002!)
        '
        'XrLabel1
        '
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(171.3542!, 0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(313.5417!, 23.0!)
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "OBSERVACIONES GENERALES"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DataSet_pACTAS_VERIFICACION_LOTES_B1
        '
        Me.DataSet_pACTAS_VERIFICACION_LOTES_B1.DataSetName = "DataSet_pACTAS_VERIFICACION_LOTES_B"
        Me.DataSet_pACTAS_VERIFICACION_LOTES_B1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PACTAS_VERIFICACION_LOTES_BTableAdapter
        '
        Me.PACTAS_VERIFICACION_LOTES_BTableAdapter.ClearBeforeFill = True
        '
        'Sub_Acta_General
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.DataSet_pACTAS_VERIFICACION_LOTES_B1})
        Me.DataAdapter = Me.PACTAS_VERIFICACION_LOTES_BTableAdapter
        Me.DataMember = "pACTAS_VERIFICACION_LOTES_B"
        Me.DataSource = Me.DataSet_pACTAS_VERIFICACION_LOTES_B1
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 0, 0)
        Me.PageHeight = 1400
        Me.PaperKind = System.Drawing.Printing.PaperKind.Legal
        Me.Version = "17.2"
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pACTAS_VERIFICACION_LOTES_B1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrRichText1 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DataSet_pACTAS_VERIFICACION_LOTES_B1 As DataSet_pACTAS_VERIFICACION_LOTES_B
    Friend WithEvents PACTAS_VERIFICACION_LOTES_BTableAdapter As DataSet_pACTAS_VERIFICACION_LOTES_BTableAdapters.pACTAS_VERIFICACION_LOTES_BTableAdapter
End Class
