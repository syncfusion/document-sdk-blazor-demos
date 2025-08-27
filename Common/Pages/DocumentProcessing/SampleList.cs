using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {

        public List<Sample> DocIO { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Hello World",
                Category = "Getting Started",
                Directory = "DocumentProcessing/Word",
                Url = "word/hello-world",
                FileName = "HelloWorld.razor",
                MetaTitle = "Blazor Word Example | Getting Started | Syncfusion",
                HeaderText = "Blazor Word Example - Getting Started",
                MetaDescription = "This Hello World demo shows how to create a simple Word document with text, image and table using Essential DocIO. It allows create, open and Save the document.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="HelloWorld",
                        FileName="HelloWorld.razor"
                    },
                    new SourceCollection
                    {
                        Id="HelloWorldService",
                        FileName="HelloWorldService.cs"
                    }
                }
            },
			new Sample
            {
                Name = "Sales Invoice",
                Category = "Product Showcase",
                Directory = "DocumentProcessing/Word",
                Url = "word/sales-invoice",
                FileName = "SalesInvoice.razor",
                MetaTitle = "Blazor Word Example | Product Showcase | Syncfusion",
                HeaderText = "Blazor Word Example - Sales Invoice",
                MetaDescription = "This Blazor Sales Invoice sample demonstrates the generation of sales invoice from an input Word template using Mail Merge functionality of Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="SalesInvoice",
                        FileName="SalesInvoice.razor"
                    },
                    new SourceCollection
                    {
                        Id="SalesInvoiceService",
                        FileName="SalesInvoiceService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Update Fields",
                Category = "Product Showcase",
                Directory = "DocumentProcessing/Word",
                Url = "word/update-fields",
                FileName = "UpdateFields.razor",
                MetaTitle = "Blazor Word Example | Product Showcase | Syncfusion",
                HeaderText = "Blazor Word Example - Update Fields",
                MetaDescription = "This sample shows updating fields in a Word document using Essential DocIO, combining merge and formula fields to populate net profit or loss dynamically.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="UpdateFields",
                        FileName="UpdateFields.razor"
                    },
                    new SourceCollection
                    {
                        Id="UpdateFieldsService",
                        FileName="UpdateFieldsService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Advanced Replace",
                Category = "Editing",
                Directory = "DocumentProcessing/Word",
                Url = "word/advanced-replace",
                FileName = "AdvancedReplace.razor",
                MetaTitle = "Word (DocIO) Library - Advanced Replace - Syncfusion Demos",
                MetaDescription = "This sample shows how to replace specific content in a Word document with another document using the Find and Replace feature of the Essential DocIO library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="AdvancedReplace",
                        FileName="AdvancedReplace.razor"
                    },
                    new SourceCollection
                    {
                        Id="AdvancedReplaceService",
                        FileName="AdvancedReplaceService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Bookmark Navigation",
                Category = "Editing",
                Directory = "DocumentProcessing/Word",                
                Url = "word/bookmark-navigation",
                FileName = "BookmarkNavigation.razor",
                MetaTitle = "Word (DocIO) Library Bookmark Navigation - Syncfusion Demos",
                MetaDescription = "This sample shows how to navigate between bookmarks in a Word document and edit their content using the Bookmark Navigation feature in Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="BookmarkNavigation",
                        FileName="BookmarkNavigation.razor"
                    },
                    new SourceCollection
                    {
                        Id="BookmarkNavigationService",
                        FileName="BookmarkNavigationService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Forms",
                Category = "Editing",
                Directory = "DocumentProcessing/Word",
                Url = "word/forms",
                FileName = "Forms.razor",
                MetaTitle = "Blazor Word (DocIO) Library | Forms | Syncfusion Demos",
                MetaDescription = "This demo shows how to create a simple job application form and fill the form using Essential DocIO. It allows to create a simple form using legacy form fields.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Forms",
                        FileName="Forms.razor"
                    },
                    new SourceCollection
                    {
                        Id="FormsService",
                        FileName="FormsService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Form filling and Protection",
                Category = "Content Control",
                Directory = "DocumentProcessing/Word",
                Url = "word/formfillingandprotection",
                FileName = "FormFillingAndProtection.razor",
                MetaTitle = "Blazor Word Example | Form Filling and Protection | Syncfusion",
                MetaDescription = "This Blazor Form Filling and Protection sample shows how to fill a form and protect the content controls in an existing Word document using Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="FormFillingAndProtection",
                        FileName="FormFillingAndProtection.razor"
                    },
                    new SourceCollection
                    {
                        Id="FormFillingAndProtectionService",
                        FileName="FormFillingAndProtectionService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Create Equation",
                Category = "Mathematical Equation",
                Directory = "DocumentProcessing/Word",
                Url = "word/create-equation",
                FileName = "CreateEquation.razor",
                MetaTitle = "Word (DocIO) Library - Create Equation - Syncfusion Demos",
                MetaDescription = "This Blazor Word (DocIO) Library Create Equation sample demonstrates how to create a Word document with the mathematical equations using Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CreateEquation",
                        FileName="CreateEquation.razor"
                    },
                    new SourceCollection
                    {
                        Id="CreateEquationService",
                        FileName="CreateEquationService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Edit Equation",
                Category = "Mathematical Equation",
                Directory = "DocumentProcessing/Word",
                Url = "word/edit-equation",
                FileName = "EditEquation.razor",
                MetaTitle = "Word (DocIO) Library - Edit Equation - Syncfusion Demos",
                MetaDescription = "This Blazor Word (DocIO) Library Edit Equation sample demonstrates how to modify the mathematical equation in a Word document using an Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="EditEquation",
                        FileName="EditEquation.razor"
                    },
                    new SourceCollection
                    {
                        Id="EditEquationService",
                        FileName="EditEquationService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Create using LaTeX",
                Category = "Mathematical Equation",
                Directory = "DocumentProcessing/Word",
                Url = "word/create-using-latex",
                FileName = "CreateUsingLaTeX.razor",
                MetaTitle = "Word (DocIO) Library Create using LaTeX - Syncfusion Demos",
                MetaDescription = "This Blazor Word (DocIO) library sample demonstrates how to create a Word document with mathematical equation using LaTeX using the .NET Word (DocIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CreateUsingLaTeX",
                        FileName="CreateUsingLaTeX.razor"
                    },
                    new SourceCollection
                    {
                        Id="CreateUsingLaTeXService",
                        FileName="CreateUsingLaTeXService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Edit using LaTeX",
                Category = "Mathematical Equation",
                Directory = "DocumentProcessing/Word",
                Url = "word/edit-using-latex",
                FileName = "EditUsingLaTeX.razor",
                MetaTitle = "Word (DocIO) Library Edit using LaTeX - Syncfusion Demos",
                MetaDescription = "This Blazor Word (DocIO) library sample demonstrates how to modify a mathematical equation using LaTeX in a Word document using .NET Word Library (DocIO).",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="EditUsingLaTeX",
                        FileName="EditUsingLaTeX.razor"
                    },
                    new SourceCollection
                    {
                        Id="EditUsingLaTeXService",
                        FileName="EditUsingLaTeXService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Bookmarks",
                Category = "Insert Content",
                Directory = "DocumentProcessing/Word",
                Url = "word/bookmarks",
                FileName = "Bookmarks.razor",
                MetaTitle = "Word (DocIO) Library - Bookmarks - Syncfusion Demos",
                MetaDescription = "This sample shows how to insert bookmarks into the Word document using Essential DocIO. Allows to edit, modify or delete the contents within that bookmark.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Bookmarks",
                        FileName="Bookmarks.razor"
                    },
                    new SourceCollection
                    {
                        Id="BookmarksService",
                        FileName="BookmarksService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Header and Footer",
                Category = "Insert Content",
                Directory = "DocumentProcessing/Word",
                Url = "word/header-and-footer",
                FileName = "HeaderandFooter.razor",
                MetaTitle = "Word (DocIO) Library - Header and Footer - Syncfusion Demos",
                MetaDescription = "This Blazor Word (DocIO) Library Headers and Footers sample demonstrates how to insert headers and footers to the Word document using Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="HeaderandFooter",
                        FileName="HeaderandFooter.razor"
                    },
                    new SourceCollection
                    {
                        Id="HeaderandFooterService",
                        FileName="HeaderandFooterService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Image Insertion",
                Category = "Insert Content",
                Directory = "DocumentProcessing/Word",
                Url = "word/image-insertion",
                FileName = "ImageInsertion.razor",
                MetaTitle = "Word (DocIO) Library Image Insertion - Syncfusion Demos",
                MetaDescription = "This sample demonstrates how to insert images into the Word document using Essential DocIO. Allows to insert images into Word document at desired location.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ImageInsertion",
                        FileName="ImageInsertion.razor"
                    },
                    new SourceCollection
                    {
                        Id="ImageInsertionService",
                        FileName="ImageInsertionService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Employee Report",
                Category = "Mail Merge",
                Directory = "DocumentProcessing/Word",
                Url = "word/employee-report",
                FileName = "EmployeeReport.razor",
                MetaTitle = "Word (DocIO) Library - Employee Report - Syncfusion Demos",
                MetaDescription = "This Word (DocIO) Library Employee Report sample demonstrates how to generate an employee report using the Mail merge functionality of Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="EmployeeReport",
                        FileName="EmployeeReport.razor"
                    },
                    new SourceCollection
                    {
                        Id="EmployeeReportService",
                        FileName="EmployeeReportService.cs"
                    }
                }
            },
			new Sample
            {
                Name = "Insert OLE Object",
                Category = "Insert Content",
                Directory = "DocumentProcessing/Word",
                Url = "word/insert-ole-object",
                FileName = "InsertOLEObject.razor",
                MetaTitle = "Word (DocIO) Library Insert OLE Object - Syncfusion Demos",
                MetaDescription = "This Blazor Word Library sample shows how to insert OLE Object into the Word document using Essential DocIO. Extract the OLE Object data from the Word document.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="InsertOLEObject",
                        FileName="InsertOLEObject.razor"
                    },
                    new SourceCollection
                    {
                        Id="InsertOLEObjectService",
                        FileName="InsertOLEObjectService.cs"
                    }
                },
            },
            new Sample
            {
                Name = "Letter Format",
                Category = "Mail Merge",
                Directory = "DocumentProcessing/Word",
                Url = "word/letter-format",
                FileName = "LetterFormat.razor",
                MetaTitle = "Word (DocIO) Library - Letter Format - Syncfusion Demos",
                MetaDescription = "This Blazor Word (DocIO) Library Letter Format sample demonstrates how to generate a letter using the Mail merge functionality of the Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="LetterFormat",
                        FileName="LetterFormat.razor"
                    },
                    new SourceCollection
                    {
                        Id="LetterFormatService",
                        FileName="LetterFormatService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Mail Merge Event",
                Category = "Mail Merge",
                Directory = "DocumentProcessing/Word",
                Url = "word/mail-merge-event",
                FileName = "MailMergeEvent.razor",
                MetaTitle = "Word (DocIO) Library - Mail Merge Event - Syncfusion Demos",
                MetaDescription = "This Blazor Word (DocIO )Library Mail Merge Event sample demonstrates how to format the Mail merged data using Mail merge events of the Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="MailMergeEvent",
                        FileName="MailMergeEvent.razor"
                    },
                    new SourceCollection
                    {
                        Id="MailMergeEventService",
                        FileName="MailMergeEventService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Nested Mail Merge",
                Category = "Mail Merge",
                Directory = "DocumentProcessing/Word",
                Url = "word/nested-mail-merge",
                FileName = "NestedMailMerge.razor",
                MetaTitle = "Word (DocIO) Library - Nested Mail Merge - Syncfusion Demos",
                MetaDescription = "This Word (DocIO) Library Nested Mail Merge example demonstrates how to perform the Mail merge for nested groups in Word document using Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="NestedMailMerge",
                        FileName="NestedMailMerge.razor"
                    },
                    new SourceCollection
                    {
                        Id="NestedMailMergeService",
                        FileName="NestedMailMergeService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Create SmartArt",
                Category = "SmartArts",
                Directory = "DocumentProcessing/Word",
                Url = "word/create-smartart",
                FileName = "CreateSmartArt.razor",
                MetaTitle = "Blazor Word (DocIO) Library - Create SmartArt - Syncfusion Demos",
                MetaDescription = "This Blazor Word (DocIO) Create SmartArt sample demonstrates how to create SmartArt graphics in the Blazor Word Library (DocIO). Explore here for more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CreateSmartArt",
                        FileName="CreateSmartArt.razor"
                    },
                    new SourceCollection
                    {
                        Id="CreateSmartArtService",
                        FileName="CreateSmartArtService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Edit SmartArt",
                Category = "SmartArts",
                Directory = "DocumentProcessing/Word",
                Url = "word/edit-smartart",
                FileName = "EditSmartArt.razor",
                MetaTitle = "Blazor Word (DocIO) Library - Edit SmartArt - Syncfusion Demos",
                MetaDescription = "This Blazor Word Library Edit SmartArt sample demonstrates how to edit SmartArt graphics in the Blazor Word Library (DocIO). Explore here for more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="EditSmartArt",
                        FileName="EditSmartArt.razor"
                    },
                    new SourceCollection
                    {
                        Id="EditSmartArtService",
                        FileName="EditSmartArtService.cs"
                    }
                }
            },
