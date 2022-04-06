using System.ComponentModel.DataAnnotations;

namespace Test_Series.Models
{
    public class SignUpViewModel
    {
        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string Lastname { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Level { get; set; }

        [Required]
        public string Edition { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Password and Confirm Password must match")]
        public string Confirm { get; set; } 
    }
}
