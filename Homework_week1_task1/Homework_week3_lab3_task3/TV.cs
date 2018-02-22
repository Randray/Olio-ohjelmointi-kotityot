using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week3_lab3_task3
{
    class TV
    {
        private int onoff;
        private int choice;
        private string line;


        public void On()
        {
            Console.Write("Do u want put the TV on 1= yes, 0= no");
            line = Console.ReadLine();

            int.TryParse(line, out onoff);

            if (onoff == 1)
            {
                Console.WriteLine("The TV is on");

            }
            else if (onoff == 0)
            {
                Console.WriteLine("The TV is off");
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("What are you doing");
            }

        }
        //This is a very old TV :)
        public void ChooseYourProgram()
        {

            while (true)
            {
                Console.WriteLine("What program you want to watch");
                Console.WriteLine("1. Yle1");
                Console.WriteLine("2. Yle2");
                Console.WriteLine("3. MTV3");
                Console.WriteLine("4. Turn off?");

                line = Console.ReadLine();

                int.TryParse(line, out choice);

                if (choice == 1)
                {
                    Console.WriteLine("Nature document is on ");
                }

                else if (choice == 2)
                {
                    Console.WriteLine("History document is on");
                }

                else if (choice == 3)
                {
                    Console.WriteLine("CSI Miami is on");
                }
                else if (choice == 4)
                {
                    System.Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("Static");
                }

            }
        }
























    }
}
