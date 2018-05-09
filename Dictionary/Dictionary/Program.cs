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

            List<Customer> customers = new List<Customer>(2);
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            








            Dictionary<int, Customer> dictionaryCustomer = new Dictionary<int, Customer>();
            dictionaryCustomer.Add(customer1.ID, customer1);
            dictionaryCustomer.Add(customer2.ID, customer2);
            dictionaryCustomer.Add(customer3.ID, customer3);

            // Vedio 73
            // TryGetValue() method
            // the return type is boolean
            Customer cust2;
            if (!dictionaryCustomer.TryGetValue(101, out cust2)) // out put value to cust
            {
                Console.WriteLine("ID = {0},Name = {1},Salary = {2},", cust2.ID, cust2.Name, cust2.Salary);
            }
            else
            {
                Console.WriteLine("Key is not available");

            }

            //Count() method
            Console.WriteLine("The total count of the dictionary is{0}", dictionaryCustomer.Count());
            // There are 2 overloaded version of this Count() method 
            Console.WriteLine("The total count of the dictionary is{0}", dictionaryCustomer.Count(kvp => kvp.Value.Salary > 400));
            //

            // remove an item from dictionary
            dictionaryCustomer.Remove(109); // if the key does not exit, you would not get an exception. 
                                            // remove all the items from the dictionary, you can use clear
                                            //dictionaryCustomer.Clear();

            // use linq expression 
            Customer[] customer = new Customer[3];
            customer[0] = customer1;
            customer[1] = customer2;
            customer[2] = customer3;
             // key is the customer id, the value is the customer itself 
            Dictionary<int, Customer> dic = customer.ToDictionary(cust => cust.ID, cust => cust);

            foreach (KeyValuePair<int, Customer> kvp in dic)
            {
                Console.WriteLine("key = {0},",kvp.Key);
                Customer cust = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }


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
