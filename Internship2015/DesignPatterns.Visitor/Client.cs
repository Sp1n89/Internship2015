namespace DesignPatterns.Visitor
{
    public class Client
    {
        private readonly Element _objectStructure;

        public Client()
        {
            _objectStructure =
                new Element(
                    new Element(
                        new ElementWithLink(
                            new Element(
                                new Element(
                                    new ElementWithLink(
                                        new Element(null),
                                        new Element(null)))),
                            new Element(
                                new Element(
                                    new Element(null))))));
        }

        public Element ObjectStructure
        {
            get { return _objectStructure; }
        }
    }
}