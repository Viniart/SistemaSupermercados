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
        List<Produto> produtos;
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

    }
}
