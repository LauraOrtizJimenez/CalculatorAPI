using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route(template: "api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet(template: "sum")]
        public IActionResult GetSum([FromQuery] int a, [FromQuery] int b)
        {
            int result = a + b;
            return Ok(new { a, b, result })

        }

        public IActionResult GetSub([FromQuery] int a, [FromQuery] int b)
        {
            int result = a - b;
            return Ok(new { operation = "sub", a, b, result });
        }

        public IActionResult GetMult([FromQuery] int a, [FromQuery] int b)
        {
            int result = a * b;
            return Ok(new { operation = "Mult", a, b, result });
        }

        public IActionResult GetDiv([FromQuery] int a, [FromQuery] int b)
        {
            if (b == 0)
                return BadRequest(new { operation = "div", a, b, error = "Division by zero is not allowed." });
        }
    }
}