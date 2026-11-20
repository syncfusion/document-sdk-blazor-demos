using System.Collections.Generic;
using System.IO;
using Syncfusion.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Parsing;

namespace BlazorDemos.Data.FileFormats.PDF
{ 
    public class SVGtoPDFService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public SVGtoPDFService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public MemoryStream ConvertPdfDocument()
        {
            MemoryStream stream = fileDataValue["svg-to-pdf.svg"];

            //Convert the SVG file to PDF template.
            SvgConverter converter = new SvgConverter();
            PdfTemplate temp = converter.Convert(stream);

            //Create a new PDF document and draw the PDF template to the page.
            PdfDocument document = new PdfDocument();
            document.PageSettings.Margins.All = 0;
            document.PageSettings.Size = new SizeF(temp.Width, temp.Height);
            PdfPage page = document.Pages.Add();

            //Draw the PDF template to the page.
            page.Graphics.DrawPdfTemplate(temp, new PointF(0, 0), new SizeF(temp.Width, temp.Height));

            //Saving the PDF to the MemoryStream
            MemoryStream ms = new MemoryStream();
            document.Save(ms);
            //If the position is not set to '0' then the PDF will be empty.
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
