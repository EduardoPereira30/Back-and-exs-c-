using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Fatura : IIprimivel
    {

        public string Devedor;
        public string Credor;

        public float Valor;
        public int DiasDeAtraso;

        public float juros = 0.10f;


        public Fatura(string dev, string cred, float valFat, int qtdAtraso)
        {
            Devedor = dev;
            Credor = cred;
            DiasDeAtraso = qtdAtraso;
            Valor = valFat;
        }
        public void Imprimir()
        {
            System.Console.WriteLine($"Credor: {Credor}");
            System.Console.WriteLine($"Devedor: {Devedor}");
            System.Console.WriteLine($"Dias de atraso: {DiasDeAtraso} dias");
            System.Console.WriteLine($"Valor: R${Valor:f2}");
            System.Console.WriteLine($"Juros: R${juros * DiasDeAtraso:f2}");
            System.Console.WriteLine($"Total: R${Valor:f2}");

        }

        public void CalcularValorDevido()
        {

            if (DiasDeAtraso > 0)
            {
                Valor = Valor * DiasDeAtraso * juros;
            }
        }
    }
}
