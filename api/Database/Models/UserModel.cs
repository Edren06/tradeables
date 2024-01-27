using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Database.Models
{
    public class UserModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get;set;}
        public string Firstname {get;set;}
        public string Surname {get;set;}
        public string Email {get;set;}
        public string Password { get;set; }
        public string ConfirmPassword { get;set; }
        public int? UserTypeId { get; set; }
        [ForeignKey("UserTypeId")]
        public UserTypeModel? UserType { get; set; }
        public UserModel()
        {
            Firstname = "";
            Surname = "";
            Email = "";
            Password = "";
            ConfirmPassword = "";
        }
    }

}