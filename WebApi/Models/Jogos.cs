using Newtonsoft.Json;

namespace WebApi.Models;

public class Jogos(string? jogoID, string? steamAppID, string? maisBarato, string? maisBaratoID, string? externo, string? nomeInterno, string? thumb)
{
    [JsonProperty(PropertyName = "gameID")]
    public string? JogoID { get; set; } = jogoID;

    [JsonProperty(PropertyName = "steamAppID")]
    public string? SteamAppID { get; set; } = steamAppID;

    [JsonProperty(PropertyName = "cheapest")]
    public string? MaisBarato { get; set; } = maisBarato;

    [JsonProperty(PropertyName = "cheapestDealID")]
    public string? MaisBaratoID { get; set; } = maisBaratoID;

    [JsonProperty(PropertyName = "external")]
    public string? Externo { get; set; } = externo;

    [JsonProperty(PropertyName = "internalName")]
    public string? NomeInterno { get; set; } = nomeInterno;

    [JsonProperty(PropertyName = "thumb")]
    public string? Thumb { get; set; } = thumb;
}