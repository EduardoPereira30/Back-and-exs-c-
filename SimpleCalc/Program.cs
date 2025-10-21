// See https://aka.ms/new-console-template for more info

string nome;
int n1;
int n2;

Console.WriteLine("digite seu nome");
nome = Console.ReadLine();

Console.WriteLine("digite seu primeiro numero");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("digite seu segundo numero");
n2 = int.Parse(Console.ReadLine());

int soma = n1 + n2;

Console.WriteLine(nome);
Console.WriteLine(soma);
