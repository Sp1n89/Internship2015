namespace QueryOverExample.Domain.Model
{
    public class Product : EntityBase
    {
        protected Product()
        {
            
        }

        public Product(string name, string category)
        {
            Name = name;
            Category = category;
        }

        public virtual string Name { get; set; }

        public virtual string Category { get; set; }
    }
}
