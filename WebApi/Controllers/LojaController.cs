using System.Net;
using Microsoft.AspNetCore.Mvc;
using WebApi.Interfaces;

namespace WebApi.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class LojaController(ILojaService lojaService) : ControllerBase
{
    public readonly ILojaService _lojaService = lojaService;

    [HttpGet("BuscarLoja")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> BuscarPorLojas()
    {
        var response = await _lojaService.BuscarLoja();

        if (response.CodigoHttp == HttpStatusCode.OK)
            return Ok(response.DadosRetorno);
        else
            return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
    }
}
