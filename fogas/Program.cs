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
            harmadikfeladat();

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

        static void harmadikfeladat()
        {
            int kereses = 0;
            bool joszam;

            Console.WriteLine("Adj meg egy horgászjegy számot: ");
            joszam = int.TryParse(Console.ReadLine(), out kereses);
            Console.WriteLine("\n" + kereses + " horgászjegyű horgász eredményes napjai: ");
            if (joszam)
            {
                for (int i = 0; i < sorokszama; i++)
                {
                    if (kereses == jegyzek[i])
                    {
                        Console.WriteLine(datum[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Nem számot adott meg!");
                
            }
        }

        static void negyedikfeladat()
        {

        }
    }
}
