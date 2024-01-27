using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Database.Models
{
    public class ProductCategoryModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get;set;}
        public string Description {get;set;}
        public string Name {get;set;}

        public ICollection<ProductTypeModel> ProductTypes { get; set; }
        public ProductCategoryModel(string name, string description)
        {
            Description = description;
            Name = name;
            ProductTypes = new List<ProductTypeModel>();
        }
    }

}