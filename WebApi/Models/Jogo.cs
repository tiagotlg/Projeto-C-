using Newtonsoft.Json;

namespace WebApi.Models;
public class Jogo
{
    [JsonProperty(PropertyName = "info")]
    public Info? Info { get; set; }

    [JsonProperty(PropertyName = "cheapestPriceEver")]
    public MaisBaratoSempre? MaisBaratoSempre { get; set; }

    [JsonProperty(PropertyName = "deals")]
    public List<Desconto>? Desconto { get; set; }
}