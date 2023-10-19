using System;

namespace ProjetoCarros.Models
{
    public class RegistoModel
    {
        public int Id { get; set; }
        public required string Marca { get; set; }
        public required string Modelo { get; set; }
        public required int Preco { get; set; }
        public required int AnoCarro { get; set; }
        public required string TipoCombustivel { get; set; }
        public required string Cor { get; set; }
        public DateTime UltimaAtualização { get; set; } = DateTime.Now;
    }

}