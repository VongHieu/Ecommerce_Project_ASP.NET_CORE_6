namespace Ecommerce.Server.Entities
{
    public class CartDetail
    {
        public int Cart_Id { get; set; }
        public int Product_Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Product GetProduct { get; set; }
        public Cart GetCart { get; set; }

    }
}
