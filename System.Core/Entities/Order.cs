namespace System.Core.Entities
{
    public class Order
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }      //Navigational Property

        public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;

        public decimal TotalAmount { get; set; }

        public ICollection<OrderItem> orderItems { get; set; } = new HashSet<OrderItem>();

        public string PaymentMethod { get; set; }

        public string Status { get; set; }
    }
}
