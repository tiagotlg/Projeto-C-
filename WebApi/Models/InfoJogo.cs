using Newtonsoft.Json;

namespace WebApi.Models;

public class InfoJogo
{
    [JsonProperty(PropertyName = "storeID")]
    public string? LojaId { get; set; }

    [JsonProperty(PropertyName = "gameID")]
    public string? JogoId { get; set; }

    [JsonProperty(PropertyName = "name")]
    public string? Nome { get; set; }

    [JsonProperty(PropertyName = "steamAppID")]
    public string? SteamAppID { get; set; }

    [JsonProperty(PropertyName = "salePrice")]
    public string? PrecoVenda { get; set; }

    [JsonProperty(PropertyName = "retailPrice")]
    public string? PrecoOriginal { get; set; }

    [JsonProperty(PropertyName = "steamRatingText")]
    public string? CriticaSteam { get; set; }

    [JsonProperty(PropertyName = "steamRatingPercent")]
    public string? PorcentagemCriticaSteam { get; set; }

    [JsonProperty(PropertyName = "steamRatingCount")]
    public string? QtdCriticaSteam { get; set; }

    [JsonProperty(PropertyName = "metacriticScore")]
    public string? NotaCritica { get; set; }

    [JsonProperty(PropertyName = "metacriticLink")]
    public string? LinkCritica { get; set; }

    [JsonProperty(PropertyName = "releaseDate")]
    public int? DataLancamento { get; set; }

    [JsonProperty(PropertyName = "publisher")]
    public string? Desenvolvedora { get; set; }

    [JsonProperty(PropertyName = "steamworks")]
    public string? Steamworks { get; set; }

    [JsonProperty(PropertyName = "thumb")]
    public string? Thumb { get; set; }
}
