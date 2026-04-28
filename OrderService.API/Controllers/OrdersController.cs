using Microsoft.AspNetCore.Mvc;
using OrderService.API.Models;
using OrderService.Application.UseCases.CreateOrder;

namespace OrderService.API.Controllers
{
    [ApiController]
    [Route("orders")]
    public class OrdersController : ControllerBase
    {
        private readonly CreateOrderHandler _handler;

        public OrdersController(CreateOrderHandler handler)
        {
            _handler = handler;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateOrderRequest request)
        {
            var orderId = await _handler.Handle(request.Amount);

            return Ok(new { OrderId = orderId });
        }
    }
}