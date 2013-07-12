using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //snowcrashCLR.SnowCrashCLR.test();
            snowcrashCLR.Blueprint blueprint;
            snowcrashCLR.SnowCrashCLR.parse("# My API\nDescription is here\n", out blueprint);

            Console.Write("API name: ");
            Console.WriteLine(blueprint.name);

            Console.Write("API description: ");
            Console.WriteLine(blueprint.description);
        }
    }
}
