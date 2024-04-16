using AutoMapper;
using WebApi.Dtos;
using WebApi.Interfaces;

namespace WebApi.Service;

public class DescontoService(IMapper mapper, ICheapSharkApi cheapSharkApi) : IDescontoService
{
    private readonly IMapper _mapper = mapper;
    private readonly ICheapSharkApi _cheapSharkApi = cheapSharkApi;

    public async Task<ResponseGenerico<DescontoResponse>> BuscaDescontoPorId(string descontoId)
    {
        var desconto = await _cheapSharkApi.BuscaDescontoPorId(descontoId);
        return _mapper.Map<ResponseGenerico<DescontoResponse>>(desconto);
    }

    public async Task<ResponseListaGenerico<ListaDescontosResponse>> BuscaPorDescontos(int lojaId, int precoMaximo, int precoMinimo)
    {
        var descontos = await _cheapSharkApi.BuscaPorDescontos(lojaId, precoMaximo, precoMinimo);
        return _mapper.Map<ResponseListaGenerico<ListaDescontosResponse>>(descontos);
    }
}
