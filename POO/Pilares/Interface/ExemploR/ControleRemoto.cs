using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploR
{
    public class ControleRemoto
    {
        public int NivelVolume = 0;
        public int VolumeMaximo = 100;

        public void AumentarVolume()
        {
            if (NivelVolume < VolumeMaximo)
            {

                NivelVolume++;
                Console.WriteLine($"Nível atual do volume: {NivelVolume}");
            }
            else
            {
                Console.WriteLine($"O volume já atingiu o nível máximo {NivelVolume}");
            }
        }

        public void Desligar()
        {
            Console.WriteLine($"Desligando a tv ...");

        }

        public void DiminuirVolume()
        {
            if (NivelVolume == 0)
            {
                Console.WriteLine($"O volume já está no mínimo {NivelVolume}");

            }
            else
            {
                NivelVolume--;
                Console.WriteLine($"Volume atual: {NivelVolume}");

            }
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando a TV ...");
        }
    }
}