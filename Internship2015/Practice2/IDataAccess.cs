namespace Practice2
{
    public interface IDataAccess
    {
        Customer FindCustomerByName(string name);

        Product FindProductByName(string name);
    }
}