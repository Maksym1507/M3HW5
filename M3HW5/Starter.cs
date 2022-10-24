using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3HW5
{
    public class Starter
    {
        public void Run()
        {
            var asyncMethodsClass = new AsyncMethods();
            string helloWorld = asyncMethodsClass.HelloWorldAsync().Result;

            Console.WriteLine(helloWorld);
        }
    }
}