#if !(WASM) && !WEBAPP
            new Sample
            {
                Name = "Word to PDF",
                Category = "Import and Export",
                Directory = "DocumentProcessing/Word",
                Url = "word/word-to-pdf",
                FileName = "WordToPDF.razor",
                Type = SampleType.Updated,
                MetaTitle = "Blazor Word (DocIO) Library - Word to PDF - Syncfusion Demos",
                MetaDescription = "This Blazor Word (DocIO) Library component Word to PDF sample illustrates how to convert Word document to PDF using Essential DocIO and Essential PDF.",
                 NotificationDescription = new string[] { @"Enhanced Word to PDF and image conversions now preserve gradient fills, pattern fills, transparency fills, drawing canvas elements, and recolored pictures. Additionally, support for Arabic, Hebrew, Chinese, and Thai list number formats has been added to ensure accurate formatting."},
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WordToPDF",
                        FileName="WordToPDF.razor"
                    },
                    new SourceCollection
                    {
                        Id="WordToPDFService",
                        FileName="WordToPDFService.cs"
                    }
                }
            },
			new Sample
            {
                Name = "Word to PDF/A",
                Category = "Import and Export",
                Directory = "DocumentProcessing/Word",
                Url = "word/word-to-pdfa",
                FileName = "WordToPDFA.razor",
                Type = SampleType.Updated,
                MetaTitle = "Blazor Word (DocIO) Library - Word to PDF/A - Syncfusion Demos",
                MetaDescription = "This Blazor Word Library sample illustrates how to set the Pdf conformance level while converting Word to PDF using Essential DocIO and Essential PDF.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WordToPDFA",
                        FileName="WordToPDFA.razor"
                    },
                    new SourceCollection
                    {
                        Id="WordToPDFAService",
                        FileName="WordToPDFAService.cs"
                    }
                }
            },
			new Sample
            {
                Name = "Word to PDF/UA",
                Category = "Import and Export",
                Directory = "DocumentProcessing/Word",
                Url = "word/word-to-pdfua",
                FileName = "WordToPDFUA.razor",
                Type = SampleType.Updated,
                MetaTitle = "Blazor Word (DocIO) Library - Word to PDF/UA - Syncfusion Demos",
                MetaDescription = "This Blazor Word to PDF/UA sample illustrates how to preserve the document structured tags in the converted PDF using Essential DocIO and Essential PDF.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WordToPDFUA",
                        FileName="WordToPDFUA.razor"
                    },
                    new SourceCollection
                    {
                        Id="WordToPDFUAService",
                        FileName="WordToPDFUAService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Word to Image",
                Category = "Import and Export",
                Directory = "DocumentProcessing/Word",
                Url = "word/word-to-image",
                FileName = "WordToImage.razor",
                Type = SampleType.Updated,
                MetaTitle = "Blazor Word (DocIO) Library - Word to Image - Syncfusion Demos",
                MetaDescription = "This example demonstrates how to convert a Word document into an image using Syncfusion Essential DocIO, enabling easy visualization of document content.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WordToImage",
                        FileName="WordToImage.razor"
                    },
                    new SourceCollection
                    {
                        Id="WordToImageService",
                        FileName="WordToImageService.cs"
                    }
                }
            },
