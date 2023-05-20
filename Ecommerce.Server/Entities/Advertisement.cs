namespace Ecommerce.Server.Entities
{
    public class Advertisement
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string? Link { get; set; }
        public bool Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int ProductCategory_Id { get; set; }
        public ProductCategory GetProductCategory { get; set; }

    }
}
