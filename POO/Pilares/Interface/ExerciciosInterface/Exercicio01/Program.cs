using System.Reflection;
using Exercicio01;

System.Console.WriteLine($"Bem vindo ao programa cálculos de Geometria ");
System.Console.WriteLine();
System.Console.WriteLine($"Vamos calcular o retangulo");
System.Console.WriteLine($"Digite a largura do retangulo");
float l = float.Parse(Console.ReadLine());
System.Console.WriteLine($"Digite a largura do retangulo");
float a = float.Parse(Console.ReadLine());

Retangulo r = new Retangulo();
r.altura = a;
r.largura = l;

r.CalcularArea();

System.Console.WriteLine();
System.Console.WriteLine("click <enter> para continuar");
Console.ReadLine();

Console.Clear();

System.Console.WriteLine($"Vamos calcular o circulo");

System.Console.WriteLine($"Digite o raio do circulo");
float ra = float.Parse(Console.ReadLine());

Circulo c = new Circulo();
c.raio = ra;

c.CalcularArea();