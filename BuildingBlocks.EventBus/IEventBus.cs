namespace BuildingBlocks.EventBus
{
    public interface IEventBus
    {
        Task PublishAsync<T>(T @event);
    }
}