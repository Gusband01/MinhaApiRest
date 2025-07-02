using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace MinhaApiRest.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CepController : ControllerBase
{
    private readonly HttpClient _httpClient;

    public CepController(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient();
    }

    [HttpGet("{cep}")]
    public async Task<IActionResult> ConsultarCep(string cep)
    {
        cep = cep.Replace("-", "").Trim();
        
        if (cep.Length != 8 || !cep.All(char.IsDigit))
            return BadRequest("CEP inválido. Use o formato 12345678.");

        var url = $"https://viacep.com.br/ws/{cep}/json/";

        try
        {
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return Ok(JsonDocument.Parse(json));
        }
        catch (HttpRequestException)
        {
            return StatusCode(503, "Não foi possível consultar o CEP no momento.");
        }
    }
}