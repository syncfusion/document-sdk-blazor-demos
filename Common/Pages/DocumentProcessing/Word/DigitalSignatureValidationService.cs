using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Office;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BlazorDemos.Data.DocumentProcessing.Word
{
    public class DigitalSignatureValidationService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;

        public DigitalSignatureValidationService(
            Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        public string ValidateSignature()
        {
            StringBuilder builder =
                new StringBuilder();

            WordDocument document =
                new WordDocument(
                    fileDataValue["DigitalSignature.docx"],
                    FormatType.Docx);

            if (document.DigitalSignatures.Count > 0)
            {
                builder.AppendLine(
                    "The following digital signatures were found.");

                int index = 1;

                foreach (OfficeDigitalSignature signature
                    in document.DigitalSignatures)
                {
                    builder.AppendLine();
                    builder.AppendLine(
                        $"{index:D3}:");

                    builder.AppendLine(
                        signature.IsValid
                        ? "The signature is valid"
                        : "The signature is invalid");

                    builder.AppendLine(
                        $"Signed at : {signature.SigningTime}");

                    builder.AppendLine(
                        $"Subject name : {signature.Certificate.Subject}");

                    builder.AppendLine(
                        $"Issuer name : {signature.Certificate.Issuer}");

                    builder.AppendLine(
                        $"Valid From : {signature.Certificate.ValidFrom}");

                    builder.AppendLine(
                        $"Valid To : {signature.Certificate.ValidTo}");

                    index++;
                }
            }
            else
            {
                builder.AppendLine(
                    "No digital signatures were found.");
            }

            document.Close();

            return builder.ToString();
        }

        public void Close()
        {
            foreach (KeyValuePair<string, MemoryStream> item
                in fileDataValue)
            {
                item.Value.Dispose();
            }

            fileDataValue.Clear();
        }
    }
}
