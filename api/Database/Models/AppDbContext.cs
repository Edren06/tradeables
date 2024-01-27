using Api.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Add DbSet properties for your models
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<ProductCategoryModel> ProductCategorys { get;set; }
        public DbSet<ProductTagModel> ProductTags { get;set; }
        public DbSet<TagModel> Tags { get;set; }
        public DbSet<UserModel> Users { get;set; }
        public DbSet<UserTypeModel> UserTypes { get;set; }
        public DbSet<ProductTypeModel> ProductTypes { get;set; }

        // Add other DbSet properties as needed
    }
}