using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Diary
    {
        //stan pola klasy
        List<float> ratings = new List<float>();// zainicjowanie obiektu

        // zachowania metody
        public void AddRating(float rating) //dodawanie oceny do dzienniczka
        {
            ratings.Add(rating);
        }

        public float CalculateAverange()
        {
            float sum = 0, avg = 0;
            foreach (var rating in ratings)
            {
                sum += rating;
            }

            avg = sum / ratings.Count();  // count na liscie daje ilosc elementow 
            return avg;
        }

        public float GiveMaxRating()
        {
            return ratings.Max();
        }
        public float GiveMinRating()
        {
            return ratings.Min();
        }
    }
}
