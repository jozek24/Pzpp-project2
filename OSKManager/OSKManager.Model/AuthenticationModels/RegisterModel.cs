using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OSKManager.Api.Models
{
    public class RegisterModel
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Length must be less then 50 characters.")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Length must be less then 50 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email jest wymagany.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Hasło jest wymagane.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare(nameof(Password),ErrorMessage = "Hasła nie są zgodne.")]
        public string ConfirmPassword { get; set; }

        public string TypeOfRole { get; set; }

    }
}
