using Newtonsoft.Json;

namespace WebApi.Models;

public class PrecoMaisBarato
{
    [JsonProperty(PropertyName = "price")]
    public string? Preco { get; set; }

    [JsonProperty(PropertyName = "date")]
    public string? Data { get; set; }
}
