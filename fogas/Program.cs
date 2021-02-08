using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fogas
{
    class Program
    {
        static int[] jegyzek;
        static string[] datum;
        static string[,] halak;
        static string[] halfajok;
        static int sorokszama;
        static int oszlop;

        static void Main(string[] args)
        {
            
            Console.WriteLine("Beolvasás:");
            beolvasas();
            masodikfeladat();

            Console.ReadKey();
        }

        static void beolvasas()
        {
            StreamReader be = new StreamReader(@"E:\naplo.txt");
            sorokszama = File.ReadLines(@"E:\naplo.txt").Count();
            string sor = " ";
            int index = 0;
            jegyzek = new int[sorokszama];
            datum = new string[sorokszama];
            oszlop = 13;
            halak = new string[oszlop, sorokszama];

            while ((sor = be.ReadLine())!= null)
            {
                string[] temp = sor.Split(' ');
                jegyzek[index] = Convert.ToInt32(temp[0]);
                datum[index] = temp[1];
                for (int i = 2; i < oszlop; i++)
                {
                    halak[i, index] = temp[i];
                }
                index++;
            }
            be.Close();        }

        static void masodikfeladat()
        {
            halfajok = new string[] { "Ponty", "Csuka", "Süllő", "Harcsa", "Balin", "Angolna", "Pisztráng", "Márna", "Kecsege", "Amúr" };
        }
    }
}
