using System;
using System.Threading;

namespace CallingProtocols
{
    public class TrafficLight:
        IGreenLight,
        IYellowLight,
        IRedLight
    {
        private TrafficLight()
        {

        }

        public static IGreenLight New
        {
            get
            {
                return new TrafficLight();
            }
        }

        public IYellowLight TurnGreenLight(TimeSpan interval)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("GREEN LIGHT IS TURNED ON");

            Thread.Sleep((int)interval.TotalMilliseconds);

            return this;
        }

        public void TurnRedLight()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("RED LIGHT IS TURNED ON");
            Console.ResetColor();
        }

        public IRedLight TurnYellowLight(TimeSpan interval)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("YELLOW LIGHT IS BLINKING");
                Thread.Sleep((int)interval.TotalMilliseconds);
            }

            return this;
        }
    }
}
