using WebApi.Dtos;
using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface ICheapSharkApi
    {
        Task<ResponseGenerico<Jogo>> BuscaJogoPorId(string id);
        Task<ResponseListaGenerico<Jogos>> BuscarPorNome(string nome);
        Task<ResponseGenerico<List<Loja>>> BuscaTodasLojas();
        Task<ResponseGenerico<Loja>> BuscaLojaPorId();
    }
}