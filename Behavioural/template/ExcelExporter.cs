namespace designPattern.Behavioural.Template
{
    public class ExcelExporter:Exporter
    {
        protected override void ApplySpecificSettings()
        {
              Console.WriteLine("Applying Excel specific settings....");
        }
    }
}