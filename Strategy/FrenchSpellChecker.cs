namespace designPattern.Behavioural.Strategy
{
    public class FrenchSpellChecker:ISpellChecker
    {
        public void CheckSpelling(string value)
        {
            Console.WriteLine($"{value} has the right spelling in French..");
        }
    }
}