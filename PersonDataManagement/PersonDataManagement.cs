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
            Console.WriteLine("\nRetrive top 2 Person less than Age 60 are =");
            Program.DisplayPersonDetails(top2);
        }
    }
}
