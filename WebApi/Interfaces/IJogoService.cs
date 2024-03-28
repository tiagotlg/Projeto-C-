using WebApi.Dtos;

namespace WebApi.Interfaces;

public interface IJogoService
{
    Task<ResponseGenerico<JogoResponse>> BuscaJogoPorId(string id);
}
