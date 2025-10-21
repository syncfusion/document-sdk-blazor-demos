#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.IO;
using Syncfusion.Pdf.Xfa;
using System;
using System.Collections.Generic;

namespace BlazorDemos.Data.FileFormats.PDF
{ 
    public class XFAFormFillingService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public XFAFormFillingService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public MemoryStream XFAFormFillingPDF()
        {
           
            //Load the existing XFA document.
            PdfLoadedXfaDocument ldoc = new PdfLoadedXfaDocument(fileDataValue["xfa-template.pdf"]);

            //Loaded the existing XFA form.
            PdfLoadedXfaForm? lform = ldoc.XfaForm;
           
            // Get subform references with null checks
            if (lform?.Fields["subform1[0]"] is PdfLoadedXfaForm subform1 &&
                subform1?.Fields["subform3[0]"] is PdfLoadedXfaForm subform3)
            {
                //Fill the XFA form fields.
                if (subform3.Fields?["title[0]"] is PdfLoadedXfaComboBoxField titleField)
                    titleField.SelectedIndex = 0;

                if (subform3.Fields?["fn[0]"] is PdfLoadedXfaTextBoxField fnField)
                    fnField.Text = "Simons";

                if (subform3.Fields?["ln[0]"] is PdfLoadedXfaTextBoxField lnField)
                    lnField.Text = "Bistro";

                if (subform3.Fields?["dob[0]"] is PdfLoadedXfaDateTimeField dobField)
                    dobField.Value = new DateTime(1989, 5, 21);

                if (subform3.Fields?["company[0]"] is PdfLoadedXfaTextBoxField companyField)
                    companyField.Text = "XYZ Pvt Ltd";

                if (subform3.Fields?["jt[0]"] is PdfLoadedXfaTextBoxField jtField)
                    jtField.Text = "Developer";

                if (subform3.Fields?["jd[0]"] is PdfLoadedXfaTextBoxField jdField)
                    jdField.Text = "Develop and maintain components and applications for the web, desktop and mobile platforms. \nWork with some of the best UI/UX designers in the world to craft Stunning user interfaces. \nRegular appraisals to ensure quick growth if you deliver on the job.";

                if (subform3.Fields?["st[0]"] is PdfLoadedXfaTextBoxField stField)
                    stField.Text = "Vinbaeltet 34";

                if (subform3.Fields?["ad1[0]"] is PdfLoadedXfaTextBoxField ad1Field)
                    ad1Field.Text = "Kobenhaven";

                if (subform3.Fields?["city[0]"] is PdfLoadedXfaTextBoxField cityField)
                    cityField.Text = "Denmark";

                if (subform3.Fields?["state[0]"] is PdfLoadedXfaComboBoxField stateField)
                    stateField.SelectedIndex = 1;

                if (subform3.Fields?["zip[0]"] is PdfLoadedXfaNumericField zipField)
                    zipField.NumericValue = 24534;

                if (subform3.Fields?["country[0]"] is PdfLoadedXfaTextBoxField countryField)
                    countryField.Text = "US";

                if (subform3.Fields?["em[0]"] is PdfLoadedXfaTextBoxField emField)
                    emField.Text = "simonsbistro@outlook.com";

                if (subform3.Fields?["phone[0]"] is PdfLoadedXfaNumericField phoneField)
                    phoneField.NumericValue = 8765456789;

                if (subform3.Fields?["sdn[0]"] is PdfLoadedXfaListBoxField sdnField)
                    sdnField.SelectedItems = new string[] { "Vegan", "Diary Free" };

                if (subform3.Fields?["san[0]"] is PdfLoadedXfaListBoxField sanField)
                    sanField.SelectedIndex = 0;

                if (subform3.Fields?["email[0]"] is PdfLoadedXfaCheckBoxField emailField)
                    emailField.IsChecked = true;

                if (subform3.Fields?["phone[1]"] is PdfLoadedXfaCheckBoxField phoneCheckField)
                    phoneCheckField.IsChecked = true;

                if (subform3.Fields?["group1[0]"] is PdfLoadedXfaRadioButtonGroup group1Field)
                    group1Field.Fields[1].IsChecked = true;
            }


            //Saving the PDF to the MemoryStream
            MemoryStream ms = new MemoryStream();
            ldoc.Save(ms);
            //If the position is not set to '0' then the PDF will be empty.
            ms.Position = 0;

            //Close the document
            ldoc.Close();
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
