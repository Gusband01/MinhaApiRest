using Microsoft.AspNetCore.Mvc;
using MinhaApiRest.Data;
using MinhaApiRest.Models;

namespace MinhaApiRest.Controllers;

[ApiController]
[Route("api/mensagens")]
public class MensagensController : ControllerBase
{
    private readonly AppDbContext _context;
    
    public MensagensController(AppDbContext context)
    {
        _context = context;
    }
    
    [HttpGet]
    public IActionResult GetAll()
    {
        var mensagens = _context.Mensagens.ToList();
        return Ok(mensagens);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var mensagem = _context.Mensagens.Find(id);
        if (mensagem == null) return NotFound();
        return Ok(mensagem);
    }
    
    [HttpPost]
    public IActionResult Create([FromBody] Mensagem mensagem)
    {
        _context.Mensagens.Add(mensagem);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetById), new { id = mensagem.Id }, mensagem);
    }
    
    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Mensagem mensagemAtualizada)
    {
        var mensagem = _context.Mensagens.Find(id);
        if (mensagem == null) return NotFound();

        mensagem.Texto = mensagemAtualizada.Texto;
        _context.SaveChanges();
        return NoContent();
    }
    
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var mensagem = _context.Mensagens.Find(id);
        if (mensagem == null) return NotFound();

        _context.Mensagens.Remove(mensagem);
        _context.SaveChanges();
        return NoContent();
    }
}