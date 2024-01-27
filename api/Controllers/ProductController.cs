using Api.Database;
using Api.Database.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController<ProductModel, IProductService>
    {
        public ProductController(IProductService productService) : base(productService)
        {
        }

        // Implement the abstract method to get the entity id
        protected override int GetEntityId(ProductModel entity)
        {
            return entity.Id;
        }

        // Get products grouped by category with count
        [HttpGet("grouped-with-count")]
        public IActionResult GetGroupedWithCount()
        {
            var productsWithCount = _service.GetProductsGroupedByCategoryWithCount();
            return Ok(productsWithCount);
        }
    }
}