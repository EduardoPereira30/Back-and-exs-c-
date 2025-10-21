int numero = 0, resultado = 0;

for (int n = 1; n <= 3; n++)
{
    Console.WriteLine($"digite o {n} numero");
    numero = int.Parse(Console.ReadLine());

    resultado += numero;

}
Console.WriteLine("o resultado é :" + resultado);