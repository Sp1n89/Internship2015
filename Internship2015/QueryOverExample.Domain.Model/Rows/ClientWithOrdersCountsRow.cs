namespace QueryOverExample.Domain.Model.Rows
{
    public class ClientWithOrdersCountsRow
    {
        public int ClientId { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public int OrdersCount { get; set; }

        public override string ToString()
        {
            return string.Format("{0, -15} {1, -15} {2, -15} {3, -15}", ClientId, Firstname, Lastname, OrdersCount);
        }
    }
}