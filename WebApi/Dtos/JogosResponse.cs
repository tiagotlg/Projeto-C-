using WebApi.Models;

namespace WebApi.Dtos;

public class JogosResponse
{
    public string JogoID { get; set; }

    public string SteamAppID { get; set; }

    public string MaisBarato { get; set; }

    public string MaisBaratoID { get; set; }

    public string Externo { get; set; }

    public string NomeInterno { get; set; }

    public string Thumb { get; set; }

    public List<DescontoJogoResumo> Lojas { get; set; }
}
