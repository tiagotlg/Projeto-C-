using AutoMapper;
using WebApi.Dtos;
using WebApi.Interfaces;

namespace WebApi.Service;

public class JogoService : IJogoService
{
    private readonly IMapper _mapper;
    private readonly ICheapSharkApi _cheapSharkApi;

public JogoService(IMapper mapper, ICheapSharkApi cheapSharkApi) 
{
    _mapper = mapper;
    _cheapSharkApi = cheapSharkApi;
}

    public async Task<ResponseGenerico<JogoResponse>> BuscaJogoPorId(string id)
    {
        var jogo = await _cheapSharkApi.BuscaJogoPorId(id);
        return _mapper.Map<ResponseGenerico<JogoResponse>>(jogo);
    }
}
