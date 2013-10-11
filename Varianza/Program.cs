using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varianza
{

    class Vehicle 
    {
        public double Speed { get; set; }
        public virtual void Accelerate()
        {
            Console.WriteLine("vroom");
        }
    }

    class Car : Vehicle
    {
    }

    class Moto : Vehicle
    {
    }

    class CarBuilder : IBuilder<Car>
    {
        public Car Build()
        {
            return new Car();
        }
    }

    class VehicleCruiseControl : ICruiseControl<Vehicle>
    {
        public void SetSpeed(Vehicle obj, double speed)
        {
            obj.Speed = speed;
        }
    }

    class Program
    {
        static void StartRun(List<Vehicle> veicoli)
        {
            foreach (Vehicle v in veicoli)
                v.Accelerate();
        }

        static void StartRun<T>(List<T> veicoli) where T: Vehicle
        {
            foreach (Vehicle v in veicoli)
                v.Accelerate();
        }

        static void StartRun2(IEnumerable<Vehicle> veicoli)
        {
            foreach (Vehicle v in veicoli)
                v.Accelerate();
        }

        static void Main(string[] args)
        {
            Car ferrari = new Car();
            Vehicle vehicle = ferrari; //assignment compatibility

            Car[] carArray=new Car[10];
            carArray[0] = ferrari;
            Vehicle[] vehicleArray=carArray; //array covarianza

            //vehicleArray[1] = new Moto(); //errore 

            List<Car> macchine = new List<Car>();
            List<Vehicle> veicoli = new List<Vehicle>();
            //List<Vehicle> veicoli = macchine; //le classi generiche sono invarianti

            macchine.Add(new Car());
            macchine.Add(new Car());
            StartRun<Car>(macchine);
            StartRun(macchine);

            CarBuilder cb = new CarBuilder();
            Car car1=cb.Build();
            IBuilder<Vehicle> vb = cb;
            Vehicle vehicle1= vb.Build();


            StartRun2(macchine);

            VehicleCruiseControl vcc = new VehicleCruiseControl();
            vcc.SetSpeed(new Vehicle(), 123);

            ICruiseControl<Car> ccCar = vcc;
            ccCar.SetSpeed(new Car(), 100);

        }
    }
}
