namespace AutoDac_Sample.Services
{
    public class CustomerService : ICustomerService
    {
        public int DoSum(int id)
        {
            return id + 10;
        }
    }
}
