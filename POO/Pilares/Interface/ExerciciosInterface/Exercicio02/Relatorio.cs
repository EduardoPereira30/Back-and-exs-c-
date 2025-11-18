using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Relatorio : IIprimivel
    {
        public string Nome;

        public string TextoRelatorio = "";

        public Relatorio(string responsavel, string TextRelatorio)
        {
            responsavel = Nome;

            TextRelatorio = TextoRelatorio;
        }
        public void Imprimir()
        {
            Console.WriteLine($"Responsavel: {Nome}...");
            Console.WriteLine(TextoRelatorio);
            Console.WriteLine($"--");
        }
    }
}