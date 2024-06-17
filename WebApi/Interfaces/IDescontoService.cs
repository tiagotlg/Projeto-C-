using WebApi.Dtos;

namespace WebApi.Interfaces;

public interface IDescontoService
{
    Task<ResponseGenerico<DescontoResponse>> BuscaDescontoPorId(string descontoId);
    Task<ResponseListaGenerico<ListaDescontosResponse>> BuscaPorDescontos(int lojaId, int precoMaximo, int precoMinimo, int steamRating, int pageNumber, int pageSize);
    Task<ResponseListaGenerico<ListaDescontosResponse>> BuscaPorDescontosMenor(int lojaId);
}
