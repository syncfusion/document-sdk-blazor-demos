#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Drawing;
using System.IO;
using System.Collections.Generic;
using Syncfusion.Office;
using Syncfusion.DocIORenderer;
using Syncfusion.Pdf;
using System;

namespace BlazorDemos.Data.DocumentProcessing.Word
{
    public class EditInkService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public EditInkService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        public MemoryStream EditInk(string documentType, string button)
        {
            if (button == "View Template")
            {
                return fileDataValue["edit-ink-input.docx"];
            }
            // Creates an empty Word document instance         
            WordDocument document = new WordDocument();
            document.Open(fileDataValue["edit-ink-input.docx"], FormatType.Docx);
            // Access the first section of the document
            WSection section = document.Sections[0];

            // Access the first ink and customize its trace points.
            WInk firstInk = section.Paragraphs[0].ChildEntities[0] as WInk;
            // Move the ink vertically.
            firstInk.VerticalPosition = 25f;
            // Copy existing points into the new array.
            int oldTracePointsLength = firstInk.Traces[0].Points.Length;
            int newTracePointsLength = oldTracePointsLength + 3;
            PointF[] newTracePoints = new PointF[newTracePointsLength];
            PointF[] oldTracePoints = firstInk.Traces[0].Points;
            Array.Copy(oldTracePoints, newTracePoints, oldTracePointsLength);
            newTracePoints[newTracePoints.Length - 3] = new PointF(oldTracePoints[3].X, 0);
            newTracePoints[newTracePoints.Length - 2] = new PointF(oldTracePoints[0].X, 0);
            newTracePoints[newTracePoints.Length - 1] = new PointF(oldTracePoints[0].X, oldTracePoints[0].Y);
            // Update the trace points of the first ink with the new array. 
            firstInk.Traces[0].Points = newTracePoints;

            // Access the second ink and customize its container width.
            WInk secondInk = (WInk)section.Paragraphs[1].ChildEntities[0];
            IOfficeInkTrace secondInkTrace = secondInk.Traces[0];
            // Set the ink size (thickness) to 1 point
            secondInkTrace.Brush.Size = new SizeF(1f, 1f);

            // Access the third ink and customize its container width.
            WInk thirdInk = (WInk)section.Paragraphs[2].ChildEntities[0];
            // Set the width of the ink container to 130 points.
            thirdInk.Width = 130f;

            // Access the fourth ink and customize its brush color.
            WParagraph paragraph = (WParagraph)section.Tables[0].Rows[0].Cells[0].ChildEntities[0] ;
            WInk fourthInk = (WInk)paragraph.ChildEntities[0];
            IOfficeInkTrace fourthInkTrace = fourthInk.Traces[0];
            // Set the color of the ink stroke to Yellow
            fourthInkTrace.Brush.Color = Color.Yellow;

            FormatType type = FormatType.Docx;
            /*Server:Block*/
#if !(WASM) && !WEBAPP
            //Save as .pdf format
            if (documentType == "PDF")
            {
                DocIORenderer render = new DocIORenderer();
                // Converts Word document into PDF document.
                PdfDocument pdf = render.ConvertToPDF(document);
                //Save the document as a stream and return the stream
                using (MemoryStream stream = new MemoryStream())
                {
                    //Save the created PDF document to MemoryStream
                    pdf.Save(stream);
                    render.Dispose();
                    pdf.Close();
                    document.Close();
                    stream.Position = 0;
                    return stream;
                }
            }
            else
            {
#endif
            /*End:Server*/
            using (MemoryStream stream = new MemoryStream())
                {
                    //Save the created Word document to MemoryStream
                    document.Save(stream, type);
                    document.Close();
                    stream.Position = 0;
                    return stream;
                }
            /*Server:Block*/
#if !(WASM) && !WEBAPP
            }
#endif
            /*End:Server*/
        }
        /// <summary>
        /// Dispose the Dictionary
        /// </summary>
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