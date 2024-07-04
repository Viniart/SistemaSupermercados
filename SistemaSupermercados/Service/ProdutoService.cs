using SistemaSupermercados.Models;
using SistemaSupermercados.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSupermercados.Service
{
    public class ProdutoService
    {
        private List<Produto> produtos;
        int id = 1;

        public ProdutoService()
        {
            produtos = new List<Produto>();
        }

        public void Cadastrar(Produto prod)
        {
            prod.Id = id;
            produtos.Add(prod);
            // id = id + 1;
            id++;
        }


        public void Listar() {
            foreach (var p in produtos)
            {
                DisplayHelper.ExibirProduto(p);
            }
        }

        public List<Produto> RetornarLista()
        {
            return produtos;
        }

        public bool Atualizar(int id, Produto prod)
        {
            Produto produto = produtos.Find(p => p.Id == id);
            if (produto != null)
            {
                produto.Nome = prod.Nome;
                produto.Categoria = prod.Categoria;
                produto.Preco = prod.Preco;
                produto.QuantidadeEstoque = prod.QuantidadeEstoque;
                produto.DataValidade = prod.DataValidade;

                // Se retornar true (verdadeiro) quer dizer que ele conseguiu achar o produto e atualizar
                return true;
            }
            // Se retornar false (falso) quer dizer que ele não conseguiu achar o produto
            return false;
        }

        public bool Deletar(int id)
        {
            Produto produto = produtos.Find(p => p.Id == id);
            if (produto != null)
            {
                produtos.Remove(produto);
                return true;
            }
            return false;
        }

    }
}
