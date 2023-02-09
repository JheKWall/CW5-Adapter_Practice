using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5_AdapterPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a bear instance holding a grizzly
            IBear grizzly = new Grizzly();

            // create a toybear instance holding a teddybear
            IToyBear teddybear = new TeddyBear();

            // create a toybear instance with the bearadapter, using your grizzly as the constructor argument
            IToyBear adapter = new BearAdapter(grizzly);

            // run through all bear functions with the grizzly
            Console.WriteLine("Grizzly/Bear methods:\n" + "1. maul() - ");
            grizzly.maul();
            Console.WriteLine("2. hibernate() - ");
            grizzly.hibernate();

            // run through all toybear functions with your teddybear
            Console.WriteLine("TeddyBear/ToyBear methods:\n" + "1. hug() - ");
            teddybear.hug();

            //run through all toybear functions with your bearadapter
            /// expected output: grizzly's maul()
            Console.WriteLine("ToyBear/BearAdapter methods:\n" + "1. hug() - ");
            adapter.hug();

            // exit prompt
            Console.ReadKey();
        }
    }
}
