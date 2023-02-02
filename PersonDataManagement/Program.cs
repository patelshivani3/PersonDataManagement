using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    internal class Program
    {  
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Person Data Management.");
            List<Person> listOfPerson = new List<Person>();
           
            //UC1 - Create Person Class and Add the Data
            AddingPersonDetails(listOfPerson);
            
            //UC2 - Retrive Top 2 record which are Less than 60
            PersonDataManagement.RetrieveTop2LessThan60(listOfPerson);
            
            //UC3 - Retrive Records having Age betwwen 13 to 18
            PersonDataManagement.AgeBetween13to18(listOfPerson);
            
            //UC4 - Retrive Average age from the list
            PersonDataManagement.AverageAge(listOfPerson);
            
            //UC5 - Check Name is present or not
            PersonDataManagement.CheckName(listOfPerson, "Yash");

            //UC6 - Skip records less than age 60
            PersonDataManagement.SkipAgeLessThan60(listOfPerson);

            Console.ReadLine();
        }
        public static void AddingPersonDetails(List<Person> list)
        {
            list.Add(new Person() { SSN = 1, Name = "Shivani", Address = "Delhi", Age = 25 });
            list.Add(new Person() { SSN = 2, Name = "Abhishek", Address = "Mumbai", Age = 27 });
            list.Add(new Person() { SSN = 3, Name = "Yash", Address = "Pune", Age = 12 });
            list.Add(new Person() { SSN = 4, Name = "Dhruv", Address = "Nagpur", Age = 70 });
            list.Add(new Person() { SSN = 5, Name = "siya", Address = "Banglore", Age = 30 });
            list.Add(new Person() { SSN = 6, Name = "nitya", Address = "Bhopal", Age = 62 });
            list.Add(new Person() { SSN = 7, Name = "Disha", Address = "Jaipur", Age = 15 });
            DisplayPersonDetails(list);
        }
        public static void DisplayPersonDetails(IEnumerable<Person> list)
        {
            foreach (Person person in list)
            {
                Console.WriteLine(person);
            }
        }
    }
}
