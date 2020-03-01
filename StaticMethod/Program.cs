using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    class FunctionCount
    {
        public static int count = 0;
        public static void CountFunction()
        {
            count++;
            Console.WriteLine("CountFunction Hass been called By the Main {0} times",count);
        }
        static void Main(string[] args)
        {
            for(int i = 0; i<10;i++)
            {
                FunctionCount.CountFunction();
            }
            Console.Read();
         }
    }

}
