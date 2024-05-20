using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity
{
    public class CustomerQueue
    {
        private Queue<string> customers;

        public CustomerQueue()
        { 
            customers = new Queue<string>();
        }

        public void EnqueueCustomer(string names)
        { 
           customers.Enqueue(names);
        }

        public void printCustomers()
        {
            foreach (var name in customers)
            {
                Console.WriteLine(name); 
            }
        }

        public void DequeueCustomers()
        { 
            customers.Dequeue();
        }

    }
}
