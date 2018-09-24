using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Firearm
    {
        public virtual void shoot()
        {
            Console.WriteLine("pew pew");
            
        }

        public virtual void clean()
        {
            Console.WriteLine("firearm is clean enough");
        }
        public virtual void Reload()
        {
            Console.WriteLine("firearm is ful of rounds");
        }
    }
}
