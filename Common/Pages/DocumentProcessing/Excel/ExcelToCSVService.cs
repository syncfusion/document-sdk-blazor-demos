﻿#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.XlsIO;
using System.Collections.Generic;
using System.IO;

namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class ExcelToCSVService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public ExcelToCSVService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// Create an Excel document with attendance tracker
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream ExcelToCSVXlsIO(string filePath)
        {
            ExcelEngine excelEngine = new ExcelEngine();
            IApplication application = excelEngine.Excel;

            //Loads Excel document
            IWorkbook workbook = application.Workbooks.Open(fileDataValue["excel-to-csv-template.xlsx"]);

            //Save workbook
            MemoryStream ms = new MemoryStream();
            workbook.SaveAs(ms, ",");
            ms.Position = 0;

            return ms;
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