#endif
            new Sample
            {
                Name = "Word to HTML",
                Category = "Import and Export",
                Directory = "DocumentProcessing/Word",
                Url = "word/word-to-html",
                FileName = "WordToHTML.razor",
                MetaTitle = "Blazor Word (DocIO) Library - Word to HTML - Syncfusion Demos",
                MetaDescription = "This Blazor Word (DocIO) Library Word to HTML sample shows how to convert a Word document to HTML using .NET Word Library (DocIO). Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WordToHTML",
                        FileName="WordToHTML.razor"
                    },
                    new SourceCollection
                    {
                        Id="WordToHTMLService",
                        FileName="WordToHTMLService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "HTML to Word",
                Category = "Import and Export",
                Directory = "DocumentProcessing/Word",
                Url = "word/html-to-word",
                FileName = "HTMLToWord.razor",
                MetaTitle = "Blazor Word (DocIO) Library - HTML to Word - Syncfusion Demos",
                MetaDescription = "This Blazor Word (DocIO) Library HTML to Word sample shows how to convert the HTML to a Word document using .NET Word Library. Explore here to more details.",
                NotificationDescription = new string[]
                {
                    @"Now supports HTML that deviates from XML standards, enhancing document processing capabilities."
                },
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="HTMLToWord",
                        FileName="HTMLToWord.razor"
                    },
                    new SourceCollection
                    {
                        Id="HTMLToWordService",
                        FileName="HTMLToWordService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Word to Markdown",
                Category = "Import and Export",
                Directory = "DocumentProcessing/Word",
                Url = "word/word-to-markdown",
                FileName = "WordToMarkdown.razor",
                MetaTitle = "Word (DocIO) Library - Word to Markdown - Syncfusion Demos",
                MetaDescription = "This Blazor Word (DocIO) Library Word to Markdown example demonstrates how to convert the Word document to Markdown using the .NET Word (DocIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WordToMarkdown",
                        FileName="WordToMarkdown.razor"
                    },
                    new SourceCollection
                    {
                        Id="WordToMarkdownTService",
                        FileName="WordToMarkdownService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Markdown to Word",
                Category = "Import and Export",
                Directory = "DocumentProcessing/Word",
                Url = "word/markdown-to-word",
                FileName = "MarkdownToWord.razor",
                MetaTitle = "Word (DocIO) Library - Markdown to Word - Syncfusion Demos",
                MetaDescription = "This Blazor Word (DocIO) Library Markdown to Word example demonstrates how to convert the Markdown file to Word document using .NET Word (DocIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="MarkdownToWord",
                        FileName="MarkdownToWord.razor"
                    },
                    new SourceCollection
                    {
                        Id="MarkdownToWordService",
                        FileName="MarkdownToWordService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "RTF to Word",
                Category = "Import and Export",
                Directory = "DocumentProcessing/Word",
                Url = "word/rtf-to-doc",
                FileName = "RTFtoDOC.razor",
                MetaTitle = "Blazor Word (DocIO) Library - RTF to Word - Syncfusion Demos",
                MetaDescription = "This Blazor Word (DocIO) Library RTF to Word sample shows how to convert the RTF file to Word document using Essential DocIO. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RTFtoDOC",
                        FileName="RTFtoDOC.razor"
                    },
                    new SourceCollection
                    {
                        Id="RTFtoDOCService",
                        FileName="RTFtoDOCService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Word to WordML",
                Category = "Import and Export",
                Directory = "DocumentProcessing/Word",
                Url = "word/word-to-wordml",
                FileName = "WordToWordML.razor",
                MetaTitle = "Word (DocIO) Library - Word to WordML - Syncfusion Demos",
                MetaDescription = "This Blazor Word (DocIO) Library Word to WordML example demonstrates how to convert the Word document to Word processing XML using the Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WordToWordML",
                        FileName="WordToWordML.razor"
                    },
                    new SourceCollection
                    {
                        Id="WordToWordMLService",
                        FileName="WordToWordMLService.cs"
                    }
                }
            },
			new Sample
            {
                Name = "WordML to Word",
                Category = "Import and Export",
                Directory = "DocumentProcessing/Word",
                Url = "word/wordml-to-word",
                FileName = "WordMLtoWord.razor",
                MetaTitle = "Blazor Word (DocIO) Library - WordML to Word - Syncfusion Demos",
                MetaDescription = "This Blazor Word (DocIO) Library WordML to Word example demonstrates how to convert the Word processing XML to Word document using the Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WordMLtoWord",
                        FileName="WordMLtoWord.razor"
                    },
                    new SourceCollection
                    {
                        Id="WordMLtoWordService",
                        FileName="WordMLtoWordService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Word to ODT",
                Category = "Import and Export",
                Directory = "DocumentProcessing/Word",
                Url = "word/word-to-odt",
                FileName = "WordToODT.razor",
                MetaTitle = "Blazor Word (DocIO) Library - Word to ODT - Syncfusion Demos",
                MetaDescription = "This Blazor Word (DocIO) Library Word to ODT sample demonstrates how to convert the Word document to ODT using Essential DocIO. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WordToODT",
                        FileName="WordToODT.razor"
                    },
                    new SourceCollection
                    {
                        Id="WordToODTService",
                        FileName="WordToODTService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Track Changes",
                Category = "Review",
                Directory = "DocumentProcessing/Word",
                Url = "word/track-changes",
                FileName = "TrackChanges.razor",
                MetaTitle = "Blazor Word (DocIO) Library - Track Changes - Syncfusion Demos",
                MetaDescription = "This Blazor Word (DocIO) Library Track Changes sample demonstrates how to accept or reject the tracked changes in the Word document using Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TrackChanges",
                        FileName="TrackChanges.razor"
                    },
                    new SourceCollection
                    {
                        Id="TrackChangesService",
                        FileName="TrackChangesService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Compare Documents",
                Category = "Review",
                Directory = "DocumentProcessing/Word",
                Url = "word/compare-documents",
                FileName = "CompareDocuments.razor",
                MetaTitle = "Word (DocIO) Library Compare Documents - Syncfusion Demos",
                MetaDescription = "This Blazor Word Library Compare Documents example demonstrates comparing two Word documents in Blazor Word (DocIO) Library. Explore here for more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CompareDocuments",
                        FileName="CompareDocuments.razor"
                    },
                    new SourceCollection
                    {
                        Id="CompareDocumentsService",
                        FileName="CompareDocumentsService.cs"
                    }
                }
            },
#if !(WASM) && !WEBAPP
            new Sample
            {
                Name = "Table of Content",
                Category = "Reference",
                Directory = "DocumentProcessing/Word",
                Url = "word/table-of-content",
                FileName = "TableofContent.razor",
                MetaTitle = "Blazor Word (DocIO) Library - Table of Content - Syncfusion Demos",
                MetaDescription = "DocIO supports to insert Table of Contents based on custom and default heading styles, include page numbers, hyperlinks to easily navigate to specific topic.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TableofContent",
                        FileName="TableofContent.razor"
                    },
                    new SourceCollection
                    {
                        Id="TableofContentService",
                        FileName="TableofContentService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Table of Figures",
                Category = "Reference",
                Directory = "DocumentProcessing/Word",
                Url = "word/table-of-figures",
                FileName = "TableOfFigures.razor",
                MetaTitle = "Blazor Word (DocIO) Library - Table of Figures - Syncfusion Demos",
                MetaDescription = "This Blazor Word Library Table of Figures sample demonstrates how to insert and update the table of figures in a Word document using .NET Word Library (DocIO).",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TableOfFigures",
                        FileName="TableOfFigures.razor"
                    },
                    new SourceCollection
                    {
                        Id="TableOfFiguresService",
                        FileName="TableOfFiguresService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Encrypt and Decrypt",
                Category = "Security",
                Directory = "DocumentProcessing/Word",
                Url = "word/encrypt-and-decrypt",
                FileName = "EncryptDecrypt.razor",
                MetaTitle = "Blazor Word (DocIO) Library - Encrypt and Decrypt - Syncfusion Demos",
                MetaDescription = "This Blazor Word Library demo supports to encrypt a Word document with password that restrict others from accessing or modifying confidential contents.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="EncryptDecrypt",
                        FileName="EncryptDecrypt.razor"
                    },
                    new SourceCollection
                    {
                        Id="EncryptDecryptService",
                        FileName="EncryptDecryptService.cs"
                    }
                }
            },
#endif
            new Sample
            {
                Name = "Document Protection",
                Category = "Security",
                Directory = "DocumentProcessing/Word",
                Url = "word/document-protection",
                FileName = "DocumentProtection.razor",
                MetaTitle = "Blazor Word (DocIO) Library - Document Protection - Syncfusion Demos",
                MetaDescription = "This Blazor Word (DocIO) Library Document Production example shows how to encrypt a Word document with the document protection. Explore here to more details.",
                NotificationDescription = new string[]
                {
                    @"Added support for adding editable ranges in protected DOCX format documents to allow specific parts to remain editable."
                },
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="DocumentProtection",
                        FileName="DocumentProtection.razor"
                    },
                    new SourceCollection
                    {
                        Id="DocumentProtectionService",
                        FileName="DocumentProtectionService.cs"
                    }
                }
            }
        };
        public List<Sample> Presentation { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Create Presentation",
                Category = "Getting Started",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/getting-started",
                FileName = "GettingStarted.razor",
                MetaTitle = "PowerPoint Library - Create Presentation - Syncfusion Demos",
                MetaDescription = "This sample demonstrates how to create slides with simple text in a PowerPoint presentation. It allows create, edit text or shapes in the preview pages.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="GettingStarted",
                        FileName="GettingStarted.razor"
                    },
                    new SourceCollection
                    {
                        Id="GettingStartedService",
                        FileName="GettingStartedService.cs"
                    }
                }
            },
#if !(WASM) && !WEBAPP
            new Sample
            {
                Name = "PPTX To Image",
                Category = "Conversion",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/pptx-to-image",
                FileName = "PPTXToImage.razor",
                MetaTitle = "PowerPoint Library - PPTX To Image - Syncfusion Demos",
                MetaDescription = "This sample demonstrates how to convert the PowerPoint slide to an image. It convert all slide elements like text, shape, SmartArt diagram, and table.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="PPTXToImage",
                        FileName="PPTXToImage.razor"
                    },
                    new SourceCollection
                    {
                        Id="PPTXToImageService",
                        FileName="PPTXToImageService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "PPTX To PDF",
                Category = "Conversion",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/pptx-to-pdf",
                FileName = "PPTXToPDF.razor",
                NotificationDescription = new string[]
                {
                    @"Added support for preserving shapes as editable text form fields during PowerPoint to PDF conversion."
                },
                MetaTitle = "PowerPoint Library - PPTX To PDF - Syncfusion Demos",
                MetaDescription = "This sample demonstrates how to convert a PowerPoint presentation to PDF. It convert all slide elements like text, shape, SmartArt diagram, and table.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="PPTXToPDF",
                        FileName="PPTXToPDF.razor"
                    },
                    new SourceCollection
                    {
                        Id="PPTXToPDFService",
                        FileName="PPTXToPDFService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "PPTX To PDF/A",
                Category = "Conversion",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/pptx-to-pdfa",
                FileName = "PPTXToPDFA.razor",
                MetaTitle = "PowerPoint Library - PPTX To PDF/A - Syncfusion Demos",
                MetaDescription = "This PPTX to PDF/A example shows how to set the PDF conformance level while converting the PowerPoint presentation to PDF. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="PPTXToPDFA",
                        FileName="PPTXToPDFA.razor"
                    },
                    new SourceCollection
                    {
                        Id="PPTXToPDFAService",
                        FileName="PPTXToPDFAService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "PPTX To PDF/UA",
                Category = "Conversion",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/pptx-to-pdfua",
                FileName = "PPTXToPDFUA.razor",
                MetaTitle = "PowerPoint Library - PPTX To PDF/UA - Syncfusion Demos",
                MetaDescription = "This Blazor PowerPoint PPTX to PDF/UA sample demonstrates how to preserve the document structured tags in the converted PDF. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="PPTXToPDFUA",
                        FileName="PPTXToPDFUA.razor"
                    },
                    new SourceCollection
                    {
                        Id="PPTXToPDFUAService",
                        FileName="PPTXToPDFUAService.cs"
                    }
                }
            },
