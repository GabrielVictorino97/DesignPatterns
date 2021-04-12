using Bridge.Plataforms;
using System;

namespace Bridge.Transmissions
{
    class AdvancedLive : Live
    {
        public AdvancedLive(IPlataform plataform): base(plataform)
        {

        }

        public void Subtitle()
        {
            Console.WriteLine("Legendas ativadas");
        }

        public void Comments()
        {
            Console.WriteLine("Comentarios liberados");
        }

        public void Records()
        {
            Console.WriteLine("A live está sendo gravada");
        }

    }
}
