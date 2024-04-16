using Newtonsoft.Json;

namespace WebApi.Models;

public class InfoJogo(string? lojaId, string? jogoId, string? nome, string? steamAppID, string? precoVenda, string? precoOriginal, string? criticaSteam, string? porcentagemCriticaSteam, string? qtdCriticaSteam, string? notaCritica, string? linkCritica, int? dataLancamento, string? desenvolvedora, string? steamworks, string? thumb)
{
    [JsonProperty(PropertyName = "storeID")]
    public string? LojaId { get; set; } = lojaId;

    [JsonProperty(PropertyName = "gameID")]
    public string? JogoId { get; set; } = jogoId;

    [JsonProperty(PropertyName = "name")]
    public string? Nome { get; set; } = nome;

    [JsonProperty(PropertyName = "steamAppID")]
    public string? SteamAppID { get; set; } = steamAppID;

    [JsonProperty(PropertyName = "salePrice")]
    public string? PrecoVenda { get; set; } = precoVenda;

    [JsonProperty(PropertyName = "retailPrice")]
    public string? PrecoOriginal { get; set; } = precoOriginal;

    [JsonProperty(PropertyName = "steamRatingText")]
    public string? CriticaSteam { get; set; } = criticaSteam;

    [JsonProperty(PropertyName = "steamRatingPercent")]
    public string? PorcentagemCriticaSteam { get; set; } = porcentagemCriticaSteam;

    [JsonProperty(PropertyName = "steamRatingCount")]
    public string? QtdCriticaSteam { get; set; } = qtdCriticaSteam;

    [JsonProperty(PropertyName = "metacriticScore")]
    public string? NotaCritica { get; set; } = notaCritica;

    [JsonProperty(PropertyName = "metacriticLink")]
    public string? LinkCritica { get; set; } = linkCritica;

    [JsonProperty(PropertyName = "releaseDate")]
    public int? DataLancamento { get; set; } = dataLancamento;

    [JsonProperty(PropertyName = "publisher")]
    public string? Desenvolvedora { get; set; } = desenvolvedora;

    [JsonProperty(PropertyName = "steamworks")]
    public string? Steamworks { get; set; } = steamworks;

    [JsonProperty(PropertyName = "thumb")]
    public string? Thumb { get; set; } = thumb;
}
