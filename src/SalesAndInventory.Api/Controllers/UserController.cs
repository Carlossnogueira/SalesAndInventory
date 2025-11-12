using Microsoft.AspNetCore.Mvc;
using SalesAndInventory.Communication.Request;
using SalesAndInventory.Communication.Response;

namespace SalesAndInventory.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    // CREATE READ UPDATE DELETE
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> AddUser([FromBody] RequestRegisterUserJson request)
    {
        return Created(string.Empty, "");
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
    [ProducesResponseType(typeof(ResponseRegisterUserJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateUser([FromRoute] long id)
    {
        return Ok();
    }
}