using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace H4._01.RegisterNLogin.ViewModels
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Please enter your e-mail address")]
        [EmailAddress(ErrorMessage = "Please enter a valid-mail address")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter your password")]
        public string  Password { get; set; }

    }
}
