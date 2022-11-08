using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverriding
{
    class Pig : Animal
    {
        public override void animalsound()
        {
            Console.WriteLine("The pig says : wee wee");
        }
    }
}
