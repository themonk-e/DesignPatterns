namespace designPattern.Structural.Composite
{
    public interface IData
    {

        public void AddPermission(string permission);
        public void RemovePermission(string permission);
        public void DisplayProperties();

    }
}