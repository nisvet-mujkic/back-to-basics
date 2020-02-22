using System;

namespace CallingProtocols
{
    public interface IGreenLight
    {
        IYellowLight TurnGreenLight(TimeSpan interval);
    }
}