#endif
	    new Sample
            {
                Name = "Find and Replace",
                Category = "Editing",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/find-and-replace",
                FileName = "FindAndReplace.razor",
                MetaTitle = "PowerPoint Library - Find and Replace - Syncfusion Demos",
                MetaDescription = "This sample shows how to replace specific text in a PowerPoint presentation using the Find and Replace feature of the .NET PowerPoint library efficiently.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="FindToReplace",
                        FileName="FindAndReplace.razor"
                    },
                    new SourceCollection
                    {
                        Id="FindAndReplaceService",
                        FileName="FindAndReplaceService.cs"
                    }
                }
            },
	    new Sample
            {
                Name = "Find and Highlight",
                Category = "Editing",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/find-and-highlight",
                FileName = "FindAndHighlight.razor",
                MetaTitle = "PowerPoint Find & Highlight Example - Syncfusion Demos",
                MetaDescription = "This sample shows how to find specific text and highlight it in an existing PowerPoint presentation using the Find feature of the .NET PowerPoint library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="FindToHighlight",
                        FileName="FindAndHighlight.razor"
                    },
                    new SourceCollection
                    {
                        Id="FindAndHighlightService",
                        FileName="FindAndHighlightService.cs"
                    }
                }
            },
#if !(WASM) && !WEBAPP
            new Sample
            {
                Name = "Encrypt and Decrypt",
                Category = "Security",
                Directory = "DocumentProcessing/PowerPoint",
                Type = SampleType.None,
                Url = "powerpoint/encrypt-and-decrypt",
                MetaTitle = "Blazor PowerPoint Library Encrypt and Decrypt - Syncfusion Demos",
                MetaDescription = "This Blazor PowerPoint Encrypt and Decrypt example demonstrates how to encrypt and decrypt the PowerPoint documents using the Essential Presentations.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="EncryptAndDecrypt",
                        FileName="EncryptAndDecrypt.razor"
                    },
                    new SourceCollection
                    {
                        Id="EncryptAndDecryptService",
                        FileName="EncryptAndDecryptService.cs"
                    }
                },
                FileName = "EncryptAndDecrypt.razor"
            },
            new Sample
            {
                Name = "Write Protection",
                Category = "Security",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/write-protection",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WriteProtection",
                        FileName="WriteProtection.razor"
                    },
                    new SourceCollection
                    {
                        Id="WriteProtectionService",
                        FileName="WriteProtectionService.cs"
                    }
                },
                FileName = "WriteProtection.razor",
                MetaTitle = "Blazor PowerPoint Library Write Protection - Syncfusion Demos",
                MetaDescription = "This Blazor PowerPoint Write Protection example shows how to set write protection for a PowerPoint presentation with password. Explore here to more details."
            },
