using Microsoft.Extensions.Logging;
using SystemsLtd.Training.ECommerce.Model;

namespace SystemsLtd.Training.ECommerce.Repository.Interface
{
    public interface IProductRepository
    {
        #region Public Methods
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);
        int AddProduct(Product product);

        bool UpdateProduct(Product product);

        bool DeleteProduct(Product product);
        IEnumerable<Product> GetAllProducts(Product product);
        #endregion
    }
}