using Newtonsoft.Json;

namespace WebApi.Models;
public class Jogo(InfoJogoResumo infoJogoResumo, MaisBaratoSempreJogo maisBaratoSempreJogo, List<DescontoJogoResumo> descontoJogoResumo)
{
    [JsonProperty(PropertyName = "info")]
    public InfoJogoResumo InfoJogoResumo { get; set; } = infoJogoResumo;

    [JsonProperty(PropertyName = "cheapestPriceEver")]
    public MaisBaratoSempreJogo MaisBaratoSempreJogo { get; set; } = maisBaratoSempreJogo;

    [JsonProperty(PropertyName = "deals")]
    public List<DescontoJogoResumo> DescontoJogoResumo { get; set; } = descontoJogoResumo;
}