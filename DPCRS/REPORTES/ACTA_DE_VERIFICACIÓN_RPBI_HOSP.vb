Public Class ACTA_DE_VERIFICACIÓN_RPBI_HOSP
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

    Friend WithEvents XrRichText1 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrRichText2 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText3 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText5 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText4 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText8 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText6 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText7 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText9 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText10 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText11 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText12 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText13 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText14 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText15 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText17 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText18 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText16 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText19 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText20 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText21 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText22 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText25 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText24 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText23 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText32 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText31 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText30 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText26 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText28 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText27 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText43 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText42 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText41 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText40 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText39 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText38 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText36 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText35 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText34 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText33 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText29 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText44 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText57 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText56 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText55 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText54 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText53 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText52 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText51 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText50 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText49 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText48 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText47 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText37 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText46 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText45 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText58 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText59 As DevExpress.XtraReports.UI.XRRichText

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACTA_DE_VERIFICACIÓN_RPBI_HOSP))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrRichText59 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText58 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText57 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText56 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText55 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText54 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText53 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText52 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText51 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText50 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText49 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText48 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText47 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText37 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText46 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText45 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText44 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText43 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText42 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText41 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText40 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText39 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText38 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText36 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText35 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText34 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText33 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText29 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText32 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText31 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText30 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText26 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText28 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText27 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText25 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText24 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText23 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText6 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText7 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText9 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText10 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText11 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText12 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText13 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText14 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText15 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText17 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText18 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText16 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText19 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText20 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText21 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText22 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText8 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText4 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText5 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText3 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText2 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me.XrRichText59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrRichText59, Me.XrRichText58, Me.XrRichText57, Me.XrRichText56, Me.XrRichText55, Me.XrRichText54, Me.XrRichText53, Me.XrRichText52, Me.XrRichText51, Me.XrRichText50, Me.XrRichText49, Me.XrRichText48, Me.XrRichText47, Me.XrRichText37, Me.XrRichText46, Me.XrRichText45, Me.XrRichText44, Me.XrRichText43, Me.XrRichText42, Me.XrRichText41, Me.XrRichText40, Me.XrRichText39, Me.XrRichText38, Me.XrRichText36, Me.XrRichText35, Me.XrRichText34, Me.XrRichText33, Me.XrRichText29, Me.XrRichText32, Me.XrRichText31, Me.XrRichText30, Me.XrRichText26, Me.XrRichText28, Me.XrRichText27, Me.XrRichText25, Me.XrRichText24, Me.XrRichText23, Me.XrRichText6, Me.XrRichText7, Me.XrRichText9, Me.XrRichText10, Me.XrRichText11, Me.XrRichText12, Me.XrRichText13, Me.XrRichText14, Me.XrRichText15, Me.XrRichText17, Me.XrRichText18, Me.XrRichText16, Me.XrRichText19, Me.XrRichText20, Me.XrRichText21, Me.XrRichText22, Me.XrRichText8, Me.XrRichText4, Me.XrRichText5, Me.XrRichText3, Me.XrRichText2, Me.XrRichText1})
        Me.Detail.HeightF = 16471.96!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrRichText59
        '
        Me.XrRichText59.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText59.LocationFloat = New DevExpress.Utils.PointFloat(0.0006357829!, 16066.13!)
        Me.XrRichText59.Name = "XrRichText59"
        Me.XrRichText59.SerializableRtfString = resources.GetString("XrRichText59.SerializableRtfString")
        Me.XrRichText59.SizeF = New System.Drawing.SizeF(724.0002!, 348.54!)
        '
        'XrRichText58
        '
        Me.XrRichText58.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText58.LocationFloat = New DevExpress.Utils.PointFloat(37.00002!, 15953.13!)
        Me.XrRichText58.Name = "XrRichText58"
        Me.XrRichText58.SerializableRtfString = resources.GetString("XrRichText58.SerializableRtfString")
        Me.XrRichText58.SizeF = New System.Drawing.SizeF(647.9332!, 100.501!)
        '
        'XrRichText57
        '
        Me.XrRichText57.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText57.LocationFloat = New DevExpress.Utils.PointFloat(37.00002!, 15043.83!)
        Me.XrRichText57.Name = "XrRichText57"
        Me.XrRichText57.SerializableRtfString = resources.GetString("XrRichText57.SerializableRtfString")
        Me.XrRichText57.SizeF = New System.Drawing.SizeF(647.9332!, 880.042!)
        '
        'XrRichText56
        '
        Me.XrRichText56.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText56.LocationFloat = New DevExpress.Utils.PointFloat(37.00002!, 14674.04!)
        Me.XrRichText56.Name = "XrRichText56"
        Me.XrRichText56.SerializableRtfString = resources.GetString("XrRichText56.SerializableRtfString")
        Me.XrRichText56.SizeF = New System.Drawing.SizeF(647.9332!, 369.7891!)
        '
        'XrRichText55
        '
        Me.XrRichText55.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText55.LocationFloat = New DevExpress.Utils.PointFloat(0!, 14185.42!)
        Me.XrRichText55.Name = "XrRichText55"
        Me.XrRichText55.SerializableRtfString = resources.GetString("XrRichText55.SerializableRtfString")
        Me.XrRichText55.SizeF = New System.Drawing.SizeF(699.5!, 488.626!)
        '
        'XrRichText54
        '
        Me.XrRichText54.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText54.LocationFloat = New DevExpress.Utils.PointFloat(37.00002!, 13949.04!)
        Me.XrRichText54.Name = "XrRichText54"
        Me.XrRichText54.SerializableRtfString = resources.GetString("XrRichText54.SerializableRtfString")
        Me.XrRichText54.SizeF = New System.Drawing.SizeF(650.0001!, 236.376!)
        '
        'XrRichText53
        '
        Me.XrRichText53.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText53.LocationFloat = New DevExpress.Utils.PointFloat(0!, 13681.25!)
        Me.XrRichText53.Name = "XrRichText53"
        Me.XrRichText53.SerializableRtfString = resources.GetString("XrRichText53.SerializableRtfString")
        Me.XrRichText53.SizeF = New System.Drawing.SizeF(724.0008!, 267.791!)
        '
        'XrRichText52
        '
        Me.XrRichText52.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText52.LocationFloat = New DevExpress.Utils.PointFloat(37.00002!, 13530.29!)
        Me.XrRichText52.Name = "XrRichText52"
        Me.XrRichText52.SerializableRtfString = resources.GetString("XrRichText52.SerializableRtfString")
        Me.XrRichText52.SizeF = New System.Drawing.SizeF(650.0001!, 150.959!)
        '
        'XrRichText51
        '
        Me.XrRichText51.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText51.LocationFloat = New DevExpress.Utils.PointFloat(0.0006357829!, 13300.79!)
        Me.XrRichText51.Name = "XrRichText51"
        Me.XrRichText51.SerializableRtfString = resources.GetString("XrRichText51.SerializableRtfString")
        Me.XrRichText51.SizeF = New System.Drawing.SizeF(724.0002!, 229.498!)
        '
        'XrRichText50
        '
        Me.XrRichText50.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText50.LocationFloat = New DevExpress.Utils.PointFloat(34.93309!, 13084.21!)
        Me.XrRichText50.Name = "XrRichText50"
        Me.XrRichText50.SerializableRtfString = resources.GetString("XrRichText50.SerializableRtfString")
        Me.XrRichText50.SizeF = New System.Drawing.SizeF(650.0001!, 216.585!)
        '
        'XrRichText49
        '
        Me.XrRichText49.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText49.LocationFloat = New DevExpress.Utils.PointFloat(0.0006357829!, 12808.17!)
        Me.XrRichText49.Name = "XrRichText49"
        Me.XrRichText49.SerializableRtfString = resources.GetString("XrRichText49.SerializableRtfString")
        Me.XrRichText49.SizeF = New System.Drawing.SizeF(724.0002!, 276.042!)
        '
        'XrRichText48
        '
        Me.XrRichText48.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText48.LocationFloat = New DevExpress.Utils.PointFloat(34.93309!, 12640.54!)
        Me.XrRichText48.Name = "XrRichText48"
        Me.XrRichText48.SerializableRtfString = resources.GetString("XrRichText48.SerializableRtfString")
        Me.XrRichText48.SizeF = New System.Drawing.SizeF(650.0001!, 167.626!)
        '
        'XrRichText47
        '
        Me.XrRichText47.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText47.LocationFloat = New DevExpress.Utils.PointFloat(0!, 12399.83!)
        Me.XrRichText47.Name = "XrRichText47"
        Me.XrRichText47.SerializableRtfString = resources.GetString("XrRichText47.SerializableRtfString")
        Me.XrRichText47.SizeF = New System.Drawing.SizeF(724.0008!, 219.874!)
        '
        'XrRichText37
        '
        Me.XrRichText37.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText37.LocationFloat = New DevExpress.Utils.PointFloat(35.41705!, 12213.46!)
        Me.XrRichText37.Name = "XrRichText37"
        Me.XrRichText37.SerializableRtfString = resources.GetString("XrRichText37.SerializableRtfString")
        Me.XrRichText37.SizeF = New System.Drawing.SizeF(650.0001!, 186.376!)
        '
        'XrRichText46
        '
        Me.XrRichText46.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText46.LocationFloat = New DevExpress.Utils.PointFloat(23.45848!, 11949.92!)
        Me.XrRichText46.Name = "XrRichText46"
        Me.XrRichText46.SerializableRtfString = resources.GetString("XrRichText46.SerializableRtfString")
        Me.XrRichText46.SizeF = New System.Drawing.SizeF(700.5423!, 263.5391!)
        '
        'XrRichText45
        '
        Me.XrRichText45.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText45.LocationFloat = New DevExpress.Utils.PointFloat(37.00002!, 11804.17!)
        Me.XrRichText45.Name = "XrRichText45"
        Me.XrRichText45.SerializableRtfString = resources.GetString("XrRichText45.SerializableRtfString")
        Me.XrRichText45.SizeF = New System.Drawing.SizeF(650.0001!, 145.751!)
        '
        'XrRichText44
        '
        Me.XrRichText44.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText44.LocationFloat = New DevExpress.Utils.PointFloat(0!, 11529.17!)
        Me.XrRichText44.Name = "XrRichText44"
        Me.XrRichText44.SerializableRtfString = resources.GetString("XrRichText44.SerializableRtfString")
        Me.XrRichText44.SizeF = New System.Drawing.SizeF(724.0008!, 274.999!)
        '
        'XrRichText43
        '
        Me.XrRichText43.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText43.LocationFloat = New DevExpress.Utils.PointFloat(34.93309!, 11312.58!)
        Me.XrRichText43.Name = "XrRichText43"
        Me.XrRichText43.SerializableRtfString = resources.GetString("XrRichText43.SerializableRtfString")
        Me.XrRichText43.SizeF = New System.Drawing.SizeF(650.0001!, 216.585!)
        '
        'XrRichText42
        '
        Me.XrRichText42.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText42.LocationFloat = New DevExpress.Utils.PointFloat(0!, 11040.54!)
        Me.XrRichText42.Name = "XrRichText42"
        Me.XrRichText42.SerializableRtfString = resources.GetString("XrRichText42.SerializableRtfString")
        Me.XrRichText42.SizeF = New System.Drawing.SizeF(724.0008!, 272.04!)
        '
        'XrRichText41
        '
        Me.XrRichText41.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText41.LocationFloat = New DevExpress.Utils.PointFloat(37.00002!, 10917.71!)
        Me.XrRichText41.Name = "XrRichText41"
        Me.XrRichText41.SerializableRtfString = resources.GetString("XrRichText41.SerializableRtfString")
        Me.XrRichText41.SizeF = New System.Drawing.SizeF(650.0001!, 122.834!)
        '
        'XrRichText40
        '
        Me.XrRichText40.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText40.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10638.54!)
        Me.XrRichText40.Name = "XrRichText40"
        Me.XrRichText40.SerializableRtfString = resources.GetString("XrRichText40.SerializableRtfString")
        Me.XrRichText40.SizeF = New System.Drawing.SizeF(724.0008!, 279.166!)
        '
        'XrRichText39
        '
        Me.XrRichText39.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText39.LocationFloat = New DevExpress.Utils.PointFloat(34.93309!, 10513.62!)
        Me.XrRichText39.Name = "XrRichText39"
        Me.XrRichText39.SerializableRtfString = resources.GetString("XrRichText39.SerializableRtfString")
        Me.XrRichText39.SizeF = New System.Drawing.SizeF(650.0001!, 103.043!)
        '
        'XrRichText38
        '
        Me.XrRichText38.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText38.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10211.21!)
        Me.XrRichText38.Name = "XrRichText38"
        Me.XrRichText38.SerializableRtfString = resources.GetString("XrRichText38.SerializableRtfString")
        Me.XrRichText38.SizeF = New System.Drawing.SizeF(723.9995!, 302.4131!)
        '
        'XrRichText36
        '
        Me.XrRichText36.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText36.LocationFloat = New DevExpress.Utils.PointFloat(37.00002!, 10043.58!)
        Me.XrRichText36.Name = "XrRichText36"
        Me.XrRichText36.SerializableRtfString = resources.GetString("XrRichText36.SerializableRtfString")
        Me.XrRichText36.SizeF = New System.Drawing.SizeF(650.0001!, 167.626!)
        '
        'XrRichText35
        '
        Me.XrRichText35.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText35.LocationFloat = New DevExpress.Utils.PointFloat(0!, 9721.709!)
        Me.XrRichText35.Name = "XrRichText35"
        Me.XrRichText35.SerializableRtfString = resources.GetString("XrRichText35.SerializableRtfString")
        Me.XrRichText35.SizeF = New System.Drawing.SizeF(724.0005!, 321.875!)
        '
        'XrRichText34
        '
        Me.XrRichText34.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText34.LocationFloat = New DevExpress.Utils.PointFloat(35.41679!, 9553.042!)
        Me.XrRichText34.Name = "XrRichText34"
        Me.XrRichText34.SerializableRtfString = resources.GetString("XrRichText34.SerializableRtfString")
        Me.XrRichText34.SizeF = New System.Drawing.SizeF(650.0002!, 143.667!)
        '
        'XrRichText33
        '
        Me.XrRichText33.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText33.LocationFloat = New DevExpress.Utils.PointFloat(0!, 9271.71!)
        Me.XrRichText33.Name = "XrRichText33"
        Me.XrRichText33.SerializableRtfString = resources.GetString("XrRichText33.SerializableRtfString")
        Me.XrRichText33.SizeF = New System.Drawing.SizeF(724.0005!, 281.332!)
        '
        'XrRichText29
        '
        Me.XrRichText29.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText29.LocationFloat = New DevExpress.Utils.PointFloat(35.41667!, 9108.251!)
        Me.XrRichText29.Name = "XrRichText29"
        Me.XrRichText29.SerializableRtfString = resources.GetString("XrRichText29.SerializableRtfString")
        Me.XrRichText29.SizeF = New System.Drawing.SizeF(650.0002!, 163.459!)
        '
        'XrRichText32
        '
        Me.XrRichText32.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText32.LocationFloat = New DevExpress.Utils.PointFloat(35.41679!, 8589.667!)
        Me.XrRichText32.Name = "XrRichText32"
        Me.XrRichText32.SerializableRtfString = resources.GetString("XrRichText32.SerializableRtfString")
        Me.XrRichText32.SizeF = New System.Drawing.SizeF(650.0002!, 229.084!)
        '
        'XrRichText31
        '
        Me.XrRichText31.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText31.LocationFloat = New DevExpress.Utils.PointFloat(0.0002543131!, 8329.168!)
        Me.XrRichText31.Name = "XrRichText31"
        Me.XrRichText31.SerializableRtfString = resources.GetString("XrRichText31.SerializableRtfString")
        Me.XrRichText31.SizeF = New System.Drawing.SizeF(723.9998!, 260.499!)
        '
        'XrRichText30
        '
        Me.XrRichText30.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText30.LocationFloat = New DevExpress.Utils.PointFloat(35.41667!, 8158.417!)
        Me.XrRichText30.Name = "XrRichText30"
        Me.XrRichText30.SerializableRtfString = resources.GetString("XrRichText30.SerializableRtfString")
        Me.XrRichText30.SizeF = New System.Drawing.SizeF(650.0002!, 170.7505!)
        '
        'XrRichText26
        '
        Me.XrRichText26.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText26.LocationFloat = New DevExpress.Utils.PointFloat(0.0002543131!, 7943.75!)
        Me.XrRichText26.Name = "XrRichText26"
        Me.XrRichText26.SerializableRtfString = resources.GetString("XrRichText26.SerializableRtfString")
        Me.XrRichText26.SizeF = New System.Drawing.SizeF(724.0001!, 214.667!)
        '
        'XrRichText28
        '
        Me.XrRichText28.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText28.LocationFloat = New DevExpress.Utils.PointFloat(35.41667!, 7751.125!)
        Me.XrRichText28.Name = "XrRichText28"
        Me.XrRichText28.SerializableRtfString = resources.GetString("XrRichText28.SerializableRtfString")
        Me.XrRichText28.SizeF = New System.Drawing.SizeF(650.0002!, 192.6255!)
        '
        'XrRichText27
        '
        Me.XrRichText27.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText27.LocationFloat = New DevExpress.Utils.PointFloat(0.0002543131!, 8818.751!)
        Me.XrRichText27.Name = "XrRichText27"
        Me.XrRichText27.SerializableRtfString = resources.GetString("XrRichText27.SerializableRtfString")
        Me.XrRichText27.SizeF = New System.Drawing.SizeF(724.0003!, 289.5!)
        '
        'XrRichText25
        '
        Me.XrRichText25.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText25.LocationFloat = New DevExpress.Utils.PointFloat(0.0001271566!, 7488.625!)
        Me.XrRichText25.Name = "XrRichText25"
        Me.XrRichText25.SerializableRtfString = resources.GetString("XrRichText25.SerializableRtfString")
        Me.XrRichText25.SizeF = New System.Drawing.SizeF(724.0002!, 262.5!)
        '
        'XrRichText24
        '
        Me.XrRichText24.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText24.LocationFloat = New DevExpress.Utils.PointFloat(35.41667!, 7317.708!)
        Me.XrRichText24.Name = "XrRichText24"
        Me.XrRichText24.SerializableRtfString = resources.GetString("XrRichText24.SerializableRtfString")
        Me.XrRichText24.SizeF = New System.Drawing.SizeF(650.0002!, 170.9165!)
        '
        'XrRichText23
        '
        Me.XrRichText23.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText23.LocationFloat = New DevExpress.Utils.PointFloat(0!, 7048.588!)
        Me.XrRichText23.Name = "XrRichText23"
        Me.XrRichText23.SerializableRtfString = resources.GetString("XrRichText23.SerializableRtfString")
        Me.XrRichText23.SizeF = New System.Drawing.SizeF(724.0001!, 258.7871!)
        '
        'XrRichText6
        '
        Me.XrRichText6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText6.LocationFloat = New DevExpress.Utils.PointFloat(10.0001!, 3646.875!)
        Me.XrRichText6.Name = "XrRichText6"
        Me.XrRichText6.SerializableRtfString = resources.GetString("XrRichText6.SerializableRtfString")
        Me.XrRichText6.SizeF = New System.Drawing.SizeF(700.77!, 169.8752!)
        '
        'XrRichText7
        '
        Me.XrRichText7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText7.LocationFloat = New DevExpress.Utils.PointFloat(34.93322!, 3816.75!)
        Me.XrRichText7.Name = "XrRichText7"
        Me.XrRichText7.SerializableRtfString = resources.GetString("XrRichText7.SerializableRtfString")
        Me.XrRichText7.SizeF = New System.Drawing.SizeF(650.0002!, 217.7917!)
        '
        'XrRichText9
        '
        Me.XrRichText9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText9.LocationFloat = New DevExpress.Utils.PointFloat(0!, 4044.958!)
        Me.XrRichText9.Name = "XrRichText9"
        Me.XrRichText9.SerializableRtfString = resources.GetString("XrRichText9.SerializableRtfString")
        Me.XrRichText9.SizeF = New System.Drawing.SizeF(724.0001!, 221.9585!)
        '
        'XrRichText10
        '
        Me.XrRichText10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText10.LocationFloat = New DevExpress.Utils.PointFloat(34.93322!, 4266.917!)
        Me.XrRichText10.Name = "XrRichText10"
        Me.XrRichText10.SerializableRtfString = resources.GetString("XrRichText10.SerializableRtfString")
        Me.XrRichText10.SizeF = New System.Drawing.SizeF(650.0002!, 254.2495!)
        '
        'XrRichText11
        '
        Me.XrRichText11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText11.LocationFloat = New DevExpress.Utils.PointFloat(0!, 4521.167!)
        Me.XrRichText11.Name = "XrRichText11"
        Me.XrRichText11.SerializableRtfString = resources.GetString("XrRichText11.SerializableRtfString")
        Me.XrRichText11.SizeF = New System.Drawing.SizeF(724.0001!, 306.0835!)
        '
        'XrRichText12
        '
        Me.XrRichText12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText12.LocationFloat = New DevExpress.Utils.PointFloat(34.93309!, 4827.25!)
        Me.XrRichText12.Name = "XrRichText12"
        Me.XrRichText12.SerializableRtfString = resources.GetString("XrRichText12.SerializableRtfString")
        Me.XrRichText12.SizeF = New System.Drawing.SizeF(650.0002!, 183.417!)
        '
        'XrRichText13
        '
        Me.XrRichText13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText13.LocationFloat = New DevExpress.Utils.PointFloat(0.0006357829!, 5010.667!)
        Me.XrRichText13.Name = "XrRichText13"
        Me.XrRichText13.SerializableRtfString = resources.GetString("XrRichText13.SerializableRtfString")
        Me.XrRichText13.SizeF = New System.Drawing.SizeF(724.0001!, 219.8765!)
        '
        'XrRichText14
        '
        Me.XrRichText14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText14.LocationFloat = New DevExpress.Utils.PointFloat(35.41679!, 5230.544!)
        Me.XrRichText14.Name = "XrRichText14"
        Me.XrRichText14.SerializableRtfString = resources.GetString("XrRichText14.SerializableRtfString")
        Me.XrRichText14.SizeF = New System.Drawing.SizeF(650.0003!, 194.793!)
        '
        'XrRichText15
        '
        Me.XrRichText15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText15.LocationFloat = New DevExpress.Utils.PointFloat(0.0006357829!, 5425.337!)
        Me.XrRichText15.Name = "XrRichText15"
        Me.XrRichText15.SerializableRtfString = resources.GetString("XrRichText15.SerializableRtfString")
        Me.XrRichText15.SizeF = New System.Drawing.SizeF(724.0001!, 305.2065!)
        '
        'XrRichText17
        '
        Me.XrRichText17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText17.LocationFloat = New DevExpress.Utils.PointFloat(35.41679!, 5730.543!)
        Me.XrRichText17.Name = "XrRichText17"
        Me.XrRichText17.SerializableRtfString = resources.GetString("XrRichText17.SerializableRtfString")
        Me.XrRichText17.SizeF = New System.Drawing.SizeF(650.0003!, 146.8765!)
        '
        'XrRichText18
        '
        Me.XrRichText18.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText18.LocationFloat = New DevExpress.Utils.PointFloat(0.0006357829!, 5877.42!)
        Me.XrRichText18.Name = "XrRichText18"
        Me.XrRichText18.SerializableRtfString = resources.GetString("XrRichText18.SerializableRtfString")
        Me.XrRichText18.SizeF = New System.Drawing.SizeF(724.0001!, 284.4575!)
        '
        'XrRichText16
        '
        Me.XrRichText16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText16.LocationFloat = New DevExpress.Utils.PointFloat(35.41679!, 6161.877!)
        Me.XrRichText16.Name = "XrRichText16"
        Me.XrRichText16.SerializableRtfString = resources.GetString("XrRichText16.SerializableRtfString")
        Me.XrRichText16.SizeF = New System.Drawing.SizeF(650.0003!, 120.8345!)
        '
        'XrRichText19
        '
        Me.XrRichText19.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText19.LocationFloat = New DevExpress.Utils.PointFloat(0.0001271566!, 6293.128!)
        Me.XrRichText19.Name = "XrRichText19"
        Me.XrRichText19.SerializableRtfString = resources.GetString("XrRichText19.SerializableRtfString")
        Me.XrRichText19.SizeF = New System.Drawing.SizeF(724.0001!, 156.25!)
        '
        'XrRichText20
        '
        Me.XrRichText20.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText20.LocationFloat = New DevExpress.Utils.PointFloat(35.41667!, 6449.378!)
        Me.XrRichText20.Name = "XrRichText20"
        Me.XrRichText20.SerializableRtfString = resources.GetString("XrRichText20.SerializableRtfString")
        Me.XrRichText20.SizeF = New System.Drawing.SizeF(650.0002!, 88.62646!)
        '
        'XrRichText21
        '
        Me.XrRichText21.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText21.LocationFloat = New DevExpress.Utils.PointFloat(0!, 6538.004!)
        Me.XrRichText21.Name = "XrRichText21"
        Me.XrRichText21.SerializableRtfString = resources.GetString("XrRichText21.SerializableRtfString")
        Me.XrRichText21.SizeF = New System.Drawing.SizeF(724.0001!, 239.667!)
        '
        'XrRichText22
        '
        Me.XrRichText22.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText22.LocationFloat = New DevExpress.Utils.PointFloat(35.41667!, 6777.671!)
        Me.XrRichText22.Name = "XrRichText22"
        Me.XrRichText22.SerializableRtfString = resources.GetString("XrRichText22.SerializableRtfString")
        Me.XrRichText22.SizeF = New System.Drawing.SizeF(650.0002!, 270.9165!)
        '
        'XrRichText8
        '
        Me.XrRichText8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText8.LocationFloat = New DevExpress.Utils.PointFloat(23.45835!, 3437.616!)
        Me.XrRichText8.Name = "XrRichText8"
        Me.XrRichText8.SerializableRtfString = resources.GetString("XrRichText8.SerializableRtfString")
        Me.XrRichText8.SizeF = New System.Drawing.SizeF(650.0002!, 189.6667!)
        '
        'XrRichText4
        '
        Me.XrRichText4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText4.LocationFloat = New DevExpress.Utils.PointFloat(9.999974!, 3245.314!)
        Me.XrRichText4.Name = "XrRichText4"
        Me.XrRichText4.SerializableRtfString = resources.GetString("XrRichText4.SerializableRtfString")
        Me.XrRichText4.SizeF = New System.Drawing.SizeF(700.77!, 192.3022!)
        '
        'XrRichText5
        '
        Me.XrRichText5.BackColor = System.Drawing.Color.Transparent
        Me.XrRichText5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText5.LocationFloat = New DevExpress.Utils.PointFloat(23.45835!, 2715.625!)
        Me.XrRichText5.Name = "XrRichText5"
        Me.XrRichText5.SerializableRtfString = resources.GetString("XrRichText5.SerializableRtfString")
        Me.XrRichText5.SizeF = New System.Drawing.SizeF(650.0001!, 529.6892!)
        Me.XrRichText5.StylePriority.UseBackColor = False
        '
        'XrRichText3
        '
        Me.XrRichText3.BackColor = System.Drawing.Color.Transparent
        Me.XrRichText3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText3.LocationFloat = New DevExpress.Utils.PointFloat(35.41654!, 1805.476!)
        Me.XrRichText3.Name = "XrRichText3"
        Me.XrRichText3.SerializableRtfString = resources.GetString("XrRichText3.SerializableRtfString")
        Me.XrRichText3.SizeF = New System.Drawing.SizeF(649.9999!, 814.0725!)
        Me.XrRichText3.StylePriority.UseBackColor = False
        '
        'XrRichText2
        '
        Me.XrRichText2.BackColor = System.Drawing.Color.Transparent
        Me.XrRichText2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText2.LocationFloat = New DevExpress.Utils.PointFloat(35.41667!, 898.4697!)
        Me.XrRichText2.Name = "XrRichText2"
        Me.XrRichText2.SerializableRtfString = resources.GetString("XrRichText2.SerializableRtfString")
        Me.XrRichText2.SizeF = New System.Drawing.SizeF(650.0!, 800.0465!)
        Me.XrRichText2.StylePriority.UseBackColor = False
        '
        'XrRichText1
        '
        Me.XrRichText1.BackColor = System.Drawing.Color.Transparent
        Me.XrRichText1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.XrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(35.41667!, 0!)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.SizeF = New System.Drawing.SizeF(650.0!, 800.0834!)
        Me.XrRichText1.StylePriority.UseBackColor = False
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox1, Me.XrLabel2, Me.XrLabel3})
        Me.TopMargin.HeightF = 123.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(23.45835!, 28.125!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(192.3168!, 74.70835!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(215.7752!, 74.0735!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(217.391!, 16.25983!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "Subsecretaría de Salud Pública "
        '
        'XrLabel3
        '
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(363.0575!, 90.33334!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(310.4008!, 23.00002!)
        Me.XrLabel3.Text = "Acta de Verificación Sanitaria No"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 61.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ACTA_DE_VERIFICACIÓN_RPBI_HOSP
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Margins = New System.Drawing.Printing.Margins(63, 63, 123, 61)
        Me.Version = "17.2"
        Me.Watermark.Image = CType(resources.GetObject("ACTA_DE_VERIFICACIÓN_RPBI_HOSP.Watermark.Image"), System.Drawing.Image)
        Me.Watermark.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Watermark.ImageTransparency = 237
        CType(Me.XrRichText59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region

End Class