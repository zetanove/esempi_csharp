﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap7_Inheritance
{
    class StreetVehicle: Vehicle
    {
        protected byte wheels;


        public StreetVehicle(byte wheels)
        {
            this.wheels = wheels;
            currentSpeed = 0;
        }
    }
}
