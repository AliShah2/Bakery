using System.ComponentModel.DataAnnotations;

namespace Bakery.WebApi.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string Category { get; set; }

        [Required]
        public double Price { get; set; }

        //Todo - to be added
        //description
        //Free from
        //ingredeints
        //images (with main image)

    }
}
