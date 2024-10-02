using Microsoft.AspNetCore.Mvc;
using Prova_H1_1BIM.Services;
using Prova_H1_1BIM.Models;

namespace Prova_H1_1BIM.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ChurrasController : ControllerBase
{
    private readonly IChurrasRepository _churrasRepository;

    public ChurrasController(IChurrasRepository churrasRepository)
    {
        _churrasRepository = churrasRepository;
    }

    [HttpGet]
    [Route("ObterTodos")]
    public IActionResult ObterTodos()
    {
        return Ok(_churrasRepository.ObterTodosParticipantes());
    }
    
    [HttpPost]
    [Route("InserirParticipante")]
    public IActionResult Inserir(Participantes novoParticipante)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _churrasRepository.Inserir(new Participantes()
        {
            Nome = novoParticipante.Nome,
            DescricaoCarne = novoParticipante.DescricaoCarne,
            DescricaoBebida = novoParticipante.DescricaoBebida,
            Idade = novoParticipante.Idade
        });


        return Ok($"Participante {novoParticipante.Nome} inserido com sucesso, aproveite as carnes.");
    }
}
