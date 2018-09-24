using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Aircraft a10 = new Plane();
            Plane f22 = new Plane();
            Aircraft hh60 = new Helicopter();
            Helicopter ah64 = new Helicopter();

            Tanks m1 = new Tanks();
            Vehicle tank = new Tanks();
            Firearm m1911 = new Firearm();

            m1911.shoot();
            m1.Shoot();

            a10.Fly();
            f22.Move();
            ah64.Maintain();
            tank.Fuel();

        }
    }
}