#endif
            new Sample
            {
                Name = "Image",
                Category = "Slide Elements",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/image",
                FileName = "Image.razor",
                MetaTitle = "Blazor PowerPoint Library: Image Example - Syncfusion Demos",
                MetaDescription = "This Blazor PowerPoint Image example demonstrates how to add and format images in PowerPoint Presentation using .NET PowerPoint Library (Presentation).",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Image",
                        FileName="Image.razor"
                    },
                    new SourceCollection
                    {
                        Id="ImageService",
                        FileName="ImageService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Chart",
                Category = "Slide Elements",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/chart",
                FileName = "Chart.razor",
                MetaTitle = "PowerPoint Library - Chart Example - Syncfusion Demos",
                MetaDescription = "This Blazor PowerPoint chart example shows how to create charts in a presentation using PowerPoint presentation using .NET PowerPoint Library (Presentation).",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Chart",
                        FileName="Chart.razor"
                    },
                    new SourceCollection
                    {
                        Id="ChartService",
                        FileName="ChartService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Slide",
                Category = "Slide Elements",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/slide",
                FileName = "Slide.razor",
                MetaTitle = "Blazor PowerPoint Library Slide Example - Syncfusion Demos",
                MetaDescription = "This Blazor PowerPoint Slide example shows how to create slides with simple text, table and image in a PowerPoint presentation using .NET PowerPoint Library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Slide",
                        FileName="Slide.razor"
                    },
                    new SourceCollection
                    {
                        Id="SlideService",
                        FileName="SlideService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "SmartArt",
                Category = "Slide Elements",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/smartart",
                FileName = "SmartArt.razor",
                MetaTitle = "PowerPoint Library - SmartArt Example - Syncfusion Demos",
                MetaDescription = "This Blazor PowerPoint SmartArt example demonstrates how to create the SmartArt diagram in a PowerPoint presentation using the .NET PowerPoint Library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="SmartArt",
                        FileName="SmartArt.razor"
                    },
                    new SourceCollection
                    {
                        Id="SmartArtService",
                        FileName="SmartArtService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Table",
                Category = "Slide Elements",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/table",
                FileName = "Table.razor",
                MetaTitle = "PowerPoint Library - Table Example - Syncfusion Demos",
                MetaDescription = "This Blazor PowerPoint Table example shows how to add tables in a PowerPoint presentation using the .NET PowerPoint Library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Table",
                        FileName="Table.razor"
                    },
                    new SourceCollection
                    {
                        Id="TableService",
                        FileName="TableService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Comment",
                Category = "Slide Elements",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/comment",
                FileName = "Comment.razor",
                MetaTitle = "PowerPoint Library - Comment Example - Syncfusion Demos",
                MetaDescription = "This Blazor PowerPoint Comment sample shows how to add comments to a PowerPoint presentation slide. It supports add, reply, edit comments in powerpoint slide.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Comment",
                        FileName="Comment.razor"
                    },
                    new SourceCollection
                    {
                        Id="CommentService",
                        FileName="CommentService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Connector",
                Category = "Slide Elements",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/connector",
                FileName = "Connector.razor",
                MetaTitle = "PowerPoint Library - Connector Example - Syncfusion Demos",
                MetaDescription = "This Blazor Connector sample demonstrates how to insert the connectors in a PowerPoint slide. It support to insert, edit, remove, clone, and convert connectors.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Connector",
                        FileName="Connector.razor"
                    },
                    new SourceCollection
                    {
                        Id="ConnectorService",
                        FileName="ConnectorService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "OLE Object",
                Category = "Slide Elements",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/ole-object",
                FileName = "OLEObject.razor",
                MetaTitle = "PowerPoint Library - OLE Object Example - Syncfusion Demos",
                MetaDescription = "This Blazor OLE Object example shows how to insert and open a OLE Object in PowerPoint presentation using Powerpoint Library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="OLEObject",
                        FileName="OLEObject.razor"
                    },
                    new SourceCollection
                    {
                        Id="OLEObjectService",
                        FileName="OLEObjectService.cs"
                    }
                }
            },            
            new Sample
            {
                Name = "Create Animation",
                Category = "Animation",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/create-animation",
                FileName = "CreateAnimation.razor",
                MetaTitle = "PowerPoint Library Create Animation - Syncfusion Demos",
                MetaDescription = "This Blazor PowerPoint Create Animation demo shows how to add the different animation effect for shapes using powerpoint library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CreateAnimation",
                        FileName="CreateAnimation.razor"
                    },
                    new SourceCollection
                    {
                        Id="CreateAnimationService",
                        FileName="CreateAnimationService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Modify Animation",
                Category = "Animation",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/modify-animation",
                FileName = "ModifyAnimation.razor",
                MetaTitle = "PowerPoint Library - Modify Animation - Syncfusion Demos",
                MetaDescription = "This Blazor PowerPoint modify Animation sample shows how to modify the animation effect for shapes using powerpoint library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ModifyAnimation",
                        FileName="ModifyAnimation.razor"
                    },
                    new SourceCollection
                    {
                        Id="ModifyAnimationService",
                        FileName="ModifyAnimationService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Slide Transition",
                Category = "Transition",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/slide-transition",
                FileName = "SlideTransition.razor",
                MetaTitle = "PowerPoint Library - Slide Transition - Syncfusion Demos",
                MetaDescription = "This sample demonstrates how to create slide transition effects in PowerPoint presentation using the powerpoint library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="SlideTransition",
                        FileName="SlideTransition.razor"
                    },
                    new SourceCollection
                    {
                        Id="SlideTransitionService",
                        FileName="SlideTransitionService.cs"
                    }
                }
            }		
        };

        public List<Sample> XlsIO { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Create",
                Category = "Getting Started",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/create-excel",
                MetaTitle = "Excel (XlsIO) Library Create Example - Syncfusion Demos",
                MetaDescription = "This Excel (XlsIO) Create sample demonstrates how to create a simple spreadsheet document using .NET Excel (XlsIO) library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Create",
                        FileName="Create.razor"
                    },
                    new SourceCollection
                    {
                        Id="CreateService",
                        FileName="CreateService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Attendance Tracker",
                Category = "Product Showcase",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/attendance-tracker",
                MetaTitle = "Excel (XlsIO) Library Attendance Tracker - Syncfusion Demos",
                MetaDescription = "This Excel Attendance Tracker sample demonstrates how to use AttendanceTracker in spreadsheets using .NET Excel (XlsIO) library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="AttendanceTracker",
                        FileName="AttendanceTracker.razor"
                    },
                    new SourceCollection
                    {
                        Id="AttendanceTrackerService",
                        FileName="AttendanceTrackerService.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Call Center Dashboard",
                Category = "Product Showcase",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/call-center-dashboard",
                MetaTitle = "Excel Library - Call Center Dashboard - Syncfusion Demos",
                MetaDescription = "This Excel CellCenterDashboard sample shows how to use CallCenterDashboard in spreadsheets using .NET Excel (XlsIO) library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CallCenterDashboard",
                        FileName="CallCenterDashboard.razor"
                    },
                    new SourceCollection
                    {
                        Id="CallCenterDashboardService",
                        FileName="CallCenterDashboardService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Expenses Report",
                Category = "Product Showcase",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/expenses-report",
                MetaTitle = "Excel (XlsIO) Library - Expenses Report - Syncfusion Demos",
                MetaDescription = "This sample demonstrates how to create a simple Excel report for expenses with data, chart, formula, and cell formatting using .NET Excel (XlsIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ExpensesReport",
                        FileName="ExpensesReport.razor"
                    },
                    new SourceCollection
                    {
                        Id="ExpensesReportService",
                        FileName="ExpensesReportService.cs"
                    }
                }
            },
			new Sample
            {
                Name = "Yearly Sales",
                Category = "Product Showcase",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/yearly-sales",
                MetaTitle = "Excel (XlsIO) Library - Yearly Sales - Syncfusion Demos",
                MetaDescription = "This sample demonstrates how to create a simple Excel report for yearly sales with data, charts, formulas, and cell formatting using .NET Excel (XlsIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="YearlySales",
                        FileName="YearlySales.razor"
                    },
                    new SourceCollection
                    {
                        Id="YearlySalesService",
                        FileName="YearlySalesService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Format Cells",
                Category = "Formatting",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/format-cells",
                MetaTitle = "Excel (XlsIO) Library Format Cells - Syncfusion Demos",
                MetaDescription = "This Excel (XlsIO) Format Cells sample demonstrates how to apply formatting to the cells using .NET Excel (XlsIO) library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="FormatCells",
                        FileName="FormatCells.razor"
                    },
                    new SourceCollection
                    {
                        Id="FormatCellsService",
                        FileName="FormatCellsService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Conditional Formatting",
                Category = "Formatting",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/conditional-formatting",
                MetaTitle = "XlsIO Library Conditional Formatting - Syncfusion Demos",
                MetaDescription = "This Blazor Excel Conditional Formatting sample demonstrates how to apply conditional formats using .NET Excel (XlsIO) library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ConditionalFormatting",
                        FileName="ConditionalFormatting.razor"
                    },
                    new SourceCollection
                    {
                        Id="ConditionalFormattingService",
                        FileName="ConditionalFormattingService.cs"
                    }
                }
            },
			new Sample
            {
                Name = "Collection Objects",
                Category = "Data Binding",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/collection-objects",
                MetaTitle = "Excel (XlsIO) Library Collection Objects - Syncfusion Demos",
                MetaDescription = "This Blazor Excel Collection Objects sample demonstrates how to use Collection Objects in spreadsheets using Essential XlsIO. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CollectionObjects",
                        FileName="CollectionObjects.razor"
                    },
                    new SourceCollection
                    {
                        Id="CollectionObjects",
                        FileName="CollectionObjectsService.cs"
                    }
                }
            },
			new Sample
            {
                Name = "Import Export Data Table",
                Category = "Data Binding",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/import-export-data-table",
                MetaTitle = "Excel Library - Import Export Data Table - Syncfusion Demos",
                MetaDescription = "This Blazor Excel sample demonstrates exporting data from Excel to a data table, and import data from the data table to the Grid. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ImportExportDataTable",
                        FileName="ImportExportDataTable.razor"
                    },
                    new SourceCollection
                    {
                        Id="ImportExportDataTable",
                        FileName="ImportExportDataTableService.cs"
                    }
                }
            },
			new Sample
            {
                Name = "Import HTML Table",
                Category = "Data Binding",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/import-html-table",
                MetaTitle = "Excel (XlsIO) Library Import HTML Table - Syncfusion Demos",
                MetaDescription = "This Blazor Excel (XlsIO) Import HTML Table sample demonstrates how to import HTML table to worksheet using Essential XlsIO. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ImportHTMLTable",
                        FileName="ImportHTMLTable.razor"
                    },
                    new SourceCollection
                    {
                        Id="ImportHTMLTable",
                        FileName="ImportHTMLTableService.cs"
                    }
                }
            },
			new Sample
            {
                Name = "Template Marker",
                Category = "Data Binding",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/template-marker",
                MetaTitle = "Excel (XlsIO) Library - Template Marker - Syncfusion Demos",
                MetaDescription = "The sample demonstrates how to import data to a predefined Excel template using template marker in Excel (XlsIO) library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TemplateMarker",
                        FileName="TemplateMarker.razor"
                    },
                    new SourceCollection
                    {
                        Id="TemplateMarker",
                        FileName="TemplateMarkerService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Chart Worksheet",
                Category = "Charts",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/chart-worksheet",
                MetaTitle = "Excel (XlsIO) Library - Chart Worksheet - Syncfusion Demos",
                MetaDescription = "This Blazor Excel Chart Worksheet sample demonstrates how to create a simple chart sheet using .NET Excel (XlsIO) library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ChartWorksheet",
                        FileName="ChartWorksheet.razor"
                    },
                    new SourceCollection
                    {
                        Id="ChartWorksheetService",
                        FileName="ChartWorksheetService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Embedded Chart",
                Category = "Charts",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/embedded-chart",
                MetaTitle = "Excel (XlsIO) Library - Embedded Chart - Syncfusion Demos",
                MetaDescription = "This Blazor Excel (XlsIO) Embedded Chart sample demonstrates how to create a simple chart using .NET Excel (XlsIO) library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="EmbeddedChart",
                        FileName="EmbeddedChart.razor"
                    },
                    new SourceCollection
                    {
                        Id="EmbeddedChartService",
                        FileName="EmbeddedChartService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Sparklines",
                Category = "Charts",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/sparklines",
                MetaTitle = "Excel (XlsIO) Library - Sparklines - Syncfusion Demos",
                MetaDescription = "This Blazor Excel (XlsIO) Sparklines sample demonstrates how to create sparkline charts using .NET Excel (XlsIO) library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Sparklines",
                        FileName="Sparklines.razor"
                    },
                    new SourceCollection
                    {
                        Id="SparklinesService",
                        FileName="SparklinesService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Formulas",
                Category = "Excel Formulas",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/formulas",
                MetaTitle = "Excel (XlsIO) Library - Formulas - Syncfusion Demos",
                MetaDescription = "This Blazor Excel (XlsIO) Formulas sample demonstrates how to use formulas in spreadsheets using .NET Excel (XlsIO) library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Formulas",
                        FileName="Formulas.razor"
                    },
                    new SourceCollection
                    {
                        Id="FormulasService",
                        FileName="FormulasService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Data Validation",
                Category = "Data Management",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/data-validation",
                MetaTitle = "Excel (XlsIO) Library - Data Validation - Syncfusion Demos",
                MetaDescription = "This Blazor Excel Data Validation sample demonstrates how to use data validation in spreadsheets using .NET Excel (XlsIO) library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="DataValidation",
                        FileName="DataValidation.razor"
                    },
                    new SourceCollection
                    {
                        Id="DataValidationService",
                        FileName="DataValidationService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Form Controls",
                Category = "Data Management",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/form-controls",
                MetaTitle = "Excel (XlsIO) Library - Form Controls - Syncfusion Demos",
                MetaDescription = "This Blazor Excel Form Controls sample demonstrates how to use form controls in spreadsheet using .NET Excel (XlsIO) library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="FormControls",
                        FileName="FormControls.razor"
                    },
                    new SourceCollection
                    {
                        Id="FormControlsService",
                        FileName="FormControlsService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Slicer",
                Category = "Data Management",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/slicer",
                MetaTitle = "Blazor Excel (XlsIO) Library - Slicer - Syncfusion Demos",
                MetaDescription = "This Blazor Excel (XlsIO) Slicer example demonstrates how to create and use the slicers using .NET Excel (XlsIO) library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Slicer",
                        FileName="Slicer.razor"
                    },
                    new SourceCollection
                    {
                        Id="SlicerService",
                        FileName="SlicerService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Auto Fill & Fill Series",
                Category = "Data Management",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/fillOption",
                MetaTitle = "Blazor Excel Library - Auto Fill & Fill Series - Syncfusion Demos",
                MetaDescription = "This Blazor Excel Auto Fill & Fill Series sample demonstrates how to use the Auto Fill and Fill Series options with XlsIO. Explore here to more details.",
                NotificationDescription = new string[]
                {
                    @"This demo showcases the Auto Fill and Fill Series features of the Excel library, which allow users to programmatically populate cells based on predefined patterns, series, or trends."
                },
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="AutoFill",
                        FileName="AutoFill.razor"
                    },
                    new SourceCollection
                    {
                        Id="AutoFillService",
                        FileName="AutoFillService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "What-If Analysis" ,
                Category = "Data Management",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/WhatIfAnalysis",
                MetaTitle = "Excel (XlsIO) Library What-If Analysis - Syncfusion Demos",
                MetaDescription = "The Blazor Excel sample shows how to create different scenarios of What-If Analysis in Blazor using .NET Excel (XlsIO) library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WhatIfAnalysis",
                        FileName="WhatIfAnalysis.razor"
                    },
                    new SourceCollection
                    {
                        Id="WhatIfAnalysisService",
                        FileName="WhatIfAnalysisService.cs"
                    }
                }
            },
