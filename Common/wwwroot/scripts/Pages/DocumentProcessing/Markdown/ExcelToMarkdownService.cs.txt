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

namespace BlazorDemos.Data.FileFormats.Markdown
{
    public class ExcelToMarkdownService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public ExcelToMarkdownService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create an Excel document
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream ExcelToMarkdownXlsIO(string option)
        {

            if (option == "View Template")
            {
                return fileDataValue["excel-to-markdown.xlsx"];
            }
            else
            {
                ExcelEngine engine = new ExcelEngine();
                IApplication app = engine.Excel;

                //Loads Excel document
                IWorkbook workbook = app.Workbooks.Open(fileDataValue["excel-to-markdown.xlsx"]);


                //Save the document as a stream and return the stream
                using (MemoryStream stream = new MemoryStream())
                {
                    //Saves the workbook as markdown with markdown options
                    workbook.SaveAs(stream, ExcelSaveType.Markdown);
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