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
    public class MarkdownToWordService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public MarkdownToWordService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// Markdown to Word document
        /// </summary>
        /// <returns>Return the created Word document as stream</returns>
        public MemoryStream MarkdownToWord(string documentType, string button)
        {
            if (button == "View Template")
            {
                return fileDataValue["markdown-to-word.md"];
            }
            WordDocument document = new WordDocument(fileDataValue["markdown-to-word.md"], FormatType.Markdown);
            FormatType formatType = FormatType.Docx;
            //Save as DOC format
            if (documentType == "DOC")
                formatType = FormatType.Doc;
			//Save as RTF format
			else if (documentType == "RTF")
                formatType = FormatType.Rtf;
			//Save as WordML format
			else if (documentType == "WordML")
                formatType = FormatType.WordML;
            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created Word document to MemoryStream
                document.Save(stream, formatType);
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