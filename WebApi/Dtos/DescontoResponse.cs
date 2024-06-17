using WebApi.Models;

namespace WebApi.Dtos;

public class DescontoResponse(InfoJogo infoJogo, List<LojaMaisBarata> lojaMaisBarata, PrecoMaisBarato precoMaisBarato)
{
    public InfoJogo InfoJogo { get; set; } = infoJogo;

    public List<LojaMaisBarata> LojaMaisBarata { get; set; } = lojaMaisBarata;

    public PrecoMaisBarato PrecoMaisBarato { get; set; } = precoMaisBarato;
}
