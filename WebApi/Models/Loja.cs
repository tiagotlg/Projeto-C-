using Newtonsoft.Json;

namespace WebApi.Models;

public class Loja(string id, string nome, int status, ImagemLoja imagemLoja)
{
    [JsonProperty(PropertyName = "storeID")]
    public string Id { get; set; } = id;

    [JsonProperty(PropertyName = "storeName")]
    public string Nome { get; set; } = nome;

    [JsonProperty(PropertyName = "isActive")]
    public int Status { get; set; } = status;

    [JsonProperty(PropertyName = "images")]
    public ImagemLoja ImagemLoja { get; set; } = imagemLoja;
}