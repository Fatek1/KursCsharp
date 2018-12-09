using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETLE
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pętle
            //https://www.youtube.com/watch?v=jAoizbTxWc4&list=PL6aekdNhY7DAeU-2LEGBDXls60Yy-Ubbu&index=5

            //int a = 0;


            //while (a < 10)
            //{
            //    Console.WriteLine(a);
            //    a++;
            //}


            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(DateTime.Now.TimeOfDay);
            //}

            //do
            //{
            //    Console.WriteLine("Tekst");
            //} while (false);





            /*
             * komentarze
             * Ctrl+K Ctrl+D formatowanie kodu
             * Ctrl+K Ctrl+C komentowanie zaznaczonego kodu
             * Ctrl+K Ctrol+U usuwanie komnetarza z zaznaczonego kodu
             */

            //RZUTOWANIE ZMIENNYCH
            //int i = int.MaxValue;
            //double d = 5.1;

            //i = (int)d;
            //Console.WriteLine(i);

            //WCZYTYWANIE DANYCH Z KONSOLI
            //string s = Console.ReadLine();


            //KONWERSJA TYPÓW (STRING>INT, INT>STRING)
            //int i = int.Parse(s)+2;
            //Console.WriteLine(i);

            //s = i.ToString();

            //Console.WriteLine(s);
            //KNOSLA

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Witaj {0} \n","Sławek");
            Console.Beep();
            Console.ReadKey();
        }
    }
}
