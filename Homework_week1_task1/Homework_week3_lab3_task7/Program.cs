using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week3_lab3_task7
{
    class Program
    {
        static void Main(string[] args)
        {

            CD ng = new CD();

            ng.Artsit = "Nightwise";
            ng.Name = "Endless Forms Most Beatifull";
            ng.Genre = "Symphonic metal";
            ng.Price = 19.9;

            Console.WriteLine("CD:");
            Console.WriteLine("-Artist: "+ ng.Artsit);
            Console.WriteLine("-Name: " + ng.Name);
            Console.WriteLine("-Genre: " + ng.Genre);
            Console.WriteLine("-Price: " + ng.Price);
            Console.WriteLine("Songs:");
            ng.GetTheSongsOut();

        }
    }
}
