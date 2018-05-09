using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000,
            };
            Customer customer2 = new Customer
            {
                ID = 119,
                Name = "John",
                Salary = 3500
            };
            Customer customer3 = new Customer
            {
                ID = 110,
                Name = "Pam",
                Salary = 6500
            };

            List<Customer> customers = new List<Customer>(2); // List<> is strongly typed. This is type of Customer. 
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3); // List can change the size
            customers.Insert(0, customer3);

            foreach(Customer c in customers)
            {
                Console.WriteLine(c.ID);
            }

            Console.WriteLine(customers.IndexOf(customer3)); // 0 is the result 

            // the result will be 3
            Console.WriteLine(customers.IndexOf(customer3, 1, 3));// the second parameter means which position you want start to search, 
                                                                 // the third parameter means how many items you want to search
                            
            foreach(Customer c in customers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }

            for (int i = 0; i < customers.Count; i++)
            {
                Customer c = customers[i];
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }

            SavingsCustomer sr = new SavingsCustomer(); // SavingsCustomer is inherited from Customer class. 
            customers.Add(sr); // So it is okay to add sr. it is still strongly typed. 


            Console.WriteLine("-------------------------------------");

            // check if customer is in the list 
            if (customers.Contains(customer3))
            {
                Console.WriteLine("Customer 3 is in the list");
            }
            else
            {
                Console.WriteLine("Customer 3 is not in the list");
            }

            // use lambda expression
            if (customers.Exists(cust => cust.Name.StartsWith("P")))
            {
                Console.WriteLine("Customer3 object exists in the list");
            }
            else
            {
                Console.WriteLine("Customer3 object does not exist in the list");
            }

            // Find() returns one object
            Customer c2 = customers.Find(cust => cust.Salary > 5000);
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c2.ID, c2.Name, c2.Salary);
            //FindAll() 



            // Convert an array to list 
            Customer[] customerArray = new Customer[3];
            customerArray[0] = customer1;
            customerArray[1] = customer2;
            customerArray[2] = customer3;
            List<Customer> listCustomers = customerArray.ToList();
            foreach(Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }

            // convert a list to a dictionary
            Dictionary<int, Customer> dictionary = listCustomers.ToDictionary(x => x.ID);
            foreach (KeyValuePair<int, Customer> kvp in dictionary)
            {
                Customer c = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }




            Console.ReadLine();
        }
    }
}
