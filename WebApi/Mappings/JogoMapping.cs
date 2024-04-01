using AutoMapper;
using WebApi.Dtos;
using WebApi.Models;

namespace WebApi.Mappings;

public class JogoMapping : Profile
{
    public JogoMapping()
    {
        #region Jogo
        CreateMap<Jogo, JogoResponse>();
        CreateMap<ResponseGenerico<Jogo>, ResponseGenerico<JogoResponse>>()
            .ConstructUsing(o => new ResponseGenerico<JogoResponse>());
        #endregion

        #region Jogos
        CreateMap<Jogos, JogosResponse>();
        CreateMap<ResponseListaGenerico<Jogos>, ResponseListaGenerico<JogosResponse>>()
            .ConstructUsing(o => new ResponseListaGenerico<JogosResponse>());
        #endregion
    }
}
