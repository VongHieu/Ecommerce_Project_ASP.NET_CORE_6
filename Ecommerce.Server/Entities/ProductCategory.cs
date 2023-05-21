namespace Ecommerce.Server.Entities
{
    public class ProductCategory : Date
    {
        public int Id { get; set; }
        public string Name { get; }
        public string? Description { get; }
        public string SEOAlias { get; }
        public string? SEOTitle { get; }
        public int Category_Id { get; }
        public int? Promotion_Id { get; set; }
        public ICollection<Product> products { get; set; }
        public Category GetCategory { get; set; }
        public Promotion GetPromotion { get; set; }
        public ICollection<Advertisement> advertisements { get; set; }
        public ProductCategory()
        {
            products = new List<Product>();
            advertisements = new List<Advertisement>();
        }

    }
}
