using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week3_lab3_task5
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> st = new List<Student>
            {

                new Student {Name="Mari",Email="Mari.Marisia@jamk.fi", Age=21, Gender='F',StudentID="L2345" },
                new Student {Name="Janne",Email="Janne.Junittelia@jamk.fi", Age=26, Gender='M',StudentID="K5467" },
                new Student {Name="Pasi",Email="Pasi.Paasaja@luukku.fi", Age=45, Gender='T',StudentID="T2324" },
                new Student {Name="Janina",Email="Janina.Jankuttaja@luukku.fi", Age=28, Gender='F',StudentID="L2375" },
                new Student {Name="Kaisa",Email="Kaisa.Kalasta@luukku.fi", Age=12, Gender='F',StudentID="I1293" }

            };


            foreach (Student s in st)
            {
                Console.WriteLine(s.Name);
                Console.WriteLine(s.Email);
                Console.WriteLine(s.Age);
                Console.WriteLine(s.Gender);
                Console.WriteLine(s.StudentID);
            }






        }
    }
}
