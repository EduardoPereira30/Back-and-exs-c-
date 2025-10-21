int n1, n2;

Console.WriteLine("digite seu primeiro numero");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("digite seu segundo numero");
n2 = int.Parse(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine("numero " + n1 + "é maior");
}
else if (n1 == n2)
{
    Console.WriteLine($" os numeros são iguais");

}
else
{
    Console.WriteLine($"numero {n2} é maior");
}
