using Api.Database;
using Api.Database.Models;

public class TagRepository : BaseRepository<TagModel>, ITagRepository
{
    public TagRepository(AppDbContext context) : base(context)
    {
    }
}

public interface ITagRepository : IRepository<TagModel>
{

}