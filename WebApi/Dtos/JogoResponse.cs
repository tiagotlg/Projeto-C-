using WebApi.Models;

namespace WebApi.Dtos;

public class JogoResponse
{
    public InfoJogoResumo? InfoJogoResumo { get; set; }

    public MaisBaratoSempreJogo? MaisBaratoSempreJogo { get; set; }

    public List<DescontoJogoResumo>? DescontoJogoResumo { get; set; }
}