using System.Collections.Generic;

namespace TDD_Homework1
{
    internal interface IProductService
    {
        IEnumerable<Product> GetSumOfCostNProduct(List<Product> products, int groupSize);
        IEnumerable<Product> GetSumOfRevenueNProduct(List<Product> products, int groupSize);
    }

    internal class ProductService : IProductService
    {
        public IEnumerable<Product> GetSumOfCostNProduct(List<Product> products, int groupSize)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetSumOfRevenueNProduct(List<Product> products, int groupSize)
        {
            throw new System.NotImplementedException();
        }
    }
}
