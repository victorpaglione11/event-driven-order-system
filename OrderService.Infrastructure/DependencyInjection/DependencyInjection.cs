using BuildingBlocks.EventBus;
using Microsoft.Extensions.DependencyInjection;
using OrderService.Application.Interfaces;
using OrderService.Infrastructure.Repositories;

namespace OrderService.Infrastructure.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IOrderRepository, InMemoryOrderRepository>();
            services.AddSingleton<IEventBus, InMemoryEventBus>();

            return services;
        }
    }
}