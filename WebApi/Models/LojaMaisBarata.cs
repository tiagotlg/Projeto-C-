using Newtonsoft.Json;

namespace WebApi.Models;

public class LojaMaisBarata(string descontoId, string lojaId, string precoVenda, string precoOriginal)
{
    [JsonProperty(PropertyName = "dealID")]
    public string DescontoId { get; set; } = descontoId;

    [JsonProperty(PropertyName = "storeID")]
    public string LojaId { get; set; } = lojaId;

    [JsonProperty(PropertyName = "salePrice")]
    public string PrecoVenda { get; set; } = precoVenda;

    [JsonProperty(PropertyName = "retailPrice")]
    public string PrecoOriginal { get; set; } = precoOriginal;
}
