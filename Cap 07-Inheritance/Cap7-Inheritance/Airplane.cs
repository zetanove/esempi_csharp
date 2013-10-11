using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap7_Inheritance
{
    class Airplane: FlyingVehicle
    {
        public Airplane()
        {
            maxSpeed = 1000;
        }

        public new void TakeOff()
        {
            Accelerate();
            Console.WriteLine("Airplane takeoff");
            this.currentSpeed += 5;
            if (currentSpeed > maxSpeed)
                currentSpeed = maxSpeed;
        }



    }

    public class Helicopter : FlyingVehicle
    {
        public override void TakeOff()
        {
            throw new NotImplementedException();
        }
    }
}
