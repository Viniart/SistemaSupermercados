using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSupermercados.Models
{
    public class Transacao
    {
        // Preciso do metodo construtor iniciando a minha lista senão ela vai inicializar nula
        // O que vai gerar um erro assim que eu tentar inserir produto dentro do Program.cs
        public Transacao()
        {
            Produtos = new List<Produto>();
            ValorTotal = 0;
        }

        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdFuncionario { get; set; }

        public DateTime DataTransacao { get; set; }
        public List<Produto> Produtos { get; set; }
        public double ValorTotal { get; set; }
    }
}
