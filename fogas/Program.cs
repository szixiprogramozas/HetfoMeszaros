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
        static double[,] halak;
        static string[] halfajok;
        static int sorokszama;
        static int oszlop;

        static void Main(string[] args)
        {
            Console.WriteLine("1. feladat");
            beolvasas();
            Console.WriteLine("naplo.txt beolvasva\n");

            Console.WriteLine("2. feladat: ");
            masodikfeladat();

            Console.WriteLine("3. feladat: ");
            harmadikfeladat();

            Console.WriteLine("4. feladat: ");
            negyedikfeladat();

            Console.WriteLine("5. feladat: ");
            otodikfeladat();
            hatodikfeladat();
            hetedikfeladat();
            nyolcadikfeladat();

            Console.ReadKey();
        }

        static void beolvasas()
        {
            StreamReader be = new StreamReader(@"naplo.txt");
            sorokszama = File.ReadLines(@"naplo.txt").Count();
            string sor = " ";
            int index = 0;
            jegyzek = new int[sorokszama];
            datum = new string[sorokszama];
            oszlop = 13;
            halak = new double[oszlop, sorokszama];

            while ((sor = be.ReadLine())!= null)
            {
                string[] temp = sor.Split(' ');
                jegyzek[index] = Convert.ToInt32(temp[0]);
                datum[index] = temp[1];
                for (int i = 2; i < oszlop; i++)
                {
                    halak[i, index] = Convert.ToDouble(temp[i].Replace('.', ','));
                }
                index++;
            }
            be.Close();        }

        static void masodikfeladat()
        {
            halfajok = new string[] { "Ponty", "Csuka", "Sullo", "Harcsa", "Balin", "Angolna", "Pisztrang", "Marna", "Kecsege", "Amur" };

            for (int i = 0; i < halfajok.Length; i++)
            {
                Console.WriteLine(halfajok[i]);
            }
            Console.WriteLine(" ");
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
            Console.WriteLine(" ");
        }

        static void negyedikfeladat()
        {
            int eredmenyestag = 0;
            for (int i = 0; i < sorokszama; i++)
			{
                for (int j = 2; j < oszlop; j++)
			    {
                    if (halak[j, i] != 0)
	                {
                        eredmenyestag++;
	                }
			    }
			}
            Console.WriteLine("Eredményes tagok száma: " + eredmenyestag);
            Console.WriteLine(" ");
        }

        static void otodikfeladat()
        {
            HashSet<int> januar = new HashSet<int>();
            for (int i = 0; i < sorokszama; i++)
			{
                datum[i] = datum[i].Substring(0,2);
                if (datum[i] == "01")
	            {
                    januar.Add(i+1);
	            }
			}
            foreach (var item in januar)
	        {
                Console.WriteLine(item);
	        }
            Console.WriteLine(" ");
        }

        static void hatodikfeladat()
        {
            double legnagyobb = 0;
            legnagyobb = halak[0, 0];
            int index = 0;
            for (int i = 0; i < sorokszama; i++)
            {
                for (int j = 2; j < oszlop; j++)
                {
                    if (halak[j, i] > legnagyobb)
                    {
                        legnagyobb = halak[j, i];
                    }
                }
            }
            Console.WriteLine(jegyzek[index] + " " + legnagyobb + "kg ");
        }

        static void hetedikfeladat()
        {
            
        }

        static void nyolcadikfeladat()
        {
            
        }

        static void kilencedikfeladat()
        {

        }
    }
}
