using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesAndInventory.Communication.Request.Adress;
using SalesAndInventory.Communication.Response.Adress;

namespace SalesAndInventory.Api.Controllers.Adress
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddCity([FromBody] RequestRegisterCityJson request)
        {
            return Created(string.Empty, "");
        }

        [HttpGet]
        [Route("{id:int}")]
        [ProducesResponseType(typeof(ResponseRegisterCityJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteCity([FromRoute] int id, [FromBody] RequestRegisterCityJson request)
        {
            return Ok();
        }

        [HttpPatch]
        [Route("{id:long}")]
        [ProducesResponseType(typeof(ResponseRegisterCityJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateCity([FromRoute] long id, [FromBody] RequestRegisterCityJson request)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteCity([FromRoute] int id)
        {
            return Ok();
        }
    }
}
