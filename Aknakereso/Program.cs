using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aknakereso
{
    class Program
    {
        
        static void Main(string[] args)
        {
            char[,] palya = new char[10, 10];
            Feltoltes(palya);
            Kirajzolo(palya);

            Console.ReadKey();
        }

        static void Kirajzolo(char[,] palya)
        {
            for (int i = 0; i < palya.GetLength(0); i++)
            {
                for (int j = 0; j < palya.GetLength(1); j++)
                {
                    Console.Write(palya[i,j]);
                }
                Console.WriteLine();
            }
        }

        static void Feltoltes(char[,] palya)
        {
            for (int i = 0; i < palya.GetLength(0); i++)
            {
                for (int j = 0; j < palya.GetLength(1); j++)
                {
                    palya[i, j] = '_';
                }
            }
            Random rnd = new Random();
            int sor, oszlop;
            for (int i = 0; i < 10; i++)
            {
               do
               {
                  sor = rnd.Next(0, 10);
                  oszlop = rnd.Next(0, 10);
               } while (palya[sor, oszlop] == 'B');
               palya[sor, oszlop] = 'B';
            }
        }
    }
}
