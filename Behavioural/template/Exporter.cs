using System.Runtime.ConstrainedExecution;

namespace designPattern.Behavioural.Template
{
    public abstract class Exporter
    {
        public void Export(string document, string path)
        {
            OpenDocument(document, path);
            FormatDocument(document);
            ApplySpecificSettings();
            SaveDocument(document);
        }

        private void OpenDocument(string document, string path)
        {
            Console.WriteLine($"opening {document}....");
        }

        private void FormatDocument(string document)
        {
            Console.WriteLine($"Formatting {document}....");
        }

        private void SaveDocument(string document)
        {
            Console.WriteLine($"saving {document}..");
        }

        protected abstract void ApplySpecificSettings();

    }
}