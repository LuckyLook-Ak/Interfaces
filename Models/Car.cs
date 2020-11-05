using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    class Car : AutoMobile
    {
        public Car()
        {

        }
        public Car(bool IsOn)
        {
            this.IsOn = IsOn;
        }

        public override void SteerLeft()
        {
            Console.WriteLine("the car is steering left");
        }
        public void Break()
        {
            Console.WriteLine("The car is breaking");
        }
        public void Reverse()
        {
            Console.WriteLine("The car is reversing");
        }
    }
}
