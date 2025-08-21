using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // GET: api/calculator/sum?a=5&b=7
        [HttpGet("sum")]
        public IActionResult GetSum([FromQuery] int a, [FromQuery] int b)
        {
            int result = a + b;
            return Ok(new { operation = "sum", a, b, result });
        }

        // GET: api/calculator/sub?a=10&b=4
        [HttpGet("sub")]
        public IActionResult GetSub([FromQuery] int a, [FromQuery] int b)
        {
            int result = a - b;
            return Ok(new { operation = "sub", a, b, result });
        }
        
        // GET: api/calculator/mul?a=3&b=4
        [HttpGet("mul")]
        public IActionResult GetMul([FromQuery] int a, [FromQuery] int b)
        {
            int result = a * b;
            return Ok(new { operation = "mul", a, b, result });
        }

        // GET: api/calculator/div?a=8&b=3
        [HttpGet("div")]
        public IActionResult GetDiv([FromQuery] int a, [FromQuery] int b)
        {
            if (b == 0)
                return BadRequest(new { operation = "div", a, b, error = "Division by zero is not allowed." });

            // Si prefieres resultado decimal, cambia a: double result = (double)a / b;
            double result = (double)a / b;
            return Ok(new { operation = "div", a, b, result });
        }
    }
}