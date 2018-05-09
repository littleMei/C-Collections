using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000,
            };

            Customer customer2 = new Customer()
            {
                ID = 110,
                Name = "Pam",
                Salary = 6500,
            };

            Customer customer3 = new Customer()
            {
                ID = 119,
                Name = "John",
                Salary = 3500,
            };

            Dictionary<int, Customer> dictionaryCustomer = new Dictionary<int, Customer>();
            dictionaryCustomer.Add(customer1.ID, customer1);
            dictionaryCustomer.Add(customer2.ID, customer2);
            dictionaryCustomer.Add(customer3.ID, customer3);

            Customer customer119 = dictionaryCustomer[119];

            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer119.ID, customer119.Name, customer119.Salary);

            // you can use var instead of KeyValuePair<>, but this is more clear
            foreach(KeyValuePair<int, Customer> customerKeyValuePair in dictionaryCustomer)
            {
                Console.WriteLine("ID = {0}", customerKeyValuePair.Key);
                Customer cust = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
                Console.WriteLine("--------------------------");
            }

            // the keys in the dictionary must be unique
            foreach(int key in dictionaryCustomer.Keys)
            {
                Console.WriteLine("The key in the dictionary is {0}", key);
                Console.WriteLine("**********");
            }

            if (!dictionaryCustomer.ContainsKey(customer1.ID))
            {
                dictionaryCustomer.Add(customer1.ID, customer1);
            }

            Console.ReadLine();
        }
    }
}
