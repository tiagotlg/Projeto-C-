using Newtonsoft.Json;

namespace WebApi.Models;

public class Desconto
{
    [JsonProperty(PropertyName = "gameInfo")]
    public InfoJogo? InfoJogo { get; set; }

    [JsonProperty(PropertyName = "cheaperStores")]
    public List<LojaMaisBarata>? LojaMaisBarata { get; set; }

    [JsonProperty(PropertyName = "cheapestPrice")]
    public PrecoMaisBarato? PrecoMaisBarato { get; set; }
}