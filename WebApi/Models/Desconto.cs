using Newtonsoft.Json;

namespace WebApi.Models;

public class Desconto(InfoJogo infoJogo, List<LojaMaisBarata> lojaMaisBarata, PrecoMaisBarato precoMaisBarato)
{
    [JsonProperty(PropertyName = "gameInfo")]
    public InfoJogo InfoJogo { get; set; } = infoJogo;

    [JsonProperty(PropertyName = "cheaperStores")]
    public List<LojaMaisBarata> LojaMaisBarata { get; set; } = lojaMaisBarata;

    [JsonProperty(PropertyName = "cheapestPrice")]
    public PrecoMaisBarato PrecoMaisBarato { get; set; } = precoMaisBarato;
}