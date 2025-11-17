using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesAndInventory.Communication.Request.Adress;
using SalesAndInventory.Communication.Response.Adress;

namespace SalesAndInventory.Api.Controllers.Adress
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdressController : ControllerBase
    {
        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddAdress([FromBody] RequestRegisterAdressJson request)
        {
            return Created(string.Empty, "");
        }

        [HttpGet]
        [Route("{id:int}")]
        [ProducesResponseType(typeof(ResponseRegisterAdressJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteAdress([FromRoute] int id, [FromBody] RequestRegisterAdressJson request)
        {
            return Ok();
        }

        [HttpPatch]
        [Route("{id:long}")]
        [ProducesResponseType(typeof(ResponseRegisterAdressJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateUpdateAdress([FromRoute] long id, [FromBody] RequestRegisterAdressJson request)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteAdress([FromRoute] int id)
        {
            return Ok();
        }
    }
}
