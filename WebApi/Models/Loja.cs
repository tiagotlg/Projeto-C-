using System.Text.Json.Serialization;

namespace WebApi.Models;

public class Loja
{
    [JsonPropertyName("storeID")]
    public string? Id { get; set; }

    [JsonPropertyName("storeName")]
    public string? Nome { get; set; }

    [JsonPropertyName("isActive")]
    public int Status { get; set; }

    [JsonPropertyName("images")]
    public Imagens? Imagens { get; set; }
}

public class Imagens
    {
        [JsonPropertyName("banner")]
        public string? Banner { get; set; }

        [JsonPropertyName("logo")]
        public string? Logo { get; set; }

        [JsonPropertyName("icon")]
        public string? Icone { get; set; }
    }
