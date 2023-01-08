using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Homework_5
{
    internal class Quadcopter : IFlyingRobot, IChargeable
    {
        List<string> components = new List<string> {"rotor1","rotor2","rotor3","rotor4"};


        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }

        public List<string> GetComponents()
        {
            return components;
        }

        public string GetInfo()
        {
            return components.Count.ToString();
        }
    }
}
