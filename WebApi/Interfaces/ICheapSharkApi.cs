using WebApi.Dtos;
using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface ICheapSharkApi
    {
        Task<ResponseGenerico<Jogo>> BuscaJogoPorId(string id);
        Task<ResponseListaGenerico<Jogos>> BuscarPorNome(string nome);
        Task<ResponseGenerico<Desconto>> BuscaDescontoPorId(string descontoId);
        Task<ResponseListaGenerico<ListaDescontos>> BuscaPorDescontos(int lojaId, int precoMaximo, int precoMinimo);
        Task<ResponseListaGenerico<Loja>> BuscarLoja();
    }
}