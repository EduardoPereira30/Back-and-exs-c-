Console.WriteLine("Digite seu nome ");
string nome = Console.ReadLine();

Console.WriteLine("Digite seu sobrenome ");
string sobrenome = Console.ReadLine();

Console.WriteLine($"ok, {nome}! Agora vamos dar as boas vindas a você!! ");

Console.WriteLine("Por favor escolha uma opção abaixo:");
Console.WriteLine(" 1 - Saudar: com nome ");
Console.WriteLine(" 2 - Saudar: com sobrenome ");
Console.WriteLine(" 3 - Saudar: com nome e sobrenome ");
Console.WriteLine(" 0 - Apenas saudação generica ");

int opcao = 0;

switch (opcao)
{

    case 0:
        saudacaoGenerica();
        break;
    case 1:
        saudacaoComNome(nome);
        break;
    case 2:
        saudacaoComSobrenome(sobrenome);
        break;
    case 3:
        string nomeCompleto = DevolviONomeCompleto(nome, sobrenome);
        Console.WriteLine($"sejá bem vindo de volta, {nomeCompleto}");
        break;
}

void saudacaoGenerica()
{
    Console.WriteLine($"Olá, sejá bem vindo ao nosso pograma, tenha uma otímo dia :)");

}
void saudacaoComNome(string nomeRecebido)
{
    Console.WriteLine($"sejá bem vindo de volta, {nomeRecebido}");
}
void saudacaoComSobrenome(string sobrenomeRecebido)
{
    Console.WriteLine($"Olá, sejá bem vindo de volta {sobrenomeRecebido}");
}

string DevolviONomeCompleto(string nomeRecebido, string sobrenomeRecebido)
{
    return $"{nomeRecebido} {sobrenomeRecebido}";
}
