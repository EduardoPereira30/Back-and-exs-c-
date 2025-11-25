using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapesulamento
{
    public class ContaBancaria
    {
        private float Saldo;

        public ContaBancaria()
        {
            Saldo = 0;
        }

        public ContaBancaria(float SaldoInicial)
        {
            if (SaldoInicial >= 0)
            {
                Saldo = SaldoInicial;
                return;

            }
        }

        public void Depositar(float valor)
        {
            if (valor >= 0)
            {
                Saldo = valor;
                return;

            }
            System.Console.WriteLine("valor invalido");
        }

        public float GetSaldo()
        {
            return Saldo;

        }

        public void Sacar(float saca)
        {

            if (saca > Saldo)
            {

                System.Console.WriteLine("saldo insufisciente para sacar");
            }
            else
            {
                Saldo -= saca;
                return;

            }
        }
    }
}