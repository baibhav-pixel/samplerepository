using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class D8T5
    {
        static void Main(string[] args)
        {
            Custmer obj = new Custmer();
            Console.WriteLine("Enter name, savings");
            try
            {
                string n = Console.ReadLine();
                int s = Convert.ToInt32(Console.ReadLine());
                obj.acceptdet(n, s);
                obj.getdetails();
            }
            catch(Exception e)
            {
                Console.WriteLine("Some error occurred");
                obj.TraceInfor(e);
            }
            Console.ReadKey();
        }
    }
}
