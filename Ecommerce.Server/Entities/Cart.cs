namespace Ecommerce.Server.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public int? User_Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<CartDetail> cartDetails { get; set; }
        public Cart()
        {
            cartDetails = new List<CartDetail>();
        }

    }
}
