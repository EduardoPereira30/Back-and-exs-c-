using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    public class Pessoa3Sobrecarga
    {
        public string Nome;

        public int Idade;

        public Pessoa3Sobrecarga()
        {
            Nome = "Desconhacido";
            Idade = 0;

        }
        public Pessoa3Sobrecarga(string n)
        {
            Nome = n;
            Idade = 0;

        }
        public Pessoa3Sobrecarga(string n, int i)
        {
            Nome = n;
            Idade = i;

        }
    }
}