#if !WASM && !WEBAPP
            new Sample
            {
                Name = "Worksheet To Image",
                Category = "Conversions",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/worksheet-to-image",
                MetaTitle = "Excel (XlsIO) Library - Worksheet To Image - Syncfusion Demos",
                MetaDescription = "This Blazor Excel WorkSheet to Image sample demonstrates how to convert worksheets to image using .NET Excel (XlsIO) library. Explore here to more details.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WorksheetToImage",
                        FileName="WorksheetToImage.razor"
                    },
                    new SourceCollection
                    {
                        Id="WorksheetToImageService",
                        FileName="WorksheetToImageService.cs"
                    }
                }
            },
#endif
            new Sample
            {
                Name = "Worksheet To HTML",
                Category = "Conversions",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/worksheet-to-html",
                MetaTitle = "Excel Library Worksheet to HTML Example - Syncfusion Demos",
                MetaDescription = "This Blazor Excel (XlsIO) WorkSheet to HTML sample demonstrates how to convert Worksheets to html files using Essential XlsIO. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WorksheetToHTML",
                        FileName="WorksheetToHTML.razor"
                    },
                    new SourceCollection
                    {
                        Id="WorksheetToHTMLService",
                        FileName="WorksheetToHTMLService.cs"
                    }
                }
            },
#if !WASM && !WEBAPP
            new Sample
            {
                Name = "Excel To PDF",
                Category = "Conversions",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/excel-to-pdf",
                Type = SampleType.Updated,
                MetaTitle = "Excel (XlsIO) Library - Excel To PDF - Syncfusion Demos",
                MetaDescription = "This Blazor Excel component Excel to PDF sample demonstrates the conversion of Excel documents to pdf file using Essential XlsIO. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ExcelToPDF",
                        FileName="ExcelToPDF.razor"
                    },
                    new SourceCollection
                    {
                        Id="ExcelToPDFService",
                        FileName="ExcelToPDFService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Excel to PDF/UA",
                Category = "Conversions",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/excel-to-pdf-ua",
                Type = SampleType.Updated,
                NotificationDescription = new string[]
                {
                    @"Converting Excel documents to PDF with PDF/UA standard compliance is now supported. This ensures that users who rely on accessibility tools can effectively read the content of these PDF documents."
                },
                MetaTitle = "Excel (XlsIO) Library - Excel To PDF/UA - Syncfusion Demos",
                MetaDescription = "This Blazor Excel (XlsIO) component Excel to PDF/UA example demonstrates how to create the macros using the Excel (XlsIO). Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ExcelToPDFUA",
                        FileName="ExcelToPDFUA.razor"
                    },
                    new SourceCollection
                    {
                        Id="ExcelToPDFUAService",
                        FileName="ExcelToPDFUAService.cs"
                    }
                }
            },
#endif
			new Sample
            {
                Name = "Excel To JSON",
                Category = "Conversions",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/excel-to-json",
                MetaTitle = "Excel (XlsIO) Library Excel To JSON - Syncfusion Demos",
                MetaDescription = "This Blazor Excel to JSON sample demonstrates the conversion of Excel documents to JSON file using Essential Excel (XlsIO). Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ExcelToJSON",
                        FileName="ExcelToJSON.razor"
                    },
                    new SourceCollection
                    {
                        Id="ExcelToJSONService",
                        FileName="ExcelToJSONService.cs"
                    }
                }
            },
			new Sample
            {
                Name = "Excel To TSV",
                Category = "Conversions",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/excel-to-tsv",
                MetaTitle = "Excel (XlsIO) Library Excel To TSV - Syncfusion Demos",
                MetaDescription = "This Blazor Excel to TSV sample demonstrates how to convert Excel documents to TSV documents using Essential Excel (XlsIO). Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ExcelToTSV",
                        FileName="ExcelToTSV.razor"
                    },
                    new SourceCollection
                    {
                        Id="ExcelToTSVService",
                        FileName="ExcelToTSVService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "CSV To Excel",
                Category = "Conversions",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/csv-to-excel",
                MetaTitle = "Blazor Excel Library - CSV To Excel - Syncfusion Demos",
                MetaDescription = "This Blazor CSV to Excel example demonstrates how to convert the CSV files to Excel files using Essential Excel (XlsIO). Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CSVToExcel",
                        FileName="CSVToExcel.razor"
                    },
                    new SourceCollection
                    {
                        Id="CSVToExcelService",
                        FileName="CSVToExcelService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Excel To CSV",
                Category = "Conversions",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/excel-to-csv",
                MetaTitle = "Blazor Excel Library - Excel To CSV - Syncfusion Demos",
                MetaDescription = "This Blazor Excel to CSV example demonstrates how to convert the Excel files to CSV files using Essential Excel (XlsIO). Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ExcelToCSV",
                        FileName="ExcelToCSV.razor"
                    },
                    new SourceCollection
                    {
                        Id="ExcelToCSVService",
                        FileName="ExcelToCSVService.cs"
                    }
                }
            },
#if !WASM && !WEBAPP
            new Sample
            {
                Name = "Encrypt and Decrypt",
                Category = "Settings",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/encrypt-and-decrypt",
                MetaTitle = "Excel (XlsIO) Library Encrypt and Decrypt - Syncfusion Demos",
                MetaDescription  = "This Blazor Excel Encrypt and Decrypt sample demonstrates how to encrypt and decrypt workbooks using .NET Excel (XlsIO) library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="EncryptAndDecrypt",
                        FileName="EncryptAndDecrypt.razor"
                    },
                    new SourceCollection
                    {
                        Id="EncryptAndDecryptService",
                        FileName="EncryptAndDecryptService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Workbook Protection",
                Category = "Settings",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/workbook-protection",
                MetaTitle = "Excel (XlsIO) Library Workbook Protection - Syncfusion Demos",
                MetaDescription  = "This Blazor Excel Workbook Protection sample demonstrates how to set protection for a workbook using Excel (XlsIO) Library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WorkbookProtection",
                        FileName="WorkbookProtection.razor"
                    },
                    new SourceCollection
                    {
                        Id="WorkbookProtectionService",
                        FileName="WorkbookProtectionService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Worksheet Protection",
                Category = "Settings",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/worksheet-protection",
                MetaTitle = "Excel (xlsIO) Library Worksheet Protection - Syncfusion Demos",
                MetaDescription  = "This Blazor Excel Worksheet Protection sample demonstrates how to Lock and Unlock spreadsheets using Excel (XlsIO) Library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WorksheetProtection",
                        FileName="WorksheetProtection.razor"
                    },
                    new SourceCollection
                    {
                        Id="WorksheetProtectionService",
                        FileName="WorksheetProtectionService.cs"
                    }
                }
            },
