namespace QueryOverExample.Domain.Model
{
    public class Product : EntityBase
    {
        protected Product()
        {
            
        }

        public Product(string name, ProductCategory productCategory)
        {
            Name = name;
            ProductCategory = productCategory;
        }

        public virtual string Name { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
    }
}
