using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace GenieTaskIbrahim.Models
{
    [MetadataType(typeof(UserMetadata))]
    public partial class User
    {
        //add new attribut
        [Compare("Password", ErrorMessage = "Password does not match")]
        [Required(ErrorMessage = "You can't leave this empty.")]
        public string ConfPassword { get; set; }

    }

    public class UserMetadata
    {
        //edit new attribut

        public int ID { get; set; }

        [Required(ErrorMessage = "You can't leave this empty.")]
        [RegularExpression(@"^[a-zA-Z0-9 ]+$", ErrorMessage = "Please enter a valid name.")]

        public string Name { get; set; }
        
        [Required(ErrorMessage = "You can't leave this empty.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "You can't leave this empty.")]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "Minimum 6 Characters.")]
        public string Password { get; set; }
     

    }
}