using Api.Database.Models;
using System.Collections.Generic;

public interface IProductCategoryService : IService<ProductCategoryModel>
{

}

public class ProductCategoryService : Service<ProductCategoryModel, IProductCategoryRepository>, IProductCategoryService
{
    public ProductCategoryService(IProductCategoryRepository repository) : base(repository)
    {
    }
}