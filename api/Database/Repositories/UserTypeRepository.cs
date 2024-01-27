using Api.Database;
using Api.Database.Models;

public class UserTypeRepository : BaseRepository<UserTypeModel>, IUserTypeRepository
{
    public UserTypeRepository(AppDbContext context) : base(context)
    {
    }
}

public interface IUserTypeRepository : IRepository<UserTypeModel>
{

}