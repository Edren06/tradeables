using Api.Database.Models;
using System.Collections.Generic;

public interface IProductService : IService<ProductModel>
{
    // Additional product-specific methods, if needed
    List<ProductCategoryWithCountDto> GetProductsGroupedByCategoryWithCount();
}

public class ProductService : Service<ProductModel, IProductRepository>, IProductService
{
    public ProductService(IProductRepository repository) : base(repository)
    {
    }

    public List<ProductCategoryWithCountDto> GetProductsGroupedByCategoryWithCount()
    {
        return _repository.GetProductsGroupedByCategoryWithCount();
    }
}