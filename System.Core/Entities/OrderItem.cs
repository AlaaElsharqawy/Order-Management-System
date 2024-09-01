namespace System.Core.Entities
{
    public class OrderItem

    {
        public int OrderItemId { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }  //Navigitional property

        public int ProductId { get; set; }

        public Product product { get; set; }  //Navigitional property

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public decimal Discount { get; set; }
    }
}
