namespace Ecommerce.Server.Entities
{
    public class Product : Date
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Thumbnail { get; set; }
        public string? Images { get; set; }
        public string? Description { get; set; }
        public string? Detail { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Stock { get; set; }
        public string? SEOTitle { get; set; }
        public string SEOAlias { get; set; }
        public bool Status { get; set; }
        public int? ViewCount { get; set; }
        public int ProductCategory_Id { get; set; }
        public int? Promotion_Id { get; set; }
        public ProductCategory GetProductCategory { get; set; }
        public Promotion GetPromotion { get; set; }
        public ICollection<OrderDetail> orderDetails { get; set; }
        public ICollection<CartDetail> cartDetails { get; set; }
        public Product()
        {
            orderDetails = new List<OrderDetail>();
            cartDetails = new List<CartDetail>();
        }

    }
}
