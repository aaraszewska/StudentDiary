using System;
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
            //float avg = diary.CalculateAverange();
            //float max = diary.GiveMaxRating();
            //float min = diary.GiveMinRating();

            for (; ; )
            {
                Console.WriteLine(  "podaj ocene z zakresu 1-10");
                float rating = float.Parse(Console.ReadLine());
                

                if(rating == 11)
                {
                    break;
                }
                diary.AddRating(rating);
            }
            Console.WriteLine("Srednia twoich ocen to:" + diary.CalculateAverange());
            Console.WriteLine("max ocena to:" + diary.GiveMaxRating());
            Console.WriteLine("min ocena to:" + diary.GiveMinRating());

            Console.ReadKey();
        }
    }
}
