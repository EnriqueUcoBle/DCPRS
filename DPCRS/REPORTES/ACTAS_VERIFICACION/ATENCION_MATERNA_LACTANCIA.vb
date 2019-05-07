Public Class ATENCION_MATERNA_LACTANCIA
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrRichText1 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText2 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrRichText3 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents DataSet_pCAT_ACTAS_VERIFICACION_B1 As DataSet_pCAT_ACTAS_VERIFICACION_B

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ATENCION_MATERNA_LACTANCIA))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
        Me.XrRichText2 = New DevExpress.XtraReports.UI.XRRichText()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrRichText3 = New DevExpress.XtraReports.UI.XRRichText()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.DataSet_pCAT_ACTAS_VERIFICACION_B1 = New DPCRS.DataSet_pCAT_ACTAS_VERIFICACION_B()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCAT_ACTAS_VERIFICACION_B1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrRichText1, Me.XrPageBreak1, Me.XrRichText2})
        Me.Detail.HeightF = 3696.125!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrRichText1
        '
        Me.XrRichText1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 0!)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.SizeF = New System.Drawing.SizeF(778.9999!, 70.83334!)
        '
        'XrPageBreak1
        '
        Me.XrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPageBreak1.Name = "XrPageBreak1"
        '
        'XrRichText2
        '
        Me.XrRichText2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText2.LocationFloat = New DevExpress.Utils.PointFloat(9.000111!, 70.83334!)
        Me.XrRichText2.Name = "XrRichText2"
        Me.XrRichText2.SerializableRtfString = resources.GetString("XrRichText2.SerializableRtfString")
        Me.XrRichText2.SizeF = New System.Drawing.SizeF(790.0001!, 3619.458!)
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
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.XrRichText3})
        Me.BottomMargin.HeightF = 64.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(699.0001!, 29.8748!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        '
        'XrRichText3
        '
        Me.XrRichText3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrRichText3.Name = "XrRichText3"
        Me.XrRichText3.SerializableRtfString = resources.GetString("XrRichText3.SerializableRtfString")
        Me.XrRichText3.SizeF = New System.Drawing.SizeF(620.8333!, 23.0!)
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreport1})
        Me.PageHeader.HeightF = 100.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrSubreport1
        '
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(146.8751!, 38.54167!)
        '
        'DataSet_pCAT_ACTAS_VERIFICACION_B1
        '
        Me.DataSet_pCAT_ACTAS_VERIFICACION_B1.DataSetName = "DataSet_pCAT_ACTAS_VERIFICACION_B"
        Me.DataSet_pCAT_ACTAS_VERIFICACION_B1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ATENCION_MATERNA_LACTANCIA
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.DataSet_pCAT_ACTAS_VERIFICACION_B1})
        Me.DataMember = "pCAT_ACTAS_VERIFICACION_B"
        Me.DataSource = Me.DataSet_pCAT_ACTAS_VERIFICACION_B1
        Me.Margins = New System.Drawing.Printing.Margins(22, 28, 0, 64)
        Me.Version = "17.2"
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCAT_ACTAS_VERIFICACION_B1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Private Sub ATENCION_MATERNA_LACTANCIA_DataSourceDemanded(sender As Object, e As EventArgs) Handles Me.DataSourceDemanded
        Dim header As New header_verificacion
        XrSubreport1.ReportSource = header
    End Sub

    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region
    Dim HEADER As header_verificacion

End Class