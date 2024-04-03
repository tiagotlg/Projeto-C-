using Newtonsoft.Json;

namespace WebApi.Models;

public class Loja
{
    [JsonProperty(PropertyName = "storeID")]
    public string? Id { get; set; }

    [JsonProperty(PropertyName = "storeName")]
    public string? Nome { get; set; }

    [JsonProperty(PropertyName = "isActive")]
    public int Status { get; set; }

    [JsonProperty(PropertyName = "images")]
    public ImagemLoja? ImagemLoja { get; set; }
}