using WebApi.Models;

namespace WebApi.Dtos;

public class LojaResponse
{
    public string? Id { get; set; }
    public string? Nome { get; set; }
    public int Status { get; set; }
    public ImagemLoja? ImagemLoja { get; set; }
}