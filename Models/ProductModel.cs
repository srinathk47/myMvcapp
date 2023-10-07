using System.ComponentModel.DataAnnotations;

namespace Myapplicationsln.Models
{
    public class ProductModel: MainModel
    {
        [Required]
        public string? ProductName { get; set; }

        public string? Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal Count { get; set; }

        public string? ImgURL { get; set; }

        public Guid CategoryId { get; set; }

        public CategoryModel? Category { get; set; }
    }
}
