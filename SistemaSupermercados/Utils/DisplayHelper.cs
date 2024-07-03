using SistemaSupermercados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSupermercados.Utils
{
    public static class DisplayHelper
    {
        public static void ExibirProduto(Produto prod)
        {
            // Concatenar
            // Console.WriteLine("Nome: " + prod.Nome);
            // Interpolar
            Console.WriteLine($"Id: {prod.Id}");
            Console.WriteLine($"Nome: {prod.Nome}");
            Console.WriteLine($"Categoria: {prod.Categoria}");
            Console.WriteLine($"Preco: {prod.Preco}");
            Console.WriteLine($"Quantidade em Estoque: {prod.QuantidadeEstoque}");
            Console.WriteLine($"Data de Validade: {prod.DataValidade}\n");
        }

        public static void ExibirCliente(Cliente cliente)
        {
            Console.WriteLine($"Id: {cliente.Id}");
            Console.WriteLine($"Nome: {cliente.Nome}");
            Console.WriteLine($"Data de Nascimento: {cliente.DataNascimento}");
            Console.WriteLine($"Endereco: {cliente.Endereco}");
            Console.WriteLine($"Numero de Telefone: {cliente.NumeroTelefone}\n");
        }

        public static void ExibirFuncionario(Funcionario funcionario)
        {
            Console.WriteLine($"Id: {funcionario.Id}");
            Console.WriteLine($"Nome: {funcionario.Nome}");
            Console.WriteLine($"Cargo: {funcionario.Cargo}");
            Console.WriteLine($"Numero de Registro: {funcionario.NumeroRegistro}");
            Console.WriteLine($"Horario de Trabalho: {funcionario.HorarioTrabalho}\n");
        }

        public static void ExibirTransacao(Transacao transacao)
        {
            Console.WriteLine($"Id: {transacao.Id}");
            Console.WriteLine($"Id do Funcionario: {transacao.IdFuncionario}");
            Console.WriteLine($"Id do Cliente: {transacao.IdCliente}");
            Console.WriteLine($"Data de Transacao: {transacao.DataTransacao}");
            Console.WriteLine($"Valor Total: {transacao.ValorTotal}\n");

            foreach (var item in transacao.Produtos)
            {
                ExibirProduto(item);
            }
        }
    }
}
