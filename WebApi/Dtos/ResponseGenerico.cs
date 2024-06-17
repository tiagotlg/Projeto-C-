using System.Dynamic;
using System.Net;

namespace WebApi.Dtos;

public class ResponseGenerico<T> where T : class
{
    public HttpStatusCode CodigoHttp { get; set; }
    public T DadosRetorno { get; set; }
    public ExpandoObject ErroRetorno { get; set; }
}