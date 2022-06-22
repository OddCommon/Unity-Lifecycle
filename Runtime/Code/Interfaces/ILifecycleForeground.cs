using OddCommon.Messaging;


namespace OddCommon.Lifecycle
{
    [MessagingInterface]
    public interface ILifecycleForeground
    {
        void LifecycleForeground(float timeSinceStartup);
    }
}