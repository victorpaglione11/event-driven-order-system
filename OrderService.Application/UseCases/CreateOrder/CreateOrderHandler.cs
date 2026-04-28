using BuildingBlocks.Contracts.Events;
using BuildingBlocks.EventBus;
using OrderService.Application.Interfaces;
using OrderService.Domain.Entities;

namespace OrderService.Application.UseCases.CreateOrder
{
    public class CreateOrderHandler
    {
        private readonly IOrderRepository _repository;
        private readonly IEventBus _eventBus;

        public CreateOrderHandler(
            IOrderRepository repository,
            IEventBus eventBus)
        {
            _repository = repository;
            _eventBus = eventBus;
        }

        public async Task<Guid> Handle(decimal amount)
        {
            var order = new Order(amount);

            await _repository.AddAsync(order);

            var orderCreatedEvent = new OrderCreatedEvent(order.Id, order.Amount);

            await _eventBus.PublishAsync(orderCreatedEvent);

            return order.Id;
        }
    }
}