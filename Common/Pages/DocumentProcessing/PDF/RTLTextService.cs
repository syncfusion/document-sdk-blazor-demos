#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Drawing;
using System.IO;
using System.Collections.Generic;

namespace BlazorDemos.Data.FileFormats.PDF
{ 
    public class RTLTextService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public RTLTextService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public MemoryStream CreatePdfDocument()
        {
            //Create a new PDF document
            PdfDocument document = new PdfDocument();

            //Add a page
            PdfPage page = document.Pages.Add();


            PdfFont font = new PdfTrueTypeFont(fileDataValue["noto-naskh-arabic-regular.ttf"], 13);
            PdfFont font1 = new PdfTrueTypeFont(fileDataValue["noto-sans-hebrew-medium.ttf"], 13);

            //Read the text from text file

            StreamReader reader = new StreamReader(fileDataValue["arabic.txt"], System.Text.Encoding.Unicode);
            StreamReader reader1 = new StreamReader(fileDataValue["hebrew.txt"], System.Text.Encoding.Unicode);
            string text = reader.ReadToEnd();
            reader.Dispose();
            string text1 = reader1.ReadToEnd();
            reader1.Dispose();

            //Create a brush
            PdfBrush brush = new PdfSolidBrush(new PdfColor(0, 0, 0));
            PdfPen pen = new PdfPen(new PdfColor(0, 0, 0));
            SizeF clipBounds = page.Graphics.ClientSize;
            RectangleF rect = new RectangleF(0, 0, clipBounds.Width, clipBounds.Height);
            RectangleF rect1 = new RectangleF(0, 240, clipBounds.Width, clipBounds.Height);

            //Set the property for RTL text
            PdfStringFormat format = new PdfStringFormat();
            format.TextDirection = PdfTextDirection.RightToLeft;
            format.Alignment = PdfTextAlignment.Right;
            format.ParagraphIndent = 35f;

            //Draw text.
            page.Graphics.DrawString(text, font, brush, rect, format);
            page.Graphics.DrawString(text1, font1, brush, rect1, format);
            MemoryStream stream = new MemoryStream();
            document.Save(stream);
            document.Close();
            stream.Position = 0;

            return stream;            
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
