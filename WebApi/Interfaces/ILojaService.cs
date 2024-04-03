using WebApi.Dtos;

namespace WebApi.Interfaces;

public interface ILojaService
{
    Task<ResponseListaGenerico<LojaResponse>> BuscarLoja();
}
