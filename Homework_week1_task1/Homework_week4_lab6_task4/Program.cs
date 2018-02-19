using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week4_lab6_task4
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book();
            CD cd = new CD();

            cd.Name = "Some generic pop album";

            book.Name = "Aladin";
            book.Pagecount = 321;
            Console.WriteLine("Here is all of my content "); cd.ToLeather(); book.ToYou();


        }
    }
}
