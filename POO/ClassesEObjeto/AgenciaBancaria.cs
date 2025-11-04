using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEObjeto
{
    // public class Pessoa
    // {
    //     public string titular = "";
    //     public int idade = 0;

    //     public void falar()
    //     {
    //         Console.WriteLine($"Olá, meu nome é {titular}");
    //     }

    //     public int Envelhecer(int _anos)
    //     {
    //         if (_anos <= 0)
    //         {
    //             Console.WriteLine("idade invalida");
    //             return idade;
    //         }

    //         idade += _anos;
    //         return idade;
    //     }

    // }

    public class AgenciaBancaria
    {
        public double saldo = 0;

        public string titular = "";

        public AgenciaBancaria(String titular, double saldoInit = 0)
        {
            titular = titular;
            saldo = saldoInit;
        }
        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                saldo += valor;
                System.Console.WriteLine($"Deposito no valor de R$ {valor:F2} realizado");

            }
            else
            {
                System.Console.WriteLine("O valor deve ser maior do que zero");
            }
            System.Console.WriteLine($"");
        }

        public void sacar(double valor)
        {

            if (valor > 0 && valor <= 0)
            {
                saldo -= valor;
                System.Console.WriteLine($"Deposito no valor de R$ {valor:F2} realizado");

            }
            else if (valor > saldo)
            {
                System.Console.WriteLine("saldo insufisiente");
            }
        }
    }
}