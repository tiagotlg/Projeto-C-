using AutoMapper;
using WebApi.Dtos;
using WebApi.Models;

namespace WebApi.Mappings;

public class JogoMapping : Profile
{
    public JogoMapping()
    {
        #region Jogo
        CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
        CreateMap<JogoResponse, Jogo>();
        CreateMap<Jogo, JogoResponse>();
        #endregion

        #region Jogos
        CreateMap<Jogos, JogosResponse>();
        CreateMap<ResponseListaGenerico<Jogos>, ResponseListaGenerico<JogosResponse>>()
            .ConstructUsing(o => new ResponseListaGenerico<JogosResponse>());
        #endregion
    }
}
