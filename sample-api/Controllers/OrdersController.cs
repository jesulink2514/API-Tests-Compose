using Microsoft.AspNetCore.Mvc;
using sample_api.DTOs;
using sample_api.Models;

namespace sample_api.Controllers;

[ApiController]
[Route("[controller]")]
public class OrdersController: ControllerBase{

    private readonly OrderService _orderService;
    private readonly BookService _bookService;

    public OrdersController(OrderService orderService, BookService bookService)
    {    
        _orderService = orderService;
        _bookService = bookService;
    }

    [HttpGet(Name = "GetOrders")]
    public async Task<IEnumerable<Order>> Get()
    {
        return await _orderService.GetOrders();
    }

    [HttpGet("{id}", Name = "GetOrderById")]
    public async Task<Order> Get(int id)
    {
        return await _orderService.GetOrderById(id);
    }

    [HttpPost(Name = "RegisterOrder")]
    public async Task<ActionResult<Order>> Post([FromBody] CreateOrder order)
    {
        if (order == null) return BadRequest();

        var book = _bookService.GetById(order.BookId);

        var newOrder = new Order
        {
            BookId = order.BookId,
            Title = book.Title,
            Amount = book.Price
        };

        var created = await _orderService.Register(newOrder);
        return CreatedAtAction(nameof(Get), new {id= created.Id},created);
    }

}
