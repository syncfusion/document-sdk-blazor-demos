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



namespace BlazorDemos.Data.DocumentProcessing.PowerPoint
{
    public class PPTXToMarkdownService
    {
        private readonly Dictionary<string, FileStream> fileDataValue;
        public PPTXToMarkdownService(Dictionary<string, FileStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// Convert the PowerPoint presentation to Markdown
        /// </summary>
        /// <returns>Return the resultant Markdown as stream</returns>
        public MemoryStream PPTXToMarkdown(string button)
        {
            if (button == "View Template")
            {
                // Copy into MemoryStream
                MemoryStream memoryStreamTemplate = new MemoryStream();
                fileDataValue["presentation-to-markdown.pptx"].CopyTo(memoryStreamTemplate);
                // Reset position before returning
                memoryStreamTemplate.Position = 0;
                return memoryStreamTemplate;

            }
            //Loads the template PowerPoint presentation
            IPresentation presentation = Presentation.Open(fileDataValue["presentation-to-markdown.pptx"]);

            #region Saving document
            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the Markdown to MemoryStream
                presentation.Save(stream, FormatType.Markdown);
                return stream;
            }
            #endregion
        }
        #region HelperMethod
        /// <summary>
        /// Dispose the Dictionary
        /// </summary>
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
