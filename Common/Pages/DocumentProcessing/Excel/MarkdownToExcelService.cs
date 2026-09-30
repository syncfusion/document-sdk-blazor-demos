#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.XlsIO;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class MarkdownToExcelService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public MarkdownToExcelService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create an Excel document
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream MarkdownToExcel(string option)
        {

            if (option == "Input Template")
            {
                return fileDataValue["markdown-to-excel.md"];
            }
            else
            {
                ExcelEngine engine = new ExcelEngine();
                IApplication app = engine.Excel;

                app.DefaultVersion = ExcelVersion.Xlsx;

                app.PreserveCSVDataTypes = true;

                //Loads Excel document
                IWorkbook workbook = app.Workbooks.Open(fileDataValue["markdown-to-excel.md"],ExcelOpenType.Markdown);

                IWorksheet sheet = workbook.Worksheets[0];

                sheet.Calculate();

                sheet.UsedRange.AutofitColumns();
                
                //Save the document as a stream and return the stream
                using (MemoryStream stream = new MemoryStream())
                {
                    //Saves the workbook as markdown with markdown options
                    workbook.SaveAs(stream);
                    stream.Position = 0;
                    return stream;
                }
            }
        }
        #region HelperMethod
        public void Close()
        {
            foreach (KeyValuePair<string, MemoryStream> item in fileDataValue)
            {
                item.Value.Dispose();
            }
            fileDataValue.Clear();
        }
        #endregion
    }
}