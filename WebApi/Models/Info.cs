using Newtonsoft.Json;

namespace WebApi.Models;

public class InfoJogoResumo(string titulo, string steamAppID, string thumb)
{
    [JsonProperty(PropertyName = "title")]
    public string Titulo { get; set; } = titulo;

    [JsonProperty(PropertyName = "steamAppID")]
    public string SteamAppID { get; set; } = steamAppID;

    [JsonProperty(PropertyName = "thumb")]
    public string Thumb { get; set; } = thumb;
}
