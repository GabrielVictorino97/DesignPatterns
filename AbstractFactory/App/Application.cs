using AbstractFactory.Aircrafts;
using AbstractFactory.Factories;
using AbstractFactory.LandVehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.App
{
    class Application
    {
        private IAircraft aircraft;
        private ILandVehicle vehicle;

        public Application (ITransportFactory factory)
        {
            aircraft =  factory.CreateTransportAirCraft();
            vehicle =  factory.CreateTransportVehicle();
        }

        public void StartRoute()
        {
            vehicle.StartRoute();
            aircraft.StartRoute();
        }
    }
}
