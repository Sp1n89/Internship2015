namespace DesignPatterns.Visitor.Example3
{
    public class PriceCalculatorVisitor : IVisitor
    {
        public decimal Total { get; set; }

        public void Visit(Book book)
        {
            // Calculate book's price
            Total += book.Price;
        }

        public void Visit(Fruit fruit)
        {
            // Calculate fruit's price
            Total += fruit.PricePerKg * fruit.Weight;
        }
    }
}