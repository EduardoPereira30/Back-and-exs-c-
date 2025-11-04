using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    public class Pessoa
    {
        public string Nome;

        public int Idade;

        public Pessoa(string n, int i)
        {
            Nome = n;
            Idade = i;

        }

        public void Exibirdados()
        {
            System.Console.WriteLine($"Nome: {Nome} | Idade: {Idade}");
        }
    }


}