Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Web
Imports System.IO
Imports Wisej.Web
Imports Wisej.Web.Form

Partial Public Class ReportView
    Inherits System.Web.UI.Page
    Dim sReportName, sProcedureName, bExportar_PDF As String
    Dim _report As XtraReport
    Dim oFunciones As New dllData
    Dim sArraysMesesDic As New Dictionary(Of String, String)
    Dim Margins(0) As String
    Public sTipo_Reporte As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Wisej.Web.Application.Session("OMITIR_HORA_FECHA") = True
        If Wisej.Web.Application.Session("DocumentCached") Is Nothing Then
            Wisej.Web.Application.Session("OMITIR_FECHA") = oFunciones.fDevulve_Configuracion_Sistema("FECHA_HORA")
            'If Wisej.Web.Application.Session("Cve_Unidad") <> "ADMIN" Then
            '    Wisej.Web.Application.Session("Cve_Unidad_Reporte") = Wisej.Web.Application.Session("Cve_Unidad_Reporte")

            'End If
            sTipo_Reporte = Request.QueryString("sTipo_Reporte")

            Dim COM As String = Request.QueryString("COMPRA")
            ' ¿'   Dim folio_p = Request.QueryString("FOLIO_PEDIDO")

            'Agregado para evitar recargar 2 veces la pagina  del reporte
            sProcedureName = Wisej.Web.Application.Session("ProcedureName")
            '--------------------------------------------------------------------------------
            sReportName = Wisej.Web.Application.Session("ReportName")
            sArraysMesesDic = Wisej.Web.Application.Session("DicParametros")
            bExportar_PDF = Wisej.Web.Application.Session("Exportar_PDF")
            Dim sCamposX(0)
            sCamposX(0) = Wisej.Web.Application.Session("Titulo_Reporte")

            If Trim(sReportName) <> Nothing Then
                Dim _ReporteInstance As XtraReport
                Try
                    _ReporteInstance = Activator.CreateInstance(Type.GetType("DPCRS." & sReportName))
                    If sArraysMesesDic Is Nothing = False Then
                        For i = 0 To sArraysMesesDic.Count - 1
                            _ReporteInstance.Parameters(sArraysMesesDic.Keys(i)).Value = sArraysMesesDic.Values(i)
                        Next
                    End If

                    Dim MS As New MemoryStream()
                    Dim opts As New DevExpress.XtraPrinting.PdfExportOptions
                    opts.ShowPrintDialogOnOpen = True
                    MS.Seek(0, SeekOrigin.Begin)
                    _ReporteInstance.ExportToPdf(MS, opts)
                    'Dim report As Byte() = MS.ToArray()
                    'Page.Response.ContentType = "application/pdf"
                    'Page.Response.Clear()
                    'Page.Response.OutputStream.Write(report, 0, report.Length)

                    'Page.Response.[End]()
                    'Page.Response.End()

                    _ReporteInstance.CreateDocument()
                    ASPxDocumentViewer1.Report = _ReporteInstance

                Catch ex As Exception
                    Dim errorx = ex.Message.ToString

                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
                'Try
                '    _ReporteInstance = Activator.CreateInstance(Type.GetType("DPCRS." + sReportName))
                'Catch ex As Exception
                '    oFunciones.Guardar_Error("GENERAL REPORTES", ex.Message, "user", "Activator.CreateInstance reportes" & sReportName, "ReportViewer")
                '    'MessageBox.Show(ex.Message)
                'End Try
                'Margins = oFunciones.ReportsMargins("pCAT_REPORTES_B", "@ReportName", sReportName, "Margins")

                'If _ReporteInstance Is Nothing = False Then
                '    If _ReporteInstance.Parameters.Count > 0 Then
                '        If sArraysMesesDic Is Nothing = False Then
                '            For i = 0 To sArraysMesesDic.Count - 1
                '                If _ReporteInstance.Parameters.Contains(_ReporteInstance.Parameters(sArraysMesesDic.Keys(i))) Then
                '                    _ReporteInstance.Parameters(sArraysMesesDic.Keys(i)).Value = sArraysMesesDic.Values(i)
                '                End If
                '            Next
                '        End If
                '    End If

                '    _report = _ReporteInstance
                'End If



                'If _report IsNot Nothing Then
                '    _report.Margins = New Printing.Margins(Margins(0), Margins(1), Margins(2), Margins(3))
                '    If sTipo_Reporte <> Nothing Then
                '        _report.Tag = sTipo_Reporte
                '    End If
                '    If COM <> Nothing Then
                '        _report.Name = COM
                '    End If
                'End If
                Wisej.Web.Application.Session("r1") = sReportName.ToString
                'ASPxDocumentViewer1.Report = _report
            End If
        End If
        sArraysMesesDic = Nothing
        Wisej.Web.Application.Session("DicParametros") = Nothing

        AddHandler ASPxDocumentViewer1.CacheReportDocument, AddressOf ASPxDocumentViewer1_CacheReportDocument
        AddHandler ASPxDocumentViewer1.RestoreReportDocumentFromCache, AddressOf ASPxDocumentViewer1_RestoreReportDocumentFromCache
    End Sub
    'Protected Sub ReportViewer1_CacheReportDocument(ByVal sender As Object, ByVal e As CacheReportDocumentEventArgs)
    '    e.Key = Guid.NewGuid().ToString()
    '    Page.Session(e.Key) = e.SaveDocumentToMemoryStream()
    '    Wisej.Web.Application.Session("DocumentCached") = True
    'End Sub
    'Protected Sub ReportViewer1_RestoreReportDocumentFromCache(ByVal sender As Object, ByVal e As RestoreReportDocumentFromCacheEventArgs)
    '    Dim stream As IO.Stream = TryCast(Page.Session(e.Key), IO.Stream)
    '    If stream IsNot Nothing Then
    '        e.RestoreDocumentFromStream(stream)
    '    End If
    'End Sub

    Protected Sub ASPxDocumentViewer1_CacheReportDocument(ByVal sender As Object, ByVal e As CacheReportDocumentEventArgs)
        e.Key = Guid.NewGuid().ToString()
        Page.Session(e.Key) = e.SaveDocumentToMemoryStream()
        Wisej.Web.Application.Session("DocumentCached") = True
    End Sub
    Protected Sub ASPxDocumentViewer1_RestoreReportDocumentFromCache(ByVal sender As Object, ByVal e As RestoreReportDocumentFromCacheEventArgs)
        Dim stream As IO.Stream = TryCast(Page.Session(e.Key), IO.Stream)
        If stream IsNot Nothing Then
            e.RestoreDocumentFromStream(stream)
        End If
    End Sub

    ' Use this method if you want to automaically open
    ' the created PDF file in the default program.
    Public Sub StartProcess(ByVal path As String)
        Dim process As New Process()
        Try
            process.StartInfo.FileName = path
            process.Start()
            process.WaitForInputIdle()
        Catch
        End Try
    End Sub
    Protected Sub cpPopup_Callback(ByVal source As Object, ByVal e As DevExpress.Web.CallbackEventArgsBase)

    End Sub
End Class