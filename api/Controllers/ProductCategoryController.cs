using Api.Database;
using Api.Database.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : BaseController<ProductCategoryModel, IProductCategoryService>
    {
        public ProductCategoryController(IProductCategoryService productCategoryService) : base(productCategoryService)
        {
        }

        // Implement the abstract method to get the entity id
        protected override int GetEntityId(ProductCategoryModel entity)
        {
            return entity.Id;
        }
    }
}