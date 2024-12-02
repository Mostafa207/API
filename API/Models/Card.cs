using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Card
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 13, ErrorMessage = "Card number must be between 13 and 16 digits.")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Card number must contain only digits.")]
        public string CardNumber { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Cardholder name is too long.")]
        public string CardHolderName { get; set; }

        [Required]
        [Range(1, 12, ErrorMessage = "Month must be between 1 and 12.")]
        public int ExpiryMonth { get; set; }

        [Required]
        [Range(2024, 2100, ErrorMessage = "Year must be a valid future year.")]
        public int ExpiryYear { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "CVV must be 3 digits.")]
        [RegularExpression(@"^\d{3}$", ErrorMessage = "CVV must contain exactly 3 digits.")]
        public string CVV { get; set; }
        public List<Prodect> prodects { get; set; }

    }
}
