using Bridge.Plataforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Transmissions
{
    class Live : ITransmission
    {
        protected IPlataform plataform;
        public Live (IPlataform plataform)
        {
            this.plataform = plataform;
        }


        public void Broadcasting()
        {
            Console.WriteLine($"Iniciando a transmissão na {plataform}");
        }

        public void Result()
        {
            Console.WriteLine("**** ON AIR ****");
        }
    }
}
