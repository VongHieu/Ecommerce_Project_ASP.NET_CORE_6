namespace Ecommerce.Server.Entities
{
    public class OrderDetail
    {
        public int Product_Id { get; set; }
        public int Order_Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Product GetProduct { get; set; }
        public Order GetOrder { get; set; }
    }
}
