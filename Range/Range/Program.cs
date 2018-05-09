using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000,
                Type = "RetailCustomer"
            };
            Customer customer2 = new Customer
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000,
                Type = "RetailCustomer"
            };
            Customer customer3 = new Customer
            {
                ID = 103,
                Name = "Rob",
                Salary = 5500,
                Type = "RetailCustomer"
            };
            Customer customer4 = new Customer
            {
                ID = 104,
                Name = "John",
                Salary = 6500,
                Type = "CorporateCustomer"
            };
            Customer customer5 = new Customer
            {
                ID = 105,
                Name = "Sam",
                Salary = 3500,
                Type = "CorporateCustomer"
            };

            // Create 1st list
            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            

            // Create 2nd list for corporate customers 
            List<Customer> listCorporateCustomers = new List<Customer>();
            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);

            // add list 2 to list 1 
            listCustomers.AddRange(listCorporateCustomers);

            Console.WriteLine("*****************");

            // sort 
            Console.Write("This is before sorting\n");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Name);
            }

            Console.WriteLine("*****************");

            listCustomers.Sort();
            Console.Write("This is after sorting\n");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Name);
            }

            listCustomers.Reverse();
            Console.Write("This is salary in decesding order\n");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Name);
            }

            Console.WriteLine("*****************");

            SortByName sortByName = new SortByName();
            listCustomers.Sort(sortByName);
            Console.Write("Sorting by name\n");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Name);
            }

            Console.Write("^^^^^^^^^^^^^^^^^^^^^^^");

            // use delegate to sort
            Comparison<Customer> customerComparer = new Comparison<Customer>(CompareCustomer);

            Console.Write("This is before sorting\n");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.ID);
            }

            // lambda expression
            listCustomers.Sort((x, y) => x.ID.CompareTo(y.ID));

            Console.Write("This is after sorting\n");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.ID);
            }

            Console.Write("^^^^^^^^^^^^^^^^^^^^^^^^^");



            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
            }

            Console.WriteLine("-------------------");

            // from index = 3, I want 2 items
            List<Customer> customers = listCustomers.GetRange(3, 2);
            foreach(Customer c in customers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
            }

            Console.WriteLine("-------------------");

            // insert a list of items, InsertRange()
            listCustomers.InsertRange(0, listCorporateCustomers);

            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
            }

            // Remove the specific index item 
            listCustomers.RemoveAt(0);

            // must use condition if you want to remove all 
            //listCustomers.RemoveAll();

            // remove a lit of customer
            listCustomers.RemoveRange(3, 2);



            // sort the list 
            //listCustomers.Sort(); // this is not gonna work
            // you need to design how you want sort your object 

            // IComparable Interface 
            // CompareTo() function 



            Console.ReadLine();
        }

        // tell how you want sort 
        private static int CompareCustomer(Customer x, Customer y)
        {
            return x.ID.CompareTo(y.ID);
        }
    }
}
