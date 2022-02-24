using OddCommon.Messaging;


namespace OddCommon.Lifecycle
{
    [MessagingInterface]
    public interface ILifecycleBackground
    {
        void LifecycleBackground(float timeSinceStartup);
    }
}