using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week3_lab3_task4
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public void PrintData()
        {

            Console.WriteLine(Name);
            Console.WriteLine(Speed);
            Console.WriteLine(Tyres);
        }
        public void ToStringVehicle()
        {
            Console.WriteLine("Name: {0}, Speed: {1}, Tyres: {2}",Name,Speed,Tyres);
        }



    }
}
