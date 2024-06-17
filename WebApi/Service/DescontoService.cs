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

    public async Task<ResponseGenerico<DescontoResponse>> BuscaDescontoPorId(string descontoId)
    {
        var desconto = await _cheapSharkApi.BuscaDescontoPorId(descontoId);
        return _mapper.Map<ResponseGenerico<DescontoResponse>>(desconto);
    }

    public async Task<ResponseListaGenerico<ListaDescontosResponse>> BuscaPorDescontos(int lojaId, int precoMaximo, int precoMinimo, int steamRating)
    {
        var descontos = await _cheapSharkApi.BuscaPorDescontos(lojaId, precoMaximo, precoMinimo, steamRating);
        return _mapper.Map<ResponseListaGenerico<ListaDescontosResponse>>(descontos);
    }

    public async Task<ResponseListaGenerico<ListaDescontosResponse>> BuscaPorDescontosMenor(int lojaId)
    {
        var descontos = await _cheapSharkApi.BuscaPorDescontosMenor(lojaId);
        return _mapper.Map<ResponseListaGenerico<ListaDescontosResponse>>(descontos);
    }
}
