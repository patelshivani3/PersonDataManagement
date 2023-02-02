using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    public class PersonDataManagement
    {
        public static void RetrieveTop2LessThan60(List<Person> list)
        {
            //OrderBy() method is use to sort data in ascending order
            var top2 = list.Where(p => p.Age < 60).OrderBy(a => a.Age).Take(2);
            Console.WriteLine("\nRetrive top 2 Person less than Age 60 =");
            Program.DisplayPersonDetails(top2);
        }
        public static void AgeBetween13to18(List<Person> list)
        {
            var teenage = list.Where(p => p.Age > 13 && p.Age < 18);
            Console.WriteLine("\nRetrive records Between Age 13 to 18 =");
            Program.DisplayPersonDetails(teenage);
        }
        public static void AverageAge(List<Person> list)
        {
            var avgAge = list.Average(p => p.Age);
            Console.WriteLine("\nAverage Age is : " + Math.Round(avgAge, 2));
        }
        public static void CheckName(List<Person> list, string input)
        {
            var result = list.Where(p => p.Name == input).ToList();

            if (result.Count > 0)
            {
                Console.WriteLine("\nName is Present");
            }
            else
            {
                Console.WriteLine("\nName is not Present");
            }
        }
        public static void SkipAgeLessThan60(List<Person> list)
        {
            var result = list.OrderBy(p =>p.Age).SkipWhile(p => p.Age < 60);
            Console.WriteLine("\nSkip records from the list having age less than 60");
            Program.DisplayPersonDetails(result);
        }

    }
}
