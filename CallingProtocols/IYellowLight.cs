using System;

namespace CallingProtocols
{
    public interface IYellowLight
    {
        IRedLight TurnYellowLight(TimeSpan interval);
    }
}