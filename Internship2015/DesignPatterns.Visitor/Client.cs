namespace DesignPatterns.Visitor
{
    public class Client
    {
        private readonly Element _objectStructure;

        public Client()
        {
            _objectStructure =
                new Element("Body",
                    new Element("Paragraph",
                        new ElementWithLink("MSDN",
                            new Element("Bullet 1",
                                new Element("C# Types",
                                    new ElementWithLink("C#",
                                        new Element("Classes", null),
                                        new Element("Objects", null)))),
                            new Element("Bullet 2",
                                new Element("C# Functions",
                                    new Element("LINQ", null))))));
        }

        public Element ObjectStructure
        {
            get { return _objectStructure; }
        }
    }
}