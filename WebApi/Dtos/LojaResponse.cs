using WebApi.Models;

namespace WebApi.Dtos
{
    public class LojaResponse
    {
        public string? Id { get; set; }
        public string? Nome { get; set; }
        public int Status { get; set; }
        public Imagens? Imagens { get; set; }
        public string? Banner { get; set; }
        public string? Logo { get; set; }
        public string? Icone { get; set; }
    }
}