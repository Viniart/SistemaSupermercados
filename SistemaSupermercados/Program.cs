// See https://aka.ms/new-console-template for more information


using SistemaSupermercados.Models;
using SistemaSupermercados.Service;

ProdutoService produtoService = new();
ClienteService clienteService = new();
FuncionarioService funcionarioService = new();
TransacaoService transacaoService = new();

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
            EscolherMetodoCliente();
            break;
        case 2:
            EscolherMetodoFuncionario();
            break;
        case 3:
            EscolherMetodoProduto();
            break;
        case 4:
            EscolherMetodoTransacao();
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

#region Cliente
void EscolherMetodoCliente()
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
            clienteService.Listar();
            break;
        case 2:
            clienteService.Cadastrar(CriarCliente());
            break;
        case 3:
            // Descubro o Id de quem quero editar e passo o produto que quero editar
            if (clienteService.Atualizar(EscolherCliente(), CriarCliente()))
            {
                Console.WriteLine("Cliente Atualizado com Sucesso!");
            }
            else
            {
                Console.WriteLine("Identificador inválido, tente novamente");
            }
            break;
        case 4:
            if (clienteService.Deletar(EscolherCliente()))
            {
                Console.WriteLine("Cliente Deletado com Sucesso!");
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

Cliente CriarCliente()
{
    Cliente cliente = new Cliente();

    Console.WriteLine("Digite o Nome: ");
    cliente.Nome = Console.ReadLine();

    Console.WriteLine("Digite o Endereço: ");
    cliente.Endereco = Console.ReadLine();

    Console.WriteLine("Digite o Número de Telefone: ");
    cliente.NumeroTelefone = Console.ReadLine();

    Console.WriteLine("Digite a Data de Nascimento: (DD/MM/YYYY)");
    // Essa variável guarda se a data é inválida ou não e com base nisso eu solicito a data novamente
    bool dataInvalida = true;
    while (dataInvalida)
    {
        if (DateTime.TryParse(Console.ReadLine(), out DateTime data))
        {
            cliente.DataNascimento = data;
            dataInvalida = false;
        }
        else
        {
            Console.WriteLine("Data inválida, insira novamente: ");
        }
    }

    return cliente;
}

int EscolherCliente()
{
    Console.WriteLine("Digite o Id do Cliente: ");
    return int.Parse(Console.ReadLine());
}
#endregion

#region Funcionario
void EscolherMetodoFuncionario()
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
            funcionarioService.Listar();
            break;
        case 2:
            funcionarioService.Cadastrar(CriarFuncionario());
            break;
        case 3:
            // Descubro o Id de quem quero editar e passo o produto que quero editar
            if (funcionarioService.Atualizar(EscolherFuncionario(), CriarFuncionario()))
            {
                Console.WriteLine("Funcionario Atualizado com Sucesso!");
            }
            else
            {
                Console.WriteLine("Identificador inválido, tente novamente");
            }
            break;
        case 4:
            if (funcionarioService.Deletar(EscolherFuncionario()))
            {
                Console.WriteLine("Funcionario Deletado com Sucesso!");
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

Funcionario CriarFuncionario()
{
    Funcionario funcionario = new Funcionario();

    Console.WriteLine("Digite o Nome: ");
    funcionario.Nome = Console.ReadLine();

    Console.WriteLine("Digite o Cargo: ");
    funcionario.Cargo = Console.ReadLine();

    Console.WriteLine("Digite o Número de Registro: ");
    funcionario.NumeroRegistro = Console.ReadLine();
    
    Console.WriteLine("Digite o Horário de Trabalho: ");
    funcionario.HorarioTrabalho = Console.ReadLine();

    return funcionario;
}

int EscolherFuncionario()
{
    Console.WriteLine("Digite o Id do Funcionario: ");
    return int.Parse(Console.ReadLine());
}
#endregion

#region Transação
void EscolherMetodoTransacao()
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
            transacaoService.Listar();
            break;
        case 2:
            transacaoService.Cadastrar(CriarTransacao());
            break;
        case 3:
            // Descubro o Id de quem quero editar e passo o produto que quero editar
            if (transacaoService.Atualizar(EscolherTransacao(), CriarTransacao()))
            {
                Console.WriteLine("Transação Atualizado com Sucesso!");
            }
            else
            {
                Console.WriteLine("Identificador inválido, tente novamente");
            }
            break;
        case 4:
            if (funcionarioService.Deletar(EscolherTransacao()))
            {
                Console.WriteLine("Transação Deletado com Sucesso!");
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

Transacao CriarTransacao()
{
    Transacao transacao = new Transacao();

    /* Pego as listas de clientes e funcionarios
     * para garantir que o Id fornecido existe na lista
     * Feito isso faço a associação durante o cadastro
     */
    List<Cliente> listaClientes = clienteService.RetornarLista();
    List<Funcionario> listaFuncionarios = funcionarioService.RetornarLista();
    List<Produto> listaProdutos = produtoService.RetornarLista();

    bool idInvalido = true;
    int idCliente = 0;

    do
    {
        Console.WriteLine("Digite o Id do Cliente: ");
        idCliente = int.Parse(Console.ReadLine());

        // Verifico se tem alguém com o Id fornecido
        if (listaClientes.Exists(c => c.Id == idCliente))
        {
            idInvalido = false;
        }
        else
        {
            Console.WriteLine("Id Inválido, nenhum Cliente com esse Id foi encontrado");
        }
    }
    while (idInvalido);
    transacao.IdCliente = idCliente;

    bool idFuncionarioInvalido = true;
    int idFuncionario = 0;

    do
    {
        Console.WriteLine("Digite o Id do Funcionário: ");
        idFuncionario = int.Parse(Console.ReadLine());

        // Verifico se tem alguém com o Id fornecido
        if (listaFuncionarios.Exists(c => c.Id == idFuncionario))
        {
            idFuncionarioInvalido = false;
        }
        else
        {
            Console.WriteLine("Id Inválido, nenhum Funcionário com esse Id foi encontrado");
        }
    }
    while (idFuncionarioInvalido);
    transacao.IdFuncionario = idFuncionario;

    Console.WriteLine("Digite da Data da Transação: (DD/MM/YYYY)");
    bool dataInvalida = true;
    while (dataInvalida)
    {
        if (DateTime.TryParse(Console.ReadLine(), out DateTime data))
        {
            transacao.DataTransacao = data;
            dataInvalida = false;
        }
        else
        {
            Console.WriteLine("Data inválida, insira novamente: ");
        }
    }


    // Escolha de Produtos
    bool idProdutoInvalido = true;
    do
    {
        Console.WriteLine("Digite o Id do Produto: ");
        int idProduto = int.Parse(Console.ReadLine());

        // Verifico se tem alguém com o Id fornecido
        if (listaFuncionarios.Exists(c => c.Id == idProduto))
        {
            idInvalido = false;
        }
        else
        {
            Console.WriteLine("Id Inválido, nenhum Produto com esse Id foi encontrado");
            continue;
        }

        transacao.Produtos.Add(listaProdutos.Find(p => p.Id == idProduto));
        transacao.ValorTotal += listaProdutos.Find(p => p.Id == idProduto).Preco;

        Console.WriteLine("Deseja adicionar mais produtos? (S/N)");
        string resposta = Console.ReadLine();

        if (resposta.ToUpper() == "N")
        {
            idProdutoInvalido = false;
        }
    }
    while (idProdutoInvalido);

    return transacao;
}

int EscolherTransacao()
{
    Console.WriteLine("Digite o Id da Transação: ");
    return int.Parse(Console.ReadLine());
}
#endregion