using System.ComponentModel.DataAnnotations;

namespace Bakery.WebApi.Dtos
{
    public class ProductUpdateDto
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string Category { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
