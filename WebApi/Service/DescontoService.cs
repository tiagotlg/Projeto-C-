using AutoMapper;
using WebApi.Dtos;
using WebApi.Interfaces;

namespace WebApi.Service;

public class DescontoService : IDescontoService
{
    private readonly IMapper _mapper;
    private readonly ICheapSharkApi _cheapSharkApi;

    public DescontoService(IMapper mapper, ICheapSharkApi cheapSharkApi)
    {
        _mapper = mapper;
        _cheapSharkApi = cheapSharkApi;
    }

    public async Task<ResponseListaGenerico<ListaDescontosResponse>> BuscaPorDescontos(int lojaId, int precoMaximo, int precoMinimo)
    {
        var descontos = await _cheapSharkApi.BuscaPorDescontos(lojaId, precoMaximo, precoMinimo);
        return _mapper.Map<ResponseListaGenerico<ListaDescontosResponse>>(descontos);
    }
}
