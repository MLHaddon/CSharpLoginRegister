using System.ComponentModel.DataAnnotations;
namespace LoginRegister.Models
{
    public class User
    {
        [Required]
        [MinLength(2)]
        [Display(Name="First Name")]
        public string FirstName {get; set;}
        

        [Required]
        [MinLength(2)]
        [Display(Name="Last Name")]

        public string LastName {get; set;}
        

        [Required]
        [EmailAddress]
        public string Email {get; set;}
        

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password {get; set;}



        [DataType(DataType.Password)]
        [Compare("ConfirmPassword", ErrorMessage="Passwords Must Match.")]
        [Display(Name="Confirm Password")]
        public string ConfirmPassword {get; set;}
    }
}