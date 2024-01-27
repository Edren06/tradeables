using Api.Database;
using Api.Database.Models;

public class UserRepository : BaseRepository<UserModel>, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context)
    {
    }
}

public interface IUserRepository : IRepository<UserModel>
{

}