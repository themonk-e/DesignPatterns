namespace designPattern.Behavioural.Observer
{
    public class Investor:IInvestor
    {
        private readonly string Name;

        public Investor(string name) {
            Name = name;
        }


        public string GetName()
        {
            return Name;
        }

        public void Update(string notification)
        {
            Console.WriteLine(notification);
        }

        public void Buy(IStock stock)
        {
            stock.AddInvestor(this);
        }
        public void Sell(IStock stock)
        {
            stock.RemoveInvestor(this);
        }
    }
}