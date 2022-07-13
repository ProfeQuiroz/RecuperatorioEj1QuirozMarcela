using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRecuperatorioej1QuirozMarcela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Comprar pesos";
            double dolares;
            double euros;
            double oficial;
            double paralelo;

            Console.Write("Ingrese los dolares disponibles:");
            dolares = double.Parse(Console.ReadLine());

            oficial= dolares * 230;
            paralelo= dolares * 280;
            euros= dolares / 1.17;
        { 
            Console.WriteLine($"Puede adquirir {oficial} pesos en el mercado oficial");
            Console.WriteLine($"Puede adquirir {paralelo} pesos en el mercado paralelo");
            Console.WriteLine($"Su equivalente en euros es {euros}");
        }
            Console.ReadLine();

        }
        
    }
}
