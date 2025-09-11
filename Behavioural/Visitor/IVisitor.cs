namespace designPattern.Behavioural.Visitor
{
    public interface IVisitor
    {
        public void Visit(TextFile file);
        public void Visit(VideoFile file);
        public void Visit(ImageFile file);
    }
}