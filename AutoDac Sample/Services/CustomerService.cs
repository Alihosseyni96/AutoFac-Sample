using AutoFac_Sample.Services;

namespace AutFac_Sample.Services
{
    public class CustomerService : ICustomerService
    {
        public int DoSum(int id)
        {
            return id + 10;
        }
    }
}
