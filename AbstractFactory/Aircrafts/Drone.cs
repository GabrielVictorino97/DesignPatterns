using System;

namespace AbstractFactory.Aircrafts
{
    class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Ligando o drone, checando o vendo, vento OK!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Pronto para decolar");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Drone decolando!");
        }
    }
}
