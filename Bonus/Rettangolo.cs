using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus
{
    internal class Rettangolo
    {
        public string nomeRettangolo;
        public int baseRettangolo;
        public int altezzaRettangolo;


        public void CalcolaPerimetro()
        {
            int perimetro = baseRettangolo + altezzaRettangolo * 2;
            Console.WriteLine("Perimetro: " + perimetro + " cm");
        }

        public void CalcolaArea()
        {
            int area = baseRettangolo * altezzaRettangolo;
            Console.WriteLine("Area: " + area + " cm");
        }

        public void StampaRettangolo()
        {
            Console.WriteLine("--" + nomeRettangolo + "--");
            Console.WriteLine("Base: " + baseRettangolo);
            Console.WriteLine("Altezza: " + altezzaRettangolo);
            CalcolaPerimetro();
            CalcolaArea();
            DisegnaRettangolo();
        }

        public void DisegnaRettangolo()
        {
            for (int i = 0; i < baseRettangolo; i++)
            {
                Console.Write("--");
            }

            Console.WriteLine();
            for (int i = 0; i < altezzaRettangolo; i++)
            {
                Console.Write("|");
                for (int k = 0; k < baseRettangolo - 1; k++)
                {
                    Console.Write("  ");
                }
                Console.Write("| \n");
            }

            for (int i = 0; i < baseRettangolo; i++)
            {
                Console.Write("--");
            }
            Console.WriteLine();
        }
    }


}
