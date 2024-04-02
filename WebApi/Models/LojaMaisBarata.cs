using Newtonsoft.Json;

namespace WebApi.Models;

public class LojaMaisBarata
{
    [JsonProperty(PropertyName = "dealID")]
    public string? DescontoId { get; set; }

    [JsonProperty(PropertyName = "storeID")]
    public string? LojaId { get; set; }

    [JsonProperty(PropertyName = "salePrice")]
    public string? PrecoVenda { get; set; }

    [JsonProperty(PropertyName = "retailPrice")]
    public string? PrecoOriginal { get; set; }
}
