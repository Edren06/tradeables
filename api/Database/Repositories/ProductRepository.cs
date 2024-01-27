using Api.Database;
using Api.Database.Models;

public class ProductRepository : BaseRepository<ProductModel>, IProductRepository
{
    private readonly AppDbContext _dbContext;
    public ProductRepository(AppDbContext context) : base(context)
    {
        _dbContext = context;
    }

    public List<ProductCategoryWithCountDto> GetProductsGroupedByCategoryWithCount()
    {
        return _dbContext.ProductCategories
            .GroupJoin(
                _dbContext.Products,
                pc => pc.Id,
                p => p.CategoryId,
                (pc, products) => new ProductCategoryWithCountDto
                {
                    CategoryId = pc.Id,
                    CategoryName = pc.Name,
                    ProductCount = products.Count()
                })
            .ToList();
    }
}

public interface IProductRepository : IRepository<ProductModel>
{
    // Additional methods specific to product repository, if needed
    List<ProductCategoryWithCountDto> GetProductsGroupedByCategoryWithCount();
}