using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV03
{
    internal class BookFunctions
    {
        public static string GetTitle(Book B)

        {
           if (B is not null) return $"TITLE : {B.Title}"; return "NOT FOUND";
        }

        public static string GetAuthors(Book B)
        {
            if (B is not null)
            {
                string author = string.Join(",", B.Authors);
                return $"Author : {author}";
            }
            return "NOT FOUND";
        }

        public static string GetPrice(Book B)

        {
            if (B is not null)
            {
                return $"Price : {B.Price}";
            }
            return "NOT FOUND";
        }
    }
}
