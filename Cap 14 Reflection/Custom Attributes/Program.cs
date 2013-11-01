﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Vehicle);
            bool defined=t.IsDefined(typeof(VehicleTypeAttribute), false);
        }


    }

    [VehicleType("Auto", Potenza=100)]
    class Vehicle
    {
        
    }

    

    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Struct, Inherited = false, AllowMultiple = true)]
    sealed class VehicleTypeAttribute : Attribute
    {
        // See the attribute guidelines at 
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        readonly string typeDescription;

        // This is a positional argument
        public VehicleTypeAttribute(string typeDescription)
        {
            this.typeDescription = typeDescription;

            // TODO: Implement code here
            
        }

        public string TypeDescription
        {
            get { return typeDescription; }
        }

        // This is a named argument
        public int Potenza { get; set; }
    }
}
