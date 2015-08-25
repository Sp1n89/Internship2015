namespace QueryOverExample.Domain.Model.Rows
{
    public class OrderDetailsRow
    {
        public string OrderNumber { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string TelephoneNumber { get; set; }

        public string Product { get; set; }

        public ProductCategory? ProductCategory { get; set; }
    }
}