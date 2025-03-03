using WebApi8_projeto.DTO.Vinculo;
using WebApi8_projeto.Models;

namespace WebApi8_projeto.DTO.Livro
{
    public class LivroEdicaoDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
