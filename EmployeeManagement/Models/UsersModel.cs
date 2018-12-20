using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.API
{
    public class SignUpModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        public int RoleId { get; set; }

        [Required]
        public int Manager { get; set; } 


    }

    public class EmployeeModel
    {
       public string Email { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }


    }

    public class LoginModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }

}
