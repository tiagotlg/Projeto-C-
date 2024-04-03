using AutoMapper;
using WebApi.Dtos;
using WebApi.Interfaces;

namespace WebApi.Service;

public class LojaService : ILojaService
{
    private readonly IMapper _mapper;
    private readonly ICheapSharkApi _cheapSharkApi;

    public LojaService(IMapper mapper, ICheapSharkApi cheapSharkApi)
    {
        _mapper = mapper;
        _cheapSharkApi = cheapSharkApi;
    }

    public async Task<ResponseListaGenerico<LojaResponse>> BuscarLoja()
    {
        var loja = await _cheapSharkApi.BuscarLoja();
        return _mapper.Map<ResponseListaGenerico<LojaResponse>>(loja);
    }
}
