using Builder.Builders;
using Builder.Directors;
using Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            VehicleBuilder builder = new VehicleBuilder();
            Director director = new Director(builder);

            director.ConstructSedan();

            Vehicle sedan = builder.GetVehicle();

            Console.WriteLine($"Criado um veículo do tipo: {sedan.VehicleType}");


            director.ConstructTruck();

            Vehicle truck = builder.GetVehicle();


            Console.WriteLine($"Criado um veículo do tipo: {truck.VehicleType}");

            director.ConstructSUV();

            Vehicle suv = builder.GetVehicle();


            Console.WriteLine($"Criado um veículo do tipo: {suv.VehicleType} e {suv.Airbags}");

            Console.ReadLine();

        }
    }
}
