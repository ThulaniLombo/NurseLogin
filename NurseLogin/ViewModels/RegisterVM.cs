using System.ComponentModel.DataAnnotations;

namespace NurseLogin.ViewModels
{
    public class RegisterVM
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Compare("Password", ErrorMessage = "Passowrd do not match.")]
        [Display (Name = "Confirm Password")]
		[DataType(DataType.Password)]
		public string? ConfirmPassowrd { get; set; }

        [DataType(DataType.MultilineText)]
        public string? Address { get;}
    }
}
