using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEstaticas
{
    public static class Calculos
    {
        public static void Somar(float a, float b)
        {

            System.Console.WriteLine($" A soma é : {a + b}");
        }
        public static void Subtrair(float a, float b)
        {

            System.Console.WriteLine($" A subtração é : {a - b}");

        }
        public static void Mutiplicar(float a, float b)
        {

            System.Console.WriteLine($" A mutiplicação é : {a * b}");

        }
        public static void Dividir(float a, float b)
        {

            System.Console.WriteLine($" A divisão é : {a / b}");

        }


    }
}