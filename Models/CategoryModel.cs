using System.ComponentModel.DataAnnotations;

namespace Myapplicationsln.Models
{
    public class CategoryModel : MainModel
    {
        public CategoryModel()
        {
            Products = new HashSet<ProductModel>();

        }
        [Required]
        public string Name { get; set; }

        public ICollection<ProductModel> Products { get; set; }

    }
}
