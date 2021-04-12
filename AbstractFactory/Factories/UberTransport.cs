using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories
{
    class UberTransport : ITransportFactory
    {
        public IAircraft CreateTransportAirCraft()
        {
            return new Airplane();
        }

        public ILandVehicle CreateTransportVehicle()
        {
            return new Car();
        }
    }
}
