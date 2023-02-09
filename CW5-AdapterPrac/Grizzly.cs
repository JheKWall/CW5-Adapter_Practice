using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5_AdapterPrac
{
    internal class Grizzly : IBear
    {
        public void maul()
        {
            Console.WriteLine("Grizzly uses maul!\n");
        }

        public void hibernate()
        {
            Console.WriteLine("Grizzly uses hibernate!\n");
        }
    }
}
