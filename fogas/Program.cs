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

        static void Main(string[] args)
        {
            
            Console.WriteLine("Beolvasás:");
            beolvasa();
            masodikfeladat();

            Console.ReadKey();
        }

        static void beolvasa()
        {
            StreamReader be = new StreamReader(@"E:\naplo.txt");
            int sorokszama = File.ReadLines(@"E:\naplo.txt").Count();
            string sor = " ";
            int index = 0;
            jegyzek = new int[sorokszama];
            datum = new string[sorokszama];

            while ((sor = be.ReadLine())!= null)
            {
                string[] temp = sor.Split(' ');
                jegyzek[index] = Convert.ToInt32(temp[0]);
                datum[index] = temp[1];
                index++;
            }
            be.Close();
            for (int i = 0; i < 100; i++)
            {
                Console.Write(jegyzek[i] + " " + datum[i] + "\n");
            }
        }

        static void masodikfeladat()
        {
            halfajok = new string[] { "Ponty", "Csuka", "Süllő", "Harcsa", "Balin", "Angolna", "Pisztráng", "Márna", "Kecsege", "Amúr" };
            for (int i = 0; i < halfajok.Length; i++)
            {
                Console.WriteLine(halfajok[i]);
            }
            
        }
    }
}
