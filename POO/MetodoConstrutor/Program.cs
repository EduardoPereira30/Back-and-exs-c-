// Pessoa Fontes = new Pessoa("joão", 17);

// // Fontes.Nome = "Felipe Fontes";
// // Fontes.Idade = 17;

// Fontes.Exibirdados();

// // Fontes.Nome = "Gustavo Oliveira";

// // Fontes.Exibirdados();


using MetodoConstrutor;
//Primeiro contrutor
Console.Clear();
System.Console.WriteLine();
Pessoa3Sobrecarga p1 = new Pessoa3Sobrecarga();
System.Console.WriteLine($"Primeira pessoa {p1.Nome} || idade: {p1.Idade}");
System.Console.WriteLine();

//Segundo contrutor
Pessoa3Sobrecarga p2 = new Pessoa3Sobrecarga("Eduardo pereira");
System.Console.WriteLine($"Segunda pessoa {p2.Nome} || idade: {p2.Idade}");
System.Console.WriteLine();

//Terceiro contrutor
Pessoa3Sobrecarga p3 = new Pessoa3Sobrecarga("Julia Mauricio", 17);

System.Console.WriteLine("digite o seu nome");
p3.Nome = Console.ReadLine();
System.Console.WriteLine();

System.Console.WriteLine("digite sua idade");
p3.Idade = int.Parse(Console.ReadLine());
System.Console.WriteLine();

System.Console.WriteLine($"Terceira pessoa {p3.Nome} || idade: {p3.Idade}");
System.Console.WriteLine();

