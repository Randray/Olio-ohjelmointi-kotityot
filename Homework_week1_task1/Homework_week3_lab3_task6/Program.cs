using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week3_lab3_task6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Zoo> zoo = new List<Zoo>
            {
                new Zoo {Animal="Lion", Contidion="Healty", Diet="Cows meat", Spicies="Fiiline" },
                new Zoo {Animal="Black bear", Contidion="Healty", Diet="Cows meat", Spicies="Otso" },
                new Zoo {Animal="Mouse", Contidion="Sick", Diet="Wheet", Spicies="Mouse" },
                new Zoo {Animal="Goat", Contidion="Healty", Diet="Grass", Spicies="Goutsy" }
                //jne
            };



            foreach(Zoo s in zoo)
            {
                Console.WriteLine(s.Animal);
                Console.WriteLine(s.Spicies);
                Console.WriteLine(s.Contidion);
                Console.WriteLine(s.Diet);
            }













        }










    }
}
