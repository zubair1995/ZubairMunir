using Microsoft.Extensions.Logging;
using SystemsLtd.Training.ECommerce.Model;
using SystemsLtd.Training.ECommerce.Repository;

namespace SystemsLtd.Training.ECommerce.Service.Interface
{
    public interface IProductService
    {
        #region Public Methods
        IEnumerable<Product> GetProducts();
        IEnumerable<Product> GetAllProducts(Product product);
        Product GetProduct(int id);
        int AddProduct(Product product);
        bool UpdateProduct(Product product);

        bool DeleteProduct(Product product);
        #endregion
    }
}