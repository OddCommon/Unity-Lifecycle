using OddCommon.Messaging;


namespace OddCommon.Lifecycle
{
    [MessagingInterface]
    public interface ILifecycle : ILifecycleStart, ILifecycleForeground, ILifecycleBackground, ILifecycleQuit
    {
    
    }
}