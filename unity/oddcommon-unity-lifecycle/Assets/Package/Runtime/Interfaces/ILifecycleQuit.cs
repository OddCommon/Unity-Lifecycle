using OddCommon.Messaging;


namespace OddCommon.Lifecycle
{
    [MessagingInterface]
    public interface ILifecycleQuit
    {
        void LifecycleQuit(float timeSinceStartup);
    }
}