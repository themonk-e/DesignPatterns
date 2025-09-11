namespace designPattern.Behavioural.Visitor
{
    public interface IFile
    {
        public void Accept(IVisitor visitor);
    }
}