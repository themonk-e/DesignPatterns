namespace designPattern.Behavioural.Strategy
{
    public class Editor
    {
        public string Language;

        private readonly Dictionary<String, ISpellChecker> SpellCheckers = new Dictionary<string, ISpellChecker>();
        private ISpellChecker spellChecker;

        public Editor()
        {
            SpellCheckers["English"] = new EnglishSpellChecker();
            SpellCheckers["Spanish"] = new SpanishSpellChecker();
            SpellCheckers["French"] = new FrenchSpellChecker();
        }
        public void SetLanguage(string lang)
        {
            Language = lang;
            spellChecker = SpellCheckers[lang];
        }

        public void CheckSpelling(string word)
        {
            spellChecker.CheckSpelling(word);
        }
    }
}