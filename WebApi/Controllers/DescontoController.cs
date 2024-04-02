using System.Net;
using Microsoft.AspNetCore.Mvc;
using WebApi.Interfaces;

namespace WebApi.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class DescontoController : ControllerBase
{
    public readonly IDescontoService _descontoService;

    public DescontoController(IDescontoService descontoService)
    {
        _descontoService = descontoService;
    }

    [HttpGet("BuscaDescontoPorId/{descontoId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> BuscarDescontoId([FromRoute] string descontoId)
    {
        var response = await _descontoService.BuscaDescontoPorId(descontoId);

        if (response.CodigoHttp == HttpStatusCode.OK)
            return Ok(response.DadosRetorno);
        else
            return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
    }

    [HttpGet("BuscaPorDescontos")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> BuscaDescontos(int lojaId, int precoMaximo, int precoMinimo)
    {
        var response = await _descontoService.BuscaPorDescontos(lojaId, precoMaximo, precoMinimo);

        if (response.CodigoHttp == HttpStatusCode.OK)
            return Ok(response.DadosRetorno);
        else
            return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
    }
}
