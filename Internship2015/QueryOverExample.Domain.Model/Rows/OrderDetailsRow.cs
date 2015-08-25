namespace QueryOverExample.Domain.Model.Rows
{
    public class OrderDetailsRow
    {
        public string OrderNumber { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string TelephoneNumber { get; set; }

        public string Product { get; set; }

        public string Category { get; set; }

        public override string ToString()
        {
            return string.Format("{0, -20} {1, -20} {2, -20} {3, -20} {4, -50} {5, -20}",
                OrderNumber, Firstname, Lastname, TelephoneNumber, Product, Category);
        }
    }
}