using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlp
{
    internal class Test
    {
        public string typtestu { get; set; }
        public int pocettestu { get; set; }
        public int pocetzaku { get; set; }

        public Test()
        {
            Console.WriteLine();
        }
        public void vlastnosti()
        {
            Console.WriteLine($"{typtestu}, {pocettestu}, {pocetzaku}");
        }

    }
}
