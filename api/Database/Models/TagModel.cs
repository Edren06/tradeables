using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Database.Models
{
    public class TagModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get;set;}
        public string Description {get;set;}
        public string Name {get;set;}

        public ICollection<ProductTagModel> ProductTags { get; set; }

        public TagModel(string name, string description)
        {
            Description = description;
            Name = name;
            ProductTags = new List<ProductTagModel>();
        }
    }

}