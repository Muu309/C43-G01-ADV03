using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV03
{
    public delegate string BookDelegate(Book book);

    public class LibraryEngine
    {
        public static void ProcessBook(List<Book> books, BookDelegate fptr)
        {
            foreach (var book in books)
            {
                Console.WriteLine(fptr.Invoke(book));
            }
        }


        public static void ProcessBook2(List<Book> books, Func<Book,string> fptr)
        {
            foreach (var book in books)
            {
                Console.WriteLine(fptr(book));
            }
        }
    }
}
