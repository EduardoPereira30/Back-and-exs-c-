using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEObjeto
{
    public class Garrafa
    {
        public string tamanho = "";
        public double capacidade = 0;
        public string Cor = "";
        public string Marcas = "";
        public void abrir()
        {
            Console.WriteLine($"Garrafa Aberta");

        }
        public void Fechar()
        {
            Console.WriteLine($"Garrafa Fechada");

        }
        public void Encher()
        {
            Console.WriteLine($"Garrafa Cheia");

        }
        public void Esvaciar()
        {
            Console.WriteLine($"Garrafa Esvaciar");

        }
    }
}