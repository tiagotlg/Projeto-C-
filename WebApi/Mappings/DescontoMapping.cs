using AutoMapper;
using WebApi.Dtos;
using WebApi.Models;

namespace WebApi.Mappings;

public class DescontoMapping : Profile
{
    public DescontoMapping()
    {
        #region desconto
        CreateMap<Desconto, DescontoResponse>();
        CreateMap<ResponseGenerico<Desconto>, ResponseGenerico<DescontoResponse>>()
            .ConstructUsing(o => new ResponseGenerico<DescontoResponse>());
        #endregion

        #region descontos
        CreateMap<ListaDescontos, ListaDescontosResponse>();
        CreateMap<ResponseListaGenerico<ListaDescontos>, ResponseListaGenerico<ListaDescontosResponse>>()
            .ConstructUsing(o => new ResponseListaGenerico<ListaDescontosResponse>());
        #endregion
    }
}
