using Newtonsoft.Json;

namespace WebApi.Models;

public class Desconto
{
    [JsonProperty(PropertyName = "storeID")]
    public string? LojaId { get; set; }

    [JsonProperty(PropertyName = "dealID")]
    public string? DescontoID { get; set; }

    [JsonProperty(PropertyName = "price")]
    public string? PrecoDesconto { get; set; }

    [JsonProperty(PropertyName = "retailPrice")]
    public string? PrecoOriginal { get; set; }

    [JsonProperty(PropertyName = "savings")]
    public string? Salvo { get; set; }
}
