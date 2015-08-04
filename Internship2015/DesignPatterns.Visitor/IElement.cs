namespace DesignPatterns.Visitor
{
    public abstract class ElementBase
    {
       public abstract void Accept(IVisitor visitor);
    }
}