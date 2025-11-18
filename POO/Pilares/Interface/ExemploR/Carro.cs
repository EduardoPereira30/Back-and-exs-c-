using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploR
{
    public class Carro : IMotor
    {
        public void Acelerar()
        {
            Console.WriteLine($"Carro acelerando... vrum vrum!");

        }
    }
}