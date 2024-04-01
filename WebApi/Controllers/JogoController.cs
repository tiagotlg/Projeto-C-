using System.Net;
using Microsoft.AspNetCore.Mvc;
using WebApi.Interfaces;

namespace WebApi.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class JogoController : ControllerBase
{
    public readonly IJogoService _jogoService;

    public JogoController(IJogoService jogoService)
    {
        _jogoService = jogoService;
    }

    [HttpGet("BuscaPorId/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> BuscarJogoId([FromRoute] string id)
    {
        var response = await _jogoService.BuscaJogoPorId(id);

        if (response.CodigoHttp == HttpStatusCode.OK)
            return Ok(response.DadosRetorno);
        else
            return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
    }

    [HttpGet("BuscaPorNome/{nome}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> BuscarJogoNome([FromRoute] string nome)
    {
        var response = await _jogoService.BuscarPorNome(nome);

        if (response.CodigoHttp == HttpStatusCode.OK)
            return Ok(response.DadosRetorno);
        else
            return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
    }
}
