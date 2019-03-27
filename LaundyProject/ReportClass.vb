Imports System.IO

Public Class ReportClass
    Shared FlNm As String = "C:\Laundry Report\Report\Report" & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xls"

    Public Shared Sub ReportHari(ByRef judul As String, ByVal DGV As DataGridView)

        Dim fs As New StreamWriter(FlNm, True)
        With fs
            .WriteLine("<?xml version=""1.0""?>")
            .WriteLine("<?mso-application progid=""Excel.Sheet""?>")
            .WriteLine("<Workbook xmlns=""urn:schemas-microsoft-com:office:spreadsheet""")
            .WriteLine("xmlns:o=""urn:schemas-microsoft-com:office:office""")
            .WriteLine("xmlns:x=""urn:schemas-microsoft-com:office:excel""")
            .WriteLine("xmlns:ss=""urn:schemas-microsoft-com:office:spreadsheet""")
            .WriteLine("xmlns:html=""http://www.w3.org/TR/REC-html40"">")
            .WriteLine("<DocumentProperties xmlns=""urn:schemas-microsoft-com:office:office"">")
            .WriteLine("<Author>Abdul Rahmat</Author>")
            .WriteLine("</DocumentProperties>")

            .WriteLine("<OfficeDocumentSettings xmlns=""urn:schemas-microsoft-com:office:office"">")
            .WriteLine("<AllowPNG/>")
            .WriteLine("</OfficeDocumentSettings>")

            'START styling
            .WriteLine("<Styles>")
            .WriteLine("<Style ss:ID=""Default"" ss:Name=""Normal"">")
            .WriteLine("<Alignment ss:Vertical=""Bottom""/>")
            .WriteLine("<Borders/>")
            .WriteLine("<Font ss:FontName=""Calibri"" x:Family=""Swiss"" ss:Size=""11"" ss:Color=""#000000""/>")
            .WriteLine("<Interior/>")
            .WriteLine("<NumberFormat/>")
            .WriteLine("<Protection/>")
            .WriteLine("</Style>")

            'STYLE isi
            .WriteLine("<Style ss:ID=""isi"">")
            .WriteLine("<Borders>")
            .WriteLine("<Border ss:Position=""Bottom"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("<Border ss:Position=""Left"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("<Border ss:Position=""Right"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("<Border ss:Position=""Top"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("</Borders>")
            .WriteLine("</Style>")

            'STYLE Header
            .WriteLine("<Style ss:ID=""header"">")
            .WriteLine("<Alignment ss:Horizontal=""Center"" ss:Vertical=""Bottom""/>")
            .WriteLine("<Borders>")
            .WriteLine("<Border ss:Position=""Bottom"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("<Border ss:Position=""Left"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("<Border ss:Position=""Right"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("<Border ss:Position=""Top"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("</Borders>")
            .WriteLine("<Font ss:FontName=""Calibri"" x:Family=""Swiss"" ss:Size=""11"" ss:Color=""#000000"" ss:Bold=""1""/>")
            .WriteLine("</Style>")

            'STYLE Judul
            .WriteLine("<Style ss:ID=""judul"">")
            .WriteLine("<Alignment ss:Horizontal=""Center"" ss:Vertical=""Center""/>")
            .WriteLine("<Font ss:FontName=""Calibri"" x:Family=""Swiss"" ss:Size=""16"" ss:Color=""#000000"" ss:Bold=""1""/>")
            .WriteLine("</Style>")

            .WriteLine("</Styles>")


            'END styling

            'START Worksheet

            .WriteLine("<Worksheet ss:Name=""Laporan"">")
            '.WriteLine("<Table>")
            .WriteLine("<Table ss:ExpandedColumnCount=""8"" ss:ExpandedRowCount=""12"" x:FullColumns=""1""")
            .WriteLine("x:FullRows=""1"" ss:DefaultRowHeight=""15"">")
            .WriteLine("<Column ss:Index=""2"" ss:AutoFitWidth=""0"" ss:Width=""54.75""/>")
            .WriteLine("<Column ss:AutoFitWidth=""0"" ss:Width=""180""/>")
            .WriteLine("<Column ss:AutoFitWidth=""0"" ss:Width=""99""/>")
            .WriteLine("<Column ss:AutoFitWidth=""0"" ss:Width=""96.75""/>")
            .WriteLine("<Column ss:AutoFitWidth=""0"" ss:Width=""58.5""/>")
            .WriteLine("<Column ss:AutoFitWidth=""0"" ss:Width=""78.75""/>")
            .WriteLine("<Column ss:AutoFitWidth=""0"" ss:Width=""80.25""/>")
            .WriteLine("<Row ss:AutoFitHeight=""0""/>")

            'SECTION judul
            .WriteLine("<Row ss:AutoFitHeight=""0"" ss:Height=""19.5"">")
            .WriteLine("<Cell ss:Index=""2"" ss:MergeAcross=""6"" ss:StyleID=""judul""><Data ss:Type=""String"">" + judul + "</Data></Cell>")
            .WriteLine("</Row>")

            'AUTO SET HEADER
            .WriteLine("<Row ss:Index=""6"" ss:AutoFitHeight=""0"">")
            For i As Integer = 0 To DGV.Columns.Count - 1 'SET HEADER
                Application.DoEvents()
                .WriteLine("<Cell ss:StyleID=""header"">")
                .WriteLine("<Data ss:Type=""String"">{0}</Data>", DGV.Columns.Item(i).HeaderText)
                .WriteLine("</Cell>")
            Next
            .WriteLine("</Row>")

            'AUTO FILL DATA
            For intRow As Integer = 0 To DGV.RowCount - 1
                Application.DoEvents()
                .WriteLine("<Row ss:AutoFitHeight =""0"">")
                For intCol As Integer = 0 To DGV.Columns.Count - 1
                    Application.DoEvents()
                    .WriteLine("<Cell ss:StyleID=""isi"">")
                    .WriteLine("<Data ss:Type=""String"">{0}</Data>", DGV.Item(intCol, intRow).Value.ToString)
                    .WriteLine("</Cell>")
                Next
                .WriteLine("</Row>")
            Next
            .WriteLine("</Table>")
            .WriteLine("<WorksheetOptions xmlns=""urn:schemas-microsoft-com:office:excel"">")
            .WriteLine("<PageSetup>")
            .WriteLine("<Header x:Margin=""0.3""/>")
            .WriteLine("<Footer x:Margin=""0.3""/>")
            .WriteLine("<PageMargins x:Bottom=""0.75"" x:Left=""0.7"" x:Right=""0.7"" x:Top=""0.75""/>")
            .WriteLine("</PageSetup>")
            .WriteLine("<Unsynced/>")
            .WriteLine("<Print>")
            .WriteLine("<ValidPrinterInfo/>")
            .WriteLine("<PaperSizeIndex>20480</PaperSizeIndex>")
            .WriteLine("<HorizontalResolution>160</HorizontalResolution>")
            .WriteLine("<VerticalResolution>144</VerticalResolution>")
            .WriteLine("</Print>")
            .WriteLine("<Selected/>")
            .WriteLine("<Panes>")
            .WriteLine("<Pane>")
            .WriteLine("<Number>3</Number>")
            .WriteLine("<ActiveRow>3</ActiveRow>")
            .WriteLine("<ActiveCol>5</ActiveCol>")
            .WriteLine("</Pane>")
            .WriteLine("</Panes>")
            .WriteLine("<ProtectObjects>False</ProtectObjects>")
            .WriteLine("<ProtectScenarios>False</ProtectScenarios>")
            .WriteLine("</WorksheetOptions>")
            .WriteLine("</Worksheet>")
            .WriteLine("</Workbook>")

            'END Worksheet
            .Close()
        End With
    End Sub
End Class
