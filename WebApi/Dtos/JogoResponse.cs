using WebApi.Models;

namespace WebApi.Dtos;

public class JogoResponse(InfoJogoResumo infoJogoResumo, MaisBaratoSempreJogo maisBaratoSempreJogo, List<DescontoJogoResumo> descontoJogoResumo)
{
    public InfoJogoResumo InfoJogoResumo { get; set; } = infoJogoResumo;

    public MaisBaratoSempreJogo MaisBaratoSempreJogo { get; set; } = maisBaratoSempreJogo;

    public List<DescontoJogoResumo> DescontoJogoResumo { get; set; } = descontoJogoResumo;
}