using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Server.Entities
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Details { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        [Range(0, 100, ErrorMessage = "Không vượt quá phần trăm!")]
        public float PercentageDiscount { get; set; }
        public bool Status { get; set; }
        public ICollection<Product> products { get; set; }
        public ICollection<ProductCategory> productCategories { get; set; }
        public Promotion()
        {
            productCategories = new HashSet<ProductCategory>();
            products = new HashSet<Product>();
        }

    }
}
