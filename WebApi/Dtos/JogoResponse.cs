using WebApi.Models;

namespace WebApi.Dtos;

public class JogoResponse
{
    public Info? Info { get; set; }

    public MaisBaratoSempre? MaisBaratoSempre { get; set; }

    public List<Desconto>? Desconto { get; set; }
}