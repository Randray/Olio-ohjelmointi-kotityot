using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week4_lab6_task5
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();
            Moterbikes m1 = new Moterbikes();
            Moterbikes m2 = new Moterbikes();

            car1.Name = "Toyta";
            car1.Price = 1200.00;
            car1.SiteCount = 4;
            car1.TireCount = 4;

            car2.Name = "Ferrari";
            car2.Price = 12000.00;
            car2.SiteCount = 2;
            car2.TireCount = 4;

            car3.Name = "BMW";
            car3.Price = 15200.00;
            car3.SiteCount = 5;
            car3.TireCount = 4;

            m1.Name = "Yamaha";
            m1.Price = 5200.00;
            m1.SiteCount = 2;
            m1.TireCount = 2;
            m1.Motorsize = 500;

            m2.Name = "Susuzi";
            m2.Price = 2200.00;
            m2.SiteCount = 1;
            m2.TireCount = 2;
            m2.Motorsize = 50;


            Console.WriteLine("Here are your vehicle: ");
            car1.ToStringCar();
            car2.ToStringCar();
            car3.ToStringCar();
            m1.ToStringMoterBike();
            m2.ToStringMoterBike();

        }
    }
}
