using System.Text.Json.Serialization;
using WebApi8_projeto.Models;

namespace WebApi8_projeto.DTO.Autor
{
    public class AutorEdicaoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }
}
