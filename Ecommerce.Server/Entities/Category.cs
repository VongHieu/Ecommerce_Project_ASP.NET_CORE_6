namespace Ecommerce.Server.Entities
{
    public class Category : Date
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? SEOTitle { get; set; }
        public string SEOAlias { get; set; }

        public ICollection<ProductCategory> productCategories { get; set; }
        public ICollection<News> news { get; set; }
        public ICollection<Contact> contacts { get; set; }
        public Category()
        {
            productCategories = new HashSet<ProductCategory>();
            news = new HashSet<News>();
            contacts = new HashSet<Contact>();
        }

    }
}
