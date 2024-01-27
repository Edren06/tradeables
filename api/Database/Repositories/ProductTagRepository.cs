using Api.Database;
using Api.Database.Models;

public class ProductTagRepository : BaseRepository<ProductTagModel>, IProductTagRepository
{
    public ProductTagRepository(AppDbContext context) : base(context)
    {
    }
}

public interface IProductTagRepository : IRepository<ProductTagModel>
{

}