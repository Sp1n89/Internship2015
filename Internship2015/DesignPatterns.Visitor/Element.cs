namespace DesignPatterns.Visitor
{
    public class Element : ElementBase
    {
        public Element Next { get; set; }
        public Element Link { get; set; }

        public string Name { get; set; }

        public Element()
        {
            
        }

        public Element(string name, Element next)
        {
            Name = name;
            Next = next;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}