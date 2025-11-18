using Microsoft.AspNetCore.Mvc;
using SaleAndInventory.Application.UseCase.User.Register;
using SalesAndInventory.Communication.Request;
using SalesAndInventory.Communication.Response;

namespace SalesAndInventory.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterUserJson),StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> AddUser(
        [FromBody] RequestRegisterUserJson request, 
        [FromServices] IRegisterUserUseCase service)
    {
        var result = await service.Execute(request);
        return Created(string.Empty, result);
    }
    
    [HttpGet]
    [Route("{id:long}")]
    [ProducesResponseType(typeof(ResponseRegisterUserJson),StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> GetUser([FromRoute]  long id)
    {
        return Ok();
    }

    [HttpPatch]
    [Route("{id:long}")]
    [ProducesResponseType(typeof(ResponseRegisterUserJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateUser([FromRoute] long id, [FromBody] RequestRegisterUserJson request)
    {
        return Ok();
    }
    
    [HttpDelete]
    [Route("{id:long}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateUser([FromRoute] long id)
    {
        return Ok();
    }
}