using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week3_lab3_task4
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle car = new Vehicle();



            car.Name = "Audi";
            car.Speed = 200;
            car.Tyres = 4;

            car.ToStringVehicle();
            car.PrintData();

            car.Name = "Audi";
            car.Speed = 20;
            car.Tyres = 3;

            car.ToStringVehicle();
            car.PrintData();





        }
    }
}
