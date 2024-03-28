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

    public Task<ResponseGenerico<Loja>> BuscaLojaPorId()
    {
        throw new NotImplementedException();
    }

    public Task<ResponseGenerico<List<Loja>>> BuscaTodasLojas()
    {
        throw new NotImplementedException();
    }
}