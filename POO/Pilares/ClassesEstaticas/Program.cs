using ClassesEstaticas;

Console.Clear();
System.Console.WriteLine("bem-vindo ao sistema");
// System.Console.WriteLine();

// System.Console.WriteLine("Digite o primero   numero:");
// float a = float.Parse(Console.ReadLine());

// System.Console.WriteLine("Digite o segundo numero:");
// float b = float.Parse(Console.ReadLine());

// Calculos.Somar(a, b);
// Calculos.Subtrair(a, b);
// Calculos.Mutiplicar(a, b);

// if (b == 0)
// {
//     System.Console.WriteLine(" Divisão invalida");
// }
// else { Calculos.Dividir(a, b); }

System.Console.WriteLine("Digite 1° numero :");

float n1 = float.Parse(System.Console.ReadLine());

System.Console.WriteLine("Digite 2° numero :");
float n2 = float.Parse(Console.ReadLine());


if (n1 == n2)
{

    System.Console.WriteLine("Os dois são iguais");
}
else
{
    Console.WriteLine($" Maior: {Math.Max(n1, n2)}");
    Console.WriteLine($" Menor: {Math.Min(n1, n2)}");
}

