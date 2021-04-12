using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Vehicles
{
    class Bicycle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda com a bicicleta");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciei a corrida com a bicicleta");

        }
    }
}
