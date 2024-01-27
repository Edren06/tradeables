using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Api.Database.Models
{
    public class ProductTypeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductTypeId { get;set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public ProductTypeModel()
        {
            Code = "NEW";
            Name = "New";
        }
    }
}