using System.Dynamic;
using Newtonsoft.Json;
using WebApi.Dtos;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Rest;

public class CheapSharkApiRest : ICheapSharkApi
{
    public async Task<ResponseGenerico<Jogo>> BuscaJogoPorId(string id)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"https://www.cheapshark.com/api/1.0/games?id={id}");
        var response = new ResponseGenerico<Jogo>();

        using (var client = new HttpClient())
        {
            var responseCheapSharkApi = await client.SendAsync(request);
            var contentResp = await responseCheapSharkApi.Content.ReadAsStringAsync();
            var ObjResponse = JsonConvert.DeserializeObject<Jogo>(contentResp);

            if (responseCheapSharkApi.IsSuccessStatusCode)
            {
                response.CodigoHttp = responseCheapSharkApi.StatusCode;
                response.DadosRetorno = ObjResponse;
            }
            else
            {
                response.CodigoHttp = responseCheapSharkApi.StatusCode;
                response.ErroRetorno = JsonConvert.DeserializeObject<ExpandoObject>(contentResp);
            }
        }
        return response;
    }

    public async Task<ResponseListaGenerico<Jogos>> BuscarPorNome(string nome)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"https://www.cheapshark.com/api/1.0/games?title={nome}");
        var response = new ResponseListaGenerico<Jogos>();

        using (var client = new HttpClient())
        {
            var responseCheapSharkApi = await client.SendAsync(request);
            var contentResp = await responseCheapSharkApi.Content.ReadAsStringAsync();
            var ObjResponse = JsonConvert.DeserializeObject<List<Jogos>>(contentResp);

            if (responseCheapSharkApi.IsSuccessStatusCode)
            {
                response.CodigoHttp = responseCheapSharkApi.StatusCode;
                response.DadosRetorno = ObjResponse;
            }
            else
            {
                response.CodigoHttp = responseCheapSharkApi.StatusCode;
                response.ErroRetorno = JsonConvert.DeserializeObject<ExpandoObject>(contentResp);
            }
        }
        return response;
    }

    public async Task<ResponseListaGenerico<ListaDescontos>> BuscaPorDescontos(int lojaId, int precoMaximo, int precoMinimo)
    {
        var loja = lojaId != 0 ? "=" + lojaId : "?";
        var maximo = precoMaximo != 0 ? "=" + precoMaximo : "?";
        var minimo = precoMinimo != 0 ? "=" + precoMinimo : "?";

        var request = new HttpRequestMessage(HttpMethod.Get, $"https://www.cheapshark.com/api/1.0/deals?storeID{loja}&upperPrice{maximo}&lowerPrice{minimo}");
        var response = new ResponseListaGenerico<ListaDescontos>();

        using (var client = new HttpClient())
        {
            var responseCheapSharkApi = await client.SendAsync(request);
            var contentResp = await responseCheapSharkApi.Content.ReadAsStringAsync();
            var ObjResponse = JsonConvert.DeserializeObject<List<ListaDescontos>>(contentResp);

            if (responseCheapSharkApi.IsSuccessStatusCode)
            {
                response.CodigoHttp = responseCheapSharkApi.StatusCode;
                response.DadosRetorno = ObjResponse;
            }
            else
            {
                response.CodigoHttp = responseCheapSharkApi.StatusCode;
                response.ErroRetorno = JsonConvert.DeserializeObject<ExpandoObject>(contentResp);
            }
        }
        return response;
    }

    public Task<ResponseGenerico<Loja>> BuscaLojaPorId()
    {
        throw new NotImplementedException();
    }

    public Task<ResponseGenerico<List<Loja>>> BuscaTodasLojas()
    {
        throw new NotImplementedException();
    }
}