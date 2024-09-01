namespace System.Core.Entities
{
    public class Invoice
    {
        public int InvoiceId { get; set; }

        public int OrderId { get; set; }

        public Order order { get; set; }  //Navigitional property

        public DateTimeOffset InvoiceDate { get; set; } = DateTimeOffset.Now;

        public decimal TotalAmount { get; set; }
    }
}
