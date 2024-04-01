using WebApi.Models;

namespace WebApi.Dtos;

public class JogoResponse
{
    public InfoJogo? InfoJogo { get; set; }

    public MaisBaratoSempreJogo? MaisBaratoSempreJogo { get; set; }

    public List<DescontoJogo>? DescontoJogo { get; set; }
}