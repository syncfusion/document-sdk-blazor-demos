namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        internal SampleConfig()
        {
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Excel (XlsIO)",
                Category = "Document Processing Libraries",
                Directory = "DocumentProcessing/Excel",
                Samples = XlsIO, 
                Type = SampleType.Updated,
                ControllerName = "Excel",
                DemoPath = "excel/create-excel",
                ComponentIconName = "excel"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Word (DocIO)",
                Category = "Document Processing Libraries",
                Directory = "DocumentProcessing/Word",
                Type = SampleType.Updated,
                Samples = DocIO,
                ControllerName = "Word",
                DemoPath = "word/hello-world",
                ComponentIconName = "word"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "PowerPoint (Presentation)",
                Category = "Document Processing Libraries",
                Directory = "DocumentProcessing/PowerPoint",
                Samples = Presentation,
                ControllerName = "PowerPoint",
                DemoPath = "powerpoint/getting-started",
                ComponentIconName = "powerpoint"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "PDF",
                Category = "Document Processing Libraries",
                Directory = "DocumentProcessing/PDF",
#if !(WASM)
                Type = SampleType.None,
#else
               Type = SampleType.None,
#endif
                Samples = PDF,
                ControllerName = "PDF",
                DemoPath = "pdf/hello-world"
            });
        }
    }
}
