using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week4_lab6_task5
{
    class Car:Vechile
    {

        public int SiteCount { get; set; }
        public int TireCount { get; set; }

        public void ToStringCar()
        {
            Console.WriteLine("Car: {0}, Price: {1}, Sitecount:{2}, Tirecount{3}",Name,Price,SiteCount,TireCount);
        }

    }
}
