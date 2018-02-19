using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week4_lab6_task4
{
    class CD:Stuff
    {

        List<string> songs = new List<string>();

        public void ToLeather()
        {
            Console.WriteLine("CD: "+ Name);

            foreach (string song in songs)
            {
                Console.WriteLine("Songs: " + song);
            }
        }


    }
}
