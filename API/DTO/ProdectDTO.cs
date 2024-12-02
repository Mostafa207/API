using System.ComponentModel.DataAnnotations;

namespace API.DTO
{
    public class ProdectDTO
    {
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public decimal Price { get; set; }
    }
}
