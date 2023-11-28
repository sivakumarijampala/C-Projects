using System.ComponentModel.DataAnnotations;

namespace ShoppingProject.Models
{
    public class Product
    {
        [Key]
        public int productId { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public double productPrice { get; set; }
        public string productImage { get; set; }
    }
}
