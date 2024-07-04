using SistemaSupermercados.Models;
using SistemaSupermercados.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSupermercados.Service
{
    public class TransacaoService
    {
        private List<Transacao> transacoes;
        int id = 1;

        public TransacaoService()
        {
            transacoes = new List<Transacao>();
        }

        public void Cadastrar(Transacao transacao)
        {
            transacao.Id = id;
            transacoes.Add(transacao);
            id++;
        }


        public void Listar()
        {
            foreach (var f in transacoes)
            {
                DisplayHelper.ExibirFuncionario(f);
            }
        }

        public bool Atualizar(int id, Transacao transacao)
        {
            Transacao transacaoLista = transacoes.Find(p => p.Id == id);
            if (transacaoLista != null)
            {
                transacaoLista.IdCliente = transacao.IdCliente;
                transacaoLista.IdFuncionario = transacao.IdFuncionario;
                transacaoLista.DataTransacao = transacao.DataTransacao;
                transacaoLista.ValorTotal = transacao.ValorTotal;

                transacaoLista.Produtos = transacao.Produtos;

                // Se retornar true (verdadeiro) quer dizer que ele conseguiu achar o transacao e atualizar
                return true;
            }
            // Se retornar false (falso) quer dizer que ele não conseguiu achar o transacao
            return false;
        }

        public bool Deletar(int id)
        {
            Transacao transacao = transacoes.Find(p => p.Id == id);
            if (transacao != null)
            {
                transacoes.Remove(transacao);
                return true;
            }
            return false;
        }
    }
}
