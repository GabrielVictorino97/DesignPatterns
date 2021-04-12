using Bridge.Plataforms;
using Bridge.Transmissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {

        static void StartLive(IPlataform plataform)
        {
            Console.WriteLine("Aguarde...");

            Live live = new Live(plataform);
            live.Broadcasting();
            live.Result();
        }
        static void StartLiveAdvanced(IPlataform plataform)
        {
            Console.WriteLine("Aguarde...");

            AdvancedLive live = new AdvancedLive(plataform);
            live.Broadcasting();
            live.Subtitle();
            live.Comments();
            live.Records();
            live.Result();

        }
        static void Main(string[] args)
        {

            StartLiveAdvanced(new YouTube());
            Console.WriteLine("");
            StartLive(new Facebook());
            Console.WriteLine("");
            StartLive(new TwitchTV());
            Console.WriteLine("");
            StartLiveAdvanced(new TheLive());
            Console.WriteLine("");

            Console.ReadLine();

        }
    }
}
