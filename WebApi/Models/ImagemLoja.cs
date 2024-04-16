using Newtonsoft.Json;

namespace WebApi.Models;

public class ImagemLoja(string? banner, string? logo, string? icon)
{
    [JsonProperty(PropertyName = "banner")]
    public string? Banner { get; set; } = banner;

    [JsonProperty(PropertyName = "logo")]
    public string? Logo { get; set; } = logo;

    [JsonProperty(PropertyName = "icon")]
    public string? Icon { get; set; } = icon;
}
