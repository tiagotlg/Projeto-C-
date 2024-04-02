using WebApi.Dtos;

namespace WebApi.Interfaces;

public interface IDescontoService
{
    Task<ResponseGenerico<DescontoResponse>> BuscaDescontoPorId(string descontoId);
    Task<ResponseListaGenerico<ListaDescontosResponse>> BuscaPorDescontos(int lojaId, int precoMaximo, int precoMinimo);
}
