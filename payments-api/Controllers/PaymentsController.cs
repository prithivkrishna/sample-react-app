using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace payments_api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PaymentsController : ControllerBase
{
    private class Response
    {
        public DateTime ResponseDate { get; set; }
        public bool Value { get; set; }
    }

    [HttpGet]
    [EnableCors]
    public IActionResult Get()
    {
        return Ok(new Response
        {
            ResponseDate = DateTime.UtcNow,
            Value = true
        });
    }
}
