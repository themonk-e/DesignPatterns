namespace designPattern.Behavioural.Observer
{
    public interface IInvestor
    {
        public string GetName();
        public void Update(string notification);

        public void Buy(IStock stock);
        public void Sell(IStock stock);
    }
}