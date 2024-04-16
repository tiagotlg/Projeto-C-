using Newtonsoft.Json;

namespace WebApi.Models;

public class DescontoJogoResumo(string? lojaId, string? descontoID, string? precoDesconto, string? precoOriginal, string? salvo)
{
    [JsonProperty(PropertyName = "storeID")]
    public string? LojaId { get; set; } = lojaId;

    [JsonProperty(PropertyName = "dealID")]
    public string? DescontoID { get; set; } = descontoID;

    [JsonProperty(PropertyName = "price")]
    public string? PrecoDesconto { get; set; } = precoDesconto;

    [JsonProperty(PropertyName = "retailPrice")]
    public string? PrecoOriginal { get; set; } = precoOriginal;

    [JsonProperty(PropertyName = "savings")]
    public string? Salvo { get; set; } = salvo;
}
