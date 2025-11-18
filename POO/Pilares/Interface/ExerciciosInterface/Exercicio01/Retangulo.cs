using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Retangulo : IForma
    {

        public float altura;
        public float largura;
        public void CalcularArea()
        {
            System.Console.WriteLine($" A area do retangulo é: {largura * altura}");
        }
    }
}