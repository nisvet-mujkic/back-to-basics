using System;

namespace CallingProtocols
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficLight.New.TurnGreenLight(TimeSpan.FromMinutes(0.1))
                            .TurnYellowLight(TimeSpan.FromMinutes(0.02))
                            .TurnRedLight();
        }
    }
}
