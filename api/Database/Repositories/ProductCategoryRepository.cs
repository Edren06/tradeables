using Api.Database;
using Api.Database.Models;

public class ProductCategoryRepository : BaseRepository<ProductCategoryModel>, IProductCategoryRepository
{
    public ProductCategoryRepository(AppDbContext context) : base(context)
    {
    }
}

public interface IProductCategoryRepository : IBase<ProductCategoryModel>
{

}