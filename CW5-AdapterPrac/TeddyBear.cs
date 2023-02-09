using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5_AdapterPrac
{
    internal class TeddyBear : IToyBear
    {
        public void hug()
        {
            Console.WriteLine("Teddybear uses hug!\n");
        }
    }
}
