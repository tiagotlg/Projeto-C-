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
        var requestJogo = new HttpRequestMessage(HttpMethod.Get, $"https://www.cheapshark.com/api/1.0/games?id={id}");
        var responseJogo = new ResponseGenerico<Jogo>();

        using (var client = new HttpClient())
        {
            List<int> LojasIds = [1, 7, 8, 13, 25, 31];

            var responseCheapSharkApi = await client.SendAsync(requestJogo);
            var contentResp = await responseCheapSharkApi.Content.ReadAsStringAsync();
            var ObjResponse = JsonConvert.DeserializeObject<Jogo>(contentResp);

            List<DescontoJogoResumo> ObjFiltrado = ObjResponse.DescontoJogoResumo.Where(o => LojasIds.Contains(o.LojaId)).ToList();

            if (responseCheapSharkApi.IsSuccessStatusCode)
            {
                responseJogo.CodigoHttp = responseCheapSharkApi.StatusCode;
                responseJogo.DadosRetorno = ObjResponse;
                responseJogo.DadosRetorno.DescontoJogoResumo = ObjFiltrado;

            }
            else
            {
                responseJogo.CodigoHttp = responseCheapSharkApi.StatusCode;
                responseJogo.ErroRetorno = JsonConvert.DeserializeObject<ExpandoObject>(contentResp);
            }
        }
        return responseJogo;
    }

    public async Task<ResponseListaGenerico<Jogos>> BuscarPorNome(string nome)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"https://www.cheapshark.com/api/1.0/games?title={nome}&limit=10");
        var response = new ResponseListaGenerico<Jogos>();

        using (var client = new HttpClient())
        {
            var responseCheapSharkApi = await client.SendAsync(request);
            var contentResp = await responseCheapSharkApi.Content.ReadAsStringAsync();
            List<Jogos> ObjResponse = JsonConvert.DeserializeObject<List<Jogos>>(contentResp);
            List<DescontoJogoResumo> lojas = [];

            if (responseCheapSharkApi.IsSuccessStatusCode)
            {
                foreach (var jogo in ObjResponse)
                {
                    var buscaJogo = await BuscaJogoPorId(jogo.JogoID);
                    if (buscaJogo.DadosRetorno.DescontoJogoResumo.Count > 0)
                    {
                        lojas = buscaJogo.DadosRetorno.DescontoJogoResumo;
                        jogo.Lojas = lojas;
                    }
                };

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

    public async Task<ResponseGenerico<Desconto>> BuscaDescontoPorId(string descontoId)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"https://www.cheapshark.com/api/1.0/deals?id={descontoId}");
        var response = new ResponseGenerico<Desconto>();

        using (var client = new HttpClient())
        {
            List<string> LojasIds = ["1", "7", "8", "13", "25", "31"];

            var responseCheapSharkApi = await client.SendAsync(request);
            var contentResp = await responseCheapSharkApi.Content.ReadAsStringAsync();
            var ObjResponse = JsonConvert.DeserializeObject<Desconto>(contentResp);

            List<LojaMaisBarata> ObjFiltrado = ObjResponse!.LojaMaisBarata.Where(o => LojasIds.Contains(o.LojaId)).ToList();

            if (responseCheapSharkApi.IsSuccessStatusCode)
            {
                response.CodigoHttp = responseCheapSharkApi.StatusCode;
                response.DadosRetorno = ObjResponse;
                response.DadosRetorno.LojaMaisBarata = ObjFiltrado;
            }
            else
            {
                response.CodigoHttp = responseCheapSharkApi.StatusCode;
                response.ErroRetorno = JsonConvert.DeserializeObject<ExpandoObject>(contentResp);
            }
        }
        return response;
    }

    public async Task<ResponseListaGenerico<ListaDescontos>> BuscaPorDescontos(int lojaId, int precoMaximo, int precoMinimo, int steamRating)
    {
        var loja = lojaId != 0 ? "=" + lojaId : "?";
        var maximo = precoMaximo != 0 ? "=" + precoMaximo : "?";
        var minimo = precoMinimo != 0 ? "=" + precoMinimo : "?";
        var rating = steamRating != 0 ? "=" + steamRating : "?";

        var request = new HttpRequestMessage(HttpMethod.Get, $"https://www.cheapshark.com/api/1.0/deals?storeID{loja}&upperPrice{maximo}&lowerPrice{minimo}&steamRating{rating}");
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

    public async Task<ResponseListaGenerico<ListaDescontos>> BuscaPorDescontosMenor(int lojaId)
    {
        var loja = lojaId != 0 ? "=" + lojaId : "?";

        var request = new HttpRequestMessage(HttpMethod.Get, $"https://www.cheapshark.com/api/1.0/deals?storeID{loja}&pageSize=7");
        var response = new ResponseListaGenerico<ListaDescontos>();

        using (var client = new HttpClient())
        {
            List<string> LojasIds = ["1", "7", "8", "13", "25", "31"];

            var responseCheapSharkApi = await client.SendAsync(request);
            var contentResp = await responseCheapSharkApi.Content.ReadAsStringAsync();
            var ObjResponse = JsonConvert.DeserializeObject<List<ListaDescontos>>(contentResp);

            List<ListaDescontos> ObjFiltrado = ObjResponse!.Where(o => LojasIds.Contains(o.LojaID)).ToList();

            if (responseCheapSharkApi.IsSuccessStatusCode)
            {
                response.CodigoHttp = responseCheapSharkApi.StatusCode;
                response.DadosRetorno = ObjFiltrado;
            }
            else
            {
                response.CodigoHttp = responseCheapSharkApi.StatusCode;
                response.ErroRetorno = JsonConvert.DeserializeObject<ExpandoObject>(contentResp);
            }
        }
        return response;
    }

    public async Task<ResponseListaGenerico<Loja>> BuscarLoja()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"https://www.cheapshark.com/api/1.0/stores");
        var response = new ResponseListaGenerico<Loja>();

        using (var client = new HttpClient())
        {
            List<string> LojasIds = ["1", "7", "8", "13", "25", "31"];

            var responseCheapSharkApi = await client.SendAsync(request);
            var contentResp = await responseCheapSharkApi.Content.ReadAsStringAsync();
            var ObjResponse = JsonConvert.DeserializeObject<List<Loja>>(contentResp);

            List<Loja> ObjFiltrado = ObjResponse!.Where(o => LojasIds.Contains(o.Id)).ToList();

            if (responseCheapSharkApi.IsSuccessStatusCode)
            {
                response.CodigoHttp = responseCheapSharkApi.StatusCode;
                response.DadosRetorno = ObjFiltrado;
            }
            else
            {
                response.CodigoHttp = responseCheapSharkApi.StatusCode;
                response.ErroRetorno = JsonConvert.DeserializeObject<ExpandoObject>(contentResp);
            }
        }
        return response;
    }

}