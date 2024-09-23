using System;
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

            Console.ReadKey();

        }
    }
}
