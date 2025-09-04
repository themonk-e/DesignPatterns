namespace designPattern.Behavioural.Observer
{
    public interface IStock
    {
        public void ChangePrice(double price);
        public void AddInvestor(IInvestor investor);

        public void RemoveInvestor(IInvestor investor);
    }
}