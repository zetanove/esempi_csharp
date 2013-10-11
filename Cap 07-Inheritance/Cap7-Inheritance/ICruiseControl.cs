using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap7_Inheritance
{

    public interface ICruiseControl
    {
        int? CruiseSpeed { get; }
        void ResetCruise();
        void SetCruise(int speed);
        void StartControl();
    }

    public struct Coordinate
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public interface IAutoPilot : ICruiseControl
    {
        Coordinate Destination { get; set; }
        void Activate();
        void Deactivate();
    }
}
