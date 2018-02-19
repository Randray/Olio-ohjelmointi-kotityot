using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week4_lab6_task4
{
    class Book:Stuff
    {

        
        public int Pagecount { get; set; }

        public void ToYou()
        {
            Console.WriteLine("Name: "+ Name );

            Console.WriteLine("Pagecount: " + Pagecount);


        }

    }
}
