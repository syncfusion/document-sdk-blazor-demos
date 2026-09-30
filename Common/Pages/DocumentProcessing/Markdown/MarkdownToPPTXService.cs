#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.Presentation;
using System.IO;
using System.Collections.Generic;



namespace BlazorDemos.Data.DocumentProcessing.Markdown
{
    public class MarkdownToPPTXService
    {
        private readonly Dictionary<string, FileStream> fileDataValue;
        public MarkdownToPPTXService(Dictionary<string, FileStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// Markdown to PowerPoint presentation
        /// </summary>
        /// <returns>Return the created PowerPoint document as stream</returns>
        public MemoryStream MarkdownToPPTX(string button)
        {
            if (button == "View Template")
            {
                // Copy into MemoryStream
                MemoryStream memoryStreamTemplate = new MemoryStream();
                fileDataValue["markdown-to-presentation.md"].CopyTo(memoryStreamTemplate);
                // Reset position before returning
                memoryStreamTemplate.Position = 0;
                return memoryStreamTemplate;
            }
            // Open the Markdown file and convert to PowerPoint presentation
            IPresentation presentation = Presentation.Open(fileDataValue["markdown-to-presentation.md"]);

            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream())
            {
                presentation.Save(stream, FormatType.Pptx);
                return stream;
            }
        }
        /// <summary>
        /// Dispose the Dictionary
        /// </summary>
        #region HelperMethod
        public void Close()
        {
            foreach (KeyValuePair<string, FileStream> item in fileDataValue)
            {
                item.Value.Dispose();
            }
            fileDataValue.Clear();
            
        }
        #endregion
    }
}
