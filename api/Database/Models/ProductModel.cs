using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Database.Models
{
    public class ProductModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get;set;}
        public string Description {get;set;}
        
        public int Year {get;set;}

        public string Name {get;set;}

        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public ProductCategoryModel? Category { get; set; }

        public int? ProductTypeId { get; set; }
        [ForeignKey("ProductTypeId")]
        public ProductTypeModel? ProductType { get; set; }

        public ICollection<ProductTagModel> ProductTags { get; set; }

        public ProductModel(string name, string description)
        {
            Description = description;
            Name = name;
            ProductTags = new List<ProductTagModel>();
        }
    }

}