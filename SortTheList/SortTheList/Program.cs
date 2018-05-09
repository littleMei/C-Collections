using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTheList
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 8, 7, 5, 2, 3, 4, 9, 6 };

            Console.WriteLine("numbers before sorting\n");
            foreach(int n in numbers)
            {
                Console.Write(n + " ");

            }

            numbers.Sort();

            Console.WriteLine("\nnumbers after sorting\n");
            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }

            numbers.Reverse();

            Console.WriteLine("\nnumbers in descending order\n");
            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }

            List<string> alphabets = new List<string>() { "B", "F", "D", "E", "A", "C" };
            Console.WriteLine("Alphabets before sorting");
            foreach(string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            alphabets.Sort();
            Console.WriteLine("Alphabets after sorting");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            alphabets.Reverse();
            Console.WriteLine("Alphabets in decending order");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }




            Console.ReadLine();

        }
    }
}
