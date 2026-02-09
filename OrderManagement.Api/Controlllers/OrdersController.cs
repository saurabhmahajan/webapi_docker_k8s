

using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[Controller]")]
public class OrdersController(IOrderRepository repository) : ControllerBase
{
    [HttpGet]
    [Route("/health")]
    public IActionResult Health()
    {
        return Ok();
    }

    [HttpGet]
    [Route("api/orders")]
    public IActionResult Orders()
    {
        var orders = repository.GetAll();
        return Ok(orders);
    }
}