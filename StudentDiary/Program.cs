﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            //diary.AddRating(5);
            //diary.AddRating(8.5f);
            //diary.AddRating(4.7f);

            //float avg = diary.CalculateAverage();
            //float max = diary.GivMaxRating();
            //float min = diary.GivMinRating();




            for (; ; )
            {
                Console.WriteLine("Podaj ocenę od 0 do 10");

                float rating;
                bool result = float.TryParse(Console.ReadLine(),out rating);



                if (rating==11)
                {
                    break;
                }

                if (result)
                {
                    if (rating>0 && rating<=10)
                    {
                        diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowa liczba, Podaj z zakresu 1-10");
                    }
                }


            }

            Console.WriteLine("Średnia Twoich ocen: "+ diary.CalculateAverage());
            Console.WriteLine("Maksymalna ocena: "+ diary.GivMaxRating());
            Console.WriteLine("Minimalna ocena: "+ diary.GivMinRating());

            Console.ReadKey();
        }
    }

   
}
