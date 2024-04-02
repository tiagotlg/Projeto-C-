using WebApi.Models;

namespace WebApi.Dtos;

public class DescontoResponse
{
    public InfoJogo? InfoJogo { get; set; }

    public List<LojaMaisBarata>? LojaMaisBarata { get; set; }

    public PrecoMaisBarato? PrecoMaisBarato { get; set; }
}
