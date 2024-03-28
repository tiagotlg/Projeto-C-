using WebApi.Dtos;
using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface ICheapSharkApi
    {
        Task<ResponseGenerico<Jogo>> BuscaJogoPorId(string id);
        Task<ResponseGenerico<List<Loja>>> BuscaTodasLojas();
        Task<ResponseGenerico<Loja>> BuscaLojaPorId();


        
    }
}