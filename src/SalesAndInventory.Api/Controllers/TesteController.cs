using Microsoft.AspNetCore.Mvc;
using SalesAndInventory.Communication.Response;
using SalesAndInventory.Exception;

namespace SalesAndInventory.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TesteController : ControllerBase
{

    [HttpPost]
    public IActionResult exception([FromBody] int number)
    {
        if (number < 1)
        {
            var list = new List<string>() { "Erro legal", "Erro bacana" };
            throw new ErrorOnValidationException(list);
        }

        if (number > 1)
        {
            throw new System.Exception("Erro traisueiro");
        }

        return Ok();
    }
    
}