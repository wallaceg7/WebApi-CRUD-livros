﻿using System.Text.Json.Serialization;

namespace WebApi8_projeto.Models
{
    public class LivroModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public AutorModel Autor { get; set; }
    }
}
