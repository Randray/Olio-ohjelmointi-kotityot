using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week4_lab6_task5
{
    class Moterbikes:Car
    {

        public double Motorsize { get; set; }

        public void ToStringMoterBike()
        {
            Console.WriteLine("Moterbike: {0}, Price: {1}, Sitecount:{2}, Tirecount{3}, Motersize{4}", Name, Price, SiteCount, TireCount,Motorsize);
        }


    }
}
