namespace designPattern.Behavioural.Observer
{
    public class Stock:IStock
    {
        public string Name;
        public double Price;
        private List<IInvestor> Investors;

        public Stock(string name, double price)
        {
            Name = name;
            Price = price;
            Investors = new List<IInvestor>();
        }

        public void ChangePrice(double price)
        {
            double oldPrice = Price;
            Price = price;

            foreach (var investor in Investors)
            {
                investor.Update($"Hi,{investor.GetName()} your {Name} stock's has been changed from ${oldPrice} to ${price}");
            }
        }


        public void AddInvestor(IInvestor investor)
        {
            Investors.Add(investor);
        }

        public void RemoveInvestor(IInvestor investor)
        {
            Investors.Remove(investor);
        }
    }
}