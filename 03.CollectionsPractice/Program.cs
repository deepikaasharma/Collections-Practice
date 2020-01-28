using System;
using System.Collections.Generic;

namespace _03.CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            int[] numArray = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            string[] stringArray = new string[] {"Tim", "Martin", "Nikki", "Sara"};
            bool[] boolArray = new bool[10];
            boolArray = new bool[] {true,false,true,false,true,false,true,false,true,false};

            // List
            List<string> flavors = new List<string> {"Peanut Butter Cup", "Cookie Dough", "Birthday Cake", "Oreo", "Orange Sherbert", "Raspberry"};
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);

            // Dictionary
            Dictionary<string,string> iceCream = new Dictionary<string,string>();
            foreach (string name in stringArray)
            {
                iceCream.Add(name, null);
            }

            foreach (var name in iceCream)
            {
                Console.WriteLine(name.Key + " - " + flavors[0]);
            }
        }
    }
}
