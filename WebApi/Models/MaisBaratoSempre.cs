using Newtonsoft.Json;

namespace WebApi.Models;

public class MaisBaratoSempreJogo(string? precoMaisBarato, int? data)
{
    [JsonProperty(PropertyName = "price")]
    public string? PrecoMaisBarato { get; set; } = precoMaisBarato;

    [JsonProperty(PropertyName = "date")]
    public int? Data { get; set; } = data;
}
