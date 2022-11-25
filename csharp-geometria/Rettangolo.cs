using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_geometria
{
    public class Rettangolo
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
            Console.WriteLine("Alteza: " + altezzaRettangolo);
            CalcolaPerimetro();
            CalcolaArea();
            
        }
    }
    

}

