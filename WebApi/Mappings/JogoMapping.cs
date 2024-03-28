using AutoMapper;
using WebApi.Dtos;
using WebApi.Models;

namespace WebApi.Mappings;

public class JogoMapping : Profile
{
    public JogoMapping()
    {
        CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
        CreateMap<JogoResponse, Jogo>();
        CreateMap<Jogo, JogoResponse>();
        CreateMap<Jogos, JogosResponse>();
    }
}
