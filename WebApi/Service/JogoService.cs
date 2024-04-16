using AutoMapper;
using WebApi.Dtos;
using WebApi.Interfaces;

namespace WebApi.Service;

public class JogoService(IMapper mapper, ICheapSharkApi cheapSharkApi) : IJogoService
{
    private readonly IMapper _mapper = mapper;
    private readonly ICheapSharkApi _cheapSharkApi = cheapSharkApi;

    public async Task<ResponseGenerico<JogoResponse>> BuscaJogoPorId(string id)
    {
        var jogo = await _cheapSharkApi.BuscaJogoPorId(id);
        return _mapper.Map<ResponseGenerico<JogoResponse>>(jogo);
    }

    public async Task<ResponseListaGenerico<JogosResponse>> BuscarPorNome(string nome)
    {
        var jogos = await _cheapSharkApi.BuscarPorNome(nome);
        return _mapper.Map<ResponseListaGenerico<JogosResponse>>(jogos);
    }
}
