﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClosedXML.Excel;
using System.Drawing;
using ClosedXML.Excel.Style;

namespace ClosedXML_Examples.Styles
{
    public class StyleFont
    {
        public void Create(String filePath)
        {
            var workbook = new XLWorkbook();
            var ws = workbook.Worksheets.Add("Style Font");

            var co = 2;
            var ro = 1;

            ws.Cell(++ro, co).Value = "Bold";
            ws.Cell(ro, co).Style.Font.Bold = true;

            ws.Cell(++ro, co).Value = "FontColor - Red";
            ws.Cell(ro, co).Style.Font.FontColor = Color.Red;

            ws.Cell(++ro, co).Value = "FontFamilyNumbering - Swiss";
            ws.Cell(ro, co).Style.Font.FontFamilyNumbering = XLFontFamilyNumberingValues.Swiss;

            ws.Cell(++ro, co).Value = "FontName - Arial";
            ws.Cell(ro, co).Style.Font.FontName = "Arial";

            ws.Cell(++ro, co).Value = "FontSize = 8";
            ws.Cell(ro, co).Style.Font.FontSize = 8;

            ws.Cell(++ro, co).Value = "Italic";
            ws.Cell(ro, co).Style.Font.Italic = true;

            ws.Cell(++ro, co).Value = "Shadow";
            ws.Cell(ro, co).Style.Font.Shadow = true;

            ws.Cell(++ro, co).Value = "Strikethrough";
            ws.Cell(ro, co).Style.Font.Strikethrough = true;

            ws.Cell(++ro, co).Value = "Underline = Double";
            ws.Cell(ro, co).Style.Font.Underline = XLFontUnderlineValues.Double;

            ws.Cell(++ro, co).Value = "VerticalAlignment = Superscript";
            ws.Cell(ro, co).Style.Font.VerticalAlignment = XLFontVerticalTextAlignmentValues.Superscript;

            ws.Cell(++ro, co).Value = "Combined";
            ws.Cell(ro, co).Style.Font.Bold = true;
            ws.Cell(ro, co).Style.Font.FontColor = Color.Red;
            ws.Cell(ro, co).Style.Font.FontFamilyNumbering = XLFontFamilyNumberingValues.Swiss;
            ws.Cell(ro, co).Style.Font.FontName = "Arial";
            ws.Cell(ro, co).Style.Font.FontSize = 8;
            ws.Cell(ro, co).Style.Font.Italic = true;
            ws.Cell(ro, co).Style.Font.Shadow = true;
            ws.Cell(ro, co).Style.Font.Strikethrough = true;
            ws.Cell(ro, co).Style.Font.Underline = XLFontUnderlineValues.Double;
            ws.Cell(ro, co).Style.Font.VerticalAlignment = XLFontVerticalTextAlignmentValues.Superscript;


            workbook.SaveAs(filePath);
        }
    }
}
