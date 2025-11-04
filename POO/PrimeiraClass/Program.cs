using System.Security.Cryptography;
using PrimeiraClass;

// System.Console.WriteLine("digite seu nome");
// string nome = Console.ReadLine();

// Hello cumprimento = new Hello();

// cumprimento.TextoHello = "Olá Mundo";

// cumprimento.SaldarUsuario();
// cumprimento.SaldarComNome(nome);

// Carro c1 = new Carro();

// c1.Marcas = "Lamborghine";
// c1.Modelo = "Urus";
// c1.qtRodas = 4;
// c1.Cor = "Roxa";
// c1.qtPortas = 4;
// c1.Ligar();
// c1.Desligar();
// c1.Acelerar();
// c1.Freiar();

// Carro c2 = new Carro();

// c2.Marcas = "Civic";
// c2.Modelo = "g10";
// c2.Cor = "Amarelo";
// c2.qtPortas = 4;
// c2.Ligar();
// c2.Desligar();
// c2.Acelerar();
// c2.Freiar();



// System.Console.WriteLine($"ligando o {c2.Modelo}");
// System.Console.WriteLine($"acelerando o {c2.Modelo}");
// System.Console.WriteLine($"freiando o {c2.Modelo}");
// System.Console.WriteLine($"desligando o {c2.Modelo}");
// System.Console.WriteLine();
// System.Console.WriteLine("-------------- Caracteristicas: -----------");
// System.Console.WriteLine();

// System.Console.WriteLine($"---------------{c1.Marcas}---------------");

// System.Console.WriteLine($"Carro: {c1.Marcas}");
// System.Console.WriteLine($"Modelo: {c1.Modelo}");
// System.Console.WriteLine($"Cor: {c1.Cor}");
// System.Console.WriteLine($"Quantidade de Portas: {c1.qtPortas}");

// System.Console.WriteLine();
// System.Console.WriteLine("---");
// System.Console.WriteLine();

// System.Console.WriteLine($"---------------{c2.Marcas}---------------");

// System.Console.WriteLine($"Carro: {c2.Marcas}");
// System.Console.WriteLine($"Modelo: {c2.Modelo}");
// System.Console.WriteLine($"Cor {c2.Cor}");
// System.Console.WriteLine($"Quantidade de Portas: {c2.qtPortas}");

// Moto m1 = new Moto();

// m1.Marcas = "BMW";
// m1.Modelo = "Adventure. R 1300 GS Adventure";
// m1.qtRodas = 2;
// m1.Cor = "Roxa";
// m1.Ligar();
// m1.Desligar();
// m1.Acelerar();
// m1.Freiar();

// Moto m2 = new Moto();

// m2.Marcas = "Honda";
// m2.Modelo = "Pop 110i";
// m2.Cor = "Preto";
// m2.qtRodas = 2;
// m2.Ligar();
// m2.Desligar();
// m2.Acelerar();
// m2.Freiar();



// System.Console.WriteLine($"ligando o {m2.Modelo}");
// System.Console.WriteLine($"acelerando o {m2.Modelo}");
// System.Console.WriteLine($"freiando o {m2.Modelo}");
// System.Console.WriteLine($"desligando o {m2.Modelo}");
// System.Console.WriteLine();
// System.Console.WriteLine("-------------- Caracteristicas: -----------");
// System.Console.WriteLine();

// System.Console.WriteLine($"---------------{m1.Marcas}---------------");

// System.Console.WriteLine($"Moto: {m1.Marcas}");
// System.Console.WriteLine($"Modelo: {m1.Modelo}");
// System.Console.WriteLine($"Cor: {m1.Cor}");
// System.Console.WriteLine($"Quantidade de Rodas: {m1.qtRodas}");

// System.Console.WriteLine();
// System.Console.WriteLine("---");
// System.Console.WriteLine();

// System.Console.WriteLine($"---------------{m2.Marcas}---------------");

// System.Console.WriteLine($"Moto: {m2.Marcas}");
// System.Console.WriteLine($"Modelo: {m2.Modelo}");
// System.Console.WriteLine($"Cor {m2.Cor}");
// System.Console.WriteLine($"Quantidade de Rodas: {m2.qtRodas}");

Console.Clear();

Garrafa g1 = new Garrafa();

Console.WriteLine("qual a marca da garrafa?");
g1.Marcas = Console.ReadLine();
Console.WriteLine("qual o tamanho da garrafa em cm?");
g1.tamanho = Console.ReadLine();
Console.WriteLine("qual a capacidade em litros da garrafa?");
g1.capacidade = double.Parse(Console.ReadLine());
Console.WriteLine("qual a Cor da garrafa?");
g1.Cor = Console.ReadLine();
g1.abrir();
g1.Esvaciar();
g1.Encher();
g1.Fechar();


Console.WriteLine();

Console.WriteLine("---- Segunda Garrafa ----");

Console.WriteLine();

Garrafa g2 = new Garrafa();

Console.WriteLine("qual a marca da garrafa?");
g2.Marcas = Console.ReadLine();
Console.WriteLine("qual o tamanho da garrafa em cm?");
g2.tamanho = Console.ReadLine();
Console.WriteLine("qual a capacidade em litros da garrafa?");
g2.capacidade = double.Parse(Console.ReadLine());
Console.WriteLine("qual a Cor da garrafa?");
g2.Cor = Console.ReadLine();
g2.abrir();
g2.Esvaciar();
g2.Encher();
g2.Fechar();

Console.WriteLine();
Console.WriteLine("-------------- Caracteristicas: -----------");
Console.WriteLine();

Console.WriteLine($"---------------{g1.Marcas}---------------");

Console.WriteLine($"Garrafa: {g1.Marcas}");
Console.WriteLine($"tamanho: {g1.tamanho} cm");
Console.WriteLine($"Cor: {g1.Cor}");
Console.WriteLine($"Capacidade de {g1.capacidade} em litros");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"---------------{g2.Marcas}---------------");

Console.WriteLine($"Garrafa: {g2.Marcas}");
Console.WriteLine($"tamanho: {g2.tamanho} cm");
Console.WriteLine($"Cor: {g2.Cor}");
Console.WriteLine($"Capacidade de {g2.capacidade} em litros");


