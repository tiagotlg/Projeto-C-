using Newtonsoft.Json;

namespace WebApi.Models;

public class ListaDescontos
{
    [JsonProperty(PropertyName = "internalName")]
    public string? NomeInterno { get; set; }

    [JsonProperty(PropertyName = "title")]
    public string? Titulo { get; set; }

    [JsonProperty(PropertyName = "metacriticLink")]
    public string? LinkCritica { get; set; }

    [JsonProperty(PropertyName = "dealID")]
    public string? DescontoID { get; set; }

    [JsonProperty(PropertyName = "storeID")]
    public string? LojaID { get; set; }

    [JsonProperty(PropertyName = "gameID")]
    public string? JogoID { get; set; }

    [JsonProperty(PropertyName = "salePrice")]
    public string? PrecoComDesconto { get; set; }

    [JsonProperty(PropertyName = "normalPrice")]
    public string? PrecoNormal { get; set; }

    [JsonProperty(PropertyName = "isOnSale")]
    public string? EstaVendendo { get; set; }

    [JsonProperty(PropertyName = "savings")]
    public string? Poupado { get; set; }

    [JsonProperty(PropertyName = "metacriticScore")]
    public string? NotaCritica { get; set; }

    [JsonProperty(PropertyName = "steamRatingText")]
    public string? CriticaSteam { get; set; }

    [JsonProperty(PropertyName = "steamRatingPercent")]
    public string? PorcentagemCriticaSteam { get; set; }

    [JsonProperty(PropertyName = "steamRatingCount")]
    public string? QtdCriticaSteam { get; set; }

    [JsonProperty(PropertyName = "steamAppID")]
    public string? SteamAppID { get; set; }

    [JsonProperty(PropertyName = "releaseDate")]
    public string? DataLancamento { get; set; }

    [JsonProperty(PropertyName = "lastChange")]
    public string? UltimaAlteracao { get; set; }

    [JsonProperty(PropertyName = "dealRating")]
    public string? AvaliacaoDesconto { get; set; }

    [JsonProperty(PropertyName = "thumb")]
    public string? Thumb { get; set; }
}



