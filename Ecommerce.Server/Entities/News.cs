namespace Ecommerce.Server.Entities
{
    public class News : Date
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public string? Detail { get; set; }
        public string SEOAlias { get; set; }
        public int Category_Id { get; set; }
        public Category GetCategory { get; set; }


    }
}
