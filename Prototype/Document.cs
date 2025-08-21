namespace designPattern.Prototype
{
    public class Formatting
    {
        public string Font { get; set; }
        public decimal FontSize { get; set; }
        public string Color { get; set; }
    }
    public class LegalDocument : IDocument
    {
        private string Title { get; set; }
        private string Content { get; set; }
        private string Author { get; set; }
        private Formatting DocFormatting { get; set; }

        public LegalDocument()
        {
            this.Title = "Legal Document";
            this.Author = "Mr.Mahesh LLB";
            this.Content = "This is a document of divorce";
            this.DocFormatting = new Formatting() { Font = "Nexa", FontSize = 2, Color = "Black" };
        }



        public object Clone()
        {
            return new LegalDocument()
            {
                Title = this.Title,
                Content = this.Content,
                Author = this.Author,
                DocFormatting = new Formatting()
                {
                    Color = this.DocFormatting.Color,
                    Font = this.DocFormatting.Font,
                    FontSize = this.DocFormatting.FontSize,
                }
            };
        }

        public void createDocument(string Title, string Author, string Content, Formatting DocFormatting)
        {
            this.Title = Title;
            this.Author = Author;
            this.Content = Content;
            this.DocFormatting = DocFormatting;
        }
        public void printDocument()
        {
            Console.WriteLine(Title);
            Console.WriteLine("================");
            Console.WriteLine(Content);
            Console.WriteLine("================");
            Console.WriteLine(Author);
            Console.WriteLine("================");
            Console.WriteLine($"Formatting Details:{DocFormatting.FontSize}pt {DocFormatting.Font} {DocFormatting.Color}");

        }

    }
    
        public class InvoiceDocument : IDocument
    {
        private string Title { get; set; }
        private string Content { get; set; }
        private string Author { get; set; }
        private Formatting DocFormatting { get; set; }


         public InvoiceDocument()
        {
            this.Title = "Invoice Notice";
            this.Author = "SRB Traders";
            this.Content = "COST OF PURCHASE 20000.00";
            this.DocFormatting = new Formatting() { Font = "Monteserrat", FontSize = 2, Color = "Black" };
        }
        public object Clone()
        {
            return new InvoiceDocument()
            {
                Title = this.Title,
                Content = this.Content,
                Author = this.Author,
                DocFormatting=new Formatting()
                {
                     Color = this.DocFormatting.Color,
                     Font = this.DocFormatting.Font,
                     FontSize=this.DocFormatting.FontSize,
                }
            };
        }

        public void createDocument(string Title, string Author, string Content, Formatting DocFormatting)
        {
            this.Title = Title;
            this.Author = Author;
            this.Content = Content;
            this.DocFormatting = DocFormatting;
        }
        public void printDocument()
        {
            Console.WriteLine(Title);
            Console.WriteLine("================");
            Console.WriteLine(Content);
            Console.WriteLine("================");
            Console.WriteLine(Author);
            Console.WriteLine("================");
            Console.WriteLine($"Formatting Details:{DocFormatting.FontSize} pt {DocFormatting.Font} {DocFormatting.Color}");

        }

    }

    public class DocTemplateRegistry
    {
        private readonly static Dictionary<string, IDocument> documnetTemplateRegistry = new Dictionary<string, IDocument>();

        static DocTemplateRegistry()
        {
            documnetTemplateRegistry["LegalDocument"] = new LegalDocument();
            documnetTemplateRegistry["Invoice"] = new InvoiceDocument();
        }

        public static IDocument GetDocumentTemplate(string docType)
        {
            return (IDocument)documnetTemplateRegistry[docType].Clone();
        }

    }
        
}