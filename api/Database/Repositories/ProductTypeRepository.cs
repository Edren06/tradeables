using api.Migrations;
using Api.Database;
using Api.Database.Models;

public class ProductTypeRepository : BaseRepository<ProductTypeModel>, IProductTypeRepository
{
    public ProductTypeRepository(AppDbContext context) : base(context)
    {
    }
}

public interface IProductTypeRepository : IRepository<ProductTypeModel>
{

}