namespace DesignPatterns.Visitor.Example3
{
    public class Fruit : IItem
    {
        public string Name { get; set; }
        public decimal PricePerKg { get; set; }
        public decimal Weight { get; set; }

        public Fruit(string name, decimal pricePerKg, decimal weight)
        {
            Name = name;
            PricePerKg = pricePerKg;
            Weight = weight;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}