using AutoMapper;
using WebApi.Dtos;
using WebApi.Models;

namespace WebApi.Mappings;

public class DescontoMapping : Profile
{
    public DescontoMapping()
    {
        #region descontos
        CreateMap<ListaDescontos, ListaDescontosResponse>();
        CreateMap<ResponseListaGenerico<ListaDescontos>, ResponseListaGenerico<ListaDescontosResponse>>()
            .ConstructUsing(o => new ResponseListaGenerico<ListaDescontosResponse>());
        #endregion
    }
}
