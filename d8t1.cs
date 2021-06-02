using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8T1
{
    class d8t1
    {
        static void Main(string[] args)
        {
            int[] arr = { 98, 76, 99, 32, 77 };
            int i, j, temp;
            Console.Write("Elements: \n");

            for(i=0;i<5;i++)
            {
                for(j=i+1;j<5;j++)
                {
                    if(arr[i]>arr[j])//changed j+1 to j back
                    {
                        temp = arr[i]; //temp =99 at i=3; used the local's window
                        arr[i] = arr[j];
                        arr[j] = temp;//changed to temp
                    }
                    
                }
            }
            for(i=0;i<arr.Length;i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.Write("\n\n");
            Console.ReadKey();
        }
    }
}
