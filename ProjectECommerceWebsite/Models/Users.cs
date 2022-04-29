using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace ProjectECommerceWebsite.Models
{
  [Table("Users")]
   
    public class Users
    {
        [Key]
        [ScaffoldColumn (false)]
        public int UserId { get; set; }
        [Display(Name ="User Name")]
        [Required]
        public string UserName { get; set; }
        [Display(Name = "Email Id")]
        [Required]
        [DataType (DataType.EmailAddress)]
        public string EmailId { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public int RoleId { get; set; }
    }
}
