using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapesulamento
{
    public class Carro
    {
        private string marca;

        private string modelo;

        private int velocidadeAtual;

        public void definirMarca(string Marca)
        {
            marca = Marca;
        }

        public string obterMarca()
        {
            return marca;

        }
        public void definirModelo(String Modelo)
        {
            modelo = Modelo;
        }

        public string obterMmodelo()
        {
            return modelo;

        }
        public int obterVelocidade()
        {
            return velocidadeAtual;
        }
        public void Acelerar(int velocidade)
        {
            if (velocidade > 0)
            {
                velocidadeAtual += velocidade;

            }
        }
        public void freiar(int velocidade)
        {

            if (velocidade > 0)
            {
                velocidadeAtual -= velocidade;

            }

        }

    }
}