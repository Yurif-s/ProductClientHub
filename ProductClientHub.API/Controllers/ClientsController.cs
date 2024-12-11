using Microsoft.AspNetCore.Mvc;

namespace ProductClientHub.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ClientsController : ControllerBase
{
    [HttpPost]
    public IActionResult Register()
    {
        return Ok();
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok();
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok();
    }

    [HttpPut]
    public IActionResult Put()
    {
        return Ok();
    }

    [HttpDelete]
    public IActionResult Delete()
    {
        return Ok();
    }
}
