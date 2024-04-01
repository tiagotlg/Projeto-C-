using WebApi.Dtos;

namespace WebApi.Interfaces;

public interface IJogoService
{
    Task<ResponseGenerico<JogoResponse>> BuscaJogoPorId(string id);
    Task<ResponseListaGenerico<JogosResponse>> BuscarPorNome(string nome);

}
