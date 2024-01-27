using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Api.Database.Models
{
    public class ProductTagModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductTagId { get;set; }
        public int ProductId { get; set; }
        public ProductModel Product { get; set; }

        public int TagId { get; set; }
        public TagModel Tag { get; set; }

        public ProductTagModel()
        {
            Product = new ProductModel("", "");
            Tag = new TagModel("", "");
        }
    }
}