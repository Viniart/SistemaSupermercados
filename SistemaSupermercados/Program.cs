// See https://aka.ms/new-console-template for more information


using SistemaSupermercados.Models;
using SistemaSupermercados.Service;

ProdutoService produtoService = new();

int opcao = 0;

Console.WriteLine("Bem vindo ao Sistema!");

Console.WriteLine("========================");
Console.WriteLine("Sistema de Supermercados");
Console.WriteLine("========================\n");

do
{
    Console.WriteLine("Selecione a opcao que deseja: ");

    Console.WriteLine("1 - Cliente");
    Console.WriteLine("2 - Funcionario");
    Console.WriteLine("3 - Produto");
    Console.WriteLine("4 - Transacao");
    Console.WriteLine("0 - Sair\n");
    opcao = int.Parse(Console.ReadLine());

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

#region Produto
void EscolherMetodoProduto()
{
    int opcaoMetodo = 0;
    Console.WriteLine("Selecione o metodo que deseja:");

    Console.WriteLine("1 - Listar");
    Console.WriteLine("2 - Cadastrar");
    Console.WriteLine("3 - Editar");
    Console.WriteLine("4 - Deletar");
    opcaoMetodo = int.Parse(Console.ReadLine());

    switch (opcaoMetodo)
    {
        case 1:
            Console.WriteLine();
            produtoService.Listar();
            break;
        case 2:
            produtoService.Cadastrar(CriarProduto());
            break;
        case 3:
            // Descubro o Id de quem quero editar e passo o produto que quero editar
            if(produtoService.Atualizar(EscolherProduto(), CriarProduto()))
            {
                Console.WriteLine("Produto Atualizado com Sucesso!");
            }
            else
            {
                Console.WriteLine("Identificador inválido, tente novamente");
            }
            break;
        case 4:
            if(produtoService.Deletar(EscolherProduto()))
            {
                Console.WriteLine("Produto Deletado com Sucesso!");
            }
            else
            {
                Console.WriteLine("Identificador inválido, tente novamente");
            }
            break;
        default:
            Console.WriteLine("Numero inválido");
            break;
    }
}

Produto CriarProduto()
{
    Produto produto = new Produto();

    Console.WriteLine("Digite o Nome: ");
    produto.Nome = Console.ReadLine();

    Console.WriteLine("Digite a Categoria: ");
    produto.Categoria = Console.ReadLine();

    Console.WriteLine("Digite o Preco: ");
    produto.Preco = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a Quantidade: ");
    produto.QuantidadeEstoque = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a Data de Validade: (DD/MM/YYYY)");
    // Essa variável guarda se a data é inválida ou não e com base nisso eu solicito a data novamente
    bool dataInvalida = true;
    while(dataInvalida)
    {
        if(DateTime.TryParse(Console.ReadLine(), out DateTime data))
        {
            produto.DataValidade = data;
            dataInvalida = false;
        }
        else
        {
            Console.WriteLine("Data inválida, insira novamente: ");
        }
    }

    return produto;
}

int EscolherProduto()
{
    Console.WriteLine("Digite o Id do Produto: ");
    return int.Parse(Console.ReadLine());
}
#endregion

