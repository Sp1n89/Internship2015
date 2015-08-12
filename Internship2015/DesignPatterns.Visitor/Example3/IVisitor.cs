namespace DesignPatterns.Visitor.Example3
{
    public interface IVisitor
    {
        void Visit(Book book);
        void Visit(Fruit fruit);
    }
}