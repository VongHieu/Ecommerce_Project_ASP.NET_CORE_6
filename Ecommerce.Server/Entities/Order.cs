namespace Ecommerce.Server.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Consignee { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public decimal AmountTotal { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }
        public DateTime OrderDate { get; set; }
        public int? User_Id { get; set; }
        public ICollection<OrderDetail> orderDetails { get; set; }
        public Order()
        {
            orderDetails = new List<OrderDetail>();
        }

    }
}
