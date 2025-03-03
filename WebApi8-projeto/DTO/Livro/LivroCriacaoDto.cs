using WebApi8_projeto.DTO.Vinculo;
using WebApi8_projeto.Models;

namespace WebApi8_projeto.DTO.Livro
{
    public class LivroCriacaoDto
    {
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
