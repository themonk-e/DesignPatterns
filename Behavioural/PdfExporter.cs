    using System.Runtime.ConstrainedExecution;

    namespace designPattern.Behavioural.Template
    {
        public class PDFExporter : Exporter
        {
            protected override void ApplySpecificSettings()
            {
                Console.WriteLine("Applying PDF specific settings....");
            }
        }
        
        
    }