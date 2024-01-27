using Api.Database;
using Api.Database.Models;

public class ProductRepository : BaseRepository<ProductModel>, IProductRepository
{
    public ProductRepository(AppDbContext context) : base(context)
    {
    }
}

public interface IProductRepository : IBase<ProductModel>
{

}