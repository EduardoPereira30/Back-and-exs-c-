string[] Clientes = new string[3];
int[] idades = new int[3];
int[] dinheiro = new int[3];
int opcao = -1, TotalCliente = 0;

do
{
    Console.Clear();
    Console.WriteLine("=== SISTEMA BANCARIO SIMPLES ===");
    Console.WriteLine("");
    Console.WriteLine("1 - Cadatrar Criente");
    Console.WriteLine("2 - Depocitar");
    Console.WriteLine("3 - Sacar");
    Console.WriteLine("4 - Transferir");
    Console.WriteLine("5 - Listar Clientes");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("    Digite uma opção:");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CadastrarCliente();
            break;

        case 2:
            Depositar();
            break;
        case 3:

            Sacar();
            break;
        case 4:
            break;
        case 5:
            ListarCliente();
            break;

        case 0:
            Console.WriteLine("Encerrando ...");
            Console.WriteLine("Pressione <Enter> para continuar");
            Console.ReadLine();
            break;
    }

} while (opcao != 0);


void CadastrarCliente()
{
    if (TotalCliente >= 3)
    {
        Console.WriteLine("Limite atingido");
        return;

        Console.WriteLine("Pressione <Enter> para continuar");
        Console.ReadLine();
    }


    Console.WriteLine("Digite o nome");
    string n = Console.ReadLine();
    Console.WriteLine("Digite a idade");
    int i = int.Parse(Console.ReadLine());

    Clientes[TotalCliente] = n;
    idades[TotalCliente] = i;
    TotalCliente++;

    Console.WriteLine("cadastrado com sucesso");
    Console.WriteLine($"Existem {TotalCliente} Cliente(s) cadastrado(s)");
    Console.WriteLine("Pressione <Enter> para continuar");
    Console.ReadLine();


}

void ListarCliente()
{
    Console.WriteLine();
    Console.WriteLine("=== LISTA DE CLIENTES ===");


    for (int i = 0; i < Clientes.Length; i++)
    {
        Console.WriteLine($"{i} - {Clientes[i]} || saldo: R$ {dinheiro[i]}");
        Console.WriteLine();
    }

    Console.WriteLine("Pressione <Enter> para continuar");
    Console.ReadLine();
}

int BuscarCliente()
{
    ListarCliente();//desenha/exibe a lista de cliente
    Console.Write($"Digite o número do cliente: ");
    int idCliente = int.Parse(Console.ReadLine());

    if (idCliente < 0 || idCliente >= TotalCliente)
    {
        Console.WriteLine($"Cliente não encontrado");
        return -1;
    }

    return 0;
}

void Depositar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }
    Console.WriteLine($"Valor para depósito: ");
    int valorDeposito = int.Parse(Console.ReadLine());
    dinheiro[idCliente] += valorDeposito;
    Console.WriteLine($"Depósito de R$ {valorDeposito} realizado!");

    Console.ReadLine();//para o sistema e esperar o usuário dar um <Enter>

}

void Transferir()
{

    Console.WriteLine($"== Transferência ==");
    Console.WriteLine($"Conta de origem: ");
    int idClienteOrigem = BuscarCliente();
    if (idClienteOrigem == -1)
    {//não existe
        return;
    }
    Console.WriteLine($"Conta de destino: ");
    int idClienteDestino = BuscarCliente();
    if (idClienteDestino == -1)
    {//não existe
        return;
    }
    Console.WriteLine($"Valor para transferir: ");
    int valor = int.Parse(Console.ReadLine());
    if (dinheiro[idClienteOrigem] >= valor)
    {
        dinheiro[idClienteOrigem] -= valor;
        dinheiro[idClienteDestino] += valor;
        Console.WriteLine($"Saldo transferido com sucesso!");

    }
    else
    {
        Console.WriteLine($"Saldo insuficiente");
    }

    Console.WriteLine($"Pressione <Enter> para continuar");
    Console.ReadLine();//para o sistema e esperar o usuário dar um <Enter>
}

void Sacar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }
    Console.WriteLine($"Qual valor você gostaria de sacar?: ");
    int valorSolicitado = int.Parse(Console.ReadLine());

    if (dinheiro[idCliente] >= valorSolicitado)
    {
        dinheiro[idCliente] -= valorSolicitado;
        Console.WriteLine($"Saldo realizado com sucesso!");

    }
    else
    {
        Console.WriteLine($"Saldo insuficiente");
    }

    Console.WriteLine($"Pressione <Enter> para continuar");
    Console.ReadLine();//para o sistema e esperar o usuário dar um <Enter>

}