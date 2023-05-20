namespace Ecommerce.Server.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Category_Id { get; set; }
        public Category GetCategory { get; set; }

    }
}
