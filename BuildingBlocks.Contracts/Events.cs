namespace BuildingBlocks.Contracts.Events
{
    public record OrderCreatedEvent(Guid OrderId, decimal Amount);
}