using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Circulo : IForma
    {
        public float raio;

        private float PI = 3.14f;
        public void CalcularArea()
        {
            System.Console.WriteLine($" A area do circulo é: {PI * raio * raio}");
        }
    }
}