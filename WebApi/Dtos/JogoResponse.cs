using WebApi.Models;

namespace WebApi.Dtos;

public class JogoResponse
{
    public InfoJogo? Info { get; set; }

    public MaisBaratoSempreJogo? MaisBaratoSempre { get; set; }

    public List<DescontoJogo>? Desconto { get; set; }
}