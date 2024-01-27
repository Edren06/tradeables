using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Database.Models
{
    public class ProductDynamicAttributeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Foreign key to associate the dynamic attribute with a product
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public ProductModel Product { get; set; }

        // Name of the dynamic attribute (e.g., "Color", "Size", etc.)
        public string AttributeName { get; set; }

        // Value of the dynamic attribute
        public string AttributeValue { get; set; }
    }

}