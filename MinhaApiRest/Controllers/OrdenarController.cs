using Microsoft.AspNetCore.Mvc;

namespace MinhaApiRest.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdenarController : ControllerBase
{
    [HttpPost]
    public IActionResult OrdenarLista([FromBody] List<int> numeros)
    {
        numeros.Sort();
        return Ok(numeros);
    }
}