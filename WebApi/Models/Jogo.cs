using Newtonsoft.Json;

namespace WebApi.Models;
public class Jogo
{
    [JsonProperty(PropertyName = "info")]
    public InfoJogo? InfoJogo { get; set; }

    [JsonProperty(PropertyName = "cheapestPriceEver")]
    public MaisBaratoSempreJogo? MaisBaratoSempreJogo { get; set; }

    [JsonProperty(PropertyName = "deals")]
    public List<DescontoJogo>? DescontoJogo { get; set; }
}