using Newtonsoft.Json;

namespace WebApi.Models;

public class ListaDescontos(string nomeInterno, string titulo, string linkCritica, string descontoID, string lojaID, string jogoID, string precoComDesconto, string precoNormal, string estaVendendo, string poupado, string notaCritica, string criticaSteam, string porcentagemCriticaSteam, string qtdCriticaSteam, string steamAppID, string dataLancamento, string ultimaAlteracao, string avaliacaoDesconto, string thumb)
{
    [JsonProperty(PropertyName = "internalName")]
    public string NomeInterno { get; set; } = nomeInterno;

    [JsonProperty(PropertyName = "title")]
    public string Titulo { get; set; } = titulo;

    [JsonProperty(PropertyName = "metacriticLink")]
    public string LinkCritica { get; set; } = linkCritica;

    [JsonProperty(PropertyName = "dealID")]
    public string DescontoID { get; set; } = descontoID;

    [JsonProperty(PropertyName = "storeID")]
    public string LojaID { get; set; } = lojaID;

    [JsonProperty(PropertyName = "gameID")]
    public string JogoID { get; set; } = jogoID;

    [JsonProperty(PropertyName = "salePrice")]
    public string PrecoComDesconto { get; set; } = precoComDesconto;

    [JsonProperty(PropertyName = "normalPrice")]
    public string PrecoNormal { get; set; } = precoNormal;

    [JsonProperty(PropertyName = "isOnSale")]
    public string EstaVendendo { get; set; } = estaVendendo;

    [JsonProperty(PropertyName = "savings")]
    public string Poupado { get; set; } = poupado;

    [JsonProperty(PropertyName = "metacriticScore")]
    public string NotaCritica { get; set; } = notaCritica;

    [JsonProperty(PropertyName = "steamRatingText")]
    public string CriticaSteam { get; set; } = criticaSteam;

    [JsonProperty(PropertyName = "steamRatingPercent")]
    public string PorcentagemCriticaSteam { get; set; } = porcentagemCriticaSteam;

    [JsonProperty(PropertyName = "steamRatingCount")]
    public string QtdCriticaSteam { get; set; } = qtdCriticaSteam;

    [JsonProperty(PropertyName = "steamAppID")]
    public string SteamAppID { get; set; } = steamAppID;

    [JsonProperty(PropertyName = "releaseDate")]
    public string DataLancamento { get; set; } = dataLancamento;

    [JsonProperty(PropertyName = "lastChange")]
    public string UltimaAlteracao { get; set; } = ultimaAlteracao;

    [JsonProperty(PropertyName = "dealRating")]
    public string AvaliacaoDesconto { get; set; } = avaliacaoDesconto;

    [JsonProperty(PropertyName = "thumb")]
    public string Thumb { get; set; } = thumb;
}



