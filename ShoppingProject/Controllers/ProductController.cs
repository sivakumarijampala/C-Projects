using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingProject.Exceptions;
using ShoppingProject.Models;
using ShoppingProject.Repository;

namespace ShoppingProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        public IProductRepo productRepo { get; set; }
        public ProductController(IProductRepo productRepo) { 
        this.productRepo = productRepo;
        }

        [HttpGet("getallproducts")]
        public ActionResult<IEnumerable<Product>> GetAllProducts()
        {
            try {
                IEnumerable<Product> products = productRepo.GetAllProducts();
                return products.ToList();
            }
            catch (ProductNotFoundException ex)
            {
               return NotFound(ex.Message);
            }
           
        }

        [HttpGet("getproductbyproductid/{productId}")]
        public ActionResult GetproductByProductId(int productId)
        {
            if(productId < 0)
            {
                return BadRequest(new { message = $"invalid product id:{productId}" });
            }
            try {
                Product product=productRepo.GetproductByProductId(productId);
                return Ok(new { message = $"product withid:{productId} fetched successfully", product });
            }
            catch (ProductNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
           
        }

        
        [HttpPost("saveproduct")]
        public ActionResult SaveProduct([FromBody]Product product)
        {
            if(product==null)
            {
                return BadRequest(new { message = $"invalid product data" });
            }
            try
            {
                Product createdproduct=productRepo.SaveProduct(product);
                return Ok(new { message = "student created successfully"});
            }
            catch(Exception ex)
            {
                return BadRequest(new {message=$"failed to save product:{ex.Message}"});
            }
        }

        [HttpDelete("deleteproduct/{productId}")]
        public ActionResult Deleteproduct(int productId)
        {
            if (productId < 0)
            {
                return BadRequest(new { message = $"prodcut with id :{productId} invalid" });
            }
            try
            {
                productRepo.DeleteProduct(productId);
                return Ok(new { message = $"product with id:{productId} deleted successfully" });
            }
            catch(ProductNotFoundException ex) 
            {
                return NotFound(ex.Message);
            }
        }


        [HttpPut("updateproduct/{productId}")]
        public ActionResult Updateproduct(int productId, Product product)
        {
            if (productId < 0)
            {
                return BadRequest(new { message = $"prodcut with id :{productId} invalid" });
            }
            try
            {
                Product prod=productRepo.UpdateProduct(productId, product);
                return Ok(new { message = $"product with id:{productId} updated successfully", prod });

            }
            catch(ProductNotFoundException ex)
            {
                return NotFound(ex.Message);
            }

        }  
    }
}
