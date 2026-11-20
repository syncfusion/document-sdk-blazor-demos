#region Copyright Syncfusion Inc. 2001 - 2023
// Copyright Syncfusion Inc. 2001 - 2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws.
#endregion
using Syncfusion.Pdf.Parsing;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BlazorDemos.Data.FileFormats.PDF
{
    public class LinearizedPDFService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;

        public LinearizedPDFService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        public MemoryStream LinearizePdf()
        {
            PdfLoadedDocument document = new PdfLoadedDocument(fileDataValue.First().Value);

            document.FileStructure.IsLinearized = true;

            MemoryStream stream = new MemoryStream();
            document.Save(stream);
            document.Close(true);
            stream.Position = 0;
            return stream;
        }

        public void Close()
        {
            foreach (KeyValuePair<string, MemoryStream> item in fileDataValue)
            {
                item.Value.Dispose();
            }
            fileDataValue.Clear();
        }
    }
}