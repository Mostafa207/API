using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        //---------------
        [Required(ErrorMessage ="Enter Frist name")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string FristName { get; set; }
        //---------------
        [Required(ErrorMessage = "Enter List name")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string ?LastName { get; set; }
        //---------------
        [Required(ErrorMessage ="Enter Age ")]
        public int Age { get; set; }
        //---------------
        [Required(ErrorMessage = "Enter Email ")]
        [DataType(DataType.EmailAddress,ErrorMessage ="=Enter Email correct")]  
        public string Email { get; set; }
        //---------------
        [Required(ErrorMessage = "Enter Password ")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,20}$",
        ErrorMessage = "Password must be 8-20 characters long, include at least one uppercase letter, one lowercase letter, one digit, and one special character.")]
        public string Password { get; set; }
        //---------------
        [Required(ErrorMessage = "Enter Phone ")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "=Enter Phone correct")]
        public string Phone { get; set; }
        //---------------
        [Required(ErrorMessage = "Enter Location")]
        [StringLength(100, ErrorMessage = "Location must be at most 100 characters long")]
        public string Location { get; set; }

        public List<Card> Cards { get; set; }

    }
}
