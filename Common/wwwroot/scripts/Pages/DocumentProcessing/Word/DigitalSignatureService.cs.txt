using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Office;
using System;
using System.Collections.Generic;
using System.IO;

namespace BlazorDemos.Data.DocumentProcessing.Word
{
    public class DigitalSignatureService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;

        public DigitalSignatureService(
            Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        public MemoryStream CreateNewDocument(
            string signatureStandard,
            string signatureType,
            string certificatePath)
        {
            WordDocument document = new WordDocument();

            IWSection section = document.AddSection();

            section.AddParagraph()
                   .AppendText("Digital Signature Sample");
            //string certificatePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot","data","word","PrivateKey.pfx");
            OfficeDigitalSignatureCertificate certificate =
                new OfficeDigitalSignatureCertificate(
                    certificatePath,
                    "1234");

            SignatureSettings settings =
                new SignatureSettings()
                {
                    SignTime = DateTime.Now,
                    Comments = "Digitally signed using DocIO"
                };

            settings.XmlDsigLevel =
                signatureStandard == "XAdES"
                ? XmlDsigLevel.XAdEsEpes
                : XmlDsigLevel.XmlDSig;

            if (signatureType == "Visible")
            {
                SignatureLineSettings signatureLine =
                    new SignatureLineSettings()
                    {
                        Signer = "John Doe",
                        SignerTitle = "Manager",
                        Email = "john.doe@company.com",
                        ShowDate = true
                    };

                WPicture picture =
                    section.AddParagraph()
                           .AppendSignatureLine(
                                signatureLine,
                                192,
                                96) as WPicture;

                settings.SignatureLineId =
                    picture.SignatureLine.Id;

                settings.SignatureLineImage =
                    fileDataValue["signature.png"]
                        .ToArray();
            }

            document.AddDigitalSignature(
                certificate,
                settings);

            MemoryStream stream =
                new MemoryStream();

            document.Save(
                stream,
                FormatType.Docx);

            document.Close();

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
