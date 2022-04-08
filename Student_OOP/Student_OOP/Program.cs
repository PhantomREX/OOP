using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student s = new Student();
            s.Name = "Yasin";
            s.Surname = "TOP";
            s.No = 453;
            s.Class = "Laboratuvar 3";

            Console.WriteLine("Öğrenci Bilgileri");
            Console.WriteLine("----------------------");
            Console.WriteLine("Adı: " + s.Name);
            Console.WriteLine("Soyadı: " + s.Surname);
            Console.WriteLine("No: " + s.No);
            Console.WriteLine("Sınıfı: " + s.Class);


            Console.ReadKey();





        }
    }
}
