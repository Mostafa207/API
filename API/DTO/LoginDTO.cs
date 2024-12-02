using System.ComponentModel.DataAnnotations;

namespace API.DTO
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Enter Email ")]
        [DataType(DataType.EmailAddress, ErrorMessage = "=Enter Email correct")]
        public string Email { get; set; }
        //---------------
        [Required(ErrorMessage = "Enter Password ")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,20}$",
        ErrorMessage = "Password must be 8-20 characters long, include at least one uppercase letter, one lowercase letter, one digit, and one special character.")]
        public string Password { get; set; }
    }
}