#endif 
            new Sample
            {
                Name = "Tables",
                Category = "Business Intelligence",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/tables",
                MetaTitle = "Blazor Excel (xlsIO) Library Tables - Syncfusion Demos",
                MetaDescription = "This Blazor Excel Tables example deomonstrates how to use the tables in spreadsheets using the .NET Excel (XlsIO) library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Tables",
                        FileName="Tables.razor"
                    },
                    new SourceCollection
                    {
                        Id="TablesService",
                        FileName="TablesService.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Pivot Table",
                Category = "Business Intelligence",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/PivotTable",
                MetaTitle = "Blazor Excel (xlsIO) Pivot Table - Syncfusion Demos",
                MetaDescription = " This Blazor Excel Pivot Table example shows how to use the pivot table in spreadsheets using the .NET Excel (XlsIO) library. Explore here to more details.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="PivotTable",
                        FileName="PivotTable.razor"
                    },
                    new SourceCollection
                    {
                        Id="PivotTableService",
                        FileName="PivotTableService.cs"
                    }
                }
            },
			new Sample
            {
                Name = "Pivot Table Layout",
                Category = "Business Intelligence",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/PivotTableLayout",
                MetaTitle = "Excel (XlsIO) Library Pivot Table Layout - Syncfusion Demos",
                MetaDescription = " This Pivot Table Layout example shows how to use the pivot table layout in spreadsheets using the .NET Excel (XlsIO) library. Explore here to more details.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="PivotTableLayout",
                        FileName="PivotTableLayout.razor"
                    },
                    new SourceCollection
                    {
                        Id="PivotTableLayoutService",
                        FileName="PivotTableLayoutService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "AutoShapes",
                Category = "Shapes",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/autoshapes",
                MetaTitle = "Blazor Excel (xlsIO) AutoShapes - Syncfusion Demos",
                MetaDescription = "This Blazor Excel AutoShapes example demonstrates how to use AutoShapes in spreadsheets using .NET Excel (XlsIO) library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="AutoShapes",
                        FileName="AutoShapes.razor"
                    },
                    new SourceCollection
                    {
                        Id="AutoShapesService",
                        FileName="AutoShapesService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Group Shapes",
                Category = "Shapes",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/group-shapes",
                MetaTitle = "Blazor Excel (xlsIO) Group Shapes - Syncfusion Demos",
                MetaDescription = "This Blazor Excel Group Shapes sample demonstrates how to use group shapes in spreadsheets using .NET Excel (XlsIO) library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="GroupShapes",
                        FileName="GroupShapes.razor"
                    },
                    new SourceCollection
                    {
                        Id="GroupShapesService",
                        FileName="GroupShapesService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Comments",
                Category = "Shapes",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/Comments",
                MetaTitle = "Blazor Excel (xlsIO) Comments - Syncfusion Examples",
                MetaDescription = "This Blazor Excel Comments example demonstrates how to use the comments in spreadsheets using .NET Excel (XlsIO) library. Explore here to more details.",                
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Comments",
                        FileName="Comments.razor"
                    },
                    new SourceCollection
                    {
                        Id="CommentsService",
                        FileName="CommentsService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Create Macro",
                Category = "Macros",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/create-macros",
                MetaTitle = "Blazor Excel (xlsIO) Create Macro - Syncfusion Demos",
                MetaDescription = "This Blazor Excel (XlsIO) Library Create Macro sample demonstrates how to create macros using .NET Excel (XlsIO) library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CreateMacros",
                        FileName="CreateMacros.razor"
                    },
                    new SourceCollection
                    {
                        Id="CreateMacrosService",
                        FileName="CreateMacrosService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Edit Macro",
                Category = "Macros",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/edit-macros",
                MetaTitle = "Blazor Excel (xlsIO) Edit Macro - Syncfusion Demos",
                MetaDescription = "This Blazor Excel (XlsIO) Library Edit Macro sample demonstrates how to edit the macros using .NET Excel (XlsIO) library. Explore here to more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="EditMacro",
                        FileName="EditMacro.razor"
                    },
                    new SourceCollection
                    {
                        Id="EditMacroService",
                        FileName="EditMacroService.cs"
                    }
                }
            }
        };	

          public List<Sample> PDF { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Hello World",
                Category = "Getting Started",
                Directory = "DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Library Hello World - Syncfusion Examples",
                MetaDescription="This Blazor PDF sample demonstrates the creation of simple PDF document. It draws the string Hello world! in the desired location using the PDF standard font.",
                Url = "pdf/hello-world",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="HelloWorldPDF",
                        FileName="HelloWorldPDF.razor"
                    },
                    new SourceCollection
                    {
                        Id="HelloWorldPDFService",
                        FileName="HelloWorldPDFService.cs"
                    }
                }
            },
            new Sample
            {
                Name= "Job Application",
                Category="Product Showcase",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Library Job Application - Syncfusion Examples",
                MetaDescription="This Blazor PDF Job Application Example demonstrates the creation of job application form from the scratch using the form fields. Explore here to more details.",
                Url="pdf/job-application",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="JobApplication",
                        FileName="JobApplication.razor"
                    },
                    new SourceCollection
                    {
                        Id="JobApplicationService",
                        FileName="JobApplicationService.cs"
            }
                }
            },
             new Sample
            {
                Name= "Text Flow",
                Category="Drawing Text",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Library Text Flow - Syncfusion Examples",
                MetaDescription="This Blazor PDF Text Flow sample demonstrates the creation of PDF document with large text that flows over multiple pages. Explore here to more details.",
                Url="pdf/text-flow",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TextFlow",
                        FileName="TextFlow.razor"
                    },
                    new SourceCollection
                    {
                        Id="TextFlow",
                        FileName="TextFlowService.cs"
                    }
                }
            },
             new Sample
            {
                Name= "Bullets and Lists",
                Category="Drawing Text",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Library Bullets and Lists - Syncfusion Examples",
                MetaDescription="This sample shows how to create ordered and unordered lists. Ordered lists use numbers or alphabets; unordered lists use bullets, circles, images as markers.",
                Url="pdf/bullets-and-lists",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="BulletsAndList",
                        FileName="BulletsAndList.razor"
                    },
                    new SourceCollection
                    {
                        Id="BulletsAndList",
                        FileName="BulletsAndListService.cs"
                    }
                }
            },           
                new Sample
            {
                Name= "RTL Text",
                Category="Drawing Text",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Library Right To Left Text - Syncfusion Examples",
                MetaDescription="This sample shows how to draw right-to-left text in PDF documents, supporting languages like Arabic, Hebrew, Persian, Urdu, and other RTL scripts seamlessly.",
                Url="pdf/rtl-text",
                Type=SampleType.None,     
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RTLText",
                        FileName="RTLText.razor"
                    },
                    new SourceCollection
                    {
                        Id="RTLText",
                        FileName="RTLTextService.cs"
                    }
                }
            },
                    new Sample
            {
                Name= "OpenType Font",
                Category="Drawing Text",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Library OpenType Font - Syncfusion Examples",
                MetaDescription="This Blazor PDF OpenType Font example demonstrates how to draw a text with the OpenType font in a PDF document. Explore here to learn know more details.",	
                Url="pdf/open-type-font",
                Type=SampleType.None,      
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="OpenTypeFont",
                        FileName="OpenTypeFont.razor"
                    },
                    new SourceCollection
                    {
                        Id="OpenTypeFont",
                        FileName="OpenTypeFontService.cs"
                    }
                }
            },
                      new Sample
            {
                Name= "Barcode",
                Category="Graphics",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Library Barcode - Fonts - Syncfusion Examples",
                MetaDescription="This sample shows creating barcodes in PDF without barcode fonts. It supports both 1D and 2D barcodes with many customizable properties for flexibility.",
                Url="pdf/barcode",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Barcode",
                        FileName="Barcode.razor"
                    },
                    new SourceCollection
                    {
                        Id="Barcode",
                        FileName="BarcodeService.cs"
                    }
                }
              },
              new Sample
            {
                Name= "Drawing Shapes",
                Category="Graphics",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Library Drawing Shapes - Syncfusion Examples",
                MetaDescription="This Blazor PDF sample demonstrates drawing of shapes such as Ellipse, Arcs, Polygon, Pie and Rectangle in the PDF document with gradient and color spaces.",
                Url="pdf/drawing-shapes",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="DrawingShapes",
                        FileName="DrawingShapes.razor"
                    },
                    new SourceCollection
                    {
                        Id="DrawingShapes",
                        FileName="DrawingShapesService.cs"
                    }
                }
              },
              new Sample
            {
                Name= "Graphic Brushes",
                Category="Graphics",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Library Graphic Brushes - Syncfusion Examples",
                MetaDescription="This sample shows drawing shapes using brushes like solid, tiling, hatch, linear, radial gradients, and color spaces like Cal RGB, ICC, Pantone, and indexed.",
                Url="pdf/graphics-brushes",
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="GraphicBrushes",
                        FileName="GraphicBrushes.razor"
                    },
                    new SourceCollection
                    {
                        Id="GraphicBrushes",
                        FileName="GraphicBrushesService.cs"
                    }
                }
              },
                 new Sample
            {
                Name= "Image Insertion",
                Category="Graphics",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Library Image Insertion - Syncfusion Examples",
                MetaDescription="This sample shows inserting various raster and vector images (JPEG, PNG, TIFF, EMF, GIF) in a PDF and demonstrates image masking in the Essential PDF library.",
                Url="pdf/image-insertion",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ImageInsertion",
                        FileName="ImageInsertion.razor"
                    },
                    new SourceCollection
                    {
                        Id="ImageInsertion",
                        FileName="ImageInsertionService.cs"
                    }
                }
              },
               new Sample
               {
                Name= "Table Features",
                Category="Tables",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Library Table Features - Syncfusion Examples",
                MetaDescription="This sample shows how to create richly formatted tables to organize data, supporting basic and advanced operations on cells, rows, columns, headers, footers.",
                Url="pdf/table-features",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TableFeatures",
                        FileName="TableFeatures.razor"
                    },
                    new SourceCollection
                    {
                        Id="TableFeatures",
                        FileName="TableFeaturesService.cs"
                    }
                }
               },
               new Sample
               {
                Name= "Encryption",
                Category="Security",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Library Encryption - Syncfusion Examples",
                MetaDescription="This PDF demo shows how to encrypt PDF document with encryption standards like 40-bit RC4, 128-bit RC4, advanced encryption standard 256-bit AES Revision 6.",
                Url="pdf/encryption",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Encryption",
                        FileName="Encryption.razor"
                    },
                    new SourceCollection
                    {
                        Id="Encryption",
                        FileName="EncryptionService.cs"
                    }
                }
               },
               new Sample
               {
                Name= "Digital Signature",
                Category="Security",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Library Digital Signature - Syncfusion Examples",
                MetaDescription="This sample shows securing a PDF with certificates and signing it using standard or author signatures, including support for Elliptic Curve signatures.",
                Url="pdf/digital-signature",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="DigitalSignature",
                        FileName="DigitalSignature.razor"
                    },
                    new SourceCollection
                    {
                        Id="DigitalSignature",
                        FileName="DigitalSignatureService.cs"
                    }
                }
               },
                new Sample
               {
                Name= "Layers",
                Category="Settings",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Library Layers | Shapes | Syncfusion Examples",
                MetaDescription="This sample shows adding layers (Optional Content Groups) with shapes in a PDF. Essential PDF supports creating, merging, and toggling these layers easily.",
                Url="pdf/layers",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Layers",
                        FileName="Layers.razor"
                    },
                    new SourceCollection
                    {
                        Id="Layers",
                        FileName="LayersService.cs"
                    }
                }
               },
                 new Sample
               {
                Name= "Find PDF Corruption",
                Category="Analyze Documents",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Library Find PDF Corruption - Syncfusion Examples",
                MetaDescription="This Find PDF Correction sample demonstrates to find PDF document corruption by using Essential PDF. It allows you to find only PDF syntax level corruptions.",
                Url="pdf/find-pdf-corruption",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="FindPDFCorruption",
                        FileName="FindPDFCorruption.razor"
                    },
                    new SourceCollection
                    {
                        Id="FindPDFCorruption",
                        FileName="FindPDFCorruptionService.cs"
                    }
                }
               },
                     new Sample
               {
                Name= "Interactive Features",
                Category="User Interaction",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Library Interactive Features - Syncfusion Examples",
                MetaDescription="This sample demonstrates the creation of interactive invoice with attachment, product total price calculation based on the quantity using PDF JavaScript.",
                Url="pdf/interactive-features",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="InteractiveFeatures",
                        FileName="InteractiveFeatures.razor"
                    },
                    new SourceCollection
                    {
                        Id="InteractiveFeatures",
                        FileName="InteractiveFeaturesService.cs"
                    }
                }
               },
                      new Sample
               {
                Name= "XFA Form Creation",
                Category="User Interaction",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Library XFA Form Creation - Syncfusion Examples",
                MetaDescription="This sample demonstrates how to create registration form using XFA form fields. The Essential PDF supports to create dynamic and static XFA form fields.",
                Url="pdf/xfa-form-creation",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="XFAFormCreation",
                        FileName="XFAFormCreation.razor"
                    },
                    new SourceCollection
                    {
                        Id="XFAFormCreation",
                        FileName="XFAFormCreationService.cs"
                    }
                }
               },
                  new Sample
               {
                Name= "XFA Form Filling",
                Category="User Interaction",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Library XFA Form Filling - Syncfusion Examples",
                MetaDescription="This Blazor PDF XFA Form Filling sample demonstrates how to fill and flatten XFA form fields. It is possible to edit and remove the existing XFA form fields.",
                Url="pdf/xfa-form-filling",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="XFAFormFilling",
                        FileName="XFAFormFilling.razor"
                    },
                    new SourceCollection
                    {
                        Id="XFAFormFilling",
                        FileName="XFAFormFillingService.cs"
                    }
                }
               },
                   new Sample
               {
                Name= "Portfolio",
                Category="User Interaction",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Portofolio | Interaction | Syncfusion Examples",
                MetaDescription="This sample shows creating a PDF portfolio, allowing file extraction and removal, combining content like documents, images, emails, spreadsheets, web pages.",
                Url="pdf/portfolio",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Portfolio",
                        FileName="Portfolio.razor"
                    },
                    new SourceCollection
                    {
                        Id="Portfolio",
                        FileName="PortfolioService.cs"
                    }
                }
               },
			   new Sample
               {
                Name= "Annotations",
                Category="User Interaction",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Library Annotations - Syncfusion Examples",
                MetaDescription="This sample shows creating annotation types like ink, free text, popup, text markup. Essential PDF supports 20+ annotations with create, edit, and delete.",
                Url="pdf/annotations",
                Type = SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Annotations",
                        FileName="Annotations.razor"
                    },
                    new SourceCollection
                    {
                        Id="Annotations",
                        FileName="AnnotationsService.cs"
                    }
                }
               },
