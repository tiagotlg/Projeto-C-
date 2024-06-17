using Newtonsoft.Json;

namespace WebApi.Models;

public class Jogos
{
    [JsonProperty(PropertyName = "gameID")]
    public string JogoID { get; set; }

    [JsonProperty(PropertyName = "steamAppID")]
    public string SteamAppID { get; set; }

    [JsonProperty(PropertyName = "cheapest")]
    public string MaisBarato { get; set; }

    [JsonProperty(PropertyName = "cheapestDealID")]
    public string MaisBaratoID { get; set; }

    [JsonProperty(PropertyName = "external")]
    public string Externo { get; set; }

    [JsonProperty(PropertyName = "internalName")]
    public string NomeInterno { get; set; }

    [JsonProperty(PropertyName = "thumb")]
    public string Thumb { get; set; }

    public List<DescontoJogoResumo> Lojas;
}