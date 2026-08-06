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
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace BlazorDemos.Data.DocumentProcessing.Markdown
{
    public class MarkdownToHTMLService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public MarkdownToHTMLService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// Markdown to HTML conversion
        /// </summary>
        /// <returns>Return the created HTML file as stream</returns>
        public MemoryStream MarkdownToHTML(string button)
        {
            if (button == "View Template")
            {
                return fileDataValue["markdown-to-word.md"];
            }
            WordDocument document = new WordDocument(fileDataValue["markdown-to-word.md"], FormatType.Markdown);
            //Save as HTML format
            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created Word document to MemoryStream
                document.Save(stream, FormatType.Html);
                document.Close();
                stream.Position = 0;
                return stream;
            }
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