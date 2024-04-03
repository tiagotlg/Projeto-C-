using AutoMapper;
using WebApi.Dtos;
using WebApi.Models;

namespace WebApi.Mappings;

public class LojaMapping : Profile
{
    public LojaMapping()
    {
        #region Loja
        CreateMap<Loja, LojaResponse>();
        CreateMap<ResponseListaGenerico<Loja>, ResponseListaGenerico<LojaResponse>>()
            .ConstructUsing(o => new ResponseListaGenerico<LojaResponse>());
        #endregion
    }
}
