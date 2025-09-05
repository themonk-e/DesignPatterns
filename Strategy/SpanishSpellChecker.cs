namespace designPattern.Behavioural.Strategy
{
    public class SpanishSpellChecker:ISpellChecker
    {
        public void CheckSpelling(string value)
        {
            Console.WriteLine($"{value} has the right spelling in Spanish..");
        }
    }
}