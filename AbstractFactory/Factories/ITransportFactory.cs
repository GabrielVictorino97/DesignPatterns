using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories
{
    interface ITransportFactory
    {

        IAircraft CreateTransportAirCraft();
        ILandVehicle CreateTransportVehicle();

    }
}
