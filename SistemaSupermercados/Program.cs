// See https://aka.ms/new-console-template for more information


using SistemaSupermercados.Models;
using SistemaSupermercados.Service;

ProdutoService produtoService = new ProdutoService();

int opcao = 0;

Console.WriteLine("Sistema de Supermercados");

Console.WriteLine("Bem vindo ao Sistema!");

do
{
    Console.WriteLine("Selecione a opcao que deseja:");

    Console.WriteLine("1 - Cliente");
    Console.WriteLine("2 - Funcionario");
    Console.WriteLine("3 - Produto");
    Console.WriteLine("4 - Transacao");
    Console.WriteLine("0 - Sair");
    opcao = Int32.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Metodo ainda nao implementado");
            break;
        case 2:
            Console.WriteLine("Metodo ainda nao implementado");
            break;
        case 3:
            EscolherMetodoProduto();
            break;
        case 4:
            Console.WriteLine("Metodo ainda nao implementado");
            break;
        default:
            Console.WriteLine("Numero invalido");
            break;
    }

}
while(opcao != 0);

void EscolherMetodoProduto()
{
    int opcaoMetodo = 0;
    Console.WriteLine("Selecione o metodo que deseja:");

    Console.WriteLine("1 - Listar");
    Console.WriteLine("2 - Cadastrar");
    Console.WriteLine("3 - Editar");
    Console.WriteLine("4 - Deletar");
    opcaoMetodo = Int32.Parse(Console.ReadLine());

    switch (opcaoMetodo)
    {
        case 1:
            produtoService.Listar();
            break;
        case 2:
            produtoService.Cadastrar(CadastrarProduto());
            break;
        case 3:
            Console.WriteLine("Metodo ainda nao implementado");
            break;
        case 4:
            Console.WriteLine("Metodo ainda nao implementado");
            break;
        default:
            Console.WriteLine("Numero invalido");
            break;
    }
}

Produto CadastrarProduto()
{
    Produto produto = new Produto();

    Console.WriteLine("Digite o Nome: ");
    produto.Nome = Console.ReadLine();

    Console.WriteLine("Digite a Categoria: ");
    produto.Categoria = Console.ReadLine();

    Console.WriteLine("Digite o Preco: ");
    produto.Preco = Double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a Quantidade: ");
    produto.QuantidadeEstoque = Int32.Parse(Console.ReadLine());

    Console.WriteLine("Digite a Data de Validade: (DD/MM/YYYY)");
    produto.DataValidade = DateTime.Parse(Console.ReadLine());

    return produto;
}