using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Database.Models
{
    public class UserTypeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get;set;}
        public string Name {get;set;}
        public string Code {get;set;}
        public string Description {get;set;}


        public UserTypeModel()
        {
            Name = "";
            Code = "";
            Description = "";
        }
    }

}