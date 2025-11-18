using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploR
{
    public class Moto : IMotor
    {
        public void Acelerar()
        {
            Console.WriteLine($"Acelerando e dando Grau na motoka!");

        }
    }
}