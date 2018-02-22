using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week3_lab3_task2
{
    class WashingMachine
    {
        private int onoff;
        private int choice;
        private string line;


        public void On()
        {
            Console.Write("Do u want put the washingmachine on 1= yes, 0= no");
            line = Console.ReadLine();

            int.TryParse(line, out onoff);

            if (onoff == 1)
            {
                Console.WriteLine("The washingmaching is on");

            }
            else if (onoff == 0)
            {
                Console.WriteLine("The washingmaching is off");
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("What are you doing");
            }

        }

        public void ChooseYourProgram()
        {
            Console.Write("What program you want to run ");
            Console.Write("1. Colorwash");
            Console.Write("2. Whitewash");
            Console.Write("3. Lightwash");
            line = Console.ReadLine();

            int.TryParse(line, out choice);

            if(choice == 1)
            {
                Console.WriteLine("Your laundry is raedy in a hour");
            }

            else if (choice == 2)
            {
                Console.WriteLine("Your laundry is raedy in 50 min");
            }

            else if (choice == 3)
            {
                Console.WriteLine("Your laundry is raedy in 40 min");
            }

            else
            {
                Console.WriteLine("Unknown command");
            }


        }





    }
}
