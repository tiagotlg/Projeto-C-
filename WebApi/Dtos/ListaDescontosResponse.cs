namespace WebApi.Dtos;

public class ListaDescontosResponse(string nomeInterno, string titulo, string linkCritica, string descontoID, string lojaID, string jogoID, string precoComDesconto, string precoNormal, string estaVendendo, string poupado, string notaCritica, string criticaSteam, string porcentagemCriticaSteam, string qtdCriticaSteam, string steamAppID, string dataLancamento, string ultimaAlteracao, string avaliacaoDesconto, string thumb)
{
    public string NomeInterno { get; set; } = nomeInterno;
    public string Titulo { get; set; } = titulo;
    public string LinkCritica { get; set; } = linkCritica;
    public string DescontoID { get; set; } = descontoID;
    public string LojaID { get; set; } = lojaID;
    public string JogoID { get; set; } = jogoID;
    public string PrecoComDesconto { get; set; } = precoComDesconto;
    public string PrecoNormal { get; set; } = precoNormal;
    public string EstaVendendo { get; set; } = estaVendendo;
    public string Poupado { get; set; } = poupado;
    public string NotaCritica { get; set; } = notaCritica;
    public string CriticaSteam { get; set; } = criticaSteam;
    public string PorcentagemCriticaSteam { get; set; } = porcentagemCriticaSteam;
    public string QtdCriticaSteam { get; set; } = qtdCriticaSteam;
    public string SteamAppID { get; set; } = steamAppID;
    public string DataLancamento { get; set; } = dataLancamento;
    public string UltimaAlteracao { get; set; } = ultimaAlteracao;
    public string AvaliacaoDesconto { get; set; } = avaliacaoDesconto;
    public string Thumb { get; set; } = thumb;
}
