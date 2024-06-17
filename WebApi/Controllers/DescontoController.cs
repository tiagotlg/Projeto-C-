using System.Net;
using Microsoft.AspNetCore.Mvc;
using WebApi.Interfaces;

namespace WebApi.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class DescontoController(IDescontoService descontoService) : ControllerBase
{
    public readonly IDescontoService _descontoService = descontoService;

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

    [HttpPost("BuscaPorDescontos")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> BuscaDescontos([FromBody] Request request)
    {
        var response = await _descontoService.BuscaPorDescontos(request.LojaId, request.PrecoMaximo, request.PrecoMinimo, request.SteamRating, request.PageNumber, request.PageSize);

        if (response.CodigoHttp == HttpStatusCode.OK)
            return Ok(response.DadosRetorno);
        else
            return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
    }

    [HttpGet("BuscaPorDescontosMenor/{lojaId:int}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> BuscaDescontosMenor([FromRoute] int lojaId)
    {
        var response = await _descontoService.BuscaPorDescontosMenor(lojaId);

        if (response.CodigoHttp == HttpStatusCode.OK)
            return Ok(response.DadosRetorno);
        else
            return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
    }
}


public class Request {
    public int LojaId { get; set;}
    public int PrecoMaximo { get; set;}
    public int PrecoMinimo { get; set;}
    public int SteamRating { get; set;}
    public int PageNumber { get; set;}
    public int PageSize { get; set;}
}