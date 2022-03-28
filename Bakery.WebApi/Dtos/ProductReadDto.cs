using System.ComponentModel.DataAnnotations;

namespace Bakery.WebApi.Dtos
{
    public class ProductReadDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
    }
}
