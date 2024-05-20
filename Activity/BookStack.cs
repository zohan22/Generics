using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity
{
    public class BookStack
    {
        private Stack<string> books;

        public BookStack()
        { 
            books = new Stack<string>();
        }

        public void PushBooks(string book)
        {
            books.Push(book);
        }

        public void PrintAllBooks()
        {
            foreach (var item in books)
            {
                Console.WriteLine(item);
            }
        }

        public void PopBooks()
        {
            books.Pop();
        }
    }
}
