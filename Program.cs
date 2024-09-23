using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 34, 12, 15, 12, 13, 11, 31, 32, 64, 23 };

            bool conditionCheck=numbers.Any(x => x > 0);//Any Method Predicate that returns a bool

            Predicate<int> numCondition = x => x > 20;//Predicate checks a condition ant return a bool type ,Used usually for find findall Linq

            List <int> filteredData=numbers.FindAll(numCondition);

            List<Products> products = new List<Products> //Created A list With the Class Products where types are Name and Price Properties of The Class Products
            {
                new Products{Name="Banana",Price=1},//Inserted to the Products List
                new Products{Name="Orange",Price=3},
                new Products{Name="Fruit",Price=4},
                new Products{Name="Lemon",Price=10},
            };

            products.Add(new Products { Name = "Cucember", Price = 2 });//Addition to List

            List<Products> productsUnder5 = products.Where(x => x.Price < 5).ToList();//Used The Where Method wich Returns an Einumerable than coverted to a list 

            foreach(var cheapProd in productsUnder5)
            {
                Console.WriteLine(cheapProd.Name);
            }

            StudentHashtable student = new StudentHashtable();

           Dictionary<int,string> athlete = new Dictionary<int, string>();

            athlete.Add(100, "Abdurri");
            athlete.Add(101, "Qemoli");
            athlete.Add(102, "Kasemi");

            athlete[100] = "Abdyli";
            

            foreach(KeyValuePair<int,string> kvp in athlete)
            {
                Console.WriteLine($"Index:{kvp.Key}:{kvp.Value}");
            }

            if (!athlete.ContainsKey(100))
            {
                athlete[100] = "Something";

            }
            else
            {
                Console.WriteLine("Already Existi at index 100");
            }

            Dictionary<int,Employee> employee= new Dictionary<int, Employee>();

            employee.Add(1, new Employee(1, "Uesli", "Manager"));
            employee.Add(2, new Employee(1, "Bruno", "Manager"));
            employee.Add(3, new Employee(1, "Enso", "Manager"));


            foreach(var employer in employee)
            {
                Console.WriteLine($"Index:{employer.Key},Employee Name:{employer.Value.Name},Position:{employer.Value.Title}");
            }

            if(employee.TryGetValue(1,out Employee emp))
            {
                Console.WriteLine(emp.Name);
            }
            
            Console.ReadKey();

        }
    }
}
