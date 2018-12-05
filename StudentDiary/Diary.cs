using System;
using System.Collections.Generic;
using System.Linq;


namespace StudentDiary
{
    class Diary
    {
        //stan zmienne tj. pola

        List<float> ratings= new List<float>();



        //zachowania inaczej metody

        /// <summary>
        /// Dodaje ocenę
        /// </summary>
        /// <param name="rating"></param>        
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }


        /// <summary>
        /// Obliczanie średniej z ocen
        /// </summary>
        /// <returns></returns>
        public float CalculateAverage()
        {
            float sum = 0;
            float avg = 0;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            avg = sum / ratings.Count();
            return avg;
        }
        /// <summary>
        /// Pobiera maksymalną ocenę
        /// </summary>
        /// <returns></returns>
        public float GivMaxRating()
        {
            return ratings.Max();
        }

        /// <summary>
        ///Podaje minimalną ocenę
        /// </summary>
        /// <returns></returns>
        public float GivMinRating()
        {
            return ratings.Min();
        }
    }

}
