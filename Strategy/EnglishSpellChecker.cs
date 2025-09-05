namespace designPattern.Behavioural.Strategy
{
    public class EnglishSpellChecker:ISpellChecker
    {
        public void CheckSpelling(string value)
        {
            Console.WriteLine($"{value} has the right spelling in English..");
        }
    }
}