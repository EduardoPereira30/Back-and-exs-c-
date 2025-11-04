using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraClass
{
        public class Carro
        {

            public int qtRodas = 0;
            public int qtPortas = 0;
            public string Marcas = "";
            public string Modelo = "";
            public string Cor = "";
            public void Acelerar()
            {
                Console.WriteLine($"Carro Acelerando");

            }
            public void Freiar()
            {
                Console.WriteLine($"Carro Freiando");

            }
            public void Ligar()
            {
                Console.WriteLine($"Carro ligado");

            }
            public void Desligar()
            {
                Console.WriteLine($"Carro desligar");

            }

        }

}