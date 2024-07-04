using SistemaSupermercados.Models;
using SistemaSupermercados.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSupermercados.Service
{
    public class ClienteService
    {
        private List<Cliente> clientes;
        int id = 1;

        public ClienteService()
        {
            clientes = new List<Cliente>();
        }

        public void Cadastrar(Cliente cliente)
        {
            cliente.Id = id;
            clientes.Add(cliente);
            id++;
        }


        public void Listar()
        {
            foreach (var c in clientes)
            {
                DisplayHelper.ExibirCliente(c);
            }
        }

        public bool Atualizar(int id, Cliente cliente)
        {
            Cliente clienteLista = clientes.Find(p => p.Id == id);
            if (clienteLista != null)
            {
                clienteLista.Nome = cliente.Nome;
                clienteLista.DataNascimento = cliente.DataNascimento;
                clienteLista.Endereco = cliente.Endereco;
                clienteLista.NumeroTelefone = cliente.NumeroTelefone;

                // Se retornar true (verdadeiro) quer dizer que ele conseguiu achar o cliente e atualizar
                return true;
            }
            // Se retornar false (falso) quer dizer que ele não conseguiu achar o cliente
            return false;
        }

        public bool Deletar(int id)
        {
            Cliente cliente = clientes.Find(p => p.Id == id);
            if (cliente != null)
            {
                clientes.Remove(cliente);
                return true;
            }
            return false;
        }
    }
}