#if !WEBAPP
              new Sample
              {
                  Name = "Compress Existing PDF",
                  Category = "Compression",
                  Directory = "DocumentProcessing/PDF",
                  MetaTitle = "Blazor PDF Library Compress Existing PDF - Syncfusion Examples",
                  MetaDescription = "This Blazor PDF Compress Exiting PDF example demonstrates how to compress the existing PDF document using Essential PDF. Explore here to more details.",
                  Url = "pdf/compress-existing-pdf",
                  Type = SampleType.None,
                  SourceFiles = new List<SourceCollection>()
                  {
                        new SourceCollection
                        {
                            Id="CompressExistingPdf",
                            FileName="CompressExistingPdf.razor"
                        },
                        new SourceCollection
                        {
                            Id="CompressExistingPdf",
                            FileName="CompressExistingPdfService.cs"
                        }
                    }
              },
               new Sample
              {
                  Name = "Redaction",
                  Category = "Security",
                  Directory = "DocumentProcessing/PDF",
                  MetaTitle = "Blazor PDF Library Redaction - Syncfusion Examples",
                  MetaDescription = "This sample shows how to redact text and images in a PDF, removing sensitive or unwanted information to protect content within the PDF document securely.",
                  Url = "pdf/redaction",
                  Type = SampleType.None,
                  SourceFiles = new List<SourceCollection>()
                  {
                        new SourceCollection
                        {
                            Id="Redaction",
                            FileName="Redaction.razor"
                        },
                        new SourceCollection
                        {
                            Id="Redaction",
                            FileName="RedactionService.cs"
                        }
                    }
              },
#endif
#if !WASM && !WEBAPP
              new Sample
                      {
                          Name = "TIFF to PDF",
                          Category = "Graphics",
                          Directory = "DocumentProcessing/PDF",
                          MetaTitle = "Blazor PDF Library TIFF to PDF - Syncfusion Examples",
                          MetaDescription = "This Blazor PDF TiFF to PDF sample demonstrates how to convert the single or multi frame TIFF images to PDF document. Explore learn here to more details.",
                          Url = "pdf/tiff-to-pdf",
                          Type = SampleType.None,
                          SourceFiles = new List<SourceCollection>()
                          {
                              new SourceCollection
                              {
                                  Id="TiffToPdf",
                                  FileName="TiffToPdf.razor"
                              },
                              new SourceCollection
                              {
                                  Id="TiffToPdf",
                                  FileName="TiffToPdfService.cs"
                              }
                          }
                      },
              new Sample
              {
                  Name = "Remove Image",
                  Category = "Modify Documents",
                  Directory = "DocumentProcessing/PDF",
                  MetaTitle = "Blazor PDF Library Remove Image - Syncfusion Examples",
                  MetaDescription = "This Blazor PDF Library Remove Image sample demonstrates how to remove an image from the existing PDF document. Explore here to learn more information.",
                  Url = "pdf/remove-image",
                  Type = SampleType.None,
                  SourceFiles = new List<SourceCollection>()
                  {
                        new SourceCollection
                        {
                            Id="RemoveImage",
                            FileName="RemoveImage.razor"
                        },
                        new SourceCollection
                        {
                            Id="RemoveImage",
                            FileName="RemoveImageService.cs"
                        }
                    }
              },
              new Sample
              {
                  Name = "PDF to PDF/A",
                  Category = "Conformance",
                  Directory = "DocumentProcessing/PDF",
                  MetaTitle = "Blazor PDF Library PDF to PDF/A - Syncfusion Examples",
                  MetaDescription = "This Blazor PDF component PDF to PDF/A sample shows how to convert an existing PDF document to PDF/A-1b compliant PDF document. Explore here to more details.",
                  Url = "pdf/pdf-to-pdfa",
                  Type = SampleType.None,
                  SourceFiles = new List<SourceCollection>()
                  {
                        new SourceCollection
                        {
                            Id="PdfToPdfA",
                            FileName="PdfToPdfA.razor"
                        },
                        new SourceCollection
                        {
                            Id="PdfToPdfA",
                            FileName="PdfToPdfAService.cs"
                        }
                    }
              },
               new Sample
               {
                Name= "Digital Signature Validation",
                Category="Security",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Library Digital Signature Validation - Syncfusion Examples",
                MetaDescription="This Blazor PDF Digital Signature Validation sample demonstrates how to validate the digital signatures in existing PDF document. Explore here to more details.",
                Url="pdf/validation-signature-pdf",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="DigitalSignatureValidation",
                        FileName="DigitalSignatureValidation.razor"
                    },
                    new SourceCollection
                    {
                        Id="DigitalSignatureValidationPdfService",
                        FileName="DigitalSignatureValidationPdfService.cs"
                    }
                }
               },
#endif
              new Sample
               {
                Name= "PDF Conformance",
                Category="Conformance",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Library PDF Conformance - Syncfusion Examples",
                MetaDescription="This Blazor PDF component PDF Conformance sample demonstrates various PDF conformance support in the Essential PDF Library. Explore here to more details.",
                Url="pdf/conformance",
                Type = SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Conformance",
                        FileName="Conformance.razor"
                    },
                    new SourceCollection
                    {
                        Id="Conformance",
                        FileName="ConformanceService.cs"
                    }
                }
               },

                  new Sample
               {
                Name= "Overlay Documents",
                Category="Modify Documents",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF library Overlay Documents - Syncfusion Demos",
                MetaDescription="This Blazor PDF Overlay Documents sample demonstrates how to overlay two different PDF documents into a single PDF document. Explore here to more details.",
                Url="pdf/overlay-documents",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="OverlayDocuments",
                        FileName="OverlayDocuments.razor"
                    },
                    new SourceCollection
                    {
                        Id="OverlayDocuments",
                        FileName="OverlayDocumentsService.cs"
                    }
                }
               },
                     new Sample
               {
                Name= "Rearrange Pages",
                Category="Modify Documents",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Library Rearrange Pages - Syncfusion Examples",
                MetaDescription="This Blazor PDF Rearrange Pages sample shows how to rearrange pages from an existing PDF document to make the document meaningful. Explore to more details.",
                Url="pdf/rearrange-pages",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RearrangePages",
                        FileName="RearrangePages.razor"
                    },
                    new SourceCollection
                    {
                        Id="RearrangePages",
                        FileName="RearrangePagesService.cs"
                    }
                }
               },
                    new Sample
               {
                Name= "Autotag",
                Category="Accessibility",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Library Autotag - Accessibility - Syncfusion Examples",
                MetaDescription="This sample shows creating tagged (accessible) PDFs from scratch using the auto-tag feature, which tags document elements automatically for accessibility.",
                Url="pdf/auto-tag",
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Autotag",
                        FileName="Autotag.razor"
                    },
                    new SourceCollection
                    {
                        Id="Autotag",
                        FileName="AutotagService.cs"
                    }
                }
               },
                      new Sample
               {
                Name= "Customtag",
                Category="Accessibility",
                Directory="DocumentProcessing/PDF",
                MetaTitle = "Blazor PDF Library Customtag - Syncfusion Examples",
                MetaDescription="This Blazor PDF CustomTag sample demonstrates how to create tagged PDF or accessible PDF from the scratch with custom tags. Explore here to more details.",
                Url="pdf/custom-tag",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Customtag",
                        FileName="Customtag.razor"
                    },
                    new SourceCollection
                    {
                        Id="Customtag",
                        FileName="CustomtagService.cs"
                    }
                }
              }
          };          
		
    }
}
