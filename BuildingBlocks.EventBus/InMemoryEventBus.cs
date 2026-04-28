namespace BuildingBlocks.EventBus
{
    public class InMemoryEventBus : IEventBus
    {
        public Task PublishAsync<T>(T @event)
        {
            Console.WriteLine($"EVENT PUBLISHED: {typeof(T).Name}");
            return Task.CompletedTask;
        }
    }
}