namespace DesignPatterns.Visitor
{
    public class ElementWithLink : Element
    {
        public ElementWithLink(string name, Element link, Element next) : base(name, next)
        {
            Link = link;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}