using Newtonsoft.Json;

namespace WebApi.Models;

public class PrecoMaisBarato(string? preco, string? data)
{
    [JsonProperty(PropertyName = "price")]
    public string? Preco { get; set; } = preco;

    [JsonProperty(PropertyName = "date")]
    public string? Data { get; set; } = data;
}
