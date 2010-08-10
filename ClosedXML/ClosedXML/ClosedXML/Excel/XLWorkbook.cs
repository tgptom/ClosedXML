﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClosedXML.Excel.Style;
using System.IO;
using System.Drawing;

namespace ClosedXML.Excel
{
    public partial class XLWorkbook: IXLWorkbook
    {
        public XLWorkbook()
        {
            Worksheets = new XLWorksheets();
        }
        #region IXLWorkbook Members

        public IXLWorksheets Worksheets { get; private set; }

        /// <summary>
        /// Gets the file name of the workbook.
        /// </summary>
        public String Name { get; private set; }

        /// <summary>
        /// Gets the file name of the workbook including its full directory.
        /// </summary>
        public String FullName { get; private set; }

        public void SaveAs(String file, Boolean overwrite = false)
        {
            if (overwrite && File.Exists(file)) File.Delete(file);

            // For maintainability reasons the XLWorkbook class was divided into two files.
            // The method CreatePackage can be located in the file XLWorkbook_Save.cs   
            CreatePackage(file);
        }

        #endregion

        #region Static

        private static XLStyle defaultStyle;
        /// <summary>
        /// Gets the default style for new workbooks.
        /// </summary>
        public static XLStyle DefaultStyle
        {
            get
            {
                if (defaultStyle == null)
                {
                    defaultStyle = new XLStyle(null, null)
                    {
                        Font = new XLFont(null, null)
                        {
                            Bold = false,
                            Italic = false,
                            Underline = XLFontUnderlineValues.None,
                            Strikethrough = false,
                            VerticalAlignment = XLFontVerticalTextAlignmentValues.Baseline,
                            FontSize = 11,
                            FontColor = Color.FromArgb(0,0,0),
                            FontName = "Calibri",
                            FontFamilyNumbering = XLFontFamilyNumberingValues.Swiss
                        }
                        , Alignment = new XLAlignment(), Border = new XLBorder(), NumberFormat = new XLNumberFormat(),
                         Fill = new XLFill(null)
                        {
                            BackgroundColor = Color.FromArgb(255,255,255),
                            PatternType = XLFillPatternValues.None,
                            PatternColor = Color.FromArgb(255, 255, 255)
                        }
                    //Border = new XLBorder(null)
                    //    {
                    //        BottomBorder = BorderStyleValues.None,
                    //        DiagonalBorder = BorderStyleValues.None,
                    //        DiagonalDown = false,
                    //        DiagonalUp = false,
                    //        LeftBorder = BorderStyleValues.None,
                    //        RightBorder = BorderStyleValues.None,
                    //        TopBorder = BorderStyleValues.None,
                    //        BottomBorderColor = "000000",
                    //        DiagonalBorderColor = "000000",
                    //        LeftBorderColor = "000000",
                    //        RightBorderColor = "000000",
                    //        TopBorderColor = "000000"
                    //    },
                    //NumberFormat = new XLNumberFormat(0),
                    //Alignment = new XLAlignment(null)
                    //    {
                    //        Horizontal = HorizontalAlignmentValues.General,
                    //        Indent = 0,
                    //        JustifyLastLine = false,
                    //        ReadingOrder = OPReadingOrders.ContextDependent,
                    //        RelativeIndent = 0,
                    //        ShrinkToFit = false,
                    //        TextRotation = 0,
                    //        Vertical = VerticalAlignmentValues.Bottom,
                    //        WrapText = false
                    //    }
                    };
                }
                return defaultStyle;
            }
        }

        #endregion
    }
}
