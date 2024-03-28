using Newtonsoft.Json;

namespace WebApi.Models;

public class InfoJogo
{
    [JsonProperty(PropertyName = "title")]
    public string? Titulo { get; set; }

    [JsonProperty(PropertyName = "steamAppID")]
    public string? SteamAppID { get; set; }

    [JsonProperty(PropertyName = "thumb")]
    public string? Thumb { get; set; }
}
