using UnityEngine;
using OddCommon.Messaging;


namespace OddCommon.Lifecycle
{
    [MessagingInterface]
    public interface ILifecycleStart
    {
        void LifecycleStart(float timeSinceStartup);
    }
}