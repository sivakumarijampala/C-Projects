using Microsoft.Identity.Client;
using ShoppingProject.Exceptions;
using ShoppingProject.Models;
using ShoppingProject.Repository;

namespace ShoppingProject.RepositoryImpl
{
    public class ProcuctRepoImpl : IProductRepo
    {
        public readonly ProductDbContext productDbContext;
        public ProcuctRepoImpl(ProductDbContext productDbContext) { 
        this.productDbContext = productDbContext;
        }

        public void DeleteProduct(int productId)
        {
            Product product=productDbContext.Products.Find(productId);
            if(product != null)
            {
                productDbContext.Products.Remove(product);
                productDbContext.SaveChanges();
            }
            else
            {
                throw new ProductNotFoundException("product is not found");
            }
        }

        public IEnumerable<Product> GetAllProducts()
        {
            IEnumerable<Product> products=productDbContext.Products.ToList();
            if (products != null)
            {
                return products;
            }
            else
            {
                throw new ProductNotFoundException("products not found");
            }
        }

        public Product GetproductByProductId(int productId)
        {
            Product product=productDbContext.Products.Find(productId);
            if(product != null)
            {
            return product;
            }
            else
            {
                throw new ProductNotFoundException($"product not found with Id:{productId}");
            }
        }

        public Product SaveProduct(Product product)
        {
             productDbContext.Products.Add(product);
             productDbContext.SaveChanges();
             return product;
        }

        public Product UpdateProduct(int productId, Product product)
        {
           Product prod = productDbContext.Products.Find(productId);
            if(prod != null)
            {
                prod.productName = product.productName;
                prod.productPrice=product.productPrice;
                prod.productDescription=product.productDescription;
                prod.productImage=product.productImage;
                productDbContext.SaveChanges();
                return prod;
            }
            else
            {
                throw new ProductNotFoundException("product not found");
            }
        }
    }
}
