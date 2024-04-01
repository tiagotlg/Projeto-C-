using WebApi.Dtos;

namespace WebApi.Interfaces;

public interface IDescontoService
{
    Task<ResponseListaGenerico<ListaDescontosResponse>> BuscaPorDescontos(int lojaId, int precoMaximo, int precoMinimo);
}
