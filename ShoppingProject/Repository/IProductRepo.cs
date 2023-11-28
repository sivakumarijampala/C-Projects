using ShoppingProject.Models;

namespace ShoppingProject.Repository
{
    public interface IProductRepo
    {
        public IEnumerable<Product> GetAllProducts();

        public Product GetproductByProductId(int productId);
        public Product SaveProduct(Product product);
        public void DeleteProduct(int productId);
        public Product UpdateProduct(int productId,Product product);

    }
}
