namespace System.Core.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();          //Navigational property
    }
}
