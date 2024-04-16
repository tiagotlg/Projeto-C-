using AutoMapper;
using WebApi.Dtos;
using WebApi.Interfaces;

namespace WebApi.Service;

public class LojaService(IMapper mapper, ICheapSharkApi cheapSharkApi) : ILojaService
{
    private readonly IMapper _mapper = mapper;
    private readonly ICheapSharkApi _cheapSharkApi = cheapSharkApi;

    public async Task<ResponseListaGenerico<LojaResponse>> BuscarLoja()
    {
        var loja = await _cheapSharkApi.BuscarLoja();
        return _mapper.Map<ResponseListaGenerico<LojaResponse>>(loja);
    }
}
