using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using Encapesulamento;

Console.Clear();
// float dinheiro = 200;

// ContaBancaria cbedu = new ContaBancaria();
// ContaBancaria cbmari = new ContaBancaria(dinheiro);

// cbedu.Depositar(dinheiro);
// System.Console.WriteLine($"saldo da conta edu: R$ {cbedu.GetSaldo()}");
// cbmari.Sacar(200);
// System.Console.WriteLine($"saldo da conta maria: R$ {cbmari.GetSaldo()}");


Carro c = new Carro();

c.definirMarca("sei lá");

c.definirModelo("fosca");

c.Acelerar(50);
c.Acelerar(100);
c.freiar(10);

System.Console.WriteLine($"Marca: {c.obterMarca()}");
System.Console.WriteLine($"Modelo: {c.obterMmodelo()}");
System.Console.WriteLine($"Velocidade atual: {c.obterVelocidade()}");

