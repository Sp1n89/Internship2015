namespace DesignPatterns.Visitor.Example3
{
    public interface IItem
    {
        // ...
        void Accept(IVisitor visitor);
    }
}