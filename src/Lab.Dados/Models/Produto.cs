using System;

namespace Lab.Dados.Models
{
    public class Produto
    {
        public Guid Id { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public string SKU { get; set; }
    }
}