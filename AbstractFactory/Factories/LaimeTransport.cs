using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    class LaimeTransport : ITransportFactory
    {
        public IAircraft CreateTransportAirCraft()
        {
            return new Drone();
        }

        public ILandVehicle CreateTransportVehicle()
        {
            return new Scooter();
        }
    }
}
