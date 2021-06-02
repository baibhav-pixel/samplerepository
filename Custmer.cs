using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Custmer
    {
        string name;
        int savings;

        public void acceptdet(string n ,int s)
        {
            Console.WriteLine("Enter name and savings");
            name = n;
            savings = s;
            
        }

        public void TraceInfor(Exception e)
        {
            Trace.Listeners.Add(new TextWriterTraceListener("traced.log"));
            Trace.WriteLine(e.Message + " " + e.Source + " " + e.StackTrace);
            Trace.WriteLine("traced ERRORS at " + DateTime.Now);
            Trace.WriteLine("Traicing done by Decoders");
            Trace.Flush();
            Trace.Close();
        }

        public void getdetails()
        {
            Console.WriteLine("The name and address is ");
            Console.WriteLine(name);
            Console.WriteLine(savings);
        }
    }
}
