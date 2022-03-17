using System.ComponentModel.DataAnnotations;

namespace H4._01.RegisterNLogin.ViewModels
{
    public class UserRegisterViewModel
    {
        [Display(Name="Last Name")]
        [Required(ErrorMessage = "{0} is a required field")]
        public string Name { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "{0} is a required field")]
        public string FirstName { get; set; }

        [Display (Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Please enter a valid e-mail address")]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} is a required field")]
        [MinLength(6, ErrorMessage ="{0} must be at least {1} characters")]
        public string PassWord { get; set; }

        [Display(Name = "Repeat password")]
        [DataType(DataType.Password)]
        [Compare(nameof(PassWord), ErrorMessage = "The passwords you entered do not match")]
        public string PassWordRepeat { get; set; }

    }
}
