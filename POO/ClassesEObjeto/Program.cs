using System.Security.Cryptography;
using ClassesEObjeto;

// -------------------- ATIVIDADE 1 ------------------------

// System.Console.WriteLine("digite seu nome");
// string nome = Console.ReadLine();

// Console.Clear();

// Garrafa g1 = new Garrafa();

// Console.WriteLine("qual a marca da garrafa?");
// g1.Marcas = Console.ReadLine();

// Console.WriteLine("qual o tamanho da garrafa em cm?");
// g1.tamanho = Console.ReadLine();

// Console.WriteLine("qual a capacidade em litros da garrafa?");
// g1.capacidade = double.Parse(Console.ReadLine());

// Console.WriteLine("qual a Cor da garrafa?");
// g1.Cor = Console.ReadLine();

// g1.abrir();
// g1.Esvaciar();
// g1.Encher();
// g1.Fechar();


// Console.WriteLine();
// Console.WriteLine($"--------------- {nome} ------------------");
// Console.WriteLine();
// Console.WriteLine("-------------- Caracteristicas -----------");
// Console.WriteLine();

// Console.WriteLine($"---------------{g1.Marcas}---------------");

// Console.WriteLine($"Garrafa: {g1.Marcas}");
// Console.WriteLine($"tamanho: {g1.tamanho} cm");
// Console.WriteLine($"Cor: {g1.Cor}");
// Console.WriteLine($"Capacidade de {g1.capacidade} em litros");



// -------------------- ATIVIDADE 2 ------------------------

int opcao;
do
{
    System.Console.Clear();
    System.Console.WriteLine();
    System.Console.WriteLine("*---Agencia Bancaria ---*");
    System.Console.WriteLine("digite o nome do titular");
    string nomeT = System.Console.ReadLine();

    AgenciaBancaria conta = new AgenciaBancaria(nomeT);

    System.Console.WriteLine();
    System.Console.WriteLine($"Bem vindo, {conta.titular}");
    System.Console.WriteLine($"Saldo inicial: R$ {conta.saldo:F2}");
    System.Console.WriteLine();

    System.Console.WriteLine("--- menu ---");
    System.Console.WriteLine("    1) Depocitar");
    System.Console.WriteLine("    2) Sacar");
    System.Console.WriteLine("    0) Sair");
    System.Console.WriteLine();
    opcao = int.Parse(Console.ReadLine());
    System.Console.WriteLine();

    switch (opcao)
    {
        case 1:
            System.Console.WriteLine("digite o valor do depocito");
            double depocito = Convert.ToDouble(Console.ReadLine());
            conta.Depositar(depocito);
            break;
        case 2:
            System.Console.WriteLine("quanto deseja sacar");
            double saque = Convert.ToDouble(Console.ReadLine());
            conta.sacar(saque);
            break;
        case 0:
            System.Console.WriteLine("saindo");
            break;
        default:
            System.Console.WriteLine("opção invalida");
            break;

    }
} while (opcao != 0);
