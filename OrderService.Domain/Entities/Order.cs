namespace OrderService.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; private set; }
        public decimal Amount { get; private set; }
        public string Status { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public Order(decimal amount)
        {
            Id = Guid.NewGuid();
            Amount = amount;
            Status = "Created";
            CreatedAt = DateTime.UtcNow;
        }

        public void MarkAsPaid()
        {
            Status = "Paid";
        }

        public void MarkAsFailed()
        {
            Status = "Failed";
        }
    }
}

