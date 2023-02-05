namespace AutoDac_Sample.Services
{
    public class ProductService : IProductService
    {
        public int DoMultiple(int id)
        {
            return (id * 10);
        }
    }
}
