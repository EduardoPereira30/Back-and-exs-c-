using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraClass
{


    class Hello
    {
        public string TextoHello = "";

        public void SaldarUsuario()
        {

            System.Console.WriteLine(this.TextoHello);
        }
        public void SaldarComNome(string n)
        {

            System.Console.WriteLine($"Olá, {n}");
        }

    }

}