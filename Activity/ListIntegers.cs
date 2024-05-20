using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity
{
    public class ListIntegers
    {
        private List<int> numbers;

        public ListIntegers()
        { 
            numbers = new List<int>();
        }

        public void AddNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                numbers.Add(i);
            }
        }

        public void PrintList()
        { 
            foreach (int number in numbers)
            {
                Console.WriteLine(number + " ");
            }
            
            Console.WriteLine();
        }

        public void RemoveFirstandLast()
        {
            if(numbers.Count > 0)
            {
                numbers.RemoveAt(0);
                if (numbers.Count > 0) 
                {
                    numbers.RemoveAt(numbers.Count - 1);
                }
            }
        }


    }
}
