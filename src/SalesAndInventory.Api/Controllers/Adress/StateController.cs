using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesAndInventory.Communication.Request.Adress;
using SalesAndInventory.Communication.Response.Adress;

namespace SalesAndInventory.Api.Controllers.Adress
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        //crud
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddState([FromBody] RequestRegisterStateJson request)
        {
            return Created(string.Empty, "");
        }

        [HttpGet]
        [Route("{id:int}")]
        [ProducesResponseType(typeof(ResponseRegisterStateJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> GetState([FromRoute] int id, [FromBody] RequestRegisterStateJson request)
        {
            return Ok();
        }

        [HttpPatch]
        [Route("{id:long}")]
        [ProducesResponseType(typeof(ResponseRegisterStateJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateUser([FromRoute] long id, [FromBody] RequestRegisterStateJson request)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteState([FromRoute] int id)
        {
            return Ok();
        }

    }
}
