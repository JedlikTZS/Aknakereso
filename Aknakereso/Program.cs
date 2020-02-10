using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aknakereso
{
    class Program
    {

        static void Feltöltés(char[,] pálya)
        {
            for (int i = 0; i < pálya.GetLength(0); i++)
            {
                for (int j = 0; j < pálya.GetLength(1); j++)
                {
                    pálya[i, j] = '_';
                }
            }
        }

        static void Main(string[] args)
        {
            char[,] pálya = new char[10, 10];
            Feltöltés(pálya);
            Console.WriteLine("Add meg a bombák számát: ");
            int bombaSzám = int.Parse(Console.ReadLine());
            BombaSorsoló(pálya, bombaSzám);
            Kirajzoló(pálya, false);
            Lépés(pálya, false);
            Console.ReadKey();
        }

        static void Lépés(char[,] pálya, bool legyenBomba)
        {
            int sorbe, oszlopbe;
            do
            {
                do
                {
                    Console.Write("Add meg a sort: ");
                    sorbe = int.Parse(Console.ReadLine());
                } while (sorbe < 1 || 10 < sorbe);
                do
                {
                    Console.Write("Add meg az oszlopot: ");
                    oszlopbe = int.Parse(Console.ReadLine());
                } while (oszlopbe < 1 || 10 < oszlopbe);
                sorbe--;
                oszlopbe--;
                if (pálya[sorbe, oszlopbe] == 'B')
                {
                    Console.WriteLine("Bombára léptél!");
                    break;
                }
                pálya[sorbe, oszlopbe] = 'X';
                Kirajzoló(pálya, legyenBomba);
            } while (pálya[sorbe, oszlopbe] != 'B');

        }

        static void BombaSorsoló(char[,] pálya, int bombaSzám)
        {
            Random rnd = new Random();
            int sor, oszlop;
            for (int i = 0; i < bombaSzám; i++)
            {
                do
                {
                    sor = rnd.Next(0, 10);
                    oszlop = rnd.Next(0, 10);
                } while (pálya[sor, oszlop] == 'B');
                pálya[sor, oszlop] = 'B';
            }
        }

        static void Kirajzoló(char[,] pálya, bool legyenBomba)
        {
            for (int i = 0; i < pálya.GetLength(0); i++)
            {
                for (int j = 0; j < pálya.GetLength(1); j++)
                {
                    if (legyenBomba)
                    {
                        Console.Write(pálya[i, j]);
                    }
                    else if (pálya[i, j] != 'X')
                    {
                        Console.Write('_');
                    }

                    Console.Write('|');
                }
                Console.WriteLine();
            }
        }
    }
}

