using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week3_lab3_task7
{
    class CD
    {

        public string Artsit { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }

      private string[] Songs= {

            " Shudder Before the Beautiful - 06:29",
            " Weak Fantasy - 05:23",
            " Elan - 04:45",
            " Yours Is an Empty Hope - 05:34",
            " Our Decades in the Sun - 06:37",
            " My Walden - 04:38",
            " Endless Forms Most Beautiful - 05:07",
            " Edema Ruh - 05:15",
            " Alpenglow - 04:45",
            " The Eyes of Sharbat Gula - 06:03",
            " The Greatest Show on Earth - 24:00"


        });
        
       
       
        public void GetTheSongsOut()
        {
            foreach (string songs in Songs)
            {
                Console.Write("--- Name: ");
                Console.WriteLine(songs);


            }
        }
       






    }
}
