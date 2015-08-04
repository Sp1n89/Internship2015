namespace DesignPatterns.Visitor
{
    public class DisplayNameVisitor : IVisitor
    {
        public string Output { get; set; }

        public void Visit(Element element)
        {
            Output += "\n" + element.Name;
        }

        public void Visit(ElementWithLink element)
        {
            Output += "\n" + element.Name;
        }

        public void DisplayElementsNames(Element element)
        {
            element.Accept(this);
            if (element.Next != null)
            {
                DisplayElementsNames(element.Next);
            }
        }
    }
}