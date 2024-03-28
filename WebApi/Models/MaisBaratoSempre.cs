using Newtonsoft.Json;

namespace WebApi.Models;

public class MaisBaratoSempre
{
    [JsonProperty(PropertyName = "price")]
    public string? PrecoMaisBarato { get; set; }

    [JsonProperty(PropertyName = "date")]
    public int? Data { get; set; }
}
