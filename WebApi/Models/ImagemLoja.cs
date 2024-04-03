using Newtonsoft.Json;

namespace WebApi.Models;

public class ImagemLoja
{
    [JsonProperty(PropertyName = "banner")]
    public string? Banner { get; set; }

    [JsonProperty(PropertyName = "logo")]
    public string? Logo { get; set; }

    [JsonProperty(PropertyName = "icon")]
    public string? Icon { get; set; }
}
