using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    class MotorBike : AutoMobile
    {
       
        public MotorBike()
        {

        }

        public MotorBike(bool IsOn)
        {
            this.IsOn= IsOn;
        }
        public override void SteerLeft()
        {
            Console.WriteLine("the motorbike is steering left");
        }
        public void Break()
        {
            Console.WriteLine("The motorbike is breaking");
        }


    }
}
