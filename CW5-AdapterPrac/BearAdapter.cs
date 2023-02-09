using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5_AdapterPrac
{
    public class BearAdapter : IToyBear
    {
        // bear adaptee
        IBear bear;

        // bear constructor
        public BearAdapter(IBear bear)
        {
            this.bear = bear;
        }

        // hug override
        public void hug()
        {
            bear.maul();
        }
    }
}
