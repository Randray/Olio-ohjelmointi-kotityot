using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week3_lab3_task1
{
    class Kiuas
    {
        private int onoff;
        private double temperature;
        private double humidity;
        private string line;


        public void On()
        {
            Console.Write("Do u want put the kiuas on 1= yes, 0= no");
            line = Console.ReadLine();

            int.TryParse(line, out onoff);

            if (onoff == 1)
            {
                Console.WriteLine("The heat is on");

            }
            else if (onoff == 0)
            {
                Console.WriteLine("The heat is off");
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("What are you doing");
            }

        }

        public void SettingTemperatu()
        {
            Console.Write("Set saunas temperaturat: ");

            line = Console.ReadLine();

            double.TryParse(line, out temperature);

            Console.WriteLine("Temperature is " + temperature);




        }

        public void SettingHumidity()
        {
            Console.Write("Set saunas humidity: ");

            line = Console.ReadLine();

            double.TryParse(line, out humidity);

            Console.WriteLine("Humidity is " + humidity);

            Console.WriteLine("Sauna will be ready in 30 min");


        }





    }